using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceCenter_Connect.ServiceCenterWS;

namespace ServiceCenter_Connect
{
    public partial class ListEspaces : Form
    {
        public ListEspaces()
        {
            InitializeComponent();
        }
        public ListEspaces(ServiceCenter ss)
        {
            InitializeComponent();
            _serviceCenter = ss;
            this.DialogResult = DialogResult.Cancel;
        }

        ServiceCenter _serviceCenter = null;
        List<ModuleInfo> AllItems = new List<ModuleInfo>();

        public struct eSpace {
            public string Name;
            public byte[] Data;
        }
        private eSpace _selectedData = new eSpace();
        public eSpace Selected_eSpace
        {
            get { return _selectedData; }
        }

        private void ListEspaces_Load(object sender, EventArgs e)
        {
            lst_eSpaces.Items.Clear();

            foreach (ModuleInfo m in _serviceCenter.Connection.ListEspaces(_serviceCenter.LoginInfo.Username, _serviceCenter.LoginInfo.Password))
            {
                AllItems.Add(m);

                ListViewItem itm = new ListViewItem(m.Name);
                itm.Tag = m;
                lst_eSpaces.Items.Add(itm);
            }

            this.ActiveControl = txtFilter;
        }
        private ListViewItem eSpaceItem(ModuleInfo mod)
        {
            ListViewItem itm = new ListViewItem(mod.Name);
            itm.Tag = mod;

            return itm;
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lst_eSpaces.Items.Clear();
            lst_eSpaces.Items.AddRange(
                AllItems.Where(
                i => string.IsNullOrEmpty(txtFilter.Text) || i.Name.ToLower().StartsWith(txtFilter.Text.ToLower())
                )
            .Select(c => eSpaceItem(c)).ToArray()
            );
        }

        private void lst_eSpaces_DoubleClick(object sender, EventArgs e)
        {
            if (lst_eSpaces.SelectedItems.Count > 0 && lst_eSpaces.SelectedItems[0] != null)
            {
                ListViewItem itm = lst_eSpaces.SelectedItems[0];
                DialogResult confirm =
                MessageBox.Show("Are you sure you want to download the " + itm.Text + " eSpace?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == System.Windows.Forms.DialogResult.Yes)
                {
                    ModuleInfo mod = (ModuleInfo)itm.Tag;

                    DateTime uploadDate = new DateTime();
                    string uploadUser = string.Empty;
                    bool isPublished = false;
                    HEMessage mess = new HEMessage();
                    bool success = false;

                    try
                    {
                        byte[] eSpaceData = _serviceCenter.Connection.Download(
                            _serviceCenter.LoginInfo.Username,
                            _serviceCenter.LoginInfo.Password,
                            mod.Version_Id,
                            mod.SS_Key,
                            out uploadDate,
                            out uploadUser,
                            out isPublished,
                            out mess,
                            out success);

                        if (success)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;

                            _selectedData.Name = mod.Name;
                            _selectedData.Data = eSpaceData;

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("An error ocurred: " + mess.Message, "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error ocurred: " + ex.Message, "Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
