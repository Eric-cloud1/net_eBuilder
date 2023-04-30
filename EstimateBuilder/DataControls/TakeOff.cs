using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for TakeOff.
	/// </summary>
	public class TakeOff : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Label lbTakeOff;	

        public System.Windows.Forms.TextBox txtTakeOffID;
        public System.Windows.Forms.TextBox txtTakeOff;
        public System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lbDescription;
        public System.Windows.Forms.CheckBox chkActive;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        public TextBox txtNote;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Label lbDivisionCost;
        public ComboBox dlDivisionCost;
        private Label lbDivisionPrint;
        public ComboBox dlDivisionPrint;
        public ComboBox dlDivision;
        private Label lbDivision;
        private Label lbBuildingType;
        public ComboBox dlBuildingType;
        private Janus.Windows.UI.Tab.UITab uiTabTakeOff;
        private Label lbUnits;
        public ComboBox dlUnits;
        private Label lbInput;
        public ComboBox dlInput;
        private Label lbLocation;
        public ComboBox dlLocation;
        private Label lbMethod;
        public ComboBox dlMethod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label lbSaveToJob;
        public ComboBox dlSaveJob;
        private Label lbJobTitle;

        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TakeOff()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

	

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lbTakeOff = new System.Windows.Forms.Label();
         
            this.txtTakeOff = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTakeOffID = new System.Windows.Forms.TextBox();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbUnits = new System.Windows.Forms.Label();
            this.dlUnits = new System.Windows.Forms.ComboBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.dlInput = new System.Windows.Forms.ComboBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.dlLocation = new System.Windows.Forms.ComboBox();
            this.lbMethod = new System.Windows.Forms.Label();
            this.dlMethod = new System.Windows.Forms.ComboBox();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.lbDivisionPrint = new System.Windows.Forms.Label();
            this.dlDivisionPrint = new System.Windows.Forms.ComboBox();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbBuildingType = new System.Windows.Forms.Label();
            this.dlBuildingType = new System.Windows.Forms.ComboBox();
            this.uiTabTakeOff = new Janus.Windows.UI.Tab.UITab();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSaveToJob = new System.Windows.Forms.Label();
            this.dlSaveJob = new System.Windows.Forms.ComboBox();
            this.lbJobTitle = new System.Windows.Forms.Label();
           
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabTakeOff)).BeginInit();
            this.uiTabTakeOff.SuspendLayout();
            this.SuspendLayout();
// 
// lbTakeOff
// 
            this.lbTakeOff.BackColor = System.Drawing.Color.Transparent;
            this.lbTakeOff.Location = new System.Drawing.Point(23, 85);
            this.lbTakeOff.Name = "lbTakeOff";
            this.lbTakeOff.Size = new System.Drawing.Size(88, 16);
            this.lbTakeOff.TabIndex = 0;
            this.lbTakeOff.Text = "Take Off Values";

// 
// txtTakeOff
// 
            this.txtTakeOff.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtTakeOff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTakeOff.AutoSize = false;
            this.txtTakeOff.Location = new System.Drawing.Point(136, 76);
            this.txtTakeOff.Multiline = true;
            this.txtTakeOff.Name = "txtTakeOff";
            this.txtTakeOff.Size = new System.Drawing.Size(116, 26);
            this.txtTakeOff.TabIndex = 2;
// 
// chkActive
// 
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(438, 44);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(64, 24);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Active";
// 
// lbDescription
// 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(24, 54);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(80, 15);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
// 
// txtDescription
// 
            this.txtDescription.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtDescription.AutoSize = false;
            this.txtDescription.Location = new System.Drawing.Point(135, 43);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(256, 26);
            this.txtDescription.TabIndex = 1;
// 
// txtTakeOffID
// 
            this.txtTakeOffID.Location = new System.Drawing.Point(489, 10);
            this.txtTakeOffID.Name = "txtTakeOffID";
            this.txtTakeOffID.ReadOnly = true;
            this.txtTakeOffID.Size = new System.Drawing.Size(48, 20);
            this.txtTakeOffID.TabIndex = 0;
            this.txtTakeOffID.TabStop = false;
// 
// uiTabPage3
// 
            this.uiTabPage3.Controls.Add(this.txtNote);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(534, 178);
            this.uiTabPage3.TabIndex = 2;
            this.uiTabPage3.Text = "Memo";
