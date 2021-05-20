namespace InspirationDemo
{
    partial class IntegralsForm
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
            this.SimpsonChoose = new System.Windows.Forms.RadioButton();
            this.TrapezoidalChoose = new System.Windows.Forms.RadioButton();
            this.MiddleChoose = new System.Windows.Forms.RadioButton();
            this.RightChoose = new System.Windows.Forms.RadioButton();
            this.LeftChoose = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_function = new System.Windows.Forms.TextBox();
            this.txtBox_F = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bIntergalTextBox = new System.Windows.Forms.TextBox();
            this.aIntegralTextBox = new System.Windows.Forms.TextBox();
            this.CheckIfNeedErrors = new System.Windows.Forms.CheckBox();
            this.checkIntegralIfNeedFile = new System.Windows.Forms.CheckBox();
            this.SolveIntegral = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NumberOfNodestextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.resultError = new System.Windows.Forms.TextBox();
            this.resultIntegral = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Численное интегрирование";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SimpsonChoose);
            this.groupBox1.Controls.Add(this.TrapezoidalChoose);
            this.groupBox1.Controls.Add(this.MiddleChoose);
            this.groupBox1.Controls.Add(this.RightChoose);
            this.groupBox1.Controls.Add(this.LeftChoose);
            this.groupBox1.Location = new System.Drawing.Point(22, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SimpsonChoose
            // 
            this.SimpsonChoose.AutoSize = true;
            this.SimpsonChoose.Location = new System.Drawing.Point(6, 129);
            this.SimpsonChoose.Name = "SimpsonChoose";
            this.SimpsonChoose.Size = new System.Drawing.Size(140, 21);
            this.SimpsonChoose.TabIndex = 6;
            this.SimpsonChoose.TabStop = true;
            this.SimpsonChoose.Text = "Метод Симпсона";
            this.SimpsonChoose.UseVisualStyleBackColor = true;
            // 
            // TrapezoidalChoose
            // 
            this.TrapezoidalChoose.AutoSize = true;
            this.TrapezoidalChoose.Location = new System.Drawing.Point(6, 102);
            this.TrapezoidalChoose.Name = "TrapezoidalChoose";
            this.TrapezoidalChoose.Size = new System.Drawing.Size(138, 21);
            this.TrapezoidalChoose.TabIndex = 5;
            this.TrapezoidalChoose.TabStop = true;
            this.TrapezoidalChoose.Text = "Метод трапеций";
            this.TrapezoidalChoose.UseVisualStyleBackColor = true;
            this.TrapezoidalChoose.CheckedChanged += new System.EventHandler(this.TrapezoidalChoose_CheckedChanged);
            // 
            // MiddleChoose
            // 
            this.MiddleChoose.AutoSize = true;
            this.MiddleChoose.Location = new System.Drawing.Point(6, 75);
            this.MiddleChoose.Name = "MiddleChoose";
            this.MiddleChoose.Size = new System.Drawing.Size(246, 21);
            this.MiddleChoose.TabIndex = 4;
            this.MiddleChoose.TabStop = true;
            this.MiddleChoose.Text = "Метод средних прямоугольников";
            this.MiddleChoose.UseVisualStyleBackColor = true;
            // 
            // RightChoose
            // 
            this.RightChoose.AutoSize = true;
            this.RightChoose.Location = new System.Drawing.Point(6, 48);
            this.RightChoose.Name = "RightChoose";
            this.RightChoose.Size = new System.Drawing.Size(240, 21);
            this.RightChoose.TabIndex = 3;
            this.RightChoose.TabStop = true;
            this.RightChoose.Text = "Метод правых прямоугольников";
            this.RightChoose.UseVisualStyleBackColor = true;
            // 
            // LeftChoose
            // 
            this.LeftChoose.AutoSize = true;
            this.LeftChoose.Location = new System.Drawing.Point(6, 21);
            this.LeftChoose.Name = "LeftChoose";
            this.LeftChoose.Size = new System.Drawing.Size(232, 21);
            this.LeftChoose.TabIndex = 2;
            this.LeftChoose.TabStop = true;
            this.LeftChoose.Text = "Метод левых прямоугольников";
            this.LeftChoose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(537, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "dx";
            // 
            // txtBox_function
            // 
            this.txtBox_function.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_function.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBox_function.Location = new System.Drawing.Point(344, 81);
            this.txtBox_function.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_function.Name = "txtBox_function";
            this.txtBox_function.Size = new System.Drawing.Size(193, 27);
            this.txtBox_function.TabIndex = 30;
            this.txtBox_function.Text = "Функция";
            this.txtBox_function.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_F
            // 
            this.txtBox_F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_F.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBox_F.Location = new System.Drawing.Point(344, 142);
            this.txtBox_F.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_F.Name = "txtBox_F";
            this.txtBox_F.Size = new System.Drawing.Size(193, 27);
            this.txtBox_F.TabIndex = 33;
            this.txtBox_F.Text = "Первообразная";
            this.txtBox_F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(537, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "+ C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(316, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(305, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Промежуток:";
            // 
            // bIntergalTextBox
            // 
            this.bIntergalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bIntergalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bIntergalTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bIntergalTextBox.Location = new System.Drawing.Point(501, 186);
            this.bIntergalTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bIntergalTextBox.Name = "bIntergalTextBox";
            this.bIntergalTextBox.Size = new System.Drawing.Size(51, 27);
            this.bIntergalTextBox.TabIndex = 38;
            this.bIntergalTextBox.Text = "b";
            this.bIntergalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aIntegralTextBox
            // 
            this.aIntegralTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aIntegralTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aIntegralTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aIntegralTextBox.Location = new System.Drawing.Point(444, 186);
            this.aIntegralTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aIntegralTextBox.Name = "aIntegralTextBox";
            this.aIntegralTextBox.Size = new System.Drawing.Size(51, 27);
            this.aIntegralTextBox.TabIndex = 37;
            this.aIntegralTextBox.Text = "a";
            this.aIntegralTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckIfNeedErrors
            // 
            this.CheckIfNeedErrors.AutoSize = true;
            this.CheckIfNeedErrors.Location = new System.Drawing.Point(444, 250);
            this.CheckIfNeedErrors.Name = "CheckIfNeedErrors";
            this.CheckIfNeedErrors.Size = new System.Drawing.Size(173, 21);
            this.CheckIfNeedErrors.TabIndex = 42;
            this.CheckIfNeedErrors.Text = "Считать погрешность";
            this.CheckIfNeedErrors.UseVisualStyleBackColor = true;
            // 
            // checkIntegralIfNeedFile
            // 
            this.checkIntegralIfNeedFile.AutoSize = true;
            this.checkIntegralIfNeedFile.Location = new System.Drawing.Point(314, 251);
            this.checkIntegralIfNeedFile.Name = "checkIntegralIfNeedFile";
            this.checkIntegralIfNeedFile.Size = new System.Drawing.Size(122, 21);
            this.checkIntegralIfNeedFile.TabIndex = 41;
            this.checkIntegralIfNeedFile.Text = "Вывод в файл";
            this.checkIntegralIfNeedFile.UseVisualStyleBackColor = true;
            // 
            // SolveIntegral
            // 
            this.SolveIntegral.Location = new System.Drawing.Point(649, 59);
            this.SolveIntegral.Name = "SolveIntegral";
            this.SolveIntegral.Size = new System.Drawing.Size(105, 216);
            this.SolveIntegral.TabIndex = 44;
            this.SolveIntegral.Text = "Вычислить интеграл";
            this.SolveIntegral.UseVisualStyleBackColor = true;
            this.SolveIntegral.Click += new System.EventHandler(this.SolveIntegral_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Это нужно только для подсчета погрешности (сравнения).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Первообразную задаете в аналитическом выражении.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(2, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(305, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Кол-во узлов:";
            // 
            // NumberOfNodestextBox
            // 
            this.NumberOfNodestextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberOfNodestextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfNodestextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NumberOfNodestextBox.Location = new System.Drawing.Point(444, 218);
            this.NumberOfNodestextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberOfNodestextBox.Name = "NumberOfNodestextBox";
            this.NumberOfNodestextBox.Size = new System.Drawing.Size(108, 27);
            this.NumberOfNodestextBox.TabIndex = 53;
            this.NumberOfNodestextBox.Text = "n";
            this.NumberOfNodestextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfNodestextBox.TextChanged += new System.EventHandler(this.NumberOfNodestextBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 424);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Погрешность:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "Вычисленный интеграл:";
            // 
            // resultError
            // 
            this.resultError.Location = new System.Drawing.Point(19, 444);
            this.resultError.Name = "resultError";
            this.resultError.Size = new System.Drawing.Size(169, 22);
            this.resultError.TabIndex = 60;
            // 
            // resultIntegral
            // 
            this.resultIntegral.Location = new System.Drawing.Point(19, 387);
            this.resultIntegral.Name = "resultIntegral";
            this.resultIntegral.Size = new System.Drawing.Size(169, 22);
            this.resultIntegral.TabIndex = 59;
            this.resultIntegral.TextChanged += new System.EventHandler(this.resultIntegral_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InspirationDemo.Properties.Resources.kisspng_integral_symbol_mathematics_calculus_mathematician_violin_5ac7a3dd564830_2587197915230330533534;
            this.pictureBox1.Location = new System.Drawing.Point(305, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Будет считаться и фактическая погрешность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(475, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 32);
            this.label9.TabIndex = 51;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 48;
            // 
            // IntegralsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.resultError);
            this.Controls.Add(this.resultIntegral);
            this.Controls.Add(this.NumberOfNodestextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SolveIntegral);
            this.Controls.Add(this.CheckIfNeedErrors);
            this.Controls.Add(this.checkIntegralIfNeedFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bIntergalTextBox);
            this.Controls.Add(this.aIntegralTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_F);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_function);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "IntegralsForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.IntegralsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SimpsonChoose;
        private System.Windows.Forms.RadioButton TrapezoidalChoose;
        private System.Windows.Forms.RadioButton MiddleChoose;
        private System.Windows.Forms.RadioButton RightChoose;
        private System.Windows.Forms.RadioButton LeftChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_function;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_F;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bIntergalTextBox;
        private System.Windows.Forms.TextBox aIntegralTextBox;
        private System.Windows.Forms.CheckBox CheckIfNeedErrors;
        private System.Windows.Forms.CheckBox checkIntegralIfNeedFile;
        private System.Windows.Forms.Button SolveIntegral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NumberOfNodestextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox resultError;
        private System.Windows.Forms.TextBox resultIntegral;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}
