using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for AssemblyData.
	/// </summary>
	public class AssemblyData
	{
		public AssemblyData():this(null,null,null,null,null,null,0,0)
		{
		}

		
		public AssemblyData(
			string   _Division,
			string  _DivisionCost,
			string   _Description,			
			object  _PhotoCad,
			object  _PhotoImage,
			string  _Memo,
			int   _AssemblyID,
            int _NumbID
			)
		{
			
			this.Division = _Division;
			this.DivisionCost =_DivisionCost;        
            this.Description = _Description;
			this.PhotoCad =_PhotoCad;
			this.PhotoImage =_PhotoImage;
            this.Memo = _Memo;
            this.AssemblyID = _AssemblyID;
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

        
        public event EventHandler AssemblyIDChanged;
		public int _AssemblyID;
		public int AssemblyID{get { return _AssemblyID; }
			set {  _AssemblyID= value; 
			if(AssemblyIDChanged != null) AssemblyIDChanged(this,EventArgs.Empty);}
		}
		
		public event EventHandler DivisionChanged;
		public string _Division;
		public string Division{get { return _Division; }
			set {  _Division= value; 
				if(DivisionChanged != null) DivisionChanged(this,EventArgs.Empty);}
		}

		public event EventHandler DivisionCostChanged;
		public string _DivisionCost;
		public string DivisionCost{get { return _DivisionCost; }
			set {  _DivisionCost= value; 
				if(DivisionCostChanged != null) DivisionCostChanged(this,EventArgs.Empty);}
		}

		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description= value; 
			if(DescriptionChanged != null) DescriptionChanged(this,EventArgs.Empty);}
		}


		public event EventHandler PhotoCadChanged;
		public object _PhotoCad;
		public object PhotoCad{get { return _PhotoCad; }
			set {  _PhotoCad= value; 
				if(PhotoCadChanged != null) PhotoCadChanged(this,EventArgs.Empty);}
		}

		public event EventHandler PhotoImageChanged;
		public object _PhotoImage;
		public object PhotoImage{get { return _PhotoImage; }
			set {  _PhotoImage= value; 
				if(PhotoImageChanged != null) PhotoImageChanged(this,EventArgs.Empty);}		
		}

		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo= value; 
			if(MemoChanged != null) MemoChanged(this,EventArgs.Empty);}
			}

	}
		


    public class AssemblyDatas : ArrayList
    {
        public enum ItemsFields
        {
      		Division,
			DivisionCost,
			Description,			
			PhotoCad,
			PhotoImage,
			Memo,
			AssemblyID,
            NumbID
        }
    }



}
