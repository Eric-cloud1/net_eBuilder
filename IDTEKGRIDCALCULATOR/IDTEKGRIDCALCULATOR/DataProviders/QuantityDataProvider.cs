using System;
using IDIGITALTEKGRID;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
    /// <summary>
    /// Summary description for QuantityDataProvider.
    /// </summary>
    public class QuantityDataProvider
    {
        public QuantityDataProvider()
        {

        }

        public void add(IDIGITALTEKGRID.QuantityData _quantityData)
        {
            StringBuilder strSQL = new StringBuilder();

            _quantityData.Quantity = 0 ;
            _quantityData.RunDateTime = System.DateTime.Now;


            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" INSERT INTO Quantity ( Division_Quantity, [DivisionCost_Quantity], ");
            strSQL.Append(" [QuantityAdjusted], QuantityRoundUp, QuantityReuse, QuantityWaste,  ");
            strSQL.Append(" [DivisionPrint_Quantity], Units, Location, Description_Quantity, ExpressionID,  ");
            strSQL.Append(" AssemblyID, Active_Quantity, Quantity, RunDateTime, [Memo_Quantity],   CostItemID , ReportPhase, ReportContract, Accounting) ");
            strSQL.Append(" VALUES ('" + _quantityData.Division + "','" + _quantityData.DivisionCost + "',");

            strSQL.Append( _quantityData.QuantityAdjusted + "," + _quantityData.QuantityRoundUp + ",");
            strSQL.Append(_quantityData.QuantityReuse + "," + _quantityData.QuantityWaste + ",");

            strSQL.Append("'" + _quantityData.DivisionPrint + "','" + _quantityData.Units + "',");
            strSQL.Append("'" + _quantityData.Location + "','" + _quantityData.Description + "',");
            strSQL.Append(_quantityData.ExpressionID + "," + _quantityData.AssemblyID + ", ");
            strSQL.Append(_quantityData.Active + "," + _quantityData.Quantity + ",'");
            strSQL.Append(_quantityData.RunDateTime + "','" + _quantityData.Memo + "',");
   
            strSQL.Append(_quantityData.CostItemID +",'"+_quantityData.ReportPhase+"','"+_quantityData.ReportContract+"','"+_quantityData.Accounting +"')");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }

            catch { }

        }

        public void Copy(IDIGITALTEKGRID.QuantityData _quantityData)
        {
            StringBuilder strSQL = new StringBuilder();

            _quantityData.Quantity = 0;
            _quantityData.RunDateTime = System.DateTime.Now;


            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" INSERT INTO Quantity ( Division_Quantity, [DivisionCost_Quantity], ");
            strSQL.Append(" [QuantityAdjusted], QuantityRoundUp, QuantityReuse, QuantityWaste,  ");
            strSQL.Append(" [DivisionPrint_Quantity], Units, Location, Description_Quantity, ExpressionID, ");
            strSQL.Append(" AssemblyID, Active_Quantity, Quantity, RunDateTime, [Memo_Quantity],   CostItemID , ReportPhase, ReportContract, Accounting) ");
            strSQL.Append(" VALUES ('" + _quantityData.Division + "','" + _quantityData.DivisionCost + "',");

            strSQL.Append(_quantityData.QuantityAdjusted + "," + _quantityData.QuantityRoundUp + ",");
            strSQL.Append(_quantityData.QuantityReuse + "," + _quantityData.QuantityWaste + ",");

            strSQL.Append("'" + _quantityData.DivisionPrint + "','" + _quantityData.Units + "',");
            strSQL.Append("'" + _quantityData.Location + "',' Copy " + _quantityData.Description + "',");
            strSQL.Append(_quantityData.ExpressionID + "," + _quantityData.AssemblyID + ", ");
            strSQL.Append(_quantityData.Active + "," + _quantityData.Quantity + ",'");
            strSQL.Append(_quantityData.RunDateTime + "','" + _quantityData.Memo + "',");

            strSQL.Append(_quantityData.CostItemID + ",'" + _quantityData.ReportPhase + "','" + _quantityData.ReportContract + "','" + _quantityData.Accounting + "')");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }

            catch { }

        }

        public void update(IDIGITALTEKGRID.QuantityData _quantityData)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();


            _quantityData.Quantity = 0;
            _quantityData.RunDateTime = System.DateTime.Now;

            strSQL.Append("UPDATE Quantity SET ");
            strSQL.Append(" QuantityAdjusted = " + _quantityData.QuantityAdjusted + ", [QuantityRoundUp] = " + _quantityData.QuantityRoundUp + ",");
            strSQL.Append(" QuantityWaste = " + _quantityData.QuantityWaste+ ", [QuantityReuse] = " + _quantityData.QuantityReuse + ",");
            strSQL.Append(" Division_Quantity = '" + _quantityData.Division + "', [DivisionCost_Quantity] = '" + _quantityData.DivisionCost + "',");
            strSQL.Append(" [DivisionPrint_Quantity] = '" + _quantityData.DivisionPrint + "', Units = '" + _quantityData.Units + "',");
            strSQL.Append(" Location = '" + _quantityData.Location + "', Description_Quantity = '" + _quantityData.Description + "',");
            strSQL.Append(" ExpressionID = " + _quantityData.ExpressionID + ", AssemblyID = " + _quantityData.AssemblyID + " , ");
            strSQL.Append(" Active_Quantity = " + _quantityData.Active + ", Quantity = " + _quantityData.Quantity + ",");
            strSQL.Append(" RunDateTime = '" + _quantityData.RunDateTime + "', [Memo_Quantity] = '" + _quantityData.Memo + "', CostItemID =" + _quantityData.CostItemID);
            strSQL.Append(", ReportContract = '" + _quantityData.ReportContract + "', ReportPhase = '" + _quantityData.ReportPhase + "', Accounting ='" + _quantityData.Accounting+"'");
           
            strSQL.Append(" WHERE QuantityID = " + _quantityData.QuantityID);
           // strSQL.Append(" AND JobID = " + _quantityData.JobID);
            try
            {

                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }

        }

        public void delete(IDIGITALTEKGRID.QuantityData _quantityData)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" DELETE * FROM  Quantity WHERE QuantityID=" + _quantityData.QuantityID);

            _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
        }


        public DataSet selectDivisionData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  QuantityID, Division_Quantity,DivisionCost_Quantity, ");
            strSQL.Append(" DivisionPrint_Quantity, Units, Location, Description_Quantity,ExpressionID, AssemblyID,");
            strSQL.Append("  Active_Quantity, Quantity, RunDateTime, Memo_Quantity, CostItemID,");
            strSQL.Append("   ReportContract,  ReportPhase , QuantityAdjusted, QuantityRoundUp, QuantityReuse, QuantityWaste, ");
            strSQL.Append("  Quantity.QuantityReuse ,Quantity.QuantityWaste, Quantity.Accounting ");
            strSQL.Append(" FROM Quantity WHERE Division_Quantity ='" + _id + "'");
            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            return dsData;
        }


        public IDIGITALTEKGRID.QuantityDatas selectDivision(string _id)
        {
            DataSet dsData = this.selectDivisionData(_id);

            IDIGITALTEKGRID.QuantityDatas _QuantityDatas = new IDIGITALTEKGRID.QuantityDatas();
            int i = 0;
            foreach (DataRow row in dsData.Tables[0].Rows)
            {

                IDIGITALTEKGRID.Builder.progressEstimate.Increment(15);


                IDIGITALTEKGRID.QuantityData _quantityData = new IDIGITALTEKGRID.QuantityData();

                i += 1;
                _quantityData.NumbID = i;
                _quantityData.ItemID = Convert.ToInt32(row["QuantityID"].ToString());
                _quantityData.QuantityID = Convert.ToInt32(row["QuantityID"].ToString());
                _quantityData.Division = row["Division_Quantity"].ToString();
                _quantityData.DivisionCost = row["DivisionCost_Quantity"].ToString();
                _quantityData.DivisionPrint = row["DivisionPrint_Quantity"].ToString();
                _quantityData.Units = row["Units"].ToString();
                _quantityData.Location = row["Location"].ToString();
                _quantityData.Description = row["Description_Quantity"].ToString();
                _quantityData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
                _quantityData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
                _quantityData.Active = (bool)row["Active_Quantity"];

                _quantityData.Memo = row["Memo_Quantity"].ToString();
                _quantityData.Accounting = row["Accounting"].ToString();

                _quantityData.ReportPhase = row["ReportPhase"].ToString();
                _quantityData.ReportContract = row["ReportContract"].ToString();
                try
                {
                    _quantityData.QuantityAdjusted = Convert.ToDecimal(row["QuantityAdjusted"].ToString());
                    _quantityData.QuantityReuse = Convert.ToDecimal(row["QuantityReuse"].ToString());
                    _quantityData.QuantityRoundUp = Convert.ToDecimal(row["QuantityRoundUp"].ToString());
                    _quantityData.QuantityWaste = Convert.ToDecimal(row["QuantityWaste"].ToString());
                }
                catch { }

                _quantityData.Quantity = 0;

                _quantityData.RunDateTime = System.DateTime.Now;

                try
                {
                    _quantityData.CostItemID = Convert.ToInt32(row["CostItemID"].ToString());
                }
                catch
                {
                    _quantityData.CostItemID = 0;
                }
                _QuantityDatas.Add(_quantityData);
            }
            return _QuantityDatas;
        }

        public DataSet selectDivisionData()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  QuantityID, Division_Quantity,DivisionCost_Quantity, ");
            strSQL.Append(" DivisionPrint_Quantity, Units, Location, Description_Quantity,ExpressionID, AssemblyID,");
            strSQL.Append("  Active_Quantity, Quantity, RunDateTime, Memo_Quantity, CostItemID, Accounting, ");
            strSQL.Append("   ReportContract,  ReportPhase , QuantityAdjusted, QuantityRoundUp, QuantityReuse, QuantityWaste ");
            strSQL.Append(" FROM Quantity ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            return dsData;

        }
        public IDIGITALTEKGRID.QuantityDatas selectDivision()
        {
            DataSet dsData = this.selectDivisionData();

            IDIGITALTEKGRID.QuantityDatas _QuantityDatas = new IDIGITALTEKGRID.QuantityDatas();

            int i = 0;
            foreach (DataRow row in dsData.Tables[0].Rows)
            {

                IDIGITALTEKGRID.Builder.progressEstimate.Increment(15);


                IDIGITALTEKGRID.QuantityData _quantityData = new IDIGITALTEKGRID.QuantityData();

                i += 1;
                _quantityData.NumbID = i;
                _quantityData.ItemID = Convert.ToInt32(row["QuantityID"].ToString());
                _quantityData.QuantityID = Convert.ToInt32(row["QuantityID"].ToString());
                _quantityData.Division = row["Division_Quantity"].ToString();
                _quantityData.DivisionCost = row["DivisionCost_Quantity"].ToString();
                _quantityData.DivisionPrint = row["DivisionPrint_Quantity"].ToString();
                _quantityData.Units = row["Units"].ToString();
                _quantityData.Location = row["Location"].ToString();
                _quantityData.Description = row["Description_Quantity"].ToString();
                _quantityData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
                _quantityData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
                _quantityData.Active = (bool)row["Active_Quantity"];
                _quantityData.Memo = row["Memo_Quantity"].ToString();
                _quantityData.ReportPhase = row["ReportPhase"].ToString();
                _quantityData.ReportContract = row["ReportContract"].ToString();

                _quantityData.Accounting = row["Accounting"].ToString();
                try
                {
                    _quantityData.QuantityAdjusted = Convert.ToDecimal(row["QuantityAdjusted"].ToString());
                    _quantityData.QuantityReuse = Convert.ToDecimal(row["QuantityReuse"].ToString());
                    _quantityData.QuantityRoundUp = Convert.ToDecimal(row["QuantityRoundUp"].ToString());
                    _quantityData.QuantityWaste = Convert.ToDecimal(row["QuantityWaste"].ToString());
                }
                catch { }

                _quantityData.Quantity = 0;
             
                _quantityData.RunDateTime = System.DateTime.Now;

                try
                {
                    _quantityData.CostItemID = Convert.ToInt32(row["CostItemID"].ToString());
                }
                catch
                {
                    _quantityData.CostItemID = 0;
                }
                _QuantityDatas.Add(_quantityData);
            }
            return _QuantityDatas;
        }


        public DataSet selectData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            int k = _id.IndexOf("-");
            if (k > 0)
            { _id = _id.Substring(0, k); }

            strSQL.Append(" SELECT DISTINCT Quantity.QuantityID, Quantity.Division_Quantity,");
            strSQL.Append(" Quantity.DivisionCost_Quantity, Quantity.DivisionPrint_Quantity,");
            strSQL.Append(" Quantity.Units, Quantity.Location, Quantity.Description_Quantity,");
            strSQL.Append(" Quantity.ExpressionID, Quantity.AssemblyID, Quantity.Active_Quantity,");
            strSQL.Append(" Quantity.Quantity, Quantity.RunDateTime, Quantity.Memo_Quantity,");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.CostItemID ,Quantity.ReportContract,  Quantity.ReportPhase, Quantity.Accounting FROM Takeoff  ");
            strSQL.Append(" INNER JOIN (Matrix INNER JOIN Quantity ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" ON Takeoff.TakeOffID = Matrix.Value");
            strSQL.Append(" WHERE Matrix.Key=3 AND Takeoff.JobID=" + _id);
            //  strSQL.Append(" AND Quantity.Quantity <> " +IDIGITALTEKGRID.Operators.Calculate("+ Quantity.ExpressionID +", _id)") ;

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

            return dsData;
        }

        public IDIGITALTEKGRID.QuantityDatas select(string _id)
        {
            DataSet dsData = this.selectData(_id);

            int k = _id.IndexOf("-");
            if (k > 0)
            { _id = _id.Substring(0, k); }

            IDIGITALTEKGRID.QuantityDatas _QuantityDatas = new IDIGITALTEKGRID.QuantityDatas();
            
            int i = 0;
            foreach (DataRow row in dsData.Tables[0].Rows)
            {
                string _expressionID = row["ExpressionID"].ToString();

                IDIGITALTEKGRID.Builder.progressEstimate.Increment(15);

                    IDIGITALTEKGRID.QuantityData _quantityData = new IDIGITALTEKGRID.QuantityData();
                    i += 1;
                    _quantityData.NumbID = i;
                    _quantityData.ItemID = Convert.ToInt32(row["QuantityID"].ToString());
                    _quantityData.QuantityID = Convert.ToInt32(row["QuantityID"].ToString());
                    _quantityData.Division = row["Division_Quantity"].ToString();
                    _quantityData.DivisionCost = row["DivisionCost_Quantity"].ToString();
                    _quantityData.DivisionPrint = row["DivisionPrint_Quantity"].ToString();
                    _quantityData.Units = row["Units"].ToString();
                    _quantityData.Location = row["Location"].ToString();
                    _quantityData.Description = row["Description_Quantity"].ToString();
                    _quantityData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
                    _quantityData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
                    _quantityData.Active = (bool)row["Active_Quantity"];

                    _quantityData.Memo = row["Memo_Quantity"].ToString();
                    _quantityData.ReportPhase = row["ReportPhase"].ToString();
                    _quantityData.ReportContract = row["ReportContract"].ToString();
                    _quantityData.Accounting = row["Accounting"].ToString();

                    try
                    {
                        _quantityData.QuantityAdjusted = Convert.ToDecimal(row["QuantityAdjusted"].ToString());
                        _quantityData.QuantityReuse = Convert.ToDecimal(row["QuantityReuse"].ToString());
                        _quantityData.QuantityRoundUp = Convert.ToDecimal(row["QuantityRoundUp"].ToString());
                        _quantityData.QuantityWaste = Convert.ToDecimal(row["QuantityWaste"].ToString());
                    }
                    catch { }


                    _quantityData.Quantity = IDIGITALTEKGRID.Operators.Calculate(_quantityData.ExpressionID.ToString(), _id); ;

                    _quantityData.QuantityOrdered = IDIGITALTEKGRID.Operators.getQuantityOrdered(_quantityData.Quantity, _quantityData.QuantityAdjusted, _quantityData.QuantityReuse, _quantityData.QuantityWaste, _quantityData.QuantityRoundUp);

                    if (_quantityData.Quantity == -999)
                    {

                        _quantityData.Description = "N/A Check Expression for missing takeoff or zero takeoff value";
                        _quantityData.Memo = "N/A Check Expression for missing takeoff or zero takeoff value";
                       
                    }
                    _quantityData.RunDateTime = System.DateTime.Now;

                    try
                    {
                        _quantityData.CostItemID = Convert.ToInt32(row["CostItemID"].ToString());
                    }
                    catch
                    {
                        _quantityData.CostItemID = 0;
                    }
                    _QuantityDatas.Add(_quantityData);
                }
         
            return _QuantityDatas;
        }


        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            DataSet dsData;
            strSQL.Append(" SELECT DISTINCT Quantity.QuantityID, Quantity.Division_Quantity,");
            strSQL.Append(" Quantity.DivisionCost_Quantity, Quantity.DivisionPrint_Quantity,");
            strSQL.Append(" Quantity.Units, Quantity.Location, Quantity.Description_Quantity,");
            strSQL.Append(" Quantity.ExpressionID, Quantity.AssemblyID, Quantity.Active_Quantity,");
            strSQL.Append(" Quantity.Quantity, Quantity.RunDateTime, Quantity.Memo_Quantity,");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.CostItemID,  Quantity.ReportContract,  Quantity.ReportPhase, Quantity.Accounting FROM Takeoff  ");
            strSQL.Append(" INNER JOIN (Matrix INNER JOIN Quantity ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" ON Takeoff.TakeOffID = Matrix.Value");
            strSQL.Append(" WHERE Matrix.Key=3;");

            try
            {


                dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
                return dsData;
            }
            catch
            {
                return null;
            }
        }
        public IDIGITALTEKGRID.QuantityDatas select()
        {
            DataSet dsData = this.selectData();

            IDIGITALTEKGRID.QuantityDatas _QuantityDatas = new IDIGITALTEKGRID.QuantityDatas();

            int i = 0;
            foreach (DataRow row in dsData.Tables[0].Rows)
            {
                IDIGITALTEKGRID.QuantityData _quantityData = new IDIGITALTEKGRID.QuantityData();

                i += 1;
                _quantityData.NumbID = i;
                _quantityData.ItemID = Convert.ToInt32(row["QuantityID"].ToString());

                try
                {
                    _quantityData.QuantityAdjusted = Convert.ToDecimal(row["QuantityAdjusted"].ToString());
                    _quantityData.QuantityReuse = Convert.ToDecimal(row["QuantityReuse"].ToString());
                    _quantityData.QuantityRoundUp = Convert.ToDecimal(row["QuantityRoundUp"].ToString());
                    _quantityData.QuantityWaste = Convert.ToDecimal(row["QuantityWaste"].ToString());
                }
                catch { }


                _quantityData.QuantityID = Convert.ToInt32(row["QuantityID"].ToString());
                _quantityData.Division = row["Division_Quantity"].ToString();
                _quantityData.DivisionCost = row["DivisionCost_Quantity"].ToString();
                _quantityData.DivisionPrint = row["DivisionPrint_Quantity"].ToString();
                _quantityData.Units = row["Units"].ToString();
                _quantityData.Location = row["Location"].ToString();
                _quantityData.Description = row["Description_Quantity"].ToString();
                _quantityData.ExpressionID = Convert.ToInt32(row["ExpressionID"].ToString());
                _quantityData.AssemblyID = Convert.ToInt32(row["AssemblyID"].ToString());
                _quantityData.Active = (bool)row["Active_Quantity"];

                _quantityData.Memo = row["Memo_Quantity"].ToString();
                _quantityData.ReportPhase = row["ReportPhase"].ToString();
                _quantityData.ReportContract = row["ReportContract"].ToString();
                _quantityData.Accounting = row["Accounting"].ToString();
           

                _quantityData.Quantity = 0;
                _quantityData.RunDateTime = System.DateTime.Now;

                try
                {
                    _quantityData.CostItemID = Convert.ToInt32(row["CostItemID"].ToString());
                }
                catch
                {
                    _quantityData.CostItemID = 0;
                }
                _QuantityDatas.Add(_quantityData);
            }
            return _QuantityDatas;
        }
    }
}