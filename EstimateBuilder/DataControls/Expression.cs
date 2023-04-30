using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class Expression : System.Windows.Forms.UserControl
	{

		private System.Windows.Forms.Label lbDivisionCost;
		private System.Windows.Forms.Label lbDivision;
        private System.Windows.Forms.Label lbDescription;
        public Janus.Windows.UI.Tab.UITab uiTabEstimate;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtExpressionID;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITab uiTab1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage5;
        private System.Windows.Forms.TreeView trTakeOff;
        private System.Windows.Forms.Button btOperation1;
		private System.Windows.Forms.Button btOperation2;
		private System.Windows.Forms.Button btOperation3;
        private System.Windows.Forms.Button btOperation4;
        private System.Windows.Forms.TreeView trExpression;
		private System.Windows.Forms.Button btRightParenthesis;
        private System.Windows.Forms.Button btLeftParenthesis;
        private System.Windows.Forms.Button btFive;
		private System.Windows.Forms.Button btFour;
		private System.Windows.Forms.Button btTwo;
		private System.Windows.Forms.Button btOne;
		private System.Windows.Forms.Button btCE;
		private System.Windows.Forms.Button btSix;
		private System.Windows.Forms.Button btEight;
		private System.Windows.Forms.Button btNine;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btZero;
		private System.Windows.Forms.Button btThree;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lbAssemblyID;
        private Button btOK;
        private Button btC;
        private Label lbExpressionValue;
        private Label lbSelectBuildingType;
        private Label lbSelectValue;
        private Label lbUnit;
        private Label lbTakeOffValue;
        private Button btDel;
        protected string Guid;
        private Button btPeriod;

        public TextBox txtTakeoffValue;
        private TextBox txtResult;
        public string _jobID;
        public ComboBox dlBuildingType;
        public ComboBox dlJob;
        public TextBox txtExpression;
        public System.Windows.Forms.ComboBox dlDivisionCost;
        public System.Windows.Forms.ComboBox dlDivision;
        public System.Windows.Forms.TextBox txtMemo;
        public System.Windows.Forms.ComboBox dlAssembly;
        public ComboBox dlUnit;
        private Label lbExpressionTitle;

        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Expression()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expression));
     
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.lbSelectValue = new System.Windows.Forms.Label();
            this.lbTakeOffValue = new System.Windows.Forms.Label();
            this.txtTakeoffValue = new System.Windows.Forms.TextBox();
            this.btPeriod = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.lbSelectBuildingType = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.dlBuildingType = new System.Windows.Forms.ComboBox();
            this.lbExpressionValue = new System.Windows.Forms.Label();
            this.dlJob = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btEight = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.btSeven = new System.Windows.Forms.Button();
            this.btFive = new System.Windows.Forms.Button();
            this.btSix = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btOne = new System.Windows.Forms.Button();
            this.btLeftParenthesis = new System.Windows.Forms.Button();
            this.btRightParenthesis = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btOperation4 = new System.Windows.Forms.Button();
            this.btOperation3 = new System.Windows.Forms.Button();
            this.btOperation2 = new System.Windows.Forms.Button();
            this.btOperation1 = new System.Windows.Forms.Button();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.trTakeOff = new System.Windows.Forms.TreeView();
            this.uiTabPage5 = new Janus.Windows.UI.Tab.UITabPage();
            this.trExpression = new System.Windows.Forms.TreeView();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.dlAssembly = new System.Windows.Forms.ComboBox();
            this.lbAssemblyID = new System.Windows.Forms.Label();
            this.txtExpressionID = new System.Windows.Forms.TextBox();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiTabEstimate = new Janus.Windows.UI.Tab.UITab();
            this.lbUnit = new System.Windows.Forms.Label();
            this.dlUnit = new System.Windows.Forms.ComboBox();
            this.lbExpressionTitle = new System.Windows.Forms.Label();
      
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.uiTabPage5.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabEstimate)).BeginInit();
            this.uiTabEstimate.SuspendLayout();
            this.SuspendLayout();

// 
// txtDescription
// 
            this.txtDescription.AutoSize = false;
            this.txtDescription.Location = new System.Drawing.Point(95, 40);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 26);
            this.txtDescription.TabIndex = 1;
// 
// lbDescription
// 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(15, 43);
            this.lbDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(72, 23);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
// 
// lbDivision
// 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.Location = new System.Drawing.Point(16, 74);
            this.lbDivision.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(64, 23);
            this.lbDivision.TabIndex = 0;
            this.lbDivision.Text = "Division";
// 
// lbDivisionCost
// 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(288, 75);
            this.lbDivisionCost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(72, 23);
            this.lbDivisionCost.TabIndex = 0;
            this.lbDivisionCost.Text = "Division Cost";
