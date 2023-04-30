using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class ExpressionData
	{
		

		public  ExpressionData():this(null,null,null,null,null,0,null,null,0,0)
		{
		}
		
		public ExpressionData(
            string _BuildingType,
            string  _Division,
			string _DivisionCost,			
			string  _Description,
            string _value,
            int _AssemblyID,
            string _unit,
            string _Memo,
			int _ExpressionID,
            int _NumbID
			)
		{
		    this.Division =  _Division;
			this.DivisionCost= _DivisionCost;			
			this.Description=  _Description;
            this.Value =  _value;
            this.AssemblyID =_AssemblyID;
            this.Unit = _unit;
            this.Memo =  _Memo;
            this.ExpressionID = _ExpressionID;
            this.NumbID = _NumbID;
        }


        public event EventHandler NumbIDChanged;
        public int _NumbID;
        public int NumbID
        {
            get { return _NumbID; }
            set
            {
                _NumbID = value;
                if (NumbIDChanged != null) NumbIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler  ExpressionIDChanged;
		public int _ExpressionID;
		public int ExpressionID{get { return _ExpressionID; }
			set {  _ExpressionID= value; 
			if( ExpressionIDChanged != null)  ExpressionIDChanged(this,EventArgs.Empty);}
		}



        public event EventHandler UnitChanged;
        public string _Unit;
        public string Unit
        {
            get { return _Unit; }
            set
            {
                _Unit = value;
                if (UnitChanged != null) UnitChanged(this, EventArgs.Empty);
            }
        }



    
        public event EventHandler ValueChanged;
        public string _Value;
        public string Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler BuildingTypeChanged;
        public string _BuildingType;
        public string BuildingType
        {
            get { return _BuildingType; }
            set
            {
                _BuildingType = value;
                if (BuildingTypeChanged != null) BuildingTypeChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler DivisionChanged;
		    public string _Division;
		    public string Division{get { return _Division; }
			    set {  _Division = value; 
			    if(DivisionChanged != null)  DivisionChanged(this,EventArgs.Empty);}
		    }

		public event EventHandler DivisionCostChanged;
		public string _DivisionCost;
		public string DivisionCost{get { return _DivisionCost; }
			set {  _DivisionCost = value; 
			if(DivisionCostChanged != null)  DivisionCostChanged(this,EventArgs.Empty);}
		}

		public event EventHandler AssemblyIDChanged;
		public int _AssemblyID;
		public int AssemblyID{get { return _AssemblyID; }
			set {  _AssemblyID = value; 
			if(AssemblyIDChanged != null)  AssemblyIDChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description = value; 
			if(DescriptionChanged != null)  DescriptionChanged(this,EventArgs.Empty);}
		}

		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo = value; 
			if(MemoChanged != null)  MemoChanged(this,EventArgs.Empty);}
		}
	}



    public class ExpressionDatas  : ArrayList
    {
        public enum ItemsFields
        {
            BuildingType,
     		Division,
			DivisionCost,			
			Description,
            value,
            AssemblyID,
            unit,
            Memo,
			ExpressionID,
            NumbID
        }
    }


}
