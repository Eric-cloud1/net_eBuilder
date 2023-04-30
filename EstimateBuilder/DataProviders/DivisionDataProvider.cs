using System;
using System.Collections;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for DivisionDataProvider.
	/// </summary>
	public class DivisionDataProvider
	{
		public DivisionDataProvider()
		{
		}

     

        
        public  void  selectAssembly(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT DISTINCT Division  ");
			strSQL.Append(" FROM ASSEMBLY" );

			
            _list.Items.Add("All");

            try{
			DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
		
				foreach(DataRow row in dsData.Tables[0].Rows)
				{			
					_list.Items.Add(row[0].ToString() );
				}

			}
			catch{}

		}

		
		public void selectContact(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
            strSQL.Append("SELECT DISTINCT Division_Contact ");
            strSQL.Append(" FROM Contact" );
			
            _list.Items.Add("All");

            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString()) ;
					}

			}
			catch{}
		}


		public void selectCostAmount(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
            strSQL.Append("SELECT  DISTINCT BuildingType_costAmt  ");
            strSQL.Append(" FROM CostAmount" );
			
            
            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);

				foreach(DataRow row in dsData.Tables[0].Rows)
				{_list.Items.Add(row[0].ToString() );
				}
			}
			catch{}
		}

		
		public  void  selectCostItem(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT DISTINCT CostType  ");
			strSQL.Append(" FROM CostItem" );

            _list.Items.Add("All");

            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
	
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString() );
					}

			}
			catch{}
		}


		public  void  selectJob(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();

			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT  DISTINCT BuildingType  ");
            strSQL.Append(" FROM Job");
            _list.Items.Add("All");
 
			try{
				   DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
	
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString() );
					}

			}	
			catch{}
		}


		public  void selectExpression(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();

			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT DISTINCT Division  ");
			strSQL.Append(" FROM Expression" );
			
            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString());
					}

			} 
			catch{}
		}


		public  void selectQuantity(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();



            strSQL.Append("SELECT  DISTINCT [JobID]&'-'&[Description] AS Project  ");
            strSQL.Append(" FROM Job");

    
            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
		
				foreach(DataRow row in dsData.Tables[0].Rows)
				{_list.Items.Add(row[0].ToString() );
				}

			}
			catch{}
		}

        public void selectEstimateBuildingType(System.Windows.Forms.ListView _list)
        {
            _list.Items.Clear();

            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT DISTINCT BuildingType  ");
            strSQL.Append(" FROM Job ");

            _list.Items.Add("All");
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString());
                }

            }
            catch { }
        }

        
        public  void selectEstimateProject(System.Windows.Forms.ListView _list, string _BuildingType)
		{
			_list.Items.Clear();

			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT DISTINCT Job.ProjectName &'-'& Contact.Company ");
            strSQL.Append(" FROM Contact INNER JOIN Job ON Contact.ContactID = Job.ProjectName ");
            if (_BuildingType != "All")
            {
                strSQL.Append(" WHERE Job.BuildingType ='" + _BuildingType + "'");
            }

            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
		
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString() );
					}

			}
			catch{}
		}


		public  void selectTakeOff(System.Windows.Forms.ListView _list)
		{

			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT DISTINCT BuildingType_takeoff FROM Takeoff ");

            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
		
				foreach(DataRow row in dsData.Tables[0].Rows)
				{_list.Items.Add(row[0].ToString() );
				}

			}
			catch{}
		}


        public void selectQuantityDivision(System.Windows.Forms.ListView _list)
        {

            _list.Items.Clear();
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append("SELECT DISTINCT  Division_Quantity FROM Quantity  ");


            _list.Items.Add("All");
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString());
                }

            }
            catch { }
        }

        public void selectTakeOffJob(System.Windows.Forms.ListView _list)
        {

            _list.Items.Clear();
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append("SELECT DISTINCT Job.JobID &'-'& Contact.Company AS Job  ");
            strSQL.Append(" FROM Contact INNER JOIN Job ON Contact.ContactID = Job.ContactID_Job");

            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString());
                }

            }
            catch { }
        }

        
        public void selectValidationSystem(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT  DISTINCT Type  ");
			strSQL.Append(" FROM ValidationSystem" );

            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
					foreach(DataRow row in dsData.Tables[0].Rows)
					{_list.Items.Add(row[0].ToString() );
					}

			}
			catch{}
		}

	
		public  void selectValidationUser(System.Windows.Forms.ListView _list)
		{
			_list.Items.Clear();
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT  DISTINCT [Group] ");
            strSQL.Append(" FROM ValidationUser WHERE [Group] <> 'View'");
			
            _list.Items.Add("All");
            try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
					foreach(DataRow row in dsData.Tables[0].Rows)
					{
						_list.Items.Add(row[0].ToString() );
					}

			}
			catch{}
		}


        public void selectValidationTakeoff(System.Windows.Forms.ListView _list)
        {
            _list.Items.Clear();
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT  DISTINCT [Description] ");
            strSQL.Append(" FROM ValidationUser WHERE [Group] = 'Takeoff'");

            _list.Items.Add("All");
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString());
                }

            }
            catch { }
        }
	

		public void Dispose()
		{
			GC.Collect();
		}
	}


}
