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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecantMethod));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuLabel23 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resultSecant = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.iterSecantTextBox = new System.Windows.Forms.ListBox();
            this.rootSecantTextBox = new System.Windows.Forms.ListBox();
            this.operationsSecantTextBox = new System.Windows.Forms.ListBox();
            this.txtBoxSecant_eq = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.EpsilonSecantTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.x1SecantTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.x0SecantTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
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
            this.label1.TabIndex = 9;
            this.label1.Text = "Метод секущих";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Это некая модификация метода Ньютона, заключающаяся в том, что производная ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "в итерационной формуле заменена на секущую. ";
            // 
            // bunifuLabel23
            // 
            this.bunifuLabel23.AutoEllipsis = false;
            this.bunifuLabel23.CursorType = null;
            this.bunifuLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel23.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel23.Location = new System.Drawing.Point(21, 13);
            this.bunifuLabel23.Name = "bunifuLabel23";
            this.bunifuLabel23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel23.Size = new System.Drawing.Size(70, 20);
            this.bunifuLabel23.TabIndex = 3;
            this.bunifuLabel23.Text = "Функция";
            this.bunifuLabel23.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.operationsSecantTextBox);
            this.panel3.Controls.Add(this.rootSecantTextBox);
            this.panel3.Controls.Add(this.iterSecantTextBox);
            this.panel3.Controls.Add(this.resultSecant);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.txtBoxSecant_eq);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(19, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 313);
            this.panel3.TabIndex = 11;
            // 
            // resultSecant
            // 
            this.resultSecant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultSecant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultSecant.ForeColor = System.Drawing.Color.Black;
            this.resultSecant.FormattingEnabled = true;
            this.resultSecant.ItemHeight = 20;
            this.resultSecant.Location = new System.Drawing.Point(27, 87);
            this.resultSecant.Name = "resultSecant";
            this.resultSecant.Size = new System.Drawing.Size(181, 100);
            this.resultSecant.TabIndex = 23;
            this.resultSecant.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(291, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.EpsilonSecantTextBox);
            this.panel4.Controls.Add(this.x1SecantTextBox);
            this.panel4.Controls.Add(this.x0SecantTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(290, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 179);
            this.panel4.TabIndex = 0;
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
            // iterSecantTextBox
            // 
            this.iterSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iterSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.iterSecantTextBox.FormattingEnabled = true;
            this.iterSecantTextBox.ItemHeight = 20;
            this.iterSecantTextBox.Location = new System.Drawing.Point(27, 227);
            this.iterSecantTextBox.Name = "iterSecantTextBox";
            this.iterSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.iterSecantTextBox.TabIndex = 24;
            this.iterSecantTextBox.TabStop = false;
            // 
            // rootSecantTextBox
            // 
            this.rootSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rootSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rootSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.rootSecantTextBox.FormattingEnabled = true;
            this.rootSecantTextBox.ItemHeight = 20;
            this.rootSecantTextBox.Location = new System.Drawing.Point(27, 253);
            this.rootSecantTextBox.Name = "rootSecantTextBox";
            this.rootSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.rootSecantTextBox.TabIndex = 24;
            this.rootSecantTextBox.TabStop = false;
            // 
            // operationsSecantTextBox
            // 
            this.operationsSecantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.operationsSecantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.operationsSecantTextBox.FormattingEnabled = true;
            this.operationsSecantTextBox.ItemHeight = 20;
            this.operationsSecantTextBox.Location = new System.Drawing.Point(27, 279);
            this.operationsSecantTextBox.Name = "operationsSecantTextBox";
            this.operationsSecantTextBox.Size = new System.Drawing.Size(215, 20);
            this.operationsSecantTextBox.TabIndex = 24;
            this.operationsSecantTextBox.TabStop = false;
            // 
            // txtBoxSecant_eq
            // 
            this.txtBoxSecant_eq.AcceptsReturn = false;
            this.txtBoxSecant_eq.AcceptsTab = false;
            this.txtBoxSecant_eq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBoxSecant_eq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBoxSecant_eq.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSecant_eq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBoxSecant_eq.BackgroundImage")));
            this.txtBoxSecant_eq.BorderColorActive = System.Drawing.Color.Black;
            this.txtBoxSecant_eq.BorderColorDisabled = System.Drawing.Color.White;
            this.txtBoxSecant_eq.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.txtBoxSecant_eq.BorderColorIdle = System.Drawing.Color.Black;
            this.txtBoxSecant_eq.BorderRadius = 18;
            this.txtBoxSecant_eq.BorderThickness = 1;
            this.txtBoxSecant_eq.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxSecant_eq.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSecant_eq.DefaultText = "";
            this.txtBoxSecant_eq.FillColor = System.Drawing.Color.White;
            this.txtBoxSecant_eq.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSecant_eq.HideSelection = true;
            this.txtBoxSecant_eq.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxSecant_eq.IconLeft")));
            this.txtBoxSecant_eq.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSecant_eq.IconPadding = 10;
            this.txtBoxSecant_eq.IconRight = null;
            this.txtBoxSecant_eq.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtBoxSecant_eq.Location = new System.Drawing.Point(17, 23);
            this.txtBoxSecant_eq.MaxLength = 32767;
            this.txtBoxSecant_eq.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtBoxSecant_eq.Modified = false;
            this.txtBoxSecant_eq.Name = "txtBoxSecant_eq";
            this.txtBoxSecant_eq.PasswordChar = '\0';
            this.txtBoxSecant_eq.ReadOnly = false;
            this.txtBoxSecant_eq.SelectedText = "";
            this.txtBoxSecant_eq.SelectionLength = 0;
            this.txtBoxSecant_eq.SelectionStart = 0;
            this.txtBoxSecant_eq.ShortcutsEnabled = true;
            this.txtBoxSecant_eq.Size = new System.Drawing.Size(240, 35);
            this.txtBoxSecant_eq.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtBoxSecant_eq.TabIndex = 1;
            this.txtBoxSecant_eq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxSecant_eq.TextMarginLeft = 5;
            this.txtBoxSecant_eq.TextPlaceholder = "Функция";
            this.txtBoxSecant_eq.UseSystemPasswordChar = false;
            // 
            // EpsilonSecantTextBox
            // 
            this.EpsilonSecantTextBox.AcceptsReturn = false;
            this.EpsilonSecantTextBox.AcceptsTab = false;
            this.EpsilonSecantTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EpsilonSecantTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EpsilonSecantTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EpsilonSecantTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EpsilonSecantTextBox.BackgroundImage")));
            this.EpsilonSecantTextBox.BorderColorActive = System.Drawing.Color.White;
            this.EpsilonSecantTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.EpsilonSecantTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.EpsilonSecantTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.EpsilonSecantTextBox.BorderRadius = 18;
            this.EpsilonSecantTextBox.BorderThickness = 1;
            this.EpsilonSecantTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EpsilonSecantTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpsilonSecantTextBox.DefaultText = "";
            this.EpsilonSecantTextBox.FillColor = System.Drawing.Color.White;
            this.EpsilonSecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.EpsilonSecantTextBox.HideSelection = true;
            this.EpsilonSecantTextBox.IconLeft = null;
            this.EpsilonSecantTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EpsilonSecantTextBox.IconPadding = 10;
            this.EpsilonSecantTextBox.IconRight = null;
            this.EpsilonSecantTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EpsilonSecantTextBox.Location = new System.Drawing.Point(18, 130);
            this.EpsilonSecantTextBox.MaxLength = 32767;
            this.EpsilonSecantTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.EpsilonSecantTextBox.Modified = false;
            this.EpsilonSecantTextBox.Name = "EpsilonSecantTextBox";
            this.EpsilonSecantTextBox.PasswordChar = '\0';
            this.EpsilonSecantTextBox.ReadOnly = false;
            this.EpsilonSecantTextBox.SelectedText = "";
            this.EpsilonSecantTextBox.SelectionLength = 0;
            this.EpsilonSecantTextBox.SelectionStart = 0;
            this.EpsilonSecantTextBox.ShortcutsEnabled = true;
            this.EpsilonSecantTextBox.Size = new System.Drawing.Size(100, 35);
            this.EpsilonSecantTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.EpsilonSecantTextBox.TabIndex = 5;
            this.EpsilonSecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EpsilonSecantTextBox.TextMarginLeft = 5;
            this.EpsilonSecantTextBox.TextPlaceholder = "Точность";
            this.EpsilonSecantTextBox.UseSystemPasswordChar = false;
            // 
            // x1SecantTextBox
            // 
            this.x1SecantTextBox.AcceptsReturn = false;
            this.x1SecantTextBox.AcceptsTab = false;
            this.x1SecantTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.x1SecantTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.x1SecantTextBox.BackColor = System.Drawing.Color.Transparent;
            this.x1SecantTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x1SecantTextBox.BackgroundImage")));
            this.x1SecantTextBox.BorderColorActive = System.Drawing.Color.White;
            this.x1SecantTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.x1SecantTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.x1SecantTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.x1SecantTextBox.BorderRadius = 18;
            this.x1SecantTextBox.BorderThickness = 1;
            this.x1SecantTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.x1SecantTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1SecantTextBox.DefaultText = "";
            this.x1SecantTextBox.FillColor = System.Drawing.Color.White;
            this.x1SecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.x1SecantTextBox.HideSelection = true;
            this.x1SecantTextBox.IconLeft = null;
            this.x1SecantTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.x1SecantTextBox.IconPadding = 10;
            this.x1SecantTextBox.IconRight = null;
            this.x1SecantTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.x1SecantTextBox.Location = new System.Drawing.Point(18, 89);
            this.x1SecantTextBox.MaxLength = 32767;
            this.x1SecantTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.x1SecantTextBox.Modified = false;
            this.x1SecantTextBox.Name = "x1SecantTextBox";
            this.x1SecantTextBox.PasswordChar = '\0';
            this.x1SecantTextBox.ReadOnly = false;
            this.x1SecantTextBox.SelectedText = "";
            this.x1SecantTextBox.SelectionLength = 0;
            this.x1SecantTextBox.SelectionStart = 0;
            this.x1SecantTextBox.ShortcutsEnabled = true;
            this.x1SecantTextBox.Size = new System.Drawing.Size(100, 35);
            this.x1SecantTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.x1SecantTextBox.TabIndex = 5;
            this.x1SecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.x1SecantTextBox.TextMarginLeft = 5;
            this.x1SecantTextBox.TextPlaceholder = "x1";
            this.x1SecantTextBox.UseSystemPasswordChar = false;
            // 
            // x0SecantTextBox
            // 
            this.x0SecantTextBox.AcceptsReturn = false;
            this.x0SecantTextBox.AcceptsTab = false;
            this.x0SecantTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.x0SecantTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.x0SecantTextBox.BackColor = System.Drawing.Color.Transparent;
            this.x0SecantTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("x0SecantTextBox.BackgroundImage")));
            this.x0SecantTextBox.BorderColorActive = System.Drawing.Color.White;
            this.x0SecantTextBox.BorderColorDisabled = System.Drawing.Color.White;
            this.x0SecantTextBox.BorderColorHover = System.Drawing.SystemColors.ActiveCaption;
            this.x0SecantTextBox.BorderColorIdle = System.Drawing.Color.Black;
            this.x0SecantTextBox.BorderRadius = 18;
            this.x0SecantTextBox.BorderThickness = 1;
            this.x0SecantTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.x0SecantTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0SecantTextBox.DefaultText = "";
            this.x0SecantTextBox.FillColor = System.Drawing.Color.White;
            this.x0SecantTextBox.ForeColor = System.Drawing.Color.Black;
            this.x0SecantTextBox.HideSelection = true;
            this.x0SecantTextBox.IconLeft = null;
            this.x0SecantTextBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.x0SecantTextBox.IconPadding = 10;
            this.x0SecantTextBox.IconRight = null;
            this.x0SecantTextBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.x0SecantTextBox.Location = new System.Drawing.Point(18, 48);
            this.x0SecantTextBox.MaxLength = 32767;
            this.x0SecantTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.x0SecantTextBox.Modified = false;
            this.x0SecantTextBox.Name = "x0SecantTextBox";
            this.x0SecantTextBox.PasswordChar = '\0';
            this.x0SecantTextBox.ReadOnly = false;
            this.x0SecantTextBox.SelectedText = "";
            this.x0SecantTextBox.SelectionLength = 0;
            this.x0SecantTextBox.SelectionStart = 0;
            this.x0SecantTextBox.ShortcutsEnabled = true;
            this.x0SecantTextBox.Size = new System.Drawing.Size(100, 35);
            this.x0SecantTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.x0SecantTextBox.TabIndex = 5;
            this.x0SecantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.x0SecantTextBox.TextMarginLeft = 5;
            this.x0SecantTextBox.TextPlaceholder = "x0";
            this.x0SecantTextBox.UseSystemPasswordChar = false;
            // 
            // SecantMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecantMethod";
            this.Size = new System.Drawing.Size(745, 549);
            this.Load += new System.EventHandler(this.SecantMethod_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtBoxSecant_eq;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel23;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox EpsilonSecantTextBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox x1SecantTextBox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox x0SecantTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox resultSecant;
        private System.Windows.Forms.ListBox iterSecantTextBox;
        private System.Windows.Forms.ListBox rootSecantTextBox;
        private System.Windows.Forms.ListBox operationsSecantTextBox;
    }
}
