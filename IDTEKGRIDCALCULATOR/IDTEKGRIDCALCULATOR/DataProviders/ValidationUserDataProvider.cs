using System;
using IDIGITALTEKGRID;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ValidationUserDataProvider.
	/// </summary>
	public class ValidationUserDataProvider
	{
		public ValidationUserDataProvider()
		{

		}

		public void add(IDIGITALTEKGRID.ValidationUserData  _validationUser)
		{
			 StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append("INSERT INTO ValidationUser ( [Group], [Type], ");
			strSQL.Append(" [Active], [Pulldown], [Code], [Description], [Memo] )");
			strSQL.Append(" VALUES ('"+ _validationUser.Group +"','");
			strSQL.Append(_validationUser.Type +"',");
			strSQL.Append(_validationUser.Active +",");
			strSQL.Append(_validationUser.Pulldown +",'");
			strSQL.Append(_validationUser.Code +"','");
			strSQL.Append(_validationUser.Description +"','");
			strSQL.Append(_validationUser.Memo +"')");
			try
		    {
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}

        public void Copy(IDIGITALTEKGRID.ValidationUserData _validationUser)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append("INSERT INTO ValidationUser ( [Group], [Type], ");
            strSQL.Append(" [Active], [Pulldown], [Code], [Description], [Memo] )");
            strSQL.Append(" VALUES ('" + _validationUser.Group + "','");
            strSQL.Append(_validationUser.Type + "',");
            strSQL.Append(_validationUser.Active + ",");
            strSQL.Append(_validationUser.Pulldown + ",'");
            strSQL.Append(_validationUser.Code + "',' Copy ");
            strSQL.Append(_validationUser.Description + "','");
            strSQL.Append(_validationUser.Memo + "')");
            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }

		public void update(IDIGITALTEKGRID.ValidationUserData  _validationUser)
		{		
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

            if (_validationUser.ValidationUserID == 486)
            {
                int id = _validationUser.ValidationUserID;
            }

            strSQL.Append(" UPDATE ValidationUser SET ");
			strSQL.Append(" [Group] = '"+ _validationUser.Group +"', [Type] = '"+ _validationUser.Type +"',");
            strSQL.Append(" [Active] = " + _validationUser.Active + ",[Description] = '" + _validationUser.Description + "',");
            strSQL.Append(" [Pulldown] = "+ _validationUser.Pulldown +", [Code] = '"+ _validationUser.Code+"', ");
            strSQL.Append(" [Memo] = '" + _validationUser.Memo + "'");
			strSQL.Append(" WHERE  ValidationUserID = "+ _validationUser.ValidationUserID );

			try
			{
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(IDIGITALTEKGRID.ValidationUserData  _validationUser)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append("DELETE * FROM  ValidationUser WHERE ValidationUserID = "+ _validationUser.ValidationUserID );

			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);


		}

        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ValidationUserID, [Group], Type, ");
            strSQL.Append(" Active, Pulldown, Code,Description, ");
            strSQL.Append(" Memo FROM ValidationUser WHERE [Group] ='" + _id + "'");
            strSQL.Append(" AND  [Group] <>'View'");
            strSQL.Append(" ORDER BY ValidationUser.Group, ValidationUser.Code  ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

            return dsData;
        }

        public  IDIGITALTEKGRID.ValidationUserDatas select(string _id)
		{
            DataSet dsData = this.selectData(_id);

            IDIGITALTEKGRID.ValidationUserDatas _validationUserDatas = new IDIGITALTEKGRID.ValidationUserDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.ValidationUserData  _validationUser = new IDIGITALTEKGRID.ValidationUserData();
                i += 1;
                _validationUser.NumbID = i;
                _validationUser.ValidationUserID = Convert.ToInt32(row["ValidationUserID"].ToString());
				_validationUser.Group = row["Group"].ToString();
				_validationUser.Type = row["Type"].ToString();
				_validationUser.Active = (bool) row["Active"];
				_validationUser.Pulldown = (bool) row["PullDown"];
				_validationUser.Code = row["Code"].ToString();
				_validationUser.Description = row["Description"].ToString();
				_validationUser.Memo = row["Memo"].ToString();
				
				
				_validationUserDatas.Add(_validationUser);
			}
			return _validationUserDatas;
		}

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ValidationUserID, [Group], Type, ");
            strSQL.Append(" Active, Pulldown, Code,Description, ");
            strSQL.Append(" Memo FROM ValidationUser ");
            strSQL.Append(" WHERE  [Group] <>'View' ORDER BY Group, Code");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

            return dsData;
        }

        public IDIGITALTEKGRID.ValidationUserDatas select()
		{
            DataSet dsData = this.selectData();

            IDIGITALTEKGRID.ValidationUserDatas _validationUserDatas = new IDIGITALTEKGRID.ValidationUserDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.ValidationUserData  _validationUser = new IDIGITALTEKGRID.ValidationUserData();
                i += 1;
                _validationUser.NumbID = i;
                _validationUser.ValidationUserID = Convert.ToInt32(row["ValidationUserID"].ToString());
				_validationUser.Group = row["Group"].ToString();
				_validationUser.Type = row["Type"].ToString();
				_validationUser.Active = (bool) row["Active"];
				_validationUser.Pulldown = (bool) row["PullDown"];
				_validationUser.Code = row["Code"].ToString();
				_validationUser.Description = row["Description"].ToString();
				_validationUser.Memo = row["Memo"].ToString();
				_validationUserDatas.Add(_validationUser);
			}
				return _validationUserDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}

	}
}
