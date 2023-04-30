using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
    /// <summary>
    /// Summary description for Contact.
    /// </summary>
    public class Contact : System.Windows.Forms.UserControl
    {

        private System.Windows.Forms.Label lbCompany;
        public System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.Label lbDivisionCost;
        private System.Windows.Forms.Label lbContactType;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbMiddleName;
        public System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lbLastName;
        public System.Windows.Forms.TextBox txtLastName;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        public System.Windows.Forms.TextBox txtContactID;
        public System.Windows.Forms.ComboBox dlDivision;
        public System.Windows.Forms.ComboBox dlContactType;
        public System.Windows.Forms.ComboBox dlDivisionCost;
        public System.Windows.Forms.ComboBox dlOutlookID;
        public System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbTitle;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        public System.Windows.Forms.TextBox txtMemo;
        public System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.Label lbRecordID;
        private System.Windows.Forms.Label lbEmail;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbFax;
        public System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lbExtension;
        public System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lbWorkPhone;
        public System.Windows.Forms.TextBox txtWorkPhone;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox dlState;
        public System.Windows.Forms.TextBox txtPostalCode;
        public System.Windows.Forms.TextBox txtPhoneCellular;
        public System.Windows.Forms.TextBox txtStAddress;
        private System.Windows.Forms.Label lbCellular;
        private System.Windows.Forms.Label lbStAddress;
        private System.Windows.Forms.Label lbRegion;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.Label lbState;
        public ComboBox dlRegion;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label lbContactTitle;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Contact()
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
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lbCompany = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.lbContactType = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
          
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dlRegion = new System.Windows.Forms.ComboBox();
            this.dlState = new System.Windows.Forms.ComboBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbRegion = new System.Windows.Forms.Label();
            this.lbStAddress = new System.Windows.Forms.Label();
            this.txtStAddress = new System.Windows.Forms.TextBox();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWorkPhone = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtPhoneCellular = new System.Windows.Forms.TextBox();
            this.lbCellular = new System.Windows.Forms.Label();
            this.lbExtension = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lbFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.lbRecordID = new System.Windows.Forms.Label();
            this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.dlOutlookID = new System.Windows.Forms.ComboBox();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.dlContactType = new System.Windows.Forms.ComboBox();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbContactTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.uiTabPage5.SuspendLayout();
            this.SuspendLayout();
// 
// txtCompany
// 
            this.txtCompany.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtCompany.AutoSize = false;
            this.txtCompany.Location = new System.Drawing.Point(128, 18);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(312, 26);
            this.txtCompany.TabIndex = 6;
// 
// lbCompany
// 
            this.lbCompany.BackColor = System.Drawing.Color.Transparent;
            this.lbCompany.Location = new System.Drawing.Point(24, 18);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(75, 16);
            this.lbCompany.TabIndex = 0;
            this.lbCompany.Text = "Company";
// 
// lbDivision
// 
            this.lbDivision.Location = new System.Drawing.Point(16, 41);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(75, 16);
            this.lbDivision.TabIndex = 0;
            this.lbDivision.Text = "Division";
// 
// lbDivisionCost
// 
            this.lbDivisionCost.Location = new System.Drawing.Point(16, 69);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(75, 16);
            this.lbDivisionCost.TabIndex = 0;
            this.lbDivisionCost.Text = "Division Cost";
// 
// lbContactType
// 
            this.lbContactType.Location = new System.Drawing.Point(16, 95);
            this.lbContactType.Name = "lbContactType";
            this.lbContactType.Size = new System.Drawing.Size(75, 24);
            this.lbContactType.TabIndex = 0;
            this.lbContactType.Text = "Contact Type";
// 
// txtFirstName
// 
            this.txtFirstName.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtFirstName.AutoSize = false;
            this.txtFirstName.Location = new System.Drawing.Point(128, 82);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 26);
            this.txtFirstName.TabIndex = 8;
// 
// lbFirstName
// 
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Location = new System.Drawing.Point(24, 82);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(75, 16);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
// 
// lbMiddleName
// 
            this.lbMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lbMiddleName.Location = new System.Drawing.Point(24, 114);
            this.lbMiddleName.Name = "lbMiddleName";
            this.lbMiddleName.Size = new System.Drawing.Size(75, 16);
            this.lbMiddleName.TabIndex = 0;
            this.lbMiddleName.Text = "Middle Name";
