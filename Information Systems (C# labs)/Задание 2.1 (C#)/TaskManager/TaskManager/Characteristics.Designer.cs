
namespace TaskManager
{
    partial class Characteristics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.характеристикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диспетчерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proclabel = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
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
            // proclabel
            // 
            this.proclabel.AutoSize = true;
            this.proclabel.Location = new System.Drawing.Point(12, 30);
            this.proclabel.Name = "proclabel";
            this.proclabel.Size = new System.Drawing.Size(66, 13);
            this.proclabel.TabIndex = 5;
            this.proclabel.Text = "Процессор:";
            // 
            // Characteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.proclabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Characteristics";
            this.Text = "Аналитика: Характеристики";
            this.Load += new System.EventHandler(this.Characteristics_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem характеристикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диспетчерЗадачToolStripMenuItem;
        private System.Windows.Forms.Label proclabel;
    }
}