// 
// uiTabPage2
// 
            this.uiTabPage2.Controls.Add(this.lbSelectValue);
            this.uiTabPage2.Controls.Add(this.lbTakeOffValue);
            this.uiTabPage2.Controls.Add(this.txtTakeoffValue);
            this.uiTabPage2.Controls.Add(this.btPeriod);
            this.uiTabPage2.Controls.Add(this.btDel);
            this.uiTabPage2.Controls.Add(this.lbSelectBuildingType);
            this.uiTabPage2.Controls.Add(this.txtResult);
            this.uiTabPage2.Controls.Add(this.dlBuildingType);
            this.uiTabPage2.Controls.Add(this.lbExpressionValue);
            this.uiTabPage2.Controls.Add(this.dlJob);
            this.uiTabPage2.Controls.Add(this.btOK);
            this.uiTabPage2.Controls.Add(this.btC);
            this.uiTabPage2.Controls.Add(this.btZero);
            this.uiTabPage2.Controls.Add(this.btEight);
            this.uiTabPage2.Controls.Add(this.btNine);
            this.uiTabPage2.Controls.Add(this.btSeven);
            this.uiTabPage2.Controls.Add(this.btFive);
            this.uiTabPage2.Controls.Add(this.btSix);
            this.uiTabPage2.Controls.Add(this.btThree);
            this.uiTabPage2.Controls.Add(this.btFour);
            this.uiTabPage2.Controls.Add(this.btTwo);
            this.uiTabPage2.Controls.Add(this.btOne);
            this.uiTabPage2.Controls.Add(this.btLeftParenthesis);
            this.uiTabPage2.Controls.Add(this.btRightParenthesis);
            this.uiTabPage2.Controls.Add(this.btCE);
            this.uiTabPage2.Controls.Add(this.btOperation4);
            this.uiTabPage2.Controls.Add(this.btOperation3);
            this.uiTabPage2.Controls.Add(this.btOperation2);
            this.uiTabPage2.Controls.Add(this.btOperation1);
            this.uiTabPage2.Controls.Add(this.txtExpression);
            this.uiTabPage2.Controls.Add(this.uiTab1);
            this.uiTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(526, 414);
            this.uiTabPage2.TabIndex = 1;
            this.uiTabPage2.Text = "Calculator";
// 
// lbSelectValue
// 
            this.lbSelectValue.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectValue.Location = new System.Drawing.Point(314, 154);
            this.lbSelectValue.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbSelectValue.Name = "lbSelectValue";
            this.lbSelectValue.Size = new System.Drawing.Size(118, 15);
            this.lbSelectValue.TabIndex = 43;
            this.lbSelectValue.Text = "Select Job Name";
// 
// lbTakeOffValue
// 
            this.lbTakeOffValue.BackColor = System.Drawing.Color.Transparent;
            this.lbTakeOffValue.Location = new System.Drawing.Point(314, 216);
            this.lbTakeOffValue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbTakeOffValue.Name = "lbTakeOffValue";
            this.lbTakeOffValue.Size = new System.Drawing.Size(122, 23);
            this.lbTakeOffValue.TabIndex = 32;
            this.lbTakeOffValue.Text = "Selected takeoff value";
// 
// txtTakeoffValue
// 
            this.txtTakeoffValue.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtTakeoffValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtTakeoffValue.AutoSize = false;
            this.txtTakeoffValue.Location = new System.Drawing.Point(463, 207);
            this.txtTakeoffValue.Multiline = true;
            this.txtTakeoffValue.Name = "txtTakeoffValue";
            this.txtTakeoffValue.ReadOnly = true;
            this.txtTakeoffValue.Size = new System.Drawing.Size(53, 26);
            this.txtTakeoffValue.TabIndex = 32;
            this.txtTakeoffValue.TabStop = false;
// 
// btPeriod
// 
            this.btPeriod.Location = new System.Drawing.Point(438, 254);
            this.btPeriod.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btPeriod.Name = "btPeriod";
            this.btPeriod.Size = new System.Drawing.Size(23, 23);
            this.btPeriod.TabIndex = 0;
            this.btPeriod.TabStop = false;
            this.btPeriod.Text = ".";
            this.btPeriod.Click += new System.EventHandler(this.btPeriod_Click);
// 
// btDel
// 
            this.btDel.Location = new System.Drawing.Point(389, 367);
            this.btDel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(47, 20);
            this.btDel.TabIndex = 42;
            this.btDel.Text = "M-";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
// 
// lbSelectBuildingType
// 
            this.lbSelectBuildingType.BackColor = System.Drawing.Color.Transparent;
            this.lbSelectBuildingType.Location = new System.Drawing.Point(312, 91);
            this.lbSelectBuildingType.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbSelectBuildingType.Name = "lbSelectBuildingType";
            this.lbSelectBuildingType.Size = new System.Drawing.Size(118, 15);
            this.lbSelectBuildingType.TabIndex = 41;
            this.lbSelectBuildingType.Text = "Select Building Type";
// 
// txtResult
// 
            this.txtResult.AutoSize = false;
            this.txtResult.Location = new System.Drawing.Point(310, 334);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(206, 26);
            this.txtResult.TabIndex = 39;
            this.txtResult.TabStop = false;
// 
// dlBuildingType
// 
            this.dlBuildingType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dlBuildingType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlBuildingType.FormattingEnabled = true;
            this.dlBuildingType.Location = new System.Drawing.Point(312, 117);
            this.dlBuildingType.Name = "dlBuildingType";
            this.dlBuildingType.Size = new System.Drawing.Size(206, 21);
            this.dlBuildingType.TabIndex = 10;
            this.dlBuildingType.SelectionChangeCommitted += new System.EventHandler(this.dlBuildingType_SelectionChangeCommitted);
            this.dlBuildingType.DropDown += new EventHandler(this.dlBuildingType_DropDown);
// 
// lbExpressionValue
// 
            this.lbExpressionValue.BackColor = System.Drawing.Color.Transparent;
            this.lbExpressionValue.Location = new System.Drawing.Point(314, 312);
            this.lbExpressionValue.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.lbExpressionValue.Name = "lbExpressionValue";
            this.lbExpressionValue.Size = new System.Drawing.Size(118, 15);
            this.lbExpressionValue.TabIndex = 38;
            this.lbExpressionValue.Text = "Expression Value";
