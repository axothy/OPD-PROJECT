namespace InspirationDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnWallet = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPayments = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnData = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSendTckn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDashboard = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.home2 = new InspirationDemo.Home();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1077, 51);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numerical\r\nMethods\r\nManager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.btnCart);
            this.panel2.Controls.Add(this.btnWallet);
            this.panel2.Controls.Add(this.btnPayments);
            this.panel2.Controls.Add(this.btnData);
            this.panel2.Controls.Add(this.btnSendTckn);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 566);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCart.BackgroundImage")));
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCart.ButtonText = "ПОМОЩЬ";
            this.btnCart.ButtonTextMarginLeft = 0;
            this.btnCart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCart.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnCart.DisabledForecolor = System.Drawing.Color.White;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCart.IconPadding = 8;
            this.btnCart.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCart.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnCart.IdleBorderRadius = 1;
            this.btnCart.IdleBorderThickness = 0;
            this.btnCart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnCart.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnCart.IdleIconLeftImage")));
            this.btnCart.IdleIconRightImage = null;
            this.btnCart.Location = new System.Drawing.Point(0, 521);
            this.btnCart.Name = "btnCart";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btnCart.onHoverState = stateProperties7;
            this.btnCart.Size = new System.Drawing.Size(161, 31);
            this.btnCart.TabIndex = 2;
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.Color.Transparent;
            this.btnWallet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWallet.BackgroundImage")));
            this.btnWallet.ButtonText = "Задача Коши";
            this.btnWallet.ButtonTextMarginLeft = 0;
            this.btnWallet.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnWallet.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnWallet.DisabledForecolor = System.Drawing.Color.White;
            this.btnWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWallet.ForeColor = System.Drawing.Color.White;
            this.btnWallet.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnWallet.IconPadding = 8;
            this.btnWallet.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnWallet.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnWallet.IdleBorderRadius = 1;
            this.btnWallet.IdleBorderThickness = 0;
            this.btnWallet.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnWallet.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnWallet.IdleIconLeftImage")));
            this.btnWallet.IdleIconRightImage = null;
            this.btnWallet.Location = new System.Drawing.Point(8, 187);
            this.btnWallet.Name = "btnWallet";
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btnWallet.onHoverState = stateProperties8;
            this.btnWallet.Size = new System.Drawing.Size(161, 31);
            this.btnWallet.TabIndex = 2;
            this.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayments.BackgroundImage")));
            this.btnPayments.ButtonText = "Интерполяция";
            this.btnPayments.ButtonTextMarginLeft = 0;
            this.btnPayments.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPayments.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnPayments.DisabledForecolor = System.Drawing.Color.White;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayments.IconPadding = 8;
            this.btnPayments.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayments.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnPayments.IdleBorderRadius = 1;
            this.btnPayments.IdleBorderThickness = 0;
            this.btnPayments.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnPayments.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnPayments.IdleIconLeftImage")));
            this.btnPayments.IdleIconRightImage = null;
            this.btnPayments.Location = new System.Drawing.Point(8, 150);
            this.btnPayments.Name = "btnPayments";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties9.BorderRadius = 1;
            stateProperties9.BorderThickness = 1;
            stateProperties9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties9.IconLeftImage = null;
            stateProperties9.IconRightImage = null;
            this.btnPayments.onHoverState = stateProperties9;
            this.btnPayments.Size = new System.Drawing.Size(161, 31);
            this.btnPayments.TabIndex = 2;
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnData.BackgroundImage")));
            this.btnData.ButtonText = "СЛАУ";
            this.btnData.ButtonTextMarginLeft = 0;
            this.btnData.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnData.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnData.DisabledForecolor = System.Drawing.Color.White;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnData.IconPadding = 8;
            this.btnData.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnData.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnData.IdleBorderRadius = 1;
            this.btnData.IdleBorderThickness = 0;
            this.btnData.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnData.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnData.IdleIconLeftImage")));
            this.btnData.IdleIconRightImage = null;
            this.btnData.Location = new System.Drawing.Point(8, 113);
            this.btnData.Name = "btnData";
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties10.BorderRadius = 1;
            stateProperties10.BorderThickness = 1;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties10.IconLeftImage = null;
            stateProperties10.IconRightImage = null;
            this.btnData.onHoverState = stateProperties10;
            this.btnData.Size = new System.Drawing.Size(161, 31);
            this.btnData.TabIndex = 2;
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSendTckn
            // 
            this.btnSendTckn.BackColor = System.Drawing.Color.Transparent;
            this.btnSendTckn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendTckn.BackgroundImage")));
            this.btnSendTckn.ButtonText = "Интегралы";
            this.btnSendTckn.ButtonTextMarginLeft = 0;
            this.btnSendTckn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSendTckn.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnSendTckn.DisabledForecolor = System.Drawing.Color.White;
            this.btnSendTckn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendTckn.ForeColor = System.Drawing.Color.White;
            this.btnSendTckn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSendTckn.IconPadding = 8;
            this.btnSendTckn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSendTckn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnSendTckn.IdleBorderRadius = 1;
            this.btnSendTckn.IdleBorderThickness = 0;
            this.btnSendTckn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnSendTckn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnSendTckn.IdleIconLeftImage")));
            this.btnSendTckn.IdleIconRightImage = null;
            this.btnSendTckn.Location = new System.Drawing.Point(8, 76);
            this.btnSendTckn.Name = "btnSendTckn";
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties11.BorderRadius = 1;
            stateProperties11.BorderThickness = 1;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.btnSendTckn.onHoverState = stateProperties11;
            this.btnSendTckn.Size = new System.Drawing.Size(161, 31);
            this.btnSendTckn.TabIndex = 2;
            this.btnSendTckn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendTckn.Click += new System.EventHandler(this.btnSendTckn_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.ButtonText = "Уравнения";
            this.btnDashboard.ButtonTextMarginLeft = 0;
            this.btnDashboard.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnDashboard.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnDashboard.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IconPadding = 8;
            this.btnDashboard.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnDashboard.IdleBorderRadius = 1;
            this.btnDashboard.IdleBorderThickness = 0;
            this.btnDashboard.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnDashboard.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.IdleIconLeftImage")));
            this.btnDashboard.IdleIconRightImage = null;
            this.btnDashboard.Location = new System.Drawing.Point(8, 39);
            this.btnDashboard.Name = "btnDashboard";
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties12.BorderRadius = 1;
            stateProperties12.BorderThickness = 1;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.btnDashboard.onHoverState = stateProperties12;
            this.btnDashboard.Size = new System.Drawing.Size(161, 31);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.SidePanel.Location = new System.Drawing.Point(1, 40);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(6, 32);
            this.SidePanel.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.8D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // home2
            // 
            this.home2.Location = new System.Drawing.Point(1576, 5302);
            this.home2.Margin = new System.Windows.Forms.Padding(3, 48, 3, 48);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(28, 94);
            this.home2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1077, 617);
            this.Controls.Add(this.home2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCart;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnWallet;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPayments;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnData;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSendTckn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDashboard;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Home home2;
    }
}

