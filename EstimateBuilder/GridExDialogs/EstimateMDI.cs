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
using System.Threading;


namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ReportMDI.
	/// </summary>
	public class EstimateMDI :  EstimateBuilder.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EstimateMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}


        void dlSelectEstimate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public override void Refresh()
        {
            this.estimate = new EstimateDatas();

            this.lbProjectName.Text = EstimateBuilder.ApplicationBuilder.estimateId;
            this.estimate = EstimateBuilder.ApplicationBuilder.EstimateDataSource.select(EstimateBuilder.ApplicationBuilder.estimateId,this.dlSelectEstimate.SelectedIndex);      
            
            this.GridEX.DataSource = this.estimate.Clone();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstimateMDI));
            this.cmdExport1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExport1");
            this.CmdFavoriteVendor1 = new Janus.Windows.UI.CommandBars.UICommand("CmdFavoriteVendor1");
            this.CmdPreferredVendor1 = new Janus.Windows.UI.CommandBars.UICommand("CmdPreferredVendor1");
            this.lbSelectEstimate = new System.Windows.Forms.Label();
            this.dlSelectEstimate = new System.Windows.Forms.ComboBox();
            this.lbProjectName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEX
            // 
            this.GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
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
            this.GridEX.Size = new System.Drawing.Size(792, 410);
            this.GridEX.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.GridEX_FormattingRow);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbProjectName);
            this.TopRebar1.Controls.Add(this.dlSelectEstimate);
            this.TopRebar1.Controls.Add(this.lbSelectEstimate);
            this.TopRebar1.Size = new System.Drawing.Size(792, 56);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbSelectEstimate, 0);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectEstimate, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbProjectName, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // cmdExport1
            // 
            this.cmdExport1.Key = "cmdExport1";
            this.cmdExport1.Name = "cmdExport1";
            // 
            // CmdFavoriteVendor1
            // 
            this.CmdFavoriteVendor1.Key = "CmdFavoriteVendor1";
            this.CmdFavoriteVendor1.Name = "CmdFavoriteVendor1";
            // 
            // CmdPreferredVendor1
            // 
            this.CmdPreferredVendor1.Key = "CmdPreferredVendor1";
            this.CmdPreferredVendor1.Name = "CmdPreferredVendor1";
            // 
            // lbSelectEstimate
            // 
            this.lbSelectEstimate.AutoSize = true;
            this.lbSelectEstimate.Location = new System.Drawing.Point(195, 31);
            this.lbSelectEstimate.Name = "lbSelectEstimate";
            this.lbSelectEstimate.Size = new System.Drawing.Size(70, 13);
            this.lbSelectEstimate.TabIndex = 6;
            this.lbSelectEstimate.Text = "Select Vendor";
            // 
            // dlSelectEstimate
            // 
            this.dlSelectEstimate.FormattingEnabled = true;
            this.dlSelectEstimate.Items.AddRange(new object[] {
            "All Vendors",
            "Premium Vendors",
            "Discount Vendors",
            "All Favorites Vendors",
            "Premium Favorites Vendors",
            "Discount Favorites Vendors"});
            this.dlSelectEstimate.Location = new System.Drawing.Point(277, 28);
            this.dlSelectEstimate.Name = "dlSelectEstimate";
            this.dlSelectEstimate.Size = new System.Drawing.Size(187, 21);
            this.dlSelectEstimate.TabIndex = 7;
            this.dlSelectEstimate.SelectedIndexChanged += new System.EventHandler(this.dlSelectEstimate_SelectedIndexChanged);
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(64, 34);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(0, 0);
            this.lbProjectName.TabIndex = 8;
            // 
            // EstimateMDI
            // 
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "EstimateMDI";
            this.Text = "Estimate";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private Janus.Windows.UI.CommandBars.UICommand cmdExport1;
        private Janus.Windows.UI.CommandBars.UICommand CmdFavoriteVendor1;
        private Janus.Windows.UI.CommandBars.UICommand CmdPreferredVendor1;
        private Label lbSelectEstimate;
        protected ComboBox dlSelectEstimate;
        protected Label lbProjectName;



        private EstimateBuilder.EstimateDatas estimate;


		

		public void createEstimatetMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.estimateId = _id;
            this.lbProjectName.Text = EstimateBuilder.ApplicationBuilder.estimateId;
			this.Select(EstimateBuilder.ApplicationBuilder.estimateId);
		}


        public void Select(string _id)
        {
		    InitializeComponent();

            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }

            this.load(EstimateBuilder.ApplicationBuilder.estimateId);

            if(EstimateBuilder.ApplicationBuilder.OpenEstimateMode != OpenEstimate.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenEstimateMode = OpenEstimate.On;
				this.Show();
			}
           
		
		}
		public override void load(string _id)
		{
            base.load();


            this.dlSelectEstimate.SelectedIndex = 0;

            estimate = EstimateBuilder.ApplicationBuilder.EstimateDataSource.select(_id, this.dlSelectEstimate.SelectedIndex);
			this.SetDataBinding(estimate);
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
	

		
		

	

		public override void UpdateData() 
		{ 
//			GridEXSelectedItem item = null; 
//			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
//			{ 
//				item = transTemp1;
//				if ( item.RowType == RowType.Record ) 
//				{ 
//					EstimateBuilder.EstimateDataProvider Estimate  = new EstimateBuilder.EstimateDataProvider(); 
//					
//					Estimate.update((EstimateBuilder.EstimateData) item.GetRow().DataRow);
//				} 
//			}
//			this.Refresh(EstimateBuilder.ApplicationBuilder.estimateId);
//			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Insert;
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
                            EstimateBuilder.EstimateDataProvider Estimate = new EstimateBuilder.EstimateDataProvider();
                            this.estimate.Remove((EstimateBuilder.EstimateData)item.GetRow().DataRow);
                        
                        }
                    }
                    this.GridEX.DataSource = this.estimate.Clone();
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
					//EstimateBuilder.r reportDialog = new EstimateBuilder.Report(); 
					//reportDialog.Edit(  (EstimateBuilder.reportData) item.GetRow().DataRow,   this); 
				} 
			}
		}

        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			EstimateBuilder.EstimateDatas _EstimateData = new EstimateBuilder.EstimateDatas();
		
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
                        int i0, i1, i2, i3, i4;
                        try{ i0 = Convert.ToInt32(i[0]); }
                        catch { i0 = 0; }
                        try { i1 = Convert.ToInt32(i[1]); }
                        catch { i1 = 0; }
                        try { i2 = Convert.ToInt32(i[2]); }
                        catch { i2 = 0; }
                        try { i3 = Convert.ToInt32(i[3]); }
                        catch { i3 = 0; }
                        try { i4 = Convert.ToInt32(i[4]); }
                        catch { i4 = 0; }



                        try
						{
                           // _EstimateData.Add(new EstimateData(i0,i1,i2,i3,i4,i[5],i[6],i[7],i[8],i[9],i[10],i[11],i[12],i[13],i[14],i[15],i[16],i[1],i[17],i[18],i[19],i[20],i[21],i[22],i[23],i[24],i[25],i[26],i[27],i[28],i[29]));
                        }
						catch{}
					}
                    count++;

                    this.GridEX.SetDataBinding(_EstimateData, "");
                    this.GridEX.RetrieveStructure();
			        EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
		}

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            EstimateBuilder.ApplicationBuilder.XEstimate = this.ClientSize.Width;
            EstimateBuilder.ApplicationBuilder.YEstimate = this.ClientSize.Height;
		
			EstimateBuilder.ApplicationBuilder.OpenEstimateMode = OpenEstimate.Off;
		
		}


        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }

        public override void ShowExportViewDialog()
        {
            DataTable dtExport = EstimateBuilder.ApplicationBuilder.EstimateDataSource.selectExport(EstimateBuilder.ApplicationBuilder.estimateId, this.dlSelectEstimate.SelectedIndex);
            this.Export(dtExport);

        }

        private void GridEX_FormattingRow(object sender, RowLoadEventArgs e)
        {

        }


        

    }
}