// 
// txtNote
// 
            this.txtNote.AutoSize = false;
            this.txtNote.Location = new System.Drawing.Point(28, 9);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(474, 151);
            this.txtNote.TabIndex = 12;
// 
// uiTabPage1
// 
            this.uiTabPage1.Controls.Add(this.label7);
            this.uiTabPage1.Controls.Add(this.label6);
            this.uiTabPage1.Controls.Add(this.label5);
            this.uiTabPage1.Controls.Add(this.label4);
            this.uiTabPage1.Controls.Add(this.label3);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.label1);
            this.uiTabPage1.Controls.Add(this.label11);
            this.uiTabPage1.Controls.Add(this.lbUnits);
            this.uiTabPage1.Controls.Add(this.dlUnits);
            this.uiTabPage1.Controls.Add(this.lbInput);
            this.uiTabPage1.Controls.Add(this.dlInput);
            this.uiTabPage1.Controls.Add(this.lbLocation);
            this.uiTabPage1.Controls.Add(this.dlLocation);
            this.uiTabPage1.Controls.Add(this.lbMethod);
            this.uiTabPage1.Controls.Add(this.dlMethod);
            this.uiTabPage1.Controls.Add(this.lbDivisionCost);
            this.uiTabPage1.Controls.Add(this.dlDivisionCost);
            this.uiTabPage1.Controls.Add(this.lbDivisionPrint);
            this.uiTabPage1.Controls.Add(this.dlDivisionPrint);
            this.uiTabPage1.Controls.Add(this.dlDivision);
            this.uiTabPage1.Controls.Add(this.lbDivision);
            this.uiTabPage1.Controls.Add(this.lbBuildingType);
            this.uiTabPage1.Controls.Add(this.dlBuildingType);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(534, 178);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "Detail";
// 
// label7
// 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(507, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "*";
// 
// label6
// 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(507, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "*";
// 
// label5
// 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(509, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
// 
// label4
// 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(507, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "*";
// 
// label3
// 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(254, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
// 
// label2
// 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(254, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
// 
// label1
// 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(254, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
// 
// label11
// 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(254, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "*";
// 
// lbUnits
// 
            this.lbUnits.BackColor = System.Drawing.Color.Transparent;
            this.lbUnits.Location = new System.Drawing.Point(274, 31);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(32, 23);
            this.lbUnits.TabIndex = 18;
            this.lbUnits.Text = "Units";
// 
// dlUnits
// 
            this.dlUnits.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlUnits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlUnits.FormattingEnabled = true;
            this.dlUnits.Location = new System.Drawing.Point(360, 30);
            this.dlUnits.Name = "dlUnits";
            this.dlUnits.Size = new System.Drawing.Size(130, 21);
            this.dlUnits.TabIndex = 5;
            this.dlUnits.DropDown += new System.EventHandler(this.dlUnits_DropDown);
// 
// lbInput
// 
            this.lbInput.BackColor = System.Drawing.Color.Transparent;
            this.lbInput.Location = new System.Drawing.Point(31, 63);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(48, 23);
            this.lbInput.TabIndex = 17;
            this.lbInput.Text = "Input";
// 
// dlInput
// 
            this.dlInput.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlInput.FormattingEnabled = true;
            this.dlInput.Location = new System.Drawing.Point(117, 62);
            this.dlInput.Name = "dlInput";
            this.dlInput.Size = new System.Drawing.Size(130, 21);
            this.dlInput.TabIndex = 6;
            this.dlInput.DropDown +=new EventHandler(dlInput_DropDown);
// 
// lbLocation
// 
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Location = new System.Drawing.Point(31, 31);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(64, 23);
            this.lbLocation.TabIndex = 16;
            this.lbLocation.Text = "Location";
// 
// dlLocation
// 
            this.dlLocation.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlLocation.FormattingEnabled = true;
            this.dlLocation.Location = new System.Drawing.Point(117, 28);
            this.dlLocation.Name = "dlLocation";
            this.dlLocation.Size = new System.Drawing.Size(130, 21);
            this.dlLocation.TabIndex = 4;
            this.dlLocation.DropDown += new System.EventHandler(this.dlLocation_DropDown);
// 
// lbMethod
// 
            this.lbMethod.BackColor = System.Drawing.Color.Transparent;
            this.lbMethod.Location = new System.Drawing.Point(274, 129);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(48, 23);
            this.lbMethod.TabIndex = 15;
            this.lbMethod.Text = "Method";
