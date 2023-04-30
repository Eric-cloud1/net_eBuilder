using System;
using EstimateBuilder;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for TakeOffDataProvider.
	/// </summary>
	public class TakeOffDataProvider
	{
		public TakeOffDataProvider()
		{

		}

        public string connect = EstimateBuilder.ApplicationBuilder.connection;

        public void add(EstimateBuilder.TakeOffData  _takeOffData, string _JobID)
		{
            if (_takeOffData.TakeOffID == 0)
            {
                Random random = new Random();
                _takeOffData.TakeOffID = random.Next(999999);
                _JobID = "0";

            }

            _takeOffData.JobID = Convert.ToInt32(_JobID);
            _takeOffData.JobTakeOffID = _takeOffData.JobID + "-" + _takeOffData.TakeOffID;
            StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

            _takeOffData.JobTakeOffID = _takeOffData.JobID+"-"+_takeOffData.TakeOffID;
            _takeOffData.JobID = Convert.ToInt32(_JobID);

            strSQL.Append(" INSERT INTO Takeoff ( Method, [Input], ");
			strSQL.Append("  BuildingType_takeoff, Division_takeoff, ");
			strSQL.Append(" DivisionCost_takeoff, DivisionPrint_takeoff, Units, Location, ");
            strSQL.Append(" Description_takeoff, TakeoffValue, Active_takeoff, [Memo_takeoff],JobID, TakeOffID, JobTakeOffID  )");
            strSQL.Append(" VALUES ( '"+_takeOffData.Method +"','"+_takeOffData.Input+"','");

			strSQL.Append( _takeOffData.BuildingType + "','" +_takeOffData.Division + "','"  );
			strSQL.Append( _takeOffData.DivisionCost  + "','" +_takeOffData.DivisionPrint+ "','"  );
			strSQL.Append( _takeOffData.Units  + "','" +_takeOffData.Location+ "','"  );
			strSQL.Append( _takeOffData.Description  + "'," +_takeOffData.TakeOff + ","  );
			strSQL.Append( _takeOffData.Active  + ",'" +_takeOffData.Memo + "',"+_takeOffData.JobID+",");
            strSQL.Append(_takeOffData.TakeOffID + ",'" + _takeOffData.JobTakeOffID + "')");

         
           _data.ExecuteSQL(strSQL.ToString(), connect);
           

        }

        public void add(EstimateBuilder.TakeOffData _takeOffData)
        {

            if (_takeOffData.TakeOffID == 0)
            {
                Random random = new Random();
                _takeOffData.TakeOffID = random.Next(999999);
            }

            _takeOffData.JobID = 0;
            _takeOffData.JobTakeOffID = _takeOffData.JobID + "-" + _takeOffData.TakeOffID;

            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();
            strSQL.Append(" INSERT INTO Takeoff ( Method, [Input], ");
            strSQL.Append("  BuildingType_takeoff, Division_takeoff, ");
            strSQL.Append(" DivisionCost_takeoff, DivisionPrint_takeoff, Units, Location, ");
            strSQL.Append(" Description_takeoff, TakeoffValue, Active_takeoff, [Memo_takeoff],JobID, TakeOffID, JobTakeOffID  )");
            strSQL.Append(" VALUES ( '" + _takeOffData.Method + "','" + _takeOffData.Input + "','");

            strSQL.Append(_takeOffData.BuildingType + "','" + _takeOffData.Division + "','");
            strSQL.Append(_takeOffData.DivisionCost + "','" + _takeOffData.DivisionPrint + "','");
            strSQL.Append(_takeOffData.Units + "','" + _takeOffData.Location + "','");
            strSQL.Append(_takeOffData.Description + "'," + _takeOffData.TakeOff + ",");
            strSQL.Append(_takeOffData.Active + ",'" + _takeOffData.Memo + "'," + _takeOffData.JobID + ",");
            strSQL.Append(_takeOffData.TakeOffID + ",'" + _takeOffData.JobTakeOffID + "')");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), connect);
            }
            catch { }
        }


        public void Copy(EstimateBuilder.TakeOffData _takeOffData, int i)
        {

            if (i == 0)
            {
                Random random = new Random();
                _takeOffData.TakeOffID = random.Next(999999);
            }

            _takeOffData.JobID = 0;
            _takeOffData.JobTakeOffID = _takeOffData.JobID + "-" + _takeOffData.TakeOffID;

            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();
            strSQL.Append(" INSERT INTO Takeoff ( Method, [Input], ");
            strSQL.Append("  BuildingType_takeoff, Division_takeoff, ");
            strSQL.Append(" DivisionCost_takeoff, DivisionPrint_takeoff, Units, Location, ");
            strSQL.Append(" Description_takeoff, TakeoffValue, Active_takeoff, [Memo_takeoff],JobID, TakeOffID, JobTakeOffID  )");
            strSQL.Append(" VALUES ( '" + _takeOffData.Method + "','" + _takeOffData.Input + "','");

            strSQL.Append(_takeOffData.BuildingType + "','" + _takeOffData.Division + "','");
            strSQL.Append(_takeOffData.DivisionCost + "','" + _takeOffData.DivisionPrint + "','");
            strSQL.Append(_takeOffData.Units + "','" + _takeOffData.Location + "',' Copy ");
            strSQL.Append(_takeOffData.Description + "'," + _takeOffData.TakeOff + ",");
            strSQL.Append(_takeOffData.Active + ",'" + _takeOffData.Memo + "'," + _takeOffData.JobID + ",");
            strSQL.Append(_takeOffData.TakeOffID + ",'" + _takeOffData.JobTakeOffID + "')");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), connect);
            }
            catch { }
        }

        public void update(EstimateBuilder.TakeOffData _takeOffData)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

           // _takeOffData.JobID = 0;
            _takeOffData.JobTakeOffID = _takeOffData.JobID + "-" + _takeOffData.TakeOffID;
            strSQL.Append(" UPDATE Takeoff SET ");
            strSQL.Append(" Method = '" + _takeOffData.Method + "', [Input] = '" + _takeOffData.Input + "', ");
            strSQL.Append(" BuildingType_takeoff = '" + _takeOffData.BuildingType + "', Division_takeoff = '" + _takeOffData.Division + "',");
            strSQL.Append(" [DivisionCost_takeoff] = '" + _takeOffData.DivisionCost + "', [DivisionPrint_takeoff] = '" + _takeOffData.DivisionPrint + "', ");
            strSQL.Append(" Units =  '" + _takeOffData.Units + "', Location = '" + _takeOffData.Location + "', ");
            strSQL.Append(" Description_takeoff = '" + _takeOffData.Description + "', ");
            strSQL.Append(" TakeoffValue =  " + _takeOffData.TakeOff + ", ");
            strSQL.Append(" Active_takeoff =  " + _takeOffData.Active + ", [Memo_takeoff] =  '" + _takeOffData.Memo + "'");
            strSQL.Append(" WHERE  JobTakeOffID  = '" + _takeOffData.JobTakeOffID+"'");


            try
            {
                _data.ExecuteSQL(strSQL.ToString(), connect);
            }
            catch { }
        }

        public void delete(EstimateBuilder.TakeOffData  _takeOffData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append("DELETE * FROM  Takeoff WHERE TakeOffJobID ="+ _takeOffData.TakeOffJobID );

			_data.ExecuteSQL(strSQL.ToString(),connect);
		}

        public DataSet selectJobData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            int k = _id.IndexOf("-");
            if (k > 0)
            { _id = _id.Substring(0, k); }

            strSQL.Append(" SELECT [TakeOffJobID], [TakeOffID], [Method], [Input],   ");
            strSQL.Append(" [BuildingType_takeoff], [Division_takeoff],[DivisionCost_takeoff], [DivisionPrint_takeoff], ");
            strSQL.Append(" [Units], [Location],[Description_takeoff], [TakeoffValue], [Active_takeoff], [Memo_takeoff] ");
            strSQL.Append(" FROM Takeoff WHERE JobID =" + _id);



            DataSet dsData = _data.getDataSet(strSQL.ToString(), connect);
            return dsData;
        }


        public void deleteGroup(EstimateBuilder.TakeOffData _takeOffData, string _group)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();
            strSQL.Append("DELETE * FROM  TakeoffGroup WHERE TakeoffGroup.TakeOffID =" + _takeOffData.TakeOffID);
            strSQL.Append(" AND TakeoffGroup.GroupDescription ='" + _group +"'");

            _data.ExecuteSQL(strSQL.ToString(), connect);
        }


        public void addGroup(EstimateBuilder.TakeOffData _takeOffData, string _group)
        {

            if (_takeOffData.TakeOffID == 0)
            {
                Random random = new Random();
                _takeOffData.TakeOffID = random.Next(999999);
            }

            _takeOffData.JobID = 0;
            _takeOffData.TakeOffID = _takeOffData.TakeOffID;

            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();
            strSQL.Append(" INSERT INTO TakeoffGroup( TakeOffID, [GroupDescription]) ");

            strSQL.Append(" VALUES ( " + _takeOffData.TakeOffID + ",'" + _group + "')");

 

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), connect);
            }
            catch { }
        }


        public DataSet selectGroupData(string _id, string _jobid, string _division)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            try
            {
                int k = _jobid.IndexOf("-");
                if (k > 0)
                { _jobid = _jobid.Substring(0, k); }
            }
            catch { }

            strSQL.Append(" SELECT Takeoff.[TakeOffJobID], Takeoff.[Method], Takeoff.[Input], ");
            strSQL.Append(" Takeoff.[CustomerID], Takeoff.[BuildingType_takeoff], Takeoff.[Division_takeoff], ");
            strSQL.Append(" Takeoff.[DivisionCost_takeoff], Takeoff.[DivisionPrint_takeoff], Takeoff.[Units], ");
            strSQL.Append(" Takeoff.[Location], Takeoff.[Description_takeoff], Takeoff.[TakeoffValue], ");
            strSQL.Append(" Takeoff.[Active_takeoff], Takeoff.[Memo_takeoff], Takeoff.[JobID],  ");
            strSQL.Append(" Takeoff.[JobTakeOffID], Takeoff.[TakeOffID], TakeoffGroup.[GroupDescription] ");
            strSQL.Append(" FROM Takeoff LEFT JOIN TakeoffGroup ON Takeoff.[TakeOffID] = TakeoffGroup.[TakeOffID]");
            if (_jobid != null)
            {
                strSQL.Append("  WHERE Takeoff.[JobID] =" + _jobid);
            }
            if ((_division != null)&&(_division !="All"))
            {
                strSQL.Append("  WHERE Takeoff.[Division_takeoff] ='" + _division+"'");
            }




                DataSet dsData = _data.getDataSet(strSQL.ToString(), connect);
                return dsData;
         
            
        }


        public EstimateBuilder.TakeOffDatas selectGroup(string _id, string _jobId , string _division)
        {
            DataSet dsData = this.selectGroupData(_id, _jobId, _division);
            EstimateBuilder.TakeOffDatas _TakeOffDatas = new EstimateBuilder.TakeOffDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.TakeOffData  _takeOffData = new EstimateBuilder.TakeOffData();
                i += 1;
                _takeOffData.NumbID = i;

                if (row["GroupDescription"].ToString() == _id)
                {
                    _takeOffData.Group = true;
                }
                else
                {
                    _takeOffData.Group = false;
                }

                _takeOffData.TakeOffID = Convert.ToInt32(row["TakeOffID"].ToString());
                _takeOffData.TakeOffJobID = Convert.ToInt32(row["TakeOffJobID"].ToString());
                _takeOffData.Method= row["Method"].ToString();
				_takeOffData.Input= row["Input"].ToString();
				_takeOffData.BuildingType = row["BuildingType_takeoff"].ToString();
				_takeOffData.Division = row["Division_takeoff"].ToString();
				_takeOffData.DivisionCost = row["DivisionCost_takeoff"].ToString();
				_takeOffData.DivisionPrint = row["DivisionPrint_takeoff"].ToString();
				_takeOffData.Units = row["Units"].ToString();
				_takeOffData.Location = row["Location"].ToString();
				_takeOffData.Description = row["Description_takeoff"].ToString();
                _takeOffData.TakeOff = Convert.ToDecimal(row["TakeoffValue"].ToString());
                _takeOffData.Active = (bool) row["Active_takeoff"];
				_takeOffData.Memo = row["Memo_takeoff"].ToString();

				_TakeOffDatas.Add(_takeOffData);
			}
			return _TakeOffDatas;
		}

        public EstimateBuilder.TakeOffDatas selectJob(string _id)
        {
            DataSet dsData = this.selectJobData(_id);
            EstimateBuilder.TakeOffDatas _TakeOffDatas = new EstimateBuilder.TakeOffDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.TakeOffData  _takeOffData = new EstimateBuilder.TakeOffData();
                i += 1;
                _takeOffData.NumbID = i;
                _takeOffData.TakeOffID = Convert.ToInt32(row["TakeOffID"].ToString());
                _takeOffData.TakeOffJobID = Convert.ToInt32(row["TakeOffJobID"].ToString());
                _takeOffData.Method= row["Method"].ToString();
				_takeOffData.Input= row["Input"].ToString();
				_takeOffData.BuildingType = row["BuildingType_takeoff"].ToString();
				_takeOffData.Division = row["Division_takeoff"].ToString();
				_takeOffData.DivisionCost = row["DivisionCost_takeoff"].ToString();
				_takeOffData.DivisionPrint = row["DivisionPrint_takeoff"].ToString();
				_takeOffData.Units = row["Units"].ToString();
				_takeOffData.Location = row["Location"].ToString();
				_takeOffData.Description = row["Description_takeoff"].ToString();
                _takeOffData.TakeOff = Convert.ToDecimal(row["TakeoffValue"].ToString());
                _takeOffData.Active = (bool) row["Active_takeoff"];
				_takeOffData.Memo = row["Memo_takeoff"].ToString();

				_TakeOffDatas.Add(_takeOffData);
			}
			return _TakeOffDatas;
		}


        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

