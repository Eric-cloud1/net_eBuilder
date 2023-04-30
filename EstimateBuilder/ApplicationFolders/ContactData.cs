
using System.Text;
using System;
using System.Collections;
using System.ComponentModel;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ContactData.
	/// </summary>
	public class ContactData
	{

		public ContactData():this(null,null,null,null,null,null,null,null,null,null,null,null,null,0,null,null,null,null,null,0,null,0,0)
		{
		}
		
		public ContactData(

            string _Company,
            string _Title,
            string _FirstName,
            string _MiddleName,
            string _LastName,
            string _Address,
            string _City,
            string _State,
            string _ZipCode,
            string _Region,
            string _Division ,
			string _DivisionCost,
			string  _Contract,
			int _OutlookID,
			string _PhoneVoice,
            string _PhoneFax,
            string _PhoneCell,
            string _Email,
            string _PhoneExtension,
			int _RecordID,			
			string _Memo,
			int _ContactID,
            int _NumID
            )
		{
			this.Company= _Company;
            this.Title =  _Title;
            this.FirstName= _FirstName;
            this.MiddleName= _MiddleName;
            this.LastName=  _LastName;
            this.Address =  _Address;
            this.City =  _City;
            this.State =  _State;
            this.ZipCode =  _ZipCode;
            this.Region =  _Region;
            this.Division =  _Division ;
			this.DivisionCost =  _DivisionCost;
			this.Contract =  _Contract;
			this.OutlookID = _OutlookID;
			this.PhoneVoice = _PhoneVoice;
            this.PhoneFax = _PhoneFax;
            this.PhoneCell = _PhoneCell;
            this.Email = _Email;
            this.PhoneExtension =  _PhoneExtension;
			this.RecordID =  _RecordID;		
			this.Memo = _Memo;
            this.ContactID = _ContactID;
            this.NumbID = _NumID;
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


        public event EventHandler ContactIDChanged;
		public int _ContactID;
		public int ContactID{get { return _ContactID; }
			set {  _ContactID= value; 
			if(ContactIDChanged != null) ContactIDChanged(this,EventArgs.Empty);
			}
		}


		public event EventHandler CompanyChanged;
		public string _Company;
		public string Company{get { return _Company; }
			set {  _Company = value; 
			if(CompanyChanged != null) CompanyChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler LastNameChanged;
		public string _LastName;
		public string LastName{get { return _LastName; }
			set {  _LastName = value; 
			if(LastNameChanged != null) LastNameChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler FirstNameChanged;
		public string _FirstName;
		public string FirstName{get { return _FirstName; }
			set {  _FirstName = value; 
			if(FirstNameChanged != null) FirstNameChanged(this,EventArgs.Empty);
			}
		}

        public event EventHandler MiddleNameChanged;
        public string _MiddleName;
        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                _MiddleName = value;
                if (MiddleNameChanged != null) MiddleNameChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler TitleChanged;
		public string _Title;
		public string Title{get { return _Title; }
			set {  _Title = value; 
			if(TitleChanged != null) TitleChanged(this,EventArgs.Empty);
			}
		}


		public static event EventHandler AddressChanged;
		public string _Address;
		public string Address{get { return _Address; }
			set {  _Address = value; 
			if(AddressChanged != null) AddressChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler CityChanged;
		public string _City;
		public string City{get { return _City; }
			set {  _City = value; 
			if(CityChanged != null) CityChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler StateChanged;
		public string _State;
		public string State{get { return _State; }
			set {  _State = value; 
			if(StateChanged != null) StateChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler ZipCodeChanged;
		public string _ZipCode;
		public string ZipCode{get { return _ZipCode; }
			set {  _ZipCode = value; 
			if(ZipCodeChanged != null) ZipCodeChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler RegionChanged;
		public string _Region;
		public string Region{get { return _Region; }
			set {  _Region = value; 
			if(RegionChanged != null) RegionChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler PhoneVoiceChanged;
		public string _PhoneVoice;
		public string PhoneVoice{get { return _PhoneVoice; }
			set {  _PhoneVoice = value; 
			if(PhoneVoiceChanged != null) PhoneVoiceChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler PhoneExtensionChanged;
		public string _PhoneExtension;
		public string PhoneExtension{get { return _PhoneExtension; }
			set {  _PhoneExtension = value; 
			if(PhoneExtensionChanged != null) PhoneExtensionChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler PhoneCellChanged;
		public string _PhoneCell;
		public string PhoneCell{get { return _PhoneCell; }
			set {  _PhoneCell = value; 
			if(PhoneCellChanged != null) PhoneCellChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler PhoneFaxChanged;
		public string _PhoneFax;
		public string PhoneFax{get { return _PhoneFax; }
			set {  _PhoneFax = value; 
			if(PhoneFaxChanged != null) PhoneFaxChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler EmailChanged;
		public string _Email;
		public string Email{get { return _Email; }
			set {  _Email = value; 
			if(EmailChanged != null) EmailChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler RecordIDChanged;
		public int _RecordID;
		public int RecordID{get { return _RecordID; }
			set {  _RecordID = value; 
			if(RecordIDChanged != null) RecordIDChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler DivisionChanged;
		public string _Division;
		public string Division{get { return _Division; }
			set {  _Division = value; 
			if(DivisionChanged != null) DivisionChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler DivisionCostChanged;
		public string _DivisionCost;
		public string DivisionCost{get { return _DivisionCost; }
			set {  _DivisionCost = value;
			if(DivisionCostChanged != null) DivisionCostChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler ContractChanged;
		public string _Contract;
		public string Contract{get { return _Contract; }
			set {  _Contract = value; 
			if(ContractChanged != null) ContractChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler OutlookIDChanged;
		public int _OutlookID;
		public int OutlookID{get { return _OutlookID; }
			set {  _OutlookID = value; 
			if(OutlookIDChanged != null) OutlookIDChanged(this,EventArgs.Empty);
			}
		}
		public event EventHandler MemoChanged;
		public string _Memo;
		public string Memo{get { return _Memo; }
			set {  _Memo = value; 
			if(MemoChanged != null) MemoChanged(this,EventArgs.Empty);
			}
		}
	}


	
    public class ContactDatas : ArrayList
    {
        public enum ItemsFields
        {
	        Division ,
	        DivisionCost,
	        Contract,
	        OutlookID,
	        Company,
	        FirstName, 
	        LastName,
	        Title,
	        Address,
	        City,
	        State,
	        ZipCode,
	        Region,
	        PhoneVoice,
	        PhoneExtension,
	        PhoneCell,
	        PhoneFax,
	        Email,
	        RecordID,			
	        Memo,
	        ContactID,
            NumID
        }
    }



}