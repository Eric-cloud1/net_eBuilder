using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace EstimateBuilderControl
{
	/// <summary>
	/// Summary description for Assembly.
	/// </summary>
	public class Assembly : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label lbDivision;
		private System.Windows.Forms.Label lbDivisionCost;
		private System.Windows.Forms.Label lbDescription;

		public System.Windows.Forms.PictureBox imgPhotoCAD;
		public System.Windows.Forms.PictureBox imgPhotoImage;
		public System.Windows.Forms.TextBox txtDescription;
		public System.Windows.Forms.TextBox txtMemo;
		public System.Windows.Forms.ComboBox dlDivisionCost;
		public System.Windows.Forms.ComboBox dlDivision;
		public System.Windows.Forms.TextBox txtAssemblyID;


		private Janus.Windows.UI.Tab.UITab uiTab1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private Label lbTitle;




        /// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Assembly()
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
  
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbDivisionCost = new System.Windows.Forms.Label();
            this.lbDivision = new System.Windows.Forms.Label();
            this.imgPhotoImage = new System.Windows.Forms.PictureBox();
            this.imgPhotoCAD = new System.Windows.Forms.PictureBox();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtAssemblyID = new System.Windows.Forms.TextBox();
            this.dlDivision = new System.Windows.Forms.ComboBox();
            this.dlDivisionCost = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
    
            ((System.ComponentModel.ISupportInitialize)(this.imgPhotoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhotoCAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            this.uiTabPage4.SuspendLayout();
            this.SuspendLayout();

// 
// txtMemo
// 
            this.txtMemo.AutoSize = false;
            this.txtMemo.Location = new System.Drawing.Point(11, 18);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(544, 137);
            this.txtMemo.TabIndex = 7;
// 
// txtDescription
// 
            this.txtDescription.AutoSize = false;
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(128, 40);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 26);
            this.txtDescription.TabIndex = 1;
// 
// lbDescription
// 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Location = new System.Drawing.Point(24, 46);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(72, 23);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Description";
// 
// lbDivisionCost
// 
            this.lbDivisionCost.BackColor = System.Drawing.Color.Transparent;
            this.lbDivisionCost.Location = new System.Drawing.Point(24, 107);
            this.lbDivisionCost.Name = "lbDivisionCost";
            this.lbDivisionCost.Size = new System.Drawing.Size(72, 23);
            this.lbDivisionCost.TabIndex = 0;
            this.lbDivisionCost.Text = "Division Cost";
// 
// lbDivision
// 
            this.lbDivision.BackColor = System.Drawing.Color.Transparent;
            this.lbDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDivision.Location = new System.Drawing.Point(24, 81);
            this.lbDivision.Name = "lbDivision";
            this.lbDivision.Size = new System.Drawing.Size(56, 16);
            this.lbDivision.TabIndex = 0;
            this.lbDivision.Text = "Division";
// 
// imgPhotoImage
// 
            this.imgPhotoImage.Location = new System.Drawing.Point(8, 4);
            this.imgPhotoImage.Name = "imgPhotoImage";
            this.imgPhotoImage.Size = new System.Drawing.Size(552, 151);
            this.imgPhotoImage.TabIndex = 7;
            this.imgPhotoImage.TabStop = false;
// 
// imgPhotoCAD
// 
            this.imgPhotoCAD.Location = new System.Drawing.Point(8, 6);
            this.imgPhotoCAD.Name = "imgPhotoCAD";
            this.imgPhotoCAD.Size = new System.Drawing.Size(533, 163);
            this.imgPhotoCAD.TabIndex = 7;
            this.imgPhotoCAD.TabStop = false;
// 
// uiTab1
// 
            this.uiTab1.BackColor = System.Drawing.Color.Transparent;
            this.uiTab1.Controls.Add(this.uiTabPage2);
            this.uiTab1.Controls.Add(this.uiTabPage3);
            this.uiTab1.Controls.Add(this.uiTabPage4);
            this.uiTab1.FirstTabOffset = 4;
            this.uiTab1.Location = new System.Drawing.Point(8, 142);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.SelectedIndex = 2;
            this.uiTab1.Size = new System.Drawing.Size(560, 194);
            this.uiTab1.TabIndex = 9;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3,
            this.uiTabPage4});
            this.uiTab1.TabStop = false;
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
// 
// uiTabPage2
// 
            this.uiTabPage2.Controls.Add(this.imgPhotoCAD);
            this.uiTabPage2.Key = "tabCAD";
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(558, 172);
            this.uiTabPage2.TabIndex = 4;
            this.uiTabPage2.Text = "CAD";
