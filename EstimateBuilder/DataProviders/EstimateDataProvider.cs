using System.Text;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for R.
	/// </summary>
	public class EstimateDataProvider
	{
		public EstimateDataProvider()
		{

		}

        public DataSet selectMinFavoritesData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, Assembly.Description AS AssemblyID, ");
            strSQL.Append(" CostItem.MinimumOrder, CostAmount.CostAmountID, Min(CostAmount.CostAmount_costAmt) AS CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, ");
            strSQL.Append(" Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, ");
            strSQL.Append(" Quantity.DivisionPrint_Quantity, Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, ");
            strSQL.Append("  CostItem.Description_costItem, CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, ");
            strSQL.Append(" Quantity.ReportPhase, Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ON CostItem.CostItemID = Quantity.CostItemID) ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ON Takeoff.TakeOffID = Matrix.Value) ");
            strSQL.Append(" ON Contact.ContactID = CostAmount.VendorID) ON Contact_1.ContactID = CostAmount.ManufactureID) ");
            strSQL.Append(" ON (Expression.ExpressionID = Quantity.ExpressionID) AND (Expression.ExpressionID = Matrix.ExpressionID)) ");
            strSQL.Append(" ON Job.JobID = Takeoff.JobID) ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");
            strSQL.Append(" GROUP BY Takeoff.JobID, Contact_4.Company, Contact_3.Company, Job.ProjectName, Job.Description, Job.LocationZip, ");
            strSQL.Append(" Quantity.Description_Quantity, Quantity.QuantityID, Expression.Description, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company, CostAmount.VendorID, Contact.Company, Contact_1.Company, CostItem.GenericVendor, ");
            strSQL.Append(" CostAmount.Date, Assembly.Description, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, Quantity.Units, ");
            strSQL.Append(" Quantity.Location, Job.ProjectName ");

            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                    strSQL.Append(" HAVING (((Job.ProjectName)=" + id[0].ToString() + "))");
                    strSQL.Append("  AND (((CostAmount.VendorID) ");
                    strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                    strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" HAVING CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                    strSQL.Append("  AND (((CostAmount.VendorID) ");
                    strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                    strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public DataSet selectMaxFavoritesData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, Assembly.Description AS AssemblyID, ");
            strSQL.Append(" CostItem.MinimumOrder, CostAmount.CostAmountID, Max(CostAmount.CostAmount_costAmt) AS CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, ");
            strSQL.Append(" Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, ");
            strSQL.Append(" Quantity.DivisionPrint_Quantity, Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, ");
            strSQL.Append("  CostItem.Description_costItem, CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, ");
            strSQL.Append(" Quantity.ReportPhase, Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ON CostItem.CostItemID = Quantity.CostItemID) ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ON Takeoff.TakeOffID = Matrix.Value) ");
            strSQL.Append(" ON Contact.ContactID = CostAmount.VendorID) ON Contact_1.ContactID = CostAmount.ManufactureID) ");
            strSQL.Append(" ON (Expression.ExpressionID = Quantity.ExpressionID) AND (Expression.ExpressionID = Matrix.ExpressionID)) ");
            strSQL.Append(" ON Job.JobID = Takeoff.JobID) ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");
            strSQL.Append(" GROUP BY Takeoff.JobID, Contact_4.Company, Contact_3.Company, Job.ProjectName, Job.Description, Job.LocationZip, ");
            strSQL.Append(" Quantity.Description_Quantity, Quantity.QuantityID, Expression.Description, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company, CostAmount.VendorID, Contact.Company, Contact_1.Company, CostItem.GenericVendor, ");
            strSQL.Append(" CostAmount.Date, Assembly.Description, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, Quantity.Units, ");
            strSQL.Append(" Quantity.Location, Job.ProjectName ");


            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                    strSQL.Append(" HAVING(((Job.ProjectName)=" + id[0].ToString() + "))");
                    strSQL.Append("  AND (((CostAmount.VendorID) ");
                    strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                    strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" HAVING CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                    strSQL.Append("  AND (((CostAmount.VendorID) ");
                    strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                    strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }



        public DataSet selectAllFavoritesData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, ");
            strSQL.Append(" Assembly.Description AS AssemblyID, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.CostAmount_costAmt, CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, ");
            strSQL.Append(" Quantity.Active_Quantity, Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, ");
            strSQL.Append(" Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, ");
            strSQL.Append(" Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ");
            strSQL.Append(" ON CostItem.CostItemID = Quantity.CostItemID) ON Matrix.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" ON Takeoff.TakeOffID = Matrix.Value) ON Contact.ContactID = CostAmount.VendorID) ");
            strSQL.Append(" ON Contact_1.ContactID = CostAmount.ManufactureID) ON (Expression.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" AND (Expression.ExpressionID = Matrix.ExpressionID)) ON Job.JobID = Takeoff.JobID) ");
            strSQL.Append(" ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");

            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                     strSQL.Append(" WHERE (((Job.ProjectName)=" + id[0].ToString() + "))");
                     strSQL.Append("  AND (((CostAmount.VendorID) ");
                     strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                     strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" WHERE CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                    strSQL.Append("  AND (((CostAmount.VendorID) ");
                    strSQL.Append(" In (Select Child FROM Preference WHERE Parent = ");
                    strSQL.Append(" (select OwnerID From Job where JobID =" + id[0].ToString() + "))))");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }


        public DataSet selectMaxData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, Assembly.Description AS AssemblyID, ");
            strSQL.Append(" CostItem.MinimumOrder, CostAmount.CostAmountID, Max(CostAmount.CostAmount_costAmt) AS CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, ");
            strSQL.Append(" Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, ");
            strSQL.Append(" Quantity.DivisionPrint_Quantity, Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, ");
            strSQL.Append("  CostItem.Description_costItem, CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, ");
            strSQL.Append(" Quantity.ReportPhase, Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ON CostItem.CostItemID = Quantity.CostItemID) ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ON Takeoff.TakeOffID = Matrix.Value) ");
            strSQL.Append(" ON Contact.ContactID = CostAmount.VendorID) ON Contact_1.ContactID = CostAmount.ManufactureID) ");
            strSQL.Append(" ON (Expression.ExpressionID = Quantity.ExpressionID) AND (Expression.ExpressionID = Matrix.ExpressionID)) ");
            strSQL.Append(" ON Job.JobID = Takeoff.JobID) ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");
            strSQL.Append(" GROUP BY Takeoff.JobID, Contact_4.Company, Contact_3.Company, Job.ProjectName, Job.Description, Job.LocationZip, ");
            strSQL.Append(" Quantity.Description_Quantity, Quantity.QuantityID, Expression.Description, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company, CostAmount.VendorID, Contact.Company, Contact_1.Company, CostItem.GenericVendor, ");
            strSQL.Append(" CostAmount.Date, Assembly.Description, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, Quantity.Units, ");
            strSQL.Append(" Quantity.Location, Job.ProjectName ");




            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                    strSQL.Append(" HAVING (((Job.ProjectName)=" + id[0].ToString() + "))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" HAVING CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }


        public DataSet selectMinData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();


            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, Assembly.Description AS AssemblyID, ");
            strSQL.Append(" CostItem.MinimumOrder, CostAmount.CostAmountID, Min(CostAmount.CostAmount_costAmt) AS CostAmount_costAmt, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, ");
            strSQL.Append(" Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, ");
            strSQL.Append(" Quantity.DivisionPrint_Quantity, Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, ");
            strSQL.Append("  CostItem.Description_costItem, CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, ");
            strSQL.Append(" CostItem.DivisionCost_costItem, CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, ");
            strSQL.Append(" Quantity.ReportPhase, Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ON CostItem.CostItemID = Quantity.CostItemID) ");
            strSQL.Append(" ON Matrix.ExpressionID = Quantity.ExpressionID) ON Takeoff.TakeOffID = Matrix.Value) ");
            strSQL.Append(" ON Contact.ContactID = CostAmount.VendorID) ON Contact_1.ContactID = CostAmount.ManufactureID) ");
            strSQL.Append(" ON (Expression.ExpressionID = Quantity.ExpressionID) AND (Expression.ExpressionID = Matrix.ExpressionID)) ");
            strSQL.Append(" ON Job.JobID = Takeoff.JobID) ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");
            strSQL.Append(" GROUP BY Takeoff.JobID, Contact_4.Company, Contact_3.Company, Job.ProjectName, Job.Description, Job.LocationZip, ");
            strSQL.Append(" Quantity.Description_Quantity, Quantity.QuantityID, Expression.Description, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company, CostAmount.VendorID, Contact.Company, Contact_1.Company, CostItem.GenericVendor, ");
            strSQL.Append(" CostAmount.Date, Assembly.Description, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, Quantity.Active_Quantity, Quantity.QuantityAdjusted, ");
            strSQL.Append(" Quantity.QuantityRoundUp, Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, Quantity.Units, ");
            strSQL.Append(" Quantity.Location, Job.ProjectName ");

            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                    strSQL.Append(" HAVING (((Job.ProjectName)=" + id[0].ToString() + "))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" HAVING CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public DataSet  selectAllData(string _id)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

  
            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Contact_4.Company AS Job, Contact_3.Company AS Project, ");
            strSQL.Append(" Job.ProjectName, Job.Description, Job.LocationZip, Quantity.Description_Quantity, ");
            strSQL.Append(" Quantity.QuantityID, Expression.Description AS Expression, Expression.ExpressionID, ");
            strSQL.Append(" Contact_2.Company AS OwnerID, CostAmount.VendorID AS PreferenceID, Contact.Company AS VendorID, ");
            strSQL.Append(" Contact_1.Company AS ManufactureID, CostItem.GenericVendor, CostAmount.Date, ");
            strSQL.Append(" Assembly.Description AS AssemblyID, CostItem.MinimumOrder, CostAmount.CostAmountID, ");
            strSQL.Append(" CostAmount.CostAmount_costAmt, CostAmount.PieceUnitOrder_costAmt, CostItem.CostAdjustment, ");
            strSQL.Append(" Quantity.Active_Quantity, Quantity.QuantityAdjusted, Quantity.QuantityRoundUp, ");
            strSQL.Append(" Quantity.QuantityReuse, Quantity.QuantityWaste, Quantity.DivisionPrint_Quantity, ");
            strSQL.Append(" Quantity.Quantity, CostAmount.User, CostAmount.BuildingType_costAmt, CostItem.Description_costItem, ");
            strSQL.Append(" CostItem.CostItemID, CostAmount.ZipCode, CostItem.Division_costItem, CostItem.DivisionCost_costItem, ");
            strSQL.Append(" CostItem.CostType, CostItem.UnitOrder, Quantity.ReportContract, Quantity.ReportPhase, ");
            strSQL.Append(" Quantity.Units, Quantity.Location ");
            strSQL.Append(" FROM Contact AS Contact_4 INNER JOIN (Contact AS Contact_3 INNER JOIN (Contact AS Contact_2 ");
            strSQL.Append(" INNER JOIN (Assembly INNER JOIN (Job INNER JOIN (Expression INNER JOIN (Contact AS Contact_1 ");
            strSQL.Append(" RIGHT JOIN (Contact RIGHT JOIN (Takeoff INNER JOIN (Matrix INNER JOIN ((CostItem LEFT JOIN CostAmount ");
            strSQL.Append(" ON CostItem.CostItemID = CostAmount.CostItemID) INNER JOIN Quantity ");
            strSQL.Append(" ON CostItem.CostItemID = Quantity.CostItemID) ON Matrix.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" ON Takeoff.TakeOffID = Matrix.Value) ON Contact.ContactID = CostAmount.VendorID) ");
            strSQL.Append(" ON Contact_1.ContactID = CostAmount.ManufactureID) ON (Expression.ExpressionID = Quantity.ExpressionID) ");
            strSQL.Append(" AND (Expression.ExpressionID = Matrix.ExpressionID)) ON Job.JobID = Takeoff.JobID) ");
            strSQL.Append(" ON Assembly.AssemblyID = Quantity.AssemblyID) ON Contact_2.ContactID = Job.OwnerID) ");
            strSQL.Append(" ON Contact_3.ContactID = Job.ProjectName) ON Contact_4.ContactID = Job.ContactID_Job ");
  
            const char del1 = '-';
            char[] delimiter = new char[] { del1 };

            String[] id = _id.Split(delimiter);
            if (id.Length > 1)
            {

                if (id[0].ToString() != "0")
                {
                    strSQL.Append(" WHERE (((Job.ProjectName)=" + id[0].ToString() + "))");
                }
                else if (id[1].ToString() != "All")
                {
                    strSQL.Append(" WHERE CostAmount.BuildingType_costAmt ='" + id[1].ToString() + "' ");
                }
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public DataTable selectExport(string _id, int _report)
        {
            DataTable dsTable = new DataTable();

            for (int k = 0; k < 45; k++)
            {
               dsTable.Columns.Add();

            }

                dsTable.Columns[0].ColumnName = "Active";
                dsTable.Columns[1].ColumnName = "JobID" ;
                dsTable.Columns[2].ColumnName = "VendorID" ;
                dsTable.Columns[3].ColumnName = "ManufactureID";
                dsTable.Columns[4].ColumnName = "GenericVendor";
                dsTable.Columns[5].ColumnName = "CostItemID";
                dsTable.Columns[6].ColumnName = "QuantityID";
                dsTable.Columns[7].ColumnName = "ItemID";
                dsTable.Columns[8].ColumnName = "ExpressionID";
                dsTable.Columns[9].ColumnName = "Expression";
                dsTable.Columns[10].ColumnName = "AssemblyID";
                dsTable.Columns[11].ColumnName = "CostAmountID";
                dsTable.Columns[12].ColumnName = "CostAmt";
                dsTable.Columns[13].ColumnName = "CostAdjustment";
                dsTable.Columns[14].ColumnName = "QuantityAdjustment";
                dsTable.Columns[15].ColumnName = "CostAdjusted";
                dsTable.Columns[16].ColumnName = "EstimateCost";
                dsTable.Columns[17].ColumnName = "QuantityRoundUp";
                dsTable.Columns[18].ColumnName = "QuantityReuse";
                dsTable.Columns[19].ColumnName = "QuantityWaste";
                dsTable.Columns[20].ColumnName = "QuantityMinimum";
                dsTable.Columns[21].ColumnName = "Quantity";
                dsTable.Columns[22].ColumnName = "RunDateTime";
                dsTable.Columns[23].ColumnName = "Date";
                dsTable.Columns[24].ColumnName = "User";
                dsTable.Columns[25].ColumnName = "BuildingType";
                dsTable.Columns[26].ColumnName = "ItemDescription";
                dsTable.Columns[27].ColumnName = "ZipCode";
                dsTable.Columns[28].ColumnName = "Division";
                dsTable.Columns[29].ColumnName = "DivisionCost";
                dsTable.Columns[30].ColumnName = "DivisionPrint";
                dsTable.Columns[31].ColumnName = "Memo";
                dsTable.Columns[32].ColumnName = "PhotoCad";
                dsTable.Columns[33].ColumnName = "PhotoImage";
                dsTable.Columns[34].ColumnName = "CostType";
                dsTable.Columns[35].ColumnName = "UnitOrder";
                dsTable.Columns[36].ColumnName = "ReportPhase";
                dsTable.Columns[37].ColumnName = "ReportContract";
                dsTable.Columns[38].ColumnName = "Units";
                dsTable.Columns[39].ColumnName = "Location";
                dsTable.Columns[40].ColumnName = "PiecePerUnitOrder";
                dsTable.Columns[41].ColumnName = "NumbID";
                dsTable.Columns[42].ColumnName = "job";
                dsTable.Columns[43].ColumnName = "Owner";
                dsTable.Columns[44].ColumnName = "Project";

            

                EstimateBuilder.EstimateDatas _estimateDatas = new EstimateDatas();
                _estimateDatas = this.select(_id,_report);

                ArrayList _estimate =  (ArrayList)_estimateDatas;
     
                System.Collections.IEnumerator enumerator = _estimate.GetEnumerator();
                while (enumerator.MoveNext())
               {
                   EstimateBuilder.EstimateData _value = (EstimateBuilder.EstimateData)enumerator.Current;
                   dsTable.Rows.Add(_value.getValue());
                
                }

                return dsTable;
        }


        //TODO Switch to selct dataset and check for all field id to display value
        public  EstimateBuilder.EstimateDatas select(string _id, int _report)
		{

          //   "All Vendors",
          //  "Premium Vendors",
          //  "Discount Vendors",
          //  "All Favorites Vendors",
          //  "Premium Favorites Vendors",
          //  "Discount Favorites Vendors"

            DataSet dsData = null;
            if (_report == 0)
            {
                dsData = this.selectAllData(_id);
            }
            else if (_report == 1)
            {
                dsData = this.selectMaxData(_id);
            }
            else if (_report == 2)
            {
                dsData = this.selectMinData(_id);
            }
            else if (_report == 3)
            {
                dsData = this.selectAllFavoritesData(_id);
            }
            else if (_report == 4)
            {
                dsData = this.selectMaxFavoritesData(_id);
            }
            else if (_report == 5)
            {
                dsData = this.selectMinFavoritesData(_id);
            }
            else
            {
                dsData = null;
            }
            


            EstimateBuilder.EstimateDatas _estimateDatas = new EstimateBuilder.EstimateDatas();

      

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    string _expressionID = row["ExpressionID"].ToString();
                    string _JobID = row["JobID"].ToString();
                    decimal _quantityValue = EstimateBuilder.Operators.Calculate(_expressionID, _JobID);

                    if (_quantityValue  != -999)
                    {
                        EstimateBuilder.Builder.progressEstimate.Increment(10);
                        EstimateBuilder.EstimateData _estimateData = new EstimateBuilder.EstimateData();


                        _estimateData.JobID = _JobID+"-"+row["Job"].ToString();
                        try
                        {
                            _estimateData.VendorID = row["VendorID"].ToString();
                        }
                        catch
                        {
                            _estimateData.VendorID = null;
                        }

                        try
                        {
                            _estimateData.ManufactureID = row["ManufactureID"].ToString();
                        }
                        catch
                        {
                            _estimateData.ManufactureID = null;
                        }

                        try
                        {
                            _estimateData.CostAmt = Convert.ToDecimal(row["CostAmount_costAmt"]);
                        }
                        catch
                        {
                            _estimateData.CostAmt = 0;
                        }
                        try
                        {
                            _estimateData.CostAmountID = Convert.ToInt32(row["CostAmountID"]);
                        }
                        catch
                        {
                            _estimateData.CostAmountID = 0;
                        }

                        try
                        {
                            _estimateData.PiecePerUnitOrder = Convert.ToDecimal(row["PieceUnitOrder_costAmt"]);
                        }
                        catch
                        {
                            _estimateData.PiecePerUnitOrder = 0;
                        }


                        try
                        {
                            _estimateData.BuildingType = row["BuildingType_costAmt"].ToString();
                        }
                        catch
                        {
       
                        }
     
                        _estimateData.ProviderID = row["GenericVendor"].ToString();
                        _estimateData.CostItemID = Convert.ToInt32(row["CostItemID"]);
                        _estimateData.QuantityID = row["Description_Quantity"].ToString();
                        _estimateData.UnitOrder = row["UnitOrder"].ToString();
                        _estimateData.LocationZipCode = row["LocationZip"].ToString();
                        _estimateData.ExpressionID = row["ExpressionID"].ToString();
                        _estimateData.Expression = row["Expression"].ToString();

                        try                
                        {
                            _estimateData.AssemblyID = Convert.ToInt32(row["AssemblyID"]);  
                        }
                        catch{}

                        try
                        {
                            _estimateData.User = row["User"].ToString();

                        }
                        catch { }

                        try
                        {
                            _estimateData.ZipCode = row["ZipCode"].ToString();
                        }
                        catch { }

                        try
                        {
                            _estimateData.Date = Convert.ToDateTime(row["Date"].ToString());
                        }
                        catch { }
                       
                        _estimateData.Active = Convert.ToBoolean(row["Active_Quantity"]);

                        
                      
                        _estimateData.CostAdjustment = Convert.ToDecimal(row["CostAdjustment"]);
                        _estimateData.QuantityRoundUp = Convert.ToDecimal(row["QuantityRoundUp"]);
                        _estimateData.QuantityReuse = Convert.ToDecimal(row["QuantityReuse"]);
                        _estimateData.QuantityWaste = Convert.ToDecimal(row["QuantityWaste"]);
                        _estimateData.QuantityMinimum = Convert.ToDecimal(row["MinimumOrder"]);
                        try
                        {
                            _estimateData.Quantity = EstimateBuilder.Operators.multiplyValues(_quantityValue, Convert.ToDecimal(row["QuantityAdjusted"]));
                        }
                        catch
                        {
                            _estimateData.Quantity = _quantityValue;
                        }
                         _estimateData.QuantityAdjustment = EstimateBuilder.Operators.quantityAdjustment(_estimateData.PiecePerUnitOrder, _estimateData.Quantity, _estimateData.QuantityMinimum, _estimateData.QuantityRoundUp, _estimateData.QuantityReuse, _estimateData.QuantityWaste);
                         _estimateData.CostAdjusted = EstimateBuilder.Operators.multiplyValues(_estimateData.CostAdjustment, _estimateData.CostAmt);
                         _estimateData.EstimateCost = EstimateBuilder.Operators.multiplyValues(_estimateData.QuantityAdjustment, _estimateData.CostAdjusted);
               
               
                        _estimateData.Description = row["Description_costItem"].ToString();                       
                        _estimateData.Division = row["Division_costItem"].ToString();
                        _estimateData.DivisionCost = row["DivisionCost_costItem"].ToString();
                        _estimateData.DivisionPrint = row["DivisionPrint_Quantity"].ToString();
                        // _estimateData.Memo  = row["Memo_costAmt"].ToString();
                        // _estimateData.PhotoCad  = null;
                        // _estimateData.PhotoImage  = null;
                        _estimateData.CostType = row["CostType"].ToString();
                        _estimateData.UnitOrder = row["UnitOrder"].ToString();
                        _estimateData.ReportPhase = row["ReportPhase"].ToString();
                        _estimateData.ReportContract = row["ReportContract"].ToString();
                        _estimateData.Units = row["Units"].ToString();
                        _estimateData.Location = row["Location"].ToString();
                        _estimateData.RunDateTime = System.DateTime.Now;
                        _estimateData.Job = row["JobID"].ToString();
                        _estimateData.Owner = row["OwnerID"].ToString();
                        _estimateData.Project = row["Project"].ToString();


                        _estimateDatas.Add(_estimateData);
                    }
                }
          
          

            return _estimateDatas;
        }


       
        public void Dispose()
		{
			GC.Collect();
		}


	}
}
