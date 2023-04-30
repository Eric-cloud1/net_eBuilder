using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for SettingsData.
	/// </summary>
	public class SettingData
	{
	


		public SettingData():this(null,null,null)
	{
	}
		
	
		public SettingData(
			string _ViewID,
			string _ViewName,
			string _Layout)
		{


		}



		public event EventHandler ViewIDChanged;
		public string _ViewID;
		public string ViewID{get { return _ViewID; }
			set 
			{
				_ViewID= value; 
				if(ViewIDChanged != null) ViewIDChanged(this,EventArgs.Empty);
			}
		}


		public event EventHandler ViewNameChanged;
		public string _ViewName;
		public string ViewName{get { return _ViewName; }
			set 
			{
				_ViewName = value; 
				if(ViewNameChanged != null) ViewNameChanged(this,EventArgs.Empty);
			}
		}

		public event EventHandler LayoutChanged;
		public string _Layout;
		public string Layout{get { return _Layout; }
			set 
			{
				_Layout = value; 
				if(LayoutChanged != null) LayoutChanged(this,EventArgs.Empty);
			}
		}
		

	}



    public class SettingDatas : CollectionBase
    {
        public SettingDatas()
        {
        }
        public void Add(SettingData setting)
        {
            this.List.Add(setting);
        }
        public void Remove(SettingData setting)
        {
            this.List.Remove(setting);
        }
        public SettingData this[int index]
        {
            get
            {
                return (SettingData)base.List[index];
            }
        }

    }

}