// 
// dlJob
// 
            this.dlJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dlJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlJob.FormattingEnabled = true;
            this.dlJob.Location = new System.Drawing.Point(312, 179);
            this.dlJob.Name = "dlJob";
            this.dlJob.Size = new System.Drawing.Size(207, 21);
            this.dlJob.TabIndex = 11;
            this.dlJob.SelectionChangeCommitted += new System.EventHandler(this.dlJob_SelectionChangeCommitted);
// 
// btOK
// 
            this.btOK.Location = new System.Drawing.Point(335, 367);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(47, 20);
            this.btOK.TabIndex = 36;
            this.btOK.TabStop = false;
            this.btOK.Text = "M+";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
// 
// btC
// 
            this.btC.Location = new System.Drawing.Point(438, 278);
            this.btC.Margin = new System.Windows.Forms.Padding(1, 0, 2, 0);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(23, 24);
            this.btC.TabIndex = 35;
            this.btC.TabStop = false;
            this.btC.Text = "C";
            this.btC.Click += new System.EventHandler(this.btC_Click);
// 
// btZero
// 
            this.btZero.Location = new System.Drawing.Point(408, 278);
            this.btZero.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(24, 24);
            this.btZero.TabIndex = 0;
            this.btZero.TabStop = false;
            this.btZero.Text = "0";
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
// 
// btEight
// 
            this.btEight.Location = new System.Drawing.Point(360, 278);
            this.btEight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btEight.Name = "btEight";
            this.btEight.Size = new System.Drawing.Size(24, 24);
            this.btEight.TabIndex = 0;
            this.btEight.TabStop = false;
            this.btEight.Text = "8";
            this.btEight.Click += new System.EventHandler(this.btEight_Click);
// 
// btNine
// 
            this.btNine.Location = new System.Drawing.Point(384, 278);
            this.btNine.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(24, 24);
            this.btNine.TabIndex = 0;
            this.btNine.TabStop = false;
            this.btNine.Text = "9";
            this.btNine.Click += new System.EventHandler(this.btNine_Click);
// 
// btSeven
// 
            this.btSeven.Location = new System.Drawing.Point(336, 278);
            this.btSeven.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(24, 24);
            this.btSeven.TabIndex = 0;
            this.btSeven.TabStop = false;
            this.btSeven.Text = "7";
            this.btSeven.Click += new System.EventHandler(this.btSeven_Click);
// 
// btFive
// 
            this.btFive.Location = new System.Drawing.Point(408, 254);
            this.btFive.Name = "btFive";
            this.btFive.Size = new System.Drawing.Size(24, 24);
            this.btFive.TabIndex = 0;
            this.btFive.TabStop = false;
            this.btFive.Text = "5";
            this.btFive.Click += new System.EventHandler(this.btFive_Click);
// 
// btSix
// 
            this.btSix.Location = new System.Drawing.Point(312, 278);
            this.btSix.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btSix.Name = "btSix";
            this.btSix.Size = new System.Drawing.Size(24, 24);
            this.btSix.TabIndex = 0;
            this.btSix.TabStop = false;
            this.btSix.Text = "6";
            this.btSix.Click += new System.EventHandler(this.btSix_Click);
// 
// btThree
// 
            this.btThree.Location = new System.Drawing.Point(360, 254);
            this.btThree.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(24, 24);
            this.btThree.TabIndex = 0;
            this.btThree.TabStop = false;
            this.btThree.Text = "3";
            this.btThree.Click += new System.EventHandler(this.btThree_Click);
// 
// btFour
// 
            this.btFour.Location = new System.Drawing.Point(384, 254);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(24, 24);
            this.btFour.TabIndex = 0;
            this.btFour.TabStop = false;
            this.btFour.Text = "4";
            this.btFour.Click += new System.EventHandler(this.btFour_Click);
// 
// btTwo
// 
            this.btTwo.Location = new System.Drawing.Point(336, 254);
            this.btTwo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(24, 24);
            this.btTwo.TabIndex = 0;
            this.btTwo.TabStop = false;
            this.btTwo.Text = "2";
            this.btTwo.Click += new System.EventHandler(this.btTwo_Click);
// 
// btOne
// 
            this.btOne.Location = new System.Drawing.Point(312, 254);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(24, 24);
            this.btOne.TabIndex = 0;
            this.btOne.TabStop = false;
            this.btOne.Text = "1";
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
// 
// btLeftParenthesis
// 
            this.btLeftParenthesis.Location = new System.Drawing.Point(485, 278);
            this.btLeftParenthesis.Margin = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.btLeftParenthesis.Name = "btLeftParenthesis";
            this.btLeftParenthesis.Size = new System.Drawing.Size(17, 24);
            this.btLeftParenthesis.TabIndex = 0;
            this.btLeftParenthesis.TabStop = false;
            this.btLeftParenthesis.Text = "(";
            this.btLeftParenthesis.Click += new System.EventHandler(this.btLeftParenthesis_Click);
