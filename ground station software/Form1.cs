using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XModemProtocol;

namespace yer_istasyonu
{
    public partial class Form1 : Form
    {
        private MemoryStream photoStream = new MemoryStream();
        byte[] olusturalacak_paket = new byte[78];
        private const int PacketSize = 78;
        private static readonly byte[] StartBytes = { 0xFF, 0xFF }; // İlk iki bayt 0xFF
        private const byte EndByte = 0x0A;   // Bitiş baytı
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        byte CheckSumHesapla()
        {
            int check_sum = 0;

            // 4. bayttan 75. bayta kadar olan baytları toplar
            for (int i = 4; i < 75; i++)
            {
                check_sum += olusturalacak_paket[i];
            }

            // Toplamı 256 ile mod alarak 8 bitlik bir byte değeri döndürür
            return (byte)(check_sum % 256);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();

                // Seri portu aç.
                Enum.TryParse(form2.Parity,out Parity parity);
                Enum.TryParse(form2.Stop, out StopBits stop);

                serialPort1.BaudRate = Convert.ToInt32(form2.Baudrate);
                serialPort1.PortName = form2.Port;
                serialPort1.StopBits = stop;
                serialPort1.Parity = parity;
                        
                    
                
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();

                // Seri portu aç.
                Enum.TryParse(form2.Parity, out Parity parity);
                Enum.TryParse(form2.Stop, out StopBits stop);
                serialPort2.BaudRate = Convert.ToInt32(form2.Baudrate);

                serialPort2.PortName = form2.Port;
                serialPort2.StopBits = stop;
                serialPort2.Parity = parity;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {
                serialPort2.Open();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            //byte[] buffer = new byte[PacketSize];
            int bytesRead = 2;
            bool startDetected = false;
            int startByteIndex = 0;

            while (bytesRead < PacketSize)
            {
                byte incomingByte = (byte)serialPort1.ReadByte();

                if (!startDetected)
                {
                    // StartBytes'i kontrol et
                    if (incomingByte == StartBytes[startByteIndex])
                    {
                        startByteIndex++;
                        if (startByteIndex == StartBytes.Length)
                        {
                            startDetected = true;
                            bytesRead = 2;
                        }
                    }
                    else
                    {
                        
                        startByteIndex = 0; // Eğer diziyi tamamlayamazsak yeniden başla
                        //this.Invoke(new EventHandler(DisplayText));
                    }
                }
                else
                {
                    olusturalacak_paket[bytesRead++] = incomingByte;

                    if (bytesRead == PacketSize && olusturalacak_paket[77] == EndByte)
                    {

                        //ProcessReceivedData(buffer);
                        break;
                    }
                }
            }
          

           

            // 77. ve 78. byte'ları başa yerleştir
            olusturalacak_paket[0] = 0xFF;
            olusturalacak_paket[1] = 0xFF;
            this.Invoke(new EventHandler(DisplayText));




        }
        void DisplayText(object sender, EventArgs e)
        {

            if (olusturalacak_paket[75] == CheckSumHesapla())
            {

            
            textTakımID.Text = Convert.ToString(olusturalacak_paket[4]);
            textBox2.Text = Convert.ToString(olusturalacak_paket[5]);

            float irtifa = BitConverter.ToSingle(olusturalacak_paket, 6);
            textIrtifa.Text = Convert.ToString((float)irtifa);

            float Gpsirtifa = BitConverter.ToSingle(olusturalacak_paket, 10);
            textGpsIrtf.Text = Convert.ToString((float)Gpsirtifa);

            float GpsEnlem = BitConverter.ToSingle(olusturalacak_paket, 14);
            textEnlem.Text = Convert.ToString((float)GpsEnlem);

            float GpsBoylam = BitConverter.ToSingle(olusturalacak_paket, 18);
            textBoylam.Text = Convert.ToString((float)GpsBoylam);

            float GyGpsIrtifa = BitConverter.ToSingle(olusturalacak_paket, 22);
            textGyIrtifa.Text = Convert.ToString((float)GyGpsIrtifa);

            float GyEnlem = BitConverter.ToSingle(olusturalacak_paket, 26);
            textGyEnlem.Text = Convert.ToString((float)GyEnlem);

            float GyBoylam = BitConverter.ToSingle(olusturalacak_paket, 30);
            textGyBoylam.Text = Convert.ToString((float)GyBoylam);

            float gyrx = BitConverter.ToSingle(olusturalacak_paket, 46);
            textJX.Text = Convert.ToString((float)gyrx);

            float gyry = BitConverter.ToSingle(olusturalacak_paket, 50);
            textJY.Text = Convert.ToString((float)gyry);

            float gyrz = BitConverter.ToSingle(olusturalacak_paket, 54);
            textJZ.Text = Convert.ToString((float)gyrz);

            float ivmex = BitConverter.ToSingle(olusturalacak_paket, 58);
            textIvmeX.Text = Convert.ToString((float)ivmex);

            float ivmey = BitConverter.ToSingle(olusturalacak_paket, 62);
            textIvmeY.Text = Convert.ToString((float)ivmey);

            float ivmez = BitConverter.ToSingle(olusturalacak_paket, 66);
            textIvmeZ.Text = Convert.ToString((float)ivmez);

            float aci = BitConverter.ToSingle(olusturalacak_paket, 70);
            textAçi.Text = Convert.ToString((float)aci);

            textDurum.Text = Convert.ToString(olusturalacak_paket[74]);

            textCrc.Text = Convert.ToString(olusturalacak_paket[75]);

                this.chart1.Series[0].Points.AddY(i);
                i++;
                //this.chart1.Series[0].Points.AddY(irtifa);

                map.Position = new GMap.NET.PointLatLng(GpsEnlem, GpsBoylam);
                map2.Position = new GMap.NET.PointLatLng(GyEnlem, GyBoylam);

            }
        }
        private void textTakımID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textGyIrtifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEnlem_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIrtifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 5;
            map.MaxZoom = 200;

            map2.DragButton = MouseButtons.Left;
            map2.MapProvider = GMapProviders.GoogleMap;
            map2.MinZoom = 5;
            map2.MaxZoom = 200;

            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisX.Minimum = 4000;

            //chart1.ChartAreas[0].AxisX.Minimum = 0;
           //chart1.ChartAreas[0].AxisX.Minimum = 200;

            //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 200);
        }

