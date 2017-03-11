using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace cctalk
{
    public partial class Form1 : Form
    {

        private int incrementor;
        private char[] data = new char[200000];
        private string[] output = new string[256];
        private byte[] outputByte = new byte[256];
        string[] tab = new string[10000]; //array for rewrite vallues in richtextbox to HEX DEC ASCII
        List<int> sended = new List<int>();

        public Form1()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.GetEncoding(28591);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comPortList.SelectedIndex = 0;
        }

        private void comPortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comPortList.SelectedIndex == 0)
            {
                string[] ports = SerialPort.GetPortNames();
                comPortList.Items.Clear();
                comPortList.Items.Add("(Scan...)");
                foreach(string port in ports)
                    comPortList.Items.Add(port);
            }
            else
            {
                try
                {
                    serialPort1.PortName = Convert.ToString(comPortList.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                comPortList.BackColor = Color.LightGreen;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString());
            }
        }

        private void closePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                comPortList.BackColor = Color.OrangeRed;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //odbiór danycht


            //copied from serialport.sln project
            try
            {
                incrementor = serialPort1.BytesToRead;
                serialPort1.Read(data, 0, incrementor);
                this.Invoke(new EventHandler(DisplayText_temp));

            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred: " + ex.ToString());
            }

        }

        //---------------------------Reading-------------------

        private void DisplayText_temp(object sender, EventArgs e)
        {
            for (int i = 0; i < incrementor; i++)
            {
                if (sended.Count != 0)
                {
                    for (int j = 0; j < sended.Count; j++)
                    {
                        if (Convert.ToInt16(data[i]) == sended[j])
                        {
                            sended.RemoveAt(j);
                            //richTextBox1.SelectionStart = richTextBox1.Text.Length;

                           // richTextBox1.SelectionColor = Color.Red;
                            break;
                        }
                    }
                     continue;
                }
                /*else
                    richTextBox1.SelectionColor = Color.Black;*/
                if (radioButtonAscii.Checked)
                {
                    richTextBox1.Text += data[i];
                    richTextBox1.Text += ' ';
                }
                else if (radioButtonHex.Checked)
                {
                    if(checkBox0X.Checked)
                        richTextBox1.Text += "0x"+ Convert.ToInt64(data[i]).ToString("X2") + ' ';
                    else
                        richTextBox1.Text += Convert.ToInt64(data[i]).ToString("X2") + ' ';
                }
                else if(radioButtonDEC.Checked)
                {
                    richTextBox1.Text += Convert.ToInt32(data[i]);
                    richTextBox1.Text += ' ';
                }

                if(checkBoxFormat.Checked)
                {
                    if (i % trackBar1.Value == 0)
                        richTextBox1.Text += '\n';
                }
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.SelectionLength = 1;
            }
            if(!checkBoxFormat.Checked)
                richTextBox1.Text+=('\n');
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            incrementor = 0;
            //textBox1.Text += st;
        }

        //---------------------------------Sending---------------------------

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonAsciiSend.Checked)
                    serialPort1.Write(textBoxToSend.Text.ToString());
                else if (radioButton2.Checked)
                {
                    output = textBoxToSend.Text.Split(' ');
                    for (int i = 0; i < output.Length; i++)
                    {
                        outputByte[i] = Convert.ToByte(output[i]);
                        sended.Add( Convert.ToInt16(output[i]));
                    }
                    serialPort1.Write(outputByte, 0, output.Length);
                    Array.Clear(output, 0, output.Length);
                    Array.Clear(outputByte, 0, outputByte.Length);
                }
                textBoxToSend.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void textBoxToSend_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendButton.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                textBoxToSend.Text = "";
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Value: " + trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void radioButtonDEC_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDEC.Checked&&richTextBox1.Text.Length>0)
            {
                tab = richTextBox1.Text.Split(' ');
                 
                for(int i =0; i<tab.Length;i++)
                {
                    if (tab[i] != " "&&tab[i]!="\n")
                    {
                        byte hexValue = byte.Parse(tab[i], System.Globalization.NumberStyles.HexNumber);
                        tab[i] = hexValue.ToString("D");
                    }
                }
                richTextBox1.Text = "";
                for(int i =0;i<tab.Length;i++)
                {
                    richTextBox1.Text += tab[i];
                    if (tab.Length - i > 1) richTextBox1.Text += " ";
                }
                Array.Clear(tab, 0, tab.Length);
            }
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonHex.Checked)
            {
                checkBox0X.Enabled = true;
                tab = richTextBox1.Text.Split(' ');

                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] != " " && tab[i] != "\n")
                    {
                        int decValue = int.Parse(tab[i]);
                        tab[i] = decValue.ToString("X");
                    }
                }
                richTextBox1.Text = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    richTextBox1.Text += tab[i];
                    if (tab.Length - i > 1) richTextBox1.Text += " ";
                }
                Array.Clear(tab, 0, tab.Length);
            }
            else
            {
                checkBox0X.Checked = false;
                checkBox0X.Enabled = false;
            }
        }
    }
}