// 
// btRightParenthesis
// 
            this.btRightParenthesis.Location = new System.Drawing.Point(503, 278);
            this.btRightParenthesis.Margin = new System.Windows.Forms.Padding(0, 1, 3, 3);
            this.btRightParenthesis.Name = "btRightParenthesis";
            this.btRightParenthesis.Size = new System.Drawing.Size(17, 24);
            this.btRightParenthesis.TabIndex = 0;
            this.btRightParenthesis.TabStop = false;
            this.btRightParenthesis.Text = ")";
            this.btRightParenthesis.Click += new System.EventHandler(this.btRightParenthesis_Click);
// 
// btCE
// 
            this.btCE.Location = new System.Drawing.Point(443, 367);
            this.btCE.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(47, 20);
            this.btCE.TabIndex = 0;
            this.btCE.TabStop = false;
            this.btCE.Text = "CE";
            this.btCE.Click += new System.EventHandler(this.btClear_Click);
// 
// btOperation4
// 
            this.btOperation4.Location = new System.Drawing.Point(503, 255);
            this.btOperation4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btOperation4.Name = "btOperation4";
            this.btOperation4.Size = new System.Drawing.Size(16, 24);
            this.btOperation4.TabIndex = 0;
            this.btOperation4.TabStop = false;
            this.btOperation4.Text = "/";
            this.btOperation4.Click += new System.EventHandler(this.btOperation4_Click);
// 
// btOperation3
// 
            this.btOperation3.Location = new System.Drawing.Point(486, 255);
            this.btOperation3.Margin = new System.Windows.Forms.Padding(0, 3, 1, 3);
            this.btOperation3.Name = "btOperation3";
            this.btOperation3.Size = new System.Drawing.Size(16, 24);
            this.btOperation3.TabIndex = 0;
            this.btOperation3.TabStop = false;
            this.btOperation3.Text = "*";
            this.btOperation3.Click += new System.EventHandler(this.btOperation3_Click);
// 
// btOperation2
// 
            this.btOperation2.Location = new System.Drawing.Point(468, 278);
            this.btOperation2.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.btOperation2.Name = "btOperation2";
            this.btOperation2.Size = new System.Drawing.Size(16, 24);
            this.btOperation2.TabIndex = 0;
            this.btOperation2.TabStop = false;
            this.btOperation2.Text = "-";
            this.btOperation2.Click += new System.EventHandler(this.btOperation2_Click);
// 
// btOperation1
// 
            this.btOperation1.Location = new System.Drawing.Point(468, 255);
            this.btOperation1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.btOperation1.Name = "btOperation1";
            this.btOperation1.Size = new System.Drawing.Size(16, 24);
            this.btOperation1.TabIndex = 0;
            this.btOperation1.TabStop = false;
            this.btOperation1.Text = "+";
            this.btOperation1.Click += new System.EventHandler(this.btOperation1_Click);
// 
// txtExpression
// 
            this.txtExpression.AutoSize = false;
            this.txtExpression.BackColor = System.Drawing.SystemColors.Window;
            this.txtExpression.Location = new System.Drawing.Point(31, 6);
            this.txtExpression.Multiline = true;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.ReadOnly = true;
            this.txtExpression.Size = new System.Drawing.Size(480, 61);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.TabStop = false;
// 
// uiTab1
// 
            this.uiTab1.Controls.Add(this.uiTabPage4);
            this.uiTab1.Controls.Add(this.uiTabPage5);
            this.uiTab1.Location = new System.Drawing.Point(31, 78);
            this.uiTab1.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 0;
            this.uiTab1.Size = new System.Drawing.Size(272, 328);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage4,
            this.uiTabPage5});
// 
// uiTabPage4
// 
            this.uiTabPage4.Controls.Add(this.trTakeOff);
            this.uiTabPage4.Key = "tbTakeOff";
            this.uiTabPage4.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(270, 306);
            this.uiTabPage4.TabIndex = 0;
            this.uiTabPage4.Text = "Take Off";
// 
// trTakeOff
// 
            this.trTakeOff.Location = new System.Drawing.Point(1, 4);
            this.trTakeOff.Name = "trTakeOff";
            this.trTakeOff.Size = new System.Drawing.Size(266, 300);
            this.trTakeOff.TabIndex = 5;
            this.trTakeOff.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trTakeOff_BeforeExpand);
            this.trTakeOff.NodeMouseDoubleClick +=new TreeNodeMouseClickEventHandler(trTakeOff_NodeMouseDoubleClick);
            this.trTakeOff.NodeMouseClick += new TreeNodeMouseClickEventHandler(trTakeOff_NodeMouseClick);
// 
// uiTabPage5
// 
            this.uiTabPage5.Controls.Add(this.trExpression);
            this.uiTabPage5.Key = "tbExpression";
            this.uiTabPage5.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage5.Name = "uiTabPage5";
            this.uiTabPage5.Size = new System.Drawing.Size(270, 306);
            this.uiTabPage5.TabIndex = 1;
            this.uiTabPage5.Text = "Expression";
// 
// trExpression
// 
            this.trExpression.Location = new System.Drawing.Point(4, 4);
            this.trExpression.Name = "trExpression";
            this.trExpression.Size = new System.Drawing.Size(256, 299);
            this.trExpression.TabIndex = 0;
            this.trExpression.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trExpression_BeforeExpand);
            this.trExpression.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trExpression_AfterSelect);
// 
// uiTabPage3
// 
            this.uiTabPage3.Controls.Add(this.txtMemo);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(534, 351);
            this.uiTabPage3.TabIndex = 2;
            this.uiTabPage3.Text = "Memo";
// 
// txtMemo
// 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(4, 4);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(528, 240);
            this.txtMemo.TabIndex = 12;
