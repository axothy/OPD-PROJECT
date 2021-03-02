namespace InspirationDemo
{
    partial class EquationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquationsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnNewton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.secantMethod1 = new InspirationDemo.SecantMethod();
            this.SuspendLayout();
            // 
            // btnNewton
            // 
            this.btnNewton.BackColor = System.Drawing.Color.Transparent;
            this.btnNewton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewton.BackgroundImage")));
            this.btnNewton.ButtonText = "Метод деления пополам";
            this.btnNewton.ButtonTextMarginLeft = 0;
            this.btnNewton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnNewton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnNewton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewton.ForeColor = System.Drawing.Color.Black;
            this.btnNewton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNewton.IconPadding = 8;
            this.btnNewton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNewton.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.btnNewton.IdleBorderRadius = 1;
            this.btnNewton.IdleBorderThickness = 0;
            this.btnNewton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnNewton.IdleIconLeftImage = null;
            this.btnNewton.IdleIconRightImage = null;
            this.btnNewton.Location = new System.Drawing.Point(12, 94);
            this.btnNewton.Name = "btnNewton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnNewton.onHoverState = stateProperties1;
            this.btnNewton.Size = new System.Drawing.Size(289, 28);
            this.btnNewton.TabIndex = 3;
            this.btnNewton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewton.Click += new System.EventHandler(this.btnNewton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Метод секущих";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 8;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(12, 61);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(289, 28);
            this.bunifuButton1.TabIndex = 3;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.ButtonText = "Метод Ньютона";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconPadding = 8;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton2.IdleBorderRadius = 1;
            this.bunifuButton2.IdleBorderThickness = 0;
            this.bunifuButton2.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.Location = new System.Drawing.Point(12, 29);
            this.bunifuButton2.Name = "bunifuButton2";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton2.onHoverState = stateProperties3;
            this.bunifuButton2.Size = new System.Drawing.Size(292, 28);
            this.bunifuButton2.TabIndex = 3;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.ButtonText = "Метод обр. кв. интерполяции";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton3.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconPadding = 8;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 0;
            this.bunifuButton3.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.Location = new System.Drawing.Point(12, 159);
            this.bunifuButton3.Name = "bunifuButton3";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton3.onHoverState = stateProperties4;
            this.bunifuButton3.Size = new System.Drawing.Size(289, 34);
            this.bunifuButton3.TabIndex = 3;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuButton4
            // 
            this.bunifuButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton4.BackgroundImage")));
            this.bunifuButton4.ButtonText = "Метод хорд";
            this.bunifuButton4.ButtonTextMarginLeft = 0;
            this.bunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton4.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IconPadding = 8;
            this.bunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton4.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton4.IdleBorderRadius = 1;
            this.bunifuButton4.IdleBorderThickness = 0;
            this.bunifuButton4.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuButton4.IdleIconLeftImage = null;
            this.bunifuButton4.IdleIconRightImage = null;
            this.bunifuButton4.Location = new System.Drawing.Point(12, 128);
            this.bunifuButton4.Name = "bunifuButton4";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bunifuButton4.onHoverState = stateProperties5;
            this.bunifuButton4.Size = new System.Drawing.Size(289, 28);
            this.bunifuButton4.TabIndex = 3;
            this.bunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuButton5
            // 
            this.bunifuButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton5.BackgroundImage")));
            this.bunifuButton5.ButtonText = "Метод простых итераций";
            this.bunifuButton5.ButtonTextMarginLeft = 0;
            this.bunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.bunifuButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton5.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IconPadding = 8;
            this.bunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton5.IdleBorderColor = System.Drawing.SystemColors.Control;
            this.bunifuButton5.IdleBorderRadius = 1;
            this.bunifuButton5.IdleBorderThickness = 0;
            this.bunifuButton5.IdleFillColor = System.Drawing.SystemColors.Control;
            this.bunifuButton5.IdleIconLeftImage = null;
            this.bunifuButton5.IdleIconRightImage = null;
            this.bunifuButton5.Location = new System.Drawing.Point(12, 198);
            this.bunifuButton5.Name = "bunifuButton5";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bunifuButton5.onHoverState = stateProperties6;
            this.bunifuButton5.Size = new System.Drawing.Size(289, 28);
            this.bunifuButton5.TabIndex = 3;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // secantMethod1
            // 
            this.secantMethod1.Location = new System.Drawing.Point(249, -2);
            this.secantMethod1.Name = "secantMethod1";
            this.secantMethod1.Size = new System.Drawing.Size(745, 549);
            this.secantMethod1.TabIndex = 4;
            // 
            // EquationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.secantMethod1);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.bunifuButton5);
            this.Controls.Add(this.bunifuButton4);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.btnNewton);
            this.Name = "EquationsForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.EquationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private SecantMethod secantMethod1;
    }
}
