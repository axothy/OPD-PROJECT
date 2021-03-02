namespace InspirationDemo
{
    partial class MPDMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MPDMethod));
            this.panel3 = new System.Windows.Forms.Panel();
            this.operationsMPDTextBox = new System.Windows.Forms.ListBox();
            this.rootMPDTextBox = new System.Windows.Forms.ListBox();
            this.iterMPDTextBox = new System.Windows.Forms.ListBox();
            this.resultMPD = new System.Windows.Forms.ListBox();
            this.SolveMPD = new System.Windows.Forms.Button();
            this.txtBoxMPDeq = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Epsilon_MPDTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.aTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.operationsMPDTextBox);
            this.panel3.Controls.Add(this.rootMPDTextBox);
            this.panel3.Controls.Add(this.iterMPDTextBox);
            this.panel3.Controls.Add(this.resultMPD);
            this.panel3.Controls.Add(this.SolveMPD);
            this.panel3.Controls.Add(this.txtBoxMPDeq);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(23, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 313);
            this.panel3.TabIndex = 15;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // operationsMPDTextBox
            // 
            this.operationsMPDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsMPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsMPDTextBox.ForeColor = System.Drawing.Color.Black;
            this.operationsMPDTextBox.FormattingEnabled = true;
            this.operationsMPDTextBox.ItemHeight = 20;
            this.operationsMPDTextBox.Location = new System.Drawing.Point(27, 279);
            this.operationsMPDTextBox.Name = "operationsMPDTextBox";
            this.operationsMPDTextBox.Size = new System.Drawing.Size(215, 20);
            this.operationsMPDTextBox.TabIndex = 24;
            this.operationsMPDTextBox.TabStop = false;
            // 
            // rootMPDTextBox
            // 
            this.rootMPDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootMPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootMPDTextBox.ForeColor = System.Drawing.Color.Black;
            this.rootMPDTextBox.FormattingEnabled = true;
            this.rootMPDTextBox.ItemHeight = 20;
            this.rootMPDTextBox.Location = new System.Drawing.Point(27, 253);
            this.rootMPDTextBox.Name = "rootMPDTextBox";
            this.rootMPDTextBox.Size = new System.Drawing.Size(215, 20);
            this.rootMPDTextBox.TabIndex = 24;
            this.rootMPDTextBox.TabStop = false;
            // 
            // iterMPDTextBox
            // 
            this.iterMPDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterMPDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterMPDTextBox.ForeColor = System.Drawing.Color.Black;
            this.iterMPDTextBox.FormattingEnabled = true;
            this.iterMPDTextBox.ItemHeight = 20;
            this.iterMPDTextBox.Location = new System.Drawing.Point(27, 227);
            this.iterMPDTextBox.Name = "iterMPDTextBox";
            this.iterMPDTextBox.Size = new System.Drawing.Size(215, 20);
            this.iterMPDTextBox.TabIndex = 24;
            this.iterMPDTextBox.TabStop = false;
            // 
            // resultMPD
            // 
            this.resultMPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultMPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultMPD.ForeColor = System.Drawing.Color.Black;
            this.resultMPD.FormattingEnabled = true;
            this.resultMPD.ItemHeight = 20;
            this.resultMPD.Location = new System.Drawing.Point(27, 87);
            this.resultMPD.Name = "resultMPD";
            this.resultMPD.Size = new System.Drawing.Size(181, 100);
            this.resultMPD.TabIndex = 23;
            this.resultMPD.TabStop = false;
            // 
            // SolveMPD
            // 
            this.SolveMPD.BackColor = System.Drawing.SystemColors.Control;
            this.SolveMPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveMPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveMPD.ForeColor = System.Drawing.Color.Black;
            this.SolveMPD.Location = new System.Drawing.Point(291, 217);
            this.SolveMPD.Name = "SolveMPD";
            this.SolveMPD.Size = new System.Drawing.Size(186, 30);
            this.SolveMPD.TabIndex = 6;
            this.SolveMPD.Text = "Решить";
            this.SolveMPD.UseVisualStyleBackColor = false;
            // 
            // txtBoxMPDeq
            // 
            this.txtBoxMPDeq.AcceptsReturn = false;
            this.txtBoxMPDeq.AcceptsTab = false;
            this.txtBoxMPDeq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxMPDeq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxMPDeq.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxMPDeq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxMPDeq.BackgroundImage")));
            this.txtBoxMPDeq.BorderColorActive = System.Drawing.Color.Black;
            this.txtBoxMPDeq.BorderColorDisabled = System.Drawing.Color.White;
            this.txtBoxMPDeq.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxMPDeq.BorderColorIdle = System.Drawing.Color.Black;
            this.txtBoxMPDeq.BorderRadius = 18;
            this.txtBoxMPDeq.BorderThickness = 1;
            this.txtBoxMPDeq.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxMPDeq.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMPDeq.DefaultText = "";
            this.txtBoxMPDeq.FillColor = System.Drawing.Color.White;
            this.txtBoxMPDeq.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMPDeq.HideSelection = true;
            this.txtBoxMPDeq.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxMPDeq.IconLeft")));
            this.txtBoxMPDeq.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMPDeq.IconPadding = 10;
            this.txtBoxMPDeq.IconRight = null;
            this.txtBoxMPDeq.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxMPDeq.Location = new System.Drawing.Point(17, 23);
            this.txtBoxMPDeq.MaxLength = 32767;
            this.txtBoxMPDeq.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtBoxMPDeq.Modified = false;
            this.txtBoxMPDeq.Name = "txtBoxMPDeq";
            this.txtBoxMPDeq.PasswordChar = '\0';
            this.txtBoxMPDeq.ReadOnly = false;
            this.txtBoxMPDeq.SelectedText = "";
            this.txtBoxMPDeq.SelectionLength = 0;
            this.txtBoxMPDeq.SelectionStart = 0;
            this.txtBoxMPDeq.ShortcutsEnabled = true;
            this.txtBoxMPDeq.Size = new System.Drawing.Size(240, 35);
            this.txtBoxMPDeq.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtBoxMPDeq.TabIndex = 1;
            this.txtBoxMPDeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxMPDeq.TextMarginLeft = 5;
            this.txtBoxMPDeq.TextPlaceholder = "Функция";
            this.txtBoxMPDeq.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.Epsilon_MPDTextBox);
            this.panel4.Controls.Add(this.bTextBox);
            this.panel4.Controls.Add(this.aTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(290, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 179);
            this.panel4.TabIndex = 0;
            // 
            // Epsilon_MPDTextBox
            // 
            this.Epsilon_MPDTextBox.AcceptsReturn = false;
            this.Epsilon_MPDTextBox.AcceptsTab = false;
            this.Epsilon_MPDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Epsilon_MPDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Epsilon_MPDTextBox.BackColor = System.Drawing.Color.Transparent;
            this.Epsilon_MPDTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Epsilon_MPDTextBox.BackgroundImage")));
            this.Epsilon_MPDTextBox.BorderColorActive = System.Drawing.Color.White;
            this.Epsilon_MPDTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.Epsilon_MPDTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.Epsilon_MPDTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.Epsilon_MPDTextBox.BorderRadius = 18;
            this.Epsilon_MPDTextBox.BorderThickness = 1;
            this.Epsilon_MPDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Epsilon_MPDTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Epsilon_MPDTextBox.DefaultText = "";
            this.Epsilon_MPDTextBox.FillColor = System.Drawing.Color.White;
            this.Epsilon_MPDTextBox.ForeColor = System.Drawing.Color.Black;
            this.Epsilon_MPDTextBox.HideSelection = true;
            this.Epsilon_MPDTextBox.IconLeft = null;
            this.Epsilon_MPDTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Epsilon_MPDTextBox.IconPadding = 10;
            this.Epsilon_MPDTextBox.IconRight = null;
            this.Epsilon_MPDTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Epsilon_MPDTextBox.Location = new System.Drawing.Point(18, 130);
            this.Epsilon_MPDTextBox.MaxLength = 32767;
            this.Epsilon_MPDTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.Epsilon_MPDTextBox.Modified = false;
            this.Epsilon_MPDTextBox.Name = "Epsilon_MPDTextBox";
            this.Epsilon_MPDTextBox.PasswordChar = '\0';
            this.Epsilon_MPDTextBox.ReadOnly = false;
            this.Epsilon_MPDTextBox.SelectedText = "";
            this.Epsilon_MPDTextBox.SelectionLength = 0;
            this.Epsilon_MPDTextBox.SelectionStart = 0;
            this.Epsilon_MPDTextBox.ShortcutsEnabled = true;
            this.Epsilon_MPDTextBox.Size = new System.Drawing.Size(100, 35);
            this.Epsilon_MPDTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.Epsilon_MPDTextBox.TabIndex = 5;
            this.Epsilon_MPDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Epsilon_MPDTextBox.TextMarginLeft = 5;
            this.Epsilon_MPDTextBox.TextPlaceholder = "Точность";
            this.Epsilon_MPDTextBox.UseSystemPasswordChar = false;
            // 
            // bTextBox
            // 
            this.bTextBox.AcceptsReturn = false;
            this.bTextBox.AcceptsTab = false;
            this.bTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bTextBox.BackColor = System.Drawing.Color.Transparent;
            this.bTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bTextBox.BackgroundImage")));
            this.bTextBox.BorderColorActive = System.Drawing.Color.White;
            this.bTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.bTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.bTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.bTextBox.BorderRadius = 18;
            this.bTextBox.BorderThickness = 1;
            this.bTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBox.DefaultText = "";
            this.bTextBox.FillColor = System.Drawing.Color.White;
            this.bTextBox.ForeColor = System.Drawing.Color.Black;
            this.bTextBox.HideSelection = true;
            this.bTextBox.IconLeft = null;
            this.bTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bTextBox.IconPadding = 10;
            this.bTextBox.IconRight = null;
            this.bTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bTextBox.Location = new System.Drawing.Point(18, 89);
            this.bTextBox.MaxLength = 32767;
            this.bTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.bTextBox.Modified = false;
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.PasswordChar = '\0';
            this.bTextBox.ReadOnly = false;
            this.bTextBox.SelectedText = "";
            this.bTextBox.SelectionLength = 0;
            this.bTextBox.SelectionStart = 0;
            this.bTextBox.ShortcutsEnabled = true;
            this.bTextBox.Size = new System.Drawing.Size(100, 35);
            this.bTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bTextBox.TabIndex = 5;
            this.bTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bTextBox.TextMarginLeft = 5;
            this.bTextBox.TextPlaceholder = "b";
            this.bTextBox.UseSystemPasswordChar = false;
            // 
            // aTextBox
            // 
            this.aTextBox.AcceptsReturn = false;
            this.aTextBox.AcceptsTab = false;
            this.aTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.aTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.aTextBox.BackColor = System.Drawing.Color.Transparent;
            this.aTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aTextBox.BackgroundImage")));
            this.aTextBox.BorderColorActive = System.Drawing.Color.White;
            this.aTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.aTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.aTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.aTextBox.BorderRadius = 18;
            this.aTextBox.BorderThickness = 1;
            this.aTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.aTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTextBox.DefaultText = "";
            this.aTextBox.FillColor = System.Drawing.Color.White;
            this.aTextBox.ForeColor = System.Drawing.Color.Black;
            this.aTextBox.HideSelection = true;
            this.aTextBox.IconLeft = null;
            this.aTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.aTextBox.IconPadding = 10;
            this.aTextBox.IconRight = null;
            this.aTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.aTextBox.Location = new System.Drawing.Point(18, 48);
            this.aTextBox.MaxLength = 32767;
            this.aTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.aTextBox.Modified = false;
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.PasswordChar = '\0';
            this.aTextBox.ReadOnly = false;
            this.aTextBox.SelectedText = "";
            this.aTextBox.SelectionLength = 0;
            this.aTextBox.SelectionStart = 0;
            this.aTextBox.ShortcutsEnabled = true;
            this.aTextBox.Size = new System.Drawing.Size(100, 35);
            this.aTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.aTextBox.TabIndex = 5;
            this.aTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aTextBox.TextMarginLeft = 5;
            this.aTextBox.TextPlaceholder = "a";
            this.aTextBox.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Начальные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "на заданном интервале. Идея метода: деление отрезка пополам и проверка, на каком";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(576, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Самый простой, неприхотливый метод, гаранитрующий нахождение корня уравнения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Метод половинного деления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "отрезке дальше производить деления с помощью теоремы Больцано-Коши.";
            // 
            // MPDMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MPDMethod";
            this.Size = new System.Drawing.Size(745, 549);
            this.Load += new System.EventHandler(this.MPDMethod_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox operationsMPDTextBox;
        private System.Windows.Forms.ListBox rootMPDTextBox;
        private System.Windows.Forms.ListBox iterMPDTextBox;
        private System.Windows.Forms.ListBox resultMPD;
        private System.Windows.Forms.Button SolveMPD;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtBoxMPDeq;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Epsilon_MPDTextBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bTextBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox aTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
