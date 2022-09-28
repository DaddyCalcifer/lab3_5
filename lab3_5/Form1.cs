using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_output.Value = Convert.ToDecimal(func());
        }
        public int factorial(int n)
        {
            if (n == 0) return 0;
            if(n ==1) return 1;
            return n * factorial(n - 1);
        }
        public double func()
        {
            double eps = Convert.ToDouble(EPS_enter.Value);
            double res = 0;
            for (int i = 1; ; i++)
            {
                double tempo = 1 / Math.Sqrt(factorial(i));
                if (tempo < eps) return res;
                res += tempo;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EPS_enter_ValueChanged(object sender, EventArgs e)
        {
            result_output.Value = Convert.ToDecimal(func());
        }
    }
}
