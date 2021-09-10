using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplex_Method1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1;
            }
            else if(numericUpDown1.Value > 5)
            {
                numericUpDown1.Value = 5;
            }
            /*
            if(numericUpDown1.Value == 1)
            {
                varslabel.Text = "x1>= 0";
            }
            */
            switch (numericUpDown1.Value)
            {
                case 1:
                    varslabel.Text = "x1>= 0";
                    break;
                case 2:
                    varslabel.Text = "x1, x2>= 0";
                    break;
                case 3:
                    varslabel.Text = "x1, x2, x3>= 0";
                    break;
                case 4:
                    varslabel.Text = "x1, x2, x3, x4>= 0";
                    break;
                case 5:
                    varslabel.Text = "x1, x2, x3, x4, x5>= 0";
                    break;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 1)
            {
                numericUpDown2.Value = 1;
            }
            else if (numericUpDown2.Value > 5)
            {
                numericUpDown2.Value = 5;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
