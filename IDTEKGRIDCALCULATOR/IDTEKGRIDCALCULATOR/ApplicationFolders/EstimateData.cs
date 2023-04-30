using System.Text;
using System;
using System.Collections;
using System.ComponentModel;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ReportData.
	/// </summary>
	public class EstimateData
	{



		public  EstimateData():this(null,null,null,null,null,0,null,0,null,null,0,0,0,0,0,0,0,false,0,0,0,0,0,System.DateTime.Now,System.DateTime.Now,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,0,0,null,null,null)
	{
	}
		

		public EstimateData
            (
            string _LocationZipCode,
               string _JobID,
               string _VendorID,
               string _ManufactureID,
               string _ProviderID,
               int _CostItem,
               string _QuantityID,
                int _ItemID,
               string _ExpressionID,
                 string _Expression,
               int _AssemblyID,
               int _CostAmountID,
                int _CostAmt,
               decimal _CostAdjustment,
               decimal _QuantityAdjustment,
               decimal _CostAdjusted,
               decimal _EstimateCost,
               bool _active,
               decimal _QuantityRoundUp,
               decimal _QuantityReuse,
               decimal _QuantityWaste,
               decimal _QuantityMinimum,
               decimal _Quantity,
               System.DateTime _Date,
               System.DateTime _RunDateTime,
               string _User,
               string _BuildingType,
               string _Description,
               string _ZipCode,
               string _Division,
               string _DivisionCost,
               string _DivisionPrint,
               string _Memo,
               string _PhotoCad,
               string _PhotoImage,
               string _CostType,
               string _UnitOrder,
               string _ReportPhase,
               string _ReportContract,
               string _Units,
               string _Location,
               decimal _PiecePerUnitOrder,
               int _NumbID,
               string _job,
               string _owner,
               string _project
            )
		{
            this.JobID = _JobID;
            this.VendorID = _VendorID;
            this.ManufactureID = _ManufactureID;
            this.ProviderID = _ProviderID;
            this.CostItemID = _CostItem;
            this.QuantityID = _QuantityID;
            this.ItemID = _ItemID;
            this.ExpressionID = _ExpressionID;
            this.Expression = _Expression;
            this.AssemblyID = _AssemblyID;
            this.CostAmountID = _CostAmountID;
            this.CostAmt = _CostAmt;
            this.CostAdjustment = _CostAdjustment;
            this.QuantityAdjustment = _QuantityAdjustment;
            this.CostAdjusted = _CostAdjusted;
            this.EstimateCost = _EstimateCost;
            this.QuantityRoundUp = _QuantityRoundUp;
            this.QuantityReuse = _QuantityReuse;
            this.QuantityWaste = _QuantityWaste;
            this.QuantityMinimum = _QuantityMinimum;
            this.Quantity = _Quantity;
            this.RunDateTime = _RunDateTime;
            this.Date = _Date;
            this.Active = _active;
            this.User = _User;
            this.BuildingType = _BuildingType;
            this.Description = _Description;
            this.ZipCode = _ZipCode;
            this.Division = _Division;
            this.DivisionCost = _DivisionCost;
            this.DivisionPrint = _DivisionPrint;
            this.Memo = _Memo;
            this.PhotoCad = _PhotoCad;
            this.PhotoImage = _PhotoImage;
            this.CostType = _CostType;
            this.UnitOrder = _UnitOrder;
            this.ReportPhase = _ReportPhase;
            this.ReportContract = _ReportContract;
            this.Units = _Units;
            this.Location = _Location;
            this.PiecePerUnitOrder = _PiecePerUnitOrder;
            this.NumbID = _NumbID;
            this.Job =  _job;
            this.Owner =   _owner;
            this.Project = _project;
        }

        public string[] getValue()
        {
            string[] _values = new string[45];

            _values.SetValue(this.Active.ToString(), 0);
            _values.SetValue(this.JobID ,1);
            _values.SetValue(this.VendorID ,2);
            _values.SetValue(this.ManufactureID ,3);
            _values.SetValue(this.ProviderID ,4);
            _values.SetValue(this.CostItemID.ToString() ,5);
            _values.SetValue(this.QuantityID ,6);
            _values.SetValue(this.ItemID.ToString() ,7);
            _values.SetValue(this.ExpressionID ,8);
            _values.SetValue(this.Expression ,9);
            _values.SetValue(this.AssemblyID.ToString() ,10);
            _values.SetValue(this.CostAmountID.ToString() ,11);
            _values.SetValue(this.CostAmt.ToString() ,12);
            _values.SetValue(this.CostAdjustment.ToString() ,13);
            _values.SetValue(this.QuantityAdjustment.ToString() ,14);
            _values.SetValue(this.CostAdjusted.ToString() ,15);
            _values.SetValue(this.EstimateCost.ToString() ,16);
            _values.SetValue(this.QuantityRoundUp.ToString() ,17);
            _values.SetValue(this.QuantityReuse.ToString() ,18);
            _values.SetValue(this.QuantityWaste.ToString() ,19);
            _values.SetValue(this.QuantityMinimum.ToString() ,20);
            _values.SetValue(this.Quantity.ToString() ,21);
            _values.SetValue(this.RunDateTime.ToShortDateString(), 22);
            _values.SetValue(this.Date.ToShortDateString() ,23);
            _values.SetValue(this.User, 24);
            _values.SetValue(this.BuildingType, 25);
            _values.SetValue(this.Description, 26);
            _values.SetValue(this.ZipCode ,27);
            _values.SetValue(this.Division ,28);
            _values.SetValue(this.DivisionCost ,29);
            _values.SetValue(this.DivisionPrint ,30);
            _values.SetValue(this.Memo ,31);
            _values.SetValue(this.PhotoCad ,32);
            _values.SetValue(this.PhotoImage ,33);
            _values.SetValue(this.CostType ,34);
            _values.SetValue(this.UnitOrder ,35);
            _values.SetValue(this.ReportPhase ,36);
            _values.SetValue(this.ReportContract ,37);
            _values.SetValue(this.Units ,38);
            _values.SetValue(this.Location ,39);
            _values.SetValue(this.PiecePerUnitOrder.ToString() ,40);
            _values.SetValue(this.NumbID.ToString(), 41);
            _values.SetValue(this.Job, 42);
            _values.SetValue(this.Owner, 43);
            _values.SetValue(this.Project, 44);
            return _values;

        }

      
        public event EventHandler PiecePerUnitOrderChanged;
        public decimal _PiecePerUnitOrder;
        public decimal PiecePerUnitOrder
        {
            get { return _PiecePerUnitOrder; }
            set
            {
                _PiecePerUnitOrder = value;
                if (PiecePerUnitOrderChanged != null) PiecePerUnitOrderChanged(this, EventArgs.Empty);
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

        public event EventHandler ExpressionChanged;
        public string _Expression;
        public string Expression
        {
            get { return _Expression; }
            set
            {
                _Expression = value;
                if (ExpressionChanged != null) ExpressionChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler OwnerChanged;
        public string _Owner;
        public string Owner
        {
            get { return _Owner; }
            set
            {
                _Owner = value;
                if (OwnerChanged != null) OwnerChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler JobChanged;
        public string _Job;
        public string Job
        {
            get { return _Job; }
            set
            {
                _Job = value;
                if (JobChanged != null) JobChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ProjectChanged;
        public string _Project;
        public string Project
        {
            get { return _Project; }
            set
            {
                _Project = value;
                if (ProjectChanged != null) ProjectChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler LocationZipCodeChanged;
        public string _LocationZipCode;
        public string LocationZipCode
        {
            get { return _LocationZipCode; }
            set
            {
                _LocationZipCode = value;
                if (LocationZipCodeChanged != null) LocationZipCodeChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler JobIDChanged;
        public string _JobID;
        public string JobID
        {
            get { return _JobID; }
            set
            {
                _JobID = value;
                if (JobIDChanged != null) JobIDChanged(this, EventArgs.Empty);
            }
        }

        
        public event EventHandler QuantityAdjustmentChanged;
        public decimal _QuantityAdjustment;
        public decimal QuantityAdjustment
        {
            get { return _QuantityAdjustment; }
            set
            {
                _QuantityAdjustment = value;
                if (QuantityAdjustmentChanged != null) QuantityAdjustmentChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler CostAdjustedChanged;
        public decimal _CostAdjusted;
        public decimal CostAdjusted
        {
            get { return _CostAdjusted; }
            set
            {
                _CostAdjusted = value;
                if (CostAdjustedChanged != null) CostAdjustedChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler EstimateCostChanged;
        public decimal _EstimateCost;
        public decimal EstimateCost
        {
            get { return _EstimateCost; }
            set
            {
                _EstimateCost = value;
                if (EstimateCostChanged != null) EstimateCostChanged(this, EventArgs.Empty);
            }
        }




        public event EventHandler CostTypeIDChanged;
        public string _CostType;
        public string CostType
        {
            get { return _CostType; }
            set
            {
                _CostType = value;
                if (CostTypeIDChanged != null) CostTypeIDChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler UnitOrderChanged;
        public string _UnitOrder;
        public string UnitOrder
        {
            get { return _UnitOrder; }
            set
            {
                _UnitOrder = value;
                if (UnitOrderChanged != null) UnitOrderChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler DescriptionChanged;
        public string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                if (DescriptionChanged != null) DescriptionChanged(this, EventArgs.Empty);
            }
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


        public event EventHandler QuantityRoundUpChanged;
        public decimal _QuantityRoundUp;
        public decimal QuantityRoundUp
        {
            get { return _QuantityRoundUp; }
            set
            {
                _QuantityRoundUp = value;
                if (QuantityRoundUpChanged != null) QuantityRoundUpChanged(this, EventArgs.Empty);
            }
        }
        public event EventHandler QuantityReuseChanged;
        public decimal _QuantityReuse;
        public decimal QuantityReuse
        {
            get { return _QuantityReuse; }
            set
            {
                _QuantityReuse = value;
                if (QuantityReuseChanged != null) QuantityReuseChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler QuantityWasteChanged;
        public decimal _QuantityWaste;
        public decimal QuantityWaste
        {
            get { return _QuantityWaste; }
            set
            {
                _QuantityWaste = value;
                if (QuantityWasteChanged != null) QuantityWasteChanged(this, EventArgs.Empty);
            }
        }




        public event EventHandler QuantityMinimumChanged;
        public decimal _QuantityMinimum;
        public decimal QuantityMinimum
        {
            get { return _QuantityMinimum; }
            set
            {
                _QuantityMinimum = value;
                if (QuantityMinimumChanged != null) QuantityMinimumChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler QuantityAdjustedChanged;
        public decimal _QuantityAdjusted;
        public decimal QuantityAdjusted
        {
            get { return _QuantityAdjusted; }
            set
            {
                _QuantityAdjusted = value;
                if (QuantityAdjustedChanged != null) QuantityAdjustedChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler ActiveChanged;
        public bool _Active;
        public bool Active
        {
            get { return _Active; }
            set
            {
                _Active = value;
                if (ActiveChanged != null) ActiveChanged(this, EventArgs.Empty);
            }
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
        public string Division
        {
            get { return _Division; }
            set
            {
                _Division = value;
                if (DivisionChanged != null) DivisionChanged(this, EventArgs.Empty);
            }
        }







        public event EventHandler MemoChanged;
        public string _Memo;
        public string Memo
        {
            get { return _Memo; }
            set
            {
                _Memo = value;
                if (MemoChanged != null) MemoChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ReportPhaseChanged;
        public string _ReportPhase;
        public string ReportPhase
        {
            get { return _ReportPhase; }
            set
            {
                _ReportPhase = value;
                if (ReportPhaseChanged != null) ReportPhaseChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ReportContractChanged;
        public string _ReportContract;
        public string ReportContract
        {
            get { return _ReportContract; }
            set
            {
                _ReportContract = value;
                if (ReportContractChanged != null) ReportContractChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler ItemIDChanged;
        public int _ItemID;
        public int ItemID
        {
            get { return _ItemID; }
            set
            {
                _ItemID = value;
                if (ItemIDChanged != null) ItemIDChanged(this, EventArgs.Empty);
            }
        }







        public event EventHandler QuantityIDChanged;
        public string _QuantityID;
        public string QuantityID
        {
            get { return _QuantityID; }
            set
            {
                _QuantityID = value;
                if (QuantityIDChanged != null) QuantityIDChanged(this, EventArgs.Empty);
            }
        }





        public event EventHandler DivisionPrintChanged;
        public string _DivisionPrint;
        public string DivisionPrint
        {
            get { return _DivisionPrint; }
            set
            {
                _DivisionPrint = value;
                if (DivisionPrintChanged != null) DivisionPrintChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler UnitsChanged;
        public string _Units;
        public string Units
        {
            get { return _Units; }
            set
            {
                _Units = value;
                if (UnitsChanged != null) UnitsChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler LocationChanged;
        public string _Location;
        public string Location
        {
            get { return _Location; }
            set
            {
                _Location = value;
                if (LocationChanged != null) LocationChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler ExpressionIDChanged;
        public string _ExpressionID;
        public string ExpressionID
        {
            get { return _ExpressionID; }
            set
            {
                _ExpressionID = value;
                if (ExpressionIDChanged != null) ExpressionIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler AssemblyIDChanged;
        public int _AssemblyID;
        public int AssemblyID
        {
            get { return _AssemblyID; }
            set
            {
                _AssemblyID = value;
                if (AssemblyIDChanged != null) AssemblyIDChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler QuantityChanged;
        public decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                if (QuantityChanged != null) QuantityChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler RunDateTimeChanged;
        public System.DateTime _RunDateTime;
        public System.DateTime RunDateTime
        {
            get { return _RunDateTime; }
            set
            {
                _RunDateTime = value;
                if (RunDateTimeChanged != null) RunDateTimeChanged(this, EventArgs.Empty);
            }
        }





        public event EventHandler CostAmountIDChanged;
        public int _CostAmountID;
        public int CostAmountID
        {
            get { return _CostAmountID; }
            set
            {
                _CostAmountID = value;
                if (CostAmountIDChanged != null) CostAmountIDChanged(this, EventArgs.Empty);
            }
        }




        public event EventHandler ProviderIDChanged;
        public string _ProviderID;
        public string ProviderID
        {
            get { return _ProviderID; }
            set
            {
                _ProviderID = value;
                if (ProviderIDChanged != null) ProviderIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler UserChanged;
        public string _User;
        public string User
        {
            get { return _User; }
            set
            {
                _User = value;
                if (UserChanged != null) UserChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler DateChanged;
        public System.DateTime _Date;
        public System.DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                if (DateChanged != null) DateChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler BuildingTypeChanged;
        public string _BuildingType;
        public string BuildingType
        {
            get { return _BuildingType; }
            set
            {
                _BuildingType = value;
                if (BuildingTypeChanged != null) BuildingTypeChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler VendorIDChanged;
        public string _VendorID;
        public string VendorID
        {
            get { return _VendorID; }
            set
            {
                _VendorID = value;
                if (VendorIDChanged != null) VendorIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ManufactureIDChanged;
        public string _ManufactureID;
        public string ManufactureID
        {
            get { return _ManufactureID; }
            set
            {
                _ManufactureID = value;
                if (ManufactureIDChanged != null) ManufactureIDChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler ZipCodeChanged;
        public string _ZipCode;
        public string ZipCode
        {
            get { return _ZipCode; }
            set
            {
                _ZipCode = value;
                if (ZipCodeChanged != null) ZipCodeChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler CostAmtChanged;
        public decimal _CostAmt;
        public decimal CostAmt
        {
            get { return _CostAmt; }
            set
            {
                _CostAmt = value;
                if (CostAmtChanged != null) CostAmtChanged(this, EventArgs.Empty);
            }
        }



        public event EventHandler PhotoCadChanged;
        public object _PhotoCad;
        public object PhotoCad
        {
            get { return _PhotoCad; }
            set
            {
                _PhotoCad = value;
                if (PhotoCadChanged != null) PhotoCadChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler PhotoImageChanged;
        public object _PhotoImage;
        public object PhotoImage
        {
            get { return _PhotoImage; }
            set
            {
                _PhotoImage = value;
                if (PhotoImageChanged != null) PhotoImageChanged(this, EventArgs.Empty);
            }
        }



    }



    public class EstimateDatas  : ArrayList
    {
        public enum ItemsFields
        {
            JobID ,
            VendorID ,
            ManufactureID ,
            ProviderID ,
            CostItemID ,
            QuantityID ,
            ItemID ,
            ExpressionID ,
            Expression ,
            AssemblyID ,
            CostAmountID ,
            CostAmt ,
            CostAdjustment ,
            QuantityAdjustment ,
            CostAdjusted ,
            EstimateCost ,
            QuantityRoundUp ,
            QuantityReuse ,
            QuantityWaste ,
            QuantityMinimum ,
            Quantity ,
            RunDateTime,
            Date ,
            Active,
            User ,
            BuildingType ,
            Description ,
            ZipCode ,
            Division ,
            DivisionCost ,
            DivisionPrint ,
            Memo ,
            PhotoCad ,
            PhotoImage ,
            CostType ,
            UnitOrder ,
            ReportPhase ,
            ReportContract ,
            Units ,
            Location ,
            PiecePerUnitOrder,
            NumbID,
            Job,
            Owner,
            Project
        }

       
    }

}
