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
	/// Summary description for QuantityMDI.
	/// </summary>
	public class QuantityMDI :  IDIGITALTEKGRID.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>

        private System.ComponentModel.IContainer components = null;
        protected Label lbSelectJob;
        private Label lbHeader;
        private IDIGITALTEKGRID.QuantityDatas quantity ;

        public QuantityMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}
        public override void Refresh()
        {
            this.quantity = new QuantityDatas();

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.quantityId;

            if ((IDIGITALTEKGRID.ApplicationBuilder.quantityId != "All")&&(IDIGITALTEKGRID.ApplicationBuilder.quantityId !=null))
            { this.quantity = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivision(IDIGITALTEKGRID.ApplicationBuilder.quantityId); }
            else if (IDIGITALTEKGRID.ApplicationBuilder.quantityJobId != null)
            {
                this.lbSelectJob.Text = IDIGITALTEKGRID.ApplicationBuilder.quantityJobId;
                this.quantity = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.quantityJobId);
            }
            else
            { this.quantity = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivision(); }
           
            this.GridEX.DataSource = this.quantity.Clone();
            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }
           this.GridEX.Refetch();

           IDIGITALTEKGRID.Builder.progressEstimate.Increment(-200);
      
       }


        public override void ShowExportViewDialog()
        {
            DataSet dtExport;
            if ((IDIGITALTEKGRID.ApplicationBuilder.quantityId != "All") && (IDIGITALTEKGRID.ApplicationBuilder.quantityId != null))
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivisionData(IDIGITALTEKGRID.ApplicationBuilder.quantityId); }
            else if (IDIGITALTEKGRID.ApplicationBuilder.quantityJobId != null)
            {
                dtExport = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.quantityJobId);
            }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivisionData(); }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityMDI));
            this.lbSelectJob = new System.Windows.Forms.Label();
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
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.DesignTimeLayout = gridEXLayout1;
            this.GridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GridEX.Size = new System.Drawing.Size(867, 389);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Controls.Add(this.lbSelectJob);
            this.TopRebar1.Size = new System.Drawing.Size(867, 56);
            this.TopRebar1.Controls.SetChildIndex(this.lbSelectJob, 0);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbHeader, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // lbSelectJob
            // 
            this.lbSelectJob.AutoSize = true;
            this.lbSelectJob.Location = new System.Drawing.Point(45, 31);
            this.lbSelectJob.Name = "lbSelectJob";
            this.lbSelectJob.Size = new System.Drawing.Size(0, 0);
            this.lbSelectJob.TabIndex = 3;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(64, 35);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 5;
            // 
            // QuantityMDI
            // 
            this.ClientSize = new System.Drawing.Size(867, 445);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "QuantityMDI";
            this.Text = "Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion		
	
		public IDIGITALTEKGRID.QuantityDataProvider DataSource;
	


		public override void load()
		{
            base.load();

            quantity =  IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivision();
			this.SetDataBinding(quantity);
            this.BringToFront();
        }

		
		public void createQuantityMDI(string _id)
		{
			IDIGITALTEKGRID.ApplicationBuilder.quantityId = _id;

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.quantityId;
			this.Select();
		}

        public void createQuantityJobMDI(string _id)
        {
            IDIGITALTEKGRID.ApplicationBuilder.quantityJobId = _id;
            IDIGITALTEKGRID.ApplicationBuilder.quantityId = _id;

            this.loadQuantityJob(IDIGITALTEKGRID.ApplicationBuilder.quantityJobId);
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

			if(IDIGITALTEKGRID.ApplicationBuilder.quantityId !="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.quantityId);}
			else
			{this.load();}
			if(IDIGITALTEKGRID.ApplicationBuilder.OpenQuantityMode != OpenQuantity.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenQuantityMode = OpenQuantity.On;
				this.Show();
			}
			
		}

 
        public void loadQuantityJob(string _id)
        {
            quantity = IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.select(_id);
            this.GridEX.DataSource = this.quantity.Clone();
            this.GridEX.Refetch();
           
        }


        public override void load(string _id)
		{
            base.load();
            quantity =  IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.selectDivision(_id);
		
			this.SetDataBinding(quantity);
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
                this.GridEX.DropDowns["dlDivision"].SetDataBinding(list.UserValidationDivision(), "");

            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlDivisionPrint"].SetDataBinding(list.UserValidationDivisionPrint(), "");

            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlUnits"].SetDataBinding(list.UserValidationUnits(), "");

            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlLocation"].SetDataBinding(list.UserValidationLocation(), "");

            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlCostItemID"].SetDataBinding(list.CostItemIDDescription(), "");
            }
            catch { }


            try
            {
                this.GridEX.DropDowns["dlAssembly"].SetDataBinding(list.AssemblyIDName(), "");  //list.AssemblyIDDescription();
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlExpression"].SetDataBinding(list.DescriptionExpressionID(), "");  //list.Expression();
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlReportPhase"].SetDataBinding(list.UserValidationPhase(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlReportContract"].SetDataBinding(list.UserValidationContract(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlAccounting"].SetDataBinding(list.UserValidationAccounting(), "");
            }
            catch { }


            if (_ViewChanged == true)
            {
                this.GridEX.Refetch();
            }
            IDIGITALTEKGRID.Builder.progressEstimate.Increment(-200);
        }

        
        public override void SetDataBinding(object _data)
		{
            base.SetDataBinding(_data);
            this.resizeColumn(); 
        }


        protected override void GridEX_DropDown(Object sender, ColumnActionEventArgs e)
        {
            GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                item = transTemp1;
                if ((item.RowType == RowType.Record) && (e.Column.Caption == "DivisionCost"))
                {
                    IDIGITALTEKGRID.ListDataProvider list = new ListDataProvider();
                    IDIGITALTEKGRID.QuantityData i = (IDIGITALTEKGRID.QuantityData)item.GetRow().DataRow;
                    this.GridEX.DropDowns["dlDivisionCost"].SetDataBinding(list.UserValidationDivisionCost(i.Division), "");
                    this.GridEX.DropDowns["dlDivisionCost"].Refetch();
                }
            }
        }


        public override void ShowNewItemDialog()
		{
			IDIGITALTEKGRID.Quantity QuantityDialog = new IDIGITALTEKGRID.Quantity();

            if (IDIGITALTEKGRID.ApplicationBuilder.quantityId != null)
            { QuantityDialog.CreateNewQuantity(this);  }
            else
            { QuantityDialog.CreateQuantity(); }


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
                            IDIGITALTEKGRID.QuantityDataProvider Quantity = new IDIGITALTEKGRID.QuantityDataProvider();
                            this.quantity.Remove((IDIGITALTEKGRID.QuantityData)item.GetRow().DataRow);
                            Quantity.delete((IDIGITALTEKGRID.QuantityData)item.GetRow().DataRow);

                         
                             IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.delete((IDIGITALTEKGRID.QuantityData)item.GetRow().DataRow); 

                            _DivisionDataProvider.selectQuantityDivision(IDIGITALTEKGRID.Builder.lstQuantityDivision);
                        }
                    }
                    this.GridEX.DataSource = this.quantity.Clone();
                    this.GridEX.Refetch();
                    break;

                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }

        }

        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
        public override bool SaveData()
        {
            base.SaveData();
            IDIGITALTEKGRID.QuantityDataProvider Quantity = new IDIGITALTEKGRID.QuantityDataProvider();


            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                IDIGITALTEKGRID.ApplicationBuilder.QuantityDataSource.update((IDIGITALTEKGRID.QuantityData)this.GridEX.GetRow().DataRow);

            }
            _DivisionDataProvider.selectQuantityDivision(IDIGITALTEKGRID.Builder.lstQuantityDivision);
            _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstQuantityJob);
            return true;
        }


        public override void Edit() 
		{ 
			Janus.Windows.GridEX.GridEXSelectedItem item = null;
            IDIGITALTEKGRID.Quantity quantityDialog = new IDIGITALTEKGRID.Quantity();
            
            foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 
					
					
					quantityDialog.Edit((IDIGITALTEKGRID.QuantityData)item.GetRow().DataRow,this); 
				} 
			}
		}
        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }


        
        
        protected IDIGITALTEKGRID.QuantityDatas _QuantityData;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			 _QuantityData = new IDIGITALTEKGRID.QuantityDatas();

			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                IDIGITALTEKGRID.QuantityDataProvider Quantity = new IDIGITALTEKGRID.QuantityDataProvider();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						int i2, i9, i10;
                        decimal i12,i13,i14,i15,i16;
                        bool i11;
						System.DateTime i17;

                        try { i2 = Convert.ToInt32(i[2]); }
                        catch { i2 = 0; }

                        try { i9 = Convert.ToInt32(i[9]); }
                        catch { i9 = 0; }

                        try{i10 = Convert.ToInt32(i[10]);}
						catch{i10=0;}

                        try { i11 = Convert.ToBoolean(i[11]); }
                        catch { i11 = false; }

                        try { i12 = Convert.ToDecimal(i[12]); }
                        catch { i12 = 0; }

                        try { i13 = Convert.ToDecimal(i[13]); }
                        catch { i13 = 0; }

                        try { i14 = Convert.ToDecimal(i[14]); }
                        catch { i14 = 0; }

                        try { i15 = Convert.ToDecimal(i[15]); }
                        catch { i15 = 0; }

                        try { i16 = Convert.ToDecimal(i[16]); }
                        catch { i16 = 0; }


                        try { i17 = Convert.ToDateTime(i[17]); }
                        catch { i17 = System.DateTime.Now; }

                        try
						{
							_QuantityData.Add(new QuantityData("",i[0],i[1],i2,i[3],i[4],i[5],i[6],i[7],i[8],i9,i10,i11,i12,0,i13,i14,i15,i16,i17,0,"",0,0));
                            Quantity.add(new QuantityData("",i[0], i[1], i2, i[3], i[4], i[5], i[6], i[7], i[8], i9, i10, i11, i12,0, i13, i14, i15, i16, i17, 0, "", 0, 0));

						}
						catch{}
                        count++;
                    }
			
			this.GridEX.SetDataBinding(_QuantityData,"");
			this.GridEX.RetrieveStructure();
		}


        public override void InsertData()
        {
            try{
            IDIGITALTEKGRID.QuantityDataProvider Quantity = new IDIGITALTEKGRID.QuantityDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                Quantity.Copy((IDIGITALTEKGRID.QuantityData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                     }
            catch { }

        }

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );	
			IDIGITALTEKGRID.ApplicationBuilder.OpenQuantityMode = OpenQuantity.Off;

            IDIGITALTEKGRID.ApplicationBuilder.XQuantity = this.ClientSize.Width;
            IDIGITALTEKGRID.ApplicationBuilder.YQuantity = this.ClientSize.Height;
    
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                  IDIGITALTEKGRID.QuantityDataProvider Quantity = new IDIGITALTEKGRID.QuantityDataProvider();

                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    Quantity.add((IDIGITALTEKGRID.QuantityData)this.GridEX.GetRow(i).DataRow);

                }

            }

        }

	}
}
