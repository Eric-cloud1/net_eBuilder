using System;
using System.Data;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for SettingDataProvider.
	/// </summary>
	public class SettingDataProvider
	{
		public SettingDataProvider()
		{

		}



		public void add(EstimateBuilder.SettingData  _settingData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" INSERT INTO Settings( ViewName, Layout )");
			strSQL.Append(" VALUES ('" + _settingData.ViewName + "','"+ _settingData.Layout +"')");
		

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
		}


		public void update(EstimateBuilder.SettingData  _settingData)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" UPDATE [Settings] SET "); 
			strSQL.Append(" ViewName = '"+ _settingData.ViewName + "', ");
			strSQL.Append(" Layout = '"  + _settingData.Layout + "'");
			strSQL.Append(" WHERE ViewName = '"+  _settingData.ViewName +"'");
			
			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
		}


		public void delete(EstimateBuilder.SettingData  _settingData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append(" DELETE * FROM [Settings] WHERE ViewName = '"+  _settingData.ViewName +"'");

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);


		}


		public  EstimateBuilder.SettingDatas select(string  _viewName)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append(" SELECT ViewID, ViewName, Layout ");
			strSQL.Append(" FROM [Settings]  WHERE ViewName ='"+ _viewName+"'");
			try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
				EstimateBuilder.SettingDatas _SettingDatas = new EstimateBuilder.SettingDatas();

				foreach(DataRow row in dsData.Tables[0].Rows)
				{
					EstimateBuilder.SettingData  _SettingData = new EstimateBuilder.SettingData();
					_SettingData.ViewID = row["ViewID"].ToString();
					_SettingData.Layout = row["Layout"].ToString();
					_SettingData.ViewName = row["ViewName"].ToString();
					_SettingDatas.Add(_SettingData);
				}
				return _SettingDatas;
			}
			catch
			{
				return null;
			}
			
		}


		public  EstimateBuilder.SettingDatas select()
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" SELECT ViewID, ViewName, Layout ");
			strSQL.Append(" FROM [Settings]  ");


			DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
			EstimateBuilder.SettingDatas _SettingDatas = new EstimateBuilder.SettingDatas();

			foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.SettingData  _SettingData = new EstimateBuilder.SettingData();
				_SettingData.ViewID = row["ViewID"].ToString();
				_SettingData.Layout = row["Layout"].ToString();
				_SettingData.ViewName = row["ViewName"].ToString();
				_SettingDatas.Add(_SettingData);
			}
			return _SettingDatas;
		}

		public void Dispose()
		{
			GC.Collect();
		}
	}
}
