using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Text;



namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for CostAmount.
	/// </summary>
	public class CostAmount : System.Windows.Forms.UserControl
	{
		
		
		private Janus.Windows.UI.Tab.UITab uiTab1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private System.Windows.Forms.Label lbManufacture;
		private System.Windows.Forms.Label lbVendor;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbUser;
		private Janus.Windows.UI.Tab.UITabPage uiTabDetail;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.Label lbZipCode;

		public System.Windows.Forms.TextBox txtCostAmountID;
		public System.Windows.Forms.TextBox txtDate;
		public System.Windows.Forms.ComboBox dlVendor;
        public System.Windows.Forms.ComboBox dlManufacture;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtZipCode;
        public System.Windows.Forms.TextBox txtCostAmt;
		private System.Windows.Forms.Label lbCostAmt;
        public System.Windows.Forms.CheckBox chkActive;
        public System.Windows.Forms.PictureBox imgImage;
		public System.Windows.Forms.PictureBox imgCAD;
       
        private Label lbPovider;
        private Label lbDivision;
        private Label lbDivisionCost;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        
        private Label lbCostItem;
        private Label lbBuildingType;
        private Label lbPieceUnitOrder;
        public TextBox txtMemo;
        public ComboBox dlCostItem;
        public TextBox txtDivisionCost;
        public TextBox txtDescription;
        public ComboBox dlBuildingType;
        public TextBox txtPieceUnitOrder;
        private Label lbCostItemTitle;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label1;
        private Label label2;
        private Label label8;
        private RadioButton rdSortAZ;
        private RadioButton rdSortDate;
        public TextBox txtDivision;
        private Label lbUnitValue;
        private TextBox txtUnitValue;
        public TextBox txtGenericVendor;

        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CostAmount()
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
            this.dlManufacture = new System.Windows.Forms.ComboBox();
            this.dlVendor = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbManufacture = new System.Windows.Forms.Label();
            this.lbVendor = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.lbUnitValue = new System.Windows.Forms.Label();
            this.txtUnitValue = new System.Windows.Forms.TextBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPieceUnitOrder = new System.Windows.Forms.Label();
            this.txtPieceUnitOrder = new System.Windows.Forms.TextBox();
            this.lbBuildingType = new System.Windows.Forms.Label();
            this.dlBuildingType = new System.Windows.Forms.ComboBox();
            this.txtDivisionCost = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtCostAmt = new System.Windows.Forms.TextBox();
            this.lbCostAmt = new System.Windows.Forms.Label();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.imgCAD = new System.Windows.Forms.PictureBox();
            this.uiTabDetail = new Janus.Windows.UI.Tab.UITabPage();
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dlCostItem = new System.Windows.Forms.ComboBox();
            this.lbCostItem = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lbZipCode = new System.Windows.Forms.Label();
            this.txtCostAmountID = new System.Windows.Forms.TextBox();
            this.lbPovider = new System.Windows.Forms.Label();
            this.lbCostItemTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdSortAZ = new System.Windows.Forms.RadioButton();
            this.rdSortDate = new System.Windows.Forms.RadioButton();
            this.txtGenericVendor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCAD)).BeginInit();
            this.uiTabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.uiTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlManufacture
            // 
            this.dlManufacture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlManufacture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlManufacture.FormattingEnabled = true;
            this.dlManufacture.Location = new System.Drawing.Point(144, 60);
            this.dlManufacture.Name = "dlManufacture";
            this.dlManufacture.Size = new System.Drawing.Size(196, 21);
            this.dlManufacture.TabIndex = 2;
            // 
            // dlVendor
            // 
            this.dlVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlVendor.FormattingEnabled = true;
            this.dlVendor.Location = new System.Drawing.Point(144, 89);
            this.dlVendor.Name = "dlVendor";
            this.dlVendor.Size = new System.Drawing.Size(196, 21);
            this.dlVendor.TabIndex = 3;
            this.dlVendor.SelectionChangeCommitted += new System.EventHandler(this.vendor_Select);
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = false;
            this.txtUser.Location = new System.Drawing.Point(105, 16);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 26);
            this.txtUser.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = false;
            this.txtDate.Location = new System.Drawing.Point(444, 123);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(80, 22);
            this.txtDate.TabIndex = 9;
            // 
            // lbManufacture
            // 
            this.lbManufacture.BackColor = System.Drawing.Color.Transparent;
            this.lbManufacture.Location = new System.Drawing.Point(32, 64);
            this.lbManufacture.Name = "lbManufacture";
            this.lbManufacture.Size = new System.Drawing.Size(96, 16);
            this.lbManufacture.TabIndex = 0;
            this.lbManufacture.Text = "Manufacture";
            // 
            // lbVendor
            // 
            this.lbVendor.BackColor = System.Drawing.Color.Transparent;
            this.lbVendor.Location = new System.Drawing.Point(32, 94);
            this.lbVendor.Name = "lbVendor";
            this.lbVendor.Size = new System.Drawing.Size(80, 16);
            this.lbVendor.TabIndex = 0;
            this.lbVendor.Text = "Vendor";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Location = new System.Drawing.Point(364, 125);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(32, 16);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Date";
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Location = new System.Drawing.Point(23, 24);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(56, 16);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User";
            // 
            // uiTab1
            // 
            this.uiTab1.BackColor = System.Drawing.Color.Transparent;
            this.uiTab1.Controls.Add(this.uiTabPage2);
            this.uiTab1.Controls.Add(this.uiTabPage3);
            this.uiTab1.Controls.Add(this.uiTabDetail);
            this.uiTab1.Controls.Add(this.uiTabPage1);
            this.uiTab1.Location = new System.Drawing.Point(4, 152);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 0;
            this.uiTab1.Size = new System.Drawing.Size(544, 172);
            this.uiTab1.TabIndex = 11;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabDetail,
            this.uiTabPage1});
            this.uiTab1.TabStop = false;
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.lbUnitValue);
            this.uiTabPage2.Controls.Add(this.txtUnitValue);
            this.uiTabPage2.Controls.Add(this.txtDivision);
            this.uiTabPage2.Controls.Add(this.label7);
            this.uiTabPage2.Controls.Add(this.label5);
            this.uiTabPage2.Controls.Add(this.label4);
            this.uiTabPage2.Controls.Add(this.lbPieceUnitOrder);
            this.uiTabPage2.Controls.Add(this.txtPieceUnitOrder);
            this.uiTabPage2.Controls.Add(this.lbBuildingType);
            this.uiTabPage2.Controls.Add(this.dlBuildingType);
            this.uiTabPage2.Controls.Add(this.txtDivisionCost);
            this.uiTabPage2.Controls.Add(this.txtDescription);
            this.uiTabPage2.Controls.Add(this.lbDivisionCost);
            this.uiTabPage2.Controls.Add(this.lbDivision);
            this.uiTabPage2.Controls.Add(this.lbDescription);
            this.uiTabPage2.Controls.Add(this.txtCostAmt);
            this.uiTabPage2.Controls.Add(this.lbCostAmt);
            this.uiTabPage2.Controls.Add(this.lbUser);
            this.uiTabPage2.Controls.Add(this.txtUser);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(542, 150);
            this.uiTabPage2.TabIndex = 5;
            this.uiTabPage2.Text = "Detail";
            // 
            // lbUnitValue
            // 
            this.lbUnitValue.BackColor = System.Drawing.Color.Transparent;
            this.lbUnitValue.Location = new System.Drawing.Point(285, 86);
            this.lbUnitValue.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbUnitValue.Name = "lbUnitValue";
            this.lbUnitValue.Size = new System.Drawing.Size(80, 16);
            this.lbUnitValue.TabIndex = 54;
            this.lbUnitValue.Text = "Unit Value";
            // 
            // txtUnitValue
            // 
            this.txtUnitValue.AutoSize = false;
            this.txtUnitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitValue.Location = new System.Drawing.Point(381, 82);
            this.txtUnitValue.Multiline = true;
            this.txtUnitValue.Name = "txtUnitValue";
            this.txtUnitValue.ReadOnly = true;
            this.txtUnitValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUnitValue.Size = new System.Drawing.Size(152, 26);
            this.txtUnitValue.TabIndex = 53;
            // 
            // txtDivision
            // 
            this.txtDivision.AutoSize = false;
            this.txtDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivision.Location = new System.Drawing.Point(105, 116);
            this.txtDivision.Multiline = true;
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.ReadOnly = true;
            this.txtDivision.Size = new System.Drawing.Size(152, 26);
            this.txtDivision.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(476, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(201, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(263, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "*";
            // 
            // lbPieceUnitOrder
            // 
            this.lbPieceUnitOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbPieceUnitOrder.Location = new System.Drawing.Point(285, 18);
            this.lbPieceUnitOrder.Name = "lbPieceUnitOrder";
            this.lbPieceUnitOrder.Size = new System.Drawing.Size(78, 32);
            this.lbPieceUnitOrder.TabIndex = 47;
            this.lbPieceUnitOrder.Text = "Piece  Unit Ordered";
            // 
            // txtPieceUnitOrder
            // 
            this.txtPieceUnitOrder.AutoSize = false;
            this.txtPieceUnitOrder.Location = new System.Drawing.Point(380, 14);
            this.txtPieceUnitOrder.Multiline = true;
            this.txtPieceUnitOrder.Name = "txtPieceUnitOrder";
            this.txtPieceUnitOrder.Size = new System.Drawing.Size(90, 26);
            this.txtPieceUnitOrder.TabIndex = 11;
            this.txtPieceUnitOrder.Text = "1";
            // 
            // lbBuildingType
            // 
            this.lbBuildingType.BackColor = System.Drawing.Color.Transparent;
            this.lbBuildingType.Location = new System.Drawing.Point(283, 55);
            this.lbBuildingType.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbBuildingType.Name = "lbBuildingType";
            this.lbBuildingType.Size = new System.Drawing.Size(80, 16);
            this.lbBuildingType.TabIndex = 45;
            this.lbBuildingType.Text = "Building Type";
            // 
            // dlBuildingType
            // 
            this.dlBuildingType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlBuildingType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlBuildingType.FormattingEnabled = true;
            this.dlBuildingType.Location = new System.Drawing.Point(381, 51);
            this.dlBuildingType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dlBuildingType.Name = "dlBuildingType";
            this.dlBuildingType.Size = new System.Drawing.Size(150, 21);
            this.dlBuildingType.TabIndex = 12;
            this.dlBuildingType.DropDown += new System.EventHandler(this.dlBuildingType_DropDown);
            // 
            // txtDivisionCost
            // 
            this.txtDivisionCost.AutoSize = false;
            this.txtDivisionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisionCost.Location = new System.Drawing.Point(382, 117);
            this.txtDivisionCost.Multiline = true;
            this.txtDivisionCost.Name = "txtDivisionCost";
            this.txtDivisionCost.ReadOnly = true;
            this.txtDivisionCost.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDivisionCost.Size = new System.Drawing.Size(152, 26);
            this.txtDivisionCost.TabIndex = 43;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(105, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(152, 26);
            this.txtDescription.TabIndex = 40;
            // 
            // lbDivisionCost
            // 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(285, 125);
            this.lbDivisionCost.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(78, 16);
            this.lbDivisionCost.TabIndex = 39;
            this.lbDivisionCost.Text = "Division Cost";
            // 
            // lbDivision
            // 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.Location = new System.Drawing.Point(23, 121);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(64, 16);
            this.lbDivision.TabIndex = 37;
            this.lbDivision.Text = "Division";
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(23, 86);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(64, 16);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // txtCostAmt
            // 
            this.txtCostAmt.AutoSize = false;
            this.txtCostAmt.Location = new System.Drawing.Point(105, 49);
            this.txtCostAmt.Multiline = true;
            this.txtCostAmt.Name = "txtCostAmt";
            this.txtCostAmt.Size = new System.Drawing.Size(90, 26);
            this.txtCostAmt.TabIndex = 10;
            // 
            // lbCostAmt
            // 
            this.lbCostAmt.BackColor = System.Drawing.Color.Transparent;
            this.lbCostAmt.Location = new System.Drawing.Point(23, 54);
            this.lbCostAmt.Name = "lbCostAmt";
            this.lbCostAmt.Size = new System.Drawing.Size(64, 16);
            this.lbCostAmt.TabIndex = 29;
            this.lbCostAmt.Text = "Cost Amt";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.imgCAD);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(542, 150);
            this.uiTabPage3.TabIndex = 16;
            this.uiTabPage3.Text = "CAD";
            // 
            // imgCAD
            // 
            this.imgCAD.Location = new System.Drawing.Point(16, 14);
            this.imgCAD.Name = "imgCAD";
            this.imgCAD.Size = new System.Drawing.Size(509, 123);
            this.imgCAD.TabIndex = 2;
            this.imgCAD.TabStop = false;
            // 
            // uiTabDetail
            // 
            this.uiTabDetail.Controls.Add(this.imgImage);
            this.uiTabDetail.Location = new System.Drawing.Point(1, 21);
            this.uiTabDetail.Name = "uiTabDetail";
            this.uiTabDetail.Size = new System.Drawing.Size(542, 150);
            this.uiTabDetail.TabIndex = 18;
            this.uiTabDetail.Text = "Image";
            // 
            // imgImage
            // 
            this.imgImage.Location = new System.Drawing.Point(16, 7);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(509, 136);
            this.imgImage.TabIndex = 3;
            this.imgImage.TabStop = false;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.txtMemo);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(542, 150);
            this.uiTabPage1.TabIndex = 19;
            this.uiTabPage1.Text = "Memo";
            // 
            // txtMemo
            // 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(16, 11);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(509, 136);
            this.txtMemo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(535, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "*";
            // 
            // dlCostItem
            // 
            this.dlCostItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlCostItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlCostItem.FormattingEnabled = true;
            this.dlCostItem.Location = new System.Drawing.Point(144, 31);
            this.dlCostItem.Name = "dlCostItem";
            this.dlCostItem.Size = new System.Drawing.Size(196, 21);
            this.dlCostItem.TabIndex = 1;
            this.dlCostItem.SelectedValueChanged += new System.EventHandler(this.dlCostItem_SelectedValueChanged);
            // 
            // lbCostItem
            // 
            this.lbCostItem.BackColor = System.Drawing.Color.Transparent;
            this.lbCostItem.Location = new System.Drawing.Point(32, 34);
            this.lbCostItem.Name = "lbCostItem";
            this.lbCostItem.Size = new System.Drawing.Size(64, 16);
            this.lbCostItem.TabIndex = 43;
            this.lbCostItem.Text = "Cost Item";
            // 
            // chkActive
            // 
            this.chkActive.BackColor = System.Drawing.Color.Transparent;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(374, 10);
            this.chkActive.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(73, 22);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = false;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(444, 94);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(80, 20);
            this.txtZipCode.TabIndex = 4;
            // 
            // lbZipCode
            // 
            this.lbZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lbZipCode.Location = new System.Drawing.Point(364, 98);
            this.lbZipCode.Name = "lbZipCode";
            this.lbZipCode.Size = new System.Drawing.Size(56, 16);
            this.lbZipCode.TabIndex = 0;
            this.lbZipCode.Text = "Zip Code";
            // 
            // txtCostAmountID
            // 
            this.txtCostAmountID.Location = new System.Drawing.Point(449, 11);
            this.txtCostAmountID.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtCostAmountID.Name = "txtCostAmountID";
            this.txtCostAmountID.ReadOnly = true;
            this.txtCostAmountID.Size = new System.Drawing.Size(56, 20);
            this.txtCostAmountID.TabIndex = 21;
            // 
            // lbPovider
            // 
            this.lbPovider.BackColor = System.Drawing.Color.Transparent;
            this.lbPovider.Location = new System.Drawing.Point(32, 126);
            this.lbPovider.Name = "lbPovider";
            this.lbPovider.Size = new System.Drawing.Size(80, 16);
            this.lbPovider.TabIndex = 23;
            this.lbPovider.Text = "Contractor";
            // 
            // lbCostItemTitle
            // 
            this.lbCostItemTitle.AutoSize = true;
            this.lbCostItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbCostItemTitle.Location = new System.Drawing.Point(32, 5);
            this.lbCostItemTitle.Name = "lbCostItemTitle";
            this.lbCostItemTitle.Size = new System.Drawing.Size(85, 16);
            this.lbCostItemTitle.TabIndex = 52;
            this.lbCostItemTitle.Text = "Cost Amount";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(346, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "*";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(346, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(345, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "*";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(530, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "*";
            // 
            // rdSortAZ
            // 
            this.rdSortAZ.AutoSize = true;
            this.rdSortAZ.Location = new System.Drawing.Point(393, 43);
            this.rdSortAZ.Name = "rdSortAZ";
            this.rdSortAZ.Size = new System.Drawing.Size(87, 17);
            this.rdSortAZ.TabIndex = 58;
            this.rdSortAZ.TabStop = false;
            this.rdSortAZ.Text = "Cost Item A/Z";
            this.rdSortAZ.Click += new System.EventHandler(this.rdSortAZ_Click);
            // 
            // rdSortDate
            // 
            this.rdSortDate.AutoSize = true;
            this.rdSortDate.Checked = true;
            this.rdSortDate.Location = new System.Drawing.Point(392, 62);
            this.rdSortDate.Name = "rdSortDate";
            this.rdSortDate.Size = new System.Drawing.Size(105, 17);
            this.rdSortDate.TabIndex = 59;
            this.rdSortDate.Text = "Cost Item by Date";
            this.rdSortDate.Click += new System.EventHandler(this.rdSortDate_Click);
            // 
            // txtGenericVendor
            // 
            this.txtGenericVendor.AutoSize = false;
            this.txtGenericVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenericVendor.Location = new System.Drawing.Point(144, 118);
            this.txtGenericVendor.Multiline = true;
            this.txtGenericVendor.Name = "txtGenericVendor";
            this.txtGenericVendor.ReadOnly = true;
            this.txtGenericVendor.Size = new System.Drawing.Size(196, 28);
            this.txtGenericVendor.TabIndex = 55;
            // 
            // CostAmount
            // 
            this.Controls.Add(this.txtGenericVendor);
            this.Controls.Add(this.rdSortDate);
            this.Controls.Add(this.rdSortAZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbCostItemTitle);
            this.Controls.Add(this.lbCostItem);
            this.Controls.Add(this.dlCostItem);
            this.Controls.Add(this.lbPovider);
            this.Controls.Add(this.txtCostAmountID);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.lbVendor);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dlVendor);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lbZipCode);
            this.Controls.Add(this.dlManufacture);
            this.Controls.Add(this.lbManufacture);
            this.Name = "CostAmount";
            this.Size = new System.Drawing.Size(575, 345);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCAD)).EndInit();
            this.uiTabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.uiTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
		#endregion


        public bool _rdSort = true;

        void rdSortAZ_Click(object sender, EventArgs e)
        {
            this.rdSortDate.Checked = false;
            _rdSort = false;
            EstimateBuilder.ListDataProvider DataSource = new EstimateBuilder.ListDataProvider();

            this.dlCostItem.DataSource = DataSource.CostItemIDDescription(_rdSort);
            this.dlCostItem.ValueMember = "CostItemID";
            this.dlCostItem.DisplayMember = "Description";
            this.dlCostItem.Refresh();
        }

        void rdSortDate_Click(object sender, EventArgs e)
        {
            this.rdSortAZ.Checked = false;
            _rdSort = true;
            EstimateBuilder.ListDataProvider DataSource = new EstimateBuilder.ListDataProvider();

            this.dlCostItem.DataSource = DataSource.CostItemIDDescription(_rdSort);
            this.dlCostItem.ValueMember = "CostItemID";
            this.dlCostItem.DisplayMember = "Description";
            this.dlCostItem.Refresh();
        }

		
		public void CostAmount_Load()
		{
			this.Visible = true;
            this.txtDate.Text = System.DateTime.Now.ToShortDateString();
            EstimateBuilder.ListDataProvider DataSource = new EstimateBuilder.ListDataProvider();

            this.dlCostItem.DataSource = DataSource.CostItemIDDescription(_rdSort); 
            this.dlCostItem.ValueMember = "CostItemID";
            this.dlCostItem.DisplayMember = "Description";
            this.dlManufacture.DataSource = EstimateBuilder.Builder.DataSourceManufactureIDCompany;
            this.dlManufacture.DisplayMember = "Company";
            this.dlManufacture.ValueMember = "ManufactureID";
            this.dlVendor.DataSource = EstimateBuilder.Builder.DataSourceVendorIDCompany;
            this.dlVendor.DisplayMember = "Company";
            this.dlVendor.ValueMember = "VendorID";
            this.dlVendor.SelectedValue = 0;
        }

        private void vendor_Select(object sender, System.EventArgs e)
        {
  
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();
            strSQL.Append("SELECT DISTINCT  ZipCode  ");
            strSQL.Append(" FROM Contact ");
            strSQL.Append("  where ContactID = " + this.dlVendor.SelectedValue);
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    this.txtZipCode.Text = row[0].ToString().Substring(0,3);
                }
            }
            catch { }
        }



        void dlCostItem_SelectedValueChanged(object sender, EventArgs e)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.Description_costItem, UnitOrder, GenericVendor ");
            strSQL.Append(" FROM CostItem WHERE CostItemID = "  + this.dlCostItem.SelectedValue);
            strSQL.Append(" ORDER BY Description_costItem");

            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    this.txtDivision.Text = row[0].ToString();
                    this.txtDivisionCost.Text = row[1].ToString();
                    this.txtDescription.Text = row[2].ToString();
                    this.txtUnitValue.Text = row[3].ToString();
                    this.txtGenericVendor.Text = row[4].ToString(); 
                }
            }
            catch { }

        }



    
     
  


        void dlBuildingType_DropDown(object sender, EventArgs e)
        {
            this.dlBuildingType.DataSource = EstimateBuilder.Builder.DataSourceType;
            this.dlBuildingType.DisplayMember = "Description";
            this.dlBuildingType.ValueMember = "Description";
        }
    }


    }

