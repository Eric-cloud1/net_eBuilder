using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for CostItem.
	/// </summary>
	public class CostItem : System.Windows.Forms.UserControl
	{
		
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCostType;
        private System.Windows.Forms.Label lbCostAdjustment;
        private Janus.Windows.UI.Tab.UITab uiTabCostItem;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;


        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtCostAdjustment;
        public System.Windows.Forms.ComboBox dlCostType;
        public System.Windows.Forms.CheckBox chkActive;
        public System.Windows.Forms.TextBox txtMemo;
        public System.Windows.Forms.TextBox txtID;
        public ComboBox dlUnitOrder;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Label lbUnitOrder;
        private Label label5;
        private Label label4;
        private Label label21;
        private Label label20;
        private Label label24;
        public TextBox txtMinimumOrder;
        private Label lbMinimumOrder;
        public ComboBox dlDivisionCost;
        private Label label14;
        private Label label13;
        public ComboBox dlDivision;
        private Label lbDivision;
        private Label lbDivisionCost;
        private Label lbAdjustment;
        private Label lbDivision2;
        private Label lbTitle;
        private Label label3;
        private Label lbPovider;
        public ComboBox dlProvider;

        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CostItem()
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCostType = new System.Windows.Forms.Label();
            this.txtCostAdjustment = new System.Windows.Forms.TextBox();
            this.lbCostAdjustment = new System.Windows.Forms.Label();
            this.uiTabCostItem = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPovider = new System.Windows.Forms.Label();
            this.dlProvider = new System.Windows.Forms.ComboBox();
            this.lbDivision2 = new System.Windows.Forms.Label();
            this.lbAdjustment = new System.Windows.Forms.Label();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.lbDivision = new System.Windows.Forms.Label();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtMinimumOrder = new System.Windows.Forms.TextBox();
            this.lbMinimumOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dlUnitOrder = new System.Windows.Forms.ComboBox();
            this.lbUnitOrder = new System.Windows.Forms.Label();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.dlCostType = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabCostItem)).BeginInit();
            this.uiTabCostItem.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = false;
            this.txtDescription.Location = new System.Drawing.Point(85, 40);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(16, 45);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(64, 16);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
            // 
            // lbCostType
            // 
            this.lbCostType.BackColor = System.Drawing.Color.Transparent;
            this.lbCostType.Location = new System.Drawing.Point(348, 45);
            this.lbCostType.Name = "lbCostType";
            this.lbCostType.Size = new System.Drawing.Size(64, 16);
            this.lbCostType.TabIndex = 0;
            this.lbCostType.Text = "Cost Type";
            // 
            // txtCostAdjustment
            // 
            this.txtCostAdjustment.AutoSize = false;
            this.txtCostAdjustment.Location = new System.Drawing.Point(140, 189);
            this.txtCostAdjustment.Multiline = true;
            this.txtCostAdjustment.Name = "txtCostAdjustment";
            this.txtCostAdjustment.Size = new System.Drawing.Size(88, 26);
            this.txtCostAdjustment.TabIndex = 8;
            this.txtCostAdjustment.Text = "1";
            // 
            // lbCostAdjustment
            // 
            this.lbCostAdjustment.BackColor = System.Drawing.Color.Transparent;
            this.lbCostAdjustment.Location = new System.Drawing.Point(23, 195);
            this.lbCostAdjustment.Name = "lbCostAdjustment";
            this.lbCostAdjustment.Size = new System.Drawing.Size(88, 16);
            this.lbCostAdjustment.TabIndex = 0;
            this.lbCostAdjustment.Text = "Cost Adjustment";
            // 
            // uiTabCostItem
            // 
            this.uiTabCostItem.BackColor = System.Drawing.Color.Transparent;
            this.uiTabCostItem.Controls.Add(this.uiTabPage2);
            this.uiTabCostItem.Controls.Add(this.uiTabPage4);
            this.uiTabCostItem.Location = new System.Drawing.Point(8, 73);
            this.uiTabCostItem.Name = "uiTabCostItem";
            this.uiTabCostItem.SelectedIndex = 0;
            this.uiTabCostItem.Size = new System.Drawing.Size(552, 263);
            this.uiTabCostItem.TabIndex = 24;
            this.uiTabCostItem.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage4});
            this.uiTabCostItem.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.label3);
            this.uiTabPage2.Controls.Add(this.lbPovider);
            this.uiTabPage2.Controls.Add(this.dlProvider);
            this.uiTabPage2.Controls.Add(this.lbDivision2);
            this.uiTabPage2.Controls.Add(this.lbAdjustment);
            this.uiTabPage2.Controls.Add(this.dlDivisionCost);
            this.uiTabPage2.Controls.Add(this.label14);
            this.uiTabPage2.Controls.Add(this.label13);
            this.uiTabPage2.Controls.Add(this.dlDivision);
            this.uiTabPage2.Controls.Add(this.lbDivision);
            this.uiTabPage2.Controls.Add(this.lbDivisionCost);
            this.uiTabPage2.Controls.Add(this.label24);
            this.uiTabPage2.Controls.Add(this.txtMinimumOrder);
            this.uiTabPage2.Controls.Add(this.lbMinimumOrder);
            this.uiTabPage2.Controls.Add(this.label4);
            this.uiTabPage2.Controls.Add(this.label5);
            this.uiTabPage2.Controls.Add(this.dlUnitOrder);
            this.uiTabPage2.Controls.Add(this.lbUnitOrder);
            this.uiTabPage2.Controls.Add(this.lbCostAdjustment);
            this.uiTabPage2.Controls.Add(this.txtCostAdjustment);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(550, 241);
            this.uiTabPage2.TabIndex = 3;
            this.uiTabPage2.Text = "Adjustment";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(427, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "*";
            // 
            // lbPovider
            // 
            this.lbPovider.BackColor = System.Drawing.Color.Transparent;
            this.lbPovider.Location = new System.Drawing.Point(24, 43);
            this.lbPovider.Name = "lbPovider";
            this.lbPovider.Size = new System.Drawing.Size(80, 16);
            this.lbPovider.TabIndex = 58;
            this.lbPovider.Text = "Contractor";
            // 
            // dlProvider
            // 
            this.dlProvider.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlProvider.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlProvider.FormattingEnabled = true;
            this.dlProvider.Location = new System.Drawing.Point(140, 40);
            this.dlProvider.Name = "dlProvider";
            this.dlProvider.Size = new System.Drawing.Size(272, 21);
            this.dlProvider.TabIndex = 57;
            this.dlProvider.DropDown += new System.EventHandler(this.dlProvider_DropDown);
            // 
            // lbDivision2
            // 
            this.lbDivision2.AutoSize = true;
            this.lbDivision2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDivision2.Location = new System.Drawing.Point(23, 8);
            this.lbDivision2.Name = "lbDivision2";
            this.lbDivision2.Size = new System.Drawing.Size(41, 20);
            this.lbDivision2.TabIndex = 48;
            this.lbDivision2.Text = "Item";
            // 
            // lbAdjustment
            // 
            this.lbAdjustment.AutoSize = true;
            this.lbAdjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdjustment.Location = new System.Drawing.Point(23, 161);
            this.lbAdjustment.Name = "lbAdjustment";
            this.lbAdjustment.Size = new System.Drawing.Size(153, 20);
            this.lbAdjustment.TabIndex = 47;
            this.lbAdjustment.Text = "Cost Adjustement ";
            // 
            // dlDivisionCost
            // 
            this.dlDivisionCost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(140, 104);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(272, 21);
            this.dlDivisionCost.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(427, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "*";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(427, 72);
            this.label13.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "*";
            // 
            // dlDivision
            // 
            this.dlDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(140, 72);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(272, 21);
            this.dlDivision.TabIndex = 41;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.dlDivision_SelectionChangeCommitted);
            this.dlDivision.DropDown += new System.EventHandler(this.dlDivision_DropDown);
            // 
            // lbDivision
            // 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.Location = new System.Drawing.Point(23, 77);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(96, 16);
            this.lbDivision.TabIndex = 42;
            this.lbDivision.Text = "Division";
            // 
            // lbDivisionCost
            // 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(23, 104);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(112, 16);
            this.lbDivisionCost.TabIndex = 43;
            this.lbDivisionCost.Text = "Division Cost";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(500, 189);
            this.label24.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 37;
            this.label24.Text = "*";
            // 
            // txtMinimumOrder
            // 
            this.txtMinimumOrder.AutoSize = false;
            this.txtMinimumOrder.Location = new System.Drawing.Point(405, 191);
            this.txtMinimumOrder.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.txtMinimumOrder.Multiline = true;
            this.txtMinimumOrder.Name = "txtMinimumOrder";
            this.txtMinimumOrder.Size = new System.Drawing.Size(87, 26);
            this.txtMinimumOrder.TabIndex = 9;
            this.txtMinimumOrder.Text = "1";
            // 
            // lbMinimumOrder
            // 
            this.lbMinimumOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbMinimumOrder.Location = new System.Drawing.Point(295, 195);
            this.lbMinimumOrder.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lbMinimumOrder.Name = "lbMinimumOrder";
            this.lbMinimumOrder.Size = new System.Drawing.Size(102, 25);
            this.lbMinimumOrder.TabIndex = 34;
            this.lbMinimumOrder.Text = "Minimum Order";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(236, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(307, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "*";
            // 
            // dlUnitOrder
            // 
            this.dlUnitOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlUnitOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlUnitOrder.FormattingEnabled = true;
            this.dlUnitOrder.Location = new System.Drawing.Point(140, 135);
            this.dlUnitOrder.Margin = new System.Windows.Forms.Padding(3, 3, 2, 1);
            this.dlUnitOrder.Name = "dlUnitOrder";
            this.dlUnitOrder.Size = new System.Drawing.Size(152, 21);
            this.dlUnitOrder.TabIndex = 4;
            this.dlUnitOrder.DropDown += new System.EventHandler(this.dlUnitOrder_DropDown);
            // 
            // lbUnitOrder
            // 
            this.lbUnitOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbUnitOrder.Location = new System.Drawing.Point(23, 135);
            this.lbUnitOrder.Name = "lbUnitOrder";
            this.lbUnitOrder.Size = new System.Drawing.Size(56, 16);
            this.lbUnitOrder.TabIndex = 23;
            this.lbUnitOrder.Text = "Unit Order";
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.Controls.Add(this.txtMemo);
            this.uiTabPage4.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(550, 218);
            this.uiTabPage4.TabIndex = 15;
            this.uiTabPage4.Text = "Memo";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(7, 16);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(536, 184);
            this.txtMemo.TabIndex = 17;
            // 
            // chkActive
            // 
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(385, 16);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(64, 24);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Active";
            // 
            // dlCostType
            // 
            this.dlCostType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlCostType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlCostType.FormattingEnabled = true;
            this.dlCostType.Location = new System.Drawing.Point(410, 42);
            this.dlCostType.Name = "dlCostType";
            this.dlCostType.Size = new System.Drawing.Size(150, 21);
            this.dlCostType.TabIndex = 2;
            this.dlCostType.DropDown += new System.EventHandler(this.dlCostType_DropDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(467, 17);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(64, 20);
            this.txtID.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(574, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(315, 38);
            this.label21.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "*";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbTitle.Location = new System.Drawing.Point(16, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(65, 16);
            this.lbTitle.TabIndex = 49;
            this.lbTitle.Text = "Cost Item";
            // 
            // CostItem
            // 
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.uiTabCostItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.dlCostType);
            this.Controls.Add(this.lbCostType);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkActive);
            this.Name = "CostItem";
            this.Size = new System.Drawing.Size(575, 345);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabCostItem)).EndInit();
            this.uiTabCostItem.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage2.PerformLayout();
            this.uiTabPage4.ResumeLayout(false);
            this.uiTabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
		#endregion

		public void CostItem_Load()
		{
			this.Visible =true;
		}



        void dlDivision_SelectionChangeCommitted(object sender, EventArgs e)
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

        void dlProvider_DropDown(object sender, EventArgs e)
        {

            this.dlProvider.DataSource = EstimateBuilder.Builder.DataSourceContract;
            this.dlProvider.DisplayMember = "Description";
            this.dlProvider.ValueMember = "Description";
        }

        void dlDivision_DropDown(object sender, EventArgs e)
        {

            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
        }

        void dlCostType_DropDown(object sender, EventArgs e)
        {
            this.dlCostType.DataSource = EstimateBuilder.Builder.DataSourceCostType;
            this.dlCostType.DisplayMember = "Description";
            this.dlCostType.ValueMember = "Description";
        }

        void dlUnitOrder_DropDown(object sender, EventArgs e)
        {

            this.dlUnitOrder.DataSource = EstimateBuilder.Builder.DataSourceUnits;
            this.dlUnitOrder.DisplayMember = "Description";
            this.dlUnitOrder.ValueMember = "Description";

        }

    }
}