// 
// dlMethod
// 
            this.dlMethod.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlMethod.FormattingEnabled = true;
            this.dlMethod.Location = new System.Drawing.Point(359, 126);
            this.dlMethod.Name = "dlMethod";
            this.dlMethod.Size = new System.Drawing.Size(128, 21);
            this.dlMethod.TabIndex = 11;
            this.dlMethod.DropDown += new System.EventHandler(this.dlMethod_DropDown);
// 
// lbDivisionCost
// 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(274, 96);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(79, 16);
            this.lbDivisionCost.TabIndex = 0;
            this.lbDivisionCost.Text = "Division Cost";
// 
// dlDivisionCost
// 
            this.dlDivisionCost.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(358, 95);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(130, 21);
            this.dlDivisionCost.TabIndex = 9;
// 
// lbDivisionPrint
// 
            this.lbDivisionPrint.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionPrint.Location = new System.Drawing.Point(31, 131);
            this.lbDivisionPrint.Name = "lbDivisionPrint";
            this.lbDivisionPrint.Size = new System.Drawing.Size(80, 23);
            this.lbDivisionPrint.TabIndex = 0;
            this.lbDivisionPrint.Text = "Division Print";
// 
// dlDivisionPrint
// 
            this.dlDivisionPrint.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivisionPrint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionPrint.FormattingEnabled = true;
            this.dlDivisionPrint.Location = new System.Drawing.Point(117, 128);
            this.dlDivisionPrint.Name = "dlDivisionPrint";
            this.dlDivisionPrint.Size = new System.Drawing.Size(130, 21);
            this.dlDivisionPrint.TabIndex = 10;
            this.dlDivisionPrint.DropDown += new System.EventHandler(this.dlDivisionPrint_DropDown);
// 
// dlDivision
// 
            this.dlDivision.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(117, 96);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(130, 21);
            this.dlDivision.TabIndex = 8;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.Division_Select);
            this.dlDivision.DropDown += new System.EventHandler(this.dlDivision_DropDown);
// 
// lbDivision
// 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.Location = new System.Drawing.Point(31, 96);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(71, 23);
            this.lbDivision.TabIndex = 0;
            this.lbDivision.Text = "Division";
// 
// lbBuildingType
// 
            this.lbBuildingType.BackColor = System.Drawing.Color.Transparent;
            this.lbBuildingType.Location = new System.Drawing.Point(274, 62);
            this.lbBuildingType.Name = "lbBuildingType";
            this.lbBuildingType.Size = new System.Drawing.Size(79, 16);
            this.lbBuildingType.TabIndex = 0;
            this.lbBuildingType.Text = "Building Type";
// 
// dlBuildingType
// 
            this.dlBuildingType.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlBuildingType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlBuildingType.FormattingEnabled = true;
            this.dlBuildingType.ItemHeight = 13;
            this.dlBuildingType.Location = new System.Drawing.Point(359, 61);
            this.dlBuildingType.Name = "dlBuildingType";
            this.dlBuildingType.Size = new System.Drawing.Size(130, 21);
            this.dlBuildingType.TabIndex = 7;
            this.dlBuildingType.DropDown += new System.EventHandler(this.dlBuildingType_DropDown);
// 
// uiTabTakeOff
// 
            this.uiTabTakeOff.BackColor = System.Drawing.Color.Transparent;
            this.uiTabTakeOff.Controls.Add(this.uiTabPage1);
            this.uiTabTakeOff.Controls.Add(this.uiTabPage3);
            this.uiTabTakeOff.Location = new System.Drawing.Point(14, 157);
            this.uiTabTakeOff.Name = "uiTabTakeOff";
            this.uiTabTakeOff.SelectedIndex = 0;
            this.uiTabTakeOff.Size = new System.Drawing.Size(536, 200);
            this.uiTabTakeOff.TabIndex = 15;
            this.uiTabTakeOff.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage3});
            this.uiTabTakeOff.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
// 
// label8
// 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(399, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "*";
// 
// label9
// 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(269, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "*";
// 
// lbSaveToJob
// 
            this.lbSaveToJob.BackColor = System.Drawing.Color.Transparent;
            this.lbSaveToJob.Location = new System.Drawing.Point(24, 111);
            this.lbSaveToJob.Name = "lbSaveToJob";
            this.lbSaveToJob.Size = new System.Drawing.Size(88, 16);
            this.lbSaveToJob.TabIndex = 38;
            this.lbSaveToJob.Text = "Save to Job";
