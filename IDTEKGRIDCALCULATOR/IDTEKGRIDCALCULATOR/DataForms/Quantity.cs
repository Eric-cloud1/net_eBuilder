using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for Quantity.
	/// </summary>
	public class Quantity : IDIGITALTEKGRID.DataForm
	{
        private IDIGITALTEKGRIDCONTROL.Quantity quantity1;

        private System.ComponentModel.IContainer components = null;

		public Quantity()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quantity));
            this.quantity1 = new IDIGITALTEKGRIDControl.Quantity();
            this.SuspendLayout();
// 
// quantity1
// 
            this.quantity1.Location = new System.Drawing.Point(0, 0);
            this.quantity1.Name = "quantity1";
            this.quantity1.Size = new System.Drawing.Size(563, 360);
            this.quantity1.TabIndex = 0;
// 
// Quantity
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.quantity1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.quantity1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		public  IDIGITALTEKGRID.QuantityMDI  localquantity = new IDIGITALTEKGRID.QuantityMDI();

		protected IDIGITALTEKGRID.QuantityData FormQuantity = new QuantityData();

		public void CreateQuantity()
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.quantity1.Quantity_Load();
            this.Show();
		}
		public void CreateNewQuantity( IDIGITALTEKGRID.QuantityMDI  _quantity)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.localquantity = _quantity;
            this.quantity1.Quantity_Load();

 

            this.Show();
		}

		public void CreateQuantity( IDIGITALTEKGRID.QuantityMDI  _quantity)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
            this.localquantity  = _quantity;
            this.quantity1.Quantity_Load();
            this.Show();
		}

		public void Edit( IDIGITALTEKGRID.QuantityData  _formQuantity,  IDIGITALTEKGRID.QuantityMDI  _quantity ) 
		{
            this.quantity1.Quantity_Load();
            this.localquantity = _quantity;

            if(this.quantity1.chkActive.Checked ==true)
			{_formQuantity.Active = true; }
			else{_formQuantity.Active = false;};


         

        //    this.quantity1.dlJobID.SelectedText = IDIGITALTEKGRID.ApplicationBuilder.quantityJobId;

            this.quantity1.dlAssembly.SelectedValue = _formQuantity.AssemblyID;
            this.quantity1.dlExpression.SelectedValue = _formQuantity.ExpressionID;
            this.quantity1.dlCostItem.SelectedValue = _formQuantity.CostItemID;

            this.quantity1.dlDivision.Text = _formQuantity.Division;
            this.quantity1.dlDivisionCost.Text = _formQuantity.DivisionCost;
            this.quantity1.dlDivisionPrint.Text = _formQuantity.DivisionPrint;
            this.quantity1.dlReportContract.Text = _formQuantity.ReportContract;
            this.quantity1.dlReportPhase.Text = _formQuantity.ReportPhase;
            this.quantity1.dlAccounting.Text = _formQuantity.Accounting;
          
            this.quantity1.dlLocation.Text = _formQuantity.Location;
            this.quantity1.dlUnits.Text = _formQuantity.Units;
          
            this.quantity1.txtDescription.Text = _formQuantity.Description;
            this.quantity1.txtMemo.Text = _formQuantity.Memo;

			this.quantity1.txtQuantityID.Text = _formQuantity.QuantityID.ToString();

            this.quantity1.txtQuantityAdjusted.Text = _formQuantity.QuantityAdjusted.ToString();
            this.quantity1.txtQuantityReuse.Text = _formQuantity.QuantityReuse.ToString();
            this.quantity1.txtQuantityRoundUp.Text = _formQuantity.QuantityRoundUp.ToString();
            this.quantity1.txtQuantityWaste.Text = _formQuantity.QuantityWaste.ToString();


            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			
			this.Show(); 
		}

        
        public override void InsertData() 
		{

            if (this.quantity1.chkActive.Checked == true)
            { FormQuantity.Active = true; }
            else { FormQuantity.Active = false; };
            FormQuantity.Memo = this.quantity1.txtMemo.Text;
            FormQuantity.Description = this.quantity1.txtDescription.Text;


            try
            {
                FormQuantity.QuantityAdjusted = Convert.ToDecimal(this.quantity1.txtQuantityAdjusted.Text);
            }
            catch
            {
                FormQuantity.QuantityAdjusted = 0;
            }

            try
            {
                FormQuantity.QuantityReuse = Convert.ToDecimal(this.quantity1.txtQuantityReuse.Text);
            }
            catch
            {

            }

            try
            {
                FormQuantity.QuantityRoundUp = Convert.ToDecimal(this.quantity1.txtQuantityRoundUp.Text);
            }
            catch
            {
                FormQuantity.QuantityRoundUp = 0;
            }

            try
            {
                FormQuantity.QuantityWaste = Convert.ToDecimal(this.quantity1.txtQuantityWaste.Text);
            }
            catch
            {
                FormQuantity.QuantityWaste = 0;
            }

            try
            {
                FormQuantity.QuantityID = Convert.ToInt32(this.quantity1.txtQuantityID.Text);
            }
            catch { }

            if (this.quantity1.dlReportPhase.SelectedIndex != -1)
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.Text;
            }

            if (this.quantity1.dlReportContract.SelectedIndex != -1)
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.Text;
            }

            if (this.quantity1.dlDivision.SelectedIndex != -1)
            {
                FormQuantity.Division = this.quantity1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Division = this.quantity1.dlDivision.Text;
            }

            if (this.quantity1.dlAccounting.SelectedIndex != -1)
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.Text;
            }

            if (this.quantity1.dlDivisionCost.SelectedIndex != -1)
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.Text;
            }

            if (this.quantity1.dlDivisionPrint.SelectedIndex != -1)
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.Text;
            }

            if (this.quantity1.dlLocation.SelectedIndex != -1)
            {
                FormQuantity.Location = this.quantity1.dlLocation.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Location = this.quantity1.dlLocation.Text;
            }

            if (this.quantity1.dlUnits.SelectedIndex != -1)
            {
                FormQuantity.Units = this.quantity1.dlUnits.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Units = this.quantity1.dlUnits.Text;
            }

            if (this.quantity1.dlCostItem.SelectedIndex != -1)
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.SelectedValue);
            }
            else
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.Text);
            }

            if (this.quantity1.dlAssembly.SelectedIndex != -1)
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.SelectedValue);
            }
            else
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.Text);
            }


            if (this.quantity1.dlExpression.SelectedIndex != -1)
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.SelectedValue);
            }
            else
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.Text);
            }
            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;


             IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.add(FormQuantity); 

		
		} 

		public override void UpdateData() 
		{

            if (this.quantity1.chkActive.Checked == true)
            { FormQuantity.Active = true; }
            else { FormQuantity.Active = false; };
            FormQuantity.Memo = this.quantity1.txtMemo.Text;
            FormQuantity.Description = this.quantity1.txtDescription.Text;


            try
            {
                FormQuantity.QuantityAdjusted = Convert.ToDecimal(this.quantity1.txtQuantityAdjusted.Text);
            }
            catch
            {
                FormQuantity.QuantityAdjusted = 0;
            }

            try
            {
                FormQuantity.QuantityReuse = Convert.ToDecimal(this.quantity1.txtQuantityReuse.Text);
            }
            catch
            {

            }
            if (this.quantity1.dlAccounting.SelectedIndex != -1)
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.Text;
            }

            try
            {
                FormQuantity.QuantityRoundUp = Convert.ToDecimal(this.quantity1.txtQuantityRoundUp.Text);
            }
            catch
            {
                FormQuantity.QuantityRoundUp = 0;
            }

            try
            {
                FormQuantity.QuantityWaste = Convert.ToDecimal(this.quantity1.txtQuantityWaste.Text);
            }
            catch
            {
                FormQuantity.QuantityWaste = 0;
            }
            try
            {
                FormQuantity.QuantityID = Convert.ToInt32(this.quantity1.txtQuantityID.Text);
            }
            catch { }

            if (this.quantity1.dlReportPhase.SelectedIndex != -1)
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.Text;
            }

            if (this.quantity1.dlReportContract.SelectedIndex != -1)
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.Text;
            }

            if (this.quantity1.dlDivision.SelectedIndex != -1)
            {
                FormQuantity.Division = this.quantity1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Division = this.quantity1.dlDivision.Text;
            }

            if (this.quantity1.dlDivisionCost.SelectedIndex != -1)
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.Text;
            }

            if (this.quantity1.dlDivisionPrint.SelectedIndex != -1)
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.Text;
            }

            if (this.quantity1.dlLocation.SelectedIndex != -1)
            {
                FormQuantity.Location = this.quantity1.dlLocation.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Location = this.quantity1.dlLocation.Text;
            }

            if (this.quantity1.dlUnits.SelectedIndex != -1)
            {
                FormQuantity.Units = this.quantity1.dlUnits.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Units = this.quantity1.dlUnits.Text;
            }

            if (this.quantity1.dlCostItem.SelectedIndex != -1)
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.SelectedValue);
            }
            else
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.Text);
            }

            if (this.quantity1.dlAssembly.SelectedIndex != -1)
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.SelectedValue);
            }
            else
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.Text);
            }


            if (this.quantity1.dlExpression.SelectedIndex != -1)
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.SelectedValue);
            }
            else
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.Text);
            }

            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;

     
            IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.update(FormQuantity); 
            
            
		} 
		public override void CancelData() 
		{ 	
			this.quantity1.chkActive.Checked = false;
            this.quantity1.dlDivision.SelectedText = "";
            this.quantity1.dlDivisionCost.SelectedText = "";
            this.quantity1.dlDivisionPrint.SelectedText = "";
            this.quantity1.dlLocation.SelectedText = "";
            this.quantity1.dlUnits.SelectedText = "";
            this.quantity1.dlAssembly.SelectedText = "";
            this.quantity1.dlExpression.SelectedText = "";
            this.quantity1.dlCostItem.SelectedText = "";
            this.quantity1.dlAccounting.SelectedText = "";

            this.quantity1.txtDescription.Text = "";
            this.quantity1.txtMemo.Text = "";	
            this.quantity1.txtQuantityReuse.Text = "";
            this.quantity1.txtQuantityRoundUp.Text = "";
            this.quantity1.txtQuantityWaste.Text = "";
            this.quantity1.txtQuantityAdjusted.Text = "";

        } 
		public override void DeleteData()
        {
            if (this.quantity1.chkActive.Checked == true)
            { FormQuantity.Active = true; }
            else { FormQuantity.Active = false; } ;
            FormQuantity.Memo = this.quantity1.txtMemo.Text;
            FormQuantity.Description = this.quantity1.txtDescription.Text;

            try
            {
                FormQuantity.QuantityAdjusted = Convert.ToDecimal(this.quantity1.txtQuantityAdjusted.Text);
            }
            catch
            {
                FormQuantity.QuantityAdjusted = 0;
            }
            if (this.quantity1.dlAccounting.SelectedIndex != -1)
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Accounting = this.quantity1.dlAccounting.Text;
            }

            try
            {
                FormQuantity.QuantityReuse = Convert.ToDecimal(this.quantity1.txtQuantityReuse.Text);
            }
            catch
            {

            }

            try
            {
                FormQuantity.QuantityRoundUp = Convert.ToDecimal(this.quantity1.txtQuantityRoundUp.Text);
            }
            catch
            {
                FormQuantity.QuantityRoundUp = 0;
            }

            try
            {
                FormQuantity.QuantityWaste = Convert.ToDecimal(this.quantity1.txtQuantityWaste.Text);
            }
            catch
            {
                FormQuantity.QuantityWaste = 0;
            }

            try
            {
                FormQuantity.QuantityID = Convert.ToInt32(this.quantity1.txtQuantityID.Text);
            }
            catch { }


            if (this.quantity1.dlReportPhase.SelectedIndex != -1)
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportPhase = this.quantity1.dlReportPhase.Text;
            }

            if (this.quantity1.dlReportContract.SelectedIndex != -1)
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.ReportContract = this.quantity1.dlReportContract.Text;
            }

            if (this.quantity1.dlDivision.SelectedIndex != -1)
            {
                FormQuantity.Division = this.quantity1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Division = this.quantity1.dlDivision.Text;
            }

            if (this.quantity1.dlDivisionCost.SelectedIndex != -1)
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionCost = this.quantity1.dlDivisionCost.Text;
            }

            if (this.quantity1.dlDivisionPrint.SelectedIndex != -1)
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {

                FormQuantity.DivisionPrint = this.quantity1.dlDivisionPrint.Text;
            }

            if (this.quantity1.dlLocation.SelectedIndex != -1)
            {
                FormQuantity.Location = this.quantity1.dlLocation.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Location = this.quantity1.dlLocation.Text;
            }

            if (this.quantity1.dlUnits.SelectedIndex != -1)
            {
                FormQuantity.Units = this.quantity1.dlUnits.SelectedValue.ToString();
            }
            else
            {
                FormQuantity.Units = this.quantity1.dlUnits.Text;
            }

            if (this.quantity1.dlCostItem.SelectedIndex != -1)
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.SelectedValue);
            }
            else
            {
                FormQuantity.CostItemID = Convert.ToInt32(this.quantity1.dlCostItem.Text);
            }

            if (this.quantity1.dlAssembly.SelectedIndex != -1)
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.SelectedValue);
            }
            else
            {
                FormQuantity.AssemblyID = Convert.ToInt32(this.quantity1.dlAssembly.Text);
            }


            if (this.quantity1.dlExpression.SelectedIndex != -1)
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.SelectedValue);
            }
            else
            {
                FormQuantity.ExpressionID = Convert.ToInt32(this.quantity1.dlExpression.Text);
            }

      
			IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.delete(FormQuantity);

		} 
		public override bool ValidateData() 
		{ 

			bool valide = true;

  
            if(this.quantity1.txtDescription.Text.Length ==0)valide = false;


			if(this.quantity1.dlDivision.Text.Length ==0)valide = false;
			if(this.quantity1.dlDivisionCost.Text.Length ==0)valide = false;
			if(this.quantity1.dlDivisionPrint.Text.Length ==0)valide = false;
			if(this.quantity1.dlLocation.Text.Length ==0)valide = false;

            if (this.quantity1.txtQuantityAdjusted.Text.Length == 0) valide = false;
            if (this.quantity1.txtQuantityReuse.Text.Length == 0) valide = false;
            if (this.quantity1.txtQuantityRoundUp.Text.Length == 0) valide = false;
            if (this.quantity1.txtQuantityWaste.Text.Length == 0) valide = false;

            //if(this.quantity1.txtMemo.Text.Length ==0)valide = false;

			if(this.quantity1.dlUnits.Text.Length ==0)valide = false;
			if(this.quantity1.dlAssembly.Text.Length ==0)
			{
				this.quantity1.dlAssembly.Text="0";
			}
			

            if (this.quantity1.dlExpression.Text.Length == 0)
            {
                this.quantity1.dlExpression.Text = "0";
            }

            return valide; 
		}


       

       public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();


        protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

        
           try
           {
                foreach (Form item in this.localquantity.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }

                this.localquantity.MdiParent.Refresh();
            }
           catch { }

            


            _DivisionDataProvider.selectQuantityDivision(IDIGITALTEKGRID.Builder.lstQuantityDivision);
            _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstQuantityJob);



        } 



	}
}
