using System;
using System.Collections;
using System.Data;
using System.Text;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for Operators.
	/// </summary>
	public class Operators
	{
		public Operators(){ }

        #region calculator
         public static decimal Calculate(string  _expressionID, string _jobID )
		{
			Stack _intStack1 = new Stack();
			Stack _opStack1 = new Stack();
            Stack _result = new Stack();
            Stack _opResult = new Stack();
            SetStacks(_expressionID, _jobID,_intStack1, _opStack1);
            return ReturnValue(_intStack1, _opStack1, _result, _opResult);
        }

	public static void UpdateQuantity(int _value, string _expressionID)
	{
		StringBuilder strSQL = new StringBuilder();
		IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

		strSQL.Append(" UPDATE Quantity SET Quantity = "+ _value + " ,");
		strSQL.Append(" RunDateTime = '"+ System.DateTime.Now +"'");
		strSQL.Append(" WHERE Quantity.ExpressionID="+ _expressionID );
		try
		{
			_data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
		}
		catch{}

	}

        public static decimal ReturnValue(Stack intStack1, Stack opStack1)
        {
            Object[] myArray = opStack1.ToArray();
            decimal i, pop2;


            System.Collections.IEnumerator enumerator = myArray.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {

                    decimal pop1 = Convert.ToDecimal(intStack1.Pop());
                    int x = Convert.ToInt32(opStack1.Pop());

                   
                    switch (x)
                    {
                        case 0:
                            intStack1.Push(pop1);
                            break;
                        case 1:
                            pop2 = Convert.ToDecimal(intStack1.Pop());
                            i = addValues(pop1, pop2);
                            intStack1.Push(i);
                            break;
                        case 2:
                            pop2 = Convert.ToDecimal(intStack1.Pop());
                            i = subtractValues(pop1, pop2);
                            intStack1.Push(i);
                            break;
                        case 3:
                            pop2 = Convert.ToDecimal(intStack1.Pop());
                            i = multiplyValues(pop1, pop2);
                            intStack1.Push(i);
                            break;
                        case 4:
                            pop2 = Convert.ToDecimal(intStack1.Pop());
                            i = divideValues(pop1, pop2);
                            intStack1.Push(i);
                            break;
                        case 5:
                            pop2 = Convert.ToDecimal(intStack1.Pop());
                            i = remainderValues(pop1, pop2);
                            intStack1.Push(i);
                            break;

                    }
                }
                return Convert.ToDecimal(intStack1.Pop());
            }
            catch { return -999; }

        }

        public static decimal ReturnValue(Stack intStack1, Stack opStack1, Stack result, Stack opResult)
		{
            decimal y = 0;
         //   if (intStack1.Count != 0)
          //  {
                Object[] myArray = opStack1.ToArray();
                
                System.Collections.IEnumerator enumerator = myArray.GetEnumerator();
                try
                {

                    do
                    {
                        decimal pop1 = Convert.ToDecimal(intStack1.Pop());
                        int x = Convert.ToInt32(opStack1.Pop());
                        int z = 0;
                        decimal pop2;

                        switch (x)
                        {
                            case 9:
                                intStack1.Push(pop1);
                                y = ReturnValue(intStack1, opStack1, result, opResult);

                               // if ((intStack1.Count != 0) && (opStack1.Count != 0))
                                intStack1.Push(y);

                                break;
                            case 0:
                                result.Push(pop1);
                                try
                                {
                                    x = Convert.ToInt32(opStack1.Pop());
                                    if (x != 0)
                                        opResult.Push(x);
                                    else
                                    {
                                        y = ReturnValue( result, opResult);
                                        intStack1.Push(y);
                                    }
                                }
                                catch
                                {
                                   
                                }

                                break;
                            case 1:
                                z = Convert.ToInt32(opStack1.Pop());
                                if (z == 9)
                                {
                                    result.Push(pop1);
                                    //z = Convert.ToInt32(opStack1.Pop());
                                    opResult.Push(x);
                                    y = ReturnValue(intStack1, opStack1, result, opResult);
                                    break;
                                }
                                else
                                {
                                    opStack1.Push(z);
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    y = addValues(pop2, pop1);
                                    intStack1.Push(y);
                                    break;
                                }
                           
                             
                            case 2:
                                z = Convert.ToInt32(opStack1.Pop());
                                if (z == 9)
                                {
                                    result.Push(pop1);
                                   //z = Convert.ToInt32(opStack1.Pop());
                                   opResult.Push(x);
                                    y = ReturnValue(intStack1, opStack1, result, opResult);
                                    break;
                                }
                                else
                                {
                                    opStack1.Push(z);
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    y = subtractValues(pop2, pop1);
                                    intStack1.Push(y);
                                    break;
                                }

                         
                            case 3:
                                z = Convert.ToInt32(opStack1.Pop());
                                if (z == 9)
                                {
                                    result.Push(pop1);
                                   //z = Convert.ToInt32(opStack1.Pop());
                                   opResult.Push(x);
                                    y = ReturnValue(intStack1, opStack1, result, opResult);
                                    break;
                                }
                                else
                                {
                                    opStack1.Push(z);
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    y = multiplyValues(pop2, pop1);
                                    intStack1.Push(y);
                                    break;
                                }

                              
                            case 4:
                                z = Convert.ToInt32(opStack1.Pop());
                                if (z == 9)
                                {
                                    result.Push(pop1);
                                   // z = Convert.ToInt32(opStack1.Pop());
                                    opResult.Push(x);
                                    y = ReturnValue(intStack1, opStack1, result, opResult);
                                    break;
                                }
                                else
                                {
                                    opStack1.Push(z);
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    y = divideValues(pop2, pop1);
                                    intStack1.Push(y);
                                    break;
                                }
                             
                                
                            case 5:
                                z = Convert.ToInt32(opStack1.Pop());
                                if (z == 9)
                                {
                                    result.Push(pop1);
                                   // z = Convert.ToInt32(opStack1.Pop());
                                    opResult.Push(x);
                                   y = ReturnValue(intStack1, opStack1, result, opResult);
                                    break;
                                }
                                else
                                {
                                    opStack1.Push(z);
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    pop2 = Convert.ToDecimal(intStack1.Pop());
                                    y = remainderValues(pop2, pop1);
                                    intStack1.Push(y);
                                    break;
                                }
                          

                        }

                    } while (enumerator.MoveNext());

                }
                catch { }
            //}
           // intStack1.Clear();
          //  opStack1.Clear();

         
                if((result.Count!=0)&&(opResult.Count!=0))
                    y = ReturnValue(result, opResult);

            return y;

        }


		public static void SetStacks(string  _expressionID, string _jobID, Stack intStack1,Stack opStack1 )
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

            strSQL.Append("SELECT DISTINCT Matrix.MatrixID, Matrix.Value, Takeoff.TakeOffID, ");
            strSQL.Append("Matrix.Key, Matrix.GuidID, Takeoff.Description_takeoff, ");
            strSQL.Append("Matrix.ExpressionID, Takeoff.TakeoffValue ");
            strSQL.Append("FROM Matrix LEFT JOIN Takeoff ON Matrix.Value = Takeoff.TakeOffID ");
            strSQL.Append("WHERE ((Matrix.Value =[Takeoff].[TakeOffID]) AND ");
            strSQL.Append("(Matrix.ExpressionID=" + _expressionID + " ) AND ( TakeOff.JobID=" + _jobID + ")) ");
            strSQL.Append("OR (((Matrix.Key)<>003) AND Matrix.ExpressionID=" + _expressionID + ")");

            try
			{
				DataTable dt = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection).Tables[0];	
				string _key, _id, _value;
				foreach(DataRow row in dt.Rows)
				{
					_key =row["Key"].ToString();
					//Integer
					if(_key=="1")
					{intStack1.Push(row["Value"].ToString());}
						//operator
					else if(_key=="2")
					{opStack1.Push((row["Value"].ToString().Substring(0,1)));}
                    else if (_key == "0")
                    { opStack1.Push("0"); }

                    else if (_key == "9")
                    { 
                      opStack1.Push("9");
                     // opStack1.Push("0");
                    }
                        //TakeOffID
                    else if(_key=="3")
                    {
                        
                        _value = row["TakeoffValue"].ToString();
                        if(_value =="" )
                        { _value = "0"; }
                            intStack1.Push(_value);
                    }
                    //ExpressionID
					else if(_key=="4")
					{
                        opStack1.Push("0");
                        
                        _id = row["Value"].ToString() ;
						getExpressionTakeOffValue( _id,_jobID, intStack1,opStack1 );}
				}
			}
			catch{}


        }
        #endregion


        
        public static void  getExpressionTakeOffValue(string _expressionID, string _jobID, Stack _intStack1, Stack _opStack1)
		{
			SetStacks(_expressionID,_jobID,_intStack1,_opStack1);
		}
		

		#region Operation
        public static decimal addValues(decimal lhs, decimal rhs)
        {	
			return lhs + rhs;
		}

        public static decimal subtractValues(decimal lhs, decimal rhs)
        {
			return lhs - rhs;
		}

        public static decimal multiplyValues(decimal lhs, decimal rhs)
        {		
			return lhs * rhs;
		}

        public static decimal divideValues(decimal lhs, decimal rhs)
        {
			return lhs / rhs;
		}

        public static decimal remainderValues(decimal lhs, decimal rhs)
        {
			return lhs % rhs;
		}

        public static decimal getQuantityOrdered(decimal _Quantity, decimal _QuantityAdjusted, decimal _QuantityReuse, decimal _QuantityWaste, decimal _QuantityRoundUp)
        {
            decimal _quantityOrdered;
            try 
            {  
             _quantityOrdered = (_Quantity +_QuantityRoundUp) * _QuantityAdjusted * _QuantityReuse * _QuantityWaste;

            }
            catch { _quantityOrdered = 0; }

            return _quantityOrdered;
        }
        public static decimal quantityAdjustment(decimal _piecePerUnit, decimal _quantityTakeoff, decimal _quantityMinimum, decimal _quantityroundup, decimal _quantityreuse, decimal _quantitywaste)
        {
            decimal _roundUp;
            try
            {
                     _roundUp = System.Math.Floor(((_quantityTakeoff + _quantityroundup) * _quantitywaste * _quantityreuse) / _piecePerUnit) + 1;
            }
            catch { _roundUp =  0;}
            if (_quantityTakeoff == 0)
            {
                return 0;
            }
            else if (_roundUp > _quantityMinimum)
            {
               
                return _roundUp ;
            }
            else
            {
                return _quantityMinimum;
            }
          
        }

		#endregion

    }

    #region Data
     public class data1
	{
		public data1(){}
		public event EventHandler Value1Changed;

		public string _Value;
		public string  Value{get { return _Value; }
			set 
			{
				_Value = value; 
				if(Value1Changed != null) Value1Changed(this,EventArgs.Empty);
			}
		}

		public string  _Key;
		public string  Key{get { return _Key; }
			set {_Key= value; }
		}

		public string  _GuidID;
		public string  GuidID{get { return _GuidID; }
			set {_GuidID= value; }
		}

		public string  _ID;
		public string  ID{get { return _ID; }
			set {_ID= value; }
		}

		public string  _Description;
		public string  Description{get { return _Description; }
			set {_Description= value; }
		}


		public  IDIGITALTEKGRID.data1[] select(string _id)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

			strSQL.Append("SELECT MatrixID, Value, Key,");
			strSQL.Append(" GuidID, Description ");
			strSQL.Append(" FROM Matrix WHERE ExpressionID= ="+_id );

			DataTable dt = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection).Tables[0];	

		
			int _count = dt.Rows.Count;
			if (_count != 0)
			{
				IDIGITALTEKGRID.data1[] Array1 = new  IDIGITALTEKGRID.data1[_count - 1];
  
				for (int num1 = 0; num1 <_count; num1++)
				{
					IDIGITALTEKGRID.data1 package1 = new IDIGITALTEKGRID.data1();
					IDIGITALTEKGRID.data1 package2 = package1;
					if (dt.Columns.Contains("Value"))
					{
						package2.Value = dt.Rows[num1]["Value"].ToString();
					}
					if (dt.Columns.Contains("Key"))
					{
						package2.Key = dt.Rows[num1]["Key"].ToString();
					}
					if (dt.Columns.Contains("GuidID"))
					{
						package2.GuidID = dt.Rows[num1]["GuidID"].ToString();
					}
					if (dt.Columns.Contains("MatrixID"))
					{
						package2.ID=  dt.Rows[num1]["MatrixID"].ToString();
					}
					if (dt.Columns.Contains("Description"))
					{
						package2.Description =  dt.Rows[num1]["Description"].ToString();
					}
				
					package2 = null;
					Array1[num1] = package1;
				}
				return Array1;
			}
			else
			{
				return null;
			}
			
		}


		public System.Data.DataTable ExpressionDivision(string _jobID)
		{


			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT DISTINCT Expression.Division");
            strSQL.Append(" FROM (Expression INNER JOIN Matrix ");
            strSQL.Append(" ON Expression.ExpressionID = Matrix.ExpressionID) ");
            strSQL.Append(" INNER JOIN Takeoff ON Matrix.Value = Takeoff.TakeOffID");
            strSQL.Append(" WHERE Takeoff.JobID=" + _jobID);



            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);		
			DataTable dsTable = dsData.Tables[0];
			return dsTable;
		}


		public System.Data.DataTable getExpression(string ID, string _jobId)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

           strSQL.Append(" SELECT DISTINCT Expression.ExpressionID,");
           strSQL.Append("  Expression.Description, Takeoff.JobID");
           strSQL.Append("  FROM Takeoff INNER JOIN (Expression ");
           strSQL.Append("  INNER JOIN Matrix ON Expression.ExpressionID = Matrix.ExpressionID) ");
           strSQL.Append("  ON Takeoff.TakeOffID = Matrix.Value");
           strSQL.Append("  WHERE Takeoff.JobID ="+ _jobId);
           strSQL.Append("  AND Expression.Division ='" + ID + "'");


	

			DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
			
			DataTable dsTable = dsData.Tables[0];
			return dsTable;
		}
	

		public System.Data.DataTable TakeOffDivision(string _jobID, string _buildingType)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

            strSQL.Append(" SELECT distinct Takeoff.Division_takeoff ");
            strSQL.Append(" FROM Takeoff ");
            strSQL.Append(" WHERE Takeoff.JobID=" + _jobID);
            strSQL.Append(" AND TRIM(Takeoff.BuildingType_takeoff) = '" + _buildingType + "'");
            strSQL.Append(" ORDER BY Takeoff.Division_takeoff ");


            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);			
			DataTable dsTable = dsData.Tables[0];
			return dsTable;
		}

         public System.Data.DataTable TakeOffDivisionCost(string _division, string _jobID, string _buildingType)
         {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT DISTINCT DivisionCost_takeoff ");
            strSQL.Append(" FROM TakeOff WHERE Division_takeoff ='" + _division + "'");
            strSQL.Append(" AND Takeoff.JobID = " + _jobID);
            strSQL.Append(" AND TRIM(Takeoff.buildingType_takeoff) = '" + _buildingType + "'");
            strSQL.Append(" ORDER BY DivisionCost_takeoff ");
            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }

         public System.Data.DataTable TakeOffDivisionPrint(string _divisionCost, string _jobID, string _buildingType)
         {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT DISTINCT DivisionPrint_takeoff");
            strSQL.Append(" FROM TakeOff WHERE DivisionCost_takeoff ='" + _divisionCost + "'");
            strSQL.Append(" AND Takeoff.JobID = " + _jobID);
            strSQL.Append(" AND TRIM(Takeoff.buildingType_takeoff) = '" + _buildingType + "'");
            strSQL.Append(" ORDER BY DivisionPrint_takeoff ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);
            DataTable dsTable = dsData.Tables[0];
            return dsTable;
        }


         public System.Data.DataTable getTakeOff(string _divisionCost, string _DivisionPrint, string _jobID, string _buildingType)
         {
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" SELECT DISTINCT TakeOffID , Description_takeoff, TakeoffValue, Memo_takeoff");
            strSQL.Append(" FROM TakeOff WHERE DivisionPrint_takeoff ='" + _DivisionPrint + "'");
            strSQL.Append(" AND TakeOff.JobID="+ _jobID );
            strSQL.Append(" AND TRIM(Takeoff.buildingType_takeoff) = '" + _buildingType + "'");
            strSQL.Append(" AND TRIM(Takeoff.DivisionCost_takeoff) = '" + _divisionCost + "'");
            strSQL.Append(" AND Takeoff.Active_takeoff = true ");
    
            strSQL.Append(" ORDER BY Description_takeoff ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);		
			DataTable dsTable = dsData.Tables[0];
			return dsTable;
		}


        public void delete(string _expressionID)
        {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" DELETE * FROM Matrix WHERE ExpressionID =" + _expressionID);

            _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

        }

         public void deleteGuid(string _GuidID)
         {
            StringBuilder strSQL = new StringBuilder();
            IDIGITALTEKGRID.stData _data = new IDIGITALTEKGRID.stData();
            strSQL.Append(" DELETE * FROM Matrix WHERE GuidID ='" + _GuidID+"'");

            _data.ExecuteSQL(strSQL.ToString(), IDIGITALTEKGRID.ApplicationBuilder.connection);

        }

         
    

        public void add(IDIGITALTEKGRID.data1  _data1)
		{
			StringBuilder strSQL = new StringBuilder();
			IDIGITALTEKGRID.stData  _data = new IDIGITALTEKGRID.stData();

	
			strSQL.Append(" INSERT INTO Matrix ( [Value], [Key], GuidID, ");
			strSQL.Append(" ExpressionID, Description ) VALUES (");

		
			strSQL.Append( _data1.Value + ", ");
			strSQL.Append( _data1.Key +", ");
			strSQL.Append("'"+ _data1.GuidID +"', ");
			strSQL.Append( _data1.ID +", ");
			strSQL.Append("'"+_data1.Description +"') ");
		
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),IDIGITALTEKGRID.ApplicationBuilder.connection);
			}
			catch{}
		}
	
	

		public IDIGITALTEKGRID.data1[] add(IDIGITALTEKGRID.data1[] _data1, IDIGITALTEKGRID.data1 _data2)
		{
			 int i = _data1.GetLength(0);
			int num1 = i +1;
			_data1[num1] = _data2;
			return _data1;
		}


    }
    #endregion









}




