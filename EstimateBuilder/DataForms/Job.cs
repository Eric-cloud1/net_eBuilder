using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for Estimate.
	/// </summary>
	public class Job :  EstimateBuilder.DataForm
	{
        private EstimateBuilderControl.Job job1;

        private System.ComponentModel.IContainer components = null;

		public Job()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job));
            this.job1 = new EstimateBuilderControl.Job();
            this.SuspendLayout();
// 
// job1
// 
            this.job1.Location = new System.Drawing.Point(-2, 13);
            this.job1.Name = "job1";
            this.job1.Size = new System.Drawing.Size(575, 345);
            this.job1.TabIndex = 0;
// 
// Job
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.job1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Job";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.job1, 0);
            this.ResumeLayout(false);

        }
		#endregion

	
		public  EstimateBuilder.JobMDI  job = new EstimateBuilder.JobMDI();

        protected EstimateBuilder.JobData FormJob = new JobData();

        public void CreateJob()
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.job1.Job_Load();
            this.Show();
		}

		public void CreateNewJob( EstimateBuilder.JobMDI  _job)
		{

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.job = _job;
            this.job1.Job_Load();
            this.Show();
		}

		public void CreateJob( EstimateBuilder.JobMDI  _job)
		{

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.job = _job;
            this.job1.Job_Load();
            this.Show();
		}

     

        public void Edit( EstimateBuilder.JobData  _formJob,  EstimateBuilder.JobMDI  _job ) 
		{
            this.job1.Job_Load();

            this.job1.txtJobID.Text = _formJob.JobID.ToString();

            this.job1.txtDescription.Text = _formJob.Description;
           
     
            this.job1.txtLocationZip.Text = _formJob.LocationZip;

        
            this.job1.dlProjectName.SelectedValue = _formJob.ProjectContactID;
            this.job1.dlOwnerID.SelectedValue = _formJob.OwnerID.ToString();
            this.job1.dlJobIDJob.SelectedValue = _formJob.JobContactID.ToString();


            this.job1.dlBuildingType.Text = _formJob.BuildingType;
           


            this.job1.txtStartDate.Text = _formJob.StartDate.ToString();
            this.job1.txtFinishDate.Text = _formJob.FinishDate.ToString();
          
            

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.job = _job;
			
			this.Show(); 
		}
	
		public override void InsertData() 
		{
            try
            {
                FormJob.JobID = Convert.ToInt32(this.job1.txtJobID.Text);
            }
            catch{}

            try
            {
                FormJob.FinishDate = Convert.ToDateTime(this.job1.txtFinishDate.Text);
            }
            catch { }
           

            if (Convert.ToDateTime(this.job1.txtStartDate.Text) is DateTime)
            {
                FormJob.StartDate = Convert.ToDateTime(this.job1.txtStartDate.Text);
            }




            if (this.job1.dlOwnerID.SelectedIndex != -1)
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.SelectedValue.ToString());
            }
            else
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.Text);
            }

            if (this.job1.dlJobIDJob.SelectedIndex != -1)
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.SelectedValue.ToString());
            }
            else
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.Text);
            }



            if (this.job1.dlProjectName.SelectedIndex != -1)
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.SelectedValue.ToString());
            }
            else
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.Text);
            }


            if (this.job1.dlBuildingType.SelectedIndex != -1)
            {
                FormJob.BuildingType = this.job1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormJob.BuildingType = this.job1.dlBuildingType.Text;
            }


          

            FormJob.Description = this.job1.txtDescription.Text;
            FormJob.LocationZip = this.job1.txtLocationZip.Text;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

            EstimateBuilder.ApplicationBuilder.JobDataSource.add(FormJob);


        } 

		public override void UpdateData() 
		{
            try
            {
                FormJob.JobID = Convert.ToInt32(this.job1.txtJobID.Text);
            }
            catch{}

            try
            {
                FormJob.FinishDate = Convert.ToDateTime(this.job1.txtFinishDate.Text);
            }
            catch { }

            if (Convert.ToDateTime(this.job1.txtStartDate.Text) is DateTime)
            {
                FormJob.StartDate = Convert.ToDateTime(this.job1.txtStartDate.Text);
            }


            if (this.job1.dlOwnerID.SelectedIndex != -1)
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.SelectedValue.ToString());
            }
            else
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.Text);
            }

            if (this.job1.dlJobIDJob.SelectedIndex != -1)
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.SelectedValue.ToString());
            }
            else
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.Text);
            }



            if (this.job1.dlProjectName.SelectedIndex != -1)
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.SelectedValue.ToString());
            }
            else
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.Text);
            }


            if (this.job1.dlBuildingType.SelectedIndex != -1)
            {
                FormJob.BuildingType = this.job1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormJob.BuildingType = this.job1.dlBuildingType.Text;
            }


          



            FormJob.Description = this.job1.txtDescription.Text;
            FormJob.LocationZip = this.job1.txtLocationZip.Text;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;

            EstimateBuilder.ApplicationBuilder.JobDataSource.update(FormJob);


        } 
 		public override void CancelData() 
		{ 	
			this.job1.txtDescription.Text = "";
            this.job1.txtFinishDate.Text = "";
            this.job1.txtStartDate.Text = "";
            this.job1.txtLocationZip.Text = "";
            this.job1.dlOwnerID.SelectedText = "";
            this.job1.dlProjectName.Text = "";
            this.job1.dlBuildingType.Text = "";
            this.job1.dlJobIDJob.Text = "";
            

        } 
		public override void DeleteData() 
		{

            try
            {
                FormJob.JobID = Convert.ToInt32(this.job1.txtJobID.Text);
            }
            catch { }

            try
            {
                FormJob.FinishDate = Convert.ToDateTime(this.job1.txtFinishDate.Text);
            }
            catch { }

            if (Convert.ToDateTime(this.job1.txtStartDate.Text) is DateTime)
            {
                FormJob.StartDate = Convert.ToDateTime(this.job1.txtStartDate.Text);
            }




            if (this.job1.dlOwnerID.SelectedIndex != -1)
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.SelectedValue.ToString());
            }
            else
            {
                FormJob.OwnerID = Convert.ToInt32(this.job1.dlOwnerID.Text);
            }

            if (this.job1.dlJobIDJob.SelectedIndex != -1)
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.SelectedValue.ToString());
            }
            else
            {
                FormJob.JobContactID = Convert.ToInt32(this.job1.dlJobIDJob.Text);
            }



            if (this.job1.dlProjectName.SelectedIndex != -1)
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.SelectedValue.ToString());
            }
            else
            {
                FormJob.ProjectContactID = Convert.ToInt32(this.job1.dlProjectName.Text);
            }


            if (this.job1.dlBuildingType.SelectedIndex != -1)
            {
                FormJob.BuildingType = this.job1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormJob.BuildingType = this.job1.dlBuildingType.Text;
            }


         
            FormJob.Description = this.job1.txtDescription.Text;
            FormJob.LocationZip = this.job1.txtLocationZip.Text;

            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Delete;
            EstimateBuilder.ApplicationBuilder.JobDataSource.delete(FormJob);

        } 
		public override bool ValidateData() 
		{ 


			bool valide = true;

            if (this.job1.txtStartDate.Text.Length == 0) valide = false;
            if (this.job1.txtLocationZip.Text.Length == 0) valide = false;
            if (this.job1.dlOwnerID.Text.Length == 0) valide = false;
            if (this.job1.dlProjectName.Text.Length == 0) valide = false;
            if (this.job1.dlJobIDJob.Text.Length == 0) valide = false;
            if (this.job1.dlBuildingType.Text.Length == 0) valide = false;

           
            return valide;  
		}	
	
	

		public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.job.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
                this.job.MdiParent.Refresh();
            }
            catch { }

            


            _DivisionDataProvider.selectTakeOffJob(EstimateBuilder.Builder.lstQuantityJob);
            _DivisionDataProvider.selectTakeOffJob(EstimateBuilder.Builder.lstTakeOffJob);
            _DivisionDataProvider.selectJob(EstimateBuilder.Builder.lstJobDivision);
            _DivisionDataProvider.selectEstimateProject(EstimateBuilder.Builder.lstEstimateProject, "all");
      
        } 


	}
}
