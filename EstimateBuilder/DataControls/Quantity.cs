using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for Quantity.
	/// </summary>
	public class Quantity : System.Windows.Forms.UserControl
	{
		
		private System.Windows.Forms.Label lbExpression;
		private System.Windows.Forms.Label lbAssembly;
		private Janus.Windows.UI.Tab.UITab uiTab1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.Label lbLocation;
		private System.Windows.Forms.Label lbDivisionCost;
		private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.Label lbUnits;


        public System.Windows.Forms.ComboBox dlExpression;
        public System.Windows.Forms.ComboBox dlAssembly;
        public System.Windows.Forms.CheckBox chkActive;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtQuantityID;
        public System.Windows.Forms.TextBox txtMemo;
        public ComboBox dlDivisionCost;
        public ComboBox dlDivision;
        public ComboBox dlLocation;
        public ComboBox dlUnits;
        private Label lbCostItem;
        public ComboBox dlCostItem;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbSelectJobID;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Label label19;
        private Label label14;
        public ComboBox dlReportPhase;
        public ComboBox dlReportContract;
        private Label lbReportContract;
        private Label lbReportPhase;
        private Label label23;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label lbQuantityWaste;
        public TextBox txtQuantityWaste;
        private Label lbQuantityRundUp;
        public TextBox txtQuantityRoundUp;
        private Label lbQuantityReuse;
        public TextBox txtQuantityReuse;
        private Label lbQuanityAdjusted;
        public TextBox txtQuantityAdjusted;
        private Label lbUnitOrder;
        public TextBox txtUnitOrder;
        public ComboBox dlJobID;
        private Label label1;
        public ComboBox dlDivisionPrint;
        private Label lbDivisionPrint;
        private Label lbQuantityTitle;
        private Label lbAdjustment;
        private Label label13;
        public ComboBox dlAccounting;
        private Label lbAccounting;



        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Quantity()
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dlAssembly = new System.Windows.Forms.ComboBox();
            this.dlExpression = new System.Windows.Forms.ComboBox();
            this.lbAssembly = new System.Windows.Forms.Label();
            this.lbExpression = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lbUnits = new System.Windows.Forms.Label();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.lbAdjustment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dlDivisionPrint = new System.Windows.Forms.ComboBox();
            this.lbDivisionPrint = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dlReportPhase = new System.Windows.Forms.ComboBox();
            this.dlReportContract = new System.Windows.Forms.ComboBox();
            this.lbReportContract = new System.Windows.Forms.Label();
            this.lbReportPhase = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbQuantityWaste = new System.Windows.Forms.Label();
            this.txtQuantityWaste = new System.Windows.Forms.TextBox();
            this.lbQuantityRundUp = new System.Windows.Forms.Label();
            this.txtQuantityRoundUp = new System.Windows.Forms.TextBox();
            this.lbQuantityReuse = new System.Windows.Forms.Label();
            this.txtQuantityReuse = new System.Windows.Forms.TextBox();
            this.lbQuanityAdjusted = new System.Windows.Forms.Label();
            this.txtQuantityAdjusted = new System.Windows.Forms.TextBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.dlJobID = new System.Windows.Forms.ComboBox();
            this.lbUnitOrder = new System.Windows.Forms.Label();
            this.lbSelectJobID = new System.Windows.Forms.Label();
            this.txtUnitOrder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCostItem = new System.Windows.Forms.Label();
            this.dlLocation = new System.Windows.Forms.ComboBox();
            this.dlCostItem = new System.Windows.Forms.ComboBox();
            this.dlUnits = new System.Windows.Forms.ComboBox();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtQuantityID = new System.Windows.Forms.TextBox();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbQuantityTitle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dlAccounting = new System.Windows.Forms.ComboBox();
            this.lbAccounting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = false;
            this.txtDescription.Location = new System.Drawing.Point(120, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(244, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // dlAssembly
            // 
            this.dlAssembly.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlAssembly.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlAssembly.FormattingEnabled = true;
            this.dlAssembly.Location = new System.Drawing.Point(135, 139);
            this.dlAssembly.Name = "dlAssembly";
            this.dlAssembly.Size = new System.Drawing.Size(192, 21);
            this.dlAssembly.TabIndex = 15;
            // 
            // dlExpression
            // 
            this.dlExpression.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlExpression.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlExpression.FormattingEnabled = true;
            this.dlExpression.Location = new System.Drawing.Point(135, 110);
            this.dlExpression.Name = "dlExpression";
            this.dlExpression.Size = new System.Drawing.Size(192, 21);
            this.dlExpression.TabIndex = 14;
            // 
            // lbAssembly
            // 
            this.lbAssembly.BackColor = System.Drawing.Color.Transparent;
            this.lbAssembly.Location = new System.Drawing.Point(47, 139);
            this.lbAssembly.Name = "lbAssembly";
            this.lbAssembly.Size = new System.Drawing.Size(64, 16);
            this.lbAssembly.TabIndex = 0;
            this.lbAssembly.Text = "Assembly ";
            // 
            // lbExpression
            // 
            this.lbExpression.BackColor = System.Drawing.Color.Transparent;
            this.lbExpression.Location = new System.Drawing.Point(47, 110);
            this.lbExpression.Name = "lbExpression";
            this.lbExpression.Size = new System.Drawing.Size(64, 16);
            this.lbExpression.TabIndex = 0;
            this.lbExpression.Text = "Expression";
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(40, 45);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(64, 16);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // lbLocation
            // 
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Location = new System.Drawing.Point(47, 47);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(64, 16);
            this.lbLocation.TabIndex = 0;
            this.lbLocation.Text = "Location";
            // 
            // lbDivisionCost
            // 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(42, 96);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(72, 16);
            this.lbDivisionCost.TabIndex = 0;
            this.lbDivisionCost.Text = "Division Cost";
            // 
            // lbDivision
            // 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.Location = new System.Drawing.Point(40, 76);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(64, 16);
            this.lbDivision.TabIndex = 0;
            this.lbDivision.Text = "Division";
            // 
            // chkActive
            // 
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(405, 41);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(72, 24);
            this.chkActive.TabIndex = 16;
            this.chkActive.Text = "Active";
            // 
            // lbUnits
            // 
            this.lbUnits.BackColor = System.Drawing.Color.Transparent;
            this.lbUnits.Location = new System.Drawing.Point(47, 20);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(48, 16);
            this.lbUnits.TabIndex = 0;
            this.lbUnits.Text = "Units";
            // 
            // uiTab1
            // 
            this.uiTab1.BackColor = System.Drawing.Color.Transparent;
            this.uiTab1.Controls.Add(this.uiTabPage2);
            this.uiTab1.Controls.Add(this.uiTabPage1);
            this.uiTab1.Controls.Add(this.uiTabPage3);
            this.uiTab1.Location = new System.Drawing.Point(16, 125);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 0;
            this.uiTab1.Size = new System.Drawing.Size(528, 213);
            this.uiTab1.TabIndex = 13;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage1,
            this.uiTabPage3});
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.lbAdjustment);
            this.uiTabPage2.Controls.Add(this.label1);
            this.uiTabPage2.Controls.Add(this.dlDivisionPrint);
            this.uiTabPage2.Controls.Add(this.lbDivisionPrint);
            this.uiTabPage2.Controls.Add(this.label19);
            this.uiTabPage2.Controls.Add(this.label14);
            this.uiTabPage2.Controls.Add(this.dlReportPhase);
            this.uiTabPage2.Controls.Add(this.dlReportContract);
            this.uiTabPage2.Controls.Add(this.lbReportContract);
            this.uiTabPage2.Controls.Add(this.lbReportPhase);
            this.uiTabPage2.Controls.Add(this.label23);
            this.uiTabPage2.Controls.Add(this.label7);
            this.uiTabPage2.Controls.Add(this.label11);
            this.uiTabPage2.Controls.Add(this.label12);
            this.uiTabPage2.Controls.Add(this.lbQuantityWaste);
            this.uiTabPage2.Controls.Add(this.txtQuantityWaste);
            this.uiTabPage2.Controls.Add(this.lbQuantityRundUp);
            this.uiTabPage2.Controls.Add(this.txtQuantityRoundUp);
            this.uiTabPage2.Controls.Add(this.lbQuantityReuse);
            this.uiTabPage2.Controls.Add(this.txtQuantityReuse);
            this.uiTabPage2.Controls.Add(this.lbQuanityAdjusted);
            this.uiTabPage2.Controls.Add(this.txtQuantityAdjusted);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(526, 191);
            this.uiTabPage2.TabIndex = 3;
            this.uiTabPage2.Text = "Adjustment";
            // 
            // lbAdjustment
            // 
            this.lbAdjustment.AutoSize = true;
            this.lbAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdjustment.Location = new System.Drawing.Point(35, 100);
            this.lbAdjustment.Name = "lbAdjustment";
            this.lbAdjustment.Size = new System.Drawing.Size(106, 20);
            this.lbAdjustment.TabIndex = 58;
            this.lbAdjustment.Text = "Adjustement";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "*";
            // 
            // dlDivisionPrint
            // 
            this.dlDivisionPrint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlDivisionPrint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionPrint.FormattingEnabled = true;
            this.dlDivisionPrint.Location = new System.Drawing.Point(155, 12);
            this.dlDivisionPrint.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.dlDivisionPrint.Name = "dlDivisionPrint";
            this.dlDivisionPrint.Size = new System.Drawing.Size(192, 21);
            this.dlDivisionPrint.TabIndex = 4;
            this.dlDivisionPrint.DropDown += new System.EventHandler(this.dlDivisionPrint_DropDown);
            // 
            // lbDivisionPrint
            // 
            this.lbDivisionPrint.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionPrint.Location = new System.Drawing.Point(30, 17);
            this.lbDivisionPrint.Name = "lbDivisionPrint";
            this.lbDivisionPrint.Size = new System.Drawing.Size(72, 16);
            this.lbDivisionPrint.TabIndex = 55;
            this.lbDivisionPrint.Text = "Division Print";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(447, 69);
            this.label19.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "*";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(445, 43);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "*";
            // 
            // dlReportPhase
            // 
            this.dlReportPhase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlReportPhase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlReportPhase.FormattingEnabled = true;
            this.dlReportPhase.Location = new System.Drawing.Point(155, 68);
            this.dlReportPhase.Name = "dlReportPhase";
            this.dlReportPhase.Size = new System.Drawing.Size(272, 21);
            this.dlReportPhase.TabIndex = 6;
            this.dlReportPhase.DropDown += new System.EventHandler(this.dlReportPhase_DropDown);
            // 
            // dlReportContract
            // 
            this.dlReportContract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlReportContract.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlReportContract.FormattingEnabled = true;
            this.dlReportContract.Location = new System.Drawing.Point(155, 39);
            this.dlReportContract.Name = "dlReportContract";
            this.dlReportContract.Size = new System.Drawing.Size(272, 21);
            this.dlReportContract.TabIndex = 5;
            this.dlReportContract.DropDown += new System.EventHandler(this.dlReportContract_DropDown);
            // 
            // lbReportContract
            // 
            this.lbReportContract.BackColor = System.Drawing.Color.Transparent;
            this.lbReportContract.Location = new System.Drawing.Point(31, 44);
            this.lbReportContract.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lbReportContract.Name = "lbReportContract";
            this.lbReportContract.Size = new System.Drawing.Size(103, 16);
            this.lbReportContract.TabIndex = 51;
            this.lbReportContract.Text = "Report Contract";
            // 
            // lbReportPhase
            // 
            this.lbReportPhase.BackColor = System.Drawing.Color.Transparent;
            this.lbReportPhase.Location = new System.Drawing.Point(30, 73);
            this.lbReportPhase.Name = "lbReportPhase";
            this.lbReportPhase.Size = new System.Drawing.Size(98, 16);
            this.lbReportPhase.TabIndex = 52;
            this.lbReportPhase.Text = "Report Phase";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(223, 156);
            this.label23.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "*";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(438, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "*";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(438, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(216, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "*";
            // 
            // lbQuantityWaste
            // 
            this.lbQuantityWaste.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantityWaste.Location = new System.Drawing.Point(258, 159);
            this.lbQuantityWaste.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lbQuantityWaste.Name = "lbQuantityWaste";
            this.lbQuantityWaste.Size = new System.Drawing.Size(92, 16);
            this.lbQuantityWaste.TabIndex = 44;
            this.lbQuantityWaste.Text = "Quantity Waste";
            // 
            // txtQuantityWaste
            // 
            this.txtQuantityWaste.AutoSize = false;
            this.txtQuantityWaste.Location = new System.Drawing.Point(353, 156);
            this.txtQuantityWaste.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtQuantityWaste.Multiline = true;
            this.txtQuantityWaste.Name = "txtQuantityWaste";
            this.txtQuantityWaste.Size = new System.Drawing.Size(74, 26);
            this.txtQuantityWaste.TabIndex = 10;
            this.txtQuantityWaste.Text = "1";
            // 
            // lbQuantityRundUp
            // 
            this.lbQuantityRundUp.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantityRundUp.Location = new System.Drawing.Point(256, 130);
            this.lbQuantityRundUp.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lbQuantityRundUp.Name = "lbQuantityRundUp";
            this.lbQuantityRundUp.Size = new System.Drawing.Size(94, 16);
            this.lbQuantityRundUp.TabIndex = 43;
            this.lbQuantityRundUp.Text = "Quantity Round Up";
            // 
            // txtQuantityRoundUp
            // 
            this.txtQuantityRoundUp.AutoSize = false;
            this.txtQuantityRoundUp.Location = new System.Drawing.Point(352, 123);
            this.txtQuantityRoundUp.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtQuantityRoundUp.Multiline = true;
            this.txtQuantityRoundUp.Name = "txtQuantityRoundUp";
            this.txtQuantityRoundUp.Size = new System.Drawing.Size(75, 26);
            this.txtQuantityRoundUp.TabIndex = 8;
            this.txtQuantityRoundUp.Text = "0";
            // 
            // lbQuantityReuse
            // 
            this.lbQuantityReuse.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantityReuse.Location = new System.Drawing.Point(41, 126);
            this.lbQuantityReuse.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbQuantityReuse.Name = "lbQuantityReuse";
            this.lbQuantityReuse.Size = new System.Drawing.Size(87, 16);
            this.lbQuantityReuse.TabIndex = 42;
            this.lbQuantityReuse.Text = "Quantity Reuse";
            // 
            // txtQuantityReuse
            // 
            this.txtQuantityReuse.AutoSize = false;
            this.txtQuantityReuse.Location = new System.Drawing.Point(139, 119);
            this.txtQuantityReuse.Margin = new System.Windows.Forms.Padding(2, 3, 1, 3);
            this.txtQuantityReuse.Multiline = true;
            this.txtQuantityReuse.Name = "txtQuantityReuse";
            this.txtQuantityReuse.Size = new System.Drawing.Size(65, 26);
            this.txtQuantityReuse.TabIndex = 7;
            this.txtQuantityReuse.Text = "1";
            // 
            // lbQuanityAdjusted
            // 
            this.lbQuanityAdjusted.BackColor = System.Drawing.Color.Transparent;
            this.lbQuanityAdjusted.Location = new System.Drawing.Point(40, 156);
            this.lbQuanityAdjusted.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbQuanityAdjusted.Name = "lbQuanityAdjusted";
            this.lbQuanityAdjusted.Size = new System.Drawing.Size(95, 16);
            this.lbQuanityAdjusted.TabIndex = 37;
            this.lbQuanityAdjusted.Text = "Quantity Adjusted";
            // 
            // txtQuantityAdjusted
            // 
            this.txtQuantityAdjusted.AutoSize = false;
            this.txtQuantityAdjusted.Location = new System.Drawing.Point(139, 153);
            this.txtQuantityAdjusted.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtQuantityAdjusted.Multiline = true;
            this.txtQuantityAdjusted.Name = "txtQuantityAdjusted";
            this.txtQuantityAdjusted.Size = new System.Drawing.Size(66, 26);
            this.txtQuantityAdjusted.TabIndex = 9;
            this.txtQuantityAdjusted.Text = "1";
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.dlJobID);
            this.uiTabPage1.Controls.Add(this.lbUnitOrder);
            this.uiTabPage1.Controls.Add(this.lbSelectJobID);
            this.uiTabPage1.Controls.Add(this.txtUnitOrder);
            this.uiTabPage1.Controls.Add(this.label6);
            this.uiTabPage1.Controls.Add(this.label5);
            this.uiTabPage1.Controls.Add(this.label4);
            this.uiTabPage1.Controls.Add(this.label3);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.lbCostItem);
            this.uiTabPage1.Controls.Add(this.dlLocation);
            this.uiTabPage1.Controls.Add(this.dlCostItem);
            this.uiTabPage1.Controls.Add(this.dlUnits);
            this.uiTabPage1.Controls.Add(this.lbUnits);
            this.uiTabPage1.Controls.Add(this.lbLocation);
            this.uiTabPage1.Controls.Add(this.dlExpression);
            this.uiTabPage1.Controls.Add(this.lbExpression);
            this.uiTabPage1.Controls.Add(this.lbAssembly);
            this.uiTabPage1.Controls.Add(this.dlAssembly);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(526, 191);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "Detail";
            // 
            // dlJobID
            // 
            this.dlJobID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlJobID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlJobID.FormattingEnabled = true;
            this.dlJobID.Location = new System.Drawing.Point(134, 76);
            this.dlJobID.Name = "dlJobID";
            this.dlJobID.Size = new System.Drawing.Size(193, 21);
            this.dlJobID.TabIndex = 13;
            this.dlJobID.SelectionChangeCommitted += new System.EventHandler(this.dlJobID_SelectionChangeCommitted);
            // 
            // lbUnitOrder
            // 
            this.lbUnitOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbUnitOrder.Location = new System.Drawing.Point(360, 93);
            this.lbUnitOrder.Name = "lbUnitOrder";
            this.lbUnitOrder.Size = new System.Drawing.Size(98, 16);
            this.lbUnitOrder.TabIndex = 36;
            this.lbUnitOrder.Text = "Unit Order";
            // 
            // lbSelectJobID
            // 
            this.lbSelectJobID.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectJobID.Location = new System.Drawing.Point(45, 78);
            this.lbSelectJobID.Name = "lbSelectJobID";
            this.lbSelectJobID.Size = new System.Drawing.Size(80, 16);
            this.lbSelectJobID.TabIndex = 35;
            this.lbSelectJobID.Text = "Select Job";
            // 
            // txtUnitOrder
            // 
            this.txtUnitOrder.AutoSize = false;
            this.txtUnitOrder.Location = new System.Drawing.Point(360, 119);
            this.txtUnitOrder.Multiline = true;
            this.txtUnitOrder.Name = "txtUnitOrder";
            this.txtUnitOrder.ReadOnly = true;
            this.txtUnitOrder.Size = new System.Drawing.Size(139, 26);
            this.txtUnitOrder.TabIndex = 36;
            this.txtUnitOrder.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(510, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(334, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(334, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(334, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(334, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "*";
            // 
            // lbCostItem
            // 
            this.lbCostItem.BackColor = System.Drawing.Color.Transparent;
            this.lbCostItem.Location = new System.Drawing.Point(360, 39);
            this.lbCostItem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbCostItem.Name = "lbCostItem";
            this.lbCostItem.Size = new System.Drawing.Size(80, 16);
            this.lbCostItem.TabIndex = 18;
            this.lbCostItem.Text = "Cost Item";
            // 
            // dlLocation
            // 
            this.dlLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlLocation.FormattingEnabled = true;
            this.dlLocation.Location = new System.Drawing.Point(135, 44);
            this.dlLocation.Name = "dlLocation";
            this.dlLocation.Size = new System.Drawing.Size(192, 21);
            this.dlLocation.TabIndex = 12;
            this.dlLocation.DropDown += new System.EventHandler(this.dlLocation_DropDown);
            // 
            // dlCostItem
            // 
            this.dlCostItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlCostItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlCostItem.FormattingEnabled = true;
            this.dlCostItem.Location = new System.Drawing.Point(360, 56);
            this.dlCostItem.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dlCostItem.Name = "dlCostItem";
            this.dlCostItem.Size = new System.Drawing.Size(144, 21);
            this.dlCostItem.TabIndex = 17;
            this.dlCostItem.SelectionChangeCommitted += new System.EventHandler(this.dlCostItem_SelectionChangeCommitted);
            // 
            // dlUnits
            // 
            this.dlUnits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlUnits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlUnits.FormattingEnabled = true;
            this.dlUnits.Location = new System.Drawing.Point(135, 15);
            this.dlUnits.Name = "dlUnits";
            this.dlUnits.Size = new System.Drawing.Size(192, 21);
            this.dlUnits.TabIndex = 11;
            this.dlUnits.DropDown += new System.EventHandler(this.dlUnits_DropDown);
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.txtMemo);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(526, 191);
            this.uiTabPage3.TabIndex = 2;
            this.uiTabPage3.Text = "Memo";
            // 
            // txtMemo
            // 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(23, 8);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(468, 171);
            this.txtMemo.TabIndex = 15;
            this.txtMemo.TabStop = false;
            // 
            // txtQuantityID
            // 
            this.txtQuantityID.Location = new System.Drawing.Point(516, 14);
            this.txtQuantityID.Name = "txtQuantityID";
            this.txtQuantityID.ReadOnly = true;
            this.txtQuantityID.Size = new System.Drawing.Size(37, 20);
            this.txtQuantityID.TabIndex = 0;
            this.txtQuantityID.TabStop = false;
            // 
            // dlDivision
            // 
            this.dlDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(120, 71);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(171, 21);
            this.dlDivision.TabIndex = 2;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.Division_Select);
            this.dlDivision.DropDown += new System.EventHandler(this.dlDivision_DropDown);
            // 
            // dlDivisionCost
            // 
            this.dlDivisionCost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(119, 96);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(172, 21);
            this.dlDivisionCost.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(377, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(298, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(298, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "*";
            // 
            // lbQuantityTitle
            // 
            this.lbQuantityTitle.AutoSize = true;
            this.lbQuantityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbQuantityTitle.Location = new System.Drawing.Point(21, 10);
            this.lbQuantityTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbQuantityTitle.Name = "lbQuantityTitle";
            this.lbQuantityTitle.Size = new System.Drawing.Size(58, 16);
            this.lbQuantityTitle.TabIndex = 118;
            this.lbQuantityTitle.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(543, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "*";
            // 
            // dlAccounting
            // 
            this.dlAccounting.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlAccounting.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlAccounting.FormattingEnabled = true;
            this.dlAccounting.Location = new System.Drawing.Point(379, 72);
            this.dlAccounting.Name = "dlAccounting";
            this.dlAccounting.Size = new System.Drawing.Size(158, 21);
            this.dlAccounting.TabIndex = 120;
            this.dlAccounting.DropDown += new System.EventHandler(this.dlAccounting_DropDown);
            // 
            // lbAccounting
            // 
            this.lbAccounting.BackColor = System.Drawing.Color.Transparent;
            this.lbAccounting.Location = new System.Drawing.Point(317, 74);
            this.lbAccounting.Name = "lbAccounting";
            this.lbAccounting.Size = new System.Drawing.Size(69, 16);
            this.lbAccounting.TabIndex = 119;
            this.lbAccounting.Text = "Accounting";
            // 
            // Quantity
            // 
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dlAccounting);
            this.Controls.Add(this.lbAccounting);
            this.Controls.Add(this.lbQuantityTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dlDivisionCost);
            this.Controls.Add(this.dlDivision);
            this.Controls.Add(this.txtQuantityID);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.lbDivisionCost);
            this.Controls.Add(this.chkActive);
            this.Name = "Quantity";
            this.Size = new System.Drawing.Size(575, 345);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage2.PerformLayout();
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
		#endregion

		public void Quantity_Load()
		{
			this.Visible = true;

            this.dlAssembly.DataSource = EstimateBuilder.Builder.DataSourceAssemblyIDName;
            this.dlAssembly.DisplayMember = "Name";
            this.dlAssembly.ValueMember = "AssemblyID";

            this.dlJobID.DataSource = EstimateBuilder.Builder.DataSourceJobIDJob;
            this.dlJobID.DisplayMember = "Job";
            this.dlJobID.ValueMember = "JobID";
            this.dlJobID.SelectedValue = 0;

       

            this.dlCostItem.DataSource = EstimateBuilder.Builder.DataSourceCostItemIDDesc;
            this.dlCostItem.DisplayMember = "Description";
            this.dlCostItem.ValueMember = "CostItemID";
            this.dlCostItem.SelectedValue = 0;

        }

        void dlAccounting_DropDown(object sender, EventArgs e)
        {
            this.dlAccounting.DataSource = EstimateBuilder.Builder.DataSourceAccounting;
            this.dlAccounting.DisplayMember = "Description";
            this.dlAccounting.ValueMember = "Description";
        }
   

        void dlReportPhase_DropDown(object sender, EventArgs e)
        {
            this.dlReportPhase.DataSource = EstimateBuilder.Builder.DataSourcePhase;
            this.dlReportPhase.DisplayMember = "Description";
            this.dlReportPhase.ValueMember = "Description";

        }

        void dlReportContract_DropDown(object sender, EventArgs e)
        {
            this.dlReportContract.DataSource = EstimateBuilder.Builder.DataSourceContract;
            this.dlReportContract.DisplayMember = "Description";
            this.dlReportContract.ValueMember = "Description";
        }

   


        void dlDivision_DropDown(object sender, EventArgs e)
        {

            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
            this.dlDivision.SelectedValue = 0;

       

        }

        void dlUnits_DropDown(object sender, EventArgs e)
        {
            this.dlUnits.DataSource = EstimateBuilder.Builder.DataSourceUnits;
            this.dlUnits.DisplayMember = "Description";
            this.dlUnits.ValueMember = "Description";
        }

        void dlDivisionPrint_DropDown(object sender, EventArgs e)
        {
            this.dlDivisionPrint.DataSource = EstimateBuilder.Builder.DataSourceDivisionPrint;
            this.dlDivisionPrint.DisplayMember = "Description";
            this.dlDivisionPrint.ValueMember = "Description";
        }

        void dlLocation_DropDown(object sender, EventArgs e)
        {
            this.dlLocation.DataSource = EstimateBuilder.Builder.DataSourceLocation;
            this.dlLocation.DisplayMember = "Description";
            this.dlLocation.ValueMember = "Description";
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


            this.dlCostItem.DataSource = list.CostIDDescription(i);
            this.dlCostItem.DisplayMember = "Description";
            this.dlCostItem.ValueMember = "CostItemID";
            this.dlCostItem.Refresh();

        }


        void dlCostItem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EstimateBuilder.ListDataProvider list = new EstimateBuilder.ListDataProvider();
            string i = "";

            if (this.dlCostItem.SelectedIndex != -1)
            {
                i = this.dlCostItem.SelectedValue.ToString();
            }
            else
            {
                i = this.dlCostItem.Text;
            }
            this.txtUnitOrder.Text = list.CostItemUnitOrder(i);

        }

        void dlJobID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EstimateBuilder.ListDataProvider list = new EstimateBuilder.ListDataProvider();
            this.dlExpression.SelectedValue = 0;
          

            string i = "";

            if (this.dlJobID.SelectedIndex != -1)
            {
                i = this.dlJobID.SelectedValue.ToString();
            }
            else
            {
                i = this.dlJobID.Text;
            }

            this.dlExpression.DataSource = list.selectExpression(i);
            this.dlExpression.DisplayMember = "DivisionValue";
            this.dlExpression.ValueMember = "DivisionKey";
        }


    }
}
