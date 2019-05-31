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

/// <summary>
/// 20001 - 20004 为 RS232 串口
/// 20005  -20008 为 RS485 串口
/// 20007、20008 加偶校验位
/// </summary>


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
            //Control.CheckForIllegalCrossThreadCalls = false; //工作线程不能访问窗口线程

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //port.PortName = "COM3";
            //port.BaudRate = 9600;
            //port.Parity = Parity.Even; //偶校验
            //port.Open();
            //Send(new byte[] { 1, 32, 0, 57, 192 });
            //port.DataReceived += new SerialDataReceivedEventHandler(Receive);

            //timer1.Start();
            timer1.Stop();
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
                //label1.Text = ((data[4] * 16 *16 + data[3]) / 10).ToString();
            }
            else
            {
                //label1.Text = null;
            }
        }


        /// <summary>
        /// 按钮功能
        /// </summary>
        #region
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
        #endregion


        //获取 CO、CO2、油温 的值
        public void getInfo20001()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20001"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte1 = new byte[] { 84, 1, 32, 139 }; //5401208B（命令 T
            byte[] revbyte1 = new byte[1024];
            int lenght1 = 0;
            try
            {
                sock.Send(sendbyte1);
                lenght1 = sock.Receive(revbyte1);
                CO_value.Text = ((char)revbyte1[3]).ToString() + ((char)revbyte1[4]).ToString() + ((char)revbyte1[5]).ToString() + ((char)revbyte1[6]).ToString() + ((char)revbyte1[7]).ToString();
                CO2_value.Text = ((char)revbyte1[8]).ToString() + ((char)revbyte1[9]).ToString() + ((char)revbyte1[10]).ToString() + ((char)revbyte1[11]).ToString() + ((char)revbyte1[12]).ToString();
                HC_value.Text = ((char)revbyte1[13]).ToString() + ((char)revbyte1[14]).ToString() + ((char)revbyte1[15]).ToString() + ((char)revbyte1[16]).ToString() + ((char)revbyte1[17]).ToString();
                if (revbyte1[38] == 45) //45 == 2D == -
                {
                    Oiltemp_value.Text = ((char)revbyte1[39]).ToString() + ((char)revbyte1[40]).ToString() + ((char)revbyte1[41]).ToString() + ((char)revbyte1[42]).ToString() + "  ℃";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("GAS BENCH 连接错误！请检查");
            }
            sock.Close();
        }

        //获取 气压 和 PEF 的值
        public void getAirAndPEF()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20001"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            //byte[] sendbyte = new byte[] { 84, 1, 32, 139 }; //5401208B（命令 T
            //byte[] revbyte = new byte[1024];
            //int lenght = 0;
            //try
            //{
            //    sock.Send(sendbyte);
            //    lenght = sock.Receive(revbyte);
            //    CO_value.Text = ((char)revbyte[3]).ToString() + ((char)revbyte[4]).ToString() + ((char)revbyte[5]).ToString() + ((char)revbyte[6]).ToString() + ((char)revbyte[7]).ToString();
            //    CO2_value.Text = ((char)revbyte[8]).ToString() + ((char)revbyte[9]).ToString() + ((char)revbyte[10]).ToString() + ((char)revbyte[11]).ToString() + ((char)revbyte[12]).ToString();
            //    if (revbyte[38] == 45) //45 == 2D == -
            //    {
            //        Oiltemp_value.Text = ((char)revbyte[39]).ToString() + ((char)revbyte[40]).ToString() + ((char)revbyte[41]).ToString() + ((char)revbyte[42]).ToString() + "  ℃";
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("出错");
            //}
            byte[] sendbyte1 = new byte[] { 84, 1, 21, 150 }; //54011596
            byte[] revbyte1 = new byte[1024];
            int lenght1 = 0;
            try
            {
                sock.Send(sendbyte1);
                lenght1 = sock.Receive(revbyte1);

                Air_value.Text = ((char)revbyte1[8]).ToString() + ((char)revbyte1[9]).ToString() + ((char)revbyte1[10]).ToString() + ((char)revbyte1[11]).ToString() + "  mPa"; //气压值（mPa
                PEF_value.Text = ((char)revbyte1[23]).ToString() + ((char)revbyte1[24]).ToString() + ((char)revbyte1[25]).ToString() + ((char)revbyte1[26]).ToString() + ((char)revbyte1[27]).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("读取气压出错");
            }
            //byte[] sendbyte2 = new byte[] { 80, 5, 48, 123 }; //5005307B（命令 P
            //byte[] revbyte2 = new byte[1024];
            //int lenght2 = 0;
            //try
            //{
            //    sock.Send(sendbyte2);
            //    lenght2 = sock.Receive(revbyte2);

            //    HC_value.Text = ((char)revbyte2[2]).ToString() + ((char)revbyte2[3]).ToString() + ((char)revbyte2[4]).ToString() + ((char)revbyte2[5]).ToString() + ((char)revbyte2[6]).ToString();

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("出错");
            //}
            sock.Close();
        }

        /// <summary>
        /// 读取端口 20004 相关信息
        /// 20004 波特率为 19200
        /// 包含不透光度 N 和 光吸收系数 K
        /// </summary>
        private void getInfo20004()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20004"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte1 = new byte[] { 122, 134 }; //7A86
            byte[] revbyte1 = new byte[1024];
            int lenght1 = 0;
            try
            {
                sock.Send(sendbyte1);
                lenght1 = sock.Receive(revbyte1);

                N_value.Text = revbyte1[2].ToString() + "  %";

            }
            catch (Exception)
            {
                MessageBox.Show("读取不透光度出错");
            }
            byte[] sendbyte2 = new byte[] { 99, 157 }; //639D
            byte[] revbyte2 = new byte[1024];
            int lenght2 = 0;
            try
            {
                sock.Send(sendbyte2);
                lenght2 = sock.Receive(revbyte2);

                K_value.Text = revbyte2[2].ToString() + "  /m";

            }
            catch (Exception)
            {
                MessageBox.Show("读取光吸收系数出错");
            }
            sock.Close();
        }

        //获取 光吸收系数 K 的值
        private void getK()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20004"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendbyte1 = new byte[] { 99, 157 }; //639D
            byte[] revbyte = new byte[1024];
            int lenght = 0;
            try
            {
                sock.Send(sendbyte1);
                lenght = sock.Receive(revbyte);

                K_value.Text = revbyte[2].ToString() + "  /m";

            }
            catch (Exception)
            {
                MessageBox.Show("读取光吸收系数出错");
            }
            sock.Close();
        }

        //访问 NO2 并解析（端口 20008，RS485 + EVEN
        private void getInfo20008()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20008"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendNO2 = new byte[] { 1, 32, 0, 57, 192 }; //01200039C0
            byte[] revNO2 = new byte[1024];
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
                    NO2_value.Text = ((revNO2[4] * 16 * 16 + revNO2[3]) / 10).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("读取 NO2 出错");
            }
        }

        //访问 NO 并解析（端口 20007 ，RS485 + EVEN
        private void getInfo20007()
        {
            serverFullAddress = new IPEndPoint(serverIP, int.Parse("20007"));
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(serverFullAddress);
            byte[] sendNO = new byte[] { 1, 32, 0, 57, 192 }; //01200039C0
            byte[] revNO = new byte[1024];
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
                    NO_value.Text = (revNO[4] * 16 * 16 + revNO[3]).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("读取 NO 出错");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            getInfo20001();//获取 CO、CO2、油温 的值
            getAirAndPEF();//获取 气压 和 PEF 的值
            getInfo20004();
            getInfo20007();
            getInfo20008();
            //getK();
        }
    }
}
