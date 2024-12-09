namespace OtenTool.PostmanCoreCore
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            tssUser = new ToolStripStatusLabel();
            tssDatabase = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            btnRefresh = new Button();
            dgvProject = new DataGridView();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProject).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssUser, tssDatabase });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssUser
            // 
            tssUser.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tssUser.Name = "tssUser";
            tssUser.Size = new Size(48, 19);
            tssUser.Text = "tssUser";
            // 
            // tssDatabase
            // 
            tssDatabase.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            tssDatabase.Name = "tssDatabase";
            tssDatabase.Size = new Size(73, 19);
            tssDatabase.Text = "tssDatabase";
            tssDatabase.Click += tssDatabase_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnRefresh);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProject);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 114;
            splitContainer1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(711, 84);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvProject
            // 
            dgvProject.AllowUserToAddRows = false;
            dgvProject.AllowUserToDeleteRows = false;
            dgvProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProject.Dock = DockStyle.Fill;
            dgvProject.Location = new Point(0, 0);
            dgvProject.Name = "dgvProject";
            dgvProject.ReadOnly = true;
            dgvProject.Size = new Size(796, 304);
            dgvProject.TabIndex = 2;
            dgvProject.DoubleClick += dgvProject_DoubleClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Name = "frmMain";
            Text = "GetMan:: Projects";
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssDatabase;
        private ToolStripStatusLabel tssUser;
        private SplitContainer splitContainer1;
        private Button btnRefresh;
        private DataGridView dgvProject;
    }
}
