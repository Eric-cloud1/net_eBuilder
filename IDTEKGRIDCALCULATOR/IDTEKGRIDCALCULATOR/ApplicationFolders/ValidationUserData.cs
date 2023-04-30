using System;
using System.Collections;
using System.Text;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ValidationUserData.
	/// </summary>
	public class ValidationUserData
	{
	
		public  ValidationUserData():this(null,null,false,false,null,null,null,0,0)
	{
	}


		public ValidationUserData(
				string _Group,
				string _Type,
				bool  _Active ,
				bool _Pulldown,
				string  _Code,
				string  _Description,
				string _Memo,
				int _ValidationUserID,
                int _NumbID
			)
		{
            this.Group = _Group;
            this.Type = _Type;
            this.Active =  _Active ;
            this.Pulldown = _Pulldown;
            this.Code = _Code;
			this.Description = _Description;
			this.Memo = _Memo;
			this.ValidationUserID =_ValidationUserID;
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


        
        public event EventHandler ValidationUserIDChanged;
		public int _ValidationUserID;
		public int ValidationUserID{get { return _ValidationUserID; }
			set {  _ValidationUserID= value; 
			if(  ValidationUserIDChanged != null) ValidationUserIDChanged(this,EventArgs.Empty);}
		}

		public event EventHandler GroupChanged;
		public string _Group;
		public string Group{get { return _Group; }
			set {  _Group = value; 
			if(  GroupChanged != null) GroupChanged(this,EventArgs.Empty);}
		}

		public event EventHandler TypeChanged;
		public string _Type;
		public string Type{get { return _Type; }
			set {  _Type = value; 
			if(  TypeChanged != null) TypeChanged(this,EventArgs.Empty);}
		}

		public event EventHandler ActiveChanged;
		public bool _Active;
		public bool Active{get { return _Active; }
			set {  _Active = value; 
			if(  ActiveChanged != null) ActiveChanged(this,EventArgs.Empty);}
		}

		public event EventHandler PulldownChanged;
		public bool _Pulldown;
		public bool Pulldown{get { return _Pulldown; }
			set {  _Pulldown = value; 
			if(  PulldownChanged != null) PulldownChanged(this,EventArgs.Empty);}
		}

		public event EventHandler CodeChanged;
		public string _Code;
		public string Code{get { return _Code; }
			set {  _Code = value; 
			if(CodeChanged != null) CodeChanged(this,EventArgs.Empty);}
		}
		public event EventHandler DescriptionChanged;
		public string _Description;
		public string Description{get { return _Description; }
			set {  _Description = value; 
			if(DescriptionChanged != null) DescriptionChanged(this,EventArgs.Empty);}
		}
		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo = value; 
			if(MemoChanged != null) MemoChanged(this,EventArgs.Empty);}
		}

	}



    public class ValidationUserDatas : ArrayList
    {
        public enum ItemsFields
        {
		    Group,
		    Type,
		    Active ,
		    Pulldown,
		    Code,
		    Description,
		    Memo,
		    ValidationUserID,
            NumbID
        }
    }

}
