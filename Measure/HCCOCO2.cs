using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhat
{
    public partial class HCCOCO2 : Form
    {

        private Size m_szInit;//初始窗体大小
        private Dictionary<Control, Rectangle> m_dicSize = new Dictionary<Control, Rectangle>();

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

        public HCCOCO2()
        {
            InitializeComponent();
        }

        private void Index_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Owner = this;
            this.Hide();
            menu.ShowDialog();
        }

        private void Calibration_Click(object sender, EventArgs e)
        {
            Calibra calibra = new Calibra();
            calibra.Owner = this;
            this.Hide();
            calibra.ShowDialog();
        }
    }
}
