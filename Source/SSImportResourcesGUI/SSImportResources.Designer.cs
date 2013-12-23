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
            this.tvImages = new System.Windows.Forms.ImageList(this.components);
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSSPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.txtOML = new System.Windows.Forms.TextBox();
            this.lblExpandAll = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCollapse = new System.Windows.Forms.LinkLabel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btImport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.contextFileNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItem_DontDeploy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Deploy = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblSelectionCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextFileNode.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvImages
            // 
            this.tvImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvImages.ImageStream")));
            this.tvImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tvImages.Images.SetKeyName(0, "Actions-document-import-icon.png");
            this.tvImages.Images.SetKeyName(1, "folder-icon (1).png");
            this.tvImages.Images.SetKeyName(2, "Actions-dialog-ok-apply-icon.png");
            this.tvImages.Images.SetKeyName(3, "Actions-edit-delete-icon.png");
            this.tvImages.Images.SetKeyName(4, "eSpace.png");
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(839, 361);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(73, 13);
            this.lblAuthor.TabIndex = 15;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "@ Community";
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAuthor_LinkClicked);
            // 
            // lnkGithub
            // 
            this.lnkGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.Location = new System.Drawing.Point(562, 361);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(271, 13);
            this.lnkGithub.TabIndex = 21;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "https://github.com/achinita/ImportResources/";
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(8, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lnkDownload);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.txtSSPath);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.panel2);
            this.splitContainer.Panel1.Controls.Add(this.txtOML);
            this.splitContainer.Panel1.Controls.Add(this.lblExpandAll);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.lblCollapse);
            this.splitContainer.Panel1.Controls.Add(this.txtFolder);
            this.splitContainer.Panel1.Controls.Add(this.btImport);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panel1);
            this.splitContainer.Size = new System.Drawing.Size(908, 352);
            this.splitContainer.SplitterDistance = 452;
            this.splitContainer.TabIndex = 23;
            // 
            // lnkDownload
            // 
            this.lnkDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Location = new System.Drawing.Point(320, 56);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(127, 13);
            this.lnkDownload.TabIndex = 33;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "Download from Server";
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Service Studio:";
            // 
            // txtSSPath
            // 
            this.txtSSPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSSPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSSPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSSPath.Location = new System.Drawing.Point(103, 7);
            this.txtSSPath.Name = "txtSSPath";
            this.txtSSPath.ReadOnly = true;
            this.txtSSPath.Size = new System.Drawing.Size(344, 20);
            this.txtSSPath.TabIndex = 21;
            this.txtSSPath.Click += new System.EventHandler(this.txtSSPath_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "OML:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblVersion);
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Location = new System.Drawing.Point(5, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 188);
            this.panel2.TabIndex = 32;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.BackColor = System.Drawing.Color.White;
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(0, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVersion.Size = new System.Drawing.Size(441, 20);
            this.lblVersion.TabIndex = 24;
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
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.tvImages;
            this.treeView.Location = new System.Drawing.Point(0, 22);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 1;
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(444, 161);
            this.treeView.TabIndex = 20;
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCheck);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // txtOML
            // 
            this.txtOML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOML.Location = new System.Drawing.Point(103, 33);
            this.txtOML.Name = "txtOML";
            this.txtOML.ReadOnly = true;
            this.txtOML.Size = new System.Drawing.Size(344, 20);
            this.txtOML.TabIndex = 24;
            this.txtOML.Click += new System.EventHandler(this.txtOML_Click);
            // 
            // lblExpandAll
            // 
            this.lblExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpandAll.AutoSize = true;
            this.lblExpandAll.Location = new System.Drawing.Point(295, 103);
            this.lblExpandAll.Name = "lblExpandAll";
            this.lblExpandAll.Size = new System.Drawing.Size(67, 13);
            this.lblExpandAll.TabIndex = 31;
            this.lblExpandAll.TabStop = true;
            this.lblExpandAll.Text = "Expand All";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Folder:";
            // 
            // lblCollapse
            // 
            this.lblCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCollapse.AutoSize = true;
            this.lblCollapse.Location = new System.Drawing.Point(368, 103);
            this.lblCollapse.Name = "lblCollapse";
            this.lblCollapse.Size = new System.Drawing.Size(79, 13);
            this.lblCollapse.TabIndex = 30;
            this.lblCollapse.TabStop = true;
            this.lblCollapse.Text = "Collapse All";
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFolder.Location = new System.Drawing.Point(103, 75);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(344, 20);
            this.txtFolder.TabIndex = 26;
            this.txtFolder.Click += new System.EventHandler(this.txtFolder_Click);
            // 
            // btImport
            // 
            this.btImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btImport.Location = new System.Drawing.Point(4, 326);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(447, 23);
            this.btImport.TabIndex = 27;
            this.btImport.Text = "Import";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 342);
            this.panel1.TabIndex = 18;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(3, 1);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(443, 336);
            this.txtLog.TabIndex = 17;
            this.txtLog.Text = "";
            // 
            // contextFileNode
            // 
            this.contextFileNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_DontDeploy,
            this.mnuItem_Deploy});
            this.contextFileNode.Name = "contextFileNode";
            this.contextFileNode.Size = new System.Drawing.Size(231, 48);
            this.contextFileNode.Opening += new System.ComponentModel.CancelEventHandler(this.contextFileNode_Opening);
            // 
            // mnuItem_DontDeploy
            // 
            this.mnuItem_DontDeploy.Image = global::SSImportResourcesGUI.Properties.Resources.Export_To_File_icon;
            this.mnuItem_DontDeploy.Name = "mnuItem_DontDeploy";
            this.mnuItem_DontDeploy.Size = new System.Drawing.Size(230, 22);
            this.mnuItem_DontDeploy.Text = "Add to OML but don\'t deploy";
            this.mnuItem_DontDeploy.Click += new System.EventHandler(this.mnuItem_DontDeploy_Click);
            // 
            // mnuItem_Deploy
            // 
            this.mnuItem_Deploy.Image = global::SSImportResourcesGUI.Properties.Resources.Accept_icon;
            this.mnuItem_Deploy.Name = "mnuItem_Deploy";
            this.mnuItem_Deploy.Size = new System.Drawing.Size(230, 22);
            this.mnuItem_Deploy.Text = "Deploy to target folder";
            this.mnuItem_Deploy.Click += new System.EventHandler(this.mnuItem_Deploy_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSelectionCount,
            this.progressBar,
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 358);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 30;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblSelectionCount
            // 
            this.lblSelectionCount.Name = "lblSelectionCount";
            this.lblSelectionCount.Size = new System.Drawing.Size(24, 17);
            this.lblSelectionCount.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 16);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "<status>";
            // 
            // SSImportResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 380);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SSImportResources";
            this.Text = "Import Resources";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SSImportResources_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextFileNode.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.LinkLabel lblAuthor;
        private System.Windows.Forms.ImageList tvImages;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.LinkLabel lblExpandAll;
        private System.Windows.Forms.LinkLabel lblCollapse;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSSPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ContextMenuStrip contextFileNode;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_DontDeploy;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Deploy;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectionCount;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.LinkLabel lnkDownload;
    }
}

