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
                serialPort1.PortName = Convert.ToString(comPortList.SelectedItem);
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
        }
    }
}
