using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yer_istasyonu
{
    public partial class Form2 : Form
    {
        public string Port { get; private set; }
        public string Baudrate { get; private set; }
        public string Stop { get; private set; }
        public string Parity { get; private set; }
        public Form2()
        {
            InitializeComponent();
            string[] stopbits = { "One", "Two" };
            string[] baudrate = { "9600", "14400", "19200", "115200" };
            string[] ports = SerialPort.GetPortNames();
            string[] parity = { "None", "Odd", "Even" };
            comboBox1.Items.AddRange(ports);
            comboBox2.Items.AddRange(baudrate);
            comboBox3.Items.AddRange(stopbits);
            comboBox4.Items.AddRange(parity);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Port = (string)comboBox1.SelectedItem;
            Baudrate = (string)comboBox2.SelectedItem;
            Stop = (string)comboBox3.SelectedItem;
            Parity = (string)comboBox4.SelectedItem;
           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
