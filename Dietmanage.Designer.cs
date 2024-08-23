namespace mealmate
{
    partial class Dietmanage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.RestrictionDescription = new System.Windows.Forms.TextBox();
            this.RestrictionName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDiet = new System.Windows.Forms.Button();
            this.RestrictionID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 730);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "عرض الانظمه المدرجه";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 95);
            this.button2.TabIndex = 2;
            this.button2.Text = "اضافة نظام";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 95);
            this.button3.TabIndex = 3;
            this.button3.Text = "تعديل نظام";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 824);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 95);
            this.button4.TabIndex = 4;
            this.button4.Text = "حذف نظام";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 123);
            this.label1.TabIndex = 7;
            this.label1.Text = "إدار الانظمة الغذائية ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestrictionID);
            this.groupBox1.Controls.Add(this.addDiet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RestrictionDescription);
            this.groupBox1.Controls.Add(this.RestrictionName);
            this.groupBox1.Location = new System.Drawing.Point(72, 997);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1317, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إضافة نظام غذائي ";
            this.groupBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1209, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1152, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم ";
            // 
            // RestrictionDescription
            // 
            this.RestrictionDescription.Location = new System.Drawing.Point(239, 51);
            this.RestrictionDescription.Multiline = true;
            this.RestrictionDescription.Name = "RestrictionDescription";
            this.RestrictionDescription.Size = new System.Drawing.Size(421, 103);
            this.RestrictionDescription.TabIndex = 1;
            // 
            // RestrictionName
            // 
            this.RestrictionName.Location = new System.Drawing.Point(774, 51);
            this.RestrictionName.Multiline = true;
            this.RestrictionName.Name = "RestrictionName";
            this.RestrictionName.Size = new System.Drawing.Size(314, 64);
            this.RestrictionName.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // addDiet
            // 
            this.addDiet.Location = new System.Drawing.Point(53, 80);
            this.addDiet.Name = "addDiet";
            this.addDiet.Size = new System.Drawing.Size(118, 52);
            this.addDiet.TabIndex = 5;
            this.addDiet.Text = "إضافة ";
            this.addDiet.UseVisualStyleBackColor = true;
            this.addDiet.Click += new System.EventHandler(this.addDiet_Click);
            // 
            // RestrictionID
            // 
            this.RestrictionID.Location = new System.Drawing.Point(1132, 119);
            this.RestrictionID.Multiline = true;
            this.RestrictionID.Name = "RestrictionID";
            this.RestrictionID.Size = new System.Drawing.Size(179, 35);
            this.RestrictionID.TabIndex = 6;
            // 
            // Dietmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dietmanage";
            this.Size = new System.Drawing.Size(1521, 1297);
            this.Load += new System.EventHandler(this.Dietmanage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RestrictionDescription;
        private System.Windows.Forms.TextBox RestrictionName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button addDiet;
        private System.Windows.Forms.TextBox RestrictionID;
    }
}
