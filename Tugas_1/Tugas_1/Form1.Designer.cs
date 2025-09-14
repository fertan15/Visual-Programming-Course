namespace Tugas_1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTbox = new System.Windows.Forms.TextBox();
            this.fullnameTbox = new System.Windows.Forms.TextBox();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmpasswordTbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailTbox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // usernameTbox
            // 
            this.usernameTbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTbox.Location = new System.Drawing.Point(363, 297);
            this.usernameTbox.Name = "usernameTbox";
            this.usernameTbox.Size = new System.Drawing.Size(285, 36);
            this.usernameTbox.TabIndex = 4;
            this.usernameTbox.TextChanged += new System.EventHandler(this.usernameTbox_TextChanged);
            // 
            // fullnameTbox
            // 
            this.fullnameTbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTbox.Location = new System.Drawing.Point(363, 356);
            this.fullnameTbox.Name = "fullnameTbox";
            this.fullnameTbox.Size = new System.Drawing.Size(285, 36);
            this.fullnameTbox.TabIndex = 5;
            this.fullnameTbox.TextChanged += new System.EventHandler(this.fullnameTbox_TextChanged);
            // 
            // passwordTbox
            // 
            this.passwordTbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTbox.Location = new System.Drawing.Point(363, 417);
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.PasswordChar = '*';
            this.passwordTbox.Size = new System.Drawing.Size(285, 36);
            this.passwordTbox.TabIndex = 7;
            this.passwordTbox.TextChanged += new System.EventHandler(this.passwordTbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // confirmpasswordTbox
            // 
            this.confirmpasswordTbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasswordTbox.Location = new System.Drawing.Point(363, 481);
            this.confirmpasswordTbox.Name = "confirmpasswordTbox";
            this.confirmpasswordTbox.PasswordChar = '*';
            this.confirmpasswordTbox.Size = new System.Drawing.Size(285, 36);
            this.confirmpasswordTbox.TabIndex = 9;
            this.confirmpasswordTbox.TextChanged += new System.EventHandler(this.confirmpasswordTbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupButton.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.Location = new System.Drawing.Point(135, 579);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(521, 50);
            this.signupButton.TabIndex = 10;
            this.signupButton.Text = "SIGN UP";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(12, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(842, 49);
            this.progressBar1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(278, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 57);
            this.label6.TabIndex = 12;
            this.label6.Text = "REGISTER";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // emailTbox
            // 
            this.emailTbox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTbox.Location = new System.Drawing.Point(363, 244);
            this.emailTbox.Name = "emailTbox";
            this.emailTbox.Size = new System.Drawing.Size(285, 36);
            this.emailTbox.TabIndex = 14;
            this.emailTbox.TextChanged += new System.EventHandler(this.emailTbox_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(438, 642);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 25);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already Have Account?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 688);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.emailTbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.confirmpasswordTbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullnameTbox);
            this.Controls.Add(this.usernameTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTbox;
        private System.Windows.Forms.TextBox fullnameTbox;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmpasswordTbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox emailTbox;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

