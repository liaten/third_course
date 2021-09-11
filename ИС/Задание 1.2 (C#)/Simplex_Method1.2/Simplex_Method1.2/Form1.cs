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
        public void Row2_Hide()
        {
            // hide row 2 elements 1-6
            r2e1.Hide();
            r2e2.Hide();
            r2e3.Hide();
            r2e4.Hide();
            r2e5.Hide();
            r2e6.Hide();
            // hide row 2 labels 1-5
            r2l1.Hide();
            r2l2.Hide();
            r2l3.Hide();
            r2l4.Hide();
            r2l5.Hide();
            // hide combo box with relatives on row 2
            ComboBoxRel2.Hide();
        }
        public void Row2_Show()
        {
            // show row 2 elements 1-6
            switch (numericUpDown1.Value)
            {
                case 1:
                    r2e1.Show();
                    r2e6.Show();
                    break;
                case 2:
                    r2e1.Show();
                    r2e2.Show();
                    r2e6.Show();
                    break;
                case 3:
                    r2e1.Show();
                    r2e2.Show();
                    r2e3.Show();
                    r2e6.Show();
                    break;
                case 4:
                    r2e1.Show();
                    r2e2.Show();
                    r2e3.Show();
                    r2e4.Show();
                    r2e6.Show();
                    break;
                case 5:
                    r2e1.Show();
                    r2e2.Show();
                    r2e3.Show();
                    r2e4.Show();
                    r2e5.Show();
                    r2e6.Show();
                    break;
            }
            // show row 2 labels 1-5
            switch (numericUpDown1.Value)
            {
                case 1:
                    r2l1.Show();
                    break;
                case 2:
                    r2l1.Show();
                    r2l2.Show();
                    break;
                case 3:
                    r2l1.Show();
                    r2l2.Show();
                    r2l3.Show();
                    break;
                case 4:
                    r2l1.Show();
                    r2l2.Show();
                    r2l3.Show();
                    r2l4.Show();
                    break;
                case 5:
                    r2l1.Show();
                    r2l2.Show();
                    r2l3.Show();
                    r2l4.Show();
                    r2l5.Show();
                    break;
            }
            // show combo box with relatives on row 2
            ComboBoxRel2.Show();
        }
        public void Row3_Hide()
        {
            // hide row 3 elements 1-6
            r3e1.Hide();
            r3e2.Hide();
            r3e3.Hide();
            r3e4.Hide();
            r3e5.Hide();
            r3e6.Hide();
            // hide row 3 labels 1-5
            r3l1.Hide();
            r3l2.Hide();
            r3l3.Hide();
            r3l4.Hide();
            r3l5.Hide();
            // hide combo box with relatives on row 3
            ComboBoxRel3.Hide();
        }
        public void Row3_Show()
        {
            // show row 3 elements 1-6
            switch (numericUpDown1.Value)
            {
                case 1:
                    r3e1.Show();
                    r3e6.Show();
                    break;
                case 2:
                    r3e1.Show();
                    r3e2.Show();
                    r3e6.Show();
                    break;
                case 3:
                    r3e1.Show();
                    r3e2.Show();
                    r3e3.Show();
                    r3e6.Show();
                    break;
                case 4:
                    r3e1.Show();
                    r3e2.Show();
                    r3e3.Show();
                    r3e4.Show();
                    r3e6.Show();
                    break;
                case 5:
                    r3e1.Show();
                    r3e2.Show();
                    r3e3.Show();
                    r3e4.Show();
                    r3e5.Show();
                    r3e6.Show();
                    break;
            }
            // show row 3 labels 1-5
            switch (numericUpDown1.Value)
            {
                case 1:
                    r3l1.Show();
                    break;
                case 2:
                    r3l1.Show();
                    r3l2.Show();
                    break;
                case 3:
                    r3l1.Show();
                    r3l2.Show();
                    r3l3.Show();
                    break;
                case 4:
                    r3l1.Show();
                    r3l2.Show();
                    r3l3.Show();
                    r3l4.Show();
                    break;
                case 5:
                    r3l1.Show();
                    r3l2.Show();
                    r3l3.Show();
                    r3l4.Show();
                    r3l5.Show();
                    break;
            }
            // show combo box with relatives on row 3
            ComboBoxRel3.Show();
        }
        public void Row4_Hide()
        {
            // hide row 4 elements 1-6
            r4e1.Hide();
            r4e2.Hide();
            r4e3.Hide();
            r4e4.Hide();
            r4e5.Hide();
            r4e6.Hide();
            // hide row 4 labels 1-5
            r4l1.Hide();
            r4l2.Hide();
            r4l3.Hide();
            r4l4.Hide();
            r4l5.Hide();
            // hide combo box with relatives on row 4
            ComboBoxRel4.Hide();
        }
        public void Row4_Show()
        {
            // show row 4 elements 1-6
            switch (numericUpDown1.Value)
            {
                case 1:
                    r4e1.Show();
                    r4e6.Show();
                    break;
                case 2:
                    r4e1.Show();
                    r4e2.Show();
                    r4e6.Show();
                    break;
                case 3:
                    r4e1.Show();
                    r4e2.Show();
                    r4e3.Show();
                    r4e6.Show();
                    break;
                case 4:
                    r4e1.Show();
                    r4e2.Show();
                    r4e3.Show();
                    r4e4.Show();
                    r4e6.Show();
                    break;
                case 5:
                    r4e1.Show();
                    r4e2.Show();
                    r4e3.Show();
                    r4e4.Show();
                    r4e5.Show();
                    r4e6.Show();
                    break;
            }
            // show row 4 labels 1-5
            switch (numericUpDown1.Value)
            {
                case 1:
                    r4l1.Show();
                    break;
                case 2:
                    r4l1.Show();
                    r4l2.Show();
                    break;
                case 3:
                    r4l1.Show();
                    r4l2.Show();
                    r4l3.Show();
                    break;
                case 4:
                    r4l1.Show();
                    r4l2.Show();
                    r4l3.Show();
                    r4l4.Show();
                    break;
                case 5:
                    r4l1.Show();
                    r4l2.Show();
                    r4l3.Show();
                    r4l4.Show();
                    r4l5.Show();
                    break;
            }
            // show combo box with relatives on row 2
            ComboBoxRel4.Show();
        }
        public void Row5_Hide()
        {
            // hide row 5 elements 1-6
            r5e1.Hide();
            r5e2.Hide();
            r5e3.Hide();
            r5e4.Hide();
            r5e5.Hide();
            r5e6.Hide();
            // hide row 5 labels 1-5
            r5l1.Hide();
            r5l2.Hide();
            r5l3.Hide();
            r5l4.Hide();
            r5l5.Hide();
            // hide combo box with relatives on row 5
            ComboBoxRel5.Hide();
        }
        public void Row5_Show()
        {
            // show row 5 elements 1-6
            switch (numericUpDown1.Value)
            {
                case 1:
                    r5e1.Show();
                    r5e6.Show();
                    break;
                case 2:
                    r5e1.Show();
                    r5e2.Show();
                    r5e6.Show();
                    break;
                case 3:
                    r5e1.Show();
                    r5e2.Show();
                    r5e3.Show();
                    r5e6.Show();
                    break;
                case 4:
                    r5e1.Show();
                    r5e2.Show();
                    r5e3.Show();
                    r5e4.Show();
                    r5e6.Show();
                    break;
                case 5:
                    r5e1.Show();
                    r5e2.Show();
                    r5e3.Show();
                    r5e4.Show();
                    r5e5.Show();
                    r5e6.Show();
                    break;
            }
            // show row 5 labels 1-5
            switch (numericUpDown1.Value)
            {
                case 1:
                    r5l1.Show();
                    break;
                case 2:
                    r5l1.Show();
                    r5l2.Show();
                    break;
                case 3:
                    r5l1.Show();
                    r5l2.Show();
                    r5l3.Show();
                    break;
                case 4:
                    r5l1.Show();
                    r5l2.Show();
                    r5l3.Show();
                    r5l4.Show();
                    break;
                case 5:
                    r5l1.Show();
                    r5l2.Show();
                    r5l3.Show();
                    r5l4.Show();
                    r5l5.Show();
                    break;
            }
            // show combo box with relatives on row 5
            ComboBoxRel5.Show();
        }
        public void X2_Show()
        {
            // set x1 label with plus in function section
            kl1.Text = "x1 +";
            // show x2 in function
            kx2.Show();
            kl2.Show();
            kl2.Text = "x2 →";
            // set x1 label with plus in restrictions section
            r1l1.Text = "x1 +";
            r2l1.Text = "x1 +";
            r3l1.Text = "x1 +";
            r4l1.Text = "x1 +";
            r5l1.Text = "x1 +";
            // show x2 in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1e2.Show();
                    break;
                case 2:
                    r1e2.Show();
                    r2e2.Show();
                    break;
                case 3:
                    r1e2.Show();
                    r2e2.Show();
                    r3e2.Show();
                    break;
                case 4:
                    r1e2.Show();
                    r2e2.Show();
                    r3e2.Show();
                    r4e2.Show();
                    break;
                case 5:
                    r1e2.Show();
                    r2e2.Show();
                    r3e2.Show();
                    r4e2.Show();
                    r5e2.Show();
                    break;
            }
            // show x2 label in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1l2.Show();
                    break;
                case 2:
                    r1l2.Show();
                    r2l2.Show();
                    break;
                case 3:
                    r1l2.Show();
                    r2l2.Show();
                    r3l2.Show();
                    break;
                case 4:
                    r1l2.Show();
                    r2l2.Show();
                    r3l2.Show();
                    r4l2.Show();
                    break;
                case 5:
                    r1l2.Show();
                    r2l2.Show();
                    r3l2.Show();
                    r4l2.Show();
                    r5l2.Show();
                    break;
            }
            // set x2 label without plus in restrictions section
            r1l2.Text = "x2";
            r2l2.Text = "x2";
            r3l2.Text = "x2";
            r4l2.Text = "x2";
            r5l2.Text = "x2";
        }
        public void X2_Hide()
        {
            // set x1 label without plus in function section
            kl1.Text = "x1 →";
            // hide x2 in function
            kx2.Hide();
            kl2.Hide();
            // set x1 label without plus in restrictions section
            r1l1.Text = "x1";
            r2l1.Text = "x1";
            r3l1.Text = "x1";
            r4l1.Text = "x1";
            r5l1.Text = "x1";
            // hide x2 in restrictions
            r1e2.Hide();
            r2e2.Hide();
            r3e2.Hide();
            r4e2.Hide();
            r5e2.Hide();
            // hide x2 label in restrictions
            r1l2.Hide();
            r2l2.Hide();
            r3l2.Hide();
            r4l2.Hide();
            r5l2.Hide();
        }
        public void X3_Show()
        {
            // set x2 label with plus in function section
            kl2.Text = "x2 +";
            // show x3 in function
            kx3.Show();
            kl3.Show();
            kl3.Text = "x3 →";
            // set x2 label with plus in restrictions section
            r1l2.Text = "x2 +";
            r2l2.Text = "x2 +";
            r3l2.Text = "x2 +";
            r4l2.Text = "x2 +";
            r5l2.Text = "x2 +";
            // show x3 in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1e3.Show();
                    break;
                case 2:
                    r1e3.Show();
                    r2e3.Show();
                    break;
                case 3:
                    r1e3.Show();
                    r2e3.Show();
                    r3e3.Show();
                    break;
                case 4:
                    r1e3.Show();
                    r2e3.Show();
                    r3e3.Show();
                    r4e3.Show();
                    break;
                case 5:
                    r1e3.Show();
                    r2e3.Show();
                    r3e3.Show();
                    r4e3.Show();
                    r5e3.Show();
                    break;
            }
            // show x3 label in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1l3.Show();
                    break;
                case 2:
                    r1l3.Show();
                    r2l3.Show();
                    break;
                case 3:
                    r1l3.Show();
                    r2l3.Show();
                    r3l3.Show();
                    break;
                case 4:
                    r1l3.Show();
                    r2l3.Show();
                    r3l3.Show();
                    r4l3.Show();
                    break;
                case 5:
                    r1l3.Show();
                    r2l3.Show();
                    r3l3.Show();
                    r4l3.Show();
                    r5l3.Show();
                    break;
            }
            // set x3 label without plus in restrictions section
            r1l3.Text = "x3";
            r2l3.Text = "x3";
            r3l3.Text = "x3";
            r4l3.Text = "x3";
            r5l3.Text = "x3";
        }
        public void X3_Hide()
        {
            // set x2 label without plus in function section
            kl2.Text = "x2";
            // hide x3 in function
            kx3.Hide();
            kl3.Hide();
            // set x2 label without plus in restrictions section
            r1l2.Text = "x2";
            r2l2.Text = "x2";
            r3l2.Text = "x2";
            r4l2.Text = "x2";
            r5l2.Text = "x2";
            // hide x3 in restrictions
            r1e3.Hide();
            r2e3.Hide();
            r3e3.Hide();
            r4e3.Hide();
            r5e3.Hide();
            // hide x3 label in restrictions
            r1l3.Hide();
            r2l3.Hide();
            r3l3.Hide();
            r4l3.Hide();
            r5l3.Hide();
        }
        public void X4_Show()
        {
            // set x3 label with plus in function section
            kl3.Text = "x3 +";
            // show x4 in function
            kx4.Show();
            kl4.Show();
            kl4.Text = "x4 →";
            // set x3 label with plus in restrictions section
            r1l3.Text = "x3 +";
            r2l3.Text = "x3 +";
            r3l3.Text = "x3 +";
            r4l3.Text = "x3 +";
            r5l3.Text = "x3 +";
            // show x4 in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1e4.Show();
                    break;
                case 2:
                    r1e4.Show();
                    r2e4.Show();
                    break;
                case 3:
                    r1e4.Show();
                    r2e4.Show();
                    r3e4.Show();
                    break;
                case 4:
                    r1e4.Show();
                    r2e4.Show();
                    r3e4.Show();
                    r4e4.Show();
                    break;
                case 5:
                    r1e4.Show();
                    r2e4.Show();
                    r3e4.Show();
                    r4e4.Show();
                    r5e4.Show();
                    break;
            }
            // show x4 label in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1l4.Show();
                    break;
                case 2:
                    r1l4.Show();
                    r2l4.Show();
                    break;
                case 3:
                    r1l4.Show();
                    r2l4.Show();
                    r3l4.Show();
                    break;
                case 4:
                    r1l4.Show();
                    r2l4.Show();
                    r3l4.Show();
                    r4l4.Show();
                    break;
                case 5:
                    r1l4.Show();
                    r2l4.Show();
                    r3l4.Show();
                    r4l4.Show();
                    r5l4.Show();
                    break;
            }
            // set x4 label without plus in restrictions section
            r1l4.Text = "x4";
            r2l4.Text = "x4";
            r3l4.Text = "x4";
            r4l4.Text = "x4";
            r5l4.Text = "x4";
        }
        public void X4_Hide()
        {
            // set x3 label without plus in function section
            kl3.Text = "x3";
            // hide x4 in function
            kx4.Hide();
            kl4.Hide();
            // set x3 label without plus in restrictions section
            r1l3.Text = "x3";
            r2l3.Text = "x3";
            r3l3.Text = "x3";
            r4l3.Text = "x3";
            r5l3.Text = "x3";
            // hide x4 in restrictions
            r1e4.Hide();
            r2e4.Hide();
            r3e4.Hide();
            r4e4.Hide();
            r5e4.Hide();
            // hide x4 label in restrictions
            r1l4.Hide();
            r2l4.Hide();
            r3l4.Hide();
            r4l4.Hide();
            r5l4.Hide();
        }
        public void X5_Show()
        {
            // set x4 label with plus in function section
            kl4.Text = "x4 +";
            // show x5 in function
            kx5.Show();
            kl5.Show();
            kl5.Text = "x5 →";
            // set x4 label with plus in restrictions section
            r1l4.Text = "x4 +";
            r2l4.Text = "x4 +";
            r3l4.Text = "x4 +";
            r4l4.Text = "x4 +";
            r5l4.Text = "x4 +";
            // show x5 in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1e5.Show();
                    break;
                case 2:
                    r1e5.Show();
                    r2e5.Show();
                    break;
                case 3:
                    r1e5.Show();
                    r2e5.Show();
                    r3e5.Show();
                    break;
                case 4:
                    r1e5.Show();
                    r2e5.Show();
                    r3e5.Show();
                    r4e5.Show();
                    break;
                case 5:
                    r1e5.Show();
                    r2e5.Show();
                    r3e5.Show();
                    r4e5.Show();
                    r5e5.Show();
                    break;
            }
            // show x5 label in restrictions
            switch (numericUpDown2.Value)
            {
                case 1:
                    r1l5.Show();
                    break;
                case 2:
                    r1l5.Show();
                    r2l5.Show();
                    break;
                case 3:
                    r1l5.Show();
                    r2l5.Show();
                    r3l5.Show();
                    break;
                case 4:
                    r1l5.Show();
                    r2l5.Show();
                    r3l5.Show();
                    r4l5.Show();
                    break;
                case 5:
                    r1l5.Show();
                    r2l5.Show();
                    r3l5.Show();
                    r4l5.Show();
                    r5l5.Show();
                    break;
            }
            // set x5 label without plus in restrictions section
            r1l5.Text = "x5";
            r2l5.Text = "x5";
            r3l5.Text = "x5";
            r4l5.Text = "x5";
            r5l5.Text = "x5";
        }
        public void X5_Hide()
        {
            // set x4 label without plus in function section
            kl4.Text = "x4";
            // hide x5 in function
            kx5.Hide();
            kl5.Hide();
            // set x4 label without plus in restrictions section
            r1l4.Text = "x4";
            r2l4.Text = "x4";
            r3l4.Text = "x4";
            r4l4.Text = "x4";
            r5l4.Text = "x4";
            // hide x5 in restrictions
            r1e5.Hide();
            r2e5.Hide();
            r3e5.Hide();
            r4e5.Hide();
            r5e5.Hide();
            // hide x5 label in restrictions
            r1l5.Hide();
            r2l5.Hide();
            r3l5.Hide();
            r4l5.Hide();
            r5l5.Hide();
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
            switch (numericUpDown1.Value)
            {
                case 1:
                    varslabel.Text = "x1>= 0";
                    X2_Hide();
                    X3_Hide();
                    X4_Hide();
                    X5_Hide();
                    ComboBoxMaxMin.Location = new Point(kl1.Location.X+38, 116);
                    ComboBoxRel1.Location = new Point(r1l1.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X+55,171);
                    ComboBoxRel2.Location = new Point(r2l1.Location.X + 24, 197);
                    r2e6.Location = new Point(ComboBoxRel2.Location.X + 55, 197);
                    ComboBoxRel3.Location = new Point(r3l1.Location.X + 24, 223);
                    r3e6.Location = new Point(ComboBoxRel3.Location.X + 55, 223);
                    ComboBoxRel4.Location = new Point(r4l1.Location.X + 24, 249);
                    r4e6.Location = new Point(ComboBoxRel4.Location.X + 55, 249);
                    ComboBoxRel5.Location = new Point(r5l1.Location.X + 24, 275);
                    r5e6.Location = new Point(ComboBoxRel5.Location.X + 55, 275);
                    break;
                case 2:
                    varslabel.Text = "x1, x2>= 0";
                    // first hide, then show
                    X3_Hide();
                    X4_Hide();
                    X5_Hide();
                    X2_Show();
                    ComboBoxMaxMin.Location = new Point(kl2.Location.X + 38, 116);
                    ComboBoxRel1.Location = new Point(r1l2.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X + 55, 171);
                    ComboBoxRel2.Location = new Point(r2l2.Location.X + 24, 197);
                    r2e6.Location = new Point(ComboBoxRel2.Location.X + 55, 197);
                    ComboBoxRel3.Location = new Point(r3l2.Location.X + 24, 223);
                    r3e6.Location = new Point(ComboBoxRel3.Location.X + 55, 223);
                    ComboBoxRel4.Location = new Point(r4l2.Location.X + 24, 249);
                    r4e6.Location = new Point(ComboBoxRel4.Location.X + 55, 249);
                    ComboBoxRel5.Location = new Point(r5l2.Location.X + 24, 275);
                    r5e6.Location = new Point(ComboBoxRel5.Location.X + 55, 275);
                    break;
                case 3:
                    varslabel.Text = "x1, x2, x3>= 0";
                    // first show x2, but if app knows that there is also x3
                    // then app also shows x3
                    X4_Hide();
                    X5_Hide();
                    X2_Show();
                    X3_Show();
                    ComboBoxMaxMin.Location = new Point(kl3.Location.X + 38, 116);
                    ComboBoxRel1.Location = new Point(r1l3.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X + 55, 171);
                    ComboBoxRel2.Location = new Point(r2l3.Location.X + 24, 197);
                    r2e6.Location = new Point(ComboBoxRel2.Location.X + 55, 197);
                    ComboBoxRel3.Location = new Point(r3l3.Location.X + 24, 223);
                    r3e6.Location = new Point(ComboBoxRel3.Location.X + 55, 223);
                    ComboBoxRel4.Location = new Point(r4l3.Location.X + 24, 249);
                    r4e6.Location = new Point(ComboBoxRel4.Location.X + 55, 249);
                    ComboBoxRel5.Location = new Point(r5l3.Location.X + 24, 275);
                    r5e6.Location = new Point(ComboBoxRel5.Location.X + 55, 275);
                    break;
                case 4:
                    varslabel.Text = "x1, x2, x3, x4>= 0";
                    X5_Hide();
                    X2_Show();
                    X3_Show();
                    X4_Show();
                    ComboBoxMaxMin.Location = new Point(kl4.Location.X + 38, 116);
                    ComboBoxRel1.Location = new Point(r1l4.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X + 55, 171);
                    ComboBoxRel2.Location = new Point(r2l4.Location.X + 24, 197);
                    r2e6.Location = new Point(ComboBoxRel2.Location.X + 55, 197);
                    ComboBoxRel3.Location = new Point(r3l4.Location.X + 24, 223);
                    r3e6.Location = new Point(ComboBoxRel3.Location.X + 55, 223);
                    ComboBoxRel4.Location = new Point(r4l4.Location.X + 24, 249);
                    r4e6.Location = new Point(ComboBoxRel4.Location.X + 55, 249);
                    ComboBoxRel5.Location = new Point(r5l4.Location.X + 24, 275);
                    r5e6.Location = new Point(ComboBoxRel5.Location.X + 55, 275);
                    break;
                case 5:
                    varslabel.Text = "x1, x2, x3, x4, x5>= 0";
                    X2_Show();
                    X3_Show();
                    X4_Show();
                    X5_Show();
                    ComboBoxMaxMin.Location = new Point(kl5.Location.X + 38, 116);
                    ComboBoxRel1.Location = new Point(r1l5.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X + 55, 171);
                    ComboBoxRel2.Location = new Point(r2l5.Location.X + 24, 197);
                    r2e6.Location = new Point(ComboBoxRel2.Location.X + 55, 197);
                    ComboBoxRel3.Location = new Point(r3l5.Location.X + 24, 223);
                    r3e6.Location = new Point(ComboBoxRel3.Location.X + 55, 223);
                    ComboBoxRel4.Location = new Point(r4l5.Location.X + 24, 249);
                    r4e6.Location = new Point(ComboBoxRel4.Location.X + 55, 249);
                    ComboBoxRel5.Location = new Point(r5l5.Location.X + 24, 275);
                    r5e6.Location = new Point(ComboBoxRel5.Location.X + 55, 275);
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
            switch (numericUpDown2.Value)
            {
                case 1:
                    Row2_Hide();
                    Row3_Hide();
                    Row4_Hide();
                    Row5_Hide();
                    varslabel.Location = new Point(14, r1e1.Location.Y+25);
                    break;
                case 2:
                    Row3_Hide();
                    Row4_Hide();
                    Row5_Hide();
                    Row2_Show();
                    varslabel.Location = new Point(14, r2e1.Location.Y + 25);
                    break;
                case 3:
                    Row4_Hide();
                    Row5_Hide();
                    Row2_Show();
                    Row3_Show();
                    varslabel.Location = new Point(14, r3e1.Location.Y + 25);
                    break;
                case 4:
                    Row5_Hide();
                    Row2_Show();
                    Row3_Show();
                    Row4_Show();
                    varslabel.Location = new Point(14, r4e1.Location.Y + 25);
                    break;
                case 5:
                    Row2_Show();
                    Row3_Show();
                    Row4_Show();
                    Row5_Show();
                    varslabel.Location = new Point(14, r5e1.Location.Y + 25);
                    break;
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBoxMaxMin.Text = "";
        }

    }
}
