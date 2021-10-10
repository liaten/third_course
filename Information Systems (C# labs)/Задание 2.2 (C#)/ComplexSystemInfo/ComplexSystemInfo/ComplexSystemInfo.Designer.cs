
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.SystemInfoPage = new MetroFramework.Controls.MetroTabPage();
            this.ProcLabel2 = new System.Windows.Forms.Label();
            this.ProcLabel = new System.Windows.Forms.Label();
            this.LoadPage = new MetroFramework.Controls.MetroTabPage();
            this.TaskManagerPage = new MetroFramework.Controls.MetroTabPage();
            this.panel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.SystemInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.HeaderLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 34);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(832, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 34);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderLabel.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(326, 33);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Complex System Info App";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.HeaderLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.HeaderLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.SystemInfoPage);
            this.metroTabControl.Controls.Add(this.LoadPage);
            this.metroTabControl.Controls.Add(this.TaskManagerPage);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 34);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(866, 560);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // SystemInfoPage
            // 
            this.SystemInfoPage.BackColor = System.Drawing.Color.Transparent;
            this.SystemInfoPage.Controls.Add(this.ProcLabel2);
            this.SystemInfoPage.Controls.Add(this.ProcLabel);
            this.SystemInfoPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SystemInfoPage.HorizontalScrollbarBarColor = true;
            this.SystemInfoPage.HorizontalScrollbarHighlightOnWheel = false;
            this.SystemInfoPage.HorizontalScrollbarSize = 10;
            this.SystemInfoPage.Location = new System.Drawing.Point(4, 38);
            this.SystemInfoPage.Name = "SystemInfoPage";
            this.SystemInfoPage.Size = new System.Drawing.Size(858, 518);
            this.SystemInfoPage.TabIndex = 0;
            this.SystemInfoPage.Text = "Информация о системе";
            this.SystemInfoPage.VerticalScrollbarBarColor = true;
            this.SystemInfoPage.VerticalScrollbarHighlightOnWheel = false;
            this.SystemInfoPage.VerticalScrollbarSize = 10;
            // 
            // ProcLabel2
            // 
            this.ProcLabel2.AutoSize = true;
            this.ProcLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcLabel2.ForeColor = System.Drawing.Color.Red;
            this.ProcLabel2.Location = new System.Drawing.Point(8, 36);
            this.ProcLabel2.Name = "ProcLabel2";
            this.ProcLabel2.Size = new System.Drawing.Size(94, 17);
            this.ProcLabel2.TabIndex = 3;
            this.ProcLabel2.Text = "intel blah blah";
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcLabel.Location = new System.Drawing.Point(8, 9);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(79, 17);
            this.ProcLabel.TabIndex = 2;
            this.ProcLabel.Text = "Процессор";
            // 
            // LoadPage
            // 
            this.LoadPage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadPage.HorizontalScrollbarBarColor = true;
            this.LoadPage.HorizontalScrollbarHighlightOnWheel = false;
            this.LoadPage.HorizontalScrollbarSize = 10;
            this.LoadPage.Location = new System.Drawing.Point(4, 38);
            this.LoadPage.Name = "LoadPage";
            this.LoadPage.Size = new System.Drawing.Size(858, 518);
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
            this.TaskManagerPage.Location = new System.Drawing.Point(4, 38);
            this.TaskManagerPage.Name = "TaskManagerPage";
            this.TaskManagerPage.Size = new System.Drawing.Size(858, 518);
            this.TaskManagerPage.TabIndex = 2;
            this.TaskManagerPage.Text = "Диспетчер Задач";
            this.TaskManagerPage.VerticalScrollbarBarColor = true;
            this.TaskManagerPage.VerticalScrollbarHighlightOnWheel = false;
            this.TaskManagerPage.VerticalScrollbarSize = 10;
            // 
            // ComplexSystemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(866, 594);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComplexSystemInfoForm";
            this.Text = "SystemManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.SystemInfoPage.ResumeLayout(false);
            this.SystemInfoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button CloseButton;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage SystemInfoPage;
        private MetroFramework.Controls.MetroTabPage LoadPage;
        private MetroFramework.Controls.MetroTabPage TaskManagerPage;
        private System.Windows.Forms.Label ProcLabel;
        private System.Windows.Forms.Label ProcLabel2;
    }
}

