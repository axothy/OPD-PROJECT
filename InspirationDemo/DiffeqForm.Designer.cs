namespace InspirationDemo
{
    partial class DiffeqForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RK4Choose = new System.Windows.Forms.RadioButton();
            this.RK3Choose = new System.Windows.Forms.RadioButton();
            this.RK2Choose = new System.Windows.Forms.RadioButton();
            this.EulerChoose = new System.Windows.Forms.RadioButton();
            this.txtBox_function = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Analytical = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SolveDiffeq = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bDiffeq = new System.Windows.Forms.TextBox();
            this.aDiffeq = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CheckIfNeedErrors = new System.Windows.Forms.CheckBox();
            this.checkDiffeqIfNeedFile = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.xAnswer = new System.Windows.Forms.RichTextBox();
            this.yAnswer = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.x0TxtBox = new System.Windows.Forms.TextBox();
            this.y0TxtBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.resultError = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Численное решение дифференциальных уравнений";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RK4Choose);
            this.groupBox1.Controls.Add(this.RK3Choose);
            this.groupBox1.Controls.Add(this.RK2Choose);
            this.groupBox1.Controls.Add(this.EulerChoose);
            this.groupBox1.Location = new System.Drawing.Point(22, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 138);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода";
            // 
            // RK4Choose
            // 
            this.RK4Choose.AutoSize = true;
            this.RK4Choose.Location = new System.Drawing.Point(6, 102);
            this.RK4Choose.Name = "RK4Choose";
            this.RK4Choose.Size = new System.Drawing.Size(246, 21);
            this.RK4Choose.TabIndex = 5;
            this.RK4Choose.TabStop = true;
            this.RK4Choose.Text = "Метод Рунге-Кутты 4-го порядка";
            this.RK4Choose.UseVisualStyleBackColor = true;
            // 
            // RK3Choose
            // 
            this.RK3Choose.AutoSize = true;
            this.RK3Choose.Location = new System.Drawing.Point(6, 75);
            this.RK3Choose.Name = "RK3Choose";
            this.RK3Choose.Size = new System.Drawing.Size(246, 21);
            this.RK3Choose.TabIndex = 4;
            this.RK3Choose.TabStop = true;
            this.RK3Choose.Text = "Метод Рунге-Кутты 3-го порядка";
            this.RK3Choose.UseVisualStyleBackColor = true;
            // 
            // RK2Choose
            // 
            this.RK2Choose.AutoSize = true;
            this.RK2Choose.Location = new System.Drawing.Point(6, 48);
            this.RK2Choose.Name = "RK2Choose";
            this.RK2Choose.Size = new System.Drawing.Size(246, 21);
            this.RK2Choose.TabIndex = 3;
            this.RK2Choose.TabStop = true;
            this.RK2Choose.Text = "Метод Рунге-Кутты 2-го порядка";
            this.RK2Choose.UseVisualStyleBackColor = true;
            // 
            // EulerChoose
            // 
            this.EulerChoose.AutoSize = true;
            this.EulerChoose.Location = new System.Drawing.Point(6, 21);
            this.EulerChoose.Name = "EulerChoose";
            this.EulerChoose.Size = new System.Drawing.Size(124, 21);
            this.EulerChoose.TabIndex = 2;
            this.EulerChoose.TabStop = true;
            this.EulerChoose.Text = "Метод Эйлера";
            this.EulerChoose.UseVisualStyleBackColor = true;
            // 
            // txtBox_function
            // 
            this.txtBox_function.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_function.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBox_function.Location = new System.Drawing.Point(377, 81);
            this.txtBox_function.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_function.Name = "txtBox_function";
            this.txtBox_function.Size = new System.Drawing.Size(193, 27);
            this.txtBox_function.TabIndex = 31;
            this.txtBox_function.Text = "Функция";
            this.txtBox_function.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "y\' =";
            // 
            // txtBox_Analytical
            // 
            this.txtBox_Analytical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Analytical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_Analytical.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBox_Analytical.Location = new System.Drawing.Point(377, 145);
            this.txtBox_Analytical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Analytical.Name = "txtBox_Analytical";
            this.txtBox_Analytical.Size = new System.Drawing.Size(193, 27);
            this.txtBox_Analytical.TabIndex = 34;
            this.txtBox_Analytical.Text = "Точное решение";
            this.txtBox_Analytical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "y(x) =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SolveDiffeq
            // 
            this.SolveDiffeq.Location = new System.Drawing.Point(746, 59);
            this.SolveDiffeq.Name = "SolveDiffeq";
            this.SolveDiffeq.Size = new System.Drawing.Size(105, 216);
            this.SolveDiffeq.TabIndex = 47;
            this.SolveDiffeq.Text = "Вычислить решение";
            this.SolveDiffeq.UseVisualStyleBackColor = true;
            this.SolveDiffeq.Click += new System.EventHandler(this.SolveDiffeq_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(307, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Промежуток:";
            // 
            // bDiffeq
            // 
            this.bDiffeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bDiffeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDiffeq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDiffeq.Location = new System.Drawing.Point(503, 187);
            this.bDiffeq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDiffeq.Name = "bDiffeq";
            this.bDiffeq.Size = new System.Drawing.Size(51, 27);
            this.bDiffeq.TabIndex = 49;
            this.bDiffeq.Text = "b";
            this.bDiffeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aDiffeq
            // 
            this.aDiffeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aDiffeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aDiffeq.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aDiffeq.Location = new System.Drawing.Point(446, 187);
            this.aDiffeq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aDiffeq.Name = "aDiffeq";
            this.aDiffeq.Size = new System.Drawing.Size(51, 27);
            this.aDiffeq.TabIndex = 48;
            this.aDiffeq.Text = "a";
            this.aDiffeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step
            // 
            this.step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.step.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.step.Location = new System.Drawing.Point(446, 218);
            this.step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(108, 27);
            this.step.TabIndex = 57;
            this.step.Text = "h";
            this.step.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(307, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Шаг:";
            // 
            // CheckIfNeedErrors
            // 
            this.CheckIfNeedErrors.AutoSize = true;
            this.CheckIfNeedErrors.Location = new System.Drawing.Point(446, 250);
            this.CheckIfNeedErrors.Name = "CheckIfNeedErrors";
            this.CheckIfNeedErrors.Size = new System.Drawing.Size(173, 21);
            this.CheckIfNeedErrors.TabIndex = 55;
            this.CheckIfNeedErrors.Text = "Считать погрешность";
            this.CheckIfNeedErrors.UseVisualStyleBackColor = true;
            // 
            // checkDiffeqIfNeedFile
            // 
            this.checkDiffeqIfNeedFile.AutoSize = true;
            this.checkDiffeqIfNeedFile.Location = new System.Drawing.Point(316, 251);
            this.checkDiffeqIfNeedFile.Name = "checkDiffeqIfNeedFile";
            this.checkDiffeqIfNeedFile.Size = new System.Drawing.Size(122, 21);
            this.checkDiffeqIfNeedFile.TabIndex = 54;
            this.checkDiffeqIfNeedFile.Text = "Вывод в файл";
            this.checkDiffeqIfNeedFile.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(576, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 32);
            this.label5.TabIndex = 58;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(2, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 32);
            this.label4.TabIndex = 59;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 17);
            this.label6.TabIndex = 60;
            this.label6.Text = "Точное решение - это аналитическое решение.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Задайте его, если вы хотите получить погрешность";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(612, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 32);
            this.label9.TabIndex = 61;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(475, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 32);
            this.label10.TabIndex = 62;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(306, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Будет считаться максимальная погрешность";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 17);
            this.label14.TabIndex = 64;
            this.label14.Text = "Численное решение:";
            // 
            // xAnswer
            // 
            this.xAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xAnswer.Location = new System.Drawing.Point(92, 345);
            this.xAnswer.Name = "xAnswer";
            this.xAnswer.Size = new System.Drawing.Size(156, 140);
            this.xAnswer.TabIndex = 65;
            this.xAnswer.Text = "";
            // 
            // yAnswer
            // 
            this.yAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yAnswer.Location = new System.Drawing.Point(356, 342);
            this.yAnswer.Name = "yAnswer";
            this.yAnswer.Size = new System.Drawing.Size(159, 143);
            this.yAnswer.TabIndex = 65;
            this.yAnswer.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(29, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 29);
            this.label12.TabIndex = 66;
            this.label12.Text = "x:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(284, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 29);
            this.label15.TabIndex = 35;
            this.label15.Text = "y(x):";
            this.label15.Click += new System.EventHandler(this.label3_Click);
            // 
            // x0TxtBox
            // 
            this.x0TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x0TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x0TxtBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.x0TxtBox.Location = new System.Drawing.Point(587, 81);
            this.x0TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x0TxtBox.Name = "x0TxtBox";
            this.x0TxtBox.Size = new System.Drawing.Size(51, 27);
            this.x0TxtBox.TabIndex = 67;
            this.x0TxtBox.Text = "x0";
            this.x0TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y0TxtBox
            // 
            this.y0TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.y0TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y0TxtBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.y0TxtBox.Location = new System.Drawing.Point(653, 81);
            this.y0TxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y0TxtBox.Name = "y0TxtBox";
            this.y0TxtBox.Size = new System.Drawing.Size(51, 27);
            this.y0TxtBox.TabIndex = 68;
            this.y0TxtBox.Text = "y0";
            this.y0TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(539, 312);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 70;
            this.label16.Text = "Погрешность:";
            // 
            // resultError
            // 
            this.resultError.Location = new System.Drawing.Point(542, 342);
            this.resultError.Name = "resultError";
            this.resultError.Size = new System.Drawing.Size(169, 22);
            this.resultError.TabIndex = 69;
            // 
            // DiffeqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resultError);
            this.Controls.Add(this.y0TxtBox);
            this.Controls.Add(this.x0TxtBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yAnswer);
            this.Controls.Add(this.xAnswer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.step);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CheckIfNeedErrors);
            this.Controls.Add(this.checkDiffeqIfNeedFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bDiffeq);
            this.Controls.Add(this.aDiffeq);
            this.Controls.Add(this.SolveDiffeq);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Analytical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_function);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DiffeqForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.DiffeqForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RK4Choose;
        private System.Windows.Forms.RadioButton RK3Choose;
        private System.Windows.Forms.RadioButton RK2Choose;
        private System.Windows.Forms.RadioButton EulerChoose;
        private System.Windows.Forms.TextBox txtBox_function;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Analytical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SolveDiffeq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bDiffeq;
        private System.Windows.Forms.TextBox aDiffeq;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CheckIfNeedErrors;
        private System.Windows.Forms.CheckBox checkDiffeqIfNeedFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox xAnswer;
        private System.Windows.Forms.RichTextBox yAnswer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox x0TxtBox;
        private System.Windows.Forms.TextBox y0TxtBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox resultError;
    }
}
