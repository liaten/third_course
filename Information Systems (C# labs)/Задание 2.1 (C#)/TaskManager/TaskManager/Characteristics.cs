using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace TaskManager
{
    public partial class Characteristics : Form
    {
        public string Get_Processor_Info()
        {
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            string result = "Процессор:\n";
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                result += ("Название: " + obj["Name"]) + "\n";
                result += ("Производитель: " + obj["Manufacturer"]) + "\n";
                result += ("Текущая тактовая частота: " + obj["CurrentClockSpeed"]) + "\n";
                result += ("Описание:  " + obj["Caption"]) + "\n";
                result += ("Количество ядер: " + obj["NumberOfCores"]) + "\n";
            }
            return result;
        }
        public string Get_RAM_Info()
        {
            string result_string = "ОЗУ:\n";
            ManagementObjectSearcher searcher12 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in searcher12.Get())
            {
                result_string += "Отсек памяти: " + queryObj["BankLabel"] + "\n";
                result_string += "Вместимость: " + Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2) + " ГБ\n";
                result_string += "Частота: " + queryObj["Speed"] + " МГц\n";
                result_string += "Производитель: " + queryObj["Manufacturer"] + "\n";
                result_string += "Тип памяти: " + queryObj["Name"] + "\n\n";
            }
            return result_string;
        }
        public Characteristics()
        {
            InitializeComponent();
            this.CenterToScreen();
            int tb_width = (this.Size.Width - 40) / 2;
            proctextbox.Size = new System.Drawing.Size(tb_width,130);
            ramtextbox.Size = proctextbox.Size;
            proctextbox.Text = Get_Processor_Info();
            proctextbox.Location = new Point(8, menuStrip1.Size.Height + 8);
            ramtextbox.Text = Get_RAM_Info();
            ramtextbox.Location = new Point(proctextbox.Location.X + proctextbox.Size.Width + 8, proctextbox.Location.Y);
        }

        private void характеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nothing happend
        }

        private void диспетчерЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // switch to taskmanager
            this.Hide();
            TaskManager t2 = new TaskManager();
            t2.ShowDialog();
            this.Close();
            //Dispose();
            //GC.Collect();
        }

        private void Characteristics_Load(object sender, EventArgs e)
        {

        }
    }
}
