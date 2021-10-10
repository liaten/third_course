using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace ComplexSystemInfo
{
    public partial class ComplexSystemInfoForm : Form
    {
        new bool MouseDown;
        private Point offset;
        public string Get_Processor_Info()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            string result = string.Empty;
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                result += obj["Name"];
            }
            return result;
        }
        public ComplexSystemInfoForm()
        {
            InitializeComponent();
            ProcLabel2.Text = Get_Processor_Info();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            MouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
    }
}
