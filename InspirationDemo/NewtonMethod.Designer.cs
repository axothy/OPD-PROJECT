namespace InspirationDemo
{
    partial class NewtonMethod
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkNewtonIfNeedFile = new System.Windows.Forms.CheckBox();
            this.txtBoxNewton_diffeq = new System.Windows.Forms.TextBox();
            this.txtBoxNewton_eq = new System.Windows.Forms.TextBox();
            this.operationsNewtonTextBox = new System.Windows.Forms.ListBox();
            this.rootNewtonTextBox = new System.Windows.Forms.ListBox();
            this.iterNewtonTextBox = new System.Windows.Forms.ListBox();
            this.resultNewton = new System.Windows.Forms.ListBox();
            this.buttonSolveNewton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.epsilonNewtonTextBox = new System.Windows.Forms.TextBox();
            this.x0NewtonTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(271, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Метод Ньютона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(555, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Один из самых популярнейших численных методов отыскания корня нелинейного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "уравнения, заключающийся в проведении касательных к графику функции. Точка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "пересечения касательной с осью Ox - новое приближение к корню уравнения.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.checkNewtonIfNeedFile);
            this.panel3.Controls.Add(this.txtBoxNewton_diffeq);
            this.panel3.Controls.Add(this.txtBoxNewton_eq);
            this.panel3.Controls.Add(this.operationsNewtonTextBox);
            this.panel3.Controls.Add(this.rootNewtonTextBox);
            this.panel3.Controls.Add(this.iterNewtonTextBox);
            this.panel3.Controls.Add(this.resultNewton);
            this.panel3.Controls.Add(this.buttonSolveNewton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(19, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 363);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // checkNewtonIfNeedFile
            // 
            this.checkNewtonIfNeedFile.AutoSize = true;
            this.checkNewtonIfNeedFile.Location = new System.Drawing.Point(291, 266);
            this.checkNewtonIfNeedFile.Name = "checkNewtonIfNeedFile";
            this.checkNewtonIfNeedFile.Size = new System.Drawing.Size(122, 21);
            this.checkNewtonIfNeedFile.TabIndex = 29;
            this.checkNewtonIfNeedFile.Text = "Вывод в файл";
            this.checkNewtonIfNeedFile.UseVisualStyleBackColor = true;
            // 
            // txtBoxNewton_diffeq
            // 
            this.txtBoxNewton_diffeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewton_diffeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxNewton_diffeq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNewton_diffeq.Location = new System.Drawing.Point(17, 57);
            this.txtBoxNewton_diffeq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNewton_diffeq.Name = "txtBoxNewton_diffeq";
            this.txtBoxNewton_diffeq.Size = new System.Drawing.Size(243, 27);
            this.txtBoxNewton_diffeq.TabIndex = 27;
            this.txtBoxNewton_diffeq.Text = "Производная";
            this.txtBoxNewton_diffeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxNewton_eq
            // 
            this.txtBoxNewton_eq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNewton_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxNewton_eq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNewton_eq.Location = new System.Drawing.Point(17, 23);
            this.txtBoxNewton_eq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxNewton_eq.Name = "txtBoxNewton_eq";
            this.txtBoxNewton_eq.Size = new System.Drawing.Size(243, 27);
            this.txtBoxNewton_eq.TabIndex = 26;
            this.txtBoxNewton_eq.Text = "Функция";
            this.txtBoxNewton_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // operationsNewtonTextBox
            // 
            this.operationsNewtonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsNewtonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsNewtonTextBox.ForeColor = System.Drawing.Color.Black;
            this.operationsNewtonTextBox.FormattingEnabled = true;
            this.operationsNewtonTextBox.ItemHeight = 20;
            this.operationsNewtonTextBox.Location = new System.Drawing.Point(27, 330);
            this.operationsNewtonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.operationsNewtonTextBox.Name = "operationsNewtonTextBox";
            this.operationsNewtonTextBox.Size = new System.Drawing.Size(215, 20);
            this.operationsNewtonTextBox.TabIndex = 24;
            this.operationsNewtonTextBox.TabStop = false;
            // 
            // rootNewtonTextBox
            // 
            this.rootNewtonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootNewtonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootNewtonTextBox.ForeColor = System.Drawing.Color.Black;
            this.rootNewtonTextBox.FormattingEnabled = true;
            this.rootNewtonTextBox.ItemHeight = 20;
            this.rootNewtonTextBox.Location = new System.Drawing.Point(27, 304);
            this.rootNewtonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rootNewtonTextBox.Name = "rootNewtonTextBox";
            this.rootNewtonTextBox.Size = new System.Drawing.Size(215, 20);
            this.rootNewtonTextBox.TabIndex = 24;
            this.rootNewtonTextBox.TabStop = false;
            // 
            // iterNewtonTextBox
            // 
            this.iterNewtonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterNewtonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterNewtonTextBox.ForeColor = System.Drawing.Color.Black;
            this.iterNewtonTextBox.FormattingEnabled = true;
            this.iterNewtonTextBox.ItemHeight = 20;
            this.iterNewtonTextBox.Location = new System.Drawing.Point(27, 278);
            this.iterNewtonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterNewtonTextBox.Name = "iterNewtonTextBox";
            this.iterNewtonTextBox.Size = new System.Drawing.Size(215, 20);
            this.iterNewtonTextBox.TabIndex = 24;
            this.iterNewtonTextBox.TabStop = false;
            // 
            // resultNewton
            // 
            this.resultNewton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultNewton.ForeColor = System.Drawing.Color.Black;
            this.resultNewton.FormattingEnabled = true;
            this.resultNewton.ItemHeight = 20;
            this.resultNewton.Location = new System.Drawing.Point(27, 148);
            this.resultNewton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultNewton.Name = "resultNewton";
            this.resultNewton.Size = new System.Drawing.Size(181, 80);
            this.resultNewton.TabIndex = 23;
            this.resultNewton.TabStop = false;
            // 
            // buttonSolveNewton
            // 
            this.buttonSolveNewton.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSolveNewton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolveNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSolveNewton.ForeColor = System.Drawing.Color.Black;
            this.buttonSolveNewton.Location = new System.Drawing.Point(291, 217);
            this.buttonSolveNewton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSolveNewton.Name = "buttonSolveNewton";
            this.buttonSolveNewton.Size = new System.Drawing.Size(187, 30);
            this.buttonSolveNewton.TabIndex = 6;
            this.buttonSolveNewton.Text = "Решить";
            this.buttonSolveNewton.UseVisualStyleBackColor = false;
            this.buttonSolveNewton.Click += new System.EventHandler(this.buttonSolveNewton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.epsilonNewtonTextBox);
            this.panel4.Controls.Add(this.x0NewtonTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(291, 23);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 178);
            this.panel4.TabIndex = 0;
            // 
            // epsilonNewtonTextBox
            // 
            this.epsilonNewtonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epsilonNewtonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epsilonNewtonTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.epsilonNewtonTextBox.Location = new System.Drawing.Point(19, 80);
            this.epsilonNewtonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsilonNewtonTextBox.Name = "epsilonNewtonTextBox";
            this.epsilonNewtonTextBox.Size = new System.Drawing.Size(101, 27);
            this.epsilonNewtonTextBox.TabIndex = 32;
            this.epsilonNewtonTextBox.Text = "Точность";
            this.epsilonNewtonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x0NewtonTextBox
            // 
            this.x0NewtonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x0NewtonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0NewtonTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.x0NewtonTextBox.Location = new System.Drawing.Point(19, 47);
            this.x0NewtonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x0NewtonTextBox.Name = "x0NewtonTextBox";
            this.x0NewtonTextBox.Size = new System.Drawing.Size(101, 27);
            this.x0NewtonTextBox.TabIndex = 31;
            this.x0NewtonTextBox.Text = "x0";
            this.x0NewtonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Начальные данные";
            // 
            // NewtonMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewtonMethod";
            this.Size = new System.Drawing.Size(745, 549);
            this.Load += new System.EventHandler(this.NewtonMethod_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox operationsNewtonTextBox;
        private System.Windows.Forms.ListBox rootNewtonTextBox;
        private System.Windows.Forms.ListBox iterNewtonTextBox;
        private System.Windows.Forms.ListBox resultNewton;
        private System.Windows.Forms.Button buttonSolveNewton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox epsilonNewtonTextBox;
        private System.Windows.Forms.TextBox x0NewtonTextBox;
        private System.Windows.Forms.TextBox txtBoxNewton_eq;
        private System.Windows.Forms.TextBox txtBoxNewton_diffeq;
        private System.Windows.Forms.CheckBox checkNewtonIfNeedFile;
    }
}
