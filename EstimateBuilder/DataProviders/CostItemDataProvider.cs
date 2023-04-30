using System;
using EstimateBuilder;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for CostItemDataProvider.
	/// </summary>
	public class CostItemDataProvider
	{
		public CostItemDataProvider()
		{

		}
		
		public void add(EstimateBuilder.CostItemData  _costItemData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();


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
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}

        public void Copy(EstimateBuilder.CostItemData _costItemData)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


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
                _data.ExecuteSQL(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            }
            catch { }
        }

		public void update(EstimateBuilder.CostItemData _costItemData)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

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
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(EstimateBuilder.CostItemData _costItemData)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append(" DELETE * FROM CostItem WHERE CostItemID ="+  _costItemData.CostItemID );
			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
		}

        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT CostItemID,  CostType, UnitOrder, ");
            strSQL.Append(" Description_costItem,  ");
            strSQL.Append("[MinimumOrder],  ");
            strSQL.Append("Active_costItem,  [Division_costItem], ");
            strSQL.Append("[DivisionCost_costItem], ");
            strSQL.Append(" Memo_costItem,CostAdjustment,  GenericVendor FROM CostItem WHERE CostType='" + _id + "'");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;

        }

        public  EstimateBuilder.CostItemDatas select(string _id)
		{
            DataSet dsData = selectData(_id);

            EstimateBuilder.CostItemDatas _costItemDatas = new EstimateBuilder.CostItemDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.CostItemData _costItemData = new EstimateBuilder.CostItemData();

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
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT CostItemID , CostType, UnitOrder,");
            strSQL.Append(" Description_costItem,");
            strSQL.Append(" [MinimumOrder], ");

            strSQL.Append("Active_costItem, [Division_costItem], ");
            strSQL.Append("[DivisionCost_costItem], ");
            strSQL.Append(" Memo_costItem , CostAdjustment,  GenericVendor FROM CostItem");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public EstimateBuilder.CostItemDatas select()
		{
            DataSet dsData = this.selectData();

            EstimateBuilder.CostItemDatas _costItemDatas = new EstimateBuilder.CostItemDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.CostItemData _costItemData = new EstimateBuilder.CostItemData();
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
