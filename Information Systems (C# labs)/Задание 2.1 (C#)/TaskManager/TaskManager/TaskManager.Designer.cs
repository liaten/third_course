
namespace TaskManager
{
    partial class TaskManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.характеристикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспетчерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.характеристикиToolStripMenuItem,
            this.диспетчерЗадачToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // характеристикиToolStripMenuItem
            // 
            this.характеристикиToolStripMenuItem.Name = "характеристикиToolStripMenuItem";
            this.характеристикиToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.характеристикиToolStripMenuItem.Text = "Характеристики";
            this.характеристикиToolStripMenuItem.Click += new System.EventHandler(this.характеристикиToolStripMenuItem_Click);
            // 
            // диспетчерЗадачToolStripMenuItem
            // 
            this.диспетчерЗадачToolStripMenuItem.Name = "диспетчерЗадачToolStripMenuItem";
            this.диспетчерЗадачToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.диспетчерЗадачToolStripMenuItem.Text = "Диспетчер задач";
            this.диспетчерЗадачToolStripMenuItem.Click += new System.EventHandler(this.диспетчерЗадачToolStripMenuItem_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TaskManager";
            this.Text = "Аналитика: Диспетчер задач";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem характеристикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспетчерЗадачToolStripMenuItem;
    }
}