// 
// txtMiddleName
// 
            this.txtMiddleName.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtMiddleName.AutoSize = false;
            this.txtMiddleName.Location = new System.Drawing.Point(128, 114);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(49, 26);
            this.txtMiddleName.TabIndex = 9;
// 
// lbLastName
// 
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Location = new System.Drawing.Point(24, 146);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(75, 16);
            this.lbLastName.TabIndex = 0;
            this.lbLastName.Text = "Last Name";
// 
// txtLastName
// 
            this.txtLastName.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLastName.AutoSize = false;
            this.txtLastName.Location = new System.Drawing.Point(128, 146);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 26);
            this.txtLastName.TabIndex = 10;

            this.uiTab1.BackColor = System.Drawing.Color.Transparent;
            this.uiTab1.Controls.Add(this.uiTabPage1);
            this.uiTab1.Controls.Add(this.uiTabPage3);
            this.uiTab1.Controls.Add(this.uiTabPage4);
            this.uiTab1.Controls.Add(this.uiTabPage5);
            this.uiTab1.Location = new System.Drawing.Point(16, 119);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 3;
            this.uiTab1.Size = new System.Drawing.Size(536, 202);
            this.uiTab1.TabIndex = 1;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage3,
            this.uiTabPage4,
            this.uiTabPage5});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
// 
// uiTabPage1
// 
            this.uiTabPage1.Controls.Add(this.label13);
            this.uiTabPage1.Controls.Add(this.label12);
            this.uiTabPage1.Controls.Add(this.label11);
            this.uiTabPage1.Controls.Add(this.txtCompany);
            this.uiTabPage1.Controls.Add(this.lbCompany);
            this.uiTabPage1.Controls.Add(this.txtLastName);
            this.uiTabPage1.Controls.Add(this.lbLastName);
            this.uiTabPage1.Controls.Add(this.txtMiddleName);
            this.uiTabPage1.Controls.Add(this.lbMiddleName);
            this.uiTabPage1.Controls.Add(this.txtFirstName);
            this.uiTabPage1.Controls.Add(this.lbFirstName);
            this.uiTabPage1.Controls.Add(this.txtTitle);
            this.uiTabPage1.Controls.Add(this.lbTitle);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(534, 180);
            this.uiTabPage1.TabIndex = 5;
            this.uiTabPage1.Text = "General";
// 
// label13
// 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(302, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "*";
// 
// label12
// 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(301, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "*";
// 
// label11
// 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(448, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "*";
// 
// txtTitle
// 
            this.txtTitle.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTitle.AutoSize = false;
            this.txtTitle.Location = new System.Drawing.Point(128, 50);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(79, 26);
            this.txtTitle.TabIndex = 7;
// 
// lbTitle
// 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Location = new System.Drawing.Point(24, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(64, 16);
            this.lbTitle.TabIndex = 18;
            this.lbTitle.Text = "Title";
// 
// uiTabPage3
// 
            this.uiTabPage3.Controls.Add(this.label10);
            this.uiTabPage3.Controls.Add(this.label9);
            this.uiTabPage3.Controls.Add(this.label8);
            this.uiTabPage3.Controls.Add(this.label7);
            this.uiTabPage3.Controls.Add(this.label6);
            this.uiTabPage3.Controls.Add(this.dlRegion);
            this.uiTabPage3.Controls.Add(this.dlState);
            this.uiTabPage3.Controls.Add(this.lbState);
            this.uiTabPage3.Controls.Add(this.lbPostalCode);
            this.uiTabPage3.Controls.Add(this.txtPostalCode);
            this.uiTabPage3.Controls.Add(this.lbCity);
            this.uiTabPage3.Controls.Add(this.txtCity);
            this.uiTabPage3.Controls.Add(this.lbRegion);
            this.uiTabPage3.Controls.Add(this.lbStAddress);
            this.uiTabPage3.Controls.Add(this.txtStAddress);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(534, 180);
            this.uiTabPage3.TabIndex = 11;
            this.uiTabPage3.Text = "Contact";
// 
// label10
// 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(250, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "*";
// 
// label9
// 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(250, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "*";
// 
// label8
// 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(275, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "*";
// 
// label7
// 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(275, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "*";
// 
// label6
// 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(505, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
// 
// dlRegion
// 
            this.dlRegion.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlRegion.FormattingEnabled = true;
            this.dlRegion.Location = new System.Drawing.Point(103, 151);
            this.dlRegion.Name = "dlRegion";
            this.dlRegion.Size = new System.Drawing.Size(140, 21);
            this.dlRegion.TabIndex = 16;
            this.dlRegion.DropDown += new System.EventHandler(this.dlRegion_DropDown);
// 
// dlState
// 
            this.dlState.FormattingEnabled = true;
            this.dlState.Location = new System.Drawing.Point(104, 123);
            this.dlState.Name = "dlState";
            this.dlState.Size = new System.Drawing.Size(138, 21);
            this.dlState.TabIndex = 15;
            this.dlState.DropDown += new System.EventHandler(this.dlState_DropDown);
// 
// lbState
// 
            this.lbState.Location = new System.Drawing.Point(16, 127);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(48, 16);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "State";
// 
// lbPostalCode
// 
            this.lbPostalCode.Location = new System.Drawing.Point(16, 96);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Size = new System.Drawing.Size(75, 16);
            this.lbPostalCode.TabIndex = 0;
            this.lbPostalCode.Text = "Postal Code";
// 
// txtPostalCode
// 
            this.txtPostalCode.AutoSize = false;
            this.txtPostalCode.Location = new System.Drawing.Point(103, 90);
            this.txtPostalCode.Multiline = true;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(151, 26);
            this.txtPostalCode.TabIndex = 14;
// 
// lbCity
// 
            this.lbCity.Location = new System.Drawing.Point(16, 63);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(75, 16);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
// 
// txtCity
// 
            this.txtCity.AutoSize = false;
            this.txtCity.Location = new System.Drawing.Point(104, 59);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 26);
            this.txtCity.TabIndex = 13;
// 
// lbRegion
// 
            this.lbRegion.Location = new System.Drawing.Point(16, 155);
            this.lbRegion.Name = "lbRegion";
            this.lbRegion.Size = new System.Drawing.Size(75, 16);
            this.lbRegion.TabIndex = 0;
            this.lbRegion.Text = "Region";
// 
// lbStAddress
// 
            this.lbStAddress.Location = new System.Drawing.Point(16, 10);
            this.lbStAddress.Name = "lbStAddress";
            this.lbStAddress.Size = new System.Drawing.Size(75, 16);
            this.lbStAddress.TabIndex = 0;
            this.lbStAddress.Text = "St Address";
// 
// txtStAddress
// 
            this.txtStAddress.AutoSize = false;
            this.txtStAddress.Location = new System.Drawing.Point(104, 10);
            this.txtStAddress.Multiline = true;
            this.txtStAddress.Name = "txtStAddress";
            this.txtStAddress.Size = new System.Drawing.Size(381, 44);
            this.txtStAddress.TabIndex = 12;
// 
// uiTabPage4
// 
            this.uiTabPage4.Controls.Add(this.label14);
            this.uiTabPage4.Controls.Add(this.label4);
            this.uiTabPage4.Controls.Add(this.label3);
            this.uiTabPage4.Controls.Add(this.lbWorkPhone);
            this.uiTabPage4.Controls.Add(this.txtWorkPhone);
            this.uiTabPage4.Controls.Add(this.txtPhoneCellular);
            this.uiTabPage4.Controls.Add(this.lbCellular);
            this.uiTabPage4.Controls.Add(this.lbExtension);
            this.uiTabPage4.Controls.Add(this.txtExtension);
            this.uiTabPage4.Controls.Add(this.lbFax);
            this.uiTabPage4.Controls.Add(this.txtFax);
            this.uiTabPage4.Controls.Add(this.lbEmail);
            this.uiTabPage4.Controls.Add(this.txtEmail);
            this.uiTabPage4.Controls.Add(this.txtRecordID);
            this.uiTabPage4.Controls.Add(this.lbRecordID);
            this.uiTabPage4.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(534, 180);
            this.uiTabPage4.TabIndex = 17;
            this.uiTabPage4.Text = "Phone Numbers";
