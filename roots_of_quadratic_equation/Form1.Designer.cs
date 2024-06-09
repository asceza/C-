namespace roots_of_quadratic_equation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxA = new TextBox();
            label3 = new Label();
            textBoxB = new TextBox();
            label4 = new Label();
            textBoxC = new TextBox();
            label5 = new Label();
            label6 = new Label();
            labelD = new Label();
            labelX1 = new Label();
            labelX2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(495, 32);
            label1.TabIndex = 0;
            label1.Text = "ax² + bx + c = 0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 0;
            label2.Text = "a = ";
            // 
            // textBoxA
            // 
            textBoxA.BackColor = Color.WhiteSmoke;
            textBoxA.Font = new Font("Consolas", 20.25F);
            textBoxA.Location = new Point(77, 78);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(86, 39);
            textBoxA.TabIndex = 1;
            textBoxA.Text = "2";
            textBoxA.TextAlign = HorizontalAlignment.Center;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(186, 81);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 0;
            label3.Text = "b = ";
            // 
            // textBoxB
            // 
            textBoxB.BackColor = Color.WhiteSmoke;
            textBoxB.Font = new Font("Consolas", 20.25F);
            textBoxB.Location = new Point(250, 78);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(86, 39);
            textBoxB.TabIndex = 1;
            textBoxB.Text = "11";
            textBoxB.TextAlign = HorizontalAlignment.Center;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(358, 81);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 0;
            label4.Text = "c = ";
            // 
            // textBoxC
            // 
            textBoxC.BackColor = Color.WhiteSmoke;
            textBoxC.Font = new Font("Consolas", 20.25F);
            textBoxC.Location = new Point(422, 78);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(86, 39);
            textBoxC.TabIndex = 1;
            textBoxC.Text = "-6";
            textBoxC.TextAlign = HorizontalAlignment.Center;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(13, 157);
            label5.Name = "label5";
            label5.Size = new Size(495, 32);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(16, 136);
            label6.Name = "label6";
            label6.Size = new Size(495, 2);
            label6.TabIndex = 0;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelD.Location = new Point(13, 212);
            labelD.Name = "labelD";
            labelD.Size = new Size(74, 32);
            labelD.TabIndex = 0;
            labelD.Text = "D = ";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelX1.Location = new Point(12, 262);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(89, 32);
            labelX1.TabIndex = 0;
            labelX1.Text = "x₁ = ";
            // 
            // labelX2
            // 
            labelX2.AutoSize = true;
            labelX2.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelX2.Location = new Point(12, 312);
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(89, 32);
            labelX2.TabIndex = 0;
            labelX2.Text = "x₂ = ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(529, 361);
            Controls.Add(textBoxC);
            Controls.Add(label4);
            Controls.Add(textBoxB);
            Controls.Add(label3);
            Controls.Add(textBoxA);
            Controls.Add(labelX2);
            Controls.Add(labelX1);
            Controls.Add(labelD);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Корни квадратного уравнения";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private Label label3;
        private TextBox textBoxB;
        private Label label4;
        private TextBox textBoxC;
        private Label label5;
        private Label label6;
        private Label labelD;
        private Label labelX1;
        private Label labelX2;
    }
}