// 
// uiTabPage3
// 
            this.uiTabPage3.Controls.Add(this.imgPhotoImage);
            this.uiTabPage3.Key = "tabImage";
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(558, 172);
            this.uiTabPage3.TabIndex = 5;
            this.uiTabPage3.Text = "Image";
// 
// uiTabPage4
// 
            this.uiTabPage4.Controls.Add(this.txtMemo);
            this.uiTabPage4.Key = "tabNote";
            this.uiTabPage4.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(558, 172);
            this.uiTabPage4.TabIndex = 6;
            this.uiTabPage4.Text = "Memo";
// 
// txtAssemblyID
// 
            this.txtAssemblyID.Location = new System.Drawing.Point(500, 8);
            this.txtAssemblyID.Name = "txtAssemblyID";
            this.txtAssemblyID.ReadOnly = true;
            this.txtAssemblyID.Size = new System.Drawing.Size(50, 20);
            this.txtAssemblyID.TabIndex = 11;
// 
// dlDivision
// 
            this.dlDivision.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivision.FormattingEnabled = true;
            this.dlDivision.Location = new System.Drawing.Point(128, 76);
            this.dlDivision.Name = "dlDivision";
            this.dlDivision.Size = new System.Drawing.Size(250, 21);
            this.dlDivision.TabIndex = 2;
            this.dlDivision.SelectionChangeCommitted += new System.EventHandler(this.Division_Select);
            this.dlDivision.DropDown += new EventHandler(this.dlDivision_MouseDown);
// 
// dlDivisionCost
// 
            this.dlDivisionCost.AutoCompleteMode = ((System.Windows.Forms.AutoCompleteMode)((System.Windows.Forms.AutoCompleteMode.Suggest | System.Windows.Forms.AutoCompleteMode.Append)));
            this.dlDivisionCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dlDivisionCost.DisplayMember = "Description";
            this.dlDivisionCost.FormattingEnabled = true;
            this.dlDivisionCost.Location = new System.Drawing.Point(128, 104);
            this.dlDivisionCost.Name = "dlDivisionCost";
            this.dlDivisionCost.Size = new System.Drawing.Size(250, 21);
            this.dlDivisionCost.TabIndex = 3;
            this.dlDivisionCost.ValueMember = "Description";
// 
// lbTitle
// 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(3)), true);
            this.lbTitle.Location = new System.Drawing.Point(20, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(93, 24);
            this.lbTitle.TabIndex = 50;
            this.lbTitle.Text = "Assembly";
// 
// Assembly
// 
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dlDivisionCost);
            this.Controls.Add(this.dlDivision);
            this.Controls.Add(this.txtAssemblyID);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.lbDivision);
            this.Controls.Add(this.lbDivisionCost);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtDescription);
            this.Name = "Assembly";
            this.Size = new System.Drawing.Size(575, 345);
          
            ((System.ComponentModel.ISupportInitialize)(this.imgPhotoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhotoCAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		public void Assembly_Load()
		{
        }

        private void Division_Select(object sender,EventArgs e)
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


        void dlDivision_MouseDown(object sender, EventArgs e)
        {
            this.Visible = true;
            this.dlDivision.DataSource = EstimateBuilder.Builder.DataSourceDivision;
            this.dlDivision.DisplayMember = "Description";
            this.dlDivision.ValueMember = "Description";
            this.dlDivision.SelectedValue = 0;
        }
    }
}
