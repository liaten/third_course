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
            ComboBoxMaxMin.SelectedIndex = 0;
            ComboBoxRel1.SelectedIndex = 0;
            ComboBoxRel2.SelectedIndex = 0;
            ComboBoxRel3.SelectedIndex = 0;
            ComboBoxRel4.SelectedIndex = 0;
            ComboBoxRel5.SelectedIndex = 0;
            ClearTextBoxes();
        }
        public bool IsMax()
        {
            if (ComboBoxMaxMin.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double[] Get_Numbers_From_Form()
        {
            double[] start_arr = new double[35];
            try
            {
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
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
                    richTextBox1.Location = new Point(SolveButton.Location.X + 82, 32);
                    resultlabel.Location = new Point(richTextBox1.Location.X, 9);
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
                    richTextBox1.Location = new Point(r1e6.Location.X + 62, 32);
                    resultlabel.Location = new Point(richTextBox1.Location.X, 9);
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
                    richTextBox1.Location = new Point(r1e6.Location.X + 62, 32);
                    resultlabel.Location = new Point(richTextBox1.Location.X, 9);
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
                    richTextBox1.Location = new Point(r1e6.Location.X + 62, 32);
                    resultlabel.Location = new Point(richTextBox1.Location.X, 9);
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
                    richTextBox1.Location = new Point(r1e6.Location.X + 62, 32);
                    resultlabel.Location = new Point(richTextBox1.Location.X, 9);
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
        private void kx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.')
                && (e.KeyChar != '-')
                )
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.')
                && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-')
                && ((sender as TextBox).Text.IndexOf('-') > -1))
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
            if (Get_Numbers_From_Form() == null)
            {
                return;
            }
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
                    break;
                case 2:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    break;
                case 3:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    break;
                case 4:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    table[0, 3] = start_arr[3];
                    break;
                case 5:
                    table[0, 0] = start_arr[0];
                    table[0, 1] = start_arr[1];
                    table[0, 2] = start_arr[2];
                    table[0, 3] = start_arr[3];
                    table[0, 4] = start_arr[4];
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
            int Inequality_Constraints = 0; // эту переменную мы не трогаем!!
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
            int sy = restriction + 2;
            int sx = x_nums + 1 + ICN_COUNTER;
            double[,] simplex = new double[sy, sx];    //место для дельт, базиса, коэффициентов C
            IC_BACKUP = Inequality_Constraints;
            int max_x = x_nums-1;
            // заполнение первичного массива симплекс метода
            for (int i = 0; i < sy; i++)
            {
                for(int j = 0; j < sx; j++)
                {
                    if (i == 0)
                    {
                        if (j <= x_nums)
                        {
                            simplex[i, j] = table[i, j];
                        }
                        else
                        {
                            simplex[i, j] = 0;
                        }
                    }
                    else if (i == (sy - 1))
                    {
                        simplex[i, j] = 0;
                    }
                    else
                    {
                        try
                        {
                            simplex[i, j] = table[i, j];
                        }
                        catch (System.IndexOutOfRangeException)
                        {
                            if (j == (sx-1) )
                            {
                                simplex[i, (sx - 1)] = simplex[i, (x_nums)];
                                simplex[i, x_nums] = 0;
                            }
                            else
                            {
                                simplex[i, j] = 0;
                            }
                        };
                    }
                }
            }
            for(int i = 0; i < sy; i++)
            {
                if ((IC_BACKUP % 2) == 1)
                {
                    simplex[i + 1, max_x++ + 1] = 1;
                }
                IC_BACKUP = IC_BACKUP >> 1;
            }
            result = result + "Начальная симплекс-таблица\n";
            IC_BACKUP = Inequality_Constraints;
            max_x = x_nums;
            int unknown = 0;
            string[] basis_strings = new string[restriction];
            int[] basis_ints = new int[restriction];
            // вывод первичного массива симплекс метода
            for (int i = 0; i < sy-1; i++)
            {
                if (i == 0)
                {
                    result = result + "C\t";
                }
                else if (i == (sy - 1))
                {
                    result = result + "Δ\t";
                }
                else
                {
                    string to_basis = "";
                    if ( (IC_BACKUP % 2) == 1 )
                    {
                        max_x++;
                        to_basis = to_basis + "x" + max_x;
                        basis_strings[i - 1] = to_basis;
                        basis_ints[i - 1] = max_x;
                        result = result + to_basis + "\t";
                    }
                    else
                    {
                        unknown++;
                        to_basis = to_basis + "?" + unknown;
                        basis_strings[i - 1] = to_basis;
                        result = result + to_basis + "\t";
                    }
                    IC_BACKUP = IC_BACKUP >> 1;
                    
                }
                for (int j = 0; j < sx; j++)
                {
                    result = result + simplex[i, j]+"\t";
                }
                result = result + "\n";
                if (i == 0)
                {
                    result = result + "базис\t";
                    for(int j = 0; j < sx - 1; j++)
                    {
                        result = result + "x" + (j + 1) + "\t";
                    }
                    result = result + "b\n";
                }
            }
            if (ICN_COUNTER != restriction)
            {
                result = result + "Ищем базис\n";
                IC_BACKUP = Inequality_Constraints;
                unknown = 0;
                List<int> PickedList = new List<int>();
                for (int i = 1; i < sy - 1; i++)
                {
                    if ((IC_BACKUP % 2) !=1)
                    {
                        unknown++;
                        for(int j = 0; j < x_nums; j++)
                        {
                            if ((simplex[i, j] != 0) && !PickedList.Contains(j))
                            {
                                result = result + "В качестве базисной переменной ?" + unknown + " берём x" + (j+1) + ".\n";
                                string to_basis = "x" + (j + 1);
                                basis_strings[i - 1] = to_basis;
                                basis_ints[i - 1] = j + 1;
                                double divider = simplex[i, j];
                                result = result + "Делим строку " + i + " на " + divider + ".\n";
                                
                                for(int k = 0; k < sx; k++)
                                {
                                    simplex[i, k] /= divider;
                                }
                                // выведем строку i
                                //result = result + "x" + (j + 1) + "\t";
                                //for(int k = 0; k < sx; k++)
                                //{
                                //    result = result + Math.Round(simplex[i,k],2) + "\t";
                                //}
                                //result = result + "\n";

                                if (restriction > 1)
                                {
                                    result = result + "Из строк";
                                    if (restriction > 2)
                                    {
                                        result = result + " ";
                                    }
                                    else
                                    {
                                        result = result + "и ";
                                    }
                                    for (int k = 1; k < sy - 1; k++)
                                    {
                                        if (k != i)
                                        {
                                            result = result + k + ", ";
                                            double simplex_multiplier = simplex[k, j];
                                            for(int l = 0; l < sx; l++)
                                            {
                                                simplex[k, l] += (simplex[i, l] * (-1) * simplex_multiplier); 
                                            }
                                        }
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result = result + " вычитаем строку " + i + ", умноженную на соответствующий элемент в столбце " + (j + 1) + ".\n";
                                }
                                PickedList.Add(j);
                                break;
                            }
                        }
                    }
                    IC_BACKUP = IC_BACKUP >> 1;
                }

                result = result + "Таблица:\n";
                IC_BACKUP = Inequality_Constraints;
                for (int i = 0; i < sy - 1; i++)
                {
                    if (i == 0)
                    {
                        result = result + "C\t";
                    }
                    else if (i == (sy - 1))
                    {
                        result = result + "Δ\t";
                    }
                    else
                    {
                        if ((IC_BACKUP % 2) == 1)
                        {
                            result = result + basis_strings[i - 1] + "\t";
                        }
                        else
                        {
                            result = result + basis_strings[i - 1] + "\t";
                        }
                        IC_BACKUP = IC_BACKUP >> 1;

                    }
                    for (int j = 0; j < sx; j++)
                    {
                        result = result + Math.Round(simplex[i,j],2) + "\t";
                    }
                    result = result + "\n";
                    if (i == 0)
                    {
                        result = result + "базис\t";
                        for (int j = 0; j < sx - 1; j++)
                        {
                            result = result + "x" + (j + 1) + "\t";
                        }
                        result = result + "b\n";
                    }
                }
            }
            bool Has_Negative_B = false;
            for(int i = 1; i < sy - 1; i++)
            {
                if (simplex[i, sx - 1] < 0)
                {
                    Has_Negative_B = true;
                    result = result + "В столбце b присутствуют отрицательные значения.";
                    break;
                }
            }
            bool No_Solution = false;
            while (Has_Negative_B == true)
            {
                double max_module_b = 0; // значение макс модуля b в строке
                int max_module_b_position = 0;  // значение строки с максимальным модулем b
                if (sy > 3)
                {
                    for (int i = 1; i < sy - 1; i++)
                    {
                        if ((Math.Abs(simplex[i, sx - 1]) > max_module_b) && (simplex[i, sx - 1]<0) )
                        {
                            max_module_b = Math.Abs(simplex[i, sx - 1]);
                            max_module_b_position = i;
                        }
                    }
                }
                result = result + "\nМаксимальное по модулю |b|max = |" + simplex[max_module_b_position, sx - 1]
                                + "| находится в строке " + max_module_b_position + ".";
                bool Has_Negative_Elements = false;
                for(int i = 0; i < sx - 1; i++)
                {
                    if(simplex[max_module_b_position, i] < 0)
                    {
                        Has_Negative_Elements = true;
                    }
                }
                if (Has_Negative_Elements)
                {
                    double max_module_element = 0;    // значение максимального элемента в строке
                    int max_module_element_position = 0;    // значение колонки максимального элемента строки
                    if (sx > 2)
                    {
                        for (int i = 0; i < sx - 1; i++)
                        {
                            if ((Math.Abs(simplex[max_module_b_position, i]) > max_module_element) && (simplex[max_module_b_position, i] < 0))
                            {
                                max_module_element = Math.Abs(simplex[max_module_b_position, i]);
                                max_module_element_position = i;
                            }
                        }
                    }
                    result = result + "\nМаксимальный по модулю элемент в строке " + max_module_b_position + " = "
                                    + simplex[max_module_b_position, max_module_element_position] + " находится в столбце "
                                    + (max_module_element_position + 1) + ".";
                    result = result + "\nВ качестве базисной переменной " + basis_strings[max_module_b_position - 1] + " берём x" + (max_module_element_position + 1) + ".";
                    result = result + "\nДелим строку " + max_module_b_position + " на " + simplex[max_module_b_position, max_module_element_position] + ".";
                    double divider = simplex[max_module_b_position, max_module_element_position];
                    for (int k = 0; k < sx; k++)
                    {
                        simplex[max_module_b_position, k] /= divider;
                    }
                    if (restriction > 1)
                    {
                        result = result + "Из строк";
                        if (restriction > 2)
                        {
                            result = result + " ";
                        }
                        else
                        {
                            result = result + "и ";
                        }
                        for (int k = 1; k < sy - 1; k++)
                        {
                            if (k != max_module_b_position)
                            {
                                result = result + k + ", ";
                                double simplex_multiplier = simplex[k, max_module_element_position];
                                for (int l = 0; l < sx; l++)
                                {
                                    simplex[k, l] += (simplex[max_module_b_position, l] * (-1) * simplex_multiplier);
                                }
                            }
                        }
                        result = result.Remove(result.Length - 2);
                        result = result + " вычитаем строку " + max_module_b_position + ", умноженную на соответствующий элемент в столбце " + (max_module_element_position + 1) + ".\n";
                    }
                    result = result + "Обновлённая таблица:\n";
                    for (int i = 0; i < sy - 1; i++)
                    {
                        if (i == 0)
                        {
                            result = result + "C\t";
                        }
                        else if (i == (sy - 1))
                        {
                            result = result + "Δ\t";
                        }
                        else
                        {
                            if ((IC_BACKUP % 2) == 1)
                            {
                                result = result + basis_strings[i - 1] + "\t";
                            }
                            else
                            {
                                result = result + basis_strings[i - 1] + "\t";
                            }
                            IC_BACKUP = IC_BACKUP >> 1;

                        }
                        for (int j = 0; j < sx; j++)
                        {
                            result = result + Math.Round(simplex[i, j], 2) + "\t";
                        }
                        result = result + "\n";
                        if (i == 0)
                        {
                            result = result + "базис\t";
                            for (int j = 0; j < sx - 1; j++)
                            {
                                result = result + "x" + (j + 1) + "\t";
                            }
                            result = result + "b\n";
                        }
                    }

                }
                else
                {
                    result = result + "\nВ строке " + max_module_b_position + " отсутстуют отрицательные значения. Решение задачи не существует.";
                    No_Solution = true;
                    break;
                }
                Has_Negative_B = false;
                for (int i = 1; i < sy - 1; i++)
                {
                    if (simplex[i, sx - 1] < 0)
                    {
                        Has_Negative_B = true;
                        result = result + "В столбце b присутствуют отрицательные значения.";
                        break;
                    }
                }
                if(Has_Negative_B == false)
                {
                    break;
                }
            }
            if(No_Solution == false)
                // первая дельта - первый столбец
                // вторая дельта - второй столбец и так далее
            {
                result += "Вычисляем дельты: Δi = ";
                for(int i = 0; i < restriction; i++)
                {
                    result += "C" + basis_ints[i] + " * a" + (i + 1) + "i + ";
                }
                result = result.Remove(result.Length - 2);
                result += " - Ci\n";
                for(int i = 0; i < sx - 1; i++)
                {
                    result += "Δ" + (i + 1) + " = ";
                    for(int j = 0; j < restriction; j++)
                    {
                        result += "C" + basis_ints[j] + " * a" + (j + 1) + (i+1) + " + ";
                    }
                    result = result.Remove(result.Length - 2);
                    result += " - C" + (i + 1) + " = ";
                    double delta = 0;
                    for(int j = 0; j < restriction; j++)
                    {
                        result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                        result += Math.Round(simplex[(j + 1), (i)], 2) + " + ";
                        delta += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (i)]);
                    }
                    result = result.Remove(result.Length - 2);
                    result += "- " + Math.Round(simplex[0, i], 2);
                    delta -= simplex[0, i];
                    result += " = " + Math.Round(delta,2) + "\n";
                    simplex[sy - 1, i] = delta;
                }

                result += "Δb = ";
                for (int i = 0; i < restriction; i++)
                {
                    result += "C" + basis_ints[i] + " * b" + (i + 1) + " + ";
                }
                result = result.Remove(result.Length - 2);
                result += " - C" + sx + " = ";
                double delta_b = 0;
                for (int j = 0; j < restriction; j++)
                {
                    result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                    result += Math.Round(simplex[(j + 1), (sx - 1)], 2) + " + ";
                    delta_b += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (sx - 1)]);
                }
                result = result.Remove(result.Length - 2);
                delta_b -= simplex[0, sx - 1];
                result += "- " + Math.Round(simplex[0, sx - 1], 2) + " = " + Math.Round(delta_b, 2) + "\n";
                simplex[sy - 1, sx - 1] = delta_b;
                result += "Симплекс-таблица с дельтами\n";
                IC_BACKUP = Inequality_Constraints;
                for (int i = 0; i < sy; i++)
                {
                    if (i == 0)
                    {
                        result = result + "C\t";
                    }
                    else if (i == (sy - 1))
                    {
                        result = result + "Δ\t";
                    }
                    else
                    {
                        if ((IC_BACKUP % 2) == 1)
                        {
                            result = result + basis_strings[i - 1] + "\t";
                        }
                        else
                        {
                            result = result + basis_strings[i - 1] + "\t";
                        }
                        IC_BACKUP = IC_BACKUP >> 1;

                    }
                    for (int j = 0; j < sx; j++)
                    {
                        result = result + Math.Round(simplex[i, j], 2) + "\t";
                    }
                    result = result + "\n";
                    if (i == 0)
                    {
                        result = result + "базис\t";
                        for (int j = 0; j < sx - 1; j++)
                        {
                            result = result + "x" + (j + 1) + "\t";
                        }
                        result = result + "b\n";
                    }
                }
                bool Plan_Is_Optimal = false;
                int iteration = 0;
                while (Plan_Is_Optimal == false)
                {
                    result += "Проверяем план на оптимальность\n(Критерий оптимальности: план оптимален, если в таблице отсутствуют ";
                    Plan_Is_Optimal = true;
                    double not_optimal_delta = 0;
                    int not_optimal_delta_place = 0;
                    if (IsMax())
                    {
                        result += "отрицательные дельты).";
                        for (int i = 0; i < sx - 1; i++)
                        {
                            if (simplex[sy - 1, i] < 0)
                            {
                                Plan_Is_Optimal = false;
                                not_optimal_delta_place = i;
                                not_optimal_delta = simplex[sy - 1, i];
                                break;
                            }
                        }
                        if (Plan_Is_Optimal)
                        {
                            double[] x_result = new double[x_nums];
                            for (int i = 0; i < restriction; i++)
                            {
                                result += basis_ints[i] + " ";
                            }
                            result += "\nПлан оптимален, так как отрицательные дельты отсутствуют.\nОтвет:";
                            // доделать - ответ неверный
                            for (int i = 0; i < x_nums; i++)
                            {
                                bool i_exists = false;
                                for (int j = 0; j < restriction; j++)
                                {
                                    if ((i + 1) == basis_ints[j])
                                    {
                                        x_result[i] = simplex[j + 1, (sx - 1)];
                                        result += "\nx" + (i + 1) + " = " + simplex[j + 1, (sx - 1)];
                                        i_exists = true;
                                    }
                                }
                                if (i_exists == false)
                                {
                                    result += "\nx" + (i + 1) + " = 0";
                                    x_result[i] = 0;
                                }
                            }
                            result += "\nF = ";
                            double F = 0;
                            for (int i = 0; i < x_nums; i++)
                            {
                                F += x_result[i] * simplex[0, i];
                            }
                            result += F;
                        }
                        else
                        {
                            result += "\nПлан не оптимален, так как Δ" + (not_optimal_delta_place + 1) + " = " + not_optimal_delta + "\n";
                            iteration++;
                            result += "Итерация " + iteration;
                            result += "\nОпределяем разрешающий столбец - столбец, в котором находится минимальная дельта: ";
                            double min_delta = simplex[(sy - 1), 0];
                            int min_delta_place = 0;
                            for (int i = 1; i < sx - 1; i++)
                            {
                                if (simplex[(sy - 1), i] < min_delta)
                                {
                                    min_delta = simplex[(sy - 1), i];
                                    min_delta_place = i;
                                }
                            }
                            result += (min_delta_place + 1);
                            result += ", Δ" + (min_delta_place + 1) + " = " + min_delta;
                            result += "\nНаходим симплекс-отношения Q путём деления коэффициентов b на соответствующие значения столбца " + (min_delta_place + 1) + ".\n";
                            double Q_min = simplex[1, (sx - 1)] / simplex[1, min_delta_place];
                            int Q_min_position = 1;
                            IC_BACKUP = Inequality_Constraints;
                            for (int i = 0; i < sy; i++)
                            {
                                if (i == 0)
                                {
                                    result = result + "C\t";
                                }
                                else if (i == (sy - 1))
                                {
                                    result = result + "Δ\t";
                                }
                                else
                                {
                                    if ((IC_BACKUP % 2) == 1)
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    else
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    IC_BACKUP = IC_BACKUP >> 1;

                                }

                                for (int j = 0; j < sx; j++)
                                {
                                    result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    if ((j == (sx - 1)) && (i > 0) && (i < sy - 1))
                                    {
                                        double Q = simplex[i, j] / simplex[i, min_delta_place];
                                        if (Q < Q_min)
                                        {
                                            Q_min = Q;
                                            Q_min_position = i;
                                        }
                                        result += Math.Round(simplex[i, j], 2) + " / " + Math.Round(simplex[i, min_delta_place], 2) + " = " + Math.Round(Q, 2);
                                    }
                                }
                                result = result + "\n";
                                if (i == 0)
                                {
                                    result = result + "базис\t";
                                    for (int j = 0; j < sx - 1; j++)
                                    {
                                        result = result + "x" + (j + 1) + "\t";
                                    }
                                    result = result + "b\tQ\n";
                                }
                            }
                            result += "В найденном столбце ищем строку с наименьшим значением Q: Q(min) = " + Q_min + ", строка " + Q_min_position + ".\n";
                            result += "На пересечении найденных строки и столбца находится разрешающий элемент: " + simplex[Q_min_position, min_delta_place] + ".\n";
                            result += "В качестве базисной переменной x" + basis_ints[Q_min_position - 1] + " берём x" + (min_delta_place + 1) + "\n";
                            basis_ints[Q_min_position - 1] = min_delta_place + 1;
                            basis_strings[Q_min_position - 1] = "x" + (min_delta_place + 1);
                            IC_BACKUP = Inequality_Constraints;
                            bool All_Q_Negative = true;
                            for (int i = 0; i < sy; i++)
                            {
                                if (i == 0)
                                {
                                    result = result + "C\t";
                                }
                                else if (i == (sy - 1))
                                {
                                    result = result + "Δ\t";
                                }
                                else
                                {
                                    if ((IC_BACKUP % 2) == 1)
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    else
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    IC_BACKUP = IC_BACKUP >> 1;

                                }

                                for (int j = 0; j < sx; j++)
                                {
                                    result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    if ((j == (sx - 1)) && (i > 0) && (i < sy - 1))
                                    {
                                        double Q = simplex[i, j] / simplex[i, min_delta_place];
                                        if (Q > 0)
                                        {
                                            result += Math.Round(Q, 2);
                                            All_Q_Negative = false;
                                        }
                                        else
                                        {
                                            result += "-";
                                        }
                                    }
                                }
                                result = result + "\n";
                                if (i == 0)
                                {
                                    result = result + "базис\t";
                                    for (int j = 0; j < sx - 1; j++)
                                    {
                                        result = result + "x" + (j + 1) + "\t";
                                    }
                                    result = result + "b\tQ\n";
                                }
                            }
                            if (All_Q_Negative == false)
                            {
                                result += "Делим строку " + Q_min_position + " на " + simplex[Q_min_position, min_delta_place] + ".";
                                double divider = simplex[Q_min_position, min_delta_place];
                                for (int k = 0; k < sx; k++)
                                {
                                    simplex[Q_min_position, k] /= divider;
                                }
                                if (restriction > 1)
                                {
                                    result = result + " Из строк";
                                    if (restriction > 2)
                                    {
                                        result = result + " ";
                                    }
                                    else
                                    {
                                        result = result + "и ";
                                    }
                                    for (int k = 1; k < sy - 1; k++)
                                    {
                                        if (k != Q_min_position)
                                        {
                                            result = result + k + ", ";
                                            double simplex_multiplier = simplex[k, min_delta_place];
                                            for (int l = 0; l < sx; l++)
                                            {
                                                simplex[k, l] += (simplex[Q_min_position, l] * (-1) * simplex_multiplier);
                                            }
                                        }
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result = result + " вычитаем строку " + Q_min_position + ", умноженную на соответствующий элемент в столбце " + (min_delta_place + 1) + ".\n";
                                }
                                result += "Вычисляем новые дельты: Δi = ";
                                for (int i = 0; i < restriction; i++)
                                {
                                    result += "C" + basis_ints[i] + " * a" + (i + 1) + "i + ";
                                }
                                result = result.Remove(result.Length - 2);
                                result += " - Ci\n";
                                for (int i = 0; i < sx - 1; i++)
                                {
                                    result += "Δ" + (i + 1) + " = ";
                                    for (int j = 0; j < restriction; j++)
                                    {
                                        result += "C" + basis_ints[j] + " * a" + (j + 1) + (i + 1) + " + ";
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result += " - C" + (i + 1) + " = ";
                                    double delta = 0;
                                    for (int j = 0; j < restriction; j++)
                                    {
                                        result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                                        result += Math.Round(simplex[(j + 1), (i)], 2) + " + ";
                                        delta += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (i)]);
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result += "- " + Math.Round(simplex[0, i], 2);
                                    delta -= simplex[0, i];
                                    result += " = " + Math.Round(delta, 2) + "\n";
                                    simplex[sy - 1, i] = delta;
                                }

                                result += "Δb = ";
                                for (int i = 0; i < restriction; i++)
                                {
                                    result += "C" + basis_ints[i] + " * b" + (i + 1) + " + ";
                                }
                                result = result.Remove(result.Length - 2);
                                result += " - C" + sx + " = ";
                                delta_b = 0;
                                for (int j = 0; j < restriction; j++)
                                {
                                    result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                                    result += Math.Round(simplex[(j + 1), (sx - 1)], 2) + " + ";
                                    delta_b += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (sx - 1)]);
                                }
                                result = result.Remove(result.Length - 2);
                                delta_b -= simplex[0, sx - 1];
                                result += "- " + Math.Round(simplex[0, sx - 1], 2) + " = " + Math.Round(delta_b, 2) + "\n";
                                simplex[sy - 1, sx - 1] = delta_b;
                                result += "Симплекс-таблица с обновлёнными дельтами\n";
                                IC_BACKUP = Inequality_Constraints;
                                for (int i = 0; i < sy; i++)
                                {
                                    if (i == 0)
                                    {
                                        result = result + "C\t";
                                    }
                                    else if (i == (sy - 1))
                                    {
                                        result = result + "Δ\t";
                                    }
                                    else
                                    {
                                        if ((IC_BACKUP % 2) == 1)
                                        {
                                            result = result + basis_strings[i - 1] + "\t";
                                        }
                                        else
                                        {
                                            result = result + basis_strings[i - 1] + "\t";
                                        }
                                        IC_BACKUP = IC_BACKUP >> 1;

                                    }
                                    for (int j = 0; j < sx; j++)
                                    {
                                        result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    }
                                    result = result + "\n";
                                    if (i == 0)
                                    {
                                        result = result + "базис\t";
                                        for (int j = 0; j < sx - 1; j++)
                                        {
                                            result = result + "x" + (j + 1) + "\t";
                                        }
                                        result = result + "b\n";
                                    }
                                }
                            }
                            else
                            {
                                result += "Все значения ключевого столбца отрицательны. Функция не ограничена. Оптимальное решение отсутствует.";
                            }
                        }
                    }
                    else
                    {
                        result += "положительные дельты).";
                        for (int i = 0; i < sx - 1; i++)
                        {
                            if (simplex[sy - 1, i] > 0)
                            {
                                Plan_Is_Optimal = false;
                                not_optimal_delta_place = i;
                                not_optimal_delta = simplex[sy - 1, i];
                                break;
                            }
                        }
                        if (Plan_Is_Optimal)
                        {
                            double[] x_result = new double[x_nums];
                            for (int i = 0; i < restriction; i++)
                            {
                                result += basis_ints[i] + " ";
                            }
                            result += "\nПлан оптимален, так как положительные дельты отсутствуют.\nОтвет:";
                            // доделать - ответ неверный
                            for (int i = 0; i < x_nums; i++)
                            {
                                bool i_exists = false;
                                for (int j = 0; j < restriction; j++)
                                {
                                    if ((i + 1) == basis_ints[j])
                                    {
                                        x_result[i] = simplex[j + 1, (sx - 1)];
                                        result += "\nx" + (i + 1) + " = " + simplex[j + 1, (sx - 1)];
                                        i_exists = true;
                                    }
                                }
                                if (i_exists == false)
                                {
                                    result += "\nx" + (i + 1) + " = 0";
                                    x_result[i] = 0;
                                }
                            }
                            result += "\nF = ";
                            double F = 0;
                            for (int i = 0; i < x_nums; i++)
                            {
                                F += x_result[i] * simplex[0, i];
                            }
                            result += F;
                        }
                        else
                        {
                            result += "\nПлан не оптимален, так как Δ" + (not_optimal_delta_place + 1) + " = " + not_optimal_delta + "\n";
                            iteration++;
                            result += "Итерация " + iteration;
                            result += "\nОпределяем разрешающий столбец - столбец, в котором находится максимальная дельта: ";
                            double max_delta = simplex[(sy - 1), 0];
                            int max_delta_place = 0;
                            for (int i = 1; i < sx - 1; i++)
                            {
                                if (simplex[(sy - 1), i] > max_delta)
                                {
                                    max_delta = simplex[(sy - 1), i];
                                    max_delta_place = i;
                                }
                            }
                            result += (max_delta_place + 1);
                            result += ", Δ" + (max_delta_place + 1) + " = " + max_delta;
                            result += "\nНаходим симплекс-отношения Q путём деления коэффициентов b на соответствующие значения столбца " + (max_delta_place + 1) + ".\n";
                            double Q_min = simplex[1, (sx - 1)] / simplex[1, max_delta_place];
                            int Q_min_position = 1;
                            IC_BACKUP = Inequality_Constraints;
                            for (int i = 0; i < sy; i++)
                            {
                                if (i == 0)
                                {
                                    result = result + "C\t";
                                }
                                else if (i == (sy - 1))
                                {
                                    result = result + "Δ\t";
                                }
                                else
                                {
                                    if ((IC_BACKUP % 2) == 1)
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    else
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    IC_BACKUP = IC_BACKUP >> 1;

                                }

                                for (int j = 0; j < sx; j++)
                                {
                                    result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    if ((j == (sx - 1)) && (i > 0) && (i < sy - 1))
                                    {
                                        double Q = simplex[i, j] / simplex[i, max_delta_place];
                                        if (Q < Q_min)
                                        {
                                            Q_min = Q;
                                            Q_min_position = i;
                                        }
                                        result += Math.Round(simplex[i, j], 2) + " / " + Math.Round(simplex[i, max_delta_place], 2) + " = " + Math.Round(Q, 2);
                                    }
                                }
                                result = result + "\n";
                                if (i == 0)
                                {
                                    result = result + "базис\t";
                                    for (int j = 0; j < sx - 1; j++)
                                    {
                                        result = result + "x" + (j + 1) + "\t";
                                    }
                                    result = result + "b\tQ\n";
                                }
                            }
                            result += "В найденном столбце ищем строку с наименьшим значением Q: Q(min) = " + Q_min + ", строка " + Q_min_position + ".\n";
                            result += "На пересечении найденных строки и столбца находится разрешающий элемент: " + simplex[Q_min_position, max_delta_place] + ".\n";
                            result += "В качестве базисной переменной x" + basis_ints[Q_min_position - 1] + " берём x" + (max_delta_place + 1) + "\n";
                            basis_ints[Q_min_position - 1] = max_delta_place + 1;
                            basis_strings[Q_min_position - 1] = "x" + (max_delta_place + 1);
                            IC_BACKUP = Inequality_Constraints;
                            bool All_Q_Negative = true;
                            for (int i = 0; i < sy; i++)
                            {
                                if (i == 0)
                                {
                                    result = result + "C\t";
                                }
                                else if (i == (sy - 1))
                                {
                                    result = result + "Δ\t";
                                }
                                else
                                {
                                    if ((IC_BACKUP % 2) == 1)
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    else
                                    {
                                        result = result + basis_strings[i - 1] + "\t";
                                    }
                                    IC_BACKUP = IC_BACKUP >> 1;

                                }

                                for (int j = 0; j < sx; j++)
                                {
                                    result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    if ((j == (sx - 1)) && (i > 0) && (i < sy - 1))
                                    {
                                        double Q = simplex[i, j] / simplex[i, max_delta_place];
                                        if (Q > 0)
                                        {
                                            result += Math.Round(Q, 2);
                                            All_Q_Negative = false;
                                        }
                                        else
                                        {
                                            result += "-";
                                        }
                                    }
                                }
                                result = result + "\n";
                                if (i == 0)
                                {
                                    result = result + "базис\t";
                                    for (int j = 0; j < sx - 1; j++)
                                    {
                                        result = result + "x" + (j + 1) + "\t";
                                    }
                                    result = result + "b\tQ\n";
                                }
                            }
                            if (All_Q_Negative == false)
                            {
                                result += "Делим строку " + Q_min_position + " на " + simplex[Q_min_position, max_delta_place] + ".";
                                double divider = simplex[Q_min_position, max_delta_place];
                                for (int k = 0; k < sx; k++)
                                {
                                    simplex[Q_min_position, k] /= divider;
                                }
                                if (restriction > 1)
                                {
                                    result = result + " Из строк";
                                    if (restriction > 2)
                                    {
                                        result = result + " ";
                                    }
                                    else
                                    {
                                        result = result + "и ";
                                    }
                                    for (int k = 1; k < sy - 1; k++)
                                    {
                                        if (k != Q_min_position)
                                        {
                                            result = result + k + ", ";
                                            double simplex_multiplier = simplex[k, max_delta_place];
                                            for (int l = 0; l < sx; l++)
                                            {
                                                simplex[k, l] += (simplex[Q_min_position, l] * (-1) * simplex_multiplier);
                                            }
                                        }
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result = result + " вычитаем строку " + Q_min_position + ", умноженную на соответствующий элемент в столбце " + (max_delta_place + 1) + ".\n";
                                }
                                result += "Вычисляем новые дельты: Δi = ";
                                for (int i = 0; i < restriction; i++)
                                {
                                    result += "C" + basis_ints[i] + " * a" + (i + 1) + "i + ";
                                }
                                result = result.Remove(result.Length - 2);
                                result += " - Ci\n";
                                for (int i = 0; i < sx - 1; i++)
                                {
                                    result += "Δ" + (i + 1) + " = ";
                                    for (int j = 0; j < restriction; j++)
                                    {
                                        result += "C" + basis_ints[j] + " * a" + (j + 1) + (i + 1) + " + ";
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result += " - C" + (i + 1) + " = ";
                                    double delta = 0;
                                    for (int j = 0; j < restriction; j++)
                                    {
                                        result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                                        result += Math.Round(simplex[(j + 1), (i)], 2) + " + ";
                                        delta += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (i)]);
                                    }
                                    result = result.Remove(result.Length - 2);
                                    result += "- " + Math.Round(simplex[0, i], 2);
                                    delta -= simplex[0, i];
                                    result += " = " + Math.Round(delta, 2) + "\n";
                                    simplex[sy - 1, i] = delta;
                                }

                                result += "Δb = ";
                                for (int i = 0; i < restriction; i++)
                                {
                                    result += "C" + basis_ints[i] + " * b" + (i + 1) + " + ";
                                }
                                result = result.Remove(result.Length - 2);
                                result += " - C" + sx + " = ";
                                delta_b = 0;
                                for (int j = 0; j < restriction; j++)
                                {
                                    result += Math.Round(simplex[0, basis_ints[j] - 1], 2) + " * ";
                                    result += Math.Round(simplex[(j + 1), (sx - 1)], 2) + " + ";
                                    delta_b += (simplex[0, basis_ints[j] - 1]) * (simplex[(j + 1), (sx - 1)]);
                                }
                                result = result.Remove(result.Length - 2);
                                delta_b -= simplex[0, sx - 1];
                                result += "- " + Math.Round(simplex[0, sx - 1], 2) + " = " + Math.Round(delta_b, 2) + "\n";
                                simplex[sy - 1, sx - 1] = delta_b;
                                result += "Симплекс-таблица с обновлёнными дельтами\n";
                                IC_BACKUP = Inequality_Constraints;
                                for (int i = 0; i < sy; i++)
                                {
                                    if (i == 0)
                                    {
                                        result = result + "C\t";
                                    }
                                    else if (i == (sy - 1))
                                    {
                                        result = result + "Δ\t";
                                    }
                                    else
                                    {
                                        if ((IC_BACKUP % 2) == 1)
                                        {
                                            result = result + basis_strings[i - 1] + "\t";
                                        }
                                        else
                                        {
                                            result = result + basis_strings[i - 1] + "\t";
                                        }
                                        IC_BACKUP = IC_BACKUP >> 1;

                                    }
                                    for (int j = 0; j < sx; j++)
                                    {
                                        result = result + Math.Round(simplex[i, j], 2) + "\t";
                                    }
                                    result = result + "\n";
                                    if (i == 0)
                                    {
                                        result = result + "базис\t";
                                        for (int j = 0; j < sx - 1; j++)
                                        {
                                            result = result + "x" + (j + 1) + "\t";
                                        }
                                        result = result + "b\n";
                                    }
                                }
                            }
                            else
                            {
                                result += "Все значения ключевого столбца отрицательны. Функция не ограничена. Оптимальное решение отсутствует.";
                            }
                        }
                    }
                }
                
            }
            richTextBox1.Text = result;
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            System.Windows.Forms.SendKeys.Send("{tab}");
        }
    }

}