using System;
using System.Collections;
using System.Text;
using System.Data;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for DivisionData.
	/// </summary>
	public class DivisionDataAssembly
	{


		public DivisionDataAssembly():this("","")
		{
		}

		
		public DivisionDataAssembly(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataContact
	{


		public DivisionDataContact():this("","")
		{
		}

		
		public DivisionDataContact(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataCostAmount
	{


		public DivisionDataCostAmount():this("","")
		{
		}

		
		public DivisionDataCostAmount(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}


	public class DivisionDataCostItem
	{


		public DivisionDataCostItem():this("","")
		{
		}

		
		public DivisionDataCostItem(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataJob
	{


		public DivisionDataJob():this("","")
		{
		}

		
		public DivisionDataJob(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}



	public class DivisionDataExpression
	{


		public DivisionDataExpression():this("","")
		{
		}

		
		public DivisionDataExpression(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataQuantity
	{


		public DivisionDataQuantity():this("","")
		{
		}

		
		public DivisionDataQuantity(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataEstimate
	{


		public DivisionDataEstimate():this("","")
		{
		}

		
		public DivisionDataEstimate(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataTakeOff
	{


		public DivisionDataTakeOff():this("","")
		{
		}

		
		public DivisionDataTakeOff(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}



    public class DivisionDataTakeOffJob
    {


        public DivisionDataTakeOffJob():this("","")
        {
        }


        public DivisionDataTakeOffJob(

            string _DivisionKey,
            string _DivisionValue
            )
        {
            this.DivisionKey = _DivisionKey;
            this.DivisionValue = _DivisionValue;


        }



        public event EventHandler DivisionKeyChanged;
        public string _DivisionKey;
        public string DivisionKey
        {
            get { return _DivisionKey; }
            set
            {
                _DivisionKey = value;
                if (DivisionKeyChanged != null) DivisionKeyChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler DivisionValueChanged;
        public string _DivisionValue;
        public string DivisionValue
        {
            get { return _DivisionValue; }
            set
            {
                _DivisionValue = value;
                if (DivisionValueChanged != null) DivisionValueChanged(this, EventArgs.Empty);
            }
        }

    }

    public class DivisionDataValidationSystem
	{


		public DivisionDataValidationSystem():this("","")
		{
		}

		
		public DivisionDataValidationSystem(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDataValidationUser
	{


		public DivisionDataValidationUser():this("","")
		{
		}

		
		public DivisionDataValidationUser(
	
			string   _DivisionKey,
			string  _DivisionValue
			)
		{
			this.DivisionKey =  _DivisionKey;
			this.DivisionValue = _DivisionValue;
			
		
		}



		public event EventHandler DivisionKeyChanged;
		public string _DivisionKey;
		public string DivisionKey{get { return _DivisionKey; }
			set 
			{
				_DivisionKey= value; 
				if(DivisionKeyChanged != null) DivisionKeyChanged(this,EventArgs.Empty);}
		}


		public event EventHandler DivisionValueChanged;
		public string _DivisionValue;
		public string DivisionValue{get { return _DivisionValue; }
			set 
			{
				_DivisionValue= value; 
				if(DivisionValueChanged != null) DivisionValueChanged(this,EventArgs.Empty);}
		}
		
	}

	public class DivisionDatasAssembly : CollectionBase
	{
		public DivisionDatasAssembly()
		{
		}
		public void Add(DivisionDataAssembly assembly)
		{
			this.List.Add(assembly);
		}
		public void Remove(DivisionDataAssembly assembly)
		{
			this.List.Remove(assembly);
		}
		public DivisionDataAssembly this[int index]
		{
			get
			{
				return (DivisionDataAssembly)base.List[index];
			}
		}
	}

	public class DivisionDatasContact : CollectionBase
	{
		public DivisionDatasContact()
		{
		}
		public void Add(DivisionDataContact Contact)
		{
			this.List.Add(Contact);
		}
		public void Remove(DivisionDataContact Contact)
		{
			this.List.Remove(Contact);
		}
		public DivisionDataContact this[int index]
		{
			get
			{
				return (DivisionDataContact)base.List[index];
			}
		}
	}

	public class DivisionDatasCostAmount : CollectionBase
	{
		public DivisionDatasCostAmount()
		{
		}
		public void Add(DivisionDataCostAmount CostAmount)
		{
			this.List.Add(CostAmount);
		}
		public void Remove(DivisionDataCostAmount CostAmount)
		{
			this.List.Remove(CostAmount);
		}
		public DivisionDataCostAmount this[int index]
		{
			get
			{
				return (DivisionDataCostAmount)base.List[index];
			}
		}
	}

	public class DivisionDatasCostItem : CollectionBase
	{
		public DivisionDatasCostItem()
		{
		}
		public void Add(DivisionDataCostItem CostItem)
		{
			this.List.Add(CostItem);
		}
		public void Remove(DivisionDataCostItem CostItem)
		{
			this.List.Remove(CostItem);
		}
		public DivisionDataCostItem this[int index]
		{
			get
			{
				return (DivisionDataCostItem)base.List[index];
			}
		}
	}

	public class DivisionDatasJob : CollectionBase
	{
		public DivisionDatasJob()
		{
		}
		public void Add(DivisionDataJob Job)
		{
			this.List.Add(Job);
		}
		public void Remove(DivisionDataJob Job)
		{
			this.List.Remove(Job);
		}
		public DivisionDataJob this[int index]
		{
			get
			{
				return (DivisionDataJob)base.List[index];
			}
		}
	}

	public class DivisionDatasExpression : CollectionBase
	{
		public DivisionDatasExpression()
		{
		}
		public void Add(DivisionDataExpression Expression)
		{
			this.List.Add(Expression);
		}
		public void Remove(DivisionDataExpression Expression)
		{
			this.List.Remove(Expression);
		}
		public DivisionDataExpression this[int index]
		{
			get
			{
				return (DivisionDataExpression)base.List[index];
			}
		}
	}

	public class DivisionDatasQuantity : CollectionBase
	{
		public DivisionDatasQuantity()
		{
		}
		public void Add(DivisionDataQuantity Quantity)
		{
			this.List.Add(Quantity);
		}
		public void Remove(DivisionDataQuantity Quantity)
		{
			this.List.Remove(Quantity);
		}
		public DivisionDataQuantity this[int index]
		{
			get
			{
				return (DivisionDataQuantity)base.List[index];
			}
		}
	}


	public class DivisionDatasEstimate : CollectionBase
	{
		public DivisionDatasEstimate()
		{
		}
		public void Add(DivisionDataEstimate Estimate)
		{
			this.List.Add(Estimate);
		}
		public void Remove(DivisionDataEstimate Estimate)
		{
			this.List.Remove(Estimate);
		}
		public DivisionDataEstimate this[int index]
		{
			get
			{
				return (DivisionDataEstimate)base.List[index];
			}
		}
	}

	public class DivisionDatasTakeOff : CollectionBase
	{
		public DivisionDatasTakeOff()
		{
		}
		public void Add(DivisionDataTakeOff TakeOff)
		{
			this.List.Add(TakeOff);
		}
		public void Remove(DivisionDataTakeOff TakeOff)
		{
			this.List.Remove(TakeOff);
		}
		public DivisionDataTakeOff this[int index]
		{
			get
			{
				return (DivisionDataTakeOff)base.List[index];
			}
		}
	}

    public class DivisionDatasTakeOffJob : CollectionBase
    {
        public DivisionDatasTakeOffJob()
        {
        }
        public void Add(DivisionDataTakeOffJob TakeOffJob)
        {
            this.List.Add(TakeOffJob);
        }
        public void Remove(DivisionDataTakeOffJob TakeOffJob)
        {
            this.List.Remove(TakeOffJob);
        }
        public DivisionDataTakeOffJob this[int index]
        {
            get
            {
                return (DivisionDataTakeOffJob)base.List[index];
            }
        }
    }

    public class DivisionDatasValidationSystem : CollectionBase
	{
		public DivisionDatasValidationSystem()
		{
		}
		public void Add(DivisionDataValidationSystem ValidationSystem)
		{
			this.List.Add(ValidationSystem);
		}
		public void Remove(DivisionDataValidationSystem ValidationSystem)
		{
			this.List.Remove(ValidationSystem);
		}
		public DivisionDataValidationSystem this[int index]
		{
			get
			{
				return (DivisionDataValidationSystem)base.List[index];
			}
		}
	}

	public class DivisionDatasValidationUser : CollectionBase
	{
		public DivisionDatasValidationUser()
		{
		}
		public void Add(DivisionDataValidationUser ValidationUser)
		{
			this.List.Add(ValidationUser);
		}
		public void Remove(DivisionDataValidationUser ValidationUser)
		{
			this.List.Remove(ValidationUser);
		}
		public DivisionDataValidationUser this[int index]
		{
			get
			{
				return (DivisionDataValidationUser)base.List[index];
			}
		}
	}



}
