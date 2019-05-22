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
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace nhat
{
    public partial class Menu : Form
    {
        
        private Size m_szInit;//初始窗体大小
        private Dictionary<Control, Rectangle> m_dicSize = new Dictionary<Control, Rectangle>();

        private SerialPort port = new SerialPort(); //添加串口
        private IPAddress serverIP = IPAddress.Parse("192.168.0.7");
        private IPEndPoint serverFullAddress;
        private Socket sock;

        // 十六进制转 ASCII
        //byte hex = 0x45;
        //label1.Text = ((char) hex).ToString();


        /// <summary>
        /// 控件随窗口大小自适应
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            m_szInit = this.Size;//获取初始大小
            this.GetInitSize(this);
            base.OnLoad(e);
        }

        private void GetInitSize(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                m_dicSize.Add(c, new Rectangle(c.Location, c.Size));
                this.GetInitSize(c);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            //计算当前大小和初始大小的比例
            float fx = (float)this.Width / m_szInit.Width;
            float fy = (float)this.Height / m_szInit.Height;
            foreach (var v in m_dicSize)
            {
                v.Key.Left = (int)(v.Value.Left * fx);
                v.Key.Top = (int)(v.Value.Top * fy);
                v.Key.Width = (int)(v.Value.Width * fx);
                v.Key.Height = (int)(v.Value.Height * fy);
            }
            base.OnResize(e);
        }

        public Menu()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; //工作线程不能访问窗口线程
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //port.PortName = "COM3";
            //port.BaudRate = 9600;
            //port.Parity = Parity.Even; //偶校验
            //port.Open();
            //Send(new byte[] { 1, 32, 0, 57, 192 });
            //port.DataReceived += new SerialDataReceivedEventHandler(Receive);
            
        }
        


        //断开ip连接
        private void btnClose_Click(object sender, EventArgs e)
        {
            sock.Close();

        }


        // NO、NO2 命令
        private void Send(byte[] data)
        {
            port.Write(data, 0, 5);
        }

        // NO、NO2 数据解析
        private void Receive(object obj, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[7];
            port.Read(data, 0, 7);
            GC.Collect();
            if (data[2] == 0)
            {
                //label1.Text = ((data[4] * 100 + data[5]) / 10).ToString();
            }
            else
            {
                //label1.Text = null;
            }

        }



        /// <summary>
        /// 按钮功能
        /// </summary>
        // 校准按钮
        private void Calibration_Click(object sender, EventArgs e)
        {
            Calibra calibration = new Calibra();
            calibration.Owner = this;
            this.Hide();
            calibration.ShowDialog();
        }

        //主菜单按钮
        private void Index_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Owner = this;
            this.Hide();
            menu.ShowDialog();
        }

        //测量按钮
        private void Measure_Click(object sender, EventArgs e)
        {
            Measures measures = new Measures();
            measures.Owner = this;
            this.Hide();
            measures.ShowDialog();
        }

        //调零按钮
        private void Zero_Click(object sender, EventArgs e)
        {

        }

        //诊断菜单
        private void Diagnosis_Click(object sender, EventArgs e)
        {
            Diag diag = new Diag();
            diag.Owner = this;
            this.Hide();
            diag.ShowDialog();
        }

        //设置菜单
        private void Setting_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            this.Hide();
            settings.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20008"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte = new byte[] { 1, 32, 0, 57, 192 };
            byte[] revbyte = new byte[1024];
            int lenght = 0;
            try
            {
                sock.Send(sendbyte);
                lenght = sock.Receive(revbyte);
                if (lenght == 6 && revbyte[2] == 1)
                {
                    //label1.Text = revbyte[3].ToString(); ;

                }
                else
                {
                    //label1.Text = ((double)((revbyte[4] * 16*16 + revbyte[3]) / 10)).ToString();
                }
                //label1.Text = lenght.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("出错");
            }
            sock.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            getCO2();
            getPa();
        }


        public void getCO2()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20002"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte = new byte[] { 84, 1, 32, 139 };
            byte[] revbyte = new byte[1024];
            int lenght = 0;
            try
            {
                sock.Send(sendbyte);
                lenght = sock.Receive(revbyte);
                //label1.Text = lenght.ToString();
                CO2_value.Text = ((char)revbyte[8]).ToString() + ((char)revbyte[9]).ToString() + ((char)revbyte[10]).ToString() + ((char)revbyte[11]).ToString() + ((char)revbyte[12]).ToString();
                if (revbyte[38] == 45){
                    Oiltemp_value.Text =  ((char)revbyte[39]).ToString() + ((char)revbyte[40]).ToString() + ((char)revbyte[41]).ToString() + ((char)revbyte[42]).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("出错");
            }
            sock.Close();
        }

        public void getPa()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20002"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte1 = new byte[] { 84, 1, 21, 150 };
            byte[] revbyte = new byte[1024];
            int lenght = 0;
            try
            {
                
                sock.Send(sendbyte1);
                lenght = sock.Receive(revbyte);
                
                Air_value.Text = ((char)revbyte[8]).ToString() + ((char)revbyte[9]).ToString() + ((char)revbyte[10]).ToString() + ((char)revbyte[11]).ToString();
                PEF_value.Text = ((char)revbyte[23]).ToString() + ((char)revbyte[24]).ToString() + ((char)revbyte[25]).ToString() + ((char)revbyte[26]).ToString() + ((char)revbyte[27]).ToString();

                //if (revbyte[38] == 45){
                //    Oiltemp_value.Text =  ((char)revbyte[39]).ToString() + ((char)revbyte[40]).ToString() + ((char)revbyte[41]).ToString() + ((char)revbyte[42]).ToString();
                //}

            }
            catch (Exception)
            {
                MessageBox.Show("出错");
            }
            sock.Close();
        }


        private void getNO2()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20008"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte []sendNO2 = new byte[] { 1, 32, 0, 57, 192 };
            byte[] revNO2 = new byte[10];
            int lenght = 0;
            try
            {
                sock.Send(sendNO2);
                lenght = sock.Receive(revNO2);
                if (lenght == 6 && revNO2[2] == 1)
                {
                    NO2_value.Text = revNO2[3].ToString();
                }
                else
                {
                    NO2_value.Text = ((double)((revNO2[4] * 16 * 16 + revNO2[3])/10)).ToString();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("出错");
            }
        }


        private void getNO()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20007"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendNO = new byte[] { 1, 32, 0, 57, 192 };
            byte[] revNO = new byte[10];
            int lenght = 0;
            try
            {
                sock.Send(sendNO);
                lenght = sock.Receive(revNO);
                if (lenght == 6 && revNO[2] == 1)
                {
                    NO_value.Text = revNO[3].ToString();
                }
                else
                {
                    NO_value.Text = ((double)((revNO[4] * 16 * 16 + revNO[3]) / 10)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("出错");
            }
        }

    }
}