// 
// label14
// 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(280, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "*";
// 
// label4
// 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(280, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "*";
// 
// label3
// 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(280, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "*";
// 
// lbWorkPhone
// 
            this.lbWorkPhone.Location = new System.Drawing.Point(16, 19);
            this.lbWorkPhone.Name = "lbWorkPhone";
            this.lbWorkPhone.Size = new System.Drawing.Size(75, 16);
            this.lbWorkPhone.TabIndex = 0;
            this.lbWorkPhone.Text = "Work Phone";
// 
// txtWorkPhone
// 
            this.txtWorkPhone.AutoSize = false;
            this.txtWorkPhone.Location = new System.Drawing.Point(112, 16);
            this.txtWorkPhone.Multiline = true;
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(160, 26);
            this.txtWorkPhone.TabIndex = 19;
// 
// txtPhoneCellular
// 
            this.txtPhoneCellular.AutoSize = false;
            this.txtPhoneCellular.Location = new System.Drawing.Point(112, 48);
            this.txtPhoneCellular.Multiline = true;
            this.txtPhoneCellular.Name = "txtPhoneCellular";
            this.txtPhoneCellular.Size = new System.Drawing.Size(160, 26);
            this.txtPhoneCellular.TabIndex = 21;
// 
// lbCellular
// 
            this.lbCellular.Location = new System.Drawing.Point(16, 51);
            this.lbCellular.Name = "lbCellular";
            this.lbCellular.Size = new System.Drawing.Size(75, 16);
            this.lbCellular.TabIndex = 0;
            this.lbCellular.Text = "Cellular";
// 
// lbExtension
// 
            this.lbExtension.Location = new System.Drawing.Point(314, 20);
            this.lbExtension.Name = "lbExtension";
            this.lbExtension.Size = new System.Drawing.Size(75, 16);
            this.lbExtension.TabIndex = 0;
            this.lbExtension.Text = "Extension";
// 
// txtExtension
// 
            this.txtExtension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtExtension.AutoSize = false;
            this.txtExtension.Location = new System.Drawing.Point(405, 16);
            this.txtExtension.Multiline = true;
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(80, 26);
            this.txtExtension.TabIndex = 20;
// 
// lbFax
// 
            this.lbFax.Location = new System.Drawing.Point(16, 83);
            this.lbFax.Name = "lbFax";
            this.lbFax.Size = new System.Drawing.Size(56, 16);
            this.lbFax.TabIndex = 0;
            this.lbFax.Text = "Fax";
// 
// txtFax
// 
            this.txtFax.AutoSize = false;
            this.txtFax.Location = new System.Drawing.Point(112, 80);
            this.txtFax.Multiline = true;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(160, 26);
            this.txtFax.TabIndex = 22;
// 
// lbEmail
// 
            this.lbEmail.Location = new System.Drawing.Point(16, 116);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(64, 16);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
// 
// txtEmail
// 
            this.txtEmail.AutoSize = false;
            this.txtEmail.Location = new System.Drawing.Point(112, 112);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 26);
            this.txtEmail.TabIndex = 23;
// 
// txtRecordID
// 
            this.txtRecordID.AutoSize = false;
            this.txtRecordID.Location = new System.Drawing.Point(112, 145);
            this.txtRecordID.Multiline = true;
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(80, 26);
            this.txtRecordID.TabIndex = 24;
            this.txtRecordID.Text = "1";
            this.txtRecordID.Visible = false;
// 
// lbRecordID
// 
            this.lbRecordID.Location = new System.Drawing.Point(16, 150);
            this.lbRecordID.Name = "lbRecordID";
            this.lbRecordID.Size = new System.Drawing.Size(75, 16);
            this.lbRecordID.TabIndex = 0;
            this.lbRecordID.Text = "RecordID";
            this.lbRecordID.Visible = false;
// 
// uiTabPage5
// 
            this.uiTabPage5.Controls.Add(this.txtMemo);
            this.uiTabPage5.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage5.Name = "uiTabPage5";
            this.uiTabPage5.Size = new System.Drawing.Size(534, 180);
            this.uiTabPage5.TabIndex = 24;
            this.uiTabPage5.Text = "Memo";
