namespace mealmate
{
    partial class admin
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
            this.closebutton = new System.Windows.Forms.Button();
            this.buttonusersmang = new System.Windows.Forms.Button();
            this.buttondelevermang = new System.Windows.Forms.Button();
            this.buttonfoodmang = new System.Windows.Forms.Button();
            this.buttondietmang = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.foodmanage1 = new mealmate.foodmanage();
            this.dietmanage1 = new mealmate.Dietmanage();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(157)))), ((int)(((byte)(208)))));
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.buttonusersmang);
            this.panel1.Controls.Add(this.buttondelevermang);
            this.panel1.Controls.Add(this.buttonfoodmang);
            this.panel1.Controls.Add(this.buttondietmang);
            this.panel1.Controls.Add(this.buttonhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1527, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 1321);
            this.panel1.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.IndianRed;
            this.closebutton.Location = new System.Drawing.Point(531, 12);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(47, 48);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "x";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // buttonusersmang
            // 
            this.buttonusersmang.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonusersmang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonusersmang.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonusersmang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonusersmang.Location = new System.Drawing.Point(31, 899);
            this.buttonusersmang.Name = "buttonusersmang";
            this.buttonusersmang.Size = new System.Drawing.Size(485, 130);
            this.buttonusersmang.TabIndex = 4;
            this.buttonusersmang.Text = "إدارة المستخدمين ";
            this.buttonusersmang.UseVisualStyleBackColor = false;
            // 
            // buttondelevermang
            // 
            this.buttondelevermang.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttondelevermang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelevermang.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelevermang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttondelevermang.Location = new System.Drawing.Point(31, 729);
            this.buttondelevermang.Name = "buttondelevermang";
            this.buttondelevermang.Size = new System.Drawing.Size(485, 130);
            this.buttondelevermang.TabIndex = 3;
            this.buttondelevermang.Text = "إدارة الطلبات ";
            this.buttondelevermang.UseVisualStyleBackColor = false;
            // 
            // buttonfoodmang
            // 
            this.buttonfoodmang.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonfoodmang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfoodmang.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfoodmang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonfoodmang.Location = new System.Drawing.Point(31, 369);
            this.buttonfoodmang.Name = "buttonfoodmang";
            this.buttonfoodmang.Size = new System.Drawing.Size(485, 130);
            this.buttonfoodmang.TabIndex = 1;
            this.buttonfoodmang.Text = "إدارة الأطعمة";
            this.buttonfoodmang.UseVisualStyleBackColor = false;
            this.buttonfoodmang.Click += new System.EventHandler(this.buttonfoodmang_Click);
            // 
            // buttondietmang
            // 
            this.buttondietmang.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttondietmang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondietmang.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondietmang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttondietmang.Location = new System.Drawing.Point(31, 547);
            this.buttondietmang.Name = "buttondietmang";
            this.buttondietmang.Size = new System.Drawing.Size(485, 130);
            this.buttondietmang.TabIndex = 2;
            this.buttondietmang.Text = "إدارة الانظمة الغذائية ";
            this.buttondietmang.UseVisualStyleBackColor = false;
            this.buttondietmang.Click += new System.EventHandler(this.buttondietmang_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonhome.Location = new System.Drawing.Point(31, 189);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(485, 130);
            this.buttonhome.TabIndex = 0;
            this.buttonhome.Text = "الصفحة الرئيسية ";
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // foodmanage1
            // 
            this.foodmanage1.Location = new System.Drawing.Point(31, 26);
            this.foodmanage1.Name = "foodmanage1";
            this.foodmanage1.Size = new System.Drawing.Size(1464, 1236);
            this.foodmanage1.TabIndex = 1;
            // 
            // dietmanage1
            // 
            this.dietmanage1.Location = new System.Drawing.Point(51, 38);
            this.dietmanage1.Name = "dietmanage1";
            this.dietmanage1.Size = new System.Drawing.Size(1444, 1224);
            this.dietmanage1.TabIndex = 2;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mealmate.Properties.Resources.Screenshot_2024_07_30_234009;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2117, 1321);
            this.Controls.Add(this.dietmanage1);
            this.Controls.Add(this.foodmanage1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Button buttonusersmang;
        private System.Windows.Forms.Button buttondelevermang;
        private System.Windows.Forms.Button buttonfoodmang;
        private System.Windows.Forms.Button buttondietmang;
        private System.Windows.Forms.Button closebutton;
        private foodmanage foodmanage1;
        private Dietmanage dietmanage1;
    }
}