//            int k = _id.IndexOf("-");
//            if (k > 0)
//            { _id = _id.Substring(0, k); }

            strSQL.Append(" SELECT DISTINCT [TakeOffJobID],[TakeOffID], [Method], [Input],   ");
            strSQL.Append(" [BuildingType_takeoff], [Division_takeoff],[DivisionCost_takeoff], [DivisionPrint_takeoff], ");
            strSQL.Append(" [Units], [Location],[Description_takeoff],  [Active_takeoff], [Memo_takeoff] ");
            strSQL.Append(" FROM Takeoff WHERE [JobID]=0 AND [BuildingType_takeoff] ='" + _id + "'");



            DataSet dsData = _data.getDataSet(strSQL.ToString(), connect);

            return dsData;
        }

        public  EstimateBuilder.TakeOffDatas select(string _id)
		{
            DataSet dsData = this.selectData(_id);

            EstimateBuilder.TakeOffDatas _TakeOffDatas = new EstimateBuilder.TakeOffDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.TakeOffData  _takeOffData = new EstimateBuilder.TakeOffData();

                i += 1;
                _takeOffData.NumbID = i;
                _takeOffData.TakeOffID = Convert.ToInt32(row["TakeOffID"].ToString());
                _takeOffData.TakeOffJobID = Convert.ToInt32(row["TakeOffJobID"].ToString());
                _takeOffData.Method= row["Method"].ToString();
				_takeOffData.Input= row["Input"].ToString();
                _takeOffData.BuildingType = row["BuildingType_takeoff"].ToString();
                _takeOffData.Division = row["Division_takeoff"].ToString();
                _takeOffData.DivisionCost = row["DivisionCost_takeoff"].ToString();
                _takeOffData.DivisionPrint = row["DivisionPrint_takeoff"].ToString();
                _takeOffData.Units = row["Units"].ToString();
				_takeOffData.Location = row["Location"].ToString();
                _takeOffData.Description = row["Description_takeoff"].ToString();
                _takeOffData.TakeOff = 0; /// Convert.ToDouble(row["TakeoffValue"].ToString());
                _takeOffData.Active = (bool)row["Active_takeoff"];
                _takeOffData.Memo = row["Memo_takeoff"].ToString();

                _TakeOffDatas.Add(_takeOffData);
			}
			return _TakeOffDatas;
		}

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT DISTINCT [TakeOffJobID], [TakeOffID], [Method], [Input],  ");
            strSQL.Append(" [BuildingType_takeoff], [Division_takeoff],[DivisionCost_takeoff], [DivisionPrint_takeoff], ");
            strSQL.Append(" [Units], [Location],[Description_takeoff], [Active_takeoff], [Memo_takeoff] ");
            strSQL.Append(" FROM Takeoff WHERE [JobID]=0 ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), connect);


            return dsData;
        }
        public EstimateBuilder.TakeOffDatas select()
		{
            DataSet dsData = this.selectData();

            EstimateBuilder.TakeOffDatas _TakeOffDatas = new EstimateBuilder.TakeOffDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.TakeOffData  _takeOffData = new EstimateBuilder.TakeOffData();

                i += 1;
                _takeOffData.NumbID = i;
                _takeOffData.TakeOffID = Convert.ToInt32(row["TakeOffID"].ToString());
                _takeOffData.TakeOffJobID = Convert.ToInt32(row["TakeOffJobID"].ToString());
                _takeOffData.Method= row["Method"].ToString();
				_takeOffData.Input= row["Input"].ToString();
                _takeOffData.BuildingType = row["BuildingType_takeoff"].ToString();
                _takeOffData.Division = row["Division_takeoff"].ToString();
                _takeOffData.DivisionCost = row["DivisionCost_takeoff"].ToString();
                _takeOffData.DivisionPrint = row["DivisionPrint_takeoff"].ToString();
                _takeOffData.Units = row["Units"].ToString();
				_takeOffData.Location = row["Location"].ToString();
				_takeOffData.Description = row["Description_takeoff"].ToString();
                _takeOffData.TakeOff = 0;  // Convert.ToDouble(row["TakeoffValue"].ToString());
                _takeOffData.Active = (bool)row["Active_takeoff"];
                _takeOffData.Memo = row["Memo_takeoff"].ToString();
                _TakeOffDatas.Add(_takeOffData);
			}
			return _TakeOffDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}


	}
}
