using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComplexSystemInfo
{
    public partial class ComplexSystemInfoForm : Form
    {
        static PerformanceCounter cpuCounter;
        static PerformanceCounter ramCounter;
        static ConnectionOptions connection;
        static ManagementScope RAM_Scope;
        static ObjectQuery RAM_Query;
        static ManagementObjectSearcher RamType_Searcher;
        static ManagementObjectSearcher myProcessorObject;
        static ObjectQuery Win32_Object_Query;
        static ManagementObjectSearcher RAM_Searcher;
        static ManagementObjectCollection RAM_Results;
        static DriveInfo[] allDrives;
        private static List<Process> processes;
        private static ListViewItemComparer comparer;

        private void GetProcesses()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList<Process>();
        }
        private void RefreshProcessesList()
        {
            metroListView1.Items.Clear();
            double memSize = 0;
            foreach (Process p in processes)
            {
                memSize = 0;
                PerformanceCounter pc = new PerformanceCounter();
                pc.CategoryName = "Process";
                pc.CounterName = "Working Set - Private";
                pc.InstanceName = p.ProcessName;
                memSize = (double)pc.NextValue() / (1000 * 1000);
                string[] row = new string[] { p.ProcessName.ToString(), Math.Round(memSize, 1).ToString() };
                metroListView1.Items.Add(new ListViewItem(row));
                pc.Close();
                pc.Dispose();
            }
            Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
        }
        private void RefreshProcessesList(List<Process> processes, string keyword)
        {
            try
            {
                metroListView1.Items.Clear();
                float memSize = 0;
                foreach (Process p in processes)
                {
                    if (p != null)
                    {
                        memSize = 0;
                        PerformanceCounter pc = new PerformanceCounter();
                        pc.CategoryName = "Process";
                        pc.CounterName = "Working Set - Private";
                        pc.CounterName = p.ProcessName;
                        memSize = pc.NextValue() / 1000000;
                        string[] row = new string[] { p.ProcessName.ToString(), Math.Round(memSize, 1).ToString() };
                        metroListView1.Items.Add(new ListViewItem(row));
                        pc.Close();
                        pc.Dispose();
                    }
                }
                Text = $"Complex System Information | Запущено процессов '{keyword}': " + processes.Count.ToString();
            }
            catch (Exception) { }
        }
        private void KillProces(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }
        private void KillProcessAndChildren(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "Select * from Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection oc = searcher.Get();
            foreach (ManagementObject obj in oc)
            {
                KillProcessAndChildren(Convert.ToInt32(obj["ProcessID"]));
            }
            try
            {
                Process p = Process.GetProcessById(pid);
                p.Kill();
                p.WaitForExit();
            }
            catch (ArgumentException) { }
        }
        private int GetParentProcessID(Process p)
        {
            int parentID = 0;
            try
            {
                ManagementObject mo = new ManagementObject("win32_process.handle='" + p.Id + "'");
                mo.Get();
                parentID = Convert.ToInt32(mo["ParentProcessId"]);
            }
            catch (Exception) { }
            return parentID;
        }
        public string Get_CPU_Usage()
        {
            return "Нагрузка на процессор: " + Math.Round(cpuCounter.NextValue(), 2) + "%";
        }
        // Получить свободное, занятое, всё пространство ОЗУ
        public string Get_RAM_Load()
        {
            string ResultString = string.Empty;
            float free_RAM = 0;
            float load_RAM = 0;
            int TotalVisibleMemorySize = 0;
            foreach (ManagementObject result in RAM_Results)
            {
                TotalVisibleMemorySize = Convert.ToInt32(result["TotalVisibleMemorySize"]);
                TotalVisibleMemorySize >>= 10;
                free_RAM = ramCounter.NextValue();    //MB
                load_RAM = TotalVisibleMemorySize;
                load_RAM -= free_RAM;
            }
            Update_RAM_Chart(free_RAM, load_RAM);
            return "Свободная: " + free_RAM + "MB\n" + "Занятая: " + load_RAM + "MB\n" + "Вся: " + TotalVisibleMemorySize + "MB";
        }
        // Получить тип ОЗУ
        public static string RamType()
        {
            int type = 0;
            connection.Impersonation = ImpersonationLevel.Impersonate;
            RAM_Scope.Connect();
            foreach (ManagementObject queryObj in RamType_Searcher.Get())
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
            string result = string.Empty;
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                result += obj["Name"];
            }
            return result;
        }
        public string Get_RAM_Info()
        {
            foreach (ManagementObject result in RAM_Results)
            {
                int TotalVisibleMemorySize = Convert.ToInt32(result["TotalVisibleMemorySize"]);
                TotalVisibleMemorySize >>= 20;
                TotalVisibleMemorySize++;

                return TotalVisibleMemorySize + " GB\n";
            }
            return string.Empty;
        }
        public static string Get_Drive_Capability()
        {
            string resultstring = string.Empty;
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    if (d.VolumeLabel == string.Empty)
                    {
                        resultstring += "Название: " + d.RootDirectory;
                    }
                    else
                    {
                        resultstring += "Название: " + d.VolumeLabel;
                    }
                    long TotalFreeSpace = d.TotalFreeSpace;
                    long TotalSize = d.TotalSize;
                    TotalFreeSpace >>= 30;
                    TotalSize >>= 30;
                    resultstring += "\nСвободно " + TotalFreeSpace + " GB из " + TotalSize + "GB\n\n";
                }
            }
            resultstring = resultstring.Remove(resultstring.Length - 2);
            return resultstring;
        }
        public static string Get_Drive_Info()
        {
            string resultstring = string.Empty;
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    if (d.VolumeLabel == string.Empty)
                    {
                        resultstring += "Название: " + d.RootDirectory;
                    }
                    else
                    {
                        resultstring += "Название: " + d.VolumeLabel;
                    }
                    resultstring += "\nФайловая система: " + d.DriveFormat;
                    long TotalSize = d.TotalSize;
                    TotalSize >>= 30;
                    resultstring += "\nРазмер диска: " + TotalSize + " GB";
                    resultstring += "\nАдрес: " + d.RootDirectory + "\n\n";
                }
            }
            resultstring = resultstring.Remove(resultstring.Length - 2);
            return resultstring;
        }
        public string Get_GPU_Info()
        {
            String return_result = String.Empty;
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    return_result += "Название - " + obj["Name"] + "\n";
                    return_result += "ID видеокарты - " + obj["DeviceID"] + "\n";
                    return_result += "Память адаптера - " + obj["AdapterRAM"] + "\n";
                    return_result += "Тип адаптера DAC - " + obj["AdapterDACType"] + "\n";
                    return_result += "Версия драйвера - " + obj["DriverVersion"] + "\n";
                    return_result += "Видеопроцессор - " + obj["VideoProcessor"] + "\n";
                }
            }
            return return_result;
        }
        public void Update_RAM_Chart(float free, float load)
        {
            RAM_Chart.Series.Clear();
            RAM_Chart.Legends.Clear();

            //Add a new chart-series
            string seriesname = "ОЗУ";
            RAM_Chart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            RAM_Chart.Series[seriesname].ChartType = SeriesChartType.Pie;
            RAM_Chart.Series[seriesname].Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            //Add some datapoints so the series. in this case you can pass the values to this method
            RAM_Chart.Series[seriesname].Points.AddXY("Свободно ОЗУ: " + free + " MB", free);
            RAM_Chart.Series[seriesname].Points.AddXY("Занято ОЗУ: " + load + " MB", load);
        }
        public ComplexSystemInfoForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ComplexSystemInfoForm_Load);
            Load_Static_Elements();
        }
        private void Update_Timer_Tick(object sender, EventArgs e)
        {
            if (PROC_Load_2.ForeColor == Color.Red)
            {
                PROC_Load_2.ForeColor = Color.Black;
            }
            if (RAM_Load_2.ForeColor == Color.Red)
            {
                RAM_Load_2.ForeColor = Color.Black;
            }
            if (HDD_Cap2.ForeColor == Color.Red)
            {
                HDD_Cap2.ForeColor = Color.Black;
            }
            PROC_Load_2.Text = Get_CPU_Usage();
            RAM_Load_2.Text = Get_RAM_Load();
            HDD_Cap2.Text = Get_Drive_Capability();
            HDD_Cap1.Location = new Point(8, RAM_Load_2.Location.Y + RAM_Load_2.Size.Height + 8);
            HDD_Cap2.Location = new Point(8, HDD_Cap1.Location.Y + HDD_Cap1.Size.Height + 8);
            RAM_Chart.Location = new Point(PROC_Load_2.Location.X + PROC_Load_2.Size.Width + 64, 8);
        }
        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl.SelectedIndex == 1)
            {
                Update_Resourses_Timer.Enabled = true;
            }
            else
            {
                Update_Resourses_Timer.Enabled = false;
            }
            if(metroTabControl.SelectedIndex == 2)
            {
                Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
                AutoUpdateButton.Text = "Автообновление: вкл";
                Update_TaskManager.Enabled = true;
            }
            else
            {
                Text = "Complex System Information";
                Update_TaskManager.Enabled = false;
            }
        }

        private void ComplexSystemInfoForm_Load(object sender, EventArgs e)
        {
            processes = new List<Process>();
            comparer = new ListViewItemComparer();
            comparer.ColumnIndex = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            GetProcesses();
            RefreshProcessesList();
            Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems[0] != null)
                {
                    Process processToKill = processes.Where((x) => x.ProcessName ==
                    metroListView1.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProces(processToKill);
                    GetProcesses();
                    RefreshProcessesList();
                    Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
                }
            }
            catch (Exception) { }
        }

        private void StopTree_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems[0] != null)
                {
                    Process processToKill = processes.Where((x) => x.ProcessName ==
                    metroListView1.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProcessAndChildren(GetParentProcessID(processToKill));
                    GetProcesses();
                    RefreshProcessesList();
                    Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
                }
            }
            catch (Exception) { }
        }

        private void завершитьДеревоПроцессовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopTree_Click(sender, e);
        }

        private void завершитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stop_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string path = Interaction.InputBox("Введите имя программы", "Запуск новой задачи");
            try
            {
                Process.Start(path);
                GetProcesses();
                RefreshProcessesList();
                Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
            }
            catch (Exception) { }
        }
        private void metroListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            comparer.ColumnIndex = e.Column;
            comparer.SortDirection = comparer.SortDirection == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            metroListView1.ListViewItemSorter = comparer;
            metroListView1.Sort();
        }

        private void Update_TaskManager_Tick(object sender, EventArgs e)
        {
            GetProcesses();
            RefreshProcessesList();
            Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
        }
        public void Load_Static_Elements()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            connection = new ConnectionOptions();
            RAM_Scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
            RAM_Query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            RamType_Searcher = new ManagementObjectSearcher(RAM_Scope, RAM_Query);
            myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            Win32_Object_Query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            RAM_Searcher = new ManagementObjectSearcher(Win32_Object_Query);
            RAM_Results = RAM_Searcher.Get();
            allDrives = DriveInfo.GetDrives();
            processes = null;
            comparer = null;
            ProcLabel2.Text = Get_Processor_Info();
            RamLabel2.Text = RamType() + " " + Get_RAM_Info();
            HDD_Label2.Text = Get_Drive_Info();
            GPU_Label2.Text = Get_GPU_Info();
            string is_loading = "Идёт загрузка...";
            PROC_Load_2.Text = is_loading;
            RAM_Load_2.Text = is_loading;
            HDD_Cap2.Text = is_loading;
            PROC_Load_2.ForeColor = Color.Red;
            RAM_Load_2.ForeColor = Color.Red;
            HDD_Cap2.ForeColor = Color.Red;
            ProcLabel.Location = new Point(8, 8);
            ProcLabel2.Location = new Point(8, ProcLabel.Location.Y + ProcLabel.Size.Height + 8);
            RamLabel.Location = new Point(8, ProcLabel2.Location.Y + ProcLabel2.Size.Height + 8);
            RamLabel2.Location = new Point(8, RamLabel.Location.Y + RamLabel.Size.Height + 8);
            HDD_Label.Location = new Point(8, RamLabel2.Location.Y + RamLabel2.Size.Height + 8);
            HDD_Label2.Location = new Point(8, HDD_Label.Location.Y + HDD_Label.Size.Height + 8);
            GPU_Label1.Location = new Point(8, HDD_Label2.Location.Y + HDD_Label2.Size.Height + 8);
            GPU_Label2.Location = new Point(8, GPU_Label1.Location.Y + GPU_Label1.Size.Height + 8);
            PROC_Load_1.Location = new Point(8, 8);
            PROC_Load_2.Location = new Point(8, PROC_Load_1.Location.Y + PROC_Load_1.Size.Height + 8);
            RAM_Load_1.Location = new Point(8, PROC_Load_2.Location.Y + PROC_Load_2.Size.Height + 8);
            RAM_Load_2.Location = new Point(8, RAM_Load_1.Location.Y + RAM_Load_1.Size.Height + 8);
            HDD_Cap1.Location = new Point(8, RAM_Load_2.Location.Y + RAM_Load_2.Size.Height + 8);
            HDD_Cap2.Location = new Point(8, HDD_Cap1.Location.Y + HDD_Cap1.Size.Height + 8);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(AutoUpdateButton.Text== "Автообновление: вкл")
            {
                AutoUpdateButton.Text = "Автообновление: выкл";
                Update_TaskManager.Enabled = false;
            }
            else
            {
                AutoUpdateButton.Text = "Автообновление: вкл";
                Update_TaskManager.Enabled = true;
                Text = "Complex System Information | Запущено процессов: " + processes.Count.ToString();
            }
        }
    }
}
