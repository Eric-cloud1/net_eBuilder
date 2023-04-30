using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for ValidationSystem.
	/// </summary>
	public class ValidationSystem : System.Windows.Forms.UserControl
	{
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbDescription;


        public System.Windows.Forms.TextBox txtTypeSystem;
		public System.Windows.Forms.TextBox txtDescriptionSystem;
		public System.Windows.Forms.TextBox txtValidationID;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
		public System.Windows.Forms.TextBox txtMemoSystem;
        private Label label1;
        private Label label11;
        private Label lbValidatyionSystemTitle;


        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ValidationSystem()
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
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtMemoSystem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTypeSystem = new System.Windows.Forms.TextBox();
            this.txtDescriptionSystem = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtValidationID = new System.Windows.Forms.TextBox();
            this.lbValidatyionSystemTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.SuspendLayout();
// 
// uiTab1
// 
            this.uiTab1.BackColor = System.Drawing.Color.Transparent;
            this.uiTab1.Controls.Add(this.uiTabPage2);
            this.uiTab1.Location = new System.Drawing.Point(16, 122);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 0;
            this.uiTab1.Size = new System.Drawing.Size(544, 190);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
                this.uiTabPage2
            });
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
// 
// uiTabPage2
// 
            this.uiTabPage2.Controls.Add(this.txtMemoSystem);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(542, 168);
            this.uiTabPage2.TabIndex = 1;
            this.uiTabPage2.Text = "Memo";
// 
// txtMemoSystem
// 
            this.txtMemoSystem.AutoSize = false;
            this.txtMemoSystem.Location = new System.Drawing.Point(15, 15);
            this.txtMemoSystem.Multiline = true;
            this.txtMemoSystem.Name = "txtMemoSystem";
            this.txtMemoSystem.Size = new System.Drawing.Size(508, 144);
            this.txtMemoSystem.TabIndex = 3;
// 
// label1
// 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(305, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "*";
// 
// label11
// 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(395, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
// 
// txtTypeSystem
// 
            this.txtTypeSystem.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtTypeSystem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTypeSystem.AutoSize = false;
            this.txtTypeSystem.Location = new System.Drawing.Point(135, 82);
            this.txtTypeSystem.Multiline = true;
            this.txtTypeSystem.Name = "txtTypeSystem";
            this.txtTypeSystem.Size = new System.Drawing.Size(163, 26);
            this.txtTypeSystem.TabIndex = 2;
// 
// txtDescriptionSystem
// 
            this.txtDescriptionSystem.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.txtDescriptionSystem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtDescriptionSystem.AutoSize = false;
            this.txtDescriptionSystem.Location = new System.Drawing.Point(134, 45);
            this.txtDescriptionSystem.Multiline = true;
            this.txtDescriptionSystem.Name = "txtDescriptionSystem";
            this.txtDescriptionSystem.Size = new System.Drawing.Size(250, 26);
            this.txtDescriptionSystem.TabIndex = 1;
// 
// lbType
// 
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Location = new System.Drawing.Point(41, 87);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(64, 16);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "Type";
// 
// lbDescription
// 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(41, 51);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(72, 16);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
// 
// txtValidationID
// 
            this.txtValidationID.Location = new System.Drawing.Point(492, 22);
            this.txtValidationID.Name = "txtValidationID";
            this.txtValidationID.ReadOnly = true;
            this.txtValidationID.Size = new System.Drawing.Size(48, 20);
            this.txtValidationID.TabIndex = 0;
// 
// lbValidatyionSystemTitle
// 
            this.lbValidatyionSystemTitle.AutoSize = true;
            this.lbValidatyionSystemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbValidatyionSystemTitle.Location = new System.Drawing.Point(16, 15);
            this.lbValidatyionSystemTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.lbValidatyionSystemTitle.Name = "lbValidatyionSystemTitle";
            this.lbValidatyionSystemTitle.Size = new System.Drawing.Size(167, 24);
            this.lbValidatyionSystemTitle.TabIndex = 118;
            this.lbValidatyionSystemTitle.Text = "Validation System";
// 
// ValidationSystem
// 
            this.Controls.Add(this.lbValidatyionSystemTitle);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValidationID);
            this.Controls.Add(this.txtTypeSystem);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.txtDescriptionSystem);
            this.Controls.Add(this.lbDescription);
            this.Name = "ValidationSystem";
            this.Size = new System.Drawing.Size(575, 345);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		public void ValidationSystem_Load()
		{
		}

	
	}
}
