﻿namespace ACT8
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userameTxt = new System.Windows.Forms.TextBox();
            this.useranameLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.postBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 124);
            this.textBox1.TabIndex = 0;
            // 
            // getBtn
            // 
            this.getBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.getBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBtn.ForeColor = System.Drawing.Color.White;
            this.getBtn.Location = new System.Drawing.Point(26, 167);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(478, 45);
            this.getBtn.TabIndex = 1;
            this.getBtn.Text = "GET";
            this.getBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.getBtn);
            this.panel1.Location = new System.Drawing.Point(29, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 234);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.postBtn);
            this.panel2.Controls.Add(this.passwordLbl);
            this.panel2.Controls.Add(this.passTxt);
            this.panel2.Controls.Add(this.emailLbl);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.nameLbl);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.useranameLbl);
            this.panel2.Controls.Add(this.userameTxt);
            this.panel2.Location = new System.Drawing.Point(29, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 254);
            this.panel2.TabIndex = 3;
            // 
            // userameTxt
            // 
            this.userameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userameTxt.Location = new System.Drawing.Point(115, 69);
            this.userameTxt.Name = "userameTxt";
            this.userameTxt.Size = new System.Drawing.Size(389, 26);
            this.userameTxt.TabIndex = 0;
            // 
            // useranameLbl
            // 
            this.useranameLbl.AutoSize = true;
            this.useranameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useranameLbl.ForeColor = System.Drawing.Color.White;
            this.useranameLbl.Location = new System.Drawing.Point(23, 74);
            this.useranameLbl.Name = "useranameLbl";
            this.useranameLbl.Size = new System.Drawing.Size(86, 18);
            this.useranameLbl.TabIndex = 1;
            this.useranameLbl.Text = "Username:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(51, 32);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 18);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 26);
            this.textBox2.TabIndex = 2;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(57, 115);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(52, 18);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email:";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(115, 112);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(389, 26);
            this.emailTxt.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(29, 158);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password:";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(115, 154);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(389, 26);
            this.passTxt.TabIndex = 6;
            // 
            // postBtn
            // 
            this.postBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.postBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBtn.ForeColor = System.Drawing.Color.White;
            this.postBtn.Location = new System.Drawing.Point(26, 201);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(478, 45);
            this.postBtn.TabIndex = 2;
            this.postBtn.Text = "POST";
            this.postBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(576, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userameTxt;
        private System.Windows.Forms.Label useranameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button postBtn;
    }
}
