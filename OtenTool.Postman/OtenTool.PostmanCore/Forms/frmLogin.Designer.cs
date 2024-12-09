namespace OtenTool.PostmanCore.Forms
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            statusStrip1 = new StatusStrip();
            tssDatabase = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 44);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 72);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(140, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(215, 23);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "orcun";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(215, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "1234qqqQ";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(280, 109);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssDatabase });
            statusStrip1.Location = new Point(0, 139);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(413, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssDatabase
            // 
            tssDatabase.Name = "tssDatabase";
            tssDatabase.Size = new Size(118, 17);
            tssDatabase.Text = "toolStripStatusLabel1";
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 161);
            Controls.Add(statusStrip1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            Load += frmLogin_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssDatabase;
    }
}