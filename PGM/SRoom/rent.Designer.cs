namespace SRoom
{
    partial class rent
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
            this.id = new System.Windows.Forms.TextBox();
            this.sr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.da = new System.Windows.Forms.DateTimePicker();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(36, 28);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // sr
            // 
            this.sr.Location = new System.Drawing.Point(161, 26);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(75, 23);
            this.sr.TabIndex = 1;
            this.sr.Text = "Get";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.da);
            this.gb.Controls.Add(this.l3);
            this.gb.Controls.Add(this.l2);
            this.gb.Controls.Add(this.l1);
            this.gb.Controls.Add(this.button2);
            this.gb.Location = new System.Drawing.Point(36, 71);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 193);
            this.gb.TabIndex = 3;
            this.gb.TabStop = false;
            // 
            // da
            // 
            this.da.Location = new System.Drawing.Point(42, 125);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(129, 20);
            this.da.TabIndex = 7;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(94, 103);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(18, 13);
            this.l3.TabIndex = 6;
            this.l3.Text = "ID";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(94, 71);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(18, 13);
            this.l2.TabIndex = 5;
            this.l2.Text = "ID";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(94, 34);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(18, 13);
            this.l1.TabIndex = 4;
            this.l1.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pay Rent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 299);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.id);
            this.Name = "rent";
            this.Text = "rent";
            this.Load += new System.EventHandler(this.rent_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker da;
    }
}