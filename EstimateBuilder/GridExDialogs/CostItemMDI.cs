using System.ComponentModel;
using EstimateBuilder;
using System.Text;
using Microsoft.VisualBasic;		 
using Janus.Windows.GridEX; 
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for CostItemMDI.
	/// </summary>
	public class CostItemMDI : EstimateBuilder.Grid
	{
		private System.ComponentModel.IContainer components = null;

		public CostItemMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}
        public override void Refresh()
        {
            this.costItem = new CostItemDatas();

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.costItemId;

            if (EstimateBuilder.ApplicationBuilder.costItemId != "All")
            { this.costItem = EstimateBuilder.ApplicationBuilder.CostItemDataSource.select(EstimateBuilder.ApplicationBuilder.costItemId); }
            else
            { this.costItem = EstimateBuilder.ApplicationBuilder.CostItemDataSource.select(); }

           this.GridEX.DataSource = this.costItem.Clone();
           if (_colapse == true)
           {
               this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
           }
           else
           {
               this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
           }
           this.GridEX.Refetch();
        }

        public override void ShowExportViewDialog()
        {
            DataSet dtExport;
            if (EstimateBuilder.ApplicationBuilder.costItemId != "All")
            { dtExport = EstimateBuilder.ApplicationBuilder.CostItemDataSource.selectData(EstimateBuilder.ApplicationBuilder.costItemId); }
            else
            { dtExport = EstimateBuilder.ApplicationBuilder.CostItemDataSource.selectData(); }

            this.Export(dtExport.Tables[0]);
        }


        public override void Init()
        {
            base.Init();
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
		protected new void InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostItemMDI));
            this.lbHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEX
            // 
            this.GridEX.ColumnAutoResize = true;
            this.GridEX.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            gridEXLayout1.Description = "Grid";
            gridEXLayout1.IsCurrentLayout = true;
            gridEXLayout1.Key = "Grid";
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            gridEXLayout1});
            this.GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic;
            this.GridEX.Size = new System.Drawing.Size(791, 338);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(791, 56);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbHeader, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(65, 36);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 6;
            // 
            // CostItemMDI
            // 
            this.ClientSize = new System.Drawing.Size(791, 394);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "CostItemMDI";
            this.Text = "Cost Item";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private EstimateBuilder.CostItemDatas costItem;
        private Label lbHeader;	
		public EstimateBuilder.CostItemDataProvider  DataSource;

		public void createCostItemMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.costItemId = _id;

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.costItemId;
			this.Select();
		}


        public new void Select()
        {

            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }

		
			if(EstimateBuilder.ApplicationBuilder.costItemId!="All")
			{this.load(EstimateBuilder.ApplicationBuilder.costItemId);}
			else
			{this.load();}
			if(EstimateBuilder.ApplicationBuilder.OpenCostItemMode != OpenCostItem.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenCostItemMode = OpenCostItem.On;
				this.Show();
			}
	
		}
		public override void load()
		{
            base.load();


  

            costItem =  EstimateBuilder.ApplicationBuilder.CostItemDataSource.select();
			this.SetDataBinding(costItem);
            this.BringToFront();
        }
	

		public override void load(string _id)
		{
            base.load();
            costItem =  EstimateBuilder.ApplicationBuilder.CostItemDataSource.select(_id);
			this.SetDataBinding(costItem);
            this.BringToFront();

        }

        public override void LoadSettings(string _viewName, bool _ViewChanged)
        {
            EstimateBuilder.SettingDataProvider Settings = new EstimateBuilder.SettingDataProvider();
            EstimateBuilder.SettingDatas viewRow = new EstimateBuilder.SettingDatas();
            viewRow = Settings.select(_viewName);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(System.Convert.FromBase64String(viewRow[0].Layout));
            this.GridEX.LoadLayoutFile(stream);
            stream.Close();

            EstimateBuilder.ListDataProvider list = new ListDataProvider();


            try
            {
                this.GridEX.DropDowns["dlCostType"].SetDataBinding(list.UserValidationCostType(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlUnitsOrder"].SetDataBinding(list.UserValidationUnits(), "");
            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlGenericVendor"].SetDataBinding(list.UserValidationContractors(), "");

            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlReportLocation"].SetDataBinding(list.UserValidationLocation(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlReportDivision"].SetDataBinding(list.UserValidationDivision(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlReportDivisionPrint"].SetDataBinding(list.UserValidationDivisionPrint(), "");
            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlReportAccounting"].SetDataBinding(list.UserValidationAccounting(), "");
            }
            catch { }


            if (_ViewChanged == true)
            {
                this.GridEX.Refetch();
            }
        }
        
        public override void SetDataBinding(object _data)
		{
            base.SetDataBinding(_data);
            this.resizeColumn(); 


        }
	
	
		
		public override void ShowNewItemDialog()
		{
			EstimateBuilder.CostItem CostItemDialog = new EstimateBuilder.CostItem();
			CostItemDialog.CreateNewCostItem(this);
		}




        public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
	

        public override bool SaveData()
        {
            base.SaveData();
            EstimateBuilder.CostItemDataProvider CostItem = new EstimateBuilder.CostItemDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                CostItem.update((EstimateBuilder.CostItemData)this.GridEX.GetRow().DataRow);
            } _DivisionDataProvider.selectCostItem(EstimateBuilder.Builder.lstCostItemDivision);
		   
            return true;
        }



        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }
        
        public override void Delete() 
		{ 
            DialogResult result = MessageBox.Show("Do you want to delete that Item?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.Yes:
                    //Delete Item
                    GridEXSelectedItem item = null;
                    EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
                    foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                    {
                        //this.GridEX.Delete(); 
                        item = transTemp1;
                        if (item.RowType == RowType.Record)
                        {
                            EstimateBuilder.CostItemDataProvider CostItem = new EstimateBuilder.CostItemDataProvider();
                            this.costItem.Remove((EstimateBuilder.CostItemData)item.GetRow().DataRow);
                            CostItem.delete((EstimateBuilder.CostItemData)item.GetRow().DataRow);

                            _DivisionDataProvider.selectCostItem(EstimateBuilder.Builder.lstCostItemDivision);
                        }
                    }
                    this.GridEX.DataSource = this.costItem.Clone();
                    this.GridEX.Refetch();
                    break;

                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }


		public override void Edit() 
		{ 
			Janus.Windows.GridEX.GridEXSelectedItem item = null; 
			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 
					EstimateBuilder.CostItem costItemDialog = new EstimateBuilder.CostItem(); 
					costItemDialog.Edit((EstimateBuilder.CostItemData)item.GetRow().DataRow, this); 
				} 
			}
		}
	
		protected EstimateBuilder.CostItemDatas _costItemData ;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			_costItemData = new EstimateBuilder.CostItemDatas();
			
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                EstimateBuilder.CostItemDataProvider CostItem = new EstimateBuilder.CostItemDataProvider();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						decimal i3,i7;
						bool i4;

                        try { i3 = Convert.ToDecimal(i[3]); }
                        catch { i3 = 0; }

                        try { i7 = Convert.ToDecimal(i[7]); }
                        catch{i7=0;}

						try{i4= Convert.ToBoolean(i[4]);}
						catch{i4=false;}

						try
						{
							_costItemData.Add(new CostItemData(i[0],i[1],i[2],i3,i4,i[5],i[6],i7,"",0,0,"",""));
                            CostItem.add(new CostItemData(i[0], i[1], i[2], i3, i4, i[5], i[6], i7, "", 0, 0,"",""));
				
						}
						catch{}
                        count++;
                    }
			this.GridEX.SetDataBinding(_costItemData,"");
			this.GridEX.RetrieveStructure();
	
		}

        public override void InsertData()
        {
            try{
            EstimateBuilder.CostItemDataProvider CostItem = new EstimateBuilder.CostItemDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                CostItem.Copy((EstimateBuilder.CostItemData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
               }
            catch { }
        }

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			EstimateBuilder.ApplicationBuilder.OpenCostItemMode = OpenCostItem.Off;

            EstimateBuilder.ApplicationBuilder.XCostItem = this.ClientSize.Width;
            EstimateBuilder.ApplicationBuilder.YCostItem = this.ClientSize.Height;
      
            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                EstimateBuilder.CostItemDataProvider CostItem = new EstimateBuilder.CostItemDataProvider();
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {
                    CostItem.add((EstimateBuilder.CostItemData)this.GridEX.GetRow(i).DataRow);

                }
            }
        }

	}
}