// 
// txtMemo
// 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(14, 13);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(504, 145);
            this.txtMemo.TabIndex = 26;
// 
// dlOutlookID
// 
            this.dlOutlookID.FormattingEnabled = true;
            this.dlOutlookID.Location = new System.Drawing.Point(475, 38);
            this.dlOutlookID.Name = "dlOutlookID";
            this.dlOutlookID.Size = new System.Drawing.Size(60, 21);
            this.dlOutlookID.TabIndex = 4;
            this.dlOutlookID.Text = "1";
            this.dlOutlookID.Visible = false;
// 
// dlDivisionCost
// 
            this.dlDivisionCost.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(120, 63);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(250, 21);
            this.dlDivisionCost.TabIndex = 2;
// 
// dlContactType
// 
            this.dlContactType.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlContactType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlContactType.FormattingEnabled = true;
            this.dlContactType.Location = new System.Drawing.Point(120, 91);
            this.dlContactType.Name = "dlContactType";
            this.dlContactType.Size = new System.Drawing.Size(250, 21);
            this.dlContactType.TabIndex = 3;
           

// dlDivision
// 
            this.dlDivision.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(120, 36);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(250, 21);
            this.dlDivision.TabIndex = 1;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.Division_Select);
            this.dlDivision.DropDown += new System.EventHandler(this.dlDivision_DropDown);
// 
// txtContactID
// 
            this.txtContactID.Location = new System.Drawing.Point(471, 8);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.ReadOnly = true;
            this.txtContactID.Size = new System.Drawing.Size(64, 20);
            this.txtContactID.TabIndex = 0;
// 
// label1
// 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(377, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
// 
// label2
// 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(377, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "*";
// 
// label5
// 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(377, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
// 
// lbContactTitle
// 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbContactTitle.Location = new System.Drawing.Point(17, 10);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(76, 24);
            this.lbContactTitle.TabIndex = 51;
            this.lbContactTitle.Text = "Contact";
// 
// Contact
// 
            this.Controls.Add(this.lbContactTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlDivision);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.lbContactType);
            this.Controls.Add(this.lbDivisionCost);
            this.Controls.Add(this.dlDivisionCost);
            this.Controls.Add(this.dlContactType);
            this.Controls.Add(this.dlOutlookID);
            this.Name = "Contact";
            this.Size = new System.Drawing.Size(575, 345);

            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public void Contact_Load()
        {
            this.Visible = true;
        
             //TODO: Input Mask for phone Number, Email, Zip Code
            //TODO: set Outlook ID
            //this.dlOutlookID.DataSource =list.UserValidation();
            //this.dlOutlookID.DisplayMember="Description";
            //this.dlOutlookID.ValueMember ="Description";


            this.dlContactType.DataSource = EstimateBuilder.Builder.DataSourceContactType;
            this.dlContactType.DisplayMember = "Contract";
            this.dlContactType.ValueMember = "ContractID";

        }
        private void Division_Select(object sender, System.EventArgs e)
        {
            EstimateBuilder.ListDataProvider list = new EstimateBuilder.ListDataProvider();
            string i = "";

            if (this.dlDivision.SelectedIndex != -1)
            {
                i = this.dlDivision.SelectedValue.ToString();
            }
            else
            {
                i = this.dlDivision.Text;
            }

            this.dlDivisionCost.DataSource = list.UserValidationDivisionCost(i);
            this.dlDivisionCost.DisplayMember = "Description";
            this.dlDivisionCost.ValueMember = "Description";
            this.dlDivisionCost.Refresh();
        }


    

        void dlDivision_DropDown(object sender, EventArgs e)
        {
            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
            this.dlDivision.SelectedValue = 0;
        }

        void dlRegion_DropDown(object sender, EventArgs e)
        {

            this.dlRegion.DataSource = EstimateBuilder.Builder.DataSourceRegions;
            this.dlRegion.DisplayMember = "Region";
            this.dlRegion.ValueMember = "RegionID";
        }

        void dlState_DropDown(object sender, EventArgs e)
        {
            this.dlState.DataSource = EstimateBuilder.Builder.DataSourceUSStates;
            this.dlState.DisplayMember = "State";
            this.dlState.ValueMember = "StateID";
            this.dlState.SelectedValue = "FL";
        }
    }
}
