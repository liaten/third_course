
namespace ComplexSystemInfo
{
    partial class ComplexSystemInfoForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComplexSystemInfoForm));
      this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
      this.SystemInfoPage = new MetroFramework.Controls.MetroTabPage();
      this.HDD_Label2 = new System.Windows.Forms.Label();
      this.HDD_Label = new System.Windows.Forms.Label();
      this.RamLabel2 = new System.Windows.Forms.Label();
      this.RamLabel = new System.Windows.Forms.Label();
      this.ProcLabel2 = new System.Windows.Forms.Label();
      this.ProcLabel = new System.Windows.Forms.Label();
      this.LoadPage = new MetroFramework.Controls.MetroTabPage();
      this.TaskManagerPage = new MetroFramework.Controls.MetroTabPage();
      this.GPU_Label1 = new System.Windows.Forms.Label();
      this.GPU_Label2 = new System.Windows.Forms.Label();
      this.metroTabControl.SuspendLayout();
      this.SystemInfoPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // metroTabControl
      // 
      this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.metroTabControl.Controls.Add(this.SystemInfoPage);
      this.metroTabControl.Controls.Add(this.LoadPage);
      this.metroTabControl.Controls.Add(this.TaskManagerPage);
      this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.metroTabControl.Location = new System.Drawing.Point(0, 0);
      this.metroTabControl.Multiline = true;
      this.metroTabControl.Name = "metroTabControl";
      this.metroTabControl.SelectedIndex = 0;
      this.metroTabControl.Size = new System.Drawing.Size(951, 512);
      this.metroTabControl.TabIndex = 1;
      this.metroTabControl.UseSelectable = true;
      // 
      // SystemInfoPage
      // 
      this.SystemInfoPage.AutoScroll = true;
      this.SystemInfoPage.BackColor = System.Drawing.Color.Transparent;
      this.SystemInfoPage.Controls.Add(this.GPU_Label2);
      this.SystemInfoPage.Controls.Add(this.GPU_Label1);
      this.SystemInfoPage.Controls.Add(this.HDD_Label2);
      this.SystemInfoPage.Controls.Add(this.HDD_Label);
      this.SystemInfoPage.Controls.Add(this.RamLabel2);
      this.SystemInfoPage.Controls.Add(this.RamLabel);
      this.SystemInfoPage.Controls.Add(this.ProcLabel2);
      this.SystemInfoPage.Controls.Add(this.ProcLabel);
      this.SystemInfoPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SystemInfoPage.HorizontalScrollbar = true;
      this.SystemInfoPage.HorizontalScrollbarBarColor = true;
      this.SystemInfoPage.HorizontalScrollbarHighlightOnWheel = false;
      this.SystemInfoPage.HorizontalScrollbarSize = 10;
      this.SystemInfoPage.Location = new System.Drawing.Point(4, 41);
      this.SystemInfoPage.Name = "SystemInfoPage";
      this.SystemInfoPage.Size = new System.Drawing.Size(943, 467);
      this.SystemInfoPage.Style = MetroFramework.MetroColorStyle.Black;
      this.SystemInfoPage.TabIndex = 0;
      this.SystemInfoPage.Text = "Информация о системе";
      this.SystemInfoPage.VerticalScrollbar = true;
      this.SystemInfoPage.VerticalScrollbarBarColor = true;
      this.SystemInfoPage.VerticalScrollbarHighlightOnWheel = false;
      this.SystemInfoPage.VerticalScrollbarSize = 10;
      // 
      // HDD_Label2
      // 
      this.HDD_Label2.AutoSize = true;
      this.HDD_Label2.BackColor = System.Drawing.Color.Transparent;
      this.HDD_Label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.HDD_Label2.ForeColor = System.Drawing.Color.Black;
      this.HDD_Label2.Location = new System.Drawing.Point(8, 152);
      this.HDD_Label2.Name = "HDD_Label2";
      this.HDD_Label2.Size = new System.Drawing.Size(84, 17);
      this.HDD_Label2.TabIndex = 7;
      this.HDD_Label2.Text = "HDD_LABEL";
      // 
      // HDD_Label
      // 
      this.HDD_Label.AutoSize = true;
      this.HDD_Label.BackColor = System.Drawing.Color.Transparent;
      this.HDD_Label.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.HDD_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
      this.HDD_Label.Location = new System.Drawing.Point(8, 120);
      this.HDD_Label.Name = "HDD_Label";
      this.HDD_Label.Size = new System.Drawing.Size(112, 17);
      this.HDD_Label.TabIndex = 6;
      this.HDD_Label.Text = "Жесткий диск";
      // 
      // RamLabel2
      // 
      this.RamLabel2.AutoSize = true;
      this.RamLabel2.BackColor = System.Drawing.Color.Transparent;
      this.RamLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RamLabel2.ForeColor = System.Drawing.Color.Black;
      this.RamLabel2.Location = new System.Drawing.Point(8, 90);
      this.RamLabel2.Name = "RamLabel2";
      this.RamLabel2.Size = new System.Drawing.Size(86, 17);
      this.RamLabel2.TabIndex = 5;
      this.RamLabel2.Text = "RAM_LABEL";
      // 
      // RamLabel
      // 
      this.RamLabel.AutoSize = true;
      this.RamLabel.BackColor = System.Drawing.Color.Transparent;
      this.RamLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
      this.RamLabel.Location = new System.Drawing.Point(8, 64);
      this.RamLabel.Name = "RamLabel";
      this.RamLabel.Size = new System.Drawing.Size(166, 17);
      this.RamLabel.TabIndex = 4;
      this.RamLabel.Text = "Оперативная память";
      // 
      // ProcLabel2
      // 
      this.ProcLabel2.AutoSize = true;
      this.ProcLabel2.BackColor = System.Drawing.Color.Transparent;
      this.ProcLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProcLabel2.ForeColor = System.Drawing.Color.Black;
      this.ProcLabel2.Location = new System.Drawing.Point(8, 36);
      this.ProcLabel2.Name = "ProcLabel2";
      this.ProcLabel2.Size = new System.Drawing.Size(93, 17);
      this.ProcLabel2.TabIndex = 3;
      this.ProcLabel2.Text = "PROC_LABEL";
      // 
      // ProcLabel
      // 
      this.ProcLabel.AutoSize = true;
      this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
      this.ProcLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ProcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
      this.ProcLabel.Location = new System.Drawing.Point(8, 8);
      this.ProcLabel.Name = "ProcLabel";
      this.ProcLabel.Size = new System.Drawing.Size(88, 17);
      this.ProcLabel.TabIndex = 2;
      this.ProcLabel.Text = "Процессор";
      // 
      // LoadPage
      // 
      this.LoadPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LoadPage.HorizontalScrollbarBarColor = true;
      this.LoadPage.HorizontalScrollbarHighlightOnWheel = false;
      this.LoadPage.HorizontalScrollbarSize = 10;
      this.LoadPage.Location = new System.Drawing.Point(4, 41);
      this.LoadPage.Name = "LoadPage";
      this.LoadPage.Size = new System.Drawing.Size(943, 467);
      this.LoadPage.TabIndex = 1;
      this.LoadPage.Text = "Ресурсы ПК";
      this.LoadPage.VerticalScrollbarBarColor = true;
      this.LoadPage.VerticalScrollbarHighlightOnWheel = false;
      this.LoadPage.VerticalScrollbarSize = 10;
      // 
      // TaskManagerPage
      // 
      this.TaskManagerPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TaskManagerPage.HorizontalScrollbarBarColor = true;
      this.TaskManagerPage.HorizontalScrollbarHighlightOnWheel = false;
      this.TaskManagerPage.HorizontalScrollbarSize = 10;
      this.TaskManagerPage.Location = new System.Drawing.Point(4, 41);
      this.TaskManagerPage.Name = "TaskManagerPage";
      this.TaskManagerPage.Size = new System.Drawing.Size(943, 467);
      this.TaskManagerPage.TabIndex = 2;
      this.TaskManagerPage.Text = "Диспетчер Задач";
      this.TaskManagerPage.VerticalScrollbarBarColor = true;
      this.TaskManagerPage.VerticalScrollbarHighlightOnWheel = false;
      this.TaskManagerPage.VerticalScrollbarSize = 10;
      // 
      // GPU_Label1
      // 
      this.GPU_Label1.AutoSize = true;
      this.GPU_Label1.BackColor = System.Drawing.Color.Transparent;
      this.GPU_Label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.GPU_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
      this.GPU_Label1.Location = new System.Drawing.Point(8, 183);
      this.GPU_Label1.Name = "GPU_Label1";
      this.GPU_Label1.Size = new System.Drawing.Size(96, 17);
      this.GPU_Label1.TabIndex = 8;
      this.GPU_Label1.Text = "Видеокарта";
      // 
      // GPU_Label2
      // 
      this.GPU_Label2.AutoSize = true;
      this.GPU_Label2.BackColor = System.Drawing.Color.Transparent;
      this.GPU_Label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.GPU_Label2.ForeColor = System.Drawing.Color.Black;
      this.GPU_Label2.Location = new System.Drawing.Point(8, 217);
      this.GPU_Label2.Name = "GPU_Label2";
      this.GPU_Label2.Size = new System.Drawing.Size(84, 17);
      this.GPU_Label2.TabIndex = 9;
      this.GPU_Label2.Text = "GPU_LABEL";
      // 
      // ComplexSystemInfoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
      this.ClientSize = new System.Drawing.Size(951, 512);
      this.Controls.Add(this.metroTabControl);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ComplexSystemInfoForm";
      this.Text = "SystemManager";
      this.metroTabControl.ResumeLayout(false);
      this.SystemInfoPage.ResumeLayout(false);
      this.SystemInfoPage.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage SystemInfoPage;
        private MetroFramework.Controls.MetroTabPage LoadPage;
        private MetroFramework.Controls.MetroTabPage TaskManagerPage;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.Label ProcLabel2;
        private System.Windows.Forms.Label RamLabel;
        private System.Windows.Forms.Label RamLabel2;
        private System.Windows.Forms.Label HDD_Label;
        private System.Windows.Forms.Label HDD_Label2;
    private System.Windows.Forms.Label GPU_Label2;
    private System.Windows.Forms.Label GPU_Label1;
  }
}

