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
        public static string RamType()
        {
            int type = 0;
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;
            ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
            scope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            foreach (ManagementObject queryObj in searcher.Get())
            {
                type = Convert.ToInt32(queryObj["MemoryType"]);
            }
            return TypeString(type);
        }
        private static string TypeString(int type)
        {
            string outValue;
            switch (type)
            {
                case 0x0: outValue = "Unknown"; break;
                case 0x1: outValue = "Other"; break;
                case 0x2: outValue = "DRAM"; break;
                case 0x3: outValue = "Synchronous DRAM"; break;
                case 0x4: outValue = "Cache DRAM"; break;
                case 0x5: outValue = "EDO"; break;
                case 0x6: outValue = "EDRAM"; break;
                case 0x7: outValue = "VRAM"; break;
                case 0x8: outValue = "SRAM"; break;
                case 0x9: outValue = "RAM"; break;
                case 0xa: outValue = "ROM"; break;
                case 0xb: outValue = "Flash"; break;
                case 0xc: outValue = "EEPROM"; break;
                case 0xd: outValue = "FEPROM"; break;
                case 0xe: outValue = "EPROM"; break;
                case 0xf: outValue = "CDRAM"; break;
                case 0x10: outValue = "3DRAM"; break;
                case 0x11: outValue = "SDRAM"; break;
                case 0x12: outValue = "SGRAM"; break;
                case 0x13: outValue = "RDRAM"; break;
                case 0x14: outValue = "DDR"; break;
                case 0x15: outValue = "DDR2"; break;
                case 0x16: outValue = "DDR2 FB-DIMM"; break;
                case 0x17: outValue = "Undefined 23"; break;
                case 0x18: outValue = "DDR3"; break;
                case 0x19: outValue = "FBD2"; break;
                case 0x1a: outValue = "DDR4"; break;
                default: outValue = "Undefined"; break;
            }
            return outValue;
        }
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
            ProcLabel.Location = new Point(8, 8);
            ProcLabel2.Location = new Point(8, ProcLabel.Location.Y + ProcLabel.Size.Height + 8);
            RamLabel.Location = new Point(8, ProcLabel2.Location.Y + ProcLabel2.Size.Height + 8);
            RamLabel2.Location = new Point(8, RamLabel.Location.Y + RamLabel.Size.Height + 8);
            RamLabel2.Text = RamType();
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
