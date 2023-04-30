 using System;
using EstimateBuilder;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for CostAmountDataProvider.
	/// </summary>
	public class CostAmountDataProvider
	{
		public CostAmountDataProvider()
		{

		}

		public void add(EstimateBuilder.CostAmountData  _costAmount)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();


			strSQL.Append("INSERT INTO CostAmount (  [User], [Date], ");
			strSQL.Append(" VendorID, ManufactureID,   [ZipCode], [CostAmount_costAmt], ");
            strSQL.Append(" Active,   [Memo_costAmt], CostItemID, BuildingType_costAmt ,PieceUnitOrder_costAmt)");
            strSQL.Append(" VALUES('"+ _costAmount.User +"','"+_costAmount.Date+"',");
			strSQL.Append(_costAmount.VendorID+","+_costAmount.ManufactureID+",'");
            strSQL.Append(_costAmount.ZipCode + "'," + _costAmount.CostAmt + "," + _costAmount.Active + ",'");
            strSQL.Append(  _costAmount.Memo + "'," + _costAmount.CostItemID + ",'" + _costAmount.BuildingType +"',"+ _costAmount.PiecePerUnitOrder+" )");


            try
			{

				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


        public void Copy(EstimateBuilder.CostAmountData _costAmount)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append("INSERT INTO CostAmount (  [User], [Date], ");
            strSQL.Append(" VendorID, ManufactureID,   [ZipCode], [CostAmount_costAmt], ");
            strSQL.Append(" Active,   [Memo_costAmt], CostItemID, BuildingType_costAmt ,PieceUnitOrder_costAmt)");
            strSQL.Append(" VALUES('  Copy  " + _costAmount.User + "','" + _costAmount.Date + "',");
            strSQL.Append(_costAmount.VendorID + "," + _costAmount.ManufactureID + ",'");
            strSQL.Append(_costAmount.ZipCode + "'," + _costAmount.CostAmt + "," + _costAmount.Active + ",'");
            strSQL.Append(_costAmount.Memo + "'," + _costAmount.CostItemID + ",'" + _costAmount.BuildingType + "'," + _costAmount.PiecePerUnitOrder + " )");


            try
            {

                _data.ExecuteSQL(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            }
            catch { }
        }


		public void update(EstimateBuilder.CostAmountData _costAmount)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" UPDATE [CostAmount] SET "  );
			strSQL.Append(" [User] = '"+  _costAmount.User +"', [Date] = '"+  _costAmount.Date +"',");
			strSQL.Append("	VendorID =" +  _costAmount.VendorID +",");
            strSQL.Append("	[CostItemID] = " + _costAmount.CostItemID + ",");
            strSQL.Append(" BuildingType_costAmt = '" + _costAmount.BuildingType + "', ");
            strSQL.Append(" ManufactureID = " + _costAmount.ManufactureID + ", ");
            strSQL.Append(" [ZipCode] = '" +  _costAmount.ZipCode +"', [CostAmount_costAmt] = "+ _costAmount.CostAmt +", ");
            strSQL.Append(" PieceUnitOrder_costAmt = " + _costAmount.PiecePerUnitOrder + ",");
            strSQL.Append(" Active = " + _costAmount.Active + ",[Memo_costAmt] = '" + _costAmount.Memo + "' ");   
            strSQL.Append(" WHERE CostAmountID = " +  _costAmount.CostAmountID);
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}


		public void delete(EstimateBuilder.CostAmountData _costAmount)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append("DELETE * FROM [CostAmount] WHERE CostAmountID="+_costAmount.CostAmountID);

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);


		}

        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT CostAmount.CostAmountID, CostAmount.User, ");
            strSQL.Append(" CostAmount.Date, CostAmount.VendorID, CostAmount.ManufactureID, ");
            strSQL.Append(" CostAmount.ZipCode, CostAmount.CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.BuildingType_costAmt, CostAmount.Active, ");
            strSQL.Append(" CostAmount.PhotoCad, CostAmount.PhotoImage, ");
            strSQL.Append(" CostAmount.Memo_costAmt, CostAmount.CostItemID, CostAmount.PieceUnitOrder_costAmt, ");
            strSQL.Append("  CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.Description_costItem, CostItem.GenericVendor ");
            strSQL.Append(" FROM CostAmount INNER JOIN CostItem ON CostAmount.CostItemID = CostItem.CostItemID");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }
        public  EstimateBuilder.CostAmountDatas select(string _id)
		{

            DataSet dsData = this.selectData(_id);

            EstimateBuilder.CostAmountDatas _costAmountDatas = new EstimateBuilder.CostAmountDatas();

            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.CostAmountData _costAmountData = new EstimateBuilder.CostAmountData();

                i += 1;
                _costAmountData.NumbID = i;

                try{
                _costAmountData.PiecePerUnitOrder = Convert.ToDecimal(row["PieceUnitOrder_costAmt"]);
                  }
                catch { }
                _costAmountData.CostAmountID  = Convert.ToInt32(row["CostAmountID"]);
				_costAmountData.User =  row["User"].ToString();
				try
				{
					_costAmountData.Date = Convert.ToDateTime(row["Date"]);
				}
				catch
				{
					_costAmountData.Date = System.DateTime.Now;
				}
                _costAmountData.BuildingType = row["BuildingType_costAmt"].ToString();
                _costAmountData.VendorID = Convert.ToInt32(row["VendorID"]);
                _costAmountData.ManufactureID = Convert.ToInt32(row["ManufactureID"]);
                _costAmountData.GenericVendor = row["GenericVendor"].ToString();
                _costAmountData.Description = row["Description_costItem"].ToString();
                _costAmountData.ZipCode = row["ZipCode"].ToString();
                _costAmountData.CostAmt = Convert.ToDecimal(row["CostAmount_costAmt"]);
                _costAmountData.Active = (bool)row["Active"];
                _costAmountData.PhotoCad = row["PhotoCad"].ToString();
                _costAmountData.PhotoImage = row["PhotoImage"].ToString();
                _costAmountData.Memo = row["Memo_costAmt"].ToString();
                _costAmountData.CostItemID = Convert.ToInt32(row["CostItemID"]);
                _costAmountData.Division = row["Division_costItem"].ToString();
                _costAmountData.DivisionCost = row["DivisionCost_costItem"].ToString();

                _costAmountDatas.Add(_costAmountData);
			}
			return _costAmountDatas;
		}

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT CostAmount.CostAmountID, CostAmount.User, ");
            strSQL.Append(" CostAmount.Date, CostAmount.VendorID, CostAmount.ManufactureID, ");
            strSQL.Append(" CostAmount.ZipCode, CostAmount.CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.BuildingType_costAmt, CostAmount.Active, ");
            strSQL.Append(" CostAmount.PhotoCad, CostAmount.PhotoImage, ");
            strSQL.Append(" CostAmount.Memo_costAmt, CostAmount.CostItemID, CostAmount.PieceUnitOrder_costAmt, ");
            strSQL.Append("  CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.Description_costItem, CostItem.GenericVendor");
            strSQL.Append(" FROM CostAmount INNER JOIN CostItem ON CostAmount.CostItemID = CostItem.CostItemID");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public EstimateBuilder.CostAmountDatas select()
		{

            DataSet dsData = this.selectData();

            EstimateBuilder.CostAmountDatas _costAmountDatas = new EstimateBuilder.CostAmountDatas();
            int i = 0;
            foreach(DataRow row in dsData.Tables[0].Rows)
			{
				EstimateBuilder.CostAmountData _costAmountData = new EstimateBuilder.CostAmountData();

                i += 1;
                _costAmountData.NumbID = i;

                try
                {
                    _costAmountData.PiecePerUnitOrder = Convert.ToDecimal(row["PieceUnitOrder_costAmt"]);
                }
                catch { }
                _costAmountData.CostAmountID  =  Convert.ToInt32(row["CostAmountID"]);
                _costAmountData.User = row["User"].ToString();
                try
                {
                    _costAmountData.Date = Convert.ToDateTime(row["Date"]);
                }
                catch
                {
                    _costAmountData.Date = System.DateTime.Now;
                }
                _costAmountData.BuildingType = row["BuildingType_costAmt"].ToString();
                _costAmountData.VendorID = Convert.ToInt32(row["VendorID"]);
                _costAmountData.ManufactureID = Convert.ToInt32(row["ManufactureID"]);
                _costAmountData.GenericVendor = row["GenericVendor"].ToString();
                _costAmountData.Description = row["Description_costItem"].ToString();
                _costAmountData.ZipCode = row["ZipCode"].ToString();
                _costAmountData.CostAmt = Convert.ToDecimal(row["CostAmount_costAmt"]);
                _costAmountData.Active = (bool)row["Active"];
                _costAmountData.PhotoCad = row["PhotoCad"].ToString();
                _costAmountData.PhotoImage = row["PhotoImage"].ToString();
                _costAmountData.Memo = row["Memo_costAmt"].ToString();
                _costAmountData.CostItemID = Convert.ToInt32(row["CostItemID"]);
                _costAmountData.Division = row["Division_costItem"].ToString();
                _costAmountData.DivisionCost = row["DivisionCost_costItem"].ToString();

                _costAmountDatas.Add(_costAmountData);
			}
			return _costAmountDatas;
		}


		public void Dispose()
		{
			GC.Collect();
		}

	}
}
