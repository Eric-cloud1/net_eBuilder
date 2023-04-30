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
	/// Summary description for CostAmountMDI.
	/// </summary>
	public class CostAmountMDI : IDIGITALTEKGRID.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CostAmountMDI()
		{
			//
			// Required for Windows Form Designer support
	
		}
        public override void Refresh()
        {
            this.costAmount = new CostAmountDatas();
            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.costAmountId;
            if (IDIGITALTEKGRID.ApplicationBuilder.costAmountId != "All")
            { this.costAmount = IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.costAmountId); }
            else
            { this.costAmount = IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.select(); }

           this.GridEX.DataSource = this.costAmount.Clone();
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
            if (IDIGITALTEKGRID.ApplicationBuilder.costAmountId != "All")
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.costAmountId); }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.selectData(); }
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
		protected  new void  InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostAmountMDI));
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
            this.GridEX.Size = new System.Drawing.Size(816, 395);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(816, 56);
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
            this.lbHeader.Location = new System.Drawing.Point(68, 35);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 5;
            // 
            // CostAmountMDI
            // 
            this.ClientSize = new System.Drawing.Size(816, 451);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "CostAmountMDI";
            this.Text = "Cost Amount";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion


		private IDIGITALTEKGRID.CostAmountDatas costAmount;
        private Label lbHeader;	
		public IDIGITALTEKGRID.CostAmountDataProvider DataSource;

	
	

		public void createCostAmountMDI(string _id)
		{
			IDIGITALTEKGRID.ApplicationBuilder.costAmountId = _id;
            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.costAmountId;
			this.Select();

		}


        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

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


			if(IDIGITALTEKGRID.ApplicationBuilder.costAmountId!="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.costAmountId);}

			else
			{this.load();}
			if(IDIGITALTEKGRID.ApplicationBuilder.OpenCostAmountMode != OpenCostAmount.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenCostAmountMode = OpenCostAmount.On;
				this.Show();
			}
		
		}

        public override void load()
        {
            base.load();

            costAmount = IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.select();
            this.SetDataBinding(costAmount);
            this.BringToFront();
        }
        
        public override void load(string _id)
		{
            base.load();
            costAmount =   IDIGITALTEKGRID.ApplicationBuilder.CostAmountDataSource.select(_id);
            this.dataSource = costAmount;
            this.SetDataBinding(costAmount);
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
                this.GridEX.DropDowns["dlBuildingType"].SetDataBinding(list.UserValidationBuildingType(), "");
            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlVendorID"].SetDataBinding(list.VendorIDCompany(), "");

            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlManufactureID"].SetDataBinding(list.ManufactureIDCompany(), "");
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
			IDIGITALTEKGRID.CostAmount CostAmountDialog = new IDIGITALTEKGRID.CostAmount();
			CostAmountDialog.CreateNewCostAmount(this);
		
		}



        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
	
        public override bool SaveData()
        {
            base.SaveData();
            IDIGITALTEKGRID.CostAmountDataProvider CostAmount = new IDIGITALTEKGRID.CostAmountDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {

                CostAmount.update((IDIGITALTEKGRID.CostAmountData)this.GridEX.GetRow().DataRow);
            }

            _DivisionDataProvider.selectCostAmount(IDIGITALTEKGRID.Builder.lstCostAmountDivision);
	
            return true;
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
                            IDIGITALTEKGRID.CostAmountDataProvider CostAmount = new IDIGITALTEKGRID.CostAmountDataProvider();
                            this.costAmount.Remove((IDIGITALTEKGRID.CostAmountData)item.GetRow().DataRow);
                            CostAmount.delete((IDIGITALTEKGRID.CostAmountData)item.GetRow().DataRow);
                            _DivisionDataProvider.selectCostAmount(IDIGITALTEKGRID.Builder.lstCostAmountDivision);
                        }
                    }
                    this.GridEX.DataSource = this.costAmount.Clone();
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
					IDIGITALTEKGRID.CostAmount costDialog = new IDIGITALTEKGRID.CostAmount(); 
					costDialog.Edit(  (IDIGITALTEKGRID.CostAmountData) item.GetRow().DataRow,   this); 
				} 
			}
		}


		

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 	
			IDIGITALTEKGRID.ApplicationBuilder.OpenCostAmountMode = OpenCostAmount.Off;

            IDIGITALTEKGRID.ApplicationBuilder.XCostAmount = this.ClientSize.Width;
            IDIGITALTEKGRID.ApplicationBuilder.YCostAmount = this.ClientSize.Height;
      
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                IDIGITALTEKGRID.CostAmountDataProvider CostAmount = new IDIGITALTEKGRID.CostAmountDataProvider();

                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    CostAmount.add((IDIGITALTEKGRID.CostAmountData)this.GridEX.GetRow(i).DataRow);

                }

            }

        }

        public override void InsertData()
        {
            try{
            IDIGITALTEKGRID.CostAmountDataProvider CostAmount = new IDIGITALTEKGRID.CostAmountDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                CostAmount.Copy((IDIGITALTEKGRID.CostAmountData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                 }
            catch { }
        }



		protected 	IDIGITALTEKGRID.CostAmountDatas _costAmountData ;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			 _costAmountData = new IDIGITALTEKGRID.CostAmountDatas();
             IDIGITALTEKGRID.CostAmountDataProvider CostAmount = new IDIGITALTEKGRID.CostAmountDataProvider();
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						System.DateTime i1;
						int i3,i4,i10;
                        decimal i8, i13;
                        bool i9;

						try{i1= Convert.ToDateTime(i[1]);}
						catch{i1=System.DateTime.Now;}
						try{i3= Convert.ToInt32(i[3]);}
						catch{i3=0;}
                        try { i4 = Convert.ToInt32(i[4]); }
                        catch { i4 = 0; }
                 
						try{i8= Convert.ToDecimal(i[8]);}
						catch{i8=0;}

                        try { i13 = Convert.ToDecimal(i[13]); }
                        catch { i13 = 0; }
                        
                        try{i9= Convert.ToBoolean(i[9]);}
						catch{i9=false;}
                        try { i10 = Convert.ToInt32(i[10]); }
                        catch { i10 = 0; }

                        try
						{
							_costAmountData.Add(new  CostAmountData(i[0],i1,i[2],i3,i4,i[5],i[6],i[7],i8,i9,i10,i[11],i[12],i13,"",null,null,0,0));

                            CostAmount.add( new CostAmountData(i[0], i1, i[2], i3, i4, i[5], i[6], i[7], i8, i9, i10, i[11], i[12], i13, "", null, null, 0, 0));

                        }
						catch{}
                    count++;
					}
				
        	this.GridEX.SetDataBinding(_costAmountData,"");
			this.GridEX.RetrieveStructure();


			}
				




	}
}
