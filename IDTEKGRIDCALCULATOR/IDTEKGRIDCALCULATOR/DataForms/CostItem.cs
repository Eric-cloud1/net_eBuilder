
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for CostItem.
	/// </summary>
	public class CostItem : IDIGITALTEKGRID.DataForm
	{
        private IDIGITALTEKGRIDCONTROL.CostItem costItem1;
        private Janus.Windows.UI.CommandBars.UICommand cmdSaveClose1;


        private System.ComponentModel.IContainer components = null;

		public CostItem()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostItem));
            this.cmdSaveClose1 = new Janus.Windows.UI.CommandBars.UICommand("cmdSaveClose");
            this.costItem1 = new IDIGITALTEKGRIDControl.CostItem();
            this.SuspendLayout();
// 
// cmdSaveClose1
// 
            this.cmdSaveClose1.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.Image;
            this.cmdSaveClose1.ImageIndex = 0;
            this.cmdSaveClose1.Key = "cmdSaveClose";
            this.cmdSaveClose1.Name = "cmdSaveClose1";
// 
// costItem1
// 
            this.costItem1.Location = new System.Drawing.Point(0, 0);
            this.costItem1.Name = "costItem1";
            this.costItem1.Size = new System.Drawing.Size(575, 345);
            this.costItem1.TabIndex = 11;
