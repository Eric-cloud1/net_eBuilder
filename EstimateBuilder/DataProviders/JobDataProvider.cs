using System;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for EstimateDataProvider.
	/// </summary>
	public class JobDataProvider
	{
		public JobDataProvider()
		{

		}



		public void add(EstimateBuilder.JobData  _jobData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" INSERT INTO Job (Description,");
			strSQL.Append(" ProjectName, BuildingType, OwnerID, ");
			strSQL.Append("StartDate, FinishDate, ");
            strSQL.Append("LocationZip, ContactID_Job) VALUES (");
            strSQL.Append("'" + _jobData.Description + "',");
            strSQL.Append( _jobData.ProjectContactID + ",");
            strSQL.Append("'" + _jobData.BuildingType + "',");
            strSQL.Append(  _jobData.OwnerID + ",");
            strSQL.Append("'" + _jobData.StartDate + "',");
            strSQL.Append("'" + _jobData.FinishDate + "',");
            strSQL.Append("'" + _jobData.LocationZip + "',");
            strSQL.Append( _jobData.JobContactID + ")");
   
            try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


        public void Copy(EstimateBuilder.JobData _jobData)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" INSERT INTO Job (Description,");
            strSQL.Append(" ProjectName, BuildingType, OwnerID, ");
            strSQL.Append("StartDate, FinishDate, ");
            strSQL.Append("LocationZip, ContactID_Job) VALUES (");
            strSQL.Append("'Copy " + _jobData.Description + "',");
            strSQL.Append(_jobData.ProjectContactID + ",");
            strSQL.Append("'" + _jobData.BuildingType + "',");
            strSQL.Append(_jobData.OwnerID + ",");
            strSQL.Append("'" + _jobData.StartDate + "',");
            strSQL.Append("'" + _jobData.FinishDate + "',");
            strSQL.Append("'" + _jobData.LocationZip + "',");
            strSQL.Append(_jobData.JobContactID + ")");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            }
            catch { }
        }
		public void update(EstimateBuilder.JobData  _JobData)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();



			strSQL.Append("UPDATE Job SET ");
            strSQL.Append("OwnerID = " + _JobData.OwnerID + ",");
            strSQL.Append("Description = '" + _JobData.Description + "',");
        
            strSQL.Append("ProjectName = " + _JobData.ProjectContactID+ ",");
            strSQL.Append("BuildingType = '" + _JobData.BuildingType + "',");
            strSQL.Append("StartDate = '" + _JobData.StartDate + "',");
            strSQL.Append("FinishDate = '" + _JobData.FinishDate + "',");
            strSQL.Append("LocationZip = '" + _JobData.LocationZip + "',");
            strSQL.Append("ContactID_Job= " + _JobData.JobContactID);


            strSQL.Append(" WHERE JobID =" + _JobData.JobID);
            try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}

		public void delete(EstimateBuilder.JobData  _jobData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append(" DELETE * FROM Job WHERE JobID ="+ _jobData.JobID);

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
		}
        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append(" SELECT JobID, StartDate, FinishDate, Description,  ");
            strSQL.Append("  ProjectName, OwnerID, LocationZip, BuildingType, ContactID_Job ");
            strSQL.Append(" FROM Job WHERE BuildingType ='" + _id + "'");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;

        }

        public  EstimateBuilder.JobDatas select(string _id)
		{
            DataSet dsData = this.selectData(_id);
            EstimateBuilder.JobDatas _jobDatas = new EstimateBuilder.JobDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.JobData  jobData = new EstimateBuilder.JobData();

                i += 1;
                jobData.NumbID = i;
                jobData.JobID = Convert.ToInt32(row["JobID"].ToString());
                jobData.Description = row["Description"].ToString();
                jobData.LocationZip = row["LocationZip"].ToString();
                jobData.OwnerID = Convert.ToInt32(row["OwnerID"].ToString());
                jobData.ProjectContactID = Convert.ToInt32(row["ProjectName"].ToString());
                jobData.JobContactID = Convert.ToInt32(row["ContactID_Job"].ToString());
                jobData.BuildingType = row["BuildingType"].ToString();

                try
				{
                    jobData.StartDate = Convert.ToDateTime(row["StartDate"].ToString());
                }
				catch
				{
                    jobData.StartDate = System.DateTime.Now;
                }
				try
				{
                    jobData.FinishDate = Convert.ToDateTime(row["FinishDate"].ToString());
                }
				catch
				{
                    jobData.FinishDate = System.DateTime.Now;
                }
                _jobDatas.Add(jobData);
            }
            return _jobDatas;
        }

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT JobID, StartDate, FinishDate, Description,  ");
            strSQL.Append("  ProjectName, OwnerID, LocationZip, BuildingType, ContactID_Job ");
            strSQL.Append(" FROM Job ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }
        public EstimateBuilder.JobDatas select()
		{
            DataSet dsData = this.selectData();

            EstimateBuilder.JobDatas _jobDatas = new EstimateBuilder.JobDatas();
            int i = 0;
            foreach (DataRow row in dsData.Tables[0].Rows)
            {
                EstimateBuilder.JobData jobData = new EstimateBuilder.JobData();

                i += 1;
                jobData.NumbID = i;
                jobData.JobID = Convert.ToInt32(row["JobID"].ToString());
                jobData.Description = row["Description"].ToString();
                jobData.LocationZip = row["LocationZip"].ToString();
                jobData.OwnerID = Convert.ToInt32(row["OwnerID"].ToString());
                jobData.ProjectContactID = Convert.ToInt32(row["ProjectName"].ToString());
                jobData.JobContactID = Convert.ToInt32(row["ContactID_Job"].ToString());
                jobData.BuildingType = row["BuildingType"].ToString();

                try
                {
                    jobData.StartDate = Convert.ToDateTime(row["StartDate"].ToString());
                }
                catch
                {
                    jobData.StartDate = System.DateTime.Now;
                }
                try
                {
                    jobData.FinishDate = Convert.ToDateTime(row["FinishDate"].ToString());
                }
                catch
                {
                    jobData.FinishDate = System.DateTime.Now;
                }
                _jobDatas.Add(jobData);
            }
            return _jobDatas;
        }

		public void Dispose()
		{
			GC.Collect();
		}

	}
}
