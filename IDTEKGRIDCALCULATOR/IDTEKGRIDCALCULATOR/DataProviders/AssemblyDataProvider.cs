using System;
using IDIGITALTEKGRID;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for AssemblyDataProvider.
	/// </summary>
	public class AssemblyDataProvider
	{
		public AssemblyDataProvider()
		{

		}

		public void add(IDIGITALTEKGRID.AssemblyData  _assembly)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append("INSERT INTO Assembly (  Division, ");
			strSQL.Append(" [DivisionCost], Description,  ");
			if((_assembly.PhotoCad != null)&&(_assembly.PhotoCad.ToString() != ""))
			{
				strSQL.Append(" [PhotoCad]," );
			}
			if((_assembly.PhotoImage != null)&&(_assembly.PhotoImage.ToString() != ""))
			{
				strSQL.Append("[PhotoImage]," );
			}
			strSQL.Append("  [Memo] ) VALUES ('");
			strSQL.Append(  _assembly.Division +"','"+_assembly.DivisionCost +"','"+_assembly.Description +"'");
            if ((_assembly.PhotoCad != null) && (_assembly.PhotoCad.ToString() != ""))
			{
				strSQL.Append(","+  _assembly.PhotoCad +"," );
			}
			if((_assembly.PhotoImage != null)&&(_assembly.PhotoImage.ToString() != ""))
			{
				strSQL.Append(","+  _assembly.PhotoImage +"," );
			}
		
			strSQL.Append(",'"+ _assembly.Memo +"')" );
			try
			{

				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}


        public void Copy(IDIGITALTEKGRID.AssemblyData _assembly)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("INSERT INTO Assembly (  Division, ");
            strSQL.Append(" [DivisionCost], Description,  ");
            if ((_assembly.PhotoCad != null) && (_assembly.PhotoCad.ToString() != ""))
            {
                strSQL.Append(" [PhotoCad],");
            }
            if ((_assembly.PhotoImage != null) && (_assembly.PhotoImage.ToString() != ""))
            {
                strSQL.Append("[PhotoImage],");
            }
            strSQL.Append("  [Memo] ) VALUES ('");
            strSQL.Append(_assembly.Division + "','" + _assembly.DivisionCost + "','" + _assembly.Description + "'");
            if ((_assembly.PhotoCad != null) && (_assembly.PhotoCad.ToString() != ""))
            {
                strSQL.Append("," + _assembly.PhotoCad + ",");
            }
            if ((_assembly.PhotoImage != null) && (_assembly.PhotoImage.ToString() != ""))
            {
                strSQL.Append("," + _assembly.PhotoImage + ",");
            }

            strSQL.Append(",' Copy " + _assembly.Memo + "')");
            try
            {

                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }

		public void update(IDIGITALTEKGRID.AssemblyData _assembly)
		{		
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append("UPDATE Assembly SET ");
			strSQL.Append("  Assembly.Division = '"+ _assembly.Division +"', Assembly.[DivisionCost] = '"+  _assembly.DivisionCost );
			strSQL.Append("', Assembly.Description = '"+ _assembly.Description +"', Assembly.[Memo] = '"+ _assembly.Memo +"'");
			//if(_assembly.PhotoCad != null)
			//{
			//	strSQL.Append(", Assembly.[PhotoCad] = "+_assembly.PhotoCad +",");
			//}
			//if(_assembly.PhotoImage != null)
			//{
			//	strSQL.Append(", Assembly.[PhotoImage] = " + _assembly.PhotoImage +"," );
			//}
		
			strSQL.Append(" WHERE Assembly.AssemblyID = "+ _assembly.AssemblyID );
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(IDIGITALTEKGRID.AssemblyData _assembly)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append(" DELETE * FROM ASSEMBLY WHERE AssemblyID = "+ _assembly.AssemblyID);

			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);


		}


        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT Assembly.AssemblyID, Assembly.Division, ");
            strSQL.Append("Assembly.DivisionCost, Assembly.Description, ");
            strSQL.Append("Assembly.PhotoCad, Assembly.PhotoImage, Assembly.Memo ");
            strSQL.Append("FROM Assembly WHERE Assembly.Division='" + _id + "'");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            return dsData;
        }


         public  IDIGITALTEKGRID.AssemblyDatas select(string _id)
		{

            DataSet dsData = this.selectData(_id);

            IDIGITALTEKGRID.AssemblyDatas _assemblyDatas = new IDIGITALTEKGRID.AssemblyDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.AssemblyData _assemblyData = new IDIGITALTEKGRID.AssemblyData();
                i += 1;
                _assemblyData.NumbID = i;
                _assemblyData.AssemblyID  = Convert.ToInt32(row["AssemblyID"].ToString());
				_assemblyData.Description = row["Description"].ToString();
				_assemblyData.Division = row["Division"].ToString();
				_assemblyData.DivisionCost = row["DivisionCost"].ToString();
				_assemblyData.PhotoCad = row["PhotoCad"].ToString();
				_assemblyData.PhotoImage = row["PhotoImage"].ToString();
				_assemblyData.Memo = row["Memo"].ToString();
				_assemblyDatas.Add(_assemblyData);
			}
			return _assemblyDatas;
		}


        public DataSet selectData()
        {
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

		
			strSQL.Append("SELECT Assembly.AssemblyID, Assembly.Division, ");
			strSQL.Append("Assembly.DivisionCost, Assembly.Description, ");
			strSQL.Append("Assembly.PhotoCad, Assembly.PhotoImage, Assembly.Memo ");
			strSQL.Append("FROM Assembly ");
		
			DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
			
            
            return dsData;
        }

        public IDIGITALTEKGRID.AssemblyDatas select()
        {

            DataSet dsData = this.selectData();

            IDIGITALTEKGRID.AssemblyDatas _assemblyDatas = new IDIGITALTEKGRID.AssemblyDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.AssemblyData _assemblyData = new IDIGITALTEKGRID.AssemblyData();
                i += 1;
                _assemblyData.NumbID = i;
                _assemblyData.AssemblyID  =  Convert.ToInt32(row["AssemblyID"].ToString());
				_assemblyData.Description = row["Description"].ToString();
				_assemblyData.Division = row["Division"].ToString();
				_assemblyData.DivisionCost = row["DivisionCost"].ToString();
				_assemblyData.PhotoCad = row["PhotoCad"].ToString();
				_assemblyData.PhotoImage = row["PhotoImage"].ToString();
				_assemblyData.Memo = row["Memo"].ToString();
				_assemblyDatas.Add(_assemblyData);
			}
			return _assemblyDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}

	}
}
