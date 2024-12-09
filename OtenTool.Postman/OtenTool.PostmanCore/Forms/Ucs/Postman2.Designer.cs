namespace OtenTool.PostmanCore
{
    partial class Postman2
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
            panel1 = new Panel();
            btnSend = new Button();
            txtUrl = new TextBox();
            cmbMethdodType = new ComboBox();
            splitContainer1 = new SplitContainer();
            tpHeaders = new TabControl();
            tpParams = new TabPage();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            IsChecked = new DataGridViewCheckBoxColumn();
            Key = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            tpAuthorization = new TabPage();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cmbAuthType = new ComboBox();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            dgvHeaders = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Body = new TabPage();
            pnlBody = new Panel();
            panel2 = new Panel();
            rbRaw = new RadioButton();
            rbUrlencoded = new RadioButton();
            rbFormData = new RadioButton();
            rbNone = new RadioButton();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            rtbBody = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tpHeaders.SuspendLayout();
            tpParams.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpAuthorization.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            Body.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtUrl);
            panel1.Controls.Add(cmbMethdodType);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 48);
            panel1.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.Location = new Point(917, 13);
            btnSend.Margin = new Padding(4, 3, 4, 3);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(88, 27);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(169, 15);
            txtUrl.Margin = new Padding(4, 3, 4, 3);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(740, 23);
            txtUrl.TabIndex = 1;
            // 
            // cmbMethdodType
            // 
            cmbMethdodType.DrawMode = DrawMode.OwnerDrawFixed;
            cmbMethdodType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethdodType.FormattingEnabled = true;
            cmbMethdodType.Location = new Point(20, 15);
            cmbMethdodType.Margin = new Padding(4, 3, 4, 3);
            cmbMethdodType.Name = "cmbMethdodType";
            cmbMethdodType.Size = new Size(140, 24);
            cmbMethdodType.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 48);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.MinimumSize = new Size(1008, 734);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tpHeaders);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1008, 734);
            splitContainer1.SplitterDistance = 227;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // tpHeaders
            // 
            tpHeaders.Controls.Add(tpParams);
            tpHeaders.Controls.Add(tpAuthorization);
            tpHeaders.Controls.Add(tabPage1);
            tpHeaders.Controls.Add(Body);
            tpHeaders.Dock = DockStyle.Fill;
            tpHeaders.Location = new Point(0, 0);
            tpHeaders.Margin = new Padding(4, 3, 4, 3);
            tpHeaders.MinimumSize = new Size(1003, 223);
            tpHeaders.Name = "tpHeaders";
            tpHeaders.SelectedIndex = 0;
            tpHeaders.Size = new Size(1004, 223);
            tpHeaders.TabIndex = 0;
            // 
            // tpParams
            // 
            tpParams.Controls.Add(groupBox1);
            tpParams.Location = new Point(4, 24);
            tpParams.Margin = new Padding(4, 3, 4, 3);
            tpParams.Name = "tpParams";
            tpParams.Padding = new Padding(4, 3, 4, 3);
            tpParams.Size = new Size(996, 195);
            tpParams.TabIndex = 0;
            tpParams.Text = "Params";
            tpParams.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(4, 3);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(988, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Query Params";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IsChecked, Key, Value, Description });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 19);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(980, 167);
            dataGridView1.TabIndex = 0;
            // 
            // IsChecked
            // 
            IsChecked.HeaderText = "Checked";
            IsChecked.Name = "IsChecked";
            // 
            // Key
            // 
            Key.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Key.HeaderText = "Key";
            Key.MaxInputLength = 1024;
            Key.Name = "Key";
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Value.HeaderText = "Value";
            Value.MaxInputLength = 1024;
            Value.Name = "Value";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description";
            Description.MaxInputLength = 1024;
            Description.Name = "Description";
            // 
            // tpAuthorization
            // 
            tpAuthorization.Controls.Add(textBox4);
            tpAuthorization.Controls.Add(textBox3);
            tpAuthorization.Controls.Add(textBox2);
            tpAuthorization.Controls.Add(label3);
            tpAuthorization.Controls.Add(label2);
            tpAuthorization.Controls.Add(label1);
            tpAuthorization.Controls.Add(groupBox2);
            tpAuthorization.Location = new Point(4, 24);
            tpAuthorization.Margin = new Padding(4, 3, 4, 3);
            tpAuthorization.Name = "tpAuthorization";
            tpAuthorization.Padding = new Padding(4, 3, 4, 3);
            tpAuthorization.Size = new Size(996, 195);
            tpAuthorization.TabIndex = 1;
            tpAuthorization.Text = "Authorization";
            tpAuthorization.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(357, 143);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(560, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(357, 113);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(560, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(357, 44);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 62);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 147);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 117);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "User Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Token :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbAuthType);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(4, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(233, 189);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Auth type";
            // 
            // cmbAuthType
            // 
            cmbAuthType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthType.FormattingEnabled = true;
            cmbAuthType.Items.AddRange(new object[] { "Bearer Token", "Basic Auth" });
            cmbAuthType.Location = new Point(33, 103);
            cmbAuthType.Margin = new Padding(4, 3, 4, 3);
            cmbAuthType.Name = "cmbAuthType";
            cmbAuthType.Size = new Size(140, 23);
            cmbAuthType.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(996, 195);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Headers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHeaders);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(4, 3);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(988, 189);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Headers";
            // 
            // dgvHeaders
            // 
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dgvHeaders.Dock = DockStyle.Fill;
            dgvHeaders.Location = new Point(4, 19);
            dgvHeaders.Margin = new Padding(4, 3, 4, 3);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.Size = new Size(980, 167);
            dgvHeaders.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "Checked";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Key";
            dataGridViewTextBoxColumn1.MaxInputLength = 1024;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Value";
            dataGridViewTextBoxColumn2.MaxInputLength = 1024;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.MaxInputLength = 1024;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Body
            // 
            Body.Controls.Add(pnlBody);
            Body.Controls.Add(panel2);
            Body.Location = new Point(4, 24);
            Body.Margin = new Padding(4, 3, 4, 3);
            Body.Name = "Body";
            Body.Padding = new Padding(4, 3, 4, 3);
            Body.Size = new Size(996, 195);
            Body.TabIndex = 3;
            Body.Text = "Body";
            Body.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(4, 45);
            pnlBody.Margin = new Padding(4, 3, 4, 3);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(988, 147);
            pnlBody.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbRaw);
            panel2.Controls.Add(rbUrlencoded);
            panel2.Controls.Add(rbFormData);
            panel2.Controls.Add(rbNone);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 42);
            panel2.TabIndex = 0;
            // 
            // rbRaw
            // 
            rbRaw.AutoSize = true;
            rbRaw.Location = new Point(323, 14);
            rbRaw.Margin = new Padding(4, 3, 4, 3);
            rbRaw.Name = "rbRaw";
            rbRaw.Size = new Size(44, 19);
            rbRaw.TabIndex = 1;
            rbRaw.Text = "raw";
            rbRaw.UseVisualStyleBackColor = true;
            rbRaw.CheckedChanged += BodyRadioButtonChanged;
            // 
            // rbUrlencoded
            // 
            rbUrlencoded.AutoSize = true;
            rbUrlencoded.Location = new Point(158, 14);
            rbUrlencoded.Margin = new Padding(4, 3, 4, 3);
            rbUrlencoded.Name = "rbUrlencoded";
            rbUrlencoded.Size = new Size(159, 19);
            rbUrlencoded.TabIndex = 1;
            rbUrlencoded.Text = "x-www-form-urlencoded";
            rbUrlencoded.UseVisualStyleBackColor = true;
            // 
            // rbFormData
            // 
            rbFormData.AutoSize = true;
            rbFormData.Location = new Point(72, 14);
            rbFormData.Margin = new Padding(4, 3, 4, 3);
            rbFormData.Name = "rbFormData";
            rbFormData.Size = new Size(79, 19);
            rbFormData.TabIndex = 1;
            rbFormData.Text = "from-data";
            rbFormData.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Checked = true;
            rbNone.Location = new Point(8, 14);
            rbNone.Margin = new Padding(4, 3, 4, 3);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(52, 19);
            rbNone.TabIndex = 1;
            rbNone.TabStop = true;
            rbNone.Text = "none";
            rbNone.UseVisualStyleBackColor = true;
            rbNone.CheckedChanged += BodyRadioButtonChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1004, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rtbBody);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(996, 470);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Body";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbBody
            // 
            rtbBody.Dock = DockStyle.Fill;
            rtbBody.Location = new Point(4, 3);
            rtbBody.Margin = new Padding(4, 3, 4, 3);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(988, 464);
            rtbBody.TabIndex = 0;
            rtbBody.Text = "";
            // 
            // Postman2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Postman2";
            Size = new Size(1008, 782);
            Load += Postman2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tpHeaders.ResumeLayout(false);
            tpParams.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpAuthorization.ResumeLayout(false);
            tpAuthorization.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).EndInit();
            Body.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbMethdodType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tpHeaders;
        private System.Windows.Forms.TabPage tpParams;
        private System.Windows.Forms.TabPage tpAuthorization;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Body;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAuthType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHeaders;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbFormData;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbUrlencoded;
        private System.Windows.Forms.RadioButton rbRaw;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbBody;
    }
}
