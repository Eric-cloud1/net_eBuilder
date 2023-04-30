using System;
using System.Data;
using System.Text;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for SettingDataProvider.
	/// </summary>
	public class SettingDataProvider
	{
		public SettingDataProvider()
		{

		}



		public void add(IDIGITALTEKGRID.SettingData  _settingData)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append(" INSERT INTO Settings( ViewName, Layout )");
			strSQL.Append(" VALUES ('" + _settingData.ViewName + "','"+ _settingData.Layout +"')");
		

			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
		}


		public void update(IDIGITALTEKGRID.SettingData  _settingData)
		{		
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append(" UPDATE [Settings] SET "); 
			strSQL.Append(" ViewName = '"+ _settingData.ViewName + "', ");
			strSQL.Append(" Layout = '"  + _settingData.Layout + "'");
			strSQL.Append(" WHERE ViewName = '"+  _settingData.ViewName +"'");
			
			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
		}


		public void delete(IDIGITALTEKGRID.SettingData  _settingData)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append(" DELETE * FROM [Settings] WHERE ViewName = '"+  _settingData.ViewName +"'");

			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);


		}


		public  IDIGITALTEKGRID.SettingDatas select(string  _viewName)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append(" SELECT ViewID, ViewName, Layout ");
			strSQL.Append(" FROM [Settings]  WHERE ViewName ='"+ _viewName+"'");
			try
			{
				DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
				IDIGITALTEKGRID.SettingDatas _SettingDatas = new IDIGITALTEKGRID.SettingDatas();

				foreach(DataRow row in dsData.Tables[0].Rows)
				{
					IDIGITALTEKGRID.SettingData  _SettingData = new IDIGITALTEKGRID.SettingData();
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


		public  IDIGITALTEKGRID.SettingDatas select()
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append(" SELECT ViewID, ViewName, Layout ");
			strSQL.Append(" FROM [Settings]  ");


			DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
			IDIGITALTEKGRID.SettingDatas _SettingDatas = new IDIGITALTEKGRID.SettingDatas();

			foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.SettingData  _SettingData = new IDIGITALTEKGRID.SettingData();
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
