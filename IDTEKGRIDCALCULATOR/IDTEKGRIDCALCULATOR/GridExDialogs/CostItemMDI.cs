using System.ComponentModel;
using IDIGITALTEKGRID;
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

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for CostItemMDI.
	/// </summary>
	public class CostItemMDI : IDIGITALTEKGRID.Grid
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

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.costItemId;

            if (IDIGITALTEKGRID.ApplicationBuilder.costItemId != "All")
            { this.costItem = IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.costItemId); }
            else
            { this.costItem = IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.select(); }

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
            if (IDIGITALTEKGRID.ApplicationBuilder.costItemId != "All")
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.costItemId); }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.selectData(); }

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

		private IDIGITALTEKGRID.CostItemDatas costItem;
        private Label lbHeader;	
		public IDIGITALTEKGRID.CostItemDataProvider  DataSource;

		public void createCostItemMDI(string _id)
		{
			IDIGITALTEKGRID.ApplicationBuilder.costItemId = _id;

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.costItemId;
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

		
			if(IDIGITALTEKGRID.ApplicationBuilder.costItemId!="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.costItemId);}
			else
			{this.load();}
			if(IDIGITALTEKGRID.ApplicationBuilder.OpenCostItemMode != OpenCostItem.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenCostItemMode = OpenCostItem.On;
				this.Show();
			}
	
		}
		public override void load()
		{
            base.load();


  

            costItem =  IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.select();
			this.SetDataBinding(costItem);
            this.BringToFront();
        }
	

		public override void load(string _id)
		{
            base.load();
            costItem =  IDIGITALTEKGRID.ApplicationBuilder.CostItemDataSource.select(_id);
			this.SetDataBinding(costItem);
            this.BringToFront();

        }

        public override void LoadSettings(string _viewName, bool _ViewChanged)
        {
            IDIGITALTEKGRID.SettingDataProvider Settings = new IDIGITALTEKGRID.SettingDataProvider();
            IDIGITALTEKGRID.SettingDatas viewRow = new IDIGITALTEKGRID.SettingDatas();
            viewRow = Settings.select(_viewName);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(System.Convert.FromBase64String(viewRow[0].Layout));
            this.GridEX.LoadLayoutFile(stream);
            stream.Close();

            IDIGITALTEKGRID.ListDataProvider list = new ListDataProvider();


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
			IDIGITALTEKGRID.CostItem CostItemDialog = new IDIGITALTEKGRID.CostItem();
			CostItemDialog.CreateNewCostItem(this);
		}




        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
	

        public override bool SaveData()
        {
            base.SaveData();
            IDIGITALTEKGRID.CostItemDataProvider CostItem = new IDIGITALTEKGRID.CostItemDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                CostItem.update((IDIGITALTEKGRID.CostItemData)this.GridEX.GetRow().DataRow);
            } _DivisionDataProvider.selectCostItem(IDIGITALTEKGRID.Builder.lstCostItemDivision);
		   
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
                    IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
                    foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                    {
                        //this.GridEX.Delete(); 
                        item = transTemp1;
                        if (item.RowType == RowType.Record)
                        {
                            IDIGITALTEKGRID.CostItemDataProvider CostItem = new IDIGITALTEKGRID.CostItemDataProvider();
                            this.costItem.Remove((IDIGITALTEKGRID.CostItemData)item.GetRow().DataRow);
                            CostItem.delete((IDIGITALTEKGRID.CostItemData)item.GetRow().DataRow);

                            _DivisionDataProvider.selectCostItem(IDIGITALTEKGRID.Builder.lstCostItemDivision);
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
					IDIGITALTEKGRID.CostItem costItemDialog = new IDIGITALTEKGRID.CostItem(); 
					costItemDialog.Edit((IDIGITALTEKGRID.CostItemData)item.GetRow().DataRow, this); 
				} 
			}
		}
	
		protected IDIGITALTEKGRID.CostItemDatas _costItemData ;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			_costItemData = new IDIGITALTEKGRID.CostItemDatas();
			
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                IDIGITALTEKGRID.CostItemDataProvider CostItem = new IDIGITALTEKGRID.CostItemDataProvider();
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
            IDIGITALTEKGRID.CostItemDataProvider CostItem = new IDIGITALTEKGRID.CostItemDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                CostItem.Copy((IDIGITALTEKGRID.CostItemData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
               }
            catch { }
        }

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			IDIGITALTEKGRID.ApplicationBuilder.OpenCostItemMode = OpenCostItem.Off;

            IDIGITALTEKGRID.ApplicationBuilder.XCostItem = this.ClientSize.Width;
            IDIGITALTEKGRID.ApplicationBuilder.YCostItem = this.ClientSize.Height;
      
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                IDIGITALTEKGRID.CostItemDataProvider CostItem = new IDIGITALTEKGRID.CostItemDataProvider();
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {
                    CostItem.add((IDIGITALTEKGRID.CostItemData)this.GridEX.GetRow(i).DataRow);

                }
            }
        }

	}
}