// 
// dlSaveJob
// 
            this.dlSaveJob.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlSaveJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlSaveJob.FormattingEnabled = true;
            this.dlSaveJob.Location = new System.Drawing.Point(136, 107);
            this.dlSaveJob.Name = "dlSaveJob";
            this.dlSaveJob.Size = new System.Drawing.Size(130, 21);
            this.dlSaveJob.TabIndex = 3;
  
// 
// lbJobTitle
// 
            this.lbJobTitle.AutoSize = true;
            this.lbJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbJobTitle.Location = new System.Drawing.Point(29, 10);
            this.lbJobTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbJobTitle.Name = "lbJobTitle";
            this.lbJobTitle.Size = new System.Drawing.Size(78, 24);
            this.lbJobTitle.TabIndex = 117;
            this.lbJobTitle.Text = "TakeOff";
// 
// TakeOff
// 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbJobTitle);
            this.Controls.Add(this.dlSaveJob);
            this.Controls.Add(this.lbSaveToJob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTakeOffID);
            this.Controls.Add(this.uiTabTakeOff);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtTakeOff);
            this.Controls.Add(this.lbTakeOff);
            this.Controls.Add(this.chkActive);
            this.Name = "TakeOff";
            this.Size = new System.Drawing.Size(575, 416);
           
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabTakeOff)).EndInit();
            this.uiTabTakeOff.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

        void dlUnits_DropDown(object sender, EventArgs e)
        {

            this.dlUnits.DataSource = EstimateBuilder.Builder.DataSourceDivisionUnits;
            this.dlUnits.DisplayMember = "Description";
            this.dlUnits.ValueMember = "Description";
        }

     
        public void TakeOff_Load()
		{
		
			this.Visible = true;

            Random random = new Random();
            this.txtTakeOffID.Text = random.Next(999999).ToString();

            this.dlSaveJob.DataSource = EstimateBuilder.Builder.DataSourceJobIDJob;
            this.dlSaveJob.DisplayMember = "Job";
            this.dlSaveJob.ValueMember = "JobID";
            this.dlSaveJob.SelectedValue = 0;

//            this.dlDivisionCost.DataSource = EstimateBuilder.Builder.DataSourceDivisionCost;
//            this.dlDivisionCost.DisplayMember = "Description";
//            this.dlDivisionCost.ValueMember = "Description";
//            this.dlDivisionCost.SelectedValue = 0;

        }

        void dlLocation_DropDown(object sender, EventArgs e)
        {

            this.dlLocation.DataSource = EstimateBuilder.Builder.DataSourceLocation;
            this.dlLocation.DisplayMember = "Description";
            this.dlLocation.ValueMember = "Description";
        }
        void dlInput_DropDown(object sender, EventArgs e)
        {
            this.dlInput.DataSource = EstimateBuilder.Builder.DataSourceDivisionInput;
            this.dlInput.DisplayMember = "Description";
            this.dlInput.ValueMember = "Description";
            this.dlInput.SelectedValue = "Keyed";


        }

        void dlMethod_DropDown(object sender, EventArgs e)
        {
            this.dlMethod.DataSource = EstimateBuilder.Builder.DataSourceMethod;
            this.dlMethod.DisplayMember = "Description";
            this.dlMethod.ValueMember = "Description";
            this.dlMethod.SelectedValue = "Takeoff";
        }

        void dlDivisionPrint_DropDown(object sender, EventArgs e)
        {
            this.dlDivisionPrint.DataSource = EstimateBuilder.Builder.DataSourceDivisionPrint;
            this.dlDivisionPrint.DisplayMember = "Description";
            this.dlDivisionPrint.ValueMember = "Description";
        }

        void dlDivision_DropDown(object sender, EventArgs e)
        {
            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
            this.dlDivision.SelectedValue = 0;

        }
        void dlBuildingType_DropDown(object sender, EventArgs e)
        {
            this.dlBuildingType.DataSource = EstimateBuilder.Builder.DataSourceType;
            this.dlBuildingType.DisplayMember = "Description";
            this.dlBuildingType.ValueMember = "Description";
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





     
    }
}
