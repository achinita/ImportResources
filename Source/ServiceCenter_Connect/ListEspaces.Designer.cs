namespace ServiceCenter_Connect
{
    partial class ListEspaces
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
            this.lst_eSpaces = new System.Windows.Forms.ListView();
            this.eName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_eSpaces
            // 
            this.lst_eSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_eSpaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eName});
            this.lst_eSpaces.FullRowSelect = true;
            this.lst_eSpaces.Location = new System.Drawing.Point(12, 38);
            this.lst_eSpaces.Name = "lst_eSpaces";
            this.lst_eSpaces.Size = new System.Drawing.Size(533, 229);
            this.lst_eSpaces.TabIndex = 0;
            this.lst_eSpaces.UseCompatibleStateImageBehavior = false;
            this.lst_eSpaces.View = System.Windows.Forms.View.Details;
            this.lst_eSpaces.DoubleClick += new System.EventHandler(this.lst_eSpaces_DoubleClick);
            // 
            // eName
            // 
            this.eName.Text = "eSpace";
            this.eName.Width = 499;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(533, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(353, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click an eSpace to Download it";
            // 
            // ListEspaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lst_eSpaces);
            this.Name = "ListEspaces";
            this.Text = "ListEspaces";
            this.Load += new System.EventHandler(this.ListEspaces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_eSpaces;
        private System.Windows.Forms.ColumnHeader eName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
    }
}