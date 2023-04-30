using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for Application.
	/// </summary>
	public  class ApplicationBuilder
	{
		public EstimateBuilder.DivisionDataProvider _divisionDataProvider;
		public  ApplicationBuilder()
		{
			
		}



		#region Id
		private static string _id;
        private static string _idJob;
        private static string _Job;
        private static string _quantityJobId;
        private static string _takeoffGroupId;
       

        public static string assemblyId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}
        public static string jobId
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public static string contactId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		} 
		public static string costAmountId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}
 
		public static string costItemId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}
		public static string estimateId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}

		public static string expressionId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}
		public static string quantityId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}

        public static string quantityJobId
        {
            get
            {
                return _quantityJobId;
            }
            set
            {
                _quantityJobId = value;
            }
        }
        public static string takeOffId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}

        public static string takeOffGroup
		{ 
			get 
			{
                return _takeoffGroupId; 
			}
			set
			{
                _takeoffGroupId = value;
			}
		}

        
        public static string takeOffJobId
        {
            get
            {
                return _idJob;
            }
            set
            {
                _idJob = value;
            }
        }

     

        public static string SaveJobId
        {
            get
            {
                return _Job;
            }
            set
            {
                _Job = value;
            }
        }
        public static string validationSystemId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}
		public static string validationUserId 
		{ 
			get 
			{ 
				return _id; 
			}
			set
			{
				_id = value;
			}
		}

		#endregion


		public  static string connection
		{
			get 
			{ 
				string strDir = getDBdirectory(); 

				if ( strDir.Length == 0 ) 
				{ 
					return ""; 
				}

                strDir += "\\jabi.ini";
                FileInfo f = new FileInfo(strDir);
                FileStream fs = f.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader r = new StreamReader(fs);
                string t;
                while ((t = r.ReadLine()) != null)
                {
                    if (t.Substring(0,4)  == "DIR:")
                        strDir = t.Substring(4);
                }
                fs.Close();
             
				System.IO.FileInfo fileInfo = new System.IO.FileInfo( strDir ); 
				if ( !( fileInfo.Exists ) ) 
				{ 
					return ""; 
				} 


				return "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strDir + ";"; 
			} 		
		}

        public static string ExcelEstimate
        {
           
            get
            {
        		 string strDir = getDBdirectory(); 

				        if ( strDir.Length == 0 ) 
				        { 
					        return ""; 
				        }

                        strDir += "\\jabi.ini";
                        FileInfo f = new FileInfo(strDir);
                        FileStream fs = f.Open(FileMode.Open, FileAccess.Read, FileShare.None);
                        StreamReader r = new StreamReader(fs);
                        string t;
                        while ((t = r.ReadLine()) != null)
                        {
                            if (t.Substring(0,5)  == "XLS0:")
                                strDir = t.Substring(5);
                        }
                        fs.Close();
                     
				        System.IO.FileInfo fileInfo = new System.IO.FileInfo( strDir ); 
				        if ( !( fileInfo.Exists ) ) 
				        { 
					        return ""; 
				        } 


				        return   strDir ; 
			        } 
        }
         
        

        public static EstimateBuilder.AssemblyDataProvider AssemblyDataSource
		{					
			get
			{
				EstimateBuilder.AssemblyDataProvider DataSource = new AssemblyDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.ContactDataProvider ContactDataSource
		{					
			get
			{
				EstimateBuilder.ContactDataProvider DataSource = new ContactDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.CostAmountDataProvider CostAmountDataSource
		{					
			get
			{
				EstimateBuilder.CostAmountDataProvider DataSource = new CostAmountDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.CostItemDataProvider CostItemDataSource
		{					
			get
			{
				EstimateBuilder.CostItemDataProvider DataSource = new CostItemDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.JobDataProvider JobDataSource
		{					
			get
			{
				EstimateBuilder.JobDataProvider DataSource = new JobDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.ExpressionDataProvider ExpressionDataSource
		{					
			get
			{
				EstimateBuilder.ExpressionDataProvider DataSource = new ExpressionDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.QuantityDataProvider QuantityDataSource
		{					
			get
			{
				EstimateBuilder.QuantityDataProvider DataSource = new QuantityDataProvider();
				return DataSource;
			}
		}

		
		public static EstimateBuilder.EstimateDataProvider EstimateDataSource
		{					
			get
			{
                EstimateBuilder.EstimateDataProvider DataSource = new EstimateDataProvider();
                return DataSource;
			}
		}


		public static EstimateBuilder.TakeOffDataProvider TakeOffDataSource
		{					
			get
			{
				EstimateBuilder.TakeOffDataProvider DataSource = new TakeOffDataProvider();
				return DataSource;
			}
		}


		public static EstimateBuilder.ValidationSystemDataProvider ValidationSystemDataSource
		{					
			get
			{
				EstimateBuilder.ValidationSystemDataProvider DataSource = new ValidationSystemDataProvider();
				return DataSource;
			}
		}

		public static EstimateBuilder.ValidationUserDataProvider ValidationUserDataSource
		{					
			get
			{
				EstimateBuilder.ValidationUserDataProvider DataSource = new ValidationUserDataProvider();
				return DataSource;
			}
		}




		public  static string getDBdirectory()
		{
			System.IO.DirectoryInfo  currentDirectory = new System.IO.DirectoryInfo(Application.ExecutablePath).Parent;

			while ( !(  currentDirectory == null ) ) 
			{ 
				System.IO.DirectoryInfo[] childDirectories = currentDirectory.GetDirectories(); 
				System.IO.DirectoryInfo childDir = null; 
				foreach ( System.IO.DirectoryInfo transTemp0 in childDirectories ) 
				{ 
					
                    childDir = transTemp0; 
					if (  childDir.Name == "Data"  ) 
					{ 
						return childDir.FullName; 
					} 
				}
				currentDirectory = currentDirectory.Parent; 
			} 
			return ""; 
		}


		private static DataFormEditMode _EditMode1; 
		public static DataFormEditMode EditMode 
		{ 
			get 
			{ 
				return _EditMode1; 
			}
			set
			{
				_EditMode1 = value;
			}
		} 	

		private static OpenContact _EditMode2; 
		public static OpenContact OpenContactMode 
		{ 
			get 
			{ 
				return _EditMode2; 
			}
			set
			{
				_EditMode2 = value;
			}
		} 

		private static OpenTakeOff _EditMode3; 
		public static OpenTakeOff OpenTakeOffMode 
		{ 
			get 
			{ 
				return _EditMode3; 
			}
			set
			{
				_EditMode3 = value;
			}
		}

        private static OpenTakeOffJob _EditMode13;
        public static OpenTakeOffJob OpenTakeOffJobMode
        {
            get
            {
                return _EditMode13;
            }
            set
            {
                _EditMode13 = value;
            }
        }


        private static OpenExpression _EditMode4; 
		public static OpenExpression OpenExpressionMode 
		{ 
			get 
			{ 
				return _EditMode4; 
			}
			set
			{
				_EditMode4 = value;
			}
		} 

		private static OpenQuantity _EditMode5; 
		public static OpenQuantity OpenQuantityMode 
		{ 
			get 
			{ 
				return _EditMode5; 
			}
			set
			{
				_EditMode5 = value;
			}
		}
        private static OpenQuantityJob _EditMode14;
        public static OpenQuantityJob OpenQuantityJobMode
        {
            get
            {
                return _EditMode14;
            }
            set
            {
                _EditMode14 = value;
            }
        }


        private static OpenAssembly _EditMode6; 
		public static OpenAssembly OpenAssemblyMode 
		{ 
			get 
			{ 
				return _EditMode6; 
			}
			set
			{
				_EditMode6 = value;
			}
		} 
		private static OpenCostAmount _EditMode7; 
		public static OpenCostAmount OpenCostAmountMode 
		{ 
			get 
			{ 
				return _EditMode7; 
			}
			set
			{
				_EditMode7 = value;
			}
		} 

		private static OpenCostItem _EditMode8; 
		public static OpenCostItem OpenCostItemMode 
		{ 
			get 
			{ 
				return _EditMode8; 
			}
			set
			{
				_EditMode8 = value;
			}
		}


		private static OpenJob _EditMode9; 
		public static OpenJob OpenJobMode 
		{ 
			get 
			{ 
				return _EditMode9; 
			}
			set
			{
				_EditMode9 = value;
			}
		}
		private static OpenValidationUser _EditMode10; 
		public static OpenValidationUser OpenValidationUserMode 
		{ 
			get 
			{ 
				return _EditMode10; 
			}
			set
			{
				_EditMode10 = value;
			}
		}


		private static OpenValidationSystem _EditMode11; 
		public static OpenValidationSystem OpenValidationSystemMode 
		{ 
			get 
			{ 
				return _EditMode11; 
			}
			set
			{
				_EditMode11 = value;
			}
		}

		private static OpenEstimate _EditMode12; 
		public static OpenEstimate OpenEstimateMode 
		{ 
			get 
			{ 
				return _EditMode12; 
			}
			set
			{
				_EditMode12 = value;
			}
		}

        private static SaveExpression _EditMode16;
        public static SaveExpression SaveExpressionMode
        {
            get
            {
                return _EditMode16;
            }
            set
            {
                _EditMode16 = value;
            }
        }


        private static int _XAssembly;
        public static int XAssembly
        {
            get
            {
                return _XAssembly;
            }
            set
            {
                _XAssembly = value;
            }
        }

        private static int _YAssembly;
        public static int YAssembly
        {
            get
            {
                return _YAssembly;
            }
            set
            {
                _YAssembly = value;
            }
        }


        private static int _XContact;
        public static int XContact
        {
            get
            {
                return _XContact;
            }
            set
            {
                _XContact = value;
            }
        }

        private static int _YContact;
        public static int YContact
        {
            get
            {
                return _YContact;
            }
            set
            {
                _YContact = value;
            }
        }



        private static int _XCostAmount;
        public static int XCostAmount
        {
            get
            {
                return _XCostAmount;
            }
            set
            {
                _XCostAmount = value;
            }
        }

        private static int _YCostAmount;
        public static int YCostAmount
        {
            get
            {
                return _YCostAmount;
            }
            set
            {
                _YCostAmount = value;
            }
        }

        private static int _XCostItem;
        public static int XCostItem
        {
            get
            {
                return _XCostItem;
            }
            set
            {
                _XCostItem = value;
            }
        }

        private static int _YCostItem;
        public static int YCostItem
        {
            get
            {
                return _YCostItem;
            }
            set
            {
                _YCostItem = value;
            }
        }

        private static int _XEstimate;
        public static int XEstimate
        {
            get
            {
                return _XEstimate;
            }
            set
            {
                _XEstimate = value;
            }
        }

        private static int _YEstimate;
        public static int YEstimate
        {
            get
            {
                return _YEstimate;
            }
            set
            {
                _YEstimate = value;
            }
        }

        private static int _XExpression;
        public static int XExpression
        {
            get
            {
                return _XExpression;
            }
            set
            {
                _XExpression = value;
            }
        }

        private static int _YExpression;
        public static int YExpression
        {
            get
            {
                return _YExpression;
            }
            set
            {
                _YExpression = value;
            }
        }

        private static int _XJob;
        public static int XJob
        {
            get
            {
                return _XJob;
            }
            set
            {
                _XJob = value;
            }
        }

        private static int _YJob;
        public static int YJob
        {
            get
            {
                return _YJob;
            }
            set
            {
                _YJob = value;
            }
        }

        private static int _XQuantity;
        public static int XQuantity
        {
            get
            {
                return _XQuantity;
            }
            set
            {
                _XQuantity = value;
            }
        }

        private static int _YQuantity;
        public static int YQuantity
        {
            get
            {
                return _YQuantity;
            }
            set
            {
                _YQuantity = value;
            }
        }

        private static int _XTakeoff;
        public static int XTakeoff
        {
            get
            {
                return _XTakeoff;
            }
            set
            {
                _XTakeoff = value;
            }
        }

        private static int _YTakeoff;
        public static int YTakeoff
        {
            get
            {
                return _YTakeoff;
            }
            set
            {
                _YTakeoff = value;
            }
        }

        private static int _XValidationSystem;
        public static int XValidationSystem
        {
            get
            {
                return _XValidationSystem;
            }
            set
            {
                _XValidationSystem = value;
            }
        }

        private static int _YValidationSystem;
        public static int YValidationSystem
        {
            get
            {
                return _YValidationSystem;
            }
            set
            {
                _YValidationSystem = value;
            }
        }

        private static int _XValidationUser;
        public static int XValidationUser
        {
            get
            {
                return _XValidationUser;
            }
            set
            {
                _XValidationUser = value;
            }
        }

        private static int _YValidationUser;
        public static int YValidationUser
        {
            get
            {
                return _YValidationUser;
            }
            set
            {
                _YValidationUser = value;
            }
        }

    }
}

public enum OpenContact
{ 
	On,
	Off
}
public enum SaveExpression
{
    True,
    False
}
public enum OpenTakeOff
{ 
	On,
	Off
}

public enum OpenTakeOffJob
{
    On,
    Off
}
public enum OpenExpression
{ 
	On,
	Off
}

public enum OpenQuantity
{ 
	On,
	Off
}

public enum OpenQuantityJob
{
    On,
    Off
}

public enum OpenAssembly
{ 
	On,
	Off
}

public enum OpenCostAmount
{ 
	On,
	Off
}

public enum OpenCostItem
{ 
	On,
	Off
}
public enum OpenEstimate
{ 
	On,
	Off
}
public enum OpenValidationUser
{ 
	On,
	Off
}
public enum OpenValidationSystem
{ 
	On,
	Off
}
public enum OpenJob
{ 
	On,
	Off
}



public enum DataFormEditMode 
{ 
	Edit,
	AddNew,
	Insert,
	Delete,
	Open,
	Close
}



