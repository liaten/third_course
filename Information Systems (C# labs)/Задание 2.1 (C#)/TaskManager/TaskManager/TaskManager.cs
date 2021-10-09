using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void диспетчерЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nothing happens
        }

        private void характеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // switch to chars
            this.Hide();
            Characteristics ch2 = new Characteristics();
            ch2.ShowDialog();
            this.Close();
            //Dispose();
            //GC.Collect();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }
    }
}
