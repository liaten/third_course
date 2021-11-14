using System;
using System.Windows.Forms;

namespace ComplexSystemInfo
{
    public partial class Load_Screen : Form
    {
        public Load_Screen()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public void ChangePB(int val)
        {
            this.MainPB.Invoke((MethodInvoker)delegate
            {
                this.MainPB.Value = val;
            });
        }
        public void ChangeStatusLabel(string str)
        {
            this.StatusLabel.Invoke((MethodInvoker)delegate
            {
                this.StatusLabel.Text = str;
            });
        }
    }
}
