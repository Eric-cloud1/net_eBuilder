using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for Contact.
	/// </summary>
	public class Contact : EstimateBuilder.DataForm //System.Windows.Forms.Form //
	{
        private EstimateBuilderControl.Contact contact1;

		public EstimateBuilder.ContactDataProvider ContactDataSource = new ContactDataProvider();
	
		
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public Contact(): base()
		{
			//
			// Required for Windows Form Designer support
			//
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



		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.contact1 = new EstimateBuilderControl.Contact();
            this.SuspendLayout();
// 
// contact1
// 
            this.contact1.Location = new System.Drawing.Point(0, 0);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(575, 368);
            this.contact1.TabIndex = 0;
// 
// Contact
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(567, 405);
            this.Controls.Add(this.contact1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.contact1, 0);
            this.ResumeLayout(false);

        }
		#endregion
		

		public  EstimateBuilder.ContactMDI  contact = new EstimateBuilder.ContactMDI();
		public void CreateNewContact(EstimateBuilder.ContactMDI  _contact)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.contact = _contact;
            this.contact1.Contact_Load();
            this.Show();
		}

		public void CreateContact( )
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.contact1.Contact_Load();
            this.Show();
		}

		public void CreateContact( EstimateBuilder.ContactMDI  _contact)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.contact = _contact;
            this.contact1.Contact_Load();
            this.Show();
		}

		public void Edit( EstimateBuilder.ContactData  _formContact, EstimateBuilder.ContactMDI  _contact ) 
		{

            this.contact1.Contact_Load();

            this.contact1.dlOutlookID.SelectedItem  =_formContact.OutlookID.ToString();
            this.contact1.txtRecordID.Text =  _formContact.RecordID.ToString();
			this.contact1.txtContactID.Text = _formContact.ContactID.ToString();
			this.contact1.txtStAddress.Text = _formContact.Address ;
			this.contact1.txtCity.Text = _formContact.City ;
			this.contact1.txtCompany.Text = _formContact.Company;
			

			
			this.contact1.txtEmail.Text =  _formContact.Email ;
			this.contact1.txtFirstName.Text = _formContact.FirstName;
			this.contact1.txtLastName.Text = _formContact.LastName ;
            this.contact1.txtMiddleName.Text = _formContact.MiddleName;
			this.contact1.txtMemo.Text = _formContact.Memo ;
			this.contact1.txtPhoneCellular.Text = _formContact.PhoneCell ;
			this.contact1.txtExtension.Text = _formContact.PhoneExtension ;
			this.contact1.txtFax.Text= _formContact.PhoneFax ;
			this.contact1.txtWorkPhone.Text =  _formContact.PhoneVoice  ;
			this.contact1.txtTitle.Text = _formContact.Title ;
			this.contact1.txtPostalCode.Text =_formContact.ZipCode  ;

            this.contact1.dlContactType.SelectedValue = _formContact.Contract;
            this.contact1.dlDivision.Text = _formContact.Division;
            this.contact1.dlDivisionCost.Text = _formContact.DivisionCost;
            this.contact1.dlRegion.Text = _formContact.Region;
            this.contact1.dlState.Text = _formContact.State;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.contact = _contact;
			
			this.Show(); 
		}
	
	
		protected EstimateBuilder.ContactData FormContact = new ContactData();
		
		public override void InsertData() 
		{ 
			FormContact.OutlookID=0;
		

            if (Convert.ToInt32(this.contact1.txtRecordID.Text) is Int32)
            {
                FormContact.RecordID = Convert.ToInt32(this.contact1.txtRecordID.Text);
            }

            try 
            {
                FormContact.ContactID = Convert.ToInt32(this.contact1.txtContactID.Text);
            }
            catch{}
			FormContact.Address = this.contact1.txtStAddress.Text;
			FormContact.City = this.contact1.txtCity.Text;
			FormContact.Company=  this.contact1.txtCompany.Text;
			FormContact.FirstName = this.contact1.txtFirstName.Text;
			FormContact.LastName = this.contact1.txtLastName.Text;
            FormContact.MiddleName = this.contact1.txtMiddleName.Text;
            
            
            FormContact.Memo = this.contact1.txtMemo.Text;
			FormContact.PhoneCell = this.contact1.txtPhoneCellular.Text;
			FormContact.PhoneFax = this.contact1.txtFax.Text;
			FormContact.PhoneVoice = this.contact1.txtWorkPhone.Text;
			FormContact.ZipCode = this.contact1.txtPostalCode.Text;
			FormContact.PhoneExtension = this.contact1.txtExtension.Text;
			FormContact.Region = this.contact1.dlRegion.SelectedText;
			FormContact.Title = this.contact1.txtTitle.Text;
			FormContact.Email = this.contact1.txtEmail.Text;




            if (this.contact1.dlRegion.SelectedIndex != -1)
            {
                FormContact.Region = this.contact1.dlRegion.SelectedValue.ToString();
            }
            else
            {
                FormContact.Region = this.contact1.dlRegion.Text;
            }

            if (this.contact1.dlContactType.SelectedIndex != -1)
            {
                FormContact.Contract = this.contact1.dlContactType.SelectedValue.ToString();
            }
            else
            {
                FormContact.Contract = this.contact1.dlContactType.Text;
            }

            if (this.contact1.dlState.SelectedIndex != -1)
			{
                FormContact.State = this.contact1.dlState.SelectedValue.ToString();
            }
			else
			{
                FormContact.State = this.contact1.dlState.Text;
			}

            if (this.contact1.dlDivision.SelectedIndex != -1)
            {
                FormContact.Division = this.contact1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormContact.Division = this.contact1.dlDivision.Text;
            }

            if (this.contact1.dlDivisionCost.SelectedIndex != -1)
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.Text;
            }


            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.ContactDataSource.add(FormContact);
		
			
		} 

		public override void UpdateData() 
		{
            FormContact.OutlookID = 0;


            if (Convert.ToInt32(this.contact1.txtRecordID.Text) is Int32)
            {
                FormContact.RecordID = Convert.ToInt32(this.contact1.txtRecordID.Text);
            }

            try
            {
                FormContact.ContactID = Convert.ToInt32(this.contact1.txtContactID.Text);
            }
            catch { }
            FormContact.Address = this.contact1.txtStAddress.Text;
            FormContact.City = this.contact1.txtCity.Text;
            FormContact.Company = this.contact1.txtCompany.Text;
            FormContact.FirstName = this.contact1.txtFirstName.Text;
            FormContact.LastName = this.contact1.txtLastName.Text;
            FormContact.MiddleName = this.contact1.txtMiddleName.Text;


            FormContact.Memo = this.contact1.txtMemo.Text;
            FormContact.PhoneCell = this.contact1.txtPhoneCellular.Text;
            FormContact.PhoneFax = this.contact1.txtFax.Text;
            FormContact.PhoneVoice = this.contact1.txtWorkPhone.Text;
            FormContact.ZipCode = this.contact1.txtPostalCode.Text;
            FormContact.PhoneExtension = this.contact1.txtExtension.Text;
            FormContact.Region = this.contact1.dlRegion.SelectedText;
            FormContact.Title = this.contact1.txtTitle.Text;
            FormContact.Email = this.contact1.txtEmail.Text;




            if (this.contact1.dlRegion.SelectedIndex != -1)
            {
                FormContact.Region = this.contact1.dlRegion.SelectedValue.ToString();
            }
            else
            {
                FormContact.Region = this.contact1.dlRegion.Text;
            }

            if (this.contact1.dlContactType.SelectedIndex != -1)
            {
                FormContact.Contract = this.contact1.dlContactType.SelectedValue.ToString();
            }
            else
            {
                FormContact.Contract = this.contact1.dlContactType.Text;
            }

            if (this.contact1.dlState.SelectedIndex != -1)
            {
                FormContact.State = this.contact1.dlState.SelectedValue.ToString();
            }
            else
            {
                FormContact.State = this.contact1.dlState.Text;
            }

            if (this.contact1.dlDivision.SelectedIndex != -1)
            {
                FormContact.Division = this.contact1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormContact.Division = this.contact1.dlDivision.Text;
            }

            if (this.contact1.dlDivisionCost.SelectedIndex != -1)
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.Text;
            }


            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.ContactDataSource.update(FormContact);	
			
			
		} 
		public override void CancelData() 
		{ 	
			this.contact1.txtRecordID.Text="";
			this.contact1.txtStAddress.Text="";
			this.contact1.txtCity.Text="";
			this.contact1.txtCompany.Text="";

            this.contact1.dlContactType.SelectedText = "";
            this.contact1.dlDivision.SelectedText = "";
            this.contact1.dlDivisionCost.SelectedText="";
            this.contact1.dlState.SelectedText = "";
            this.contact1.dlRegion.SelectedText = "";



            this.contact1.txtEmail.Text="";
			this.contact1.txtFirstName.Text="";
			this.contact1.txtLastName.Text="";
			this.contact1.txtMemo.Text="";
			this.contact1.txtPhoneCellular.Text="";
			this.contact1.txtExtension.Text="";
			this.contact1.txtFax.Text="";
			this.contact1.txtWorkPhone.Text="";
		
			this.contact1.txtTitle.Text="";
			this.contact1.txtPostalCode.Text="";
		} 
		public override void DeleteData() 
		{
            FormContact.OutlookID = 0;


            if (Convert.ToInt32(this.contact1.txtRecordID.Text) is Int32)
            {
                FormContact.RecordID = Convert.ToInt32(this.contact1.txtRecordID.Text);
            }

            try
            {
                FormContact.ContactID = Convert.ToInt32(this.contact1.txtContactID.Text);
            }
            catch { }
            FormContact.Address = this.contact1.txtStAddress.Text;
            FormContact.City = this.contact1.txtCity.Text;
            FormContact.Company = this.contact1.txtCompany.Text;
            FormContact.FirstName = this.contact1.txtFirstName.Text;
            FormContact.LastName = this.contact1.txtLastName.Text;
            FormContact.MiddleName = this.contact1.txtMiddleName.Text;


            FormContact.Memo = this.contact1.txtMemo.Text;
            FormContact.PhoneCell = this.contact1.txtPhoneCellular.Text;
            FormContact.PhoneFax = this.contact1.txtFax.Text;
            FormContact.PhoneVoice = this.contact1.txtWorkPhone.Text;
            FormContact.ZipCode = this.contact1.txtPostalCode.Text;
            FormContact.PhoneExtension = this.contact1.txtExtension.Text;
            FormContact.Region = this.contact1.dlRegion.SelectedText;
            FormContact.Title = this.contact1.txtTitle.Text;
            FormContact.Email = this.contact1.txtEmail.Text;




            if (this.contact1.dlRegion.SelectedIndex != -1)
            {
                FormContact.Region = this.contact1.dlRegion.SelectedValue.ToString();
            }
            else
            {
                FormContact.Region = this.contact1.dlRegion.Text;
            }

            if (this.contact1.dlContactType.SelectedIndex != -1)
            {
                FormContact.Contract = this.contact1.dlContactType.SelectedValue.ToString();
            }
            else
            {
                FormContact.Contract = this.contact1.dlContactType.Text;
            }

            if (this.contact1.dlState.SelectedIndex != -1)
            {
                FormContact.State = this.contact1.dlState.SelectedValue.ToString();
            }
            else
            {
                FormContact.State = this.contact1.dlState.Text;
            }

            if (this.contact1.dlDivision.SelectedIndex != -1)
            {
                FormContact.Division = this.contact1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormContact.Division = this.contact1.dlDivision.Text;
            }

            if (this.contact1.dlDivisionCost.SelectedIndex != -1)
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormContact.DivisionCost = this.contact1.dlDivisionCost.Text;
            }


            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Delete;
			this.ContactDataSource.delete(FormContact);
		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;
			if(this.contact1.txtStAddress.Text.Length ==0)valide = false;
			if(this.contact1.txtCity.Text.Length ==0)valide = false;
			if(this.contact1.txtCompany.Text.Length ==0)valide = false;
			if(this.contact1.dlContactType.Text.Length ==0)valide = false;
			if(this.contact1.dlDivision.Text.Length ==0)valide = false;
			if(this.contact1.dlDivisionCost.Text.Length ==0)valide = false;
			if(this.contact1.dlState.Text.Length ==0)valide = false;
			if(this.contact1.txtEmail.Text.Length ==0)valide = false;
			if(this.contact1.txtFirstName.Text.Length ==0)valide = false;
           // if (this.contact1.txtMiddleName.Text.Length == 0) valide = false;
            if(this.contact1.txtLastName.Text.Length ==0)valide = false;
			//if(this.contact1.txtMemo.Text.Length ==0)valide = false; //not required
			if(this.contact1.txtPhoneCellular.Text.Length ==0)valide = false;
           // if(this.contact1.txtExtension.Text.Length ==0)valide = false; //not required
           // if(this.contact1.txtFax.Text.Length ==0)valide = false; //not required
            if(this.contact1.txtWorkPhone.Text.Length ==0)valide = false;
			if(this.contact1.dlRegion.Text.Length ==0)valide = false;
			//if(this.contact1.txtTitle.Text.Length ==0)valide = false;
			if(this.contact1.txtPostalCode.Text.Length ==0)valide = false;
           // if(this.contact1.txtRecordID.Text.Length ==0)valide = false; //not required
            return valide; 
		}	
	
		public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.contact.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
                this.contact.MdiParent.Refresh();
            }
            catch { }



            _DivisionDataProvider.selectTakeOffJob(EstimateBuilder.Builder.lstQuantityJob);
            _DivisionDataProvider.selectTakeOffJob(EstimateBuilder.Builder.lstTakeOffJob);
            _DivisionDataProvider.selectJob(EstimateBuilder.Builder.lstJobDivision);
            _DivisionDataProvider.selectEstimateProject(EstimateBuilder.Builder.lstEstimateProject, "all");
            _DivisionDataProvider.selectContact(EstimateBuilder.Builder.lstContactDivision);
		
            
		} 



	}


}
