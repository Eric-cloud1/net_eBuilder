using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using System.Text;
using System.Data;

namespace EstimateBuilderControl
{
    /// <summary>
    /// Summary description for Project.
    /// </summary>
    public class Job : System.Windows.Forms.UserControl
    {
   
        private System.Windows.Forms.Label lbLocationState;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbFinishDate;
    
        private System.Windows.Forms.Label lbEstimateID;
        private System.Windows.Forms.Label lbBuildingType;


        public System.Windows.Forms.TextBox txtStartDate;
        public System.Windows.Forms.TextBox txtFinishDate;
        public System.Windows.Forms.TextBox txtJobID;
        public ComboBox dlOwnerID;
        public ComboBox dlBuildingType;
        public ComboBox dlProjectName;
        public System.Windows.Forms.TextBox txtLocationZip;
        public System.Windows.Forms.TextBox txtDescription;
        public ComboBox dlJobIDJob;



        private Label lbJobContact;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label lbLocationZip;
        private Janus.Windows.UI.Tab.UITab uiTabEstimate;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabFavoriteVendor;
        private ListView lstVendor;
        private Button btDeleteVendor;
        private Button btAddVendor;
        protected ListView lstFavoriteVendor;
        private Label lbJobTitle;
        public ColumnHeader columnItem;
        private ColumnHeader columnFavoriteItem;
        private Label lbFavorites;
        private Label lbVendors;




        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Job()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();



        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.lbProjectName = new System.Windows.Forms.Label();
            this.lbLocationState = new System.Windows.Forms.Label();
            this.txtFinishDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbFinishDate = new System.Windows.Forms.Label();
            this.lbBuildingType = new System.Windows.Forms.Label();
            this.dlBuildingType = new System.Windows.Forms.ComboBox();
            this.lbEstimateID = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.dlOwnerID = new System.Windows.Forms.ComboBox();
            this.dlProjectName = new System.Windows.Forms.ComboBox();
            this.txtLocationZip = new System.Windows.Forms.TextBox();
            this.lbLocationZip = new System.Windows.Forms.Label();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.uiTabEstimate = new Janus.Windows.UI.Tab.UITab();
            this.uiTabFavoriteVendor = new Janus.Windows.UI.Tab.UITabPage();
            this.lbFavorites = new System.Windows.Forms.Label();
            this.lbVendors = new System.Windows.Forms.Label();
            this.btDeleteVendor = new System.Windows.Forms.Button();
            this.btAddVendor = new System.Windows.Forms.Button();
            this.lstFavoriteVendor = new System.Windows.Forms.ListView();
            this.columnFavoriteItem = new System.Windows.Forms.ColumnHeader();
            this.lstVendor = new System.Windows.Forms.ListView();
            this.columnItem = new System.Windows.Forms.ColumnHeader();
            this.lbJobContact = new System.Windows.Forms.Label();
            this.dlJobIDJob = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbJobTitle = new System.Windows.Forms.Label();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabEstimate)).BeginInit();
            this.uiTabEstimate.SuspendLayout();
            this.uiTabFavoriteVendor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjectName
            // 
            this.lbProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lbProjectName.Location = new System.Drawing.Point(24, 101);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(86, 19);
            this.lbProjectName.TabIndex = 6;
            this.lbProjectName.Text = "Project Name";
            // 
            // lbLocationState
            // 
            this.lbLocationState.Location = new System.Drawing.Point(8, 216);
            this.lbLocationState.Name = "lbLocationState";
            this.lbLocationState.Size = new System.Drawing.Size(112, 16);
            this.lbLocationState.TabIndex = 3;
            this.lbLocationState.Text = "Location State";
            // 
            // txtFinishDate
            // 
            this.txtFinishDate.Location = new System.Drawing.Point(380, 50);
            this.txtFinishDate.Name = "txtFinishDate";
            this.txtFinishDate.Size = new System.Drawing.Size(112, 20);
            this.txtFinishDate.TabIndex = 2;
            // 
            // txtStartDate
            // 
            this.txtStartDate.AutoSize = false;
            this.txtStartDate.Location = new System.Drawing.Point(134, 49);
            this.txtStartDate.Multiline = true;
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(112, 20);
            this.txtStartDate.TabIndex = 1;
            // 
            // lbOwner
            // 
            this.lbOwner.BackColor = System.Drawing.Color.Transparent;
            this.lbOwner.Location = new System.Drawing.Point(27, 77);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(72, 16);
            this.lbOwner.TabIndex = 11;
            this.lbOwner.Text = "Owner";
            // 
            // lbStartDate
            // 
            this.lbStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lbStartDate.Location = new System.Drawing.Point(24, 53);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(72, 16);
            this.lbStartDate.TabIndex = 10;
            this.lbStartDate.Text = "Start Date";
            // 
            // lbFinishDate
            // 
            this.lbFinishDate.BackColor = System.Drawing.Color.Transparent;
            this.lbFinishDate.Location = new System.Drawing.Point(280, 53);
            this.lbFinishDate.Name = "lbFinishDate";
            this.lbFinishDate.Size = new System.Drawing.Size(72, 16);
            this.lbFinishDate.TabIndex = 9;
            this.lbFinishDate.Text = "Finish Date";
            // 
            // lbBuildingType
            // 
            this.lbBuildingType.BackColor = System.Drawing.Color.Transparent;
            this.lbBuildingType.Location = new System.Drawing.Point(26, 128);
            this.lbBuildingType.Name = "lbBuildingType";
            this.lbBuildingType.Size = new System.Drawing.Size(95, 16);
            this.lbBuildingType.TabIndex = 13;
            this.lbBuildingType.Text = "Building Type";
            // 
            // dlBuildingType
            // 
            this.dlBuildingType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlBuildingType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlBuildingType.FormattingEnabled = true;
            this.dlBuildingType.Location = new System.Drawing.Point(134, 125);
            this.dlBuildingType.Name = "dlBuildingType";
            this.dlBuildingType.Size = new System.Drawing.Size(112, 21);
            this.dlBuildingType.TabIndex = 6;
            this.dlBuildingType.DropDown += new System.EventHandler(this.dlBuildingType_DropDown);
            // 
            // lbEstimateID
            // 
            this.lbEstimateID.BackColor = System.Drawing.Color.Transparent;
            this.lbEstimateID.Location = new System.Drawing.Point(281, 77);
            this.lbEstimateID.Name = "lbEstimateID";
            this.lbEstimateID.Size = new System.Drawing.Size(72, 16);
            this.lbEstimateID.TabIndex = 103;
            this.lbEstimateID.Text = "Job ID";
            // 
            // txtJobID
            // 
            this.txtJobID.AutoSize = false;
            this.txtJobID.Location = new System.Drawing.Point(380, 77);
            this.txtJobID.Multiline = true;
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(112, 19);
            this.txtJobID.TabIndex = 0;
            this.txtJobID.TabStop = false;
            // 
            // dlOwnerID
            // 
            this.dlOwnerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlOwnerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlOwnerID.FormattingEnabled = true;
            this.dlOwnerID.Location = new System.Drawing.Point(134, 74);
            this.dlOwnerID.Name = "dlOwnerID";
            this.dlOwnerID.Size = new System.Drawing.Size(112, 21);
            this.dlOwnerID.TabIndex = 3;
            // 
            // dlProjectName
            // 
            this.dlProjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlProjectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlProjectName.FormattingEnabled = true;
            this.dlProjectName.Location = new System.Drawing.Point(134, 101);
            this.dlProjectName.Name = "dlProjectName";
            this.dlProjectName.Size = new System.Drawing.Size(112, 21);
            this.dlProjectName.TabIndex = 4;
            // 
            // txtLocationZip
            // 
            this.txtLocationZip.Location = new System.Drawing.Point(380, 127);
            this.txtLocationZip.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.txtLocationZip.Name = "txtLocationZip";
            this.txtLocationZip.Size = new System.Drawing.Size(112, 20);
            this.txtLocationZip.TabIndex = 7;
            // 
            // lbLocationZip
            // 
            this.lbLocationZip.BackColor = System.Drawing.Color.Transparent;
            this.lbLocationZip.Location = new System.Drawing.Point(280, 130);
            this.lbLocationZip.Name = "lbLocationZip";
            this.lbLocationZip.Size = new System.Drawing.Size(75, 17);
            this.lbLocationZip.TabIndex = 2;
            this.lbLocationZip.Text = "Location Zip";
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.txtDescription);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(494, 149);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = false;
            this.txtDescription.Location = new System.Drawing.Point(15, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(462, 123);
            this.txtDescription.TabIndex = 8;
            // 
            // uiTabEstimate
            // 
            this.uiTabEstimate.BackColor = System.Drawing.Color.Transparent;
            this.uiTabEstimate.Controls.Add(this.uiTabPage1);
            this.uiTabEstimate.Controls.Add(this.uiTabFavoriteVendor);
            this.uiTabEstimate.Location = new System.Drawing.Point(25, 161);
            this.uiTabEstimate.Name = "uiTabEstimate";
            this.uiTabEstimate.SelectedIndex = 0;
            this.uiTabEstimate.Size = new System.Drawing.Size(496, 171);
            this.uiTabEstimate.TabIndex = 102;
            this.uiTabEstimate.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabFavoriteVendor});
            this.uiTabEstimate.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabFavoriteVendor
            // 
            this.uiTabFavoriteVendor.Controls.Add(this.lbFavorites);
            this.uiTabFavoriteVendor.Controls.Add(this.lbVendors);
            this.uiTabFavoriteVendor.Controls.Add(this.btDeleteVendor);
            this.uiTabFavoriteVendor.Controls.Add(this.btAddVendor);
            this.uiTabFavoriteVendor.Controls.Add(this.lstFavoriteVendor);
            this.uiTabFavoriteVendor.Controls.Add(this.lstVendor);
            this.uiTabFavoriteVendor.Location = new System.Drawing.Point(1, 21);
            this.uiTabFavoriteVendor.Name = "uiTabFavoriteVendor";
            this.uiTabFavoriteVendor.Size = new System.Drawing.Size(494, 149);
            this.uiTabFavoriteVendor.TabIndex = 1;
            this.uiTabFavoriteVendor.Text = "Favorites Vendors";
            // 
            // lbFavorites
            // 
            this.lbFavorites.BackColor = System.Drawing.Color.Transparent;
            this.lbFavorites.Location = new System.Drawing.Point(289, 4);
            this.lbFavorites.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbFavorites.Name = "lbFavorites";
            this.lbFavorites.Size = new System.Drawing.Size(86, 19);
            this.lbFavorites.TabIndex = 118;
            this.lbFavorites.Text = "Favorites";
            // 
            // lbVendors
            // 
            this.lbVendors.BackColor = System.Drawing.Color.Transparent;
            this.lbVendors.Location = new System.Drawing.Point(20, 4);
            this.lbVendors.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbVendors.Name = "lbVendors";
            this.lbVendors.Size = new System.Drawing.Size(86, 19);
            this.lbVendors.TabIndex = 117;
            this.lbVendors.Text = "Vendors";
            // 
            // btDeleteVendor
            // 
            this.btDeleteVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteVendor.Location = new System.Drawing.Point(215, 89);
            this.btDeleteVendor.Name = "btDeleteVendor";
            this.btDeleteVendor.Size = new System.Drawing.Size(61, 23);
            this.btDeleteVendor.TabIndex = 3;
            this.btDeleteVendor.Text = "<<";
            this.btDeleteVendor.Click += new System.EventHandler(this.btDeleteVendor_Click);
            // 
            // btAddVendor
            // 
            this.btAddVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddVendor.Location = new System.Drawing.Point(216, 45);
            this.btAddVendor.Name = "btAddVendor";
            this.btAddVendor.Size = new System.Drawing.Size(61, 23);
            this.btAddVendor.TabIndex = 2;
            this.btAddVendor.Text = ">>";
            this.btAddVendor.Click += new System.EventHandler(this.btAddVendor_Click);
            // 
            // lstFavoriteVendor
            // 
            this.lstFavoriteVendor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFavoriteItem});
            this.lstFavoriteVendor.Location = new System.Drawing.Point(289, 24);
            this.lstFavoriteVendor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lstFavoriteVendor.MultiSelect = false;
            this.lstFavoriteVendor.Name = "lstFavoriteVendor";
            this.lstFavoriteVendor.Size = new System.Drawing.Size(188, 111);
            this.lstFavoriteVendor.TabIndex = 1;
            this.lstFavoriteVendor.View = System.Windows.Forms.View.List;
            // 
            // columnFavoriteItem
            // 
            this.columnFavoriteItem.Text = "";
            this.columnFavoriteItem.Width = 188;
            // 
            // lstVendor
            // 
            this.lstVendor.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstVendor.AllowColumnReorder = true;
            this.lstVendor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItem});
            this.lstVendor.Location = new System.Drawing.Point(20, 24);
            this.lstVendor.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lstVendor.MultiSelect = false;
            this.lstVendor.Name = "lstVendor";
            this.lstVendor.Scrollable = false;
            this.lstVendor.Size = new System.Drawing.Size(187, 111);
            this.lstVendor.TabIndex = 0;
            this.lstVendor.View = System.Windows.Forms.View.List;
            // 
            // columnItem
            // 
            this.columnItem.Text = "";
            this.columnItem.Width = 180;
            // 
            // lbJobContact
            // 
            this.lbJobContact.BackColor = System.Drawing.Color.Transparent;
            this.lbJobContact.Location = new System.Drawing.Point(281, 101);
            this.lbJobContact.Name = "lbJobContact";
            this.lbJobContact.Size = new System.Drawing.Size(75, 17);
            this.lbJobContact.TabIndex = 107;
            this.lbJobContact.Text = "Job Infos";
            // 
            // dlJobIDJob
            // 
            this.dlJobIDJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlJobIDJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlJobIDJob.FormattingEnabled = true;
            this.dlJobIDJob.Location = new System.Drawing.Point(380, 101);
            this.dlJobIDJob.Name = "dlJobIDJob";
            this.dlJobIDJob.Size = new System.Drawing.Size(112, 21);
            this.dlJobIDJob.TabIndex = 5;
            this.dlJobIDJob.SelectionChangeCommitted += new System.EventHandler(this.job_Select);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(261, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 109;
            this.label11.Text = "*";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(260, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(260, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(507, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(508, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "*";
            // 
            // lbJobTitle
            // 
            this.lbJobTitle.AutoSize = true;
            this.lbJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbJobTitle.Location = new System.Drawing.Point(25, 17);
            this.lbJobTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbJobTitle.Name = "lbJobTitle";
            this.lbJobTitle.Size = new System.Drawing.Size(27, 16);
            this.lbJobTitle.TabIndex = 116;
            this.lbJobTitle.Text = "Job";
            // 
            // Job
            // 
            this.Controls.Add(this.lbJobTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dlJobIDJob);
            this.Controls.Add(this.lbJobContact);
            this.Controls.Add(this.lbLocationZip);
            this.Controls.Add(this.dlProjectName);
            this.Controls.Add(this.txtLocationZip);
            this.Controls.Add(this.dlOwnerID);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lbBuildingType);
            this.Controls.Add(this.dlBuildingType);
            this.Controls.Add(this.lbEstimateID);
            this.Controls.Add(this.uiTabEstimate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lbFinishDate);
            this.Controls.Add(this.txtFinishDate);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.lbProjectName);
            this.Name = "Job";
            this.Size = new System.Drawing.Size(575, 345);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabEstimate)).EndInit();
            this.uiTabEstimate.ResumeLayout(false);
            this.uiTabFavoriteVendor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion



        void dlBuildingType_DropDown(object sender, EventArgs e)
        {
            this.dlBuildingType.DataSource = EstimateBuilder.Builder.DataSourceType;
            this.dlBuildingType.DisplayMember = "Description";
            this.dlBuildingType.ValueMember = "Description";
        }




       protected  EstimateBuilder.ListDataProvider list = new EstimateBuilder.ListDataProvider();
        public void Job_Load()
        {
            this.Visible = true;
            this.txtStartDate.Text = System.DateTime.Now.ToString();

            this.dlProjectName.DataSource = EstimateBuilder.Builder.DataSourceProjectIDName;
            this.dlProjectName.DisplayMember = "ProjectName";
            this.dlProjectName.ValueMember = "projectID";

            this.dlOwnerID.DataSource = EstimateBuilder.Builder.DataSourceContactIDOwner;
            this.dlOwnerID.DisplayMember = "Owner";
            this.dlOwnerID.ValueMember = "ContactID";

            this.dlJobIDJob.DataSource = EstimateBuilder.Builder.DataSourceContactJobIDJob;
            this.dlJobIDJob.DisplayMember = "Job";
            this.dlJobIDJob.ValueMember = "JobID";
            this.dlJobIDJob.SelectedValue = 0;

       
            
        }

        private void job_Select(object sender, System.EventArgs e)
        {
          

            string i = "";
            if (this.dlJobIDJob.SelectedIndex != -1)
            {
                i = this.dlJobIDJob.SelectedValue.ToString();
            }
            else
            {
                i = this.dlJobIDJob.Text;
            }
            this.txtLocationZip.Text = list.getJobZipCode(i);
            list.FavoriteVendor(this.lstFavoriteVendor, i);
            list.NotFavoriteVendor(this.lstVendor, i);

          
        }

        private void btAddVendor_Click(object sender, EventArgs e)
        {
                  
            int k = lstVendor.FocusedItem.Text.IndexOf("-");
            string _id = lstVendor.FocusedItem.Text.Substring(0, k);

            string i = "";
            if (this.dlJobIDJob.SelectedIndex != -1)
            {
                i = this.dlJobIDJob.SelectedValue.ToString();
            }
            else
            {
                i = this.dlJobIDJob.Text;
            }

            list.AddFavoriteVendor(   _id, i);
            list.FavoriteVendor(this.lstFavoriteVendor, i);
            list.NotFavoriteVendor(this.lstVendor, i);

            this.lstVendor.Refresh();
            this.lstFavoriteVendor.Refresh();


         

        }

        private void btDeleteVendor_Click(object sender, EventArgs e)
        {
        
            int k = lstFavoriteVendor.FocusedItem.Text.IndexOf("-");
            string _id = lstFavoriteVendor.FocusedItem.Text.Substring(0, k);


            string i = "";
            if (this.dlJobIDJob.SelectedIndex != -1)
            {
                i = this.dlJobIDJob.SelectedValue.ToString();
            }
            else
            {
                i = this.dlJobIDJob.Text;
            }


            list.DeleteFavoriteVendor(_id, i);
            list.FavoriteVendor(this.lstFavoriteVendor, i);
            list.NotFavoriteVendor(this.lstVendor, i);

            this.lstVendor.Refresh();
            this.lstFavoriteVendor.Refresh();


       
        }

   

    }
}
