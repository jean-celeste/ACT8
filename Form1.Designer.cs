namespace ACT8
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
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.getUserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getBookBtn = new System.Windows.Forms.Button();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookBtn = new System.Windows.Forms.Label();
            this.postUserBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.useranameLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.productPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userBtn = new System.Windows.Forms.Label();
            this.postBookBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.copiesTxt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.BookLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outputTxtBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTxtBox.Location = new System.Drawing.Point(25, 33);
            this.outputTxtBox.Multiline = true;
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxtBox.Size = new System.Drawing.Size(388, 242);
            this.outputTxtBox.TabIndex = 10;
            // 
            // getUserBtn
            // 
            this.getUserBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.getUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getUserBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getUserBtn.ForeColor = System.Drawing.Color.White;
            this.getUserBtn.Location = new System.Drawing.Point(25, 281);
            this.getUserBtn.Name = "getUserBtn";
            this.getUserBtn.Size = new System.Drawing.Size(388, 45);
            this.getUserBtn.TabIndex = 1;
            this.getUserBtn.Text = "GET";
            this.getUserBtn.UseVisualStyleBackColor = false;
            this.getUserBtn.Click += new System.EventHandler(this.getUserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.outputTxtBox);
            this.panel1.Controls.Add(this.getUserBtn);
            this.panel1.Controls.Add(this.getBookBtn);
            this.panel1.Location = new System.Drawing.Point(472, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 362);
            this.panel1.TabIndex = 2;
            // 
            // getBookBtn
            // 
            this.getBookBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.getBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getBookBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBookBtn.ForeColor = System.Drawing.Color.White;
            this.getBookBtn.Location = new System.Drawing.Point(25, 281);
            this.getBookBtn.Name = "getBookBtn";
            this.getBookBtn.Size = new System.Drawing.Size(388, 45);
            this.getBookBtn.TabIndex = 11;
            this.getBookBtn.Text = "GET";
            this.getBookBtn.UseVisualStyleBackColor = false;
            this.getBookBtn.Click += new System.EventHandler(this.getBookBtn_Click);
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.label1);
            this.UserPanel.Controls.Add(this.pictureBox1);
            this.UserPanel.Controls.Add(this.bookBtn);
            this.UserPanel.Controls.Add(this.postUserBtn);
            this.UserPanel.Controls.Add(this.passwordLbl);
            this.UserPanel.Controls.Add(this.passTxt);
            this.UserPanel.Controls.Add(this.emailLbl);
            this.UserPanel.Controls.Add(this.emailTxt);
            this.UserPanel.Controls.Add(this.nameLbl);
            this.UserPanel.Controls.Add(this.nameTxt);
            this.UserPanel.Controls.Add(this.useranameLbl);
            this.UserPanel.Controls.Add(this.usernameTxt);
            this.UserPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserPanel.Location = new System.Drawing.Point(15, 12);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(448, 340);
            this.UserPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.AutoSize = true;
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.Location = new System.Drawing.Point(308, 8);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(97, 18);
            this.bookBtn.TabIndex = 8;
            this.bookBtn.Text = "Go to Books";
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // postUserBtn
            // 
            this.postUserBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.postUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postUserBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postUserBtn.ForeColor = System.Drawing.Color.White;
            this.postUserBtn.Location = new System.Drawing.Point(27, 269);
            this.postUserBtn.Name = "postUserBtn";
            this.postUserBtn.Size = new System.Drawing.Size(391, 45);
            this.postUserBtn.TabIndex = 2;
            this.postUserBtn.Text = "POST";
            this.postUserBtn.UseVisualStyleBackColor = false;
            this.postUserBtn.Click += new System.EventHandler(this.postUserBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(42, 201);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 7;
            this.passwordLbl.Text = "Password:";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(128, 197);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(302, 26);
            this.passTxt.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(70, 158);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(52, 18);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email:";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(128, 155);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(302, 26);
            this.emailTxt.TabIndex = 4;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(64, 75);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 18);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(128, 70);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(302, 26);
            this.nameTxt.TabIndex = 2;
            // 
            // useranameLbl
            // 
            this.useranameLbl.AutoSize = true;
            this.useranameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useranameLbl.ForeColor = System.Drawing.Color.White;
            this.useranameLbl.Location = new System.Drawing.Point(36, 117);
            this.useranameLbl.Name = "useranameLbl";
            this.useranameLbl.Size = new System.Drawing.Size(86, 18);
            this.useranameLbl.TabIndex = 1;
            this.useranameLbl.Text = "Username:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(128, 112);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(302, 26);
            this.usernameTxt.TabIndex = 0;
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.BookLbl);
            this.productPanel.Controls.Add(this.priceTxt);
            this.productPanel.Controls.Add(this.pictureBox2);
            this.productPanel.Controls.Add(this.userBtn);
            this.productPanel.Controls.Add(this.postBookBtn);
            this.productPanel.Controls.Add(this.label2);
            this.productPanel.Controls.Add(this.copiesTxt);
            this.productPanel.Controls.Add(this.price);
            this.productPanel.Controls.Add(this.label4);
            this.productPanel.Controls.Add(this.titleTxt);
            this.productPanel.Controls.Add(this.label5);
            this.productPanel.Controls.Add(this.authorTxt);
            this.productPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.productPanel.Location = new System.Drawing.Point(12, 12);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(451, 340);
            this.productPanel.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(405, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // userBtn
            // 
            this.userBtn.AutoSize = true;
            this.userBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ForeColor = System.Drawing.Color.White;
            this.userBtn.Location = new System.Drawing.Point(312, 8);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(90, 18);
            this.userBtn.TabIndex = 8;
            this.userBtn.Text = "Go to Users";
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // postBookBtn
            // 
            this.postBookBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.postBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postBookBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postBookBtn.ForeColor = System.Drawing.Color.White;
            this.postBookBtn.Location = new System.Drawing.Point(30, 269);
            this.postBookBtn.Name = "postBookBtn";
            this.postBookBtn.Size = new System.Drawing.Size(391, 45);
            this.postBookBtn.TabIndex = 2;
            this.postBookBtn.Text = "POST";
            this.postBookBtn.UseVisualStyleBackColor = false;
            this.postBookBtn.Click += new System.EventHandler(this.postBookBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copies:";
            // 
            // copiesTxt
            // 
            this.copiesTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copiesTxt.Location = new System.Drawing.Point(131, 197);
            this.copiesTxt.Name = "copiesTxt";
            this.copiesTxt.Size = new System.Drawing.Size(302, 26);
            this.copiesTxt.TabIndex = 6;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(75, 157);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(49, 18);
            this.price.TabIndex = 5;
            this.price.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title:";
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(131, 70);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(302, 26);
            this.titleTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Author:";
            // 
            // authorTxt
            // 
            this.authorTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTxt.Location = new System.Drawing.Point(131, 112);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(302, 26);
            this.authorTxt.TabIndex = 0;
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(131, 154);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(302, 26);
            this.priceTxt.TabIndex = 10;
            // 
            // BookLbl
            // 
            this.BookLbl.AutoSize = true;
            this.BookLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookLbl.ForeColor = System.Drawing.Color.White;
            this.BookLbl.Location = new System.Drawing.Point(25, 8);
            this.BookLbl.Name = "BookLbl";
            this.BookLbl.Size = new System.Drawing.Size(71, 25);
            this.BookLbl.TabIndex = 11;
            this.BookLbl.Text = "Books";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(897, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.productPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox outputTxtBox;
        private System.Windows.Forms.Button getUserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label useranameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Button postUserBtn;
        private System.Windows.Forms.Label bookBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label userBtn;
        private System.Windows.Forms.Button postBookBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox copiesTxt;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button getBookBtn;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label BookLbl;
        private System.Windows.Forms.Label label1;
    }
}

