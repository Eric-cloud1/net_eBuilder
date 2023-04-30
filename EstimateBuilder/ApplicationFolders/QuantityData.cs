using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for QuantityData.
	/// </summary>
	public class QuantityData
	{


	public  QuantityData():this(null,null,null,0,null,null,null,null,null,null,0,0,false,0,0,0,1,1,1,System.DateTime.Now,0,null,0,0)
	{
	}
		
		public QuantityData(
            string _Accounting,
            string _ReportPhase,
            string _ReportContract,
            int _costItemID,
            string  _Division,
            string _DivisionCost,
			string _DivisionPrint,
            string _Units,
            string _Location,
			string  _Description,
			int _ExpressionID,
			int   _AssemblyID,
			bool  _Active,
			decimal _Quantity,
            decimal _QuantityOrdered,
            decimal _QuantityRoundUp,
            decimal _QuantityReuse,
            decimal _QuantityWaste,
            decimal _QuantityAdjusted,
            DateTime _RunDateTime,
            int _QuantityID,
			string _Memo,	
            int _ItemID,
            int _NumbID
			)
		{
            this.Accounting = _Accounting;
            this.ReportPhase = _ReportPhase;
            this.ReportContract = _ReportContract;
            this.CostItemID = _costItemID;
            this.Division=  _Division;
            this.DivisionCost= _DivisionCost;
			this.DivisionPrint= _DivisionPrint;
            this.Units =  _Units;
            this.Location= _Location;
			this.Description=  _Description;
			this.ExpressionID= _ExpressionID;
			this.AssemblyID=  _AssemblyID;
			this.Active=  _Active;
			this.Quantity= _Quantity;
            this.QuantityOrdered = _QuantityOrdered;
            this.QuantityAdjusted = _QuantityAdjusted;
            this.QuantityRoundUp = _QuantityRoundUp;
            this.QuantityReuse = _QuantityReuse;
            this.QuantityWaste = _QuantityWaste;
            this.RunDateTime= _RunDateTime;
            this.QuantityID= _QuantityID;
			this.Memo= _Memo;
            this.ItemID = _ItemID;
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



        public event EventHandler QuantityAdjustedChanged;
        public decimal _QuantityAdjusted;
        public decimal QuantityAdjusted
        {
            get { return _QuantityAdjusted; }
            set
            {
                _QuantityAdjusted = value;
                if (QuantityAdjustedChanged != null) QuantityAdjustedChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler QuantityRoundUpChanged;
        public decimal _QuantityRoundUp;
        public decimal QuantityRoundUp
        {
            get { return _QuantityRoundUp; }
            set
            {
                _QuantityRoundUp = value;
                if (QuantityRoundUpChanged != null) QuantityRoundUpChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler QuantityReuseChanged;
        public decimal _QuantityReuse;
        public decimal QuantityReuse
        {
            get { return _QuantityReuse; }
            set
            {
                _QuantityReuse = value;
                if (QuantityReuseChanged != null) QuantityReuseChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler QuantityWasteChanged;
        public decimal _QuantityWaste;
        public decimal QuantityWaste
        {
            get { return _QuantityWaste; }
            set
            {
                _QuantityWaste = value;
                if (QuantityWasteChanged != null) QuantityWasteChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler AccountingChanged;
        public string _Accounting;
        public string Accounting
        {
            get { return _Accounting; }
            set
            {
                _Accounting = value;
                if (AccountingChanged != null) AccountingChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ReportPhaseChanged;
        public string _ReportPhase;
        public string ReportPhase
        {
            get { return _ReportPhase; }
            set
            {
                _ReportPhase = value;
                if (ReportPhaseChanged != null) ReportPhaseChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ReportContractChanged;
        public string _ReportContract;
        public string ReportContract
        {
            get { return _ReportContract; }
            set
            {
                _ReportContract = value;
                if (ReportContractChanged != null) ReportContractChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ItemIDChanged;
        public int _ItemID;
        public int ItemID
        {
            get { return _ItemID; }
            set
            {
                _ItemID = value;
                if (ItemIDChanged != null) ItemIDChanged(this, EventArgs.Empty);
            }
        }




   
         public event EventHandler CostItemIDChanged;
        public int _CostItemID;
        public int CostItemID
        {
            get { return _CostItemID; }
            set
            {
                _CostItemID = value;
                if (CostItemIDChanged != null) CostItemIDChanged(this, EventArgs.Empty);
            }
        }


		public event EventHandler  QuantityIDChanged;
		public int  _QuantityID;
		public int QuantityID{get { return _QuantityID; }
			set {  _QuantityID= value; 
			if( QuantityIDChanged != null)  QuantityIDChanged(this,EventArgs.Empty);}
		}


		public event EventHandler  DivisionChanged;
		public string _Division;
		public string Division{get { return _Division; }
			set {  _Division= value; 
			if( DivisionChanged != null)  DivisionChanged(this,EventArgs.Empty);}
		}


		public event EventHandler  DivisionCostChanged;
		public string _DivisionCost;
		public string DivisionCost{get { return _DivisionCost; }
			set {  _DivisionCost= value; 
				if( DivisionCostChanged != null)  DivisionCostChanged(this,EventArgs.Empty);}
		}


		public event EventHandler  DivisionPrintChanged;
		public string _DivisionPrint;
		public string DivisionPrint{get { return _DivisionPrint; }
			set {  _DivisionPrint= value; 
			if( DivisionPrintChanged != null)  DivisionPrintChanged(this,EventArgs.Empty);}
		}


		public event EventHandler UnitsChanged;
		public string _Units;
		public string Units{get { return _Units; }
			set {  _Units= value; 
			if( UnitsChanged != null)  UnitsChanged(this,EventArgs.Empty);}
		}


		public event EventHandler LocationChanged;
		public string _Location;
		public string Location{get { return _Location; }
			set {  _Location= value; 
			if( LocationChanged != null)  LocationChanged(this,EventArgs.Empty);}
		}

		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description= value; 
			if( DescriptionChanged != null)  DescriptionChanged(this,EventArgs.Empty);}
		}

		public event EventHandler ExpressionIDChanged;
		public int _ExpressionID;
		public int ExpressionID{get { return _ExpressionID; }
			set {  _ExpressionID= value; 
			if( ExpressionIDChanged != null)  ExpressionIDChanged(this,EventArgs.Empty);}
		}

		public event EventHandler AssemblyIDChanged;
		public int _AssemblyID;
		public int AssemblyID{get { return _AssemblyID; }
			set {  _AssemblyID= value; 
			if( AssemblyIDChanged != null)  AssemblyIDChanged(this,EventArgs.Empty);}
		}

		public event EventHandler ActiveChanged;
		public bool _Active;
		public bool Active{get { return _Active; }
			set {  _Active= value; 
			if( ActiveChanged != null)  ActiveChanged(this,EventArgs.Empty);}
		}

		public event EventHandler QuantityChanged;
		public decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set {  _Quantity= value; 
			if( QuantityChanged != null)  QuantityChanged(this,EventArgs.Empty);}
		}

        public event EventHandler QuantityOrderedChanged;
        public decimal _QuantityOrdered;
        public decimal QuantityOrdered
        {
            get { return _QuantityOrdered; }
            set
            {
                _QuantityOrdered = value;
                if (QuantityOrderedChanged != null) QuantityOrderedChanged(this, EventArgs.Empty);
            }
        }
		public event EventHandler RunDateTimeChanged;
		public System.DateTime _RunDateTime;
		public System.DateTime   RunDateTime{get { return _RunDateTime; }
			set {  _RunDateTime = value; 
			if( RunDateTimeChanged != null)  RunDateTimeChanged(this,EventArgs.Empty);}
		}

		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo = value; 
			if( MemoChanged != null)  MemoChanged(this,EventArgs.Empty);}
		}

	}




    public class QuantityDatas  : ArrayList
    {
        public enum ItemsFields
        {
            Accounting,
            ReportPhase,
            ReportContract,
            costItemID,
            Division,
            DivisionCost,
			DivisionPrint,
            Units,
            Location,
			Description,
			ExpressionID,
			AssemblyID,
			Active,
			Quantity,
            QuantityOrdered,
			RunDateTime,
            QuantityAdjusted,
            QuantityRoundUp,
            QuantityReuse,
            QuantityWaste,
            QuantityID,
			Memo,	
            ItemID,
            NumbID
        }
    }


}
