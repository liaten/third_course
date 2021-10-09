
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
            this.proc_label = new System.Windows.Forms.Label();
            this.ram_label = new System.Windows.Forms.Label();
            this.proctextbox = new System.Windows.Forms.RichTextBox();
            this.ramtextbox = new System.Windows.Forms.RichTextBox();
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
            // proc_label
            // 
            this.proc_label.AutoSize = true;
            this.proc_label.Location = new System.Drawing.Point(419, 246);
            this.proc_label.Name = "proc_label";
            this.proc_label.Size = new System.Drawing.Size(215, 13);
            this.proc_label.TabIndex = 1;
            this.proc_label.Text = "Здесь будут характеристики процессора";
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Location = new System.Drawing.Point(419, 324);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(178, 13);
            this.ram_label.TabIndex = 2;
            this.ram_label.Text = "Здесь будут характеристики ОЗУ";
            // 
            // proctextbox
            // 
            this.proctextbox.Location = new System.Drawing.Point(12, 27);
            this.proctextbox.Name = "proctextbox";
            this.proctextbox.Size = new System.Drawing.Size(420, 130);
            this.proctextbox.TabIndex = 3;
            this.proctextbox.Text = "";
            // 
            // ramtextbox
            // 
            this.ramtextbox.Location = new System.Drawing.Point(452, 27);
            this.ramtextbox.Name = "ramtextbox";
            this.ramtextbox.Size = new System.Drawing.Size(420, 130);
            this.ramtextbox.TabIndex = 4;
            this.ramtextbox.Text = "";
            // 
            // Characteristics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.ramtextbox);
            this.Controls.Add(this.proctextbox);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.proc_label);
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
        private System.Windows.Forms.Label proc_label;
        private System.Windows.Forms.Label ram_label;
        public System.Windows.Forms.RichTextBox proctextbox;
        public System.Windows.Forms.RichTextBox ramtextbox;
    }
}

