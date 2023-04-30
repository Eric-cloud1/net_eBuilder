using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for CostAmount.
	/// </summary>
	public class CostAmount : EstimateBuilder.DataForm
	{
        private EstimateBuilderControl.CostAmount costAmount1;

	
		
	
		private EstimateBuilder.ApplicationBuilder application = new ApplicationBuilder();
		

		public CostAmount()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//

			//
		}

		private System.ComponentModel.Container components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostAmount));
            this.costAmount1 = new EstimateBuilderControl.CostAmount();
            this.SuspendLayout();
// 
// costAmount1
// 
            this.costAmount1.Location = new System.Drawing.Point(0, 0);
            this.costAmount1.Name = "costAmount1";
            this.costAmount1.Size = new System.Drawing.Size(563, 345);
            this.costAmount1.TabIndex = 0;
// 
// CostAmount
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.costAmount1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "CostAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.costAmount1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		public  EstimateBuilder.CostAmountMDI  costAmount = new EstimateBuilder.CostAmountMDI();
		
		protected EstimateBuilder.CostAmountData FormCostAmount = new CostAmountData();


		public void CreateCostAmount()
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.costAmount1.CostAmount_Load();
            this.Show();
		}
		public void CreateNewCostAmount(EstimateBuilder.CostAmountMDI  _costAmount)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.costAmount = _costAmount;
            this.costAmount1.CostAmount_Load();
            this.Show();
		}

		public void CreateCostAmount(EstimateBuilder.CostAmountMDI  _costAmount)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.costAmount = _costAmount;
            this.costAmount1.CostAmount_Load();
            this.Show();
		}

		public void Edit(EstimateBuilder.CostAmountData  _formCostAmount,  EstimateBuilder.CostAmountMDI  _costAmount ) 
		{

            this.costAmount1.CostAmount_Load();

            if(  this.costAmount1.chkActive.Checked )
			{ _formCostAmount.Active = true;}
			else
			{_formCostAmount.Active = false;};
		

			this.costAmount1.txtCostAmountID.Text = _formCostAmount.CostAmountID.ToString();
			this.costAmount1.txtDate.Text = _formCostAmount.Date.ToString();
			
			this.costAmount1.txtCostAmountID.Text = _formCostAmount.CostAmountID.ToString();
			this.costAmount1.txtCostAmt.Text = _formCostAmount.CostAmt.ToString("C");
			
			this.costAmount1.txtDescription.Text = _formCostAmount.Description;

            this.costAmount1.txtMemo.Text = _formCostAmount.Memo;
			//this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
			//this.costAmount1.imgImage = _formCostAmount.PhotoImage;
	
            this.costAmount1.txtUser.Text =	_formCostAmount.User;
			this.costAmount1.txtZipCode.Text = _formCostAmount.ZipCode;
            this.costAmount1.txtDivision.Text = _formCostAmount.Division;
            this.costAmount1.txtDivisionCost.Text = _formCostAmount.DivisionCost;
            this.costAmount1.txtPieceUnitOrder.Text = _formCostAmount.PiecePerUnitOrder.ToString();

            this.costAmount1.dlManufacture.SelectedValue = _formCostAmount.ManufactureID;
            this.costAmount1.dlCostItem.SelectedValue = _formCostAmount.CostItemID;
            this.costAmount1.dlVendor.SelectedValue = _formCostAmount.VendorID;


            this.costAmount1.dlBuildingType.Text = _formCostAmount.BuildingType;
            this.costAmount1.txtGenericVendor.Text = _formCostAmount.GenericVendor;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.costAmount = _costAmount;
			this.Show(); 
		}

		public override void InsertData() 
		{
            if (this.costAmount1.chkActive.Checked)
            { FormCostAmount.Active = true; }
            else
            { FormCostAmount.Active = false; };




            if (this.costAmount1.dlManufacture.SelectedIndex != -1)
            {
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.Text);

            }

            if (this.costAmount1.dlVendor.SelectedIndex != -1)
            {
                FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.Text);
            }

           
                FormCostAmount.GenericVendor = this.costAmount1.txtGenericVendor.Text;
        

            if (this.costAmount1.dlCostItem.SelectedIndex != -1)
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.Text);
            }
           



            if (Convert.ToDateTime(this.costAmount1.txtDate.Text) is DateTime)
            {
                FormCostAmount.Date = Convert.ToDateTime(this.costAmount1.txtDate.Text);
            }
            else
            {
                FormCostAmount.Date = System.DateTime.Now;
            }

            try
            {
                FormCostAmount.CostAmountID = Convert.ToInt32(this.costAmount1.txtCostAmountID.Text);
            }
            catch { }

            try
            {
                FormCostAmount.CostAmt = Convert.ToDecimal( this.costAmount1.txtCostAmt.Text);
            }
            catch
            {
                FormCostAmount.CostAmt = 0;
            }

            try
            {
                FormCostAmount.PiecePerUnitOrder = Convert.ToDecimal(this.costAmount1.txtPieceUnitOrder.Text);
            }
            catch
            {
                FormCostAmount.PiecePerUnitOrder = 1;
            }




            FormCostAmount.Division = this.costAmount1.txtDescription.Text;
            FormCostAmount.DivisionCost = this.costAmount1.txtDivision.Text;
            FormCostAmount.BuildingType = this.costAmount1.dlBuildingType.Text;
            FormCostAmount.Description = this.costAmount1.txtDescription.Text;


            FormCostAmount.Memo = this.costAmount1.txtMemo.Text;
            //this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
            //this.costAmount1.imgImage = _formCostAmount.PhotoImage;

            FormCostAmount.User = this.costAmount1.txtUser.Text;
            FormCostAmount.ZipCode = this.costAmount1.txtZipCode.Text;

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
		
			EstimateBuilder.ApplicationBuilder.CostAmountDataSource.add(FormCostAmount);
		
			
		} 

		public override void UpdateData() 
		{
            if (this.costAmount1.chkActive.Checked)
            { FormCostAmount.Active = true; }
            else
            { FormCostAmount.Active = false; };




            if (this.costAmount1.dlManufacture.SelectedIndex != -1)
            {
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.Text);

            }

            if (this.costAmount1.dlVendor.SelectedIndex != -1)
            {
                FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.Text);
            }

                FormCostAmount.GenericVendor = this.costAmount1.txtGenericVendor.Text;
           

            if (Convert.ToDateTime(this.costAmount1.txtDate.Text) is DateTime)
            {
                FormCostAmount.Date = Convert.ToDateTime(this.costAmount1.txtDate.Text);
            }
            else
            {
                FormCostAmount.Date = System.DateTime.Now;
            }

            try
            {
                FormCostAmount.CostAmountID = Convert.ToInt32(this.costAmount1.txtCostAmountID.Text);
            }
            catch { }

            try
            {
                FormCostAmount.CostAmt = Convert.ToDecimal(this.costAmount1.txtCostAmt.Text);
            }
            catch
            {
                FormCostAmount.CostAmt = 0;
            }

            try
            {
                FormCostAmount.PiecePerUnitOrder = Convert.ToDecimal(this.costAmount1.txtPieceUnitOrder.Text);
            }
            catch
            {
                FormCostAmount.PiecePerUnitOrder = 1;
            }

            if (this.costAmount1.dlCostItem.SelectedIndex != -1)
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.Text);
            }
           



            FormCostAmount.Division = this.costAmount1.txtDescription.Text;
            FormCostAmount.DivisionCost = this.costAmount1.txtDivision.Text;
            FormCostAmount.BuildingType = this.costAmount1.dlBuildingType.Text;
            FormCostAmount.Description = this.costAmount1.txtDescription.Text;


            FormCostAmount.Memo = this.costAmount1.txtMemo.Text;
            //this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
            //this.costAmount1.imgImage = _formCostAmount.PhotoImage;

            FormCostAmount.User = this.costAmount1.txtUser.Text;
            FormCostAmount.ZipCode = this.costAmount1.txtZipCode.Text;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
		
			EstimateBuilder.ApplicationBuilder.CostAmountDataSource.update(FormCostAmount);
		
			
		} 


	
		public override void CancelData() 
		{ 	
			this.costAmount1.dlManufacture.Text =  "";
	
			this.costAmount1.txtDate.Text = "";
			this.costAmount1.chkActive.Text =  "";
			this.costAmount1.txtCostAmountID.Text =  "";
			this.costAmount1.txtCostAmt.Text =  "";
			this.costAmount1.txtDate.Text =  "";
		
			this.costAmount1.txtMemo.Text =  "";
			//this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
			//this.costAmount1.imgImage = _formCostAmount.PhotoImage;
			this.costAmount1.dlVendor.Text =  "";
			this.costAmount1.txtUser.Text =	 "";
			this.costAmount1.txtZipCode.Text =  "";
	
		} 
		public override void DeleteData() 
		{ 	
		    if(  this.costAmount1.chkActive.Checked )
			{FormCostAmount.Active = true;}
			else
			{FormCostAmount.Active = false;};

            
            

			if(this.costAmount1.dlManufacture.SelectedIndex !=-1)
			{
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.ManufactureID = Convert.ToInt32(this.costAmount1.dlManufacture.Text);

            }
			
			if(this.costAmount1.dlVendor.SelectedIndex!=-1)
			{
				FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.SelectedValue.ToString());
			}
            else
            {
                FormCostAmount.VendorID = Convert.ToInt32(this.costAmount1.dlVendor.Text);
            }

            FormCostAmount.GenericVendor = this.costAmount1.txtGenericVendor.Text;


            if (Convert.ToDateTime(this.costAmount1.txtDate.Text) is DateTime)
            {
                FormCostAmount.Date = Convert.ToDateTime(this.costAmount1.txtDate.Text);
            }
            else
            {
                FormCostAmount.Date = System.DateTime.Now;
            }

            try
            {
                FormCostAmount.CostAmountID = Convert.ToInt32(this.costAmount1.txtCostAmountID.Text);
            }
            catch { }

            try
            {
                FormCostAmount.CostAmt = Convert.ToDecimal(this.costAmount1.txtCostAmt.Text);
            }
            catch
            {
                FormCostAmount.CostAmt = 0;
            }

            try
            {
                FormCostAmount.PiecePerUnitOrder = Convert.ToDecimal(this.costAmount1.txtPieceUnitOrder.Text);
            }
            catch
            {
                FormCostAmount.PiecePerUnitOrder = 1;
            }


            if (this.costAmount1.dlCostItem.SelectedIndex != -1)
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.SelectedValue.ToString());
            }
            else
            {
                FormCostAmount.CostItemID = Convert.ToInt32(this.costAmount1.dlCostItem.Text);
            }
           

            FormCostAmount.Division = this.costAmount1.txtDescription.Text;
            FormCostAmount.DivisionCost = this.costAmount1.txtDivision.Text;
            FormCostAmount.BuildingType = this.costAmount1.dlBuildingType.Text;
            FormCostAmount.Description = this.costAmount1.txtDescription.Text;


            FormCostAmount.Memo = this.costAmount1.txtMemo.Text ;
			//this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
			//this.costAmount1.imgImage = _formCostAmount.PhotoImage;

			FormCostAmount.User = this.costAmount1.txtUser.Text ;
            FormCostAmount.ZipCode = this.costAmount1.txtZipCode.Text;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
		
			EstimateBuilder.ApplicationBuilder.CostAmountDataSource.add(FormCostAmount);
		
			
		} 

		public override bool ValidateData() 
		{ 
			bool valide = true;

			//this.costAmount1.imgCAD = _formCostAmount.PhotoCad;
			//this.costAmount1.imgImage = _formCostAmount.PhotoImage;


            if (this.costAmount1.dlVendor.Text.Length == 0) valide = false;
			if(this.costAmount1.dlManufacture.Text.Length ==0)valide = false;
         
            if (this.costAmount1.dlCostItem.Text.Length == 0) valide = false;

            if (this.costAmount1.txtDate.Text.Length == 0) valide = false;
            if (this.costAmount1.txtPieceUnitOrder.Text.Length == 0) valide = false;	
			if(this.costAmount1.txtCostAmt.Text.Length ==0)valide = false;       
            if(this.costAmount1.txtUser.Text.Length ==0)valide = false;
			if(this.costAmount1.txtZipCode.Text.Length ==0)valide = false;
		
			return valide; 
		}	
	

 
		public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.costAmount.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
                this.costAmount.MdiParent.Refresh();
            }
            catch { }


            _DivisionDataProvider.selectCostAmount(EstimateBuilder.Builder.lstCostAmountDivision);
	

            
		} 


	}
}
