using System.Text;
using System;
using System.Collections;
using System.ComponentModel;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for EstimateData.
	/// </summary>
	public class JobData
	{
		
		public JobData():this( 0,0,0,null,System.DateTime.Now,System.DateTime.Now,null,null,0,0)
		{
		}
		
		public JobData
			(
                int _JobContactID,
                int _ProjectContactID ,
                int _OwnerID,
                string _LocationZip,
                System.DateTime _StartDate,
                System.DateTime _FinishDate,
                string _BuildingType, 
                string _Description,
                int _jobID,
                int _NumbID
			)
				{
			    this.JobContactID =  _JobContactID;
                this.ProjectContactID =  _ProjectContactID ;
                this.OwnerID =  _OwnerID;
                this.LocationZip =  _LocationZip;
                this.StartDate =  _StartDate;
                this.FinishDate =  _FinishDate;
                this.BuildingType =  _BuildingType; 
                this.Description =  _Description;
                this.JobID = _jobID;
                this.NumbID = _NumbID;
            }


        public event EventHandler NumbIDChanged;
        public int _NumbID;
        public int NumbID
        {
            get { return _NumbID; }
            set
            {
                _NumbID = value;
                if (NumbIDChanged != null) NumbIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler JobIDChanged;
		public int _JobID;
		public int JobID
		{
			get { return _JobID; }set 
			{
				_JobID= value; 
				if(JobIDChanged != null) JobIDChanged(this,EventArgs.Empty);
			}
		}

        public event EventHandler JobContactIDChanged;
        public int _JobContactID;
        public int JobContactID
        {
            get { return _JobContactID; }
            set
            {
                _JobContactID = value;
                if (JobContactIDChanged != null) JobContactIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler StartDateChanged;
		public System.DateTime _StartDate;
		public System.DateTime StartDate
		{
			get { return _StartDate; }set 
										{
											_StartDate= value; 
											if(StartDateChanged != null) StartDateChanged(this,EventArgs.Empty);
										}
		}


		public event EventHandler ProjectContactIDChanged;
		public int _ProjectContactID;
		public int ProjectContactID
		{
			get { return _ProjectContactID; }set 
			 {
				 _ProjectContactID = value; 
				  if(ProjectContactIDChanged != null) ProjectContactIDChanged(this,EventArgs.Empty);
			 }
		}


		public event EventHandler OwnerIDChanged;
		public int _OwnerID;
		public int OwnerID
		{
			get { return _OwnerID; }set 
										{
											_OwnerID = value; 
											if(OwnerIDChanged != null) OwnerIDChanged(this,EventArgs.Empty);
										}
		}


		public event EventHandler LocationZipChanged;
		public string _LocationZip;
		public string LocationZip
		{
			get { return _LocationZip; }set 
											   {
												   _LocationZip = value; 
												   if(LocationZipChanged != null) LocationZipChanged(this,EventArgs.Empty);
											   }
		}


		



        public event EventHandler BuildingTypeChanged;
        public string _BuildingType;
        public string BuildingType
        {
            get { return _BuildingType; }
            set
            {
                _BuildingType = value;
                if (BuildingTypeChanged != null) BuildingTypeChanged(this, EventArgs.Empty);
            }
		}


	



		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description
		{
			get { return _Description; }set 
			{
				 _Description = value; 
					if(DescriptionChanged != null) DescriptionChanged(this,EventArgs.Empty);
			 }
		}


		public event EventHandler FinishDateChanged;
		public System.DateTime _FinishDate;
		public System.DateTime FinishDate
		{
			get { return _FinishDate; }set 
			{
				_FinishDate = value; 
					if(FinishDateChanged != null) FinishDateChanged(this,EventArgs.Empty);
			}
		}
	}



    public class JobDatas : ArrayList
    {
        public enum ItemsFields
        {
             JobContactID,
             ProjectContactID ,
             OwnerID,
             LocationZip,
             StartDate,
             FinishDate,
             BuildingType, 
             Description,
             jobID,
             NumbID
        }
    }
}