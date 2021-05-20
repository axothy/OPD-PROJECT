namespace InspirationDemo
{
    partial class SLAUForm
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
            this.matrix_A = new System.Windows.Forms.RichTextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vector_b = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SolveSLAU = new System.Windows.Forms.Button();
            this.resultSLAU = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.vector_x0 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rotation = new System.Windows.Forms.RadioButton();
            this.GradDescent = new System.Windows.Forms.RadioButton();
            this.ZeidelGaussChoose = new System.Windows.Forms.RadioButton();
            this.JacobiChoose = new System.Windows.Forms.RadioButton();
            this.GaussChoose = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ariphmeticCNT = new System.Windows.Forms.RichTextBox();
            this.epsBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Решение СЛАУ прямыми методами";
            // 
            // matrix_A
            // 
            this.matrix_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrix_A.Location = new System.Drawing.Point(351, 121);
            this.matrix_A.Name = "matrix_A";
            this.matrix_A.Size = new System.Drawing.Size(382, 27);
            this.matrix_A.TabIndex = 17;
            this.matrix_A.Text = "";
            this.matrix_A.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // N
            // 
            this.N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.N.Location = new System.Drawing.Point(454, 77);
            this.N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(108, 27);
            this.N.TabIndex = 55;
            this.N.Text = "n";
            this.N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(298, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "Размер матрицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 38);
            this.label2.TabIndex = 56;
            this.label2.Text = "А";
            // 
            // vector_b
            // 
            this.vector_b.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vector_b.Location = new System.Drawing.Point(351, 158);
            this.vector_b.Name = "vector_b";
            this.vector_b.Size = new System.Drawing.Size(382, 28);
            this.vector_b.TabIndex = 57;
            this.vector_b.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 38);
            this.label3.TabIndex = 58;
            this.label3.Text = "b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SolveSLAU
            // 
            this.SolveSLAU.Location = new System.Drawing.Point(764, 77);
            this.SolveSLAU.Name = "SolveSLAU";
            this.SolveSLAU.Size = new System.Drawing.Size(119, 139);
            this.SolveSLAU.TabIndex = 60;
            this.SolveSLAU.Text = "Решить";
            this.SolveSLAU.UseVisualStyleBackColor = true;
            this.SolveSLAU.Click += new System.EventHandler(this.SolveIter_Click);
            // 
            // resultSLAU
            // 
            this.resultSLAU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultSLAU.Location = new System.Drawing.Point(22, 350);
            this.resultSLAU.Name = "resultSLAU";
            this.resultSLAU.Size = new System.Drawing.Size(156, 140);
            this.resultSLAU.TabIndex = 79;
            this.resultSLAU.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 78;
            this.label14.Text = "Вектор решений";
            // 
            // vector_x0
            // 
            this.vector_x0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vector_x0.Location = new System.Drawing.Point(351, 192);
            this.vector_x0.Name = "vector_x0";
            this.vector_x0.Size = new System.Drawing.Size(382, 28);
            this.vector_x0.TabIndex = 80;
            this.vector_x0.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 32);
            this.label4.TabIndex = 81;
            this.label4.Text = "x0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rotation);
            this.groupBox1.Controls.Add(this.GradDescent);
            this.groupBox1.Controls.Add(this.ZeidelGaussChoose);
            this.groupBox1.Controls.Add(this.JacobiChoose);
            this.groupBox1.Controls.Add(this.GaussChoose);
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 194);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода";
            // 
            // Rotation
            // 
            this.Rotation.AutoSize = true;
            this.Rotation.Location = new System.Drawing.Point(5, 43);
            this.Rotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(141, 21);
            this.Rotation.TabIndex = 6;
            this.Rotation.TabStop = true;
            this.Rotation.Text = "Метод вращений";
            this.Rotation.UseVisualStyleBackColor = true;
            // 
            // GradDescent
            // 
            this.GradDescent.AutoSize = true;
            this.GradDescent.Location = new System.Drawing.Point(5, 108);
            this.GradDescent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradDescent.Name = "GradDescent";
            this.GradDescent.Size = new System.Drawing.Size(212, 21);
            this.GradDescent.TabIndex = 5;
            this.GradDescent.TabStop = true;
            this.GradDescent.Text = "Метод градиентного спуска";
            this.GradDescent.UseVisualStyleBackColor = true;
            // 
            // ZeidelGaussChoose
            // 
            this.ZeidelGaussChoose.AutoSize = true;
            this.ZeidelGaussChoose.Location = new System.Drawing.Point(5, 87);
            this.ZeidelGaussChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZeidelGaussChoose.Name = "ZeidelGaussChoose";
            this.ZeidelGaussChoose.Size = new System.Drawing.Size(182, 21);
            this.ZeidelGaussChoose.TabIndex = 4;
            this.ZeidelGaussChoose.TabStop = true;
            this.ZeidelGaussChoose.Text = "Метод Зейделя-Гаусса";
            this.ZeidelGaussChoose.UseVisualStyleBackColor = true;
            // 
            // JacobiChoose
            // 
            this.JacobiChoose.AutoSize = true;
            this.JacobiChoose.Location = new System.Drawing.Point(5, 65);
            this.JacobiChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JacobiChoose.Name = "JacobiChoose";
            this.JacobiChoose.Size = new System.Drawing.Size(116, 21);
            this.JacobiChoose.TabIndex = 3;
            this.JacobiChoose.TabStop = true;
            this.JacobiChoose.Text = "Метод Якоби";
            this.JacobiChoose.UseVisualStyleBackColor = true;
            // 
            // GaussChoose
            // 
            this.GaussChoose.AutoSize = true;
            this.GaussChoose.Location = new System.Drawing.Point(5, 21);
            this.GaussChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GaussChoose.Name = "GaussChoose";
            this.GaussChoose.Size = new System.Drawing.Size(120, 21);
            this.GaussChoose.TabIndex = 2;
            this.GaussChoose.TabStop = true;
            this.GaussChoose.Text = "Метод Гаусса";
            this.GaussChoose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 90;
            this.label5.Text = "Число арифм. действий";
            // 
            // ariphmeticCNT
            // 
            this.ariphmeticCNT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ariphmeticCNT.Location = new System.Drawing.Point(206, 465);
            this.ariphmeticCNT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ariphmeticCNT.Name = "ariphmeticCNT";
            this.ariphmeticCNT.Size = new System.Drawing.Size(163, 25);
            this.ariphmeticCNT.TabIndex = 91;
            this.ariphmeticCNT.Text = "";
            // 
            // epsBox
            // 
            this.epsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.epsBox.Location = new System.Drawing.Point(617, 225);
            this.epsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.epsBox.Name = "epsBox";
            this.epsBox.Size = new System.Drawing.Size(116, 27);
            this.epsBox.TabIndex = 92;
            this.epsBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(429, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "Заданная точность:";
            // 
            // SLAUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.epsBox);
            this.Controls.Add(this.ariphmeticCNT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vector_x0);
            this.Controls.Add(this.resultSLAU);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SolveSLAU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vector_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.matrix_A);
            this.Controls.Add(this.label1);
            this.Name = "SLAUForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.SLAUForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox matrix_A;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox vector_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SolveSLAU;
        private System.Windows.Forms.RichTextBox resultSLAU;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox vector_x0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rotation;
        private System.Windows.Forms.RadioButton GradDescent;
        private System.Windows.Forms.RadioButton ZeidelGaussChoose;
        private System.Windows.Forms.RadioButton JacobiChoose;
        private System.Windows.Forms.RadioButton GaussChoose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ariphmeticCNT;
        private System.Windows.Forms.RichTextBox epsBox;
        private System.Windows.Forms.Label label6;
    }
}
