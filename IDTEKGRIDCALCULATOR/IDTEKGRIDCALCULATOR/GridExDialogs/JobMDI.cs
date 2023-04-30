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
	/// Summary description for EstimateMDI.
	/// </summary>
	public class JobMDI : IDIGITALTEKGRID.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public JobMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}
        public override void Refresh()
        {
            this.job = new JobDatas();

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.jobId;

            if (IDIGITALTEKGRID.ApplicationBuilder.jobId != "All")
            { this.job = IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.jobId); }
            else
            { this.job = IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.select(); }

           this.GridEX.DataSource = this.job.Clone();
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
            if (IDIGITALTEKGRID.ApplicationBuilder.jobId != "All")
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.jobId); }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.selectData(); }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobMDI));
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
            this.GridEX.Size = new System.Drawing.Size(788, 274);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(788, 56);
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
            this.lbHeader.Location = new System.Drawing.Point(64, 36);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 7;
            // 
            // JobMDI
            // 
            this.ClientSize = new System.Drawing.Size(788, 330);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "JobMDI";
            this.Text = "Job";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		private IDIGITALTEKGRID.JobDatas job;
        private Label lbHeader;
		public IDIGITALTEKGRID.JobDataProvider DataSource;
		public override void load()
		{
            base.load();



            job =  IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.select();
			this.SetDataBinding(job);
            this.BringToFront();
        }
		public void createJobMDI(string _id)
		{
			IDIGITALTEKGRID.ApplicationBuilder.jobId = _id;

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.jobId;

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

			if(IDIGITALTEKGRID.ApplicationBuilder.jobId !="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.jobId);}
			else
			{this.load();}		
			if(IDIGITALTEKGRID.ApplicationBuilder.OpenJobMode != OpenJob.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenJobMode = OpenJob.On;
				this.Show();
			}
			
		}

		public override void load(string _id)
		{
            base.load();
            job =  IDIGITALTEKGRID.ApplicationBuilder.JobDataSource.select(_id);
			this.SetDataBinding(job);
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
                this.GridEX.DropDowns["dlProjectName"].SetDataBinding(list.ProjectIDName(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlJob"].SetDataBinding(list.ContactJobIDJob(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlOwner"].SetDataBinding(list.ContactIDOwner(), "");

            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlBuildingType"].SetDataBinding(list.UserValidationBuildingType(), "");
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
			IDIGITALTEKGRID.Job EstimateDialog = new IDIGITALTEKGRID.Job();
			EstimateDialog.CreateNewJob(this);
		}


        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();

        public override bool SaveData()
        {
            base.SaveData();
            IDIGITALTEKGRID.JobDataProvider Job = new IDIGITALTEKGRID.JobDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                Job.update((IDIGITALTEKGRID.JobData)this.GridEX.GetRow().DataRow);
            }

             _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstQuantityJob);
            _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstTakeOffJob);
            _DivisionDataProvider.selectJob(IDIGITALTEKGRID.Builder.lstJobDivision);
            _DivisionDataProvider.selectEstimateProject(IDIGITALTEKGRID.Builder.lstEstimateProject, "all");

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
                            IDIGITALTEKGRID.JobDataProvider Job = new IDIGITALTEKGRID.JobDataProvider();
                            this.job.Remove((IDIGITALTEKGRID.JobData)item.GetRow().DataRow);
                            Job.delete((IDIGITALTEKGRID.JobData)item.GetRow().DataRow);
                       

                            _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstQuantityJob);
                            _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstTakeOffJob);
                            _DivisionDataProvider.selectJob(IDIGITALTEKGRID.Builder.lstJobDivision);

                        }
                    }
                    this.GridEX.DataSource = this.job.Clone();
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
					IDIGITALTEKGRID.Job jobDialog = new IDIGITALTEKGRID.Job(); 
					jobDialog.Edit(  (IDIGITALTEKGRID.JobData) item.GetRow().DataRow,   this); 
				} 
			}
		}

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }
        
        
        protected 	IDIGITALTEKGRID.JobDatas _jobData ;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
		    _jobData = new IDIGITALTEKGRID.JobDatas();

			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                IDIGITALTEKGRID.JobDataProvider Job = new IDIGITALTEKGRID.JobDataProvider();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
                        int i0,i1,i2 ;
                        System.DateTime i4, i5;

                        try { i0 = Convert.ToInt32(i[0]); }
                        catch { i0 = 0; }
                        try { i1 = Convert.ToInt32(i[1]); }
                        catch { i1 = 0; }
                        try { i2 = Convert.ToInt32(i[2]); }
                        catch { i2 = 0; }

                        try { i4 = Convert.ToDateTime(i[9]); }
                        catch { i4 = System.DateTime.Now; }
                        try { i5 = Convert.ToDateTime(i[9]); }
                        catch { i5 = System.DateTime.Now; }



                        try{
								
							_jobData.Add(new JobData(i0 ,i1,i2,i[3],i4,i5,i[6],"",0,0));
                             Job.add( new JobData(i0, i1, i2, i[3], i4, i5, i[6], "", 0, 0));
						}
						catch{}
                        count++;
                    }
			
			this.GridEX.SetDataBinding(_jobData,"");
			this.GridEX.RetrieveStructure();

		}

        public override void InsertData()
        {
            try{
            IDIGITALTEKGRID.JobDataProvider Job = new IDIGITALTEKGRID.JobDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                Job.Copy((IDIGITALTEKGRID.JobData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                     }
            catch { }
        }


		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 
			IDIGITALTEKGRID.ApplicationBuilder.OpenJobMode = OpenJob.Off;

            IDIGITALTEKGRID.ApplicationBuilder.XJob = this.ClientSize.Width;
            IDIGITALTEKGRID.ApplicationBuilder.YJob = this.ClientSize.Height;
      
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                IDIGITALTEKGRID.JobDataProvider Job = new IDIGITALTEKGRID.JobDataProvider();

                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    Job.add((IDIGITALTEKGRID.JobData)this.GridEX.GetRow(i).DataRow);

                }

            }

        }

	}
}
