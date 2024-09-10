using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsHCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            lib_hinhhoc.hinhchunhat hcn = new lib_hinhhoc.hinhchunhat();
            hcn.a = a;
            hcn.b = b;
            hcn.Xuly();
            if (hcn.ok)
            {
                label_kq1.Text = ($" diện tích hinh chu nhat = {hcn.dientich}");
                label_kq.Text = ($" chu vi hinh chu nhat = {hcn.chuvi}");
            }
            else
            {
                label_kq.Text = ("lỗi !!! ");
            }
        }
    }
}
