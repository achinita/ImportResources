using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using ServiceCenter_Connect;

namespace SSImportResourcesGUI
{
    public partial class SSImportResources : Form
    {
        NodeInfo TreeData = new NodeInfo();
        DateTime OperationStartedOn = new DateTime();
        TreeNode _rootNode = new TreeNode("eSpace", 4, 4);

        ServiceCenter ssConnect = new ServiceCenter();

        string _rtf = @"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Consolas;}}\viewkind4\uc1\pard\lang2070\f0\fs17";


        public SSImportResources()
        {
            InitializeComponent();
        }

        private static string htmlToRtf(string html)
        {
            return html
                .Replace("<b>", @"{\b ")
                .Replace("</b>", "}")
                .Replace(Environment.NewLine,@"\par ")
                .Replace("<u>", @"{\ul ")
                .Replace("</u>", "}");
        }
        private void debug(string line)
        {
            string timestamp = 
                "<b>["+DateTime.Now.Hour.ToString().PadLeft(2, '0')+ ":" +
                DateTime.Now.Minute.ToString().PadLeft(2, '0')+":"+
                    DateTime.Now.Second.ToString().PadLeft(2,'0')+@"]</b> ";

            _rtf += htmlToRtf(timestamp + line +Environment.NewLine);
            
            txtLog.Rtf = _rtf + "}";

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
        private void getFileVersion(bool OutputSSToConsole)
        {
            bool hasSSPath = (txtSSPath.Text != "");
            bool hasOml = (txtOML.Text != "");

            string ssVersion = "";
            if (hasSSPath)
            {
                FileVersionInfo fv = FileVersionInfo.GetVersionInfo(txtSSPath.Text);
                ssVersion = fv.ProductVersion;
                if (OutputSSToConsole) debug("Using Service Studio <b>" + ssVersion + "</b>");
                lblVersion.Text = "Service Studio " + ssVersion;
            }
            else lblVersion.Text = "";

            if (hasOml)
            {
                _rootNode.Text = Path.GetFileName(txtOML.Text).Replace(Path.GetExtension(txtOML.Text),"");
            }
            else _rootNode.Text = "eSpace";
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName,
                                                string pszSubIdList);


        private void SSImportResources_Load(object sender, EventArgs e)
        {
            SetWindowTheme(treeView.Handle, "explorer", null);

            lblStatus.Text = "";
            lblVersion.Text = "";

            //Init Root Node
            _rootNode.Tag = newNodeTag(false, false, "");
            _rootNode.Expand();
            treeView.Nodes.Add(_rootNode);
            HideCheckBox(treeView, _rootNode);

            //Init Service Studio Path
            RegistryKey rk = Registry.ClassesRoot;
            RegistryKey sk = rk.OpenSubKey(@"ServiceStudio\shell\open\command");
            string tempPath = sk.GetValue("").ToString();
            txtSSPath.Text = tempPath.Substring(0, tempPath.IndexOf(" %"));
            txtSSPath.Select(txtSSPath.Text.Length, txtSSPath.Text.Length);
            txtSSPath.ScrollToCaret();
            if (txtSSPath.Text != "")
            {
                debug("Loaded Service Studio Path from registry.");
                getFileVersion(true);
            }

            Form.ActiveForm.MaximizeBox = false;
            debug("Ready.");
        }

        private void txtSSPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ssFind = new OpenFileDialog();
            ssFind.Filter = "Service Studio|ServiceStudio.exe";
            if (txtSSPath.Text != "")
            {
                ssFind.InitialDirectory = Directory.GetParent(txtSSPath.Text).ToString();
                ssFind.FileName = Path.GetFileName(txtSSPath.Text);
            }
            
            DialogResult res = ssFind.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                if (Path.GetFileName(ssFind.FileName.ToLower()) == "servicestudio.exe")
                {
                    txtSSPath.Text = ssFind.FileName;
                    getFileVersion(true);
                }
                else
                {
                    MessageBox.Show("The selected file must be Service Studio.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ssFind = new OpenFileDialog();
            ssFind.Filter = "Outsystems Markup Language Files|*.oml";
            if (txtOML.Text != "")
            {
                ssFind.InitialDirectory = Directory.GetParent(txtOML.Text).ToString();
                ssFind.FileName = Path.GetFileName(txtOML.Text);
            }

            if (ssFind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(ssFind.FileName.ToLower());
                if (ext == ".oml")
                {
                    importOML(ssFind.FileName);
                }
                else
                {
                    MessageBox.Show("The selected file isn't valid.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ssFind = new FolderBrowserDialog();
            if (txtFolder.Text != "")
            {
                ssFind.SelectedPath = txtFolder.Text;
            }
            else
            {
                if (txtOML.Text != "") ssFind.SelectedPath = Path.GetDirectoryName(txtOML.Text);
            }
            if (ssFind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFolder.Text = ssFind.SelectedPath;
                _rootNode.Nodes.Clear();

                _rootNode.Nodes.AddRange(tvFolder(txtFolder.Text, contextFileNode));
                getTreeInfo();
                _rootNode.ExpandAll();
                
            }
        }
        private void importOML (string path)
        {
            txtOML.Text = path;
            getFileVersion(false);
        }
        private void getTreeInfo()
        {
            //Folders: 0/0 | Files: 0/0
            TreeData = new NodeInfo();
            foreach (TreeNode node in treeView.Nodes)
            {
                node.ForeColor = Color.Black;
                NodeInfo subInfo = getNodeData(node);

                TreeData.selectedFiles += subInfo.selectedFiles;
                TreeData.totalFiles += subInfo.totalFiles;

            }

            UpdateFileCount();
        }
        private void UpdateFileCount()
        {
            lblSelectionCount.Text = TreeData.selectedFiles + "/" + TreeData.totalFiles;
        }
        private struct NodeInfo
        {
            public int totalFiles;
            public int selectedFiles;
        }
        private NodeInfo getNodeData(TreeNode node)
        {
            NodeInfo _out = new NodeInfo();

            if (!getNodeTag(node).isFile) HideCheckBox(treeView, node);
            else
            {
                _out.totalFiles++;
                if (node.Checked) _out.selectedFiles++;
            }

            foreach (TreeNode n in node.Nodes)
            {
                NodeInfo subInfo = getNodeData(n);

                _out.selectedFiles += subInfo.selectedFiles;
                _out.totalFiles += subInfo.totalFiles;
            }
            return _out;
        }

        #region Hide CheckBox
        private const int TVIF_STATE = 0x8;
        private const int TVIS_STATEIMAGEMASK = 0xF000;
        private const int TV_FIRST = 0x1100;
        private const int TVM_SETITEM = TV_FIRST + 63;
        private struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage;
            public int cChildren;
            public IntPtr lParam;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam,
                                                 ref TVITEM lParam);

        /// <summary>
        /// Hides the checkbox for the specified node on a TreeView control.
        /// </summary>
        private void HideCheckBox(TreeView tvw, TreeNode node)
        {
            TVITEM tvi = new TVITEM();
            tvi.hItem = node.Handle;
            tvi.mask = TVIF_STATE;
            tvi.stateMask = TVIS_STATEIMAGEMASK;
            tvi.state = 0;
            SendMessage(tvw.Handle, TVM_SETITEM, IntPtr.Zero, ref tvi);
        }
        #endregion
        private struct NodeTag
        {
            public bool isFile;
            public bool deployFile;
            public string path;
        }
        private static NodeTag newNodeTag(bool isFile, bool deploy, string path)
        {
            NodeTag _out = new NodeTag();
            _out.isFile = isFile;
            _out.deployFile = deploy;
            _out.path = path;

            return _out;
        }
        private NodeTag getNodeTag(TreeNode node)
        {
            return (NodeTag)node.Tag;
        }
        private static TreeNode[] tvFolder(string path, ContextMenuStrip menu)
        {
            string[] subDirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            TreeNode[] _out = new TreeNode[subDirs.Length + files.Length];

            int folderPos = 0;
            foreach (string s in subDirs)
            {
                TreeNode folderNode = new TreeNode(Path.GetFileName(s));
                folderNode.Expand();
                folderNode.ImageIndex = 1;
                folderNode.SelectedImageIndex = 1;
                folderNode.Checked = true;
                folderNode.Tag = newNodeTag(false, false, string.Empty);
                TreeNode[] subFolders = tvFolder(s, menu);
                if (subFolders.Length > 0) folderNode.Nodes.AddRange(subFolders);

                _out[folderPos] = folderNode;
                folderPos++;
            }
            foreach (string s in files)
            {
                TreeNode fileNode = new TreeNode("" + Path.GetFileName(s) + " (" + fileSizeUnit(s) + ")");
                
                fileNode.Checked = true;
                fileNode.ImageIndex = 2;
                fileNode.SelectedImageIndex = 2;
                fileNode.ContextMenuStrip = menu;

                fileNode.Tag = newNodeTag(true,true, s);

                _out[folderPos] = fileNode;
                folderPos++;
            }

            return _out;
        }
        private static long fileSize(string path) 
        {
            return (new FileInfo(path)).Length;
        }
        private static string fileSizeUnit(string path)
        {
            long byteCount = fileSize(path);

            decimal _conversion = byteCount / 1024 / 1024;
            if (_conversion > 1) return _conversion + "MB";

            _conversion = byteCount / 1024;
            if (_conversion > 1) return _conversion + "KB";

            return byteCount + " bytes";
        }
        private struct WorkerData
        {
            public TreeNodeCollection nodes;
            public string ServiceStudio;
            public string OML;
            public string Path;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            if (txtSSPath.Text == "") { debug("Error: No Service Studio exe defined."); hasError = true; }
            if (txtOML.Text == "") { debug("Error: No OML specified."); hasError = true; }
            if (txtFolder.Text == "") { debug("Error: No Folder specified"); hasError = true; }

            if (hasError) return;
            else
            {
                getTreeInfo(); //Reset colors and values

                btImport.Enabled = false;
                txtSSPath.Enabled = false;
                txtOML.Enabled = false;
                txtFolder.Enabled = false;

                progressBar.Maximum = TreeData.selectedFiles;
                progressBar.Value = 0;

                WorkerData param = new WorkerData();

                param.nodes = _rootNode.Nodes;
                param.OML = txtOML.Text;
                param.ServiceStudio = txtSSPath.Text;
                param.Path = txtFolder.Text;

                OperationStartedOn = DateTime.Now;

                Form.ActiveForm.Cursor = Cursors.WaitCursor;

                bgWorker.RunWorkerAsync(param);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkerData param = (WorkerData)e.Argument;
            AddResources(param.nodes, param.ServiceStudio, param.OML, param.Path);
        }
        private void AddResources(TreeNodeCollection nodes, string serviceStudio, string OML, string _Path)
        {
            foreach (TreeNode node in nodes)
            {
                if (getNodeTag(node).isFile)
                {
                    if (node.Checked)
                    {
                        NodeTag tag = getNodeTag(node);
                        string DeployPath = "." + Path.GetDirectoryName(tag.path).Replace(_Path, "");

                        Process p = new Process();
                        p.StartInfo.FileName = serviceStudio;
                        p.StartInfo.Arguments = "-importResource \"" + OML + "\" \"" + tag.path + "\"" + (tag.deployFile?" \"" + DeployPath + "\"":"");
                        bgWorker.ReportProgress(0, "Adding <b>" + Path.GetFileName(tag.path) + "</b> to " + (tag.deployFile?"<u>" + DeployPath.Replace(@"\", @"\\") + "</u>":Path.GetFileName(txtOML.Text)));
                        p.Start();
                        p.WaitForExit();
                        node.ForeColor = Color.Green;
                        bgWorker.ReportProgress(1);
                    }
                    else node.ForeColor = Color.Red;
                }
                AddResources(node.Nodes, serviceStudio, OML,_Path);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage != 0)
            {
                //Currvalue ----- ActualTS
                //Total --------- X

                progressBar.Value += 1;
                TimeSpan ts = TimeSpan.FromTicks(((TreeData.selectedFiles - progressBar.Value) * (DateTime.Now.Ticks - OperationStartedOn.Ticks)) / progressBar.Value);
                lblStatus.Text = 
                    Math.Round((Double)((progressBar.Value * 100) / progressBar.Maximum), 2).ToString() + "% (" + TimeSpanToText(ts) + " left)";
            }
            else { 
                if (e.UserState != null) debug(e.UserState.ToString()); 
            }
        }
        private static string TimeSpanToText(TimeSpan ts) 
        {
            return (ts.Hours > 0 ? (ts.Hours + " hours ") : null) +
                (ts.Minutes > 0 ? ts.Minutes + " minutes " : null) +
                (ts.Seconds > 0 ? ts.Seconds + " seconds " : null) +
                ((ts.Hours == 0 && ts.Minutes==0 && ts.Seconds == 0)?ts.Milliseconds + " miliseconds":null);
        }
        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            debug("Batch finished. Imported " + progressBar.Maximum + " files.");
            TimeSpan took = TimeSpan.FromTicks(DateTime.Now.Ticks - OperationStartedOn.Ticks);

            debug("Operation took " + TimeSpanToText(took));

            btImport.Enabled = true;
            txtSSPath.Enabled = true;
            txtOML.Enabled = true;
            txtFolder.Enabled = true;

            Form.ActiveForm.Cursor = Cursors.Default;
        }

        private void lblCollapse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            treeView.CollapseAll();
        }

        private void lblExpandAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            treeView.ExpandAll();
        }

        private void lblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.outsystems.com/forums/discussion/11187/tool-batch-import-resources/");
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (getNodeTag(e.Node).isFile)
            {
                if (!bgWorker.IsBusy) e.Node.Checked = !e.Node.Checked;

                if (e.Node.Checked) TreeData.selectedFiles++;
                else TreeData.selectedFiles--;

                UpdateFileCount();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
      
            CloseCancel(e, bgWorker.IsBusy);
        }

        public static void CloseCancel(FormClosingEventArgs  e, bool showConfirm)
        {
            if (showConfirm)
            {
                var result = MessageBox.Show(
                    "The operation already modified some of your OML." + Environment.NewLine +
                    "Exiting the program won't undo these changes to your file." + Environment.NewLine +
                    Environment.NewLine + "Are you sure that you want to stop the operation?", "Stop Import",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                e.Cancel = (result == DialogResult.No);
            }
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/achinita/ImportResources/");
        }

        private void mnuItem_DontDeploy_Click(object sender, EventArgs e)
        {
            NodeTag d = getNodeTag(treeView.SelectedNode);
            d.deployFile = false;
            treeView.SelectedNode.Tag = d;

            int imgIndex = (treeView.SelectedNode.Checked ? 0 : 3);
            treeView.SelectedNode.ImageIndex = imgIndex;
            treeView.SelectedNode.SelectedImageIndex = imgIndex;
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode = e.Node;
        }
        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (getNodeTag(e.Node).isFile)
            {
                if (bgWorker.IsBusy) e.Node.Checked = !e.Node.Checked;
                else
                {
                    if (e.Node.Checked)
                    {
                        TreeData.selectedFiles++;

                        int imgIndex = getNodeTag(e.Node).deployFile ? 2 : 0;

                        e.Node.ImageIndex = imgIndex;
                        e.Node.SelectedImageIndex = imgIndex;
                    }
                    else
                    {
                        TreeData.selectedFiles--;
                        e.Node.ImageIndex = 3;
                        e.Node.SelectedImageIndex = 3;
                    }
                    UpdateFileCount();
                }
                treeView.SelectedNode = e.Node;
            }
        }

        private void contextFileNode_Opening(object sender, CancelEventArgs e)
        {
            NodeTag d = getNodeTag(treeView.SelectedNode);
            if (d.deployFile)
            {
                mnuItem_DontDeploy.Visible = true;
                mnuItem_Deploy.Visible = false;
            }
            else
            {
                mnuItem_DontDeploy.Visible = false;
                mnuItem_Deploy.Visible = true;
            }
        }

        private void mnuItem_Deploy_Click(object sender, EventArgs e)
        {
            NodeTag d = getNodeTag(treeView.SelectedNode);
            d.deployFile = true;
            treeView.SelectedNode.Tag = d;

            int imgIndex = (treeView.SelectedNode.Checked ? 2 : 3);
            treeView.SelectedNode.ImageIndex = imgIndex;
            treeView.SelectedNode.SelectedImageIndex = imgIndex;
        }

        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string importPath = ssConnect.SelectEspace();

            if (importPath != null)
            {
                importOML(importPath);
                debug("Downloaded file <b>" + Path.GetFileName(importPath) + "</b> from " + ssConnect.LoginInfo.Hostname);
            }
        }
    }
}
