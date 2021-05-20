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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainSidePanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.integralsForm1 = new InspirationDemo.IntegralsForm();
            this.home2 = new InspirationDemo.Home();
            this.diffeqForm1 = new InspirationDemo.DiffeqForm();
            this.equationsForm1 = new InspirationDemo.EquationsForm();
            this.help1 = new InspirationDemo.Help();
            this.interpolationForm1 = new InspirationDemo.InterpolationForm();
            this.slauForm1 = new InspirationDemo.SLAUForm();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.exitbutton);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1077, 51);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Численные методы";
            // 
            // exitbutton
            // 
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("exitbutton.Image")));
            this.exitbutton.Location = new System.Drawing.Point(993, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(84, 51);
            this.exitbutton.TabIndex = 10;
            this.exitbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
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
            this.panel2.Controls.Add(this.MainSidePanel);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 566);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MainSidePanel
            // 
            this.MainSidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainSidePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.MainSidePanel.Location = new System.Drawing.Point(0, 43);
            this.MainSidePanel.Name = "MainSidePanel";
            this.MainSidePanel.Size = new System.Drawing.Size(10, 31);
            this.MainSidePanel.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(8, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "  ПОМОЩЬ";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(9, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Задача Коши";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(9, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Интерполяция";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(8, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "       СЛАУ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(8, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = " Интегралы";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "  Уравнения";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // integralsForm1
            // 
            this.integralsForm1.Location = new System.Drawing.Point(175, 51);
            this.integralsForm1.Margin = new System.Windows.Forms.Padding(3, 24, 3, 24);
            this.integralsForm1.Name = "integralsForm1";
            this.integralsForm1.Size = new System.Drawing.Size(2408, 3281);
            this.integralsForm1.TabIndex = 5;
            // 
            // home2
            // 
            this.home2.Location = new System.Drawing.Point(32483, 32598);
            this.home2.Margin = new System.Windows.Forms.Padding(3, 16175878, 3, 16175878);
            this.home2.Name = "home2";
            this.home2.Size = new System.Drawing.Size(22939, 65535);
            this.home2.TabIndex = 3;
            // 
            // diffeqForm1
            // 
            this.diffeqForm1.Location = new System.Drawing.Point(175, 51);
            this.diffeqForm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffeqForm1.Name = "diffeqForm1";
            this.diffeqForm1.Size = new System.Drawing.Size(939, 550);
            this.diffeqForm1.TabIndex = 6;
            // 
            // equationsForm1
            // 
            this.equationsForm1.BackColor = System.Drawing.SystemColors.Control;
            this.equationsForm1.Location = new System.Drawing.Point(175, 51);
            this.equationsForm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equationsForm1.Name = "equationsForm1";
            this.equationsForm1.Size = new System.Drawing.Size(939, 550);
            this.equationsForm1.TabIndex = 7;
            // 
            // help1
            // 
            this.help1.Location = new System.Drawing.Point(175, 51);
            this.help1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(939, 550);
            this.help1.TabIndex = 8;
            // 
            // interpolationForm1
            // 
            this.interpolationForm1.Location = new System.Drawing.Point(175, 51);
            this.interpolationForm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.interpolationForm1.Name = "interpolationForm1";
            this.interpolationForm1.Size = new System.Drawing.Size(939, 550);
            this.interpolationForm1.TabIndex = 9;
            // 
            // slauForm1
            // 
            this.slauForm1.Location = new System.Drawing.Point(175, 51);
            this.slauForm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.slauForm1.Name = "slauForm1";
            this.slauForm1.Size = new System.Drawing.Size(939, 550);
            this.slauForm1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1077, 617);
            this.Controls.Add(this.slauForm1);
            this.Controls.Add(this.interpolationForm1);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.equationsForm1);
            this.Controls.Add(this.diffeqForm1);
            this.Controls.Add(this.integralsForm1);
            this.Controls.Add(this.home2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Methods App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Home home2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel MainSidePanel;
        private System.Windows.Forms.Button exitbutton;
        private IntegralsForm integralsForm1;
        private System.Windows.Forms.Label label1;
        private DiffeqForm diffeqForm1;
        private EquationsForm equationsForm1;
        private Help help1;
        private InterpolationForm interpolationForm1;
        private SLAUForm slauForm1;
    }
}

