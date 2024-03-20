using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToStr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strBefore = textBefore.Text;
            String packBeforeStr = packBeforeStrText.Text;
            String packAfterStr = packAfterStrText.Text;
            String splitStr = splitStrText.Text;
            String strAfter = ToStrHandler.toStr(strBefore, packBeforeStr, packAfterStr, splitStr);
            textAfter.Text = strAfter;
        }

        private void notify_Click(object sender, EventArgs e)
        {
            // 显示主窗体(还原窗体form)
            WindowState = FormWindowState.Normal;
        }


        private void about_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.ShowDialog();
        }
    }
}
