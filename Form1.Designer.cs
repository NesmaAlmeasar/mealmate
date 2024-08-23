namespace mealmate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordlable = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labeltitle);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.passwordlable);
            this.panel1.Controls.Add(this.emaillabel);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 938);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(209, 697);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(97, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "التطبيق ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(175, 649);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "إنشاء حساب ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labeltitle.Location = new System.Drawing.Point(117, 88);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labeltitle.Size = new System.Drawing.Size(299, 64);
            this.labeltitle.TabIndex = 6;
            this.labeltitle.Text = "تسجيل الدخول ";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginbutton.Image = global::mealmate.Properties.Resources.enter__1_;
            this.loginbutton.Location = new System.Drawing.Point(148, 553);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginbutton.Size = new System.Drawing.Size(200, 66);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "دخول   ";
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mealmate.Properties.Resources.password1;
            this.pictureBox2.Location = new System.Drawing.Point(463, 404);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mealmate.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(463, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // passwordlable
            // 
            this.passwordlable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordlable.AutoSize = true;
            this.passwordlable.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlable.Location = new System.Drawing.Point(188, 468);
            this.passwordlable.Name = "passwordlable";
            this.passwordlable.Size = new System.Drawing.Size(227, 32);
            this.passwordlable.TabIndex = 3;
            this.passwordlable.Text = "  يرجى إدخال  كلمة السر";
            this.passwordlable.Visible = false;
            this.passwordlable.Click += new System.EventHandler(this.passwordlable_Click);
            // 
            // emaillabel
            // 
            this.emaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emaillabel.Location = new System.Drawing.Point(235, 331);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emaillabel.Size = new System.Drawing.Size(186, 32);
            this.emaillabel.TabIndex = 2;
            this.emaillabel.Text = "يرجى إدخال الايميل ";
            this.emaillabel.Visible = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(49, 397);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(376, 68);
            this.password.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(49, 260);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(376, 68);
            this.email.TabIndex = 0;
            this.email.Text = "n.a@gmail.com";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Brown;
            this.close.Location = new System.Drawing.Point(1260, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(55, 46);
            this.close.TabIndex = 1;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::mealmate.Properties.Resources.Screenshot_2024_07_30_234009;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1315, 938);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordlable;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label label2;
    }
}

