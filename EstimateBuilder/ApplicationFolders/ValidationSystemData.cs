using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ValidationSystemData.
	/// </summary>
	public class ValidationSystemData
	{
	


		public  ValidationSystemData():this(null,null,null,0,0)
	{
	}

		
		public ValidationSystemData(
			string _Description,
			string _Type,
			string _Memo,			
			int _ValidationSystemID,
            int _NumbID
			)
		{
			this.Description =  _Description;
            this.Type = _Type;
            this.Memo = _Memo;
			this.ValidationSystemID =_ValidationSystemID;
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

        public event EventHandler ValidationSystemIDChanged;
		public int _ValidationSystemID;
		public int ValidationSystemID{get { return _ValidationSystemID; }
			set {  _ValidationSystemID= value; 
				if(  ValidationSystemIDChanged != null) ValidationSystemIDChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description= value; 
			if( DescriptionChanged != null) DescriptionChanged(this,EventArgs.Empty);}
		}


		public event EventHandler TypeChanged;
		public string _Type;
		public string Type{get { return _Type; }
			set {  _Type= value; 
			if( TypeChanged != null) TypeChanged(this,EventArgs.Empty);}
		}


		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo= value; 
			if( MemoChanged != null) MemoChanged(this,EventArgs.Empty);}
		}
	}



    public class ValidationSystemDatas : ArrayList
    {
        public enum ItemsFields
        {

            Description,
			Type,
			Memo,			
			ValidationSystemID,
            NumbID
        }


    }

}
