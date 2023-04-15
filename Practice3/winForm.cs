using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Practice3
{
    public partial class winForm : Form
    {
        public winForm()
        {
            InitializeComponent();
        }

        public double x1 = 2;
        public double a = 3.5;
        public double ep = 2.718;

        public double xn1 = 7;
        public double xn2 = 29;

        public double dx1 = 0.5;
        public double dx2 = 3;

        private void bWhile_Click(object sender, EventArgs e)
        {
            try
            {
                tbResult.Clear();
                while (x1 <= xn1)
                {
                    double result = (a * x1) * (1 + (a * Math.Pow(ep, -x1)));
                    tbResult.Text = result.ToString();
                    x1 = x1 + dx1;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка вычислений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bFor_Click(object sender, EventArgs e)
        {
            try
            {
                tbResult.Clear();
                for (x1 = 2; x1 <= xn2; x1 = x1 + dx2)
                {
                    double result = (a * x1) * (1 + (a * Math.Pow(ep, -x1)));
                    tbResult.Text = result.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка вычислений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\УП ПМ.02\День 3\Practice3\Practice3\Resources\Руководство пользователя.pdf");
        }
    }
}






