using System;
using IDIGITALTEKGRID;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
    /// <summary>
    /// Summary description for ListDataProvider.
    /// </summary>
    public class ListDataProvider
    {

         protected string _connect;
        public ListDataProvider()
        {
           _connect = IDIGITALTEKGRID.ApplicationBuilder.connection;
        }
  
   

      

        public DivisionDatasExpression selectExpression(string _jobID)
        {

            StringBuilder _strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData data = new IDIGITALTEKGRID.stData();


            _strSQL.Append(" SELECT DISTINCT Count(Matrix.Value) AS CountOfValue, "); 
            _strSQL.Append(" Matrix.ExpressionID  FROM Matrix ");
            _strSQL.Append(" GROUP BY Matrix.ExpressionID, Matrix.Key ");
            _strSQL.Append(" HAVING (Matrix.Key =3)");


            DataSet _dsData = data.getDataSet(_strSQL.ToString(), _connect);

            IDIGITALTEKGRID.DivisionDatasExpression _ExpressionDatas = new IDIGITALTEKGRID.DivisionDatasExpression();

            foreach (DataRow _row in _dsData.Tables[0].Rows)
            {
                string _count = _row["CountOfValue"].ToString();
                string _id = _row["ExpressionID"].ToString();

                StringBuilder strSQL = new StringBuilder();
                IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

                strSQL.Append(" SELECT Count(Takeoff.TakeOffID) AS CountOfTakeOffID, ");
                strSQL.Append(" Takeoff.JobID, Matrix.ExpressionID, ");
                strSQL.Append(" Expression.Description ");
                strSQL.Append(" FROM Expression INNER JOIN (Takeoff INNER JOIN Matrix ");
                strSQL.Append(" ON Takeoff.TakeOffID = Matrix.Value) ");
                strSQL.Append(" ON Expression.ExpressionID = Matrix.ExpressionID ");
                strSQL.Append(" GROUP BY Takeoff.JobID, Matrix.ExpressionID , Expression.Description");
                strSQL.Append(" HAVING (Count(Takeoff.TakeOffID) =" + _count  + ") ");
                strSQL.Append(" AND (Takeoff.JobID=" + _jobID + ")");
                strSQL.Append(" AND (Matrix.ExpressionID =" + _id + ")");
                strSQL.Append(" ORDER BY Expression.Description");

                DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

               
                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    DivisionDataExpression _ExpressionData = new IDIGITALTEKGRID.DivisionDataExpression();
                    _ExpressionData.DivisionKey = row["ExpressionID"].ToString();
                    _ExpressionData.DivisionValue = row["Description"].ToString();
                    _ExpressionDatas.Add(_ExpressionData);
                }
            }
            return _ExpressionDatas;

        }

        public int getLastExpressionID()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append("SELECT TOP 1 ExpressionID");
            strSQL.Append(" FROM Expression ORDER By ExpressionID DESC ");
            object last = _data.ExecScalar(strSQL.ToString(), _connect);
            return Convert.ToInt32(last) + 1;
        }


        public void AddJobGroup(string _JobID, string _Group, string _GroupID)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" INSERT INTO JobCategory ( JobID, Group,  GroupID)");
            strSQL.Append(" VALUES (");
            strSQL.Append(_JobID + ", '");
            strSQL.Append(_Group + "', ");
            strSQL.Append(_GroupID +")");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }



        public void DeleteJobGroup(string _JobID, string _GroupID)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" DELETE * FROM JobCategory ");
            strSQL.Append(" WHERE JobID = " + _JobID + " AND GroupID = " + _GroupID);


            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }

        public void AddFavoriteVendor( string _favoriteContactID, string _contactIdJob)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" INSERT INTO Preference ( Parent, Child )");
            strSQL.Append(" VALUES (");
            strSQL.Append(  _contactIdJob + ", ");
            strSQL.Append( _favoriteContactID + ")");

            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }

        public void DeleteFavoriteVendor(string _favoriteContactID, string _contactIdJob )
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" DELETE * FROM Preference ");
            strSQL.Append(" WHERE Child = " + _favoriteContactID + " AND Parent = " + _contactIdJob);


            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }
        }


        public string getJobZipCode(string _ContactJobID)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT DISTINCT  ZipCode  ");
            strSQL.Append(" FROM Contact ");
            strSQL.Append("  where ContactID = " + _ContactJobID );
            string zipcode="";
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    zipcode=  row[0].ToString();
                }
            }
            catch { zipcode = ""; }
            return zipcode;
        }


        public void GroupCategory(System.Windows.Forms.ListView _list, string _id)
        {

            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  ValidationUserID & '-' & [ValidationUser]![Description] AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Takeoff')");
            strSQL.Append("  AND TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) ");
            strSQL.Append("  NOT IN (SELECT  JobCategory.Group FROM JobCategory WHERE JobCategory.JobID="+_id+")");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            _list.BeginUpdate();
            _list.Items.Clear();
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString() + "-" + row[1].ToString());

                }
            }
            catch { }

            _list.EndUpdate();

        }

        public void GroupJobCategory(System.Windows.Forms.ListView _list, string _id)
        {

            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();


            strSQL.Append(" SELECT  JobCategory.Group ");
            strSQL.Append(" FROM JobCategory ");
            strSQL.Append(" WHERE JobCategory.JobID="+_id);

            _list.BeginUpdate();
            _list.Items.Clear();
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString() + "-" + row[1].ToString());

                }
            }
            catch { }

            _list.EndUpdate();
        }

        public void NotFavoriteVendor(System.Windows.Forms.ListView _list, object _contactIdJob)
        {
       
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT Contact.ContactID, Contact.Company ");
            strSQL.Append(" FROM Contact  WHERE (((Contact.ContactID) Not In ");
            strSQL.Append(" (Select Child FROM Preference WHERE Parent =" + _contactIdJob + ")) ");
            strSQL.Append(" AND ((Contact.Contract)=1))");

            _list.BeginUpdate();
            _list.Items.Clear();
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString() + "-" + row[1].ToString());

                }
            }
            catch { }

            _list.EndUpdate();
        }


        public void FavoriteVendor(System.Windows.Forms.ListView _list, object _contactIdJob)
        {
       
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT Contact.ContactID, Contact.Company ");
            strSQL.Append(" FROM Contact  WHERE (((Contact.ContactID) In ");
            strSQL.Append(" (Select child FROM Preference WHERE Parent =" + _contactIdJob + ")) ");
            strSQL.Append(" AND ((Contact.Contract)=1))");

            _list.BeginUpdate();
            _list.Items.Clear();
            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _list.Items.Add(row[0].ToString()+"-"+ row[1].ToString());
              
                }
            }
            catch { }

            _list.EndUpdate();
        }


        public System.Data.DataTable UserValidation()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append(" ORDER BY ValidationUser.Group, ValidationUser.Code  ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable UserValidationDivision()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Division')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationDivisionCost(string _id)
        {
            try
            {
                _id = _id.Substring(0, 2).ToString();
                StringBuilder strSQL = new StringBuilder();
                IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
                strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
                strSQL.Append(" FROM ValidationUser");
                //  strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown,  ValidationUser.Code ");
                strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
                strSQL.Append("  AND ((ValidationUser.Group)='Division Cost')");
                strSQL.Append("  AND ((LEFT(ValidationUser.Code,2) ='" + _id + "' ))");
                strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

                DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

                DataTable dsTable = dsData.Tables[0];
                return dsTable;
            }
            catch { return null; }
        }
        public System.Data.DataTable UserValidationDivisionCost()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Division Cost')");

            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }
        public System.Data.DataTable UserValidationDivisionPrint()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Division Print')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationUnits()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //   strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Units')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationLocation()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Location')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationPhase()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT  TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //    strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Phase')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable UserValidationContract()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //  strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Contractor')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

    

        public System.Data.DataTable UserValidationAccounting()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Accounting')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }
        public System.Data.DataTable UserValidationCostType()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //  strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append(" AND ((ValidationUser.Group)='Cost Type')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }
        public System.Data.DataTable UserValidationBuildingType()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND((ValidationUser.Group)='Building Type')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationContractors()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND((ValidationUser.Group)='Contractor')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }



        public System.Data.DataTable UserValidationMethod()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Method')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationInput()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            //strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='Input')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable UserValidationType()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT ValidationSystem.Description as [Type]");
            strSQL.Append(" FROM ValidationSystem WHERE ValidationSystem.Type='Type'");
            strSQL.Append(" ORDER BY [Description]");
            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable UserValidationGroup()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT ValidationSystem.Description as [Group]");
            strSQL.Append(" FROM ValidationSystem WHERE ValidationSystem.Type='Group'");
            strSQL.Append(" ORDER BY [Description]");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable USStates()
        {

            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT [Code]as StateID, [Description] AS State ");
            strSQL.Append(" FROM ValidationUser");
            strSQL.Append("  WHERE ((ValidationUser.Group)='State')");
            strSQL.Append(" ORDER BY [Description]");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable Regions()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT [Code]as RegionID, [Description] AS Region ");
            strSQL.Append(" FROM ValidationUser");
            strSQL.Append("  WHERE ((ValidationUser.Group)='Region')");
            strSQL.Append(" ORDER BY [Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable ContactType()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT [Code]as ContractID, [Description] AS Contract ");
            strSQL.Append(" FROM ValidationUser");
            strSQL.Append("  WHERE ((ValidationUser.Group)='Contact')");
            strSQL.Append(" ORDER BY [Description]");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable CostAmountIDDescription()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostAmountID, Description_costAmt  as Description");
            strSQL.Append(" FROM [CostAmount] ");
            strSQL.Append(" ORDER BY Description_costAmt");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public string CostItemUnitOrder(string i)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostItem.UnitOrder FROM CostItem ");
            strSQL.Append(" WHERE CostItem.CostItemID="+i);


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            string _UnitOrder = "";
            foreach (DataRow row in dsData.Tables[0].Rows)
            {
                 _UnitOrder = row["UnitOrder"].ToString();
            }
            return _UnitOrder;

        }

        public System.Data.DataTable CostItemIDDescription()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostItemID , Description_costItem as Description");
            strSQL.Append(" FROM CostItem ");
            strSQL.Append(" ORDER BY Description_costItem");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable CostIDDescription(string _division)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostItemID , Division_costItem, Description_costItem as Description");
            strSQL.Append(" FROM CostItem ");
            strSQL.Append(" WHERE Division_costItem ='" + _division + "'");
            strSQL.Append(" ORDER BY Description_costItem");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable CostItemIDDescription(bool _sort)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            if (_sort == true)
            {
                strSQL.Append(" SELECT CostItemID , Description_costItem as Description");
                strSQL.Append(" FROM CostItem ");
                strSQL.Append(" ORDER BY CostItemID DESC");
            }
            else
            {
                strSQL.Append(" SELECT CostItemID , Description_costItem as Description");
                strSQL.Append(" FROM CostItem ");
                strSQL.Append(" ORDER BY Description_costItem");
            }


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable CostItemIDDescription(string i)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostItem.CostItemID, CostItem.Description_costItem as Description, ");
            strSQL.Append(" FROM CostItem ");
            strSQL.Append(" INNER JOIN CostAmount ON ");
            strSQL.Append("  CostItem.CostItemID = CostAmount.CostItemID");
            strSQL.Append(" WHERE CostAmount.BuildingType_costAmt ='" + i + "'");

            try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

                DataTable dsTable = dsData.Tables[0];
                return dsTable;
            }
            catch
            {
                return null;
            }
        }
 


        public System.Data.DataTable QuantityIDQuantity()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT DISTINCT QuantityID , Quantity ");
            strSQL.Append(" FROM [Quantity] ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable AssemblyIDName()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT AssemblyID, Description as Name ");
            strSQL.Append(" FROM [Assembly] ");
            strSQL.Append(" ORDER BY [Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }






        //	public System.Data.DataTable OutlookID()
        //{
//			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
//
//			strSQL.Append(" ");
//			strSQL.Append(" ");
//			DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
//			
//				
//			DataTable dsTable;  // = dsData.Tables[0];
//			return dsTable;
        //	}


        public System.Data.DataTable ContactIDCompany()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  ContactID , Company ");
            strSQL.Append(" FROM [Contact] WHERE Contract in (1,3,4)");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }
        public System.Data.DataTable ContactIDOwner()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  ContactID , Company as Owner");
            strSQL.Append(" FROM [Contact] WHERE Contract in (6)");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable ProjectIDName()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ContactID as projectID, Company as ProjectName ");
            strSQL.Append(" FROM [Contact] WHERE Contract =2");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable ItemIDName()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT CostItemID as ItemID, [CostItemID]&' - '&[Description] as Name");
            strSQL.Append(" FROM [CostItem] ");
            strSQL.Append(" ORDER BY [Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable VendorIDCompany()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ContactID as [VendorID], Company ");
            strSQL.Append(" FROM [Contact] WHERE contract =1");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable CostItemDescription()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT Description_CostItem as Description FROM CostItem ");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }
        public System.Data.DataTable ProviderIDCompany()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ContactID as [ProviderID], Company ");
            strSQL.Append(" FROM [Contact] WHERE contract =3");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable ManufactureIDCompany()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ContactID as [ManufactureID], Company ");
            strSQL.Append(" FROM [Contact] WHERE contract =4");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable CustomerIDCompany()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT ContactID as CustomerID , Company ");
            strSQL.Append(" FROM [Contact] WHERE contract =4");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

        public System.Data.DataTable ContactJobIDJob()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();


            strSQL.Append(" SELECT Contact.ContactID as JobID , Contact.Company&'-'&Contact.ZipCode AS Job ");
            strSQL.Append(" FROM [Contact] WHERE contract =5");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];

            return dsTable;
        }

        public System.Data.DataTable JobIDJob()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT Job.JobID, Job.JobID&'-'&Contact.Company&'-'&Contact.ZipCode AS Job ");
            strSQL.Append(" FROM Contact INNER JOIN Job ");
            strSQL.Append(" ON Contact.ContactID = Job.ContactID_Job");
            strSQL.Append(" ORDER BY Company");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];

            return dsTable;
        }


        public System.Data.DataTable JobIDJob(string _buildingType)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT DISTINCT Takeoff.JobID, Job.JobID&'-'&Contact.Company&'-'&Contact.ZipCode AS Job ");
            strSQL.Append(" FROM (Takeoff INNER JOIN Job ON Takeoff.JobID = Job.JobID) ");
            strSQL.Append(" INNER JOIN Contact ON Job.ContactID_Job = Contact.ContactID ");
            strSQL.Append(" WHERE TRIM(Takeoff.BuildingType_takeoff)='" + _buildingType + "'");
           // strSQL.Append(" ORDER BY Company");



            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];

            return dsTable;
        }


        public System.Data.DataTable DescriptionExpressionID()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  Description, ExpressionID ");
            strSQL.Append(" FROM Expression ");
            strSQL.Append(" ORDER BY Description");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }




        public System.Data.DataTable GroupValidationSystem()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT  Description as [Group] FROM ValidationSystem ");
            strSQL.Append(" WHERE Type ='Group' ");
            strSQL.Append(" ORDER BY Description");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public System.Data.DataTable TypeValidationSystem()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT Description as [Type] FROM ValidationSystem ");
            strSQL.Append(" WHERE Type ='Type' ");
            strSQL.Append(" ORDER BY Description");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;


        }

        public System.Data.DataTable UserValidationView()
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT TRIM([ValidationUser]![Code] & ' ' & [ValidationUser]![Description]) AS Description , ValidationUser.Group");
            strSQL.Append(" FROM ValidationUser");
            // strSQL.Append(" GROUP BY [ValidationUser]![Code] & ' ' & [ValidationUser]![Description], ValidationUser.Group, ValidationUser.Active, ValidationUser.Pulldown");
            strSQL.Append(" WHERE (((ValidationUser.Active)=Yes) AND ((ValidationUser.Pulldown)=Yes))");
            strSQL.Append("  AND ((ValidationUser.Group)='View')");
            strSQL.Append(" ORDER BY [ValidationUser]![Code], [ValidationUser]![Description]");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), _connect);

            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


        public void SaveGridView(string _grid, string _view, int _X, int _Y)
        {

            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" DELETE * FROM GridView  WHERE Grid ='" + _grid + "'");
            try
            {
                _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }

            StringBuilder strSQL2 = new StringBuilder();
            IDIGITALTEKGRID.stData _data2 = new IDIGITALTEKGRID.stData();
            strSQL2.Append(" INSERT INTO GridView ( Grid, Favorite, XWidth, YHeight) ");
            strSQL2.Append(" VALUES( '" + _grid + "', '" + _view + "',"+ _X +","+ _Y +") ");
            try
            {
                _data2.ExecuteSQL(strSQL2.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            }
            catch { }

           
        }



        public string[] SelectGridView(string _grid )
        {
            StringBuilder strSQL = new StringBuilder();
            string[] _GridView = new string[3];
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();


            strSQL.Append("SELECT GridView.Grid, GridView.Favorite, GridView.XWidth, GridView.YHeight FROM GridView  WHERE Grid ='" + _grid + "'");

             DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    _GridView[0] = row[1].ToString();
                    _GridView[1] = row[2].ToString();
                    _GridView[2] = row[3].ToString();
                }

                return _GridView;
        }
    }
}
