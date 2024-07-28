namespace MessageGenerator
{
    partial class Form1
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
            this.groupBoxWorkers = new System.Windows.Forms.GroupBox();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.groupBoxPlaceTasks = new System.Windows.Forms.GroupBox();
            this.comboBoxPlaceTasks = new System.Windows.Forms.ComboBox();
            this.groupTypeTasks = new System.Windows.Forms.GroupBox();
            this.comboBoxTypeTasks = new System.Windows.Forms.ComboBox();
            this.groupBoxComment = new System.Windows.Forms.GroupBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonCopyToBufer = new System.Windows.Forms.Button();
            this.groupBoxWorkers.SuspendLayout();
            this.groupBoxPlaceTasks.SuspendLayout();
            this.groupTypeTasks.SuspendLayout();
            this.groupBoxComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxWorkers
            // 
            this.groupBoxWorkers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBoxWorkers.Controls.Add(this.comboBoxWorkers);
            this.groupBoxWorkers.Location = new System.Drawing.Point(10, 8);
            this.groupBoxWorkers.Name = "groupBoxWorkers";
            this.groupBoxWorkers.Size = new System.Drawing.Size(265, 50);
            this.groupBoxWorkers.TabIndex = 1;
            this.groupBoxWorkers.TabStop = false;
            this.groupBoxWorkers.Text = "ФИО сотрудника";
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(3, 16);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(259, 21);
            this.comboBoxWorkers.TabIndex = 1;
            // 
            // groupBoxPlaceTasks
            // 
            this.groupBoxPlaceTasks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBoxPlaceTasks.Controls.Add(this.comboBoxPlaceTasks);
            this.groupBoxPlaceTasks.Location = new System.Drawing.Point(10, 73);
            this.groupBoxPlaceTasks.Name = "groupBoxPlaceTasks";
            this.groupBoxPlaceTasks.Size = new System.Drawing.Size(265, 50);
            this.groupBoxPlaceTasks.TabIndex = 1;
            this.groupBoxPlaceTasks.TabStop = false;
            this.groupBoxPlaceTasks.Text = "Место выполнения задачи";
            // 
            // comboBoxPlaceTasks
            // 
            this.comboBoxPlaceTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPlaceTasks.FormattingEnabled = true;
            this.comboBoxPlaceTasks.Location = new System.Drawing.Point(3, 16);
            this.comboBoxPlaceTasks.Name = "comboBoxPlaceTasks";
            this.comboBoxPlaceTasks.Size = new System.Drawing.Size(259, 21);
            this.comboBoxPlaceTasks.TabIndex = 1;
            // 
            // groupTypeTasks
            // 
            this.groupTypeTasks.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupTypeTasks.Controls.Add(this.comboBoxTypeTasks);
            this.groupTypeTasks.Location = new System.Drawing.Point(12, 138);
            this.groupTypeTasks.Name = "groupTypeTasks";
            this.groupTypeTasks.Size = new System.Drawing.Size(265, 50);
            this.groupTypeTasks.TabIndex = 1;
            this.groupTypeTasks.TabStop = false;
            this.groupTypeTasks.Text = "Тип задачи";
            // 
            // comboBoxTypeTasks
            // 
            this.comboBoxTypeTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTypeTasks.FormattingEnabled = true;
            this.comboBoxTypeTasks.Location = new System.Drawing.Point(3, 16);
            this.comboBoxTypeTasks.Name = "comboBoxTypeTasks";
            this.comboBoxTypeTasks.Size = new System.Drawing.Size(259, 21);
            this.comboBoxTypeTasks.TabIndex = 1;
            // 
            // groupBoxComment
            // 
            this.groupBoxComment.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBoxComment.Controls.Add(this.textBoxComment);
            this.groupBoxComment.Location = new System.Drawing.Point(10, 203);
            this.groupBoxComment.Name = "groupBoxComment";
            this.groupBoxComment.Size = new System.Drawing.Size(265, 84);
            this.groupBoxComment.TabIndex = 1;
            this.groupBoxComment.TabStop = false;
            this.groupBoxComment.Text = "Комментарий";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(3, 16);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(259, 60);
            this.textBoxComment.TabIndex = 0;
            // 
            // buttonCopyToBufer
            // 
            this.buttonCopyToBufer.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCopyToBufer.Location = new System.Drawing.Point(13, 298);
            this.buttonCopyToBufer.Name = "buttonCopyToBufer";
            this.buttonCopyToBufer.Size = new System.Drawing.Size(258, 23);
            this.buttonCopyToBufer.TabIndex = 2;
            this.buttonCopyToBufer.Text = "Копировать";
            this.buttonCopyToBufer.UseVisualStyleBackColor = false;
            this.buttonCopyToBufer.Click += new System.EventHandler(this.buttonCopyToBufer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(286, 333);
            this.Controls.Add(this.buttonCopyToBufer);
            this.Controls.Add(this.groupBoxComment);
            this.Controls.Add(this.groupTypeTasks);
            this.Controls.Add(this.groupBoxPlaceTasks);
            this.Controls.Add(this.groupBoxWorkers);
            this.Name = "Form1";
            this.Text = "MessageGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxWorkers.ResumeLayout(false);
            this.groupBoxPlaceTasks.ResumeLayout(false);
            this.groupTypeTasks.ResumeLayout(false);
            this.groupBoxComment.ResumeLayout(false);
            this.groupBoxComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxWorkers;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.GroupBox groupBoxPlaceTasks;
        private System.Windows.Forms.ComboBox comboBoxPlaceTasks;
        private System.Windows.Forms.GroupBox groupTypeTasks;
        private System.Windows.Forms.ComboBox comboBoxTypeTasks;
        private System.Windows.Forms.GroupBox groupBoxComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonCopyToBufer;
    }
}

