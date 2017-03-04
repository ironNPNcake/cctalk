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

        public Form1()
        {
            InitializeComponent();
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

        private void DisplayText_temp(object sender, EventArgs e)
        {
            for (int i = 0; i < incrementor; i++)
            {
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
                if(checkBoxFormat.Checked)
                {
                    if (i % trackBar1.Value == 0)
                        richTextBox1.Text += '\n';
                }
            }
            if(!checkBoxFormat.Checked)
                richTextBox1.Text+=('\n');
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            incrementor = 0;
            //textBox1.Text += st;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine(textBoxToSend.Text.ToString());
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
    }
}
