namespace InspirationDemo
{
    partial class CreateMatrix
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
            this.CondChoose = new System.Windows.Forms.RadioButton();
            this.DetChoose = new System.Windows.Forms.RadioButton();
            this.N = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Det = new System.Windows.Forms.TextBox();
            this.Cond = new System.Windows.Forms.TextBox();
            this.CreateNewMatrix = new System.Windows.Forms.Button();
            this.checkIfNeedFile = new System.Windows.Forms.CheckBox();
            this.createdMatrix = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "Создание матрицы с заданными свойствами";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CondChoose);
            this.groupBox1.Controls.Add(this.DetChoose);
            this.groupBox1.Location = new System.Drawing.Point(15, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 84);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Какую матрицу создать?";
            // 
            // CondChoose
            // 
            this.CondChoose.AutoSize = true;
            this.CondChoose.Location = new System.Drawing.Point(6, 48);
            this.CondChoose.Name = "CondChoose";
            this.CondChoose.Size = new System.Drawing.Size(279, 21);
            this.CondChoose.TabIndex = 3;
            this.CondChoose.TabStop = true;
            this.CondChoose.Text = "С заданным числом обусловленности";
            this.CondChoose.UseVisualStyleBackColor = true;
            // 
            // DetChoose
            // 
            this.DetChoose.AutoSize = true;
            this.DetChoose.Location = new System.Drawing.Point(6, 21);
            this.DetChoose.Name = "DetChoose";
            this.DetChoose.Size = new System.Drawing.Size(216, 21);
            this.DetChoose.TabIndex = 2;
            this.DetChoose.TabStop = true;
            this.DetChoose.Text = "С заданным определителем";
            this.DetChoose.UseVisualStyleBackColor = true;
            // 
            // N
            // 
            this.N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.N.Location = new System.Drawing.Point(494, 70);
            this.N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(85, 27);
            this.N.TabIndex = 68;
            this.N.Text = "n";
            this.N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(324, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 67;
            this.label13.Text = "Размер матрицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(324, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Определитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(324, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Число обусл.";
            // 
            // Det
            // 
            this.Det.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Det.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Det.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Det.Location = new System.Drawing.Point(494, 102);
            this.Det.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Det.Name = "Det";
            this.Det.Size = new System.Drawing.Size(85, 27);
            this.Det.TabIndex = 69;
            this.Det.Text = "det";
            this.Det.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cond
            // 
            this.Cond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cond.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cond.Location = new System.Drawing.Point(494, 134);
            this.Cond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cond.Name = "Cond";
            this.Cond.Size = new System.Drawing.Size(85, 27);
            this.Cond.TabIndex = 70;
            this.Cond.Text = "cond";
            this.Cond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateNewMatrix
            // 
            this.CreateNewMatrix.Location = new System.Drawing.Point(608, 70);
            this.CreateNewMatrix.Name = "CreateNewMatrix";
            this.CreateNewMatrix.Size = new System.Drawing.Size(149, 91);
            this.CreateNewMatrix.TabIndex = 71;
            this.CreateNewMatrix.Text = "Создать матрицу";
            this.CreateNewMatrix.UseVisualStyleBackColor = true;
            // 
            // checkIfNeedFile
            // 
            this.checkIfNeedFile.AutoSize = true;
            this.checkIfNeedFile.Location = new System.Drawing.Point(608, 167);
            this.checkIfNeedFile.Name = "checkIfNeedFile";
            this.checkIfNeedFile.Size = new System.Drawing.Size(149, 21);
            this.checkIfNeedFile.TabIndex = 72;
            this.checkIfNeedFile.Text = "Сохранить в файл";
            this.checkIfNeedFile.UseVisualStyleBackColor = true;
            // 
            // createdMatrix
            // 
            this.createdMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdMatrix.Location = new System.Drawing.Point(22, 333);
            this.createdMatrix.Name = "createdMatrix";
            this.createdMatrix.Size = new System.Drawing.Size(156, 140);
            this.createdMatrix.TabIndex = 80;
            this.createdMatrix.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 17);
            this.label14.TabIndex = 81;
            this.label14.Text = "Созданная матрица";
            // 
            // CreateMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.createdMatrix);
            this.Controls.Add(this.checkIfNeedFile);
            this.Controls.Add(this.CreateNewMatrix);
            this.Controls.Add(this.Cond);
            this.Controls.Add(this.Det);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateMatrix";
            this.Size = new System.Drawing.Size(939, 550);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CondChoose;
        private System.Windows.Forms.RadioButton DetChoose;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Det;
        private System.Windows.Forms.TextBox Cond;
        private System.Windows.Forms.Button CreateNewMatrix;
        private System.Windows.Forms.CheckBox checkIfNeedFile;
        private System.Windows.Forms.RichTextBox createdMatrix;
        private System.Windows.Forms.Label label14;
    }
}
