
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ICBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.submitRegistrationBtn = new System.Windows.Forms.Button();
            this.ContactNumberBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(39, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Registration";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(39, 120);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(166, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(39, 174);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(166, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "IC Number";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(39, 289);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(166, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Address";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(39, 147);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(519, 23);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // ICBox
            // 
            this.ICBox.Location = new System.Drawing.Point(39, 201);
            this.ICBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ICBox.Name = "ICBox";
            this.ICBox.Size = new System.Drawing.Size(195, 23);
            this.ICBox.TabIndex = 6;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(39, 324);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(195, 140);
            this.AddressBox.TabIndex = 7;
            this.AddressBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
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
            this.submitRegistrationBtn.Location = new System.Drawing.Point(386, 427);
            this.submitRegistrationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitRegistrationBtn.Name = "submitRegistrationBtn";
            this.submitRegistrationBtn.Size = new System.Drawing.Size(172, 37);
            this.submitRegistrationBtn.TabIndex = 8;
            this.submitRegistrationBtn.Text = "Submit ";
            this.submitRegistrationBtn.UseVisualStyleBackColor = false;
            this.submitRegistrationBtn.Click += new System.EventHandler(this.submitRegistrationBtn_Click);
            // 
            // ContactNumberBox
            // 
            this.ContactNumberBox.Location = new System.Drawing.Point(39, 255);
            this.ContactNumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactNumberBox.Name = "ContactNumberBox";
            this.ContactNumberBox.Size = new System.Drawing.Size(195, 23);
            this.ContactNumberBox.TabIndex = 10;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox9.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(39, 228);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(195, 23);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "Telephone Number";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(649, 518);
            this.Controls.Add(this.ContactNumberBox);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.submitRegistrationBtn);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.ICBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(665, 557);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ICBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button submitRegistrationBtn;
        private System.Windows.Forms.TextBox ContactNumberBox;
        private System.Windows.Forms.TextBox textBox9;
    }
}