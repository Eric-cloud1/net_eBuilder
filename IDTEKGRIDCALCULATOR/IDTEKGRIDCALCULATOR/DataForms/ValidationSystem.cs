using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ValidationSystem.
	/// </summary>
	public class ValidationSystem : IDIGITALTEKGRID.DataForm
	{
        private IDIGITALTEKGRIDCONTROL.ValidationSystem validationSystem1;

        private System.ComponentModel.IContainer components;

		public ValidationSystem()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationSystem));
            this.validationSystem1 = new IDIGITALTEKGRIDControl.ValidationSystem();
            this.SuspendLayout();
// 
// validationSystem1
// 
            this.validationSystem1.Location = new System.Drawing.Point(0, 0);
            this.validationSystem1.Name = "validationSystem1";
            this.validationSystem1.Size = new System.Drawing.Size(575, 345);
            this.validationSystem1.TabIndex = 0;
// 
// ValidationSystem
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.validationSystem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "ValidationSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.validationSystem1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		
		public  IDIGITALTEKGRID.ValidationSystemMDI validationSystem = new IDIGITALTEKGRID.ValidationSystemMDI();
		protected IDIGITALTEKGRID.ValidationSystemData FormValidationSystem = new ValidationSystemData();

		public void CreateValidationSystem()
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.validationSystem1.ValidationSystem_Load();
            this.Show();
		}

		public void CreateNewValidationSystem( IDIGITALTEKGRID.ValidationSystemMDI  _validationSystem)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.validationSystem = _validationSystem;
            this.validationSystem1.ValidationSystem_Load();
            this.Show();
		}

		public void CreateValidationSystem( IDIGITALTEKGRID.ValidationSystemMDI  _validationSystem)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.validationSystem = _validationSystem;
            this.validationSystem1.ValidationSystem_Load();
            this.Show();
		}

		public void Edit( IDIGITALTEKGRID.ValidationSystemData  _formValidationSystem,  IDIGITALTEKGRID.ValidationSystemMDI  _validationSystem ) 
		{
            this.validationSystem1.ValidationSystem_Load();

            this.validationSystem1.txtDescriptionSystem.Text = _formValidationSystem.Description;
			this.validationSystem1.txtMemoSystem.Text = _formValidationSystem.Memo;
			this.validationSystem1.txtTypeSystem.Text = _formValidationSystem.Type;
			this.validationSystem1.txtValidationID.Text = _formValidationSystem.ValidationSystemID.ToString();
			
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.validationSystem = _validationSystem;	
			this.Show(); 
		}
	
		public override void InsertData() 
		{ 		
			FormValidationSystem.Description = this.validationSystem1.txtDescriptionSystem.Text ;
			FormValidationSystem.Memo = this.validationSystem1.txtMemoSystem.Text ;
			FormValidationSystem.Type = this.validationSystem1.txtTypeSystem.Text  ;
            try
            {
                FormValidationSystem.ValidationSystemID = Convert.ToInt32(this.validationSystem1.txtValidationID.Text);
            }
            catch { }

			IDIGITALTEKGRID.ApplicationBuilder.ValidationSystemDataSource.add(FormValidationSystem);	
		} 

		public override void UpdateData() 
		{ 		
			FormValidationSystem.Description = this.validationSystem1.txtDescriptionSystem.Text ;
			FormValidationSystem.Memo = this.validationSystem1.txtMemoSystem.Text ;
			FormValidationSystem.Type = this.validationSystem1.txtTypeSystem.Text  ;
            try
            {
                FormValidationSystem.ValidationSystemID = Convert.ToInt32(this.validationSystem1.txtValidationID.Text);
            }
            catch { }

			IDIGITALTEKGRID.ApplicationBuilder.ValidationSystemDataSource.update(FormValidationSystem);		
		} 
		public override void CancelData() 
		{ 				
			this.validationSystem1.txtDescriptionSystem.Text = "";	
			this.validationSystem1.txtMemoSystem.Text = "";	
			this.validationSystem1.txtTypeSystem.Text = "";			
		} 
		public override void DeleteData() 
		{ 
			FormValidationSystem.Description = this.validationSystem1.txtDescriptionSystem.Text ;
			FormValidationSystem.Memo = this.validationSystem1.txtMemoSystem.Text ;
			FormValidationSystem.Type = this.validationSystem1.txtTypeSystem.Text  ;


            try
            {
                FormValidationSystem.ValidationSystemID = Convert.ToInt32(this.validationSystem1.txtValidationID.Text);
            }
            catch { }

			IDIGITALTEKGRID.ApplicationBuilder.ValidationSystemDataSource.delete(FormValidationSystem);

		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;
			
		
			if(this.validationSystem1.txtDescriptionSystem.Text.Length ==0)valide = false;
			if(this.validationSystem1.txtTypeSystem.Text.Length ==0)valide = false;
			
			return valide; 
		}	


				
		public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.validationSystem.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
            }
            catch { }

            IDIGITALTEKGRID.Builder.LoadValidationDLL();

            _DivisionDataProvider.selectValidationSystem(IDIGITALTEKGRID.Builder.lstValidationSystemDivision);
	
		} 


	}
}
