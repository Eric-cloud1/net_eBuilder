using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for ValidationUser.
	/// </summary>
	public class ValidationUser : System.Windows.Forms.UserControl
	{
		private Janus.Windows.UI.Tab.UITab uiTabValidationUser;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
		private System.Windows.Forms.Label lbGroup;
		private System.Windows.Forms.Label lbDescripton;
		private System.Windows.Forms.Label lbCode;
		private System.Windows.Forms.Label lbType;



		public System.Windows.Forms.TextBox txtDescriptionUser;
		public System.Windows.Forms.TextBox txtCodeUser;
		public System.Windows.Forms.CheckBox chkActive;
		public System.Windows.Forms.CheckBox chkPullDown;
		public System.Windows.Forms.TextBox txtValidationUserID;
		public System.Windows.Forms.ComboBox dlTypeUser;
        public System.Windows.Forms.ComboBox dlGroupUser;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
		public System.Windows.Forms.TextBox txtMemoUser;
        private Label label2;
        private Label label11;
        private Label label3;
        private Label lbValidatyionUserTitle;
        private Label lbCheckBox;

        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ValidationUser()
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
            this.uiTabValidationUser = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.lbCheckBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dlGroupUser = new System.Windows.Forms.ComboBox();
            this.dlTypeUser = new System.Windows.Forms.ComboBox();
            this.chkPullDown = new System.Windows.Forms.CheckBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemoUser = new System.Windows.Forms.TextBox();
            this.txtDescriptionUser = new System.Windows.Forms.TextBox();
            this.txtCodeUser = new System.Windows.Forms.TextBox();
            this.lbDescripton = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.txtValidationUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValidatyionUserTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiTabValidationUser)).BeginInit();
            this.uiTabValidationUser.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabValidationUser
            // 
            this.uiTabValidationUser.BackColor = System.Drawing.Color.Transparent;
            this.uiTabValidationUser.Controls.Add(this.uiTabPage1);
            this.uiTabValidationUser.Controls.Add(this.uiTabPage2);
            this.uiTabValidationUser.Location = new System.Drawing.Point(20, 136);
            this.uiTabValidationUser.Name = "uiTabValidationUser";
            this.uiTabValidationUser.SelectedIndex = 0;
            this.uiTabValidationUser.Size = new System.Drawing.Size(521, 180);
            this.uiTabValidationUser.TabIndex = 8;
            this.uiTabValidationUser.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.uiTabValidationUser.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.lbCheckBox);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.label11);
            this.uiTabPage1.Controls.Add(this.dlGroupUser);
            this.uiTabPage1.Controls.Add(this.dlTypeUser);
            this.uiTabPage1.Controls.Add(this.chkPullDown);
            this.uiTabPage1.Controls.Add(this.chkActive);
            this.uiTabPage1.Controls.Add(this.lbType);
            this.uiTabPage1.Controls.Add(this.lbGroup);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(519, 158);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "ValidationUser";
            // 
            // lbCheckBox
            // 
            this.lbCheckBox.AutoSize = true;
            this.lbCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckBox.Location = new System.Drawing.Point(22, 92);
            this.lbCheckBox.Name = "lbCheckBox";
            this.lbCheckBox.Size = new System.Drawing.Size(128, 20);
            this.lbCheckBox.TabIndex = 31;
            this.lbCheckBox.Text = "Validation Type";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(345, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "*";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(345, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
            // 
            // dlGroupUser
            // 
            this.dlGroupUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlGroupUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlGroupUser.FormattingEnabled = true;
            this.dlGroupUser.Location = new System.Drawing.Point(134, 25);
            this.dlGroupUser.Name = "dlGroupUser";
            this.dlGroupUser.Size = new System.Drawing.Size(186, 21);
            this.dlGroupUser.TabIndex = 4;
            this.dlGroupUser.DropDown += new System.EventHandler(this.dlGroupUser_DropDown);
            // 
            // dlTypeUser
            // 
            this.dlTypeUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dlTypeUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlTypeUser.FormattingEnabled = true;
            this.dlTypeUser.Location = new System.Drawing.Point(134, 54);
            this.dlTypeUser.Name = "dlTypeUser";
            this.dlTypeUser.Size = new System.Drawing.Size(186, 21);
            this.dlTypeUser.TabIndex = 5;
            this.dlTypeUser.DropDown += new System.EventHandler(this.dlTypeUser_DropDown);
            // 
            // chkPullDown
            // 
            this.chkPullDown.BackColor = System.Drawing.Color.Transparent;
            this.chkPullDown.Location = new System.Drawing.Point(258, 117);
            this.chkPullDown.Name = "chkPullDown";
            this.chkPullDown.Size = new System.Drawing.Size(78, 24);
            this.chkPullDown.TabIndex = 7;
            this.chkPullDown.Text = "pullDown";
            this.chkPullDown.UseVisualStyleBackColor = false;
            // 
            // chkActive
            // 
            this.chkActive.BackColor = System.Drawing.Color.Transparent;
            this.chkActive.Location = new System.Drawing.Point(175, 116);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(66, 24);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = false;
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Location = new System.Drawing.Point(36, 54);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(56, 16);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type";
            // 
            // lbGroup
            // 
            this.lbGroup.BackColor = System.Drawing.Color.Transparent;
            this.lbGroup.Location = new System.Drawing.Point(36, 25);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(64, 16);
            this.lbGroup.TabIndex = 0;
            this.lbGroup.Text = "Group";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.txtMemoUser);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(519, 158);
            this.uiTabPage2.TabIndex = 1;
            this.uiTabPage2.Text = "Memo";
            // 
            // txtMemoUser
            // 
            this.txtMemoUser.AutoSize = false;
            this.txtMemoUser.Location = new System.Drawing.Point(22, 14);
            this.txtMemoUser.Multiline = true;
            this.txtMemoUser.Name = "txtMemoUser";
            this.txtMemoUser.Size = new System.Drawing.Size(456, 127);
            this.txtMemoUser.TabIndex = 9;
            // 
            // txtDescriptionUser
            // 
            this.txtDescriptionUser.AutoSize = false;
            this.txtDescriptionUser.Location = new System.Drawing.Point(104, 60);
            this.txtDescriptionUser.Multiline = true;
            this.txtDescriptionUser.Name = "txtDescriptionUser";
            this.txtDescriptionUser.Size = new System.Drawing.Size(320, 26);
            this.txtDescriptionUser.TabIndex = 1;
            // 
            // txtCodeUser
            // 
            this.txtCodeUser.AutoSize = false;
            this.txtCodeUser.Location = new System.Drawing.Point(104, 92);
            this.txtCodeUser.Multiline = true;
            this.txtCodeUser.Name = "txtCodeUser";
            this.txtCodeUser.Size = new System.Drawing.Size(151, 26);
            this.txtCodeUser.TabIndex = 2;
            // 
            // lbDescripton
            // 
            this.lbDescripton.BackColor = System.Drawing.Color.Transparent;
            this.lbDescripton.Location = new System.Drawing.Point(24, 65);
            this.lbDescripton.Name = "lbDescripton";
            this.lbDescripton.Size = new System.Drawing.Size(64, 16);
            this.lbDescripton.TabIndex = 0;
            this.lbDescripton.Text = "Description";
            // 
            // lbCode
            // 
            this.lbCode.BackColor = System.Drawing.Color.Transparent;
            this.lbCode.Location = new System.Drawing.Point(24, 96);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(64, 16);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Code";
            // 
            // txtValidationUserID
            // 
            this.txtValidationUserID.Location = new System.Drawing.Point(473, 22);
            this.txtValidationUserID.Name = "txtValidationUserID";
            this.txtValidationUserID.ReadOnly = true;
            this.txtValidationUserID.Size = new System.Drawing.Size(40, 20);
            this.txtValidationUserID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(440, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // lbValidatyionUserTitle
            // 
            this.lbValidatyionUserTitle.AutoSize = true;
            this.lbValidatyionUserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbValidatyionUserTitle.Location = new System.Drawing.Point(24, 16);
            this.lbValidatyionUserTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbValidatyionUserTitle.Name = "lbValidatyionUserTitle";
            this.lbValidatyionUserTitle.Size = new System.Drawing.Size(103, 16);
            this.lbValidatyionUserTitle.TabIndex = 119;
            this.lbValidatyionUserTitle.Text = "Validation User";
            // 
            // ValidationUser
            // 
            this.Controls.Add(this.lbValidatyionUserTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValidationUserID);
            this.Controls.Add(this.uiTabValidationUser);
            this.Controls.Add(this.txtDescriptionUser);
            this.Controls.Add(this.lbDescripton);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.txtCodeUser);
            this.Name = "ValidationUser";
            this.Size = new System.Drawing.Size(575, 345);
            ((System.ComponentModel.ISupportInitialize)(this.uiTabValidationUser)).EndInit();
            this.uiTabValidationUser.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            this.uiTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		
		public void ValidationUser_Load()
		{
			this.Visible =true;
		}



        void dlGroupUser_DropDown(object sender, EventArgs e)
        {
            this.dlGroupUser.DataSource = EstimateBuilder.Builder.DataSourceValidationGroup;
            this.dlGroupUser.DisplayMember = "Group";
            this.dlGroupUser.ValueMember = "Group";
        }

        void dlTypeUser_DropDown(object sender, EventArgs e)
        {
            this.dlTypeUser.DataSource = EstimateBuilder.Builder.DataSourceValidationType;
            this.dlTypeUser.DisplayMember = "Type";
            this.dlTypeUser.ValueMember = "Type";
        }
    }
}
