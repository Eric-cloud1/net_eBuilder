using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for TakeOff.
	/// </summary>
	public class TakeOffData
	{
	

		public  TakeOffData():this(false, null,null,null,null,null,null,null,null,null,0,false,false,null,0,0,0,null,0)
	{
	}	
		public TakeOffData(
            bool _Group,
			string _Division,
			string _DivisionCost,
			string _DivisionPrint,
            string _Method,
            string _Input,
            string _BuildingType,
            string _Units,
            string _Location,
            string _Description,
			decimal _TakeOff,
			bool  _Active ,
            bool _ActiveJob,
            string _Memo,
			int _TakeOffID,
            int _TakeOffJobID,
            int _jobID,
            string _JobTakeOffID,
            int _NumbID
            )
		{
            this.Group = _Group;
            this.Division =  _Division;
		    this.DivisionCost = _DivisionCost;
			this.DivisionPrint= _DivisionPrint;
            this.Method= _Method;
            this.Input= _Input;
            this.BuildingType= _BuildingType;
            this.Units=  _Units;
            this.Location = _Location;
            this.Description =  _Description;
			this.TakeOff =  _TakeOff;
			this.Active =   _Active;
            this.ActiveJob =  _ActiveJob;
            this.Memo =  _Memo;
			this.TakeOffID =  _TakeOffID;
            this.TakeOffJobID =  _TakeOffJobID;
            this.JobID =  _jobID;
            this.JobTakeOffID = _JobTakeOffID;
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


        public event EventHandler GroupChanged;
        public bool _Group;
        public bool Group
        {
            get { return _Group; }
            set
            {
                _Group = value;
                if (GroupChanged != null) GroupChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ActiveJobChanged;
        public bool _ActiveJob;
        public bool ActiveJob
        {
            get { return _ActiveJob; }
            set
            {
                _ActiveJob = value;
                if (ActiveJobChanged != null) ActiveJobChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler JobTakeOffIDChanged;
        public string _JobTakeOffID;
        public string JobTakeOffID
        {
            get { return _JobTakeOffID; }
            set
            {
                _JobTakeOffID = value;
                if (JobTakeOffIDChanged != null) JobTakeOffIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler JobIDChanged;
        public int _JobID;
        public int JobID
        {
            get { return _JobID; }
            set
            {
                _JobID = value;
                if (JobIDChanged != null) JobIDChanged(this, EventArgs.Empty);
            }
        }

        
        public event EventHandler TakeOffIDChanged;
		public int _TakeOffID;
		public int TakeOffID{get { return _TakeOffID; }
			set {  _TakeOffID= value; 
			if( TakeOffIDChanged != null)  TakeOffIDChanged(this,EventArgs.Empty);}
		}


        public event EventHandler TakeOffJobIDChanged;
        public int _TakeOffJobID;
        public int TakeOffJobID
        {
            get { return _TakeOffJobID; }
            set
            {
                _TakeOffJobID = value;
                if (TakeOffJobIDChanged != null) TakeOffJobIDChanged(this, EventArgs.Empty);
            }
        }
    
        
        public event EventHandler MethodChanged;
		public string _Method;
		public string Method{get { return _Method; }
			set {  _Method= value; 
			if( MethodChanged != null)  MethodChanged(this,EventArgs.Empty);}
		}

		public event EventHandler InputChanged;
		public string _Input;
		public string Input{get { return _Input; }
			set {  _Input= value; 
			if( InputChanged != null)  InputChanged(this,EventArgs.Empty);}
		}





		public event EventHandler BuildingTypeChanged;
		public string _BuildingType;
		public string BuildingType{get { return _BuildingType; }
			set {  _BuildingType = value; 
			if(  BuildingTypeChanged != null)  BuildingTypeChanged(this,EventArgs.Empty);}	
		}


		public event EventHandler DivisionChanged;
		public string _Division;
		public string Division{get { return _Division; }
			set {  _Division = value; 
			if(  DivisionChanged != null)  DivisionChanged(this,EventArgs.Empty);}
		}

		public event EventHandler DivisionCostChanged;
		public string _DivisionCost;
		public string DivisionCost{get { return _DivisionCost; }
			set {  _DivisionCost = value; 
			if(  DivisionCostChanged != null)  DivisionCostChanged(this,EventArgs.Empty);}
		}

		public event EventHandler DivisionPrintChanged;
		public string _DivisionPrint;
		public string DivisionPrint{get { return _DivisionPrint; }
			set {  _DivisionPrint = value; 
		if(  DivisionPrintChanged != null)  DivisionCostChanged(this,EventArgs.Empty);}
		}
	
		public event EventHandler UnitsChanged;
		public string _Units;
		public string Units{get { return _Units; }
			set 
			{
				_Units = value; 
				if(  UnitsChanged != null)  UnitsChanged(this,EventArgs.Empty);}
		}


		public event EventHandler LocationChanged;
		public string _Location;
		public string Location{get { return _Location; }
			set {  _Location = value; 
		if(  LocationChanged != null)  LocationChanged(this,EventArgs.Empty);}}


		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description = value; 
			if(  DescriptionChanged != null)  DescriptionChanged(this,EventArgs.Empty);}
		}
	


		public event EventHandler TakeOffChanged;
		public decimal _TakeOff;
        public decimal TakeOff
        {
            get { return _TakeOff; }
            set {  _TakeOff = value; 
			if(  TakeOffChanged != null)  TakeOffChanged(this,EventArgs.Empty);}
		}

		public event EventHandler ActiveChanged;
		public bool _Active;
		public bool Active{get { return _Active; }
			set {  _Active = value; 
			if(  ActiveChanged != null)  ActiveChanged(this,EventArgs.Empty);}
		}

		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo = value; 
			if(  MemoChanged != null)  MemoChanged(this,EventArgs.Empty);}
		}

	}

	


    public class TakeOffDatas  : ArrayList
    {
        public enum ItemsFields
        {	
            Group,
            Division,
			DivisionCost,
			DivisionPrint,
            Method,
            Input,
            BuildingType,
            Units,
            Location,
            Description,
			TakeOff,
			Active ,
            ActiveJob,
            ContactProjectID,
            ContactCustomerID,
            Memo,
			ProjectID,
			TakeOffID,
            TakeOffJobID,
            jobID,
            JobTakeOffID,
            NumbID
        }
    }

}