// 
// dlAssembly
// 
            this.dlAssembly.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlAssembly.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlAssembly.FormattingEnabled = true;
            this.dlAssembly.Location = new System.Drawing.Point(95, 99);
            this.dlAssembly.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.dlAssembly.Name = "dlAssembly";
            this.dlAssembly.Size = new System.Drawing.Size(169, 21);
            this.dlAssembly.TabIndex = 4;
           
// lbAssemblyID
// 
            this.lbAssemblyID.BackColor = System.Drawing.Color.Transparent;
            this.lbAssemblyID.Location = new System.Drawing.Point(16, 102);
            this.lbAssemblyID.Margin = new System.Windows.Forms.Padding(3, 2, 1, 3);
            this.lbAssemblyID.Name = "lbAssemblyID";
            this.lbAssemblyID.Size = new System.Drawing.Size(72, 23);
            this.lbAssemblyID.TabIndex = 29;
            this.lbAssemblyID.Text = "Assembly";
// 
// txtExpressionID
// 
            this.txtExpressionID.Location = new System.Drawing.Point(489, 12);
            this.txtExpressionID.Name = "txtExpressionID";
            this.txtExpressionID.ReadOnly = true;
            this.txtExpressionID.Size = new System.Drawing.Size(48, 20);
            this.txtExpressionID.TabIndex = 0;
// 
// dlDivision
// 
            this.dlDivision.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(95, 72);
            this.dlDivision.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(169, 21);
            this.dlDivision.TabIndex = 2;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.Division_Select);
            this.dlDivision.DropDown += new EventHandler(this.dlDivision_DropDown);
// 
// dlDivisionCost
// 
            this.dlDivisionCost.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(375, 75);
            this.dlDivisionCost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(169, 21);
            this.dlDivisionCost.TabIndex = 3;
// 
// label1
// 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(548, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
// 
// label2
// 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(265, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
// 
// label3
// 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(392, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
// 
// uiTabEstimate
// 
            this.uiTabEstimate.BackColor = System.Drawing.Color.Transparent;
            this.uiTabEstimate.Controls.Add(this.uiTabPage2);
            this.uiTabEstimate.Controls.Add(this.uiTabPage3);
            this.uiTabEstimate.Location = new System.Drawing.Point(16, 128);
            this.uiTabEstimate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.uiTabEstimate.Name = "uiTabEstimate";
            this.uiTabEstimate.SelectedIndex = 0;
            this.uiTabEstimate.Size = new System.Drawing.Size(528, 436);
            this.uiTabEstimate.TabIndex = 9;
            this.uiTabEstimate.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3});
            this.uiTabEstimate.TabStop = false;
            this.uiTabEstimate.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
// 
// lbUnit
// 
            this.lbUnit.BackColor = System.Drawing.Color.Transparent;
            this.lbUnit.Location = new System.Drawing.Point(288, 104);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(72, 23);
            this.lbUnit.TabIndex = 45;
            this.lbUnit.Text = "Unit";
// 
// dlUnit
// 
            this.dlUnit.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlUnit.FormattingEnabled = true;
            this.dlUnit.Location = new System.Drawing.Point(374, 101);
            this.dlUnit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.dlUnit.Name = "dlUnit";
            this.dlUnit.Size = new System.Drawing.Size(169, 21);
            this.dlUnit.TabIndex = 5;
            this.dlUnit.DropDown+=new EventHandler (this.dlUnit_DropDown);
// 
// lbExpressionTitle
// 
            this.lbExpressionTitle.AutoSize = true;
            this.lbExpressionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbExpressionTitle.Location = new System.Drawing.Point(12, 11);
            this.lbExpressionTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbExpressionTitle.Name = "lbExpressionTitle";
            this.lbExpressionTitle.Size = new System.Drawing.Size(106, 24);
            this.lbExpressionTitle.TabIndex = 53;
            this.lbExpressionTitle.Text = "Expression";
