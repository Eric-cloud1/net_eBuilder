using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ValidationUser.
	/// </summary>
	public class ValidationUser : IDIGITALTEKGRID.DataForm
	{
        private IDIGITALTEKGRIDCONTROL.ValidationUser validationUser1;

        private System.ComponentModel.IContainer components = null;

		public ValidationUser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//

			//
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
		


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationUser));
            this.validationUser1 = new IDIGITALTEKGRIDControl.ValidationUser();
            this.SuspendLayout();
// 
// validationUser1
// 
            this.validationUser1.Location = new System.Drawing.Point(0, 0);
            this.validationUser1.Name = "validationUser1";
            this.validationUser1.Size = new System.Drawing.Size(575, 336);
            this.validationUser1.TabIndex = 0;
// 
// ValidationUser
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.validationUser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "ValidationUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.validationUser1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		
		public  IDIGITALTEKGRID.ValidationUserMDI validationUser = new IDIGITALTEKGRID.ValidationUserMDI();
		protected IDIGITALTEKGRID.ValidationUserData FormValidationUser = new ValidationUserData();

		public void CreateValidationUser()
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.validationUser1.ValidationUser_Load();
            this.Show();
		}

		public void CreateNewValidationUser( IDIGITALTEKGRID.ValidationUserMDI  _validationUser)
		{

			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.validationUser = _validationUser;
            this.validationUser1.ValidationUser_Load();
            this.Show();
		}

		public void CreateValidationUser( IDIGITALTEKGRID.ValidationUserMDI  _validationUser)
		{

			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.validationUser = _validationUser;
            this.validationUser1.ValidationUser_Load();
            this.Show();
		}

		public void Edit( IDIGITALTEKGRID.ValidationUserData  _formValidationUser,  IDIGITALTEKGRID.ValidationUserMDI  _validationUser) 
		{
            this.validationUser1.ValidationUser_Load();

            if(_formValidationUser.Active==true)
			{this.validationUser1.chkActive.Checked = true;}
			else{this.validationUser1.chkActive.Checked = false;};


			if(_formValidationUser.Pulldown ==true)
			{this.validationUser1.chkPullDown.Checked = true;}
			else{this.validationUser1.chkPullDown.Checked = false;};

			this.validationUser1.txtCodeUser.Text =  _formValidationUser.Code;
			this.validationUser1.txtDescriptionUser.Text = _formValidationUser.Description;
			this.validationUser1.dlGroupUser.Text = _formValidationUser.Group;
			this.validationUser1.txtMemoUser.Text = _formValidationUser.Memo;
	
			this.validationUser1.dlTypeUser.Text = _formValidationUser.Type;
			this.validationUser1.txtValidationUserID.Text = _formValidationUser.ValidationUserID.ToString();

			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.validationUser = _validationUser;	
			this.Show(); 
		}
	
		public override void InsertData() 
		{
            if (this.validationUser1.chkActive.Checked == true)
            { FormValidationUser.Active = true; }
            else { FormValidationUser.Active = false; };


            if (this.validationUser1.chkPullDown.Checked == true)
            { FormValidationUser.Pulldown = true; }
            else { FormValidationUser.Pulldown = false; };


            try
            {
                FormValidationUser.ValidationUserID = Convert.ToInt32(this.validationUser1.txtValidationUserID.Text);
            }
            catch { }


            if (this.validationUser1.dlGroupUser.SelectedIndex != -1)
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.Text;
            }


            if (this.validationUser1.dlTypeUser.SelectedIndex != -1)
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.Text;
            }

            FormValidationUser.Code = this.validationUser1.txtCodeUser.Text;
            FormValidationUser.Description = this.validationUser1.txtDescriptionUser.Text;
            FormValidationUser.Memo = this.validationUser1.txtMemoUser.Text;
			IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.add(FormValidationUser);	
		} 

		public override void UpdateData() 
		{
            if (this.validationUser1.chkActive.Checked == true)
            { FormValidationUser.Active = true; }
            else { FormValidationUser.Active = false; };


            if (this.validationUser1.chkPullDown.Checked == true)
            { FormValidationUser.Pulldown = true; }
            else { FormValidationUser.Pulldown = false; };

            try
            {
                FormValidationUser.ValidationUserID = Convert.ToInt32(this.validationUser1.txtValidationUserID.Text);
            }
            catch { }


            if (this.validationUser1.dlGroupUser.SelectedIndex != -1)
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.Text;
            }


            if (this.validationUser1.dlTypeUser.SelectedIndex != -1)
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.Text;
            }

            FormValidationUser.Code = this.validationUser1.txtCodeUser.Text;
            FormValidationUser.Description = this.validationUser1.txtDescriptionUser.Text;
            FormValidationUser.Memo = this.validationUser1.txtMemoUser.Text;

			IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.update(FormValidationUser);		
		} 
		public override void CancelData() 
		{ 				
			this.validationUser1.chkActive.Checked = false;
			this.validationUser1.chkPullDown.Checked = false;
			this.validationUser1.txtCodeUser.Text = "";
			this.validationUser1.txtDescriptionUser.Text = "";
			this.validationUser1.dlGroupUser.Text = "";
			this.validationUser1.txtMemoUser.Text = "";		
			this.validationUser1.dlTypeUser.Text = "";		
		} 
		public override void DeleteData() 
		{ 	
			
			if(this.validationUser1.chkActive.Checked == true)
			{FormValidationUser.Active = true; }
			else{FormValidationUser.Active = false;};


			if(this.validationUser1.chkPullDown.Checked ==true )
			{FormValidationUser.Pulldown =true;}
			else{FormValidationUser.Pulldown = false;};


            try
            {
                FormValidationUser.ValidationUserID = Convert.ToInt32(this.validationUser1.txtValidationUserID.Text);
            }
            catch { }


            if (this.validationUser1.dlGroupUser.SelectedIndex != -1)
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Group = this.validationUser1.dlGroupUser.Text;
            }


            if (this.validationUser1.dlTypeUser.SelectedIndex != -1)
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.SelectedValue.ToString();
            }
            else
            {
                FormValidationUser.Type = this.validationUser1.dlTypeUser.Text;
            }
		
			FormValidationUser.Code = this.validationUser1.txtCodeUser.Text   ;
			FormValidationUser.Description = this.validationUser1.txtDescriptionUser.Text ;
			FormValidationUser.Memo = this.validationUser1.txtMemoUser.Text  ;
			


			IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.delete(FormValidationUser);	
		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;
			if(this.validationUser1.dlTypeUser.Text.Length ==0)valide = false;
	
			if(this.validationUser1.txtDescriptionUser.Text.Length ==0)valide = false;
			if(this.validationUser1.dlGroupUser.Text.Length ==0)valide = false;
		
			
			return valide; 
		}	
	

 
		public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.validationUser.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
            }
            catch { }

            IDIGITALTEKGRID.Builder.LoadValidationDLL();


            _DivisionDataProvider.selectValidationUser(IDIGITALTEKGRID.Builder.lstValidationUserDivision);
		
		} 

	}
}
