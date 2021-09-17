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
            label5.Text = "";
            ComboBoxMaxMin.SelectedIndex = 0;
            ComboBoxRel1.SelectedIndex = 0;
            ComboBoxRel2.SelectedIndex = 0;
            ComboBoxRel3.SelectedIndex = 0;
            ComboBoxRel4.SelectedIndex = 0;
            ComboBoxRel5.SelectedIndex = 0;
            ClearTextBoxes();
        }
        public double[] Get_Numbers_From_Form()
        {
            double[] start_arr = new double[35];
            start_arr[0] = double.Parse(kx1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[1] = double.Parse(kx2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[2] = double.Parse(kx3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[3] = double.Parse(kx4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[4] = double.Parse(kx5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[5] = double.Parse(r1e1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[6] = double.Parse(r1e2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[7] = double.Parse(r1e3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[8] = double.Parse(r1e4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[9] = double.Parse(r1e5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[10] = double.Parse(r1e6.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[11] = double.Parse(r2e1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[12] = double.Parse(r2e2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[13] = double.Parse(r2e3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[14] = double.Parse(r2e4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[15] = double.Parse(r2e5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[16] = double.Parse(r2e6.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[17] = double.Parse(r3e1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[18] = double.Parse(r3e2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[19] = double.Parse(r3e3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[20] = double.Parse(r3e4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[21] = double.Parse(r3e5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[22] = double.Parse(r3e6.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[23] = double.Parse(r4e1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[24] = double.Parse(r4e2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[25] = double.Parse(r4e3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[26] = double.Parse(r4e4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[27] = double.Parse(r4e5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[28] = double.Parse(r4e6.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[29] = double.Parse(r5e1.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[30] = double.Parse(r5e2.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[31] = double.Parse(r5e3.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[32] = double.Parse(r5e4.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[33] = double.Parse(r5e5.Text, System.Globalization.CultureInfo.InvariantCulture);
            start_arr[34] = double.Parse(r5e6.Text, System.Globalization.CultureInfo.InvariantCulture);
            return start_arr;
        }
        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "0";
            };

            func(Controls);
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
            else if (numericUpDown1.Value > 5)
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
                    ComboBoxMaxMin.Location = new Point(kl1.Location.X + 38, 116);
                    ComboBoxRel1.Location = new Point(r1l1.Location.X + 24, 171);
                    r1e6.Location = new Point(ComboBoxRel1.Location.X + 55, 171);
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
                    varslabel.Location = new Point(14, r1e1.Location.Y + 25);
                    resultlabel.Location = new Point(14, varslabel.Location.Y + 20);
                    label5.Location = new Point(14, resultlabel.Location.Y + 20);
                    break;
                case 2:
                    Row3_Hide();
                    Row4_Hide();
                    Row5_Hide();
                    Row2_Show();
                    varslabel.Location = new Point(14, r2e1.Location.Y + 25);
                    resultlabel.Location = new Point(14, varslabel.Location.Y + 20);
                    label5.Location = new Point(14, resultlabel.Location.Y + 20);
                    break;
                case 3:
                    Row4_Hide();
                    Row5_Hide();
                    Row2_Show();
                    Row3_Show();
                    varslabel.Location = new Point(14, r3e1.Location.Y + 25);
                    resultlabel.Location = new Point(14, varslabel.Location.Y + 20);
                    label5.Location = new Point(14, resultlabel.Location.Y + 20);
                    break;
                case 4:
                    Row5_Hide();
                    Row2_Show();
                    Row3_Show();
                    Row4_Show();
                    varslabel.Location = new Point(14, r4e1.Location.Y + 25);
                    resultlabel.Location = new Point(14, varslabel.Location.Y + 20);
                    label5.Location = new Point(14, resultlabel.Location.Y + 20);
                    break;
                case 5:
                    Row2_Show();
                    Row3_Show();
                    Row4_Show();
                    Row5_Show();
                    varslabel.Location = new Point(14, r5e1.Location.Y + 25);
                    resultlabel.Location = new Point(14, varslabel.Location.Y + 20);
                    label5.Location = new Point(14, resultlabel.Location.Y + 20);
                    break;
            }
        }
        private void kx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.')
                && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void SolveButton_Click(object sender, EventArgs e)
        {
            double[] start_arr = new double[35];
            start_arr = Get_Numbers_From_Form();
            // numbers of x
            int x_nums = (int)numericUpDown1.Value;
            // number restrictions
            int restriction = (int)numericUpDown2.Value;
            double[,] table = new double[restriction + 1, x_nums + 1];
            int[] c_arr = new int[x_nums];
            for (int i = 0; i < x_nums; i++)
            {
                c_arr[i] = (int)start_arr[i];
            }
            switch (x_nums)
            {
                case 1:
                    table[0, 0] = start_arr[0];
                    switch (ComboBoxMaxMin.SelectedIndex)
                    {
                        case 0:
                            table[0, 1] = 0;    // max
                            break;
                        case 1:
                            table[0, 1] = 1;    //min
                            break;
                    }
                    break;
                case 2:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    switch (ComboBoxMaxMin.SelectedIndex)
                    {
                        case 0:
                            table[0, 2] = 0;    // max
                            break;
                        case 1:
                            table[0, 2] = 1;    //min
                            break;
                    }
                    break;
                case 3:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    switch (ComboBoxMaxMin.SelectedIndex)
                    {
                        case 0:
                            table[0, 3] = 0;    // max
                            break;
                        case 1:
                            table[0, 3] = 1;    //min
                            break;
                    }
                    break;
                case 4:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    table[0, 3] = start_arr[3];
                    switch (ComboBoxMaxMin.SelectedIndex)
                    {
                        case 0:
                            table[0, 4] = 0;    // max
                            break;
                        case 1:
                            table[0, 4] = 1;    //min
                            break;
                    }
                    break;
                case 5:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    table[0, 3] = start_arr[3];
                    table[0, 4] = start_arr[4];
                    switch (ComboBoxMaxMin.SelectedIndex)
                    {
                        case 0:
                            table[0, 5] = 0;    // max
                            break;
                        case 1:
                            table[0, 5] = 1;    //min
                            break;
                    }
                    break;
            }
            for (int i = 1; i < restriction + 1; i++)
            {
                for (int j = 0; j < x_nums + 1; j++)
                {
                    if (j == x_nums)
                    {
                        table[i, j] = start_arr[5 + ((i - 1) * 6) + 5];
                    }
                    else
                    {
                        table[i, j] = start_arr[5 + ((i - 1) * 6) + j];
                    }
                }
            }
            string result = "Введённые данные\n";
            for (int i = 0; i < restriction + 1; i++)
            {
                for (int j = 0; j < x_nums + 1; j++)
                {
                    if ((j == x_nums) && (i == 0))
                    {
                        switch (table[i, j])
                        {
                            case 0:
                                result = result + "→ max";
                                break;
                            case 1:
                                result = result + "→ min";
                                break;
                        }
                    }
                    else if (j < x_nums - 1)
                    {
                        result = result + table[i, j] + "x" + (j + 1) + " + ";
                    }
                    else if (j == x_nums - 1)
                    {
                        result = result + table[i, j] + "x" + (j + 1) + " ";
                        switch (i)
                        {
                            case 1:
                                switch (ComboBoxRel1.SelectedIndex)
                                {
                                    case 0:
                                        result = result + "<= ";
                                        break;
                                    case 1:
                                        result = result + "= ";
                                        break;
                                    case 2:
                                        result = result + ">= ";
                                        break;
                                }
                                break;
                            case 2:
                                switch (ComboBoxRel2.SelectedIndex)
                                {
                                    case 0:
                                        result = result + "<= ";
                                        break;
                                    case 1:
                                        result = result + "= ";
                                        break;
                                    case 2:
                                        result = result + ">= ";
                                        break;
                                }
                                break;
                            case 3:
                                switch (ComboBoxRel3.SelectedIndex)
                                {
                                    case 0:
                                        result = result + "<= ";
                                        break;
                                    case 1:
                                        result = result + "= ";
                                        break;
                                    case 2:
                                        result = result + ">= ";
                                        break;
                                }
                                break;
                            case 4:
                                switch (ComboBoxRel4.SelectedIndex)
                                {
                                    case 0:
                                        result = result + "<= ";
                                        break;
                                    case 1:
                                        result = result + "= ";
                                        break;
                                    case 2:
                                        result = result + ">= ";
                                        break;
                                }
                                break;
                            case 5:
                                switch (ComboBoxRel5.SelectedIndex)
                                {
                                    case 0:
                                        result = result + "<= ";
                                        break;
                                    case 1:
                                        result = result + "= ";
                                        break;
                                    case 2:
                                        result = result + ">= ";
                                        break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        result = result + table[i, j];
                    }

                }
                result = result + "\n";
            }
            result = result + "Решение базовым симплекс-методом";
            bool Is_More_Or_Equals = false;
            for (int i = 1; i < restriction + 1; i++)
            {
                switch (i)
                {
                    case 1:
                        switch (ComboBoxRel1.SelectedIndex)
                        {
                            case 2:
                                // reverse row
                                for (int j = 0; j < x_nums + 1; j++)
                                {
                                    table[i, j] = table[i, j] * (-1);
                                }
                                Is_More_Or_Equals = true;
                                break;
                        }
                        break;
                    case 2:
                        switch (ComboBoxRel2.SelectedIndex)
                        {
                            case 2:
                                // reverse row
                                for (int j = 0; j < x_nums + 1; j++)
                                {
                                    table[i, j] = table[i, j] * (-1);
                                }
                                Is_More_Or_Equals = true;
                                break;
                        }
                        break;
                    case 3:
                        switch (ComboBoxRel3.SelectedIndex)
                        {
                            case 2:
                                // reverse row
                                for (int j = 0; j < x_nums + 1; j++)
                                {
                                    table[i, j] = table[i, j] * (-1);
                                }
                                Is_More_Or_Equals = true;
                                break;
                        }
                        break;
                    case 4:
                        switch (ComboBoxRel4.SelectedIndex)
                        {
                            case 2:
                                // reverse row
                                for (int j = 0; j < x_nums + 1; j++)
                                {
                                    table[i, j] = table[i, j] * (-1);
                                }
                                Is_More_Or_Equals = true;
                                break;
                        }
                        break;
                    case 5:
                        switch (ComboBoxRel5.SelectedIndex)
                        {
                            case 2:
                                // reverse row
                                for (int j = 0; j < x_nums + 1; j++)
                                {
                                    table[i, j] = table[i, j] * (-1);
                                }
                                Is_More_Or_Equals = true;
                                break;
                        }
                        break;
                }
            }
            if (Is_More_Or_Equals)
            {
                result = result + "\nМеняем знаки у ограничений с >= путём умножения на -1:\n";
                for (int i = 1; i < restriction + 1; i++)
                {
                    for (int j = 0; j < x_nums + 1; j++)
                    {
                        if (j < x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " + ";
                        }
                        else if (j == x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " ";
                            switch (i)
                            {
                                case 1:
                                    switch (ComboBoxRel1.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "<= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "<= ";
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (ComboBoxRel2.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "<= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "<= ";
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (ComboBoxRel3.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "<= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "<= ";
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (ComboBoxRel4.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "<= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "<= ";
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (ComboBoxRel5.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "<= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "<= ";
                                            break;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            result = result + table[i, j];
                        }

                    }
                    result = result + "\n";
                }
            }
            int Inequality_Constraints = 0;
            for (int i = 0; i < restriction + 1; i++)
            {
                switch (i)
                {
                    case 1:
                        switch (ComboBoxRel1.SelectedIndex)
                        {
                            case 0:
                                Inequality_Constraints++;
                                break;
                            case 2:
                                Inequality_Constraints++;
                                break;
                        }
                        break;
                    case 2:
                        switch (ComboBoxRel2.SelectedIndex)
                        {
                            case 0:
                                Inequality_Constraints += 2;
                                break;
                            case 2:
                                Inequality_Constraints += 2;
                                break;
                        }
                        break;
                    case 3:
                        switch (ComboBoxRel3.SelectedIndex)
                        {
                            case 0:
                                Inequality_Constraints += 4;
                                break;
                            case 2:
                                Inequality_Constraints += 4;
                                break;
                        }
                        break;
                    case 4:
                        switch (ComboBoxRel4.SelectedIndex)
                        {
                            case 0:
                                Inequality_Constraints += 8;
                                break;
                            case 2:
                                Inequality_Constraints += 8;
                                break;
                        }
                        break;
                    case 5:
                        switch (ComboBoxRel5.SelectedIndex)
                        {
                            case 0:
                                Inequality_Constraints += 16;
                                break;
                            case 2:
                                Inequality_Constraints += 16;
                                break;
                        }
                        break;
                }
            }
            int IC_BACKUP = Inequality_Constraints;
            int ICN_COUNTER = 0;
            while (IC_BACKUP != 0)
            {
                ICN_COUNTER += IC_BACKUP % 2;
                IC_BACKUP = IC_BACKUP >> 1;
            }
            IC_BACKUP = Inequality_Constraints;
            if (result.Last() != '\n')
            {
                result = result + "\n";
            }
            if (ICN_COUNTER > 1)
            {
                result = result + "Для каждого ограничения с неравенством добавляем дополнительные переменные";
                // поменять
                switch (ICN_COUNTER)
                {
                    case 2:
                        result = result + " x" + (x_nums + 1);
                        result = result + " и x" + (x_nums + 2) + ".";
                        break;
                    case 3:
                        result = result + " x" + (x_nums + 1);
                        result = result + "..x" + (x_nums + 3) + ".";
                        break;
                    case 4:
                        result = result + " x" + (x_nums + 1);
                        result = result + "..x" + (x_nums + 4) + ".";
                        break;
                    case 5:
                        result = result + " x" + (x_nums + 1);
                        result = result + "..x" + (x_nums + 5) + ".";
                        break;
                }
                result = result + "\nПерепишем ограничения в каноническом виде:\n";
                int j_max = x_nums + 1;
                for (int i = 1; i < restriction + 1; i++)
                {
                    for (int j = 0; j < x_nums + 1; j++)
                    {
                        if (j < x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " + ";
                        }
                        else if (j == x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " ";
                            switch (i)
                            {
                                case 1:
                                    switch (ComboBoxRel1.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (ComboBoxRel2.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (ComboBoxRel3.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (ComboBoxRel4.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (ComboBoxRel5.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            result = result + table[i, j];
                        }

                    }
                    result = result + "\n";
                }
            }
            else if (ICN_COUNTER == 1)
            {
                result = result + "Для ограничения с неравенством добавляем дополнительную переменную";
                result = result + " x" + (x_nums + 1);
                result = result + "\nПерепишем ограничения в каноническом виде:\n";
                int j_max = x_nums + 1;
                for (int i = 1; i < restriction + 1; i++)
                {
                    for (int j = 0; j < x_nums + 1; j++)
                    {
                        if (j < x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " + ";
                        }
                        else if (j == x_nums - 1)
                        {
                            result = result + table[i, j] + "x" + (j + 1) + " ";
                            switch (i)
                            {
                                case 1:
                                    switch (ComboBoxRel1.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (ComboBoxRel2.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (ComboBoxRel3.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (ComboBoxRel4.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (ComboBoxRel5.SelectedIndex)
                                    {
                                        case 0:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                        case 1:
                                            result = result + "= ";
                                            break;
                                        case 2:
                                            result = result + "+ x" + j_max + " ";
                                            j_max++;
                                            result = result + "= ";
                                            break;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            result = result + table[i, j];
                        }

                    }
                    result = result + "\n";
                }
            }
            result = result + "Ищем начальное базисное решение:\n";
            int jj_max = x_nums + 1;
            for (int i = 0; i < restriction+1; i++)
            {
                switch (i)
                {
                    case 1:
                        if (ComboBoxRel1.SelectedIndex == 0 || ComboBoxRel1.SelectedIndex == 2)
                        {
                            result = result + "Ограничение 1 содержит неравенство, базисной будет добавленная дополнительная переменная x" + jj_max;
                            jj_max++;
                        }
                        else
                        {
                            result = result + "Ограничение 1 содержит равенство. Базисная переменная для этого ограничения будет определена позднее.";
                        }
                        result = result + "\n";
                        break;
                    case 2:
                        if (ComboBoxRel2.SelectedIndex == 0 || ComboBoxRel2.SelectedIndex == 2)
                        {
                            result = result + "Ограничение 2 содержит неравенство, базисной будет добавленная дополнительная переменная x" + jj_max;
                            jj_max++;
                        }
                        else
                        {
                            result = result + "Ограничение 2 содержит равенство. Базисная переменная для этого ограничения будет определена позднее.";
                        }
                        result = result + "\n";
                        break;
                    case 3:
                        if (ComboBoxRel3.SelectedIndex == 0 || ComboBoxRel3.SelectedIndex == 2)
                        {
                            result = result + "Ограничение 3 содержит неравенство, базисной будет добавленная дополнительная переменная x" + jj_max;
                            jj_max++;
                        }
                        else
                        {
                            result = result + "Ограничение 3 содержит равенство. Базисная переменная для этого ограничения будет определена позднее.";
                        }
                        result = result + "\n";
                        break;
                    case 4:
                        if (ComboBoxRel4.SelectedIndex == 0 || ComboBoxRel4.SelectedIndex == 2)
                        {
                            result = result + "Ограничение 4 содержит неравенство, базисной будет добавленная дополнительная переменная x" + jj_max;
                            jj_max++;
                        }
                        else
                        {
                            result = result + "Ограничение 4 содержит равенство. Базисная переменная для этого ограничения будет определена позднее.";
                        }
                        result = result + "\n";
                        break;
                    case 5:
                        if (ComboBoxRel5.SelectedIndex == 0 || ComboBoxRel5.SelectedIndex == 2)
                        {
                            result = result + "Ограничение 5 содержит неравенство, базисной будет добавленная дополнительная переменная x" + jj_max;
                            jj_max++;
                        }
                        else
                        {
                            result = result + "Ограничение 5 содержит равенство. Базисная переменная для этого ограничения будет определена позднее.";
                        }
                        result = result + "\n";
                        break;
                }
            }
            label5.Text = result;
        }
    }

}