// 
// Expression
// 
            this.Controls.Add(this.lbExpressionTitle);
            this.Controls.Add(this.dlUnit);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dlDivisionCost);
            this.Controls.Add(this.dlDivision);
            this.Controls.Add(this.lbAssemblyID);
            this.Controls.Add(this.dlAssembly);
            this.Controls.Add(this.uiTabEstimate);
            this.Controls.Add(this.txtExpressionID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.lbDivisionCost);
            this.Name = "Expression";
            this.Size = new System.Drawing.Size(585, 575);
     
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage5.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabEstimate)).EndInit();
            this.uiTabEstimate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
  
    

   
		#endregion


       

        void dlBuildingType_DropDown(object sender, EventArgs e)
        {
            this.dlBuildingType.DataSource = EstimateBuilder.Builder.DataSourceType;
            this.dlBuildingType.DisplayMember = "Description";
            this.dlBuildingType.ValueMember = "Description";
            this.dlBuildingType.SelectedValue = 0;

        }


        void dlUnit_DropDown(object sender, EventArgs e)
        {
            this.dlUnit.DataSource = EstimateBuilder.Builder.DataSourceDivisionUnits;
            this.dlUnit.DisplayMember = "Description";
            this.dlUnit.ValueMember = "Description";
            this.dlUnit.SelectedValue = 0;
        }

        void dlDivision_DropDown(object sender, EventArgs e)
        {

            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
            this.dlDivision.SelectedValue = 0;
        }

        public void Expression_Load()
		{
            Guid = System.Guid.NewGuid().ToString("N");
            this.Visible = true;
            EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.False;
            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Insert;
            Random random = new Random();
           this.txtExpressionID.Text = random.Next(999999).ToString();
           _jobID = "0";

           this.dlAssembly.DataSource = EstimateBuilder.Builder.DataSourceAssemblyIDName;
           this.dlAssembly.DisplayMember = "Name";
           this.dlAssembly.ValueMember = "AssemblyID";
           this.dlAssembly.SelectedValue = 1;

       }

        private void loadTree(string _jobID,string _buildingType)
        {
            
            EstimateBuilder.data1 _data = new EstimateBuilder.data1();
         
            this.trTakeOff.Nodes.Clear();
            this.trExpression.Nodes.Clear();

            TreeNode nodeParentTakeOffDivision;

            foreach (DataRow row in _data.TakeOffDivision(_jobID, _buildingType).Rows)
            {
                nodeParentTakeOffDivision = this.trTakeOff.Nodes.Add(row["Division_takeoff"].ToString());
                nodeParentTakeOffDivision.Tag = row;
                nodeParentTakeOffDivision.Nodes.Add("*");
                nodeParentTakeOffDivision.LastNode.Nodes.Add("*");
            }

            TreeNode nodeParentExpression;

            foreach (DataRow row in _data.ExpressionDivision(_jobID).Rows)
            {
                nodeParentExpression = this.trExpression.Nodes.Add(row["Division"].ToString());
                nodeParentExpression.Tag = row;

                //nodeParent.ImageIndex =0;
                nodeParentExpression.Nodes.Add("*");
            }

        }
       

        private void trTakeOff_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
		
			EstimateBuilder.data1 _data = new EstimateBuilder.data1();
			TreeNode nodeSelected, nodeChild;
            TreeNode nodeParentTakeOffDivisionCost;
            TreeNode nodeParentTakeOffDivisionPrint;

            string i = this._jobID;
            string k = this.dlBuildingType.Text;
            string y;

            nodeSelected = e.Node;

			if(nodeSelected.Nodes[0].Text =="*")
			{
				nodeSelected.Nodes.Clear();
				System.Data.DataRow ID1 = (System.Data.DataRow) nodeSelected.Tag;


                foreach (DataRow row1 in _data.TakeOffDivisionCost(ID1.ItemArray[0].ToString(), i,k).Rows)
                {
                    y = row1["DivisionCost_takeoff"].ToString();
                    nodeParentTakeOffDivisionCost = nodeSelected.Nodes.Add(y);
                    nodeParentTakeOffDivisionCost.Tag = row1;



                    foreach (DataRow row2 in _data.TakeOffDivisionPrint(row1.ItemArray[0].ToString(), i,k).Rows)
                    {

                            nodeParentTakeOffDivisionCost.Tag = row2;

                            nodeParentTakeOffDivisionPrint = nodeSelected.LastNode.Nodes.Add(row2["DivisionPrint_takeoff"].ToString());
                            nodeParentTakeOffDivisionPrint.Tag = row2;
                           
                            
                                foreach (DataRow row3 in _data.getTakeOff(y,row2.ItemArray[0].ToString(),this._jobID,k).Rows)
                                {
                                    string field = row3["Description_takeoff"].ToString();
                                    nodeChild = nodeSelected.LastNode.LastNode.Nodes.Add(field);
                                    
                                    nodeChild.Tag = row3;
                                }
                           

                        }
                   
                }


             
			}

		}
		
		private void trExpression_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{	
			EstimateBuilder.data1 _data = new EstimateBuilder.data1();
			TreeNode nodeSelected, nodeChild;
			nodeSelected = e.Node;

			if(nodeSelected.Nodes[0].Text =="*")
			{
				nodeSelected.Nodes.Clear();
				System.Data.DataRow ID = (System.Data.DataRow) nodeSelected.Tag;
                foreach (DataRow row in _data.getExpression(ID.ItemArray[0].ToString(), this._jobID).Rows)
                {
					string field = row["Description"].ToString();
					nodeChild = nodeSelected.Nodes.Add(field);
					nodeChild.Tag = row;
				}
			}

		}


        protected EstimateBuilder.data1 _data1 = new EstimateBuilder.data1();
        protected EstimateBuilder.data1 _data2 = new EstimateBuilder.data1();

        void trTakeOff_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Data.DataRow ID = (System.Data.DataRow)e.Node.Tag;


            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {

                try
                {
                    

                    int cursor = this.txtExpression.SelectionStart;
                    if (cursor > 0)
                    {
                        this.txtExpression.Text.Insert(cursor, " [" + ID.ItemArray[1].ToString().Replace(" ", "_") + "] ");
                        this._expression.Insert(cursor, " [" + ID.ItemArray[0].ToString() + "] ");
                    }
                    else
                    {
                        this.txtExpression.Text += " [" + ID.ItemArray[1].ToString().Replace(" ", "_") + "] ";
                        this._expression += " [" + ID.ItemArray[0].ToString() + "] ";
                    }

                    this.txtExpression.Text += " ";
                    this._expression += " ";
                    this.trTakeOff.SelectedNode = null;

                }


                catch { }
            }
        }

        void trTakeOff_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            System.Data.DataRow ID = (System.Data.DataRow)e.Node.Tag;
            try
            {
                this.trTakeOff.ShowNodeToolTips = true;
                e.Node.ToolTipText = ID.ItemArray[3].ToString();
                this.txtTakeoffValue.Text = ID.ItemArray[2].ToString();
            
            }

            catch { }
        }


  

		private void trExpression_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		    
			System.Data.DataRow ID = (System.Data.DataRow) e.Node.Tag;
			try
			{
                int cursor = this.txtExpression.SelectionStart;
                if (cursor > 0)
                {
                    this.txtExpression.Text.Insert(cursor, " <" + ID.ItemArray[1].ToString().Replace(" ", "_") + "> ");
                    this._expression.Insert(cursor, " <" + ID.ItemArray[0].ToString() + "> ");
                }
                else
                {
                    this.txtExpression.Text += " <" + ID.ItemArray[1].ToString().Replace(" ", "_") + "> ";
                    this._expression += " <" + ID.ItemArray[0].ToString() + "> ";
                }

               
                this.txtExpression.Text += " ";
           
                this._expression += " ";
                this.trExpression.SelectedNode = null;
            }
			catch  {}

		}


        protected String _expression;
   
        private void EnabledTreeFalse()
        {
            EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.True;
            this.txtExpression.BackColor = System.Drawing.Color.LightGray;
            this.trTakeOff.BackColor = System.Drawing.Color.LightGray;
            this.trTakeOff.Enabled = false;
            this.trExpression.BackColor = System.Drawing.Color.LightGray;
            this.trExpression.Enabled = false;

            this.trTakeOff.SelectedNode = null;
            this.trExpression.SelectedNode = null;
   

        }
        private void EnabledTreeTrue()
        {
            EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.False;
            this.txtExpression.BackColor = System.Drawing.Color.White;
            this.trTakeOff.BackColor = System.Drawing.Color.White;
            this.trTakeOff.Enabled = true;
            this.trExpression.BackColor = System.Drawing.Color.White;
            this.trExpression.Enabled = true;

       
            this.trTakeOff.SelectedNode = null;
            this.trExpression.SelectedNode = null;
            this.txtResult.Text = "0";
        }

        private void insertOp(string _op, string _strExpression1, string _strExpression2)
        {
            int start = this.txtExpression.SelectionStart ;
            int cursor = _Cursor(_op, _strExpression1, start);
            this.txtExpression.Text = _insert(_op, _strExpression1, cursor);
            this._expression = _insert(_op, _strExpression2, cursor );
            start = 0;

        }

        private int _Cursor(string _op, string _strExpression, int start)
        {
            int cursor = 0;
            if ((start > 0)&&(start < _strExpression.Length))
            {
                for (int i=0; i<start;i++)
                {
                        if (_strExpression.Substring(i, 1) == " ")
                            cursor += 1;
                }
            }
            else
            {
                cursor = 0;
            }
            return cursor;
        }


        private string _insert(string _op, string _strExpression, int cursor)
        {
            if ((cursor > 0)&&(_strExpression!=null))
            {
            const char del1 = ' ';
                char[] delimiter = new char[] { del1 };
                string[] str1 = _strExpression.Split(delimiter);
                string beg = null, end = null;
                for (int j = 0; j < cursor; j++)
                {
                    beg += " " + str1[j].ToString();
                }
                for (int k = cursor; k < str1.Length; k++)
                {
                    end += " " + str1[k].ToString();
                }
                _strExpression = beg + " " + _op + end;
            }
            else
            {
                _strExpression += _op;
            }
            _strExpression = _strExpression.Replace("  ", " ");
            return _strExpression;
        }

        #region Click

        private void btOK_Click(object sender, EventArgs e)
        {
            if ((_expression != null)
                && (EstimateBuilder.ApplicationBuilder.SaveExpressionMode == SaveExpression.False))
            {
                const char del1 = ' ';
                char[] delimiter = new char[] { del1 };

                String[] expression = _expression.Split(delimiter);

                if (EstimateBuilder.ApplicationBuilder.EditMode != DataFormEditMode.Edit)
                {
                    _data1.Description = this.txtDescription.Text;
                    _data1.GuidID = Guid;
                    _data1.ID = this.txtExpressionID.Text;
                    _data1.Key = "0";
                    _data1.Value = "0";
                    _data2.add(_data1);
                }

                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] == "(")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "0";
                        _data1.Value = "0";
                        _data2.add(_data1);
                    }
                    if (expression[i] == ")")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "9";
                        _data1.Value = "9";
                        _data2.add(_data1);
                    }

                    if (expression[i] == "+")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "002";
                        _data1.Value = "1";
                        _data2.add(_data1);
                    }
                    else if (expression[i] == "-")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "002";
                        _data1.Value = "2";
                        _data2.add(_data1);
                    }
                    else if (expression[i] == "*")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "002";
                        _data1.Value = "3";
                        _data2.add(_data1);
                    }
                    else if (expression[i] == "/")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "002";
                        _data1.Value = "4";
                        _data2.add(_data1);
                    }

                    else if (expression[i].StartsWith("["))
                    {
                        expression[i] = expression[i].Replace("[", "");
                        expression[i] = expression[i].Replace("]", "");

                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "003";
                        _data1.Value = expression[i];
                        _data2.add(_data1);
                    }

                    else if (expression[i].StartsWith("<"))
                    {
                        expression[i] = expression[i].Replace("<", "");
                        expression[i] = expression[i].Replace(">", "");

                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "004";
                        _data1.Value = expression[i];
                        _data2.add(_data1);
                    }
                    else if (expression[i] != "")
                    {
                        _data1.Description = this.txtDescription.Text;
                        _data1.GuidID = Guid;
                        _data1.ID = this.txtExpressionID.Text;
                        _data1.Key = "001";
                        _data1.Value = expression[i].ToString();
                        _data2.add(_data1);
                    }
                }

                _data1.Description = this.txtDescription.Text;
                _data1.GuidID = Guid;
                _data1.ID = this.txtExpressionID.Text;
                _data1.Key = "9";
                _data1.Value = "9";
                _data2.add(_data1);


                EnabledTreeFalse();


            }

            this.txtResult.Text = EstimateBuilder.Operators.Calculate(this.txtExpressionID.Text, this._jobID).ToString();

        }

        private void btClear_Click(object sender, System.EventArgs e)
        {
            _data2.delete(this.txtExpressionID.Text);
            EnabledTreeTrue();
            this._expression = "";
            this.txtExpression.Text = "";
            EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.False;

        }

        //M- button
        private void btDel_Click(object sender, EventArgs e)
        {
            if (EstimateBuilder.ApplicationBuilder.EditMode != DataFormEditMode.Edit)
            {
                _data2.deleteGuid(Guid);
                EnabledTreeTrue();
                Guid = System.Guid.NewGuid().ToString("N");
                this.txtResult.Text = "";
                //this._expression = _expression;
                // this.txtExpression.Text = "";
                EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.False;
            }

        }

        private void btC_Click(object sender, EventArgs e)
        {
            if ((EstimateBuilder.ApplicationBuilder.EditMode != DataFormEditMode.Edit)
                &&(EstimateBuilder.ApplicationBuilder.SaveExpressionMode == SaveExpression.False))
            {
                this.txtExpression.Text = this.txtExpression.Text.TrimEnd();
                _expression = _expression.TrimEnd();

                if (this.txtExpression.SelectionStart == 0)
                {
                    try
                    {
                        this.txtExpression.Text = this.txtExpression.Text.Substring(0, this.txtExpression.Text.LastIndexOf(" "));
                        this._expression = this._expression.Substring(0, this._expression.LastIndexOf(" "));
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        this.txtExpression.Text = this.txtExpression.Text.Substring(0, this.txtExpression.SelectionStart);
                        this._expression = this._expression.Substring(0, this.txtExpression.SelectionStart);
                    }
                    catch { }


                }
                this.trTakeOff.SelectedNode = null;
                this.txtResult.Text = "0";
            }

        }

        private void btOperation1_Click(object sender, System.EventArgs e)
    
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" + ", this.txtExpression.Text, _expression);
            }
        }

		private void btOperation2_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" - ", this.txtExpression.Text, _expression);
            }
   
        }

		private void btOperation3_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" * ", this.txtExpression.Text, _expression);
            }
        }

		private void btOperation4_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" / ", this.txtExpression.Text, _expression);
            }
        }

		private void btOne_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("1", this.txtExpression.Text, _expression);
            }
        }

		private void btTwo_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("2", this.txtExpression.Text, _expression);
            }

        }

        private void btThree_Click(object sender, System.EventArgs e)
        {
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("3", this.txtExpression.Text, _expression);
            }
        }
        
        private void btFour_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("4", this.txtExpression.Text, _expression);
            }

        }

		private void btFive_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("5", this.txtExpression.Text, _expression);
            }

        }

		private void btSix_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("6", this.txtExpression.Text, _expression);
            }

        }

		private void btSeven_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("7", this.txtExpression.Text, _expression);
            }

        }

		private void btEight_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("8", this.txtExpression.Text, _expression);
            }

        }

		private void btNine_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("9", this.txtExpression.Text, _expression);
            }

        }

		private void btZero_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp("0", this.txtExpression.Text, _expression);
            }

        }

        private void btPeriod_Click(object sender, EventArgs e)
        {
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(".", this.txtExpression.Text, _expression);
            }

        }

        private void btLeftParenthesis_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" ( ", this.txtExpression.Text, _expression);
            }

        }

		private void btRightParenthesis_Click(object sender, System.EventArgs e)
		{
            if (EstimateBuilder.ApplicationBuilder.SaveExpressionMode != SaveExpression.True)
            {
                insertOp(" ) ", this.txtExpression.Text, _expression);
            }

        }
#endregion

        #region Dropdown
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

        void dlJob_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _jobID = this.dlJob.SelectedValue.ToString();

            string i = "";
            if (this.dlBuildingType.SelectedIndex != -1)
            {
                i = this.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                 i = this.dlBuildingType.Text;
            }
           
            loadTree(_jobID,i);
            this.txtResult.Text = EstimateBuilder.Operators.Calculate(this.txtExpressionID.Text, this._jobID).ToString();
        }

        
        void dlBuildingType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string i = "";
            if (this.dlBuildingType.SelectedIndex != -1)
            {
                i = this.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                i = this.dlBuildingType.Text;
            }
          
            loadBuildingTypeJob(i);

        }

        public void loadBuildingTypeJob(string i)
        {
            EstimateBuilder.ListDataProvider list = new EstimateBuilder.ListDataProvider();
            this.dlJob.DataSource = list.JobIDJob(i);
            this.dlJob.DisplayMember = "Job";
            this.dlJob.ValueMember = "JobID";
            this.dlJob.SelectedValue = 0;
            this.dlJob.Text = "";

            _jobID = "0";

            loadTree(_jobID, i);

        }
        #endregion




       
    }
}
