using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for CostItemData.
	/// </summary>
	public class CostItemData
	{

	public  CostItemData():this(null,null,null,0,false,null,null,0,null,0,0,null,null)
	{
	}

		
		public CostItemData(
			string _CostType,
			string _UnitOrder,
			string _Description,
            decimal _MinimumOrder,
            bool  _Active,
			string _Division,
			string _DivisionCost,	
            decimal _CostAdjustment,
            string _Memo,
			decimal _CostItemID,
            int _NumbID,
            string _CostItem,
            string _GenericVendor
			)
		{
            this.CostType =  _CostType;
			this.UnitOrder =  _UnitOrder;
			this.Description = _Description;
            this.MinimumOrder= _MinimumOrder;
            this.Active =   _Active;
			this.Division =  _Division;
			this.DivisionCost =  _DivisionCost;	
            this.CostAdjustment =  _CostAdjustment;
            this.Memo =  _Memo;
            this.CostItemID = _CostItemID;
            this.NumbID = _NumbID;
            this.CostItem = _CostItem;
            this.GenericVendor = _GenericVendor;

        }

        public event EventHandler GenericVendorChanged;
        public string _GenericVendor;
        public string GenericVendor
        {
            get { return _GenericVendor; }
            set
            {
                _GenericVendor = value;
                if (GenericVendorChanged != null) GenericVendorChanged(this, EventArgs.Empty);
            }
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

        
        public event EventHandler CostTypeIDChanged;
		public string _CostType;
		public string CostType{get { return _CostType; }
			set {  _CostType= value; 
			if(CostTypeIDChanged != null) CostTypeIDChanged(this,EventArgs.Empty);}
		}

		public event EventHandler UnitOrderChanged;
		public string _UnitOrder;
		public string UnitOrder{get { return _UnitOrder; }
			set {  _UnitOrder= value; 
			if(UnitOrderChanged != null) UnitOrderChanged(this,EventArgs.Empty);}
		}



    public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description= value; 
				if(DescriptionChanged != null) DescriptionChanged(this,EventArgs.Empty);}
		}

        public event EventHandler CostAdjustmentChanged;
        public decimal _CostAdjustment;
        public decimal CostAdjustment
        {
            get { return _CostAdjustment; }
            set
            {
                _CostAdjustment = value;
                if (CostAdjustmentChanged != null) CostAdjustmentChanged(this, EventArgs.Empty);
            }
        }

         public event EventHandler CostItemIDChanged;
        public decimal _CostItemID;
        public decimal CostItemID
        {
            get { return _CostItemID; }
            set
            {
                _CostItemID = value;
                if (CostItemIDChanged != null) CostItemIDChanged(this, EventArgs.Empty);
            }
        }




        public event EventHandler CostItemChanged;
        public string _CostItem;
        public string CostItem
        {
            get { return _CostItem; }
            set
            {
                _CostItem = value;
                if (CostItemChanged != null) CostItemChanged(this, EventArgs.Empty);
            }
        }
        
        


        public event EventHandler MinimumOrderChanged;
        public decimal _MinimumOrder;
        public decimal MinimumOrder
        {
            get { return _MinimumOrder; }
            set
            {
                _MinimumOrder = value;
                if (MinimumOrderChanged != null) MinimumOrderChanged(this, EventArgs.Empty);
            }
        }

	

	

		public event EventHandler ActiveChanged;
		public bool _Active;
		public bool Active{get { return _Active; }
			set {  _Active= value; 
			if(ActiveChanged != null) ActiveChanged(this,EventArgs.Empty);}
		}

	

		public event EventHandler DivisionCostChanged;
        public string _DivisionCost;
        public string DivisionCost
        {
            get { return _DivisionCost; }
            set
            {
                _DivisionCost = value;
                if (DivisionCostChanged != null) DivisionCostChanged(this, EventArgs.Empty);
            }
        }

		public event EventHandler DivisionChanged;
		public string _Division;
		public string Division{get { return _Division; }
			set 
			{
				_Division= value; 
				if(DivisionChanged != null) DivisionChanged(this,EventArgs.Empty);}
		}

		


	


		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo= value; 
			if(MemoChanged != null) MemoChanged(this,EventArgs.Empty);}
		}
	}




    public class CostItemDatas : ArrayList
    {
        public enum ItemsFields
        {
	        _CostType,
	        _UnitOrder,
	        _Description,
	        _MinimumOrder,
	        _Active,
	        _Division,
	        _DivisionCost,	
	        _ReportPhase,
	        _ReportContract,
            _CostAdjustment,
            _Memo,
	        _CostItemID,
            _NumbID,
            _CostItem,
            _GenericVendor
        }
    }

}
