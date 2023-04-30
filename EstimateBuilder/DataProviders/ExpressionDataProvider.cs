using System;
using EstimateBuilder;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ExpressionDataProvider.
	/// </summary>
	public class ExpressionDataProvider
	{
		public ExpressionDataProvider()
		{

		}

		
		public void add(EstimateBuilder.ExpressionData  _ExpressionData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
            strSQL.Append("INSERT INTO Expression ( [BuildingType],[ExpressionID], [value] , Division, AssemblyID, ");
            strSQL.Append("  [DivisionCost], Description, [Memo], Unit)");
            strSQL.Append(" VALUES ('"+ _ExpressionData.BuildingType +"',"+_ExpressionData.ExpressionID +",'" + _ExpressionData.Value + "','" + _ExpressionData.Division + "'," + _ExpressionData.AssemblyID + ",'");
            strSQL.Append( _ExpressionData.DivisionCost +"','"+_ExpressionData.Description+"','"+_ExpressionData.Memo+"','"+ _ExpressionData.Unit +"')");
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void update(EstimateBuilder.ExpressionData  _ExpressionData)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" UPDATE Expression SET  Expression.Division = '"+ _ExpressionData.Division + "', ");
			strSQL.Append(" [DivisionCost] = '"+ _ExpressionData.DivisionCost + "', Expression.AssemblyID = "+_ExpressionData.AssemblyID+","); 
			strSQL.Append("  Expression.Description = '"+ _ExpressionData.Description + "',"); 
			strSQL.Append(" Expression.[Memo] = '"+ _ExpressionData.Memo+ "',");
            strSQL.Append(" Expression.[Value] = '" + _ExpressionData.Value + "',");
            strSQL.Append(" Expression.[BuildingType] = '" + _ExpressionData.BuildingType + "',");
            strSQL.Append(" Expression.Unit = '" + _ExpressionData.Unit + "'");
            strSQL.Append(" WHERE ExpressionID ="+_ExpressionData.ExpressionID);
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(EstimateBuilder.ExpressionData  _ExpressionData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append("DELETE * FROM  Expression WHERE ExpressionID ="+ _ExpressionData.ExpressionID);

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
		}

        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT ExpressionID,  BuildingType, Division, [DivisionCost], AssemblyID,");
            strSQL.Append(" Description, Memo, [value], Unit FROM Expression WHERE Division='" + _id + "'");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public  EstimateBuilder.ExpressionDatas select(string _id)
		{
            DataSet dsData = this.selectData(_id);
            EstimateBuilder.ExpressionDatas _ExpressionDatas = new EstimateBuilder.ExpressionDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.ExpressionData  _ExpressionData = new EstimateBuilder.ExpressionData();

                i += 1;
                _ExpressionData.NumbID = i;
                _ExpressionData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
				_ExpressionData.Division = row["Division"].ToString();
				_ExpressionData.DivisionCost = row["DivisionCost"].ToString();
				_ExpressionData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
				_ExpressionData.Description = row["Description"].ToString();
				_ExpressionData.Memo = row["Memo"].ToString();
                _ExpressionData.Value = row["Value"].ToString();
                _ExpressionData.BuildingType = row["BuildingType"].ToString();
                _ExpressionData.Unit = row["Unit"].ToString();




                _ExpressionDatas.Add(_ExpressionData);
			}
			return _ExpressionDatas;
		}

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT ExpressionID, BuildingType, Division, [DivisionCost], AssemblyID,");
            strSQL.Append(" Description, Memo, [value],unit FROM Expression;");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public EstimateBuilder.ExpressionDatas select()
		{
            DataSet dsData = this.selectData();
            EstimateBuilder.ExpressionDatas _ExpressionDatas = new EstimateBuilder.ExpressionDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.ExpressionData  _ExpressionData = new EstimateBuilder.ExpressionData();

                i += 1;
                _ExpressionData.NumbID = i;
                _ExpressionData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
				_ExpressionData.Division = row["Division"].ToString();
				_ExpressionData.DivisionCost = row["DivisionCost"].ToString();
				_ExpressionData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
				_ExpressionData.Description = row["Description"].ToString();
				_ExpressionData.Memo = row["Memo"].ToString();
                _ExpressionData.Value = row["Value"].ToString();
                _ExpressionData.BuildingType = row["BuildingType"].ToString();
                _ExpressionData.Unit = row["Unit"].ToString();


                _ExpressionDatas.Add(_ExpressionData);
			}
			return _ExpressionDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}


	}
}
