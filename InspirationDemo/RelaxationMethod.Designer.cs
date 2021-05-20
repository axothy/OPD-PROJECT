namespace InspirationDemo
{
    partial class RelaxationMethod
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxRelaxation_eq = new System.Windows.Forms.TextBox();
            this.operationsRelaxationTextBox = new System.Windows.Forms.ListBox();
            this.rootRelaxationTextBox = new System.Windows.Forms.ListBox();
            this.iterRelaxationTextBox = new System.Windows.Forms.ListBox();
            this.resultRelaxation = new System.Windows.Forms.ListBox();
            this.SolveRelaxation = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.epsilonRelaxationTextBox = new System.Windows.Forms.TextBox();
            this.tauRelaxationTextBox = new System.Windows.Forms.TextBox();
            this.x0RelaxationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtBoxRelaxation_eq);
            this.panel3.Controls.Add(this.operationsRelaxationTextBox);
            this.panel3.Controls.Add(this.rootRelaxationTextBox);
            this.panel3.Controls.Add(this.iterRelaxationTextBox);
            this.panel3.Controls.Add(this.resultRelaxation);
            this.panel3.Controls.Add(this.SolveRelaxation);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(19, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 313);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtBoxRelaxation_eq
            // 
            this.txtBoxRelaxation_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRelaxation_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxRelaxation_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxRelaxation_eq.Location = new System.Drawing.Point(17, 23);
            this.txtBoxRelaxation_eq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxRelaxation_eq.Name = "txtBoxRelaxation_eq";
            this.txtBoxRelaxation_eq.Size = new System.Drawing.Size(243, 27);
            this.txtBoxRelaxation_eq.TabIndex = 26;
            this.txtBoxRelaxation_eq.Text = "Функция";
            this.txtBoxRelaxation_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operationsRelaxationTextBox
            // 
            this.operationsRelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsRelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsRelaxationTextBox.ForeColor = System.Drawing.Color.Black;
            this.operationsRelaxationTextBox.FormattingEnabled = true;
            this.operationsRelaxationTextBox.ItemHeight = 20;
            this.operationsRelaxationTextBox.Location = new System.Drawing.Point(27, 279);
            this.operationsRelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsRelaxationTextBox.Name = "operationsRelaxationTextBox";
            this.operationsRelaxationTextBox.Size = new System.Drawing.Size(215, 20);
            this.operationsRelaxationTextBox.TabIndex = 24;
            this.operationsRelaxationTextBox.TabStop = false;
            // 
            // rootRelaxationTextBox
            // 
            this.rootRelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootRelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootRelaxationTextBox.ForeColor = System.Drawing.Color.Black;
            this.rootRelaxationTextBox.FormattingEnabled = true;
            this.rootRelaxationTextBox.ItemHeight = 20;
            this.rootRelaxationTextBox.Location = new System.Drawing.Point(27, 254);
            this.rootRelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rootRelaxationTextBox.Name = "rootRelaxationTextBox";
            this.rootRelaxationTextBox.Size = new System.Drawing.Size(215, 20);
            this.rootRelaxationTextBox.TabIndex = 24;
            this.rootRelaxationTextBox.TabStop = false;
            // 
            // iterRelaxationTextBox
            // 
            this.iterRelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterRelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterRelaxationTextBox.ForeColor = System.Drawing.Color.Black;
            this.iterRelaxationTextBox.FormattingEnabled = true;
            this.iterRelaxationTextBox.ItemHeight = 20;
            this.iterRelaxationTextBox.Location = new System.Drawing.Point(27, 226);
            this.iterRelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterRelaxationTextBox.Name = "iterRelaxationTextBox";
            this.iterRelaxationTextBox.Size = new System.Drawing.Size(215, 20);
            this.iterRelaxationTextBox.TabIndex = 24;
            this.iterRelaxationTextBox.TabStop = false;
            // 
            // resultRelaxation
            // 
            this.resultRelaxation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultRelaxation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultRelaxation.ForeColor = System.Drawing.Color.Black;
            this.resultRelaxation.FormattingEnabled = true;
            this.resultRelaxation.ItemHeight = 20;
            this.resultRelaxation.Location = new System.Drawing.Point(27, 87);
            this.resultRelaxation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultRelaxation.Name = "resultRelaxation";
            this.resultRelaxation.Size = new System.Drawing.Size(181, 80);
            this.resultRelaxation.TabIndex = 23;
            this.resultRelaxation.TabStop = false;
            // 
            // SolveRelaxation
            // 
            this.SolveRelaxation.BackColor = System.Drawing.SystemColors.Control;
            this.SolveRelaxation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveRelaxation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveRelaxation.ForeColor = System.Drawing.Color.Black;
            this.SolveRelaxation.Location = new System.Drawing.Point(291, 217);
            this.SolveRelaxation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SolveRelaxation.Name = "SolveRelaxation";
            this.SolveRelaxation.Size = new System.Drawing.Size(187, 30);
            this.SolveRelaxation.TabIndex = 6;
            this.SolveRelaxation.Text = "Решить";
            this.SolveRelaxation.UseVisualStyleBackColor = false;
            this.SolveRelaxation.Click += new System.EventHandler(this.SolveRelaxation_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.epsilonRelaxationTextBox);
            this.panel4.Controls.Add(this.tauRelaxationTextBox);
            this.panel4.Controls.Add(this.x0RelaxationTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(291, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 178);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(121, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "*";
            // 
            // epsilonRelaxationTextBox
            // 
            this.epsilonRelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epsilonRelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilonRelaxationTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.epsilonRelaxationTextBox.Location = new System.Drawing.Point(19, 113);
            this.epsilonRelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsilonRelaxationTextBox.Name = "epsilonRelaxationTextBox";
            this.epsilonRelaxationTextBox.Size = new System.Drawing.Size(101, 27);
            this.epsilonRelaxationTextBox.TabIndex = 31;
            this.epsilonRelaxationTextBox.Text = "Точность";
            this.epsilonRelaxationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tauRelaxationTextBox
            // 
            this.tauRelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tauRelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tauRelaxationTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tauRelaxationTextBox.Location = new System.Drawing.Point(19, 80);
            this.tauRelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tauRelaxationTextBox.Name = "tauRelaxationTextBox";
            this.tauRelaxationTextBox.Size = new System.Drawing.Size(101, 27);
            this.tauRelaxationTextBox.TabIndex = 30;
            this.tauRelaxationTextBox.Text = "Параметр";
            this.tauRelaxationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x0RelaxationTextBox
            // 
            this.x0RelaxationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x0RelaxationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0RelaxationTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.x0RelaxationTextBox.Location = new System.Drawing.Point(19, 47);
            this.x0RelaxationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x0RelaxationTextBox.Name = "x0RelaxationTextBox";
            this.x0RelaxationTextBox.Size = new System.Drawing.Size(101, 27);
            this.x0RelaxationTextBox.TabIndex = 29;
            this.x0RelaxationTextBox.Text = "x0";
            this.x0RelaxationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Начальные данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Метод релаксации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "* Параметр релаксации (tau)";
            // 
            // RelaxationMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RelaxationMethod";
            this.Size = new System.Drawing.Size(745, 549);
            this.Load += new System.EventHandler(this.MPDMethod_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox operationsRelaxationTextBox;
        private System.Windows.Forms.ListBox rootRelaxationTextBox;
        private System.Windows.Forms.ListBox iterRelaxationTextBox;
        private System.Windows.Forms.ListBox resultRelaxation;
        private System.Windows.Forms.Button SolveRelaxation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox epsilonRelaxationTextBox;
        private System.Windows.Forms.TextBox tauRelaxationTextBox;
        private System.Windows.Forms.TextBox x0RelaxationTextBox;
        private System.Windows.Forms.TextBox txtBoxRelaxation_eq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
