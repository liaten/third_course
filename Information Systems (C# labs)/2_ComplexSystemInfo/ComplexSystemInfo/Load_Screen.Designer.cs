
namespace ComplexSystemInfo
{
    partial class Load_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PBPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPB = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PBPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBPanel
            // 
            this.PBPanel.Controls.Add(this.StatusLabel);
            this.PBPanel.Location = new System.Drawing.Point(0, 0);
            this.PBPanel.Name = "PBPanel";
            this.PBPanel.Padding = new System.Windows.Forms.Padding(15, 60, 15, 15);
            this.PBPanel.Size = new System.Drawing.Size(919, 431);
            this.PBPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainPB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(534, 60);
            this.panel1.TabIndex = 2;
            // 
            // MainPB
            // 
            this.MainPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPB.Location = new System.Drawing.Point(15, 15);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(504, 30);
            this.MainPB.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(15, 60);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(311, 25);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Получаем данные о системе...";
            // 
            // Load_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 91);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBPanel);
            this.MaximumSize = new System.Drawing.Size(550, 130);
            this.MinimumSize = new System.Drawing.Size(550, 130);
            this.Name = "Load_Screen";
            this.Text = "Идёт загрузка!!";
            this.PBPanel.ResumeLayout(false);
            this.PBPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PBPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar MainPB;
        private System.Windows.Forms.Label StatusLabel;
    }
}