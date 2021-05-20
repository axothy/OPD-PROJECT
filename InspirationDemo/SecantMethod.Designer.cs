namespace InspirationDemo
{
    partial class SecantMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkSecantIfNeedFile = new System.Windows.Forms.CheckBox();
            this.txtBoxSecant_eq = new System.Windows.Forms.TextBox();
            this.operationsSecantTextBox = new System.Windows.Forms.ListBox();
            this.rootSecantTextBox = new System.Windows.Forms.ListBox();
            this.iterSecantTextBox = new System.Windows.Forms.ListBox();
            this.resultSecant = new System.Windows.Forms.ListBox();
            this.SolveSecant = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.epsilonSecantTextBox = new System.Windows.Forms.TextBox();
            this.x1SecantTextBox = new System.Windows.Forms.TextBox();
            this.x0SecantTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Метод секущих";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.checkSecantIfNeedFile);
            this.panel3.Controls.Add(this.txtBoxSecant_eq);
            this.panel3.Controls.Add(this.operationsSecantTextBox);
            this.panel3.Controls.Add(this.rootSecantTextBox);
            this.panel3.Controls.Add(this.iterSecantTextBox);
            this.panel3.Controls.Add(this.resultSecant);
            this.panel3.Controls.Add(this.SolveSecant);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(19, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 313);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // checkSecantIfNeedFile
            // 
            this.checkSecantIfNeedFile.AutoSize = true;
            this.checkSecantIfNeedFile.Location = new System.Drawing.Point(289, 254);
            this.checkSecantIfNeedFile.Name = "checkSecantIfNeedFile";
            this.checkSecantIfNeedFile.Size = new System.Drawing.Size(122, 21);
            this.checkSecantIfNeedFile.TabIndex = 18;
            this.checkSecantIfNeedFile.Text = "Вывод в файл";
            this.checkSecantIfNeedFile.UseVisualStyleBackColor = true;
            // 
            // txtBoxSecant_eq
            // 
            this.txtBoxSecant_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSecant_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSecant_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxSecant_eq.Location = new System.Drawing.Point(17, 23);
            this.txtBoxSecant_eq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSecant_eq.Name = "txtBoxSecant_eq";
            this.txtBoxSecant_eq.Size = new System.Drawing.Size(243, 27);
            this.txtBoxSecant_eq.TabIndex = 25;
            this.txtBoxSecant_eq.Text = "Функция";
            this.txtBoxSecant_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operationsSecantTextBox
            // 
            this.operationsSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.operationsSecantTextBox.FormattingEnabled = true;
            this.operationsSecantTextBox.ItemHeight = 20;
            this.operationsSecantTextBox.Location = new System.Drawing.Point(27, 279);
            this.operationsSecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsSecantTextBox.Name = "operationsSecantTextBox";
            this.operationsSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.operationsSecantTextBox.TabIndex = 24;
            this.operationsSecantTextBox.TabStop = false;
            // 
            // rootSecantTextBox
            // 
            this.rootSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.rootSecantTextBox.FormattingEnabled = true;
            this.rootSecantTextBox.ItemHeight = 20;
            this.rootSecantTextBox.Location = new System.Drawing.Point(27, 254);
            this.rootSecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rootSecantTextBox.Name = "rootSecantTextBox";
            this.rootSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.rootSecantTextBox.TabIndex = 24;
            this.rootSecantTextBox.TabStop = false;
            // 
            // iterSecantTextBox
            // 
            this.iterSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.iterSecantTextBox.FormattingEnabled = true;
            this.iterSecantTextBox.ItemHeight = 20;
            this.iterSecantTextBox.Location = new System.Drawing.Point(27, 226);
            this.iterSecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterSecantTextBox.Name = "iterSecantTextBox";
            this.iterSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.iterSecantTextBox.TabIndex = 24;
            this.iterSecantTextBox.TabStop = false;
            // 
            // resultSecant
            // 
            this.resultSecant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultSecant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultSecant.ForeColor = System.Drawing.Color.Black;
            this.resultSecant.FormattingEnabled = true;
            this.resultSecant.ItemHeight = 20;
            this.resultSecant.Location = new System.Drawing.Point(27, 87);
            this.resultSecant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultSecant.Name = "resultSecant";
            this.resultSecant.Size = new System.Drawing.Size(181, 80);
            this.resultSecant.TabIndex = 23;
            this.resultSecant.TabStop = false;
            // 
            // SolveSecant
            // 
            this.SolveSecant.BackColor = System.Drawing.SystemColors.Control;
            this.SolveSecant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveSecant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveSecant.ForeColor = System.Drawing.Color.Black;
            this.SolveSecant.Location = new System.Drawing.Point(291, 217);
            this.SolveSecant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SolveSecant.Name = "SolveSecant";
            this.SolveSecant.Size = new System.Drawing.Size(187, 30);
            this.SolveSecant.TabIndex = 6;
            this.SolveSecant.Text = "Решить";
            this.SolveSecant.UseVisualStyleBackColor = false;
            this.SolveSecant.Click += new System.EventHandler(this.SolveSecant_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.epsilonSecantTextBox);
            this.panel4.Controls.Add(this.x1SecantTextBox);
            this.panel4.Controls.Add(this.x0SecantTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(291, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 178);
            this.panel4.TabIndex = 0;
            // 
            // epsilonSecantTextBox
            // 
            this.epsilonSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epsilonSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilonSecantTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.epsilonSecantTextBox.Location = new System.Drawing.Point(19, 113);
            this.epsilonSecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsilonSecantTextBox.Name = "epsilonSecantTextBox";
            this.epsilonSecantTextBox.Size = new System.Drawing.Size(101, 27);
            this.epsilonSecantTextBox.TabIndex = 28;
            this.epsilonSecantTextBox.Text = "Точность";
            this.epsilonSecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x1SecantTextBox
            // 
            this.x1SecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x1SecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1SecantTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.x1SecantTextBox.Location = new System.Drawing.Point(19, 80);
            this.x1SecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x1SecantTextBox.Name = "x1SecantTextBox";
            this.x1SecantTextBox.Size = new System.Drawing.Size(101, 27);
            this.x1SecantTextBox.TabIndex = 27;
            this.x1SecantTextBox.Text = "x1";
            this.x1SecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x0SecantTextBox
            // 
            this.x0SecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x0SecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0SecantTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.x0SecantTextBox.Location = new System.Drawing.Point(19, 47);
            this.x0SecantTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x0SecantTextBox.Name = "x0SecantTextBox";
            this.x0SecantTextBox.Size = new System.Drawing.Size(101, 27);
            this.x0SecantTextBox.TabIndex = 26;
            this.x0SecantTextBox.Text = "x0";
            this.x0SecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // SecantMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SecantMethod";
            this.Size = new System.Drawing.Size(745, 549);
            this.Load += new System.EventHandler(this.SecantMethod_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox operationsSecantTextBox;
        private System.Windows.Forms.ListBox rootSecantTextBox;
        private System.Windows.Forms.ListBox iterSecantTextBox;
        private System.Windows.Forms.ListBox resultSecant;
        private System.Windows.Forms.Button SolveSecant;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSecant_eq;
        private System.Windows.Forms.TextBox epsilonSecantTextBox;
        private System.Windows.Forms.TextBox x1SecantTextBox;
        private System.Windows.Forms.TextBox x0SecantTextBox;
        private System.Windows.Forms.CheckBox checkSecantIfNeedFile;
    }
}
