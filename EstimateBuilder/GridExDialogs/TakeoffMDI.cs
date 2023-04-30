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
	/// Summary description for TakeoffMDI.
	/// </summary>
	public class TakeoffMDI : EstimateBuilder.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TakeoffMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}

        public override void Refresh()
        {
            this.takeOff = new TakeOffDatas();

            this.lbDivisionSelected.Text = EstimateBuilder.ApplicationBuilder.takeOffId;

            if ((EstimateBuilder.ApplicationBuilder.takeOffId != "All") && (EstimateBuilder.ApplicationBuilder.takeOffId != null) && (EstimateBuilder.ApplicationBuilder.takeOffGroup == null))
            { this.takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.select(EstimateBuilder.ApplicationBuilder.takeOffId);
                 
            }
           
            else if((EstimateBuilder.ApplicationBuilder.takeOffJobId != null)&&(EstimateBuilder.ApplicationBuilder.takeOffGroup == null))
            {
                this.lbDivisionSelected.Text = EstimateBuilder.ApplicationBuilder.takeOffJobId;
                this.takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectJob(EstimateBuilder.ApplicationBuilder.takeOffJobId);
            }

            else if (EstimateBuilder.ApplicationBuilder.takeOffGroup != null)
            {
                this.lbDivisionSelected.Text =  EstimateBuilder.ApplicationBuilder.takeOffId +" "+ EstimateBuilder.ApplicationBuilder.takeOffJobId + " " + EstimateBuilder.ApplicationBuilder.takeOffGroup;
                this.takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectGroup(EstimateBuilder.ApplicationBuilder.takeOffGroup, EstimateBuilder.ApplicationBuilder.takeOffJobId, EstimateBuilder.ApplicationBuilder.takeOffId);
            }
            else
            { this.takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.select(); }
             this.GridEX.DataSource = this.takeOff.Clone();
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
            if ((EstimateBuilder.ApplicationBuilder.takeOffId != "All") && (EstimateBuilder.ApplicationBuilder.takeOffId != null))
            { dtExport = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectData(EstimateBuilder.ApplicationBuilder.takeOffId); }

            else if (EstimateBuilder.ApplicationBuilder.takeOffJobId != null)
            {
                dtExport = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectJobData(EstimateBuilder.ApplicationBuilder.takeOffJobId);
            }
            else
            { dtExport = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectData(); }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeoffMDI));
            this.lbDivisionSelected = new System.Windows.Forms.Label();
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
            this.GridEX.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.GridEX.ColumnAutoResize = true;
            this.GridEX.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            gridEXLayout1.IsCurrentLayout = true;
            gridEXLayout1.Key = "Grid";
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            gridEXLayout1});
            this.GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic;
            this.GridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
            this.GridEX.Size = new System.Drawing.Size(952, 381);
            this.GridEX.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GridEX_CellValueChanged);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Controls.Add(this.lbDivisionSelected);
            this.TopRebar1.Size = new System.Drawing.Size(952, 56);
            this.TopRebar1.Controls.SetChildIndex(this.lbDivisionSelected, 0);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbHeader, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // lbDivisionSelected
            // 
            this.lbDivisionSelected.AutoSize = true;
            this.lbDivisionSelected.Location = new System.Drawing.Point(37, 36);
            this.lbDivisionSelected.Name = "lbDivisionSelected";
            this.lbDivisionSelected.Size = new System.Drawing.Size(0, 0);
            this.lbDivisionSelected.TabIndex = 3;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(67, 36);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 8;
            // 
            // TakeoffMDI
            // 
            this.ClientSize = new System.Drawing.Size(952, 437);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "TakeoffMDI";
            this.Text = "Take off";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

   

        #endregion

        protected Label lbDivisionSelected;
        private Label lbHeader;



        private EstimateBuilder.TakeOffDatas takeOff;


		public override void load()
		{
            base.load();
            takeOff =  EstimateBuilder.ApplicationBuilder.TakeOffDataSource.select();
			this.SetDataBinding(takeOff);
            this.BringToFront();
        }

		public void createTakeOffMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.takeOffId = _id;
			this.Select();
		}



        public void createTakeOffJobMDI(string _id)
        {
			EstimateBuilder.ApplicationBuilder.takeOffJobId = _id;
            this.loadJob(EstimateBuilder.ApplicationBuilder.takeOffJobId);
        }



        public void createTakeOffGroupMDI(string _id, string _job, string _division)
        {
			EstimateBuilder.ApplicationBuilder.takeOffGroup = _id;
            EstimateBuilder.ApplicationBuilder.takeOffJobId = _job;
            EstimateBuilder.ApplicationBuilder.takeOffId = _division;
            this.loadGroup(EstimateBuilder.ApplicationBuilder.takeOffGroup, EstimateBuilder.ApplicationBuilder.takeOffJobId, EstimateBuilder.ApplicationBuilder.takeOffId);
        }


        
		

		public new  void Select()
		{

            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }


			if(EstimateBuilder.ApplicationBuilder.takeOffId !="All")
			{this.load(EstimateBuilder.ApplicationBuilder.takeOffId);}
			else
			{this.load();}
			if(EstimateBuilder.ApplicationBuilder.OpenTakeOffMode != OpenTakeOff.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenTakeOffMode = OpenTakeOff.On;
				this.Show();
			}

		}


        public void loadJob(string _id)
        {
            base.load();
            takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectJob(_id);
            
            this.SetDataBinding(takeOff);
            if (EstimateBuilder.ApplicationBuilder.OpenTakeOffJobMode != OpenTakeOffJob.On)
            {
                EstimateBuilder.ApplicationBuilder.OpenTakeOffJobMode = OpenTakeOffJob.On;
                this.Show();
            }
            this.BringToFront();

        }


        public void loadGroup(string _id, string _jobId, string _division)
        {
            base.load();
            takeOff = EstimateBuilder.ApplicationBuilder.TakeOffDataSource.selectGroup(_id, _jobId, _division);

            this.SetDataBinding(takeOff);
            if (EstimateBuilder.ApplicationBuilder.OpenTakeOffJobMode != OpenTakeOffJob.On)
            {
                EstimateBuilder.ApplicationBuilder.OpenTakeOffJobMode = OpenTakeOffJob.On;
                this.Show();
            }
            this.BringToFront();

        }
        
        public override void load(string _id)
		{
            base.load();
            takeOff =  EstimateBuilder.ApplicationBuilder.TakeOffDataSource.select(_id);
			this.SetDataBinding(takeOff);
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

                this.GridEX.DropDowns["dlBuildingType"].SetDataBinding(list.UserValidationBuildingType(), "");
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
                this.GridEX.DropDowns["dlMethod"].SetDataBinding(list.UserValidationMethod(), "");
            }
            catch { }


            try
            {
                this.GridEX.DropDowns["dlInput"].SetDataBinding(list.UserValidationInput(), "");
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
			EstimateBuilder.TakeOff TakeOffDialog = new EstimateBuilder.TakeOff();
			TakeOffDialog.CreateNewTakeOff(this);
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


            int j = this.GridEX.RecordCount;
            for (int i = 0; i < j; i++)
            {

                if (this.GridEX.GetRow(i).Cells["ActiveJob"].Value == null)
                {
                    j = j + 1;
                }
                else
                {
                    if ((bool)this.GridEX.GetRow(i).Cells["ActiveJob"].Value == true)
                    {  //this.GridEX.Delete(); 
                       
                            EstimateBuilder.TakeOffDataProvider TakeOff = new EstimateBuilder.TakeOffDataProvider();
                            this.takeOff.Remove((EstimateBuilder.TakeOffData)this.GridEX.GetRow(i).DataRow);
                            EstimateBuilder.ApplicationBuilder.TakeOffDataSource.delete((EstimateBuilder.TakeOffData)this.GridEX.GetRow(i).DataRow);
                            _DivisionDataProvider.selectTakeOff(EstimateBuilder.Builder.lstTakeOffDivision);
                       
                    }
                }
            }


                   this.GridEX.DataSource = this.takeOff.Clone();
                   this.GridEX.Refetch();
                   break;

               case DialogResult.No:
                   break;
               case DialogResult.Cancel:
                   break;
           }
       }

        public override void ShowSaveDialog()
        {
            EstimateBuilder.frmSaveTakeOff _saveTakeOff = new frmSaveTakeOff();
     
            _saveTakeOff.ShowDialog(this.ParentForm, this, null);
            base.ShowSaveDialog();

        }

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);


        }

        public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();

        void GridEX_CellValueChanged(object sender, ColumnActionEventArgs e)
        {

            this.GridEX.Update();

            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
           {
               string _check = this.GridEX.GetRow().Cells["Group"].Value.ToString();

               if ((_check == "True") && (EstimateBuilder.ApplicationBuilder.takeOffGroup != null))
                {
                    _checkGroup = true;
                    EstimateBuilder.ApplicationBuilder.TakeOffDataSource.addGroup((EstimateBuilder.TakeOffData)this.GridEX.GetRow().DataRow,EstimateBuilder.ApplicationBuilder.takeOffGroup);

                }
                else if ((_check == "False") && (EstimateBuilder.ApplicationBuilder.takeOffGroup != null))
                {
                    _checkGroup = true;
                    EstimateBuilder.ApplicationBuilder.TakeOffDataSource.deleteGroup((EstimateBuilder.TakeOffData)this.GridEX.GetRow().DataRow, EstimateBuilder.ApplicationBuilder.takeOffGroup);

                }
            }
        }



        public override bool SaveData()
        {
            base.SaveData();
            EstimateBuilder.TakeOffDataProvider TakeOff = new EstimateBuilder.TakeOffDataProvider();
            EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
            int j = this.GridEX.RecordCount;
            for (int i = 0; i < j; i++)
            {

                if (this.GridEX.GetRow(i).Cells["ActiveJob"].Value == null)
                {
                    j = j + 1;
                }
                else
                {
                    if (EstimateBuilder.frmSaveTakeOff.progressBarSaveJob is System.Windows.Forms.ProgressBar)
                    {
                        EstimateBuilder.frmSaveTakeOff.progressBarSaveJob.Increment(5);
                    }

                    if (((((bool)this.GridEX.GetRow(i).Cells["ActiveJob"].Value == true)) && (EstimateBuilder.ApplicationBuilder.SaveJobId != null))
                     || (EstimateBuilder.ApplicationBuilder.takeOffJobId != null))
                    {
                        if ((EstimateBuilder.ApplicationBuilder.takeOffJobId != null)&&(EstimateBuilder.ApplicationBuilder.SaveJobId ==null))
                        {

                            int k = EstimateBuilder.ApplicationBuilder.takeOffJobId.IndexOf("-");
                            if (k > 0)
                            { EstimateBuilder.ApplicationBuilder.SaveJobId = EstimateBuilder.ApplicationBuilder.takeOffJobId.Substring(0, k); }


                        }
                        try
                        {
                            EstimateBuilder.ApplicationBuilder.TakeOffDataSource.add((EstimateBuilder.TakeOffData)this.GridEX.GetRow(i).DataRow, EstimateBuilder.ApplicationBuilder.SaveJobId);

                        }
                        catch
                        {
                            EstimateBuilder.ApplicationBuilder.TakeOffDataSource.update((EstimateBuilder.TakeOffData)this.GridEX.GetRow(i).DataRow);

                        }
                        _DivisionDataProvider.selectTakeOff(EstimateBuilder.Builder.lstTakeOffDivision);
                    }
                }
            }
            _DivisionDataProvider.selectTakeOff(EstimateBuilder.Builder.lstTakeOffDivision);
                    return true;
                }
               


        public override void Edit() 
		{ 
			Janus.Windows.GridEX.GridEXSelectedItem item = null; 
			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 
					EstimateBuilder.TakeOff reportDialog = new EstimateBuilder.TakeOff(); 
					reportDialog.Edit(  (EstimateBuilder.TakeOffData) item.GetRow().DataRow,   this); 
				} 
			}
		}



		protected EstimateBuilder.TakeOffDatas _TakeOffData;

        public void addItem(ArrayList _importedData)
        {
            	//Creating the collection
            _TakeOffData = new EstimateBuilder.TakeOffDatas();

            int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                EstimateBuilder.TakeOffDataProvider TakeOff = new EstimateBuilder.TakeOffDataProvider();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						decimal i9;
                        bool i10;

                        try{i9 = Convert.ToDecimal(i[9]);}
						catch{  i9=0;}
								
						try{i10 = Convert.ToBoolean(i[10]);}
						catch{ i10=false;}

						try
						{
							_TakeOffData.Add(new TakeOffData(false,i[0],i[1],i[2],i[3],i[4],i[5],i[6],i[7],i[8],i9,i10,false,"",0,0,0,"",0));
                            TakeOff.add(new TakeOffData(false, i[0], i[1], i[2], i[3], i[4], i[5], i[6], i[7], i[8], i9, i10, false, "", 0, 0, 0, "", 0));
						
                        }
						catch{}
                    count++;
				
			}
		
	
			this.GridEX.SetDataBinding(_TakeOffData,"");
			this.GridEX.RetrieveStructure();
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Insert;
		}

        public override void InsertData()
        {
            try{
            EstimateBuilder.TakeOffDataProvider TakeOff = new EstimateBuilder.TakeOffDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                TakeOff.Copy((EstimateBuilder.TakeOffData)this.GridEX.GetRow().DataRow,0);
            }
            this.Refresh();
                     }
            catch { }

        }

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 
		
			EstimateBuilder.ApplicationBuilder.OpenTakeOffMode = OpenTakeOff.Off;
            EstimateBuilder.ApplicationBuilder.takeOffJobId = null;

       
            EstimateBuilder.ApplicationBuilder.XTakeoff = this.ClientSize.Width;
            EstimateBuilder.ApplicationBuilder.YTakeoff = this.ClientSize.Height;


            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                EstimateBuilder.TakeOffDataProvider TakeOff = new EstimateBuilder.TakeOffDataProvider();

                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    TakeOff.add((EstimateBuilder.TakeOffData)this.GridEX.GetRow(i).DataRow);

                }

            }

        }

	}
}
