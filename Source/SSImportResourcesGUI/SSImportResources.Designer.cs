namespace SSImportResourcesGUI
{
    partial class SSImportResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSImportResources));
            this.txtSSPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOML = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.tvImages = new System.Windows.Forms.ImageList(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.btImport = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCollapse = new System.Windows.Forms.LinkLabel();
            this.lblExpandAll = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOML = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSSPath
            // 
            this.txtSSPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSSPath.Location = new System.Drawing.Point(15, 25);
            this.txtSSPath.Name = "txtSSPath";
            this.txtSSPath.ReadOnly = true;
            this.txtSSPath.Size = new System.Drawing.Size(449, 20);
            this.txtSSPath.TabIndex = 0;
            this.txtSSPath.Click += new System.EventHandler(this.txtSSPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Studio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OML";
            // 
            // txtOML
            // 
            this.txtOML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOML.Location = new System.Drawing.Point(15, 66);
            this.txtOML.Name = "txtOML";
            this.txtOML.ReadOnly = true;
            this.txtOML.Size = new System.Drawing.Size(449, 20);
            this.txtOML.TabIndex = 3;
            this.txtOML.Click += new System.EventHandler(this.txtOML_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folder";
            // 
            // txtFolder
            // 
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFolder.Location = new System.Drawing.Point(15, 107);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(449, 20);
            this.txtFolder.TabIndex = 5;
            this.txtFolder.Click += new System.EventHandler(this.txtFolder_Click);
            // 
            // tvImages
            // 
            this.tvImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvImages.ImageStream")));
            this.tvImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tvImages.Images.SetKeyName(0, "package.png");
            this.tvImages.Images.SetKeyName(1, "Document-Blank-icon.png");
            this.tvImages.Images.SetKeyName(2, "Folder-icon.png");
            this.tvImages.Images.SetKeyName(3, "ResImport.ico");
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Location = new System.Drawing.Point(467, 361);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(51, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Files: 0/0";
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btImport.Location = new System.Drawing.Point(16, 304);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(448, 23);
            this.btImport.TabIndex = 10;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(16, 333);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(448, 22);
            this.progressBar.TabIndex = 11;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 361);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "<status>";
            // 
            // lblCollapse
            // 
            this.lblCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCollapse.AutoSize = true;
            this.lblCollapse.Location = new System.Drawing.Point(818, 9);
            this.lblCollapse.Name = "lblCollapse";
            this.lblCollapse.Size = new System.Drawing.Size(61, 13);
            this.lblCollapse.TabIndex = 13;
            this.lblCollapse.TabStop = true;
            this.lblCollapse.Text = "Collapse All";
            this.lblCollapse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCollapse_LinkClicked);
            // 
            // lblExpandAll
            // 
            this.lblExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpandAll.AutoSize = true;
            this.lblExpandAll.Location = new System.Drawing.Point(761, 9);
            this.lblExpandAll.Name = "lblExpandAll";
            this.lblExpandAll.Size = new System.Drawing.Size(57, 13);
            this.lblExpandAll.TabIndex = 14;
            this.lblExpandAll.TabStop = true;
            this.lblExpandAll.Text = "Expand All";
            this.lblExpandAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExpandAll_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(806, 361);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 13);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "@ Community";
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthor_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(16, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 165);
            this.panel1.TabIndex = 17;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(-1, -1);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(448, 165);
            this.txtLog.TabIndex = 17;
            this.txtLog.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblOML);
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Location = new System.Drawing.Point(470, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 331);
            this.panel2.TabIndex = 20;
            // 
            // lblOML
            // 
            this.lblOML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOML.BackColor = System.Drawing.Color.White;
            this.lblOML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOML.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblOML.ForeColor = System.Drawing.Color.Black;
            this.lblOML.Location = new System.Drawing.Point(165, 0);
            this.lblOML.Name = "lblOML";
            this.lblOML.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOML.Size = new System.Drawing.Size(242, 19);
            this.lblOML.TabIndex = 22;
            this.lblOML.Text = "CKEditorOrOther_eSpace.OML";
            this.lblOML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.White;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(3, -1);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(213, 20);
            this.lblVersion.TabIndex = 21;
            this.lblVersion.Text = "Service Studio 8.2.4.29";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.CheckBoxes = true;
            this.treeView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.FullRowSelect = true;
            this.treeView.ImageIndex = 1;
            this.treeView.ImageList = this.tvImages;
            this.treeView.Location = new System.Drawing.Point(0, 22);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 1;
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(407, 304);
            this.treeView.TabIndex = 20;
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCheck);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // lnkGithub
            // 
            this.lnkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(573, 361);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(227, 13);
            this.lnkGithub.TabIndex = 21;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/achinita/ImportResources/";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // SSImportResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 380);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblExpandAll);
            this.Controls.Add(this.lblCollapse);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOML);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSSPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSImportResources";
            this.Text = "Import Resources";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SSImportResources_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSSPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.LinkLabel lblCollapse;
        private System.Windows.Forms.LinkLabel lblExpandAll;
        private System.Windows.Forms.LinkLabel lblAuthor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ImageList tvImages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOML;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.LinkLabel lnkGithub;
    }
}