        private void textGyEnlem_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           // this.chart1.Series[0].Points.AddY(i);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textAçi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSayac_Click(object sender, EventArgs e)
        {

        }

        private async void button9_ClickAsync(object sender, EventArgs e)
        {
            var xmodem = new XModemCommunicator();

            xmodem.Port = serialPort1;

            xmodem.Mode = XModemMode.Checksum;

            serialPort3.Open();

           


            await Task.Run(() =>
            {
                byte[] data = new byte[] { 0x00, 0x3f, 0x17 }; // Göndermek istediğimiz veri
                foreach (byte b in data)
                {
                    serialPort3.Write(new byte[] { b }, 0, 1); // Her baytı tek tek gönderiyoruz
                }

                xmodem.Receive();

                if (xmodem.State != XModemStates.Idle)
                {
                    xmodem.CancelOperation();
                    Console.ReadLine();
                }
            });

            

            serialPort3.Close();

            byte[] buffer = new byte[xmodem.Data.Count()];
            buffer = xmodem.Data.ToArray();

            photoStream.Write(buffer, 0, xmodem.Data.Count());

            photoStream.Seek(0, SeekOrigin.Begin);
            Image img = Image.FromStream(photoStream);
            photoStream.SetLength(0);

            pictureBox1.Invoke(new MethodInvoker(delegate
            {
                pictureBox1.Image = img;
            }));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();

                // Seri portu aç.
                Enum.TryParse(form2.Parity, out Parity parity);
                Enum.TryParse(form2.Stop, out StopBits stop);

                serialPort3.BaudRate = Convert.ToInt32(form2.Baudrate);
                serialPort3.PortName = form2.Port;
                serialPort3.StopBits = stop;
                serialPort3.Parity = parity;




            }
        }
    }
}