// 
// CostItem
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.costItem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "CostItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.costItem1, 0);
            this.ResumeLayout(false);

        }
		#endregion


		public  IDIGITALTEKGRID.CostItemMDI  costItem = new IDIGITALTEKGRID.CostItemMDI();	
		protected IDIGITALTEKGRID.CostItemData FormCostItem = new CostItemData();
		

		public void CreateCostItem()
		{			
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.costItem1.CostItem_Load();
            this.Show();
		}

		public void CreateNewCostItem( IDIGITALTEKGRID.CostItemMDI  _costItem)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.costItem =  _costItem;
            this.costItem1.CostItem_Load();
            this.Show();
		}

		public void CreateCostItem( IDIGITALTEKGRID.CostItemMDI  _costItem)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.costItem =  _costItem;
            this.costItem1.CostItem_Load();
            this.Show();
		}

		public void Edit( IDIGITALTEKGRID.CostItemData  _formItem,  IDIGITALTEKGRID.CostItemMDI  _costItem ) 
		{
            this.costItem1.CostItem_Load();
            if (_formItem.Active == true)
            { 
			this.costItem1.chkActive.Checked = true;}
			else
			{this.costItem1.chkActive.Checked = false;};

            this.costItem1.txtID.Text = _formItem.CostItemID.ToString();
            this.costItem1.txtCostAdjustment.Text = _formItem.CostAdjustment.ToString();
			this.costItem1.txtDescription.Text = _formItem.Description ;
			this.costItem1.txtMemo.Text = _formItem.Memo ;
			this.costItem1.txtMinimumOrder.Text = _formItem.MinimumOrder.ToString();
			
            this.costItem1.dlCostType.Text = _formItem.CostType;
            this.costItem1.dlDivision.Text = _formItem.Division;
            this.costItem1.dlDivisionCost.Text = _formItem.DivisionCost;

            this.costItem1.dlUnitOrder.Text = _formItem.UnitOrder;
            this.costItem1.dlCostType.Text = _formItem.CostType.ToString();


            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.costItem = _costItem;			
			this.Show(); 
		}
	


		public override void InsertData() 
		{

            if (this.costItem1.chkActive.Checked)
            { FormCostItem.Active = true; }
            else
            { FormCostItem.Active = false; };

            FormCostItem.Memo = this.costItem1.txtMemo.Text;
            FormCostItem.Description = this.costItem1.txtDescription.Text;


            try
            {
                FormCostItem.CostAdjustment = Convert.ToDecimal(this.costItem1.txtCostAdjustment.Text);
            }
            catch
            {
                FormCostItem.CostAdjustment = 0;
            }
            try
            {
                FormCostItem.MinimumOrder = Convert.ToDecimal(this.costItem1.txtMinimumOrder.Text);
            }
            catch
            {
                FormCostItem.MinimumOrder = 0;
            }
            try
            {
                FormCostItem.CostItemID = Convert.ToDecimal(this.costItem1.txtID.Text);
            }
            catch { }


            if (this.costItem1.dlProvider.SelectedIndex != -1)
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.Text;
            }

            if (this.costItem1.dlCostType.SelectedIndex != -1)
            {
                FormCostItem.CostType = this.costItem1.dlCostType.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.CostType = this.costItem1.dlCostType.Text;
            }

            if (this.costItem1.dlDivision.SelectedIndex != -1)
            {
                FormCostItem.Division = this.costItem1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.Division = this.costItem1.dlDivision.Text;
            }

            if (this.costItem1.dlDivisionCost.SelectedIndex != -1)
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.Text;
            }

            if (this.costItem1.dlUnitOrder.SelectedIndex != -1)
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.Text;
            }
          

            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.add(FormCostItem);		
		} 

		public override void UpdateData() 
		{

            if (this.costItem1.chkActive.Checked)
            { FormCostItem.Active = true; }
            else
            { FormCostItem.Active = false; };

            FormCostItem.Memo = this.costItem1.txtMemo.Text;
            FormCostItem.Description = this.costItem1.txtDescription.Text;


            try
            {
                FormCostItem.CostAdjustment = Convert.ToDecimal(this.costItem1.txtCostAdjustment.Text);
            }
            catch
            {
                FormCostItem.CostAdjustment = 0;
            }
            try
            {
                FormCostItem.MinimumOrder = Convert.ToDecimal(this.costItem1.txtMinimumOrder.Text);
            }
            catch
            {
                FormCostItem.MinimumOrder = 0;
            }

            try
            {
                FormCostItem.CostItemID = Convert.ToDecimal(this.costItem1.txtID.Text);
            }
            catch { }

            if (this.costItem1.dlProvider.SelectedIndex != -1)
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.Text;
            }


            if (this.costItem1.dlCostType.SelectedIndex != -1)
            {
                FormCostItem.CostType = this.costItem1.dlCostType.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.CostType = this.costItem1.dlCostType.Text;
            }

            if (this.costItem1.dlDivision.SelectedIndex != -1)
            {
                FormCostItem.Division = this.costItem1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.Division = this.costItem1.dlDivision.Text;
            }

            if (this.costItem1.dlDivisionCost.SelectedIndex != -1)
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.Text;
            }

            if (this.costItem1.dlUnitOrder.SelectedIndex != -1)
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.Text;
            }
          
            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.update(FormCostItem);		
		} 
		public override void CancelData() 
		{ 
			this.costItem1.chkActive.Checked = false;
			this.costItem1.txtCostAdjustment.Text = "";
			this.costItem1.txtDescription.Text = "";
			this.costItem1.txtMemo.Text = "";
			this.costItem1.txtMinimumOrder.Text = "";	
			this.costItem1.dlCostType.Text = "";      
            this.costItem1.dlDivision.Text = "";
            this.costItem1.dlDivisionCost.Text = "";
			this.costItem1.dlUnitOrder.Text =  "";
		} 

		public override void DeleteData() 
		{
            if (this.costItem1.chkActive.Checked)
            { FormCostItem.Active = true; }
            else
            { FormCostItem.Active = false; };

            FormCostItem.Memo = this.costItem1.txtMemo.Text;
            FormCostItem.Description = this.costItem1.txtDescription.Text;


            try
            {
                FormCostItem.CostAdjustment = Convert.ToDecimal(this.costItem1.txtCostAdjustment.Text);
            }
            catch
            {
                FormCostItem.CostAdjustment = 0;
            }
             try
            {
                FormCostItem.MinimumOrder = Convert.ToDecimal(this.costItem1.txtMinimumOrder.Text);
            }
            catch
            {
                FormCostItem.MinimumOrder = 0;
            }
            try
            {
                FormCostItem.CostItemID = Convert.ToDecimal(this.costItem1.txtID.Text);
            }
            catch { }

            if (this.costItem1.dlProvider.SelectedIndex != -1)
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.GenericVendor = this.costItem1.dlProvider.Text;
            }


            if (this.costItem1.dlCostType.SelectedIndex != -1)
            {
                FormCostItem.CostType = this.costItem1.dlCostType.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.CostType = this.costItem1.dlCostType.Text;
            }

            if (this.costItem1.dlDivision.SelectedIndex != -1)
            {
                FormCostItem.Division = this.costItem1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.Division = this.costItem1.dlDivision.Text;
            }

            if (this.costItem1.dlDivisionCost.SelectedIndex != -1)
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.DivisionCost = this.costItem1.dlDivisionCost.Text;
            }

            if (this.costItem1.dlUnitOrder.SelectedIndex != -1)
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.SelectedValue.ToString();
            }
            else
            {
                FormCostItem.UnitOrder = this.costItem1.dlUnitOrder.Text;
            }
          

            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Delete;
			IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.delete(FormCostItem);	
		} 

		public override bool ValidateData() 
		{ 
			bool valide = true;

			if(this.costItem1.txtCostAdjustment.Text.Length ==0)valide = false;
			if(this.costItem1.txtDescription.Text.Length ==0)valide = false;
			
			if(this.costItem1.txtMinimumOrder.Text.Length ==0)valide = false;


			if(this.costItem1.dlCostType.Text.Length ==0)valide = false;
	
		
		
			if(this.costItem1.dlDivision.Text.Length ==0)valide = false;
            if (this.costItem1.dlDivisionCost.Text.Length == 0) valide = false;

	
			if(this.costItem1.dlUnitOrder.Text.Length ==0)valide = false;

			return valide; 
		}	
	
	
		public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.costItem.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
                this.costItem.MdiParent.Refresh();
            }
            catch { }

         

            _DivisionDataProvider.selectCostItem(IDIGITALTEKGRID.Builder.lstCostItemDivision);
		   
		
        } 



	}
}
