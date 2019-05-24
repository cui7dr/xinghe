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
    public partial class Diag : Form
    {

        public Diag()
        {
            InitializeComponent();
        }


        #region
        /// <summary>
        /// 窗体控件自适应
        /// </summary>

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
        #endregion


        #region
        /// <summary>
        /// 按钮功能
        /// </summary>

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

        // 校准按钮
        private void Calibration_Click(object sender, EventArgs e)
        {
            Calibra calibration = new Calibra();
            calibration.Owner = this;
            this.Hide();
            calibration.ShowDialog();
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

    }
}
