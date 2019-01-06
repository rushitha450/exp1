namespace SRoom
{
    partial class adminssion
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
            this.food = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.mob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gmob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.F = new System.Windows.Forms.RadioButton();
            this.m = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.no = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // food
            // 
            this.food.FormattingEnabled = true;
            this.food.Items.AddRange(new object[] {
            "Veg",
            "Non-Veg"});
            this.food.Location = new System.Drawing.Point(350, 101);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(121, 21);
            this.food.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 3;
            // 
            // mob
            // 
            this.mob.Location = new System.Drawing.Point(143, 107);
            this.mob.Name = "mob";
            this.mob.Size = new System.Drawing.Size(100, 20);
            this.mob.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mobile number";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(143, 137);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 20);
            this.add.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // gname
            // 
            this.gname.Location = new System.Drawing.Point(143, 170);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(100, 20);
            this.gname.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gardian Name";
            // 
            // gmob
            // 
            this.gmob.Location = new System.Drawing.Point(143, 194);
            this.gmob.Name = "gmob";
            this.gmob.Size = new System.Drawing.Size(100, 20);
            this.gmob.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gardian No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F);
            this.groupBox1.Controls.Add(this.m);
            this.groupBox1.Location = new System.Drawing.Point(143, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 31);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(47, 8);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(31, 17);
            this.F.TabIndex = 1;
            this.F.TabStop = true;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(7, 8);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(34, 17);
            this.m.TabIndex = 0;
            this.m.TabStop = true;
            this.m.Text = "M";
            this.m.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Food";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "AC/Non-AC";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.type.Location = new System.Drawing.Point(350, 132);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 21);
            this.type.TabIndex = 16;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // no
            // 
            this.no.FormattingEnabled = true;
            this.no.Location = new System.Drawing.Point(350, 165);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(121, 21);
            this.no.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Room NO";
            // 
            // cn
            // 
            this.cn.Location = new System.Drawing.Point(352, 70);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(119, 20);
            this.cn.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(273, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "College name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "DOB";
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(351, 191);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(120, 20);
            this.DOB.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "New Registration";
            // 
            // adminssion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 302);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gmob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.food);
            this.Name = "adminssion";
            this.Text = "adminssion";
            this.Load += new System.EventHandler(this.adminssion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox food;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox mob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gmob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton F;
        private System.Windows.Forms.RadioButton m;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label12;
    }
}