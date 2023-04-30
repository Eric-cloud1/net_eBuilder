using System;
using IDIGITALTEKGRID;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for CostItemDataProvider.
	/// </summary>
	public class CostItemDataProvider
	{
		public CostItemDataProvider()
		{

		}
		
		public void add(IDIGITALTEKGRID.CostItemData  _costItemData)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();


            strSQL.Append("INSERT INTO CostItem (");
            strSQL.Append("CostType, UnitOrder, Description_costItem,");
			strSQL.Append(" MinimumOrder, CostAdjustment,");
            strSQL.Append(" Active_costItem,  Division_costItem,");
            strSQL.Append("[DivisionCost_costItem],");
            strSQL.Append("[Memo_costItem], GenericVendor )");
            strSQL.Append(" VALUES ( '");
			strSQL.Append( _costItemData.CostType +"','"+ _costItemData.UnitOrder +"','"+_costItemData.Description +"',");
			strSQL.Append(_costItemData.MinimumOrder +","+_costItemData.CostAdjustment+",");
			strSQL.Append(_costItemData.Active +",'"+_costItemData.Division+"','");
			strSQL.Append(_costItemData.DivisionCost +"','");
            strSQL.Append(_costItemData.Memo + "','" + _costItemData.GenericVendor+ ")");
            try
			{
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}

        public void Copy(IDIGITALTEKGRID.CostItemData _costItemData)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();


            strSQL.Append("INSERT INTO CostItem (");
            strSQL.Append("CostType, UnitOrder, Description_costItem,");
            strSQL.Append(" MinimumOrder, CostAdjustment,");
            strSQL.Append(" Active_costItem,  Division_costItem,");
            strSQL.Append("[DivisionCost_costItem],");
            strSQL.Append("[Memo_costItem], GenericVendor )");
            strSQL.Append(" VALUES ( '");
            strSQL.Append(_costItemData.CostType + "','" + _costItemData.UnitOrder + "',' Copy " + _costItemData.Description + "',");
            strSQL.Append(_costItemData.MinimumOrder + "," + _costItemData.CostAdjustment + ",");
            strSQL.Append(_costItemData.Active + ",'" + _costItemData.Division + "','");
            strSQL.Append(_costItemData.DivisionCost + "','");
            strSQL.Append(_costItemData.Memo + "','" + _costItemData.GenericVendor+ ")");
            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }

		public void update(IDIGITALTEKGRID.CostItemData _costItemData)
		{		
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append(" UPDATE CostItem SET ");  		
			strSQL.Append(" CostItem.CostType = '"+ _costItemData.CostType  +"', CostItem.UnitOrder = '"+ _costItemData.UnitOrder +"',"); 
			strSQL.Append(" CostItem.Description_costItem = '"+ _costItemData.Description +"',");
            strSQL.Append("  CostItem.MinimumOrder  = " + _costItemData.MinimumOrder + ", ");
            strSQL.Append(" CostItem.CostAdjustment = "+ _costItemData.CostAdjustment +",");
            strSQL.Append(" CostItem.Active_costItem = " + _costItemData.Active + ",");
            strSQL.Append(" CostItem.Division_costItem = '" + _costItemData.Division + "', CostItem.[DivisionCost_costItem] = '" + _costItemData.DivisionCost + "',");
            strSQL.Append("  CostItem.[Memo_costItem] = '" + _costItemData.Memo + "', ");
            strSQL.Append("  GenericVendor = '" + _costItemData.GenericVendor+ "' ");
           
            strSQL.Append(" WHERE  CostItem.CostItemID = " + _costItemData.CostItemID );


            try
			{	
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(IDIGITALTEKGRID.CostItemData _costItemData)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
			strSQL.Append(" DELETE * FROM CostItem WHERE CostItemID ="+  _costItemData.CostItemID );
			_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
		}

        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT CostItemID,  CostType, UnitOrder, ");
            strSQL.Append(" Description_costItem,  ");
            strSQL.Append("[MinimumOrder],  ");
            strSQL.Append("Active_costItem,  [Division_costItem], ");
            strSQL.Append("[DivisionCost_costItem], ");
            strSQL.Append(" Memo_costItem,CostAdjustment,  GenericVendor FROM CostItem WHERE CostType='" + _id + "'");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            return dsData;

        }

        public  IDIGITALTEKGRID.CostItemDatas select(string _id)
		{
            DataSet dsData = selectData(_id);

            IDIGITALTEKGRID.CostItemDatas _costItemDatas = new IDIGITALTEKGRID.CostItemDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.CostItemData _costItemData = new IDIGITALTEKGRID.CostItemData();

                i += 1;
                _costItemData.NumbID = i;
                _costItemData.CostItemID  = Convert.ToInt32(row["CostItemID"]);
                _costItemData.CostAdjustment = Convert.ToDecimal(row["CostAdjustment"]);
                _costItemData.CostType =  row["CostType"].ToString();
				_costItemData.UnitOrder = row["UnitOrder"].ToString();
				_costItemData.Description = row["Description_costItem"].ToString();
                _costItemData.GenericVendor = row["GenericVendor"].ToString();
                try
                {
                    _costItemData.MinimumOrder = Convert.ToDecimal(row["MinimumOrder"]);
                }
                catch { }
                _costItemData.Active = (bool)row["Active_costItem"];
                _costItemData.Division = row["Division_costItem"].ToString();
                _costItemData.DivisionCost = row["DivisionCost_costItem"].ToString();
                _costItemData.Memo = row["Memo_costItem"].ToString();
                _costItemDatas.Add(_costItemData);
			}
			return _costItemDatas;
		}

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT CostItemID , CostType, UnitOrder,");
            strSQL.Append(" Description_costItem,");
            strSQL.Append(" [MinimumOrder], ");

            strSQL.Append("Active_costItem, [Division_costItem], ");
            strSQL.Append("[DivisionCost_costItem], ");
            strSQL.Append(" Memo_costItem , CostAdjustment,  GenericVendor FROM CostItem");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            return dsData;
        }

        public IDIGITALTEKGRID.CostItemDatas select()
		{
            DataSet dsData = this.selectData();

            IDIGITALTEKGRID.CostItemDatas _costItemDatas = new IDIGITALTEKGRID.CostItemDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				IDIGITALTEKGRID.CostItemData _costItemData = new IDIGITALTEKGRID.CostItemData();
                i += 1;
                _costItemData.NumbID = i;
                _costItemData.CostItemID  = Convert.ToInt32(row["CostItemID"]);
                _costItemData.CostAdjustment = Convert.ToDecimal(row["CostAdjustment"]);
                _costItemData.CostType =  row["CostType"].ToString();
				_costItemData.UnitOrder = row["UnitOrder"].ToString();
				_costItemData.Description = row["Description_costItem"].ToString();
                _costItemData.GenericVendor = row["GenericVendor"].ToString();
                try
                {
                    _costItemData.MinimumOrder = Convert.ToDecimal(row["MinimumOrder"]);
                }
                catch { }
                _costItemData.Active = (bool)(row["Active_costItem"]);
                _costItemData.Division = row["Division_costItem"].ToString();
                _costItemData.DivisionCost = row["DivisionCost_costItem"].ToString();
                _costItemData.Memo = row["Memo_costItem"].ToString();
                _costItemDatas.Add(_costItemData);
			}
			return _costItemDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}

	}
}
