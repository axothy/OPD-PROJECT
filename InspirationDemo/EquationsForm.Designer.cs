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
            this.mpdMethod1 = new InspirationDemo.RelaxationMethod();
            this.newtonMethod1 = new InspirationDemo.NewtonMethod();
            this.secantMethod1 = new InspirationDemo.SecantMethod();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mpdMethod1
            // 
            this.mpdMethod1.Location = new System.Drawing.Point(250, 1);
            this.mpdMethod1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mpdMethod1.Name = "mpdMethod1";
            this.mpdMethod1.Size = new System.Drawing.Size(745, 549);
            this.mpdMethod1.TabIndex = 5;
            // 
            // newtonMethod1
            // 
            this.newtonMethod1.Location = new System.Drawing.Point(250, 1);
            this.newtonMethod1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newtonMethod1.Name = "newtonMethod1";
            this.newtonMethod1.Size = new System.Drawing.Size(745, 549);
            this.newtonMethod1.TabIndex = 6;
            // 
            // secantMethod1
            // 
            this.secantMethod1.Location = new System.Drawing.Point(250, 1);
            this.secantMethod1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secantMethod1.Name = "secantMethod1";
            this.secantMethod1.Size = new System.Drawing.Size(745, 549);
            this.secantMethod1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Метод Ньютона";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Метод релаксации";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 27);
            this.button3.TabIndex = 10;
            this.button3.Text = "Метод секущих";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EquationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secantMethod1);
            this.Controls.Add(this.newtonMethod1);
            this.Controls.Add(this.mpdMethod1);
            this.Name = "EquationsForm";
            this.Size = new System.Drawing.Size(939, 550);
            this.Load += new System.EventHandler(this.EquationsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RelaxationMethod mpdMethod1;
        private NewtonMethod newtonMethod1;
        private SecantMethod secantMethod1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
