using System;
using System.Collections;
using System.Text;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for pullDown.
	/// </summary>
	public class pullDown
	{
		public pullDown()
		{

		}



		public event EventHandler KeyChanged;
		public string _Key;
		public string Key{get { return _Key; }
			set 
			{
				_Key= value; 
				if(KeyChanged != null) KeyChanged(this,EventArgs.Empty);}
		}
	}



	public class PullDowns  : CollectionBase
	{
		public PullDowns ()
		{
		}
		public void Add(pullDown  pullDown)
		{
			this.List.Add(pullDown);
		}
		public void Remove(pullDown  pullDown)
		{
			this.List.Remove(pullDown);
		}
		public pullDown this[int index]
		{
			get
			{
				return (pullDown)base.List[index];
			}
		}
	}
}
