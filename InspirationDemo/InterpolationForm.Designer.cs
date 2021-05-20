namespace InspirationDemo
{
    partial class InterpolationForm
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
            this.HermitChoose = new System.Windows.Forms.RadioButton();
            this.NewtonChoose = new System.Windows.Forms.RadioButton();
            this.LagrangeChoose = new System.Windows.Forms.RadioButton();
            this.txtBox_function = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChebyshevGridChoose = new System.Windows.Forms.RadioButton();
            this.StandartGridChoose = new System.Windows.Forms.RadioButton();
            this.Interpolate = new System.Windows.Forms.Button();
            this.nTxtBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bInterpolate = new System.Windows.Forms.TextBox();
            this.aInterpolate = new System.Windows.Forms.TextBox();
            this.CheckIfNeedErrors = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.resultError = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yAnswer = new System.Windows.Forms.RichTextBox();
            this.xAnswer = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Интерполяционные полиномы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HermitChoose);
            this.groupBox1.Controls.Add(this.NewtonChoose);
            this.groupBox1.Controls.Add(this.LagrangeChoose);
            this.groupBox1.Location = new System.Drawing.Point(22, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 116);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор полинома";
            // 
            // HermitChoose
            // 
            this.HermitChoose.AutoSize = true;
            this.HermitChoose.Location = new System.Drawing.Point(6, 75);
            this.HermitChoose.Name = "HermitChoose";
            this.HermitChoose.Size = new System.Drawing.Size(141, 21);
            this.HermitChoose.TabIndex = 4;
            this.HermitChoose.TabStop = true;
            this.HermitChoose.Text = "Полином Эрмита";
            this.HermitChoose.UseVisualStyleBackColor = true;
            // 
            // NewtonChoose
            // 
            this.NewtonChoose.AutoSize = true;
            this.NewtonChoose.Location = new System.Drawing.Point(6, 48);
            this.NewtonChoose.Name = "NewtonChoose";
            this.NewtonChoose.Size = new System.Drawing.Size(150, 21);
            this.NewtonChoose.TabIndex = 3;
            this.NewtonChoose.TabStop = true;
            this.NewtonChoose.Text = "Полином Ньютона";
            this.NewtonChoose.UseVisualStyleBackColor = true;
            // 
            // LagrangeChoose
            // 
            this.LagrangeChoose.AutoSize = true;
            this.LagrangeChoose.Location = new System.Drawing.Point(6, 21);
            this.LagrangeChoose.Name = "LagrangeChoose";
            this.LagrangeChoose.Size = new System.Drawing.Size(156, 21);
            this.LagrangeChoose.TabIndex = 2;
            this.LagrangeChoose.TabStop = true;
            this.LagrangeChoose.Text = "Полином Лагранжа";
            this.LagrangeChoose.UseVisualStyleBackColor = true;
            // 
            // txtBox_function
            // 
            this.txtBox_function.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_function.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBox_function.Location = new System.Drawing.Point(261, 76);
            this.txtBox_function.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_function.Name = "txtBox_function";
            this.txtBox_function.Size = new System.Drawing.Size(193, 27);
            this.txtBox_function.TabIndex = 32;
            this.txtBox_function.Text = "Функция";
            this.txtBox_function.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(460, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 32);
            this.label5.TabIndex = 59;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Это та функция, узлы которой вы интерполируете";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(2, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 32);
            this.label4.TabIndex = 61;
            this.label4.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChebyshevGridChoose);
            this.groupBox2.Controls.Add(this.StandartGridChoose);
            this.groupBox2.Location = new System.Drawing.Point(597, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 116);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор сетки";
            // 
            // ChebyshevGridChoose
            // 
            this.ChebyshevGridChoose.AutoSize = true;
            this.ChebyshevGridChoose.Location = new System.Drawing.Point(6, 48);
            this.ChebyshevGridChoose.Name = "ChebyshevGridChoose";
            this.ChebyshevGridChoose.Size = new System.Drawing.Size(121, 21);
            this.ChebyshevGridChoose.TabIndex = 3;
            this.ChebyshevGridChoose.TabStop = true;
            this.ChebyshevGridChoose.Text = "Чебышевская";
            this.ChebyshevGridChoose.UseVisualStyleBackColor = true;
            // 
            // StandartGridChoose
            // 
            this.StandartGridChoose.AutoSize = true;
            this.StandartGridChoose.Location = new System.Drawing.Point(6, 21);
            this.StandartGridChoose.Name = "StandartGridChoose";
            this.StandartGridChoose.Size = new System.Drawing.Size(118, 21);
            this.StandartGridChoose.TabIndex = 2;
            this.StandartGridChoose.TabStop = true;
            this.StandartGridChoose.Text = "Равномерная";
            this.StandartGridChoose.UseVisualStyleBackColor = true;
            // 
            // Interpolate
            // 
            this.Interpolate.Location = new System.Drawing.Point(777, 59);
            this.Interpolate.Name = "Interpolate";
            this.Interpolate.Size = new System.Drawing.Size(105, 133);
            this.Interpolate.TabIndex = 64;
            this.Interpolate.Text = "Построить полином";
            this.Interpolate.UseVisualStyleBackColor = true;
            this.Interpolate.Click += new System.EventHandler(this.Interpolate_Click);
            // 
            // nTxtBox
            // 
            this.nTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nTxtBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nTxtBox.Location = new System.Drawing.Point(396, 150);
            this.nTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nTxtBox.Name = "nTxtBox";
            this.nTxtBox.Size = new System.Drawing.Size(108, 27);
            this.nTxtBox.TabIndex = 69;
            this.nTxtBox.Text = "n";
            this.nTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(257, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 68;
            this.label13.Text = "Кол-во узлов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(257, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Промежуток:";
            // 
            // bInterpolate
            // 
            this.bInterpolate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bInterpolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bInterpolate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bInterpolate.Location = new System.Drawing.Point(453, 119);
            this.bInterpolate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bInterpolate.Name = "bInterpolate";
            this.bInterpolate.Size = new System.Drawing.Size(51, 27);
            this.bInterpolate.TabIndex = 66;
            this.bInterpolate.Text = "b";
            this.bInterpolate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aInterpolate
            // 
            this.aInterpolate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aInterpolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aInterpolate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aInterpolate.Location = new System.Drawing.Point(396, 119);
            this.aInterpolate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aInterpolate.Name = "aInterpolate";
            this.aInterpolate.Size = new System.Drawing.Size(51, 27);
            this.aInterpolate.TabIndex = 65;
            this.aInterpolate.Text = "a";
            this.aInterpolate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckIfNeedErrors
            // 
            this.CheckIfNeedErrors.AutoSize = true;
            this.CheckIfNeedErrors.Location = new System.Drawing.Point(396, 188);
            this.CheckIfNeedErrors.Name = "CheckIfNeedErrors";
            this.CheckIfNeedErrors.Size = new System.Drawing.Size(173, 21);
            this.CheckIfNeedErrors.TabIndex = 71;
            this.CheckIfNeedErrors.Text = "Считать погрешность";
            this.CheckIfNeedErrors.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(553, 312);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 79;
            this.label16.Text = "Погрешность:";
            // 
            // resultError
            // 
            this.resultError.Location = new System.Drawing.Point(556, 342);
            this.resultError.Name = "resultError";
            this.resultError.Size = new System.Drawing.Size(169, 22);
            this.resultError.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(30, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 29);
            this.label12.TabIndex = 77;
            this.label12.Text = "x:";
            // 
            // yAnswer
            // 
            this.yAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yAnswer.Location = new System.Drawing.Point(357, 342);
            this.yAnswer.Name = "yAnswer";
            this.yAnswer.Size = new System.Drawing.Size(180, 143);
            this.yAnswer.TabIndex = 75;
            this.yAnswer.Text = "";
            // 
            // xAnswer
            // 
            this.xAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xAnswer.Location = new System.Drawing.Point(93, 345);
            this.xAnswer.Name = "xAnswer";
            this.xAnswer.Size = new System.Drawing.Size(156, 140);
            this.xAnswer.TabIndex = 76;
            this.xAnswer.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 17);
            this.label14.TabIndex = 74;
            this.label14.Text = "Значения полинома:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(285, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 29);
            this.label15.TabIndex = 73;
            this.label15.Text = "y(x):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(565, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 32);
            this.label9.TabIndex = 80;
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
            this.label10.TabIndex = 81;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 503);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 17);
            this.label11.TabIndex = 82;
            this.label11.Text = "Будет считаться максимальная ошибка";
            // 
            // InterpolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resultError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yAnswer);
            this.Controls.Add(this.xAnswer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CheckIfNeedErrors);
            this.Controls.Add(this.nTxtBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bInterpolate);
            this.Controls.Add(this.aInterpolate);
            this.Controls.Add(this.Interpolate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_function);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "InterpolationForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.InterpolationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HermitChoose;
        private System.Windows.Forms.RadioButton NewtonChoose;
        private System.Windows.Forms.RadioButton LagrangeChoose;
        private System.Windows.Forms.TextBox txtBox_function;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ChebyshevGridChoose;
        private System.Windows.Forms.RadioButton StandartGridChoose;
        private System.Windows.Forms.Button Interpolate;
        private System.Windows.Forms.TextBox nTxtBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bInterpolate;
        private System.Windows.Forms.TextBox aInterpolate;
        private System.Windows.Forms.CheckBox CheckIfNeedErrors;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox resultError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox yAnswer;
        private System.Windows.Forms.RichTextBox xAnswer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
