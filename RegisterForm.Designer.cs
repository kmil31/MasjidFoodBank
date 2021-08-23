
namespace god_does_it
{
    partial class RegisterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.IC = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.submitRegistrationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(45, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Registration";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(45, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(190, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(45, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(190, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "IC Number";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(45, 385);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(190, 29);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Address";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(45, 196);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(222, 27);
            this.userName.TabIndex = 5;
            // 
            // IC
            // 
            this.IC.Location = new System.Drawing.Point(45, 324);
            this.IC.Name = "IC";
            this.IC.Size = new System.Drawing.Size(222, 27);
            this.IC.TabIndex = 6;
            this.IC.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(45, 432);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(222, 185);
            this.address.TabIndex = 7;
            // 
            // submitRegistrationBtn
            // 
            this.submitRegistrationBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.submitRegistrationBtn.FlatAppearance.BorderSize = 0;
            this.submitRegistrationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.submitRegistrationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitRegistrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitRegistrationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitRegistrationBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.submitRegistrationBtn.Location = new System.Drawing.Point(441, 568);
            this.submitRegistrationBtn.Name = "submitRegistrationBtn";
            this.submitRegistrationBtn.Size = new System.Drawing.Size(196, 49);
            this.submitRegistrationBtn.TabIndex = 8;
            this.submitRegistrationBtn.Text = "Submit ";
            this.submitRegistrationBtn.UseVisualStyleBackColor = false;
            this.submitRegistrationBtn.Click += new System.EventHandler(this.submitRegistrationBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(742, 690);
            this.Controls.Add(this.submitRegistrationBtn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.IC);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(758, 729);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox IC;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button submitRegistrationBtn;
    }
}