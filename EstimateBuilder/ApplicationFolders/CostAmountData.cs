using System;
using System.Collections;
using System.Text;

namespace EstimateBuilder
{
    /// <summary>
    /// Summary description for CostAmountData.
    /// </summary>
    public class CostAmountData
    {

        public CostAmountData():this(null,System.DateTime.Now,null,0,0,null,null,null,0,false,0,null,null,0,null,null,null,0,0)
        {
        }


        public CostAmountData(
                string _User,
                System.DateTime _Date,
                string _BuildingType,
                int _VendorID,
                int _ManufactureID,
                string _GenericVendor,
                string _Description,
                string _ZipCode,
                decimal _CostAmt,
                bool _active,
                int _CostItem,
                string _Division,
                string _DivisionCost,
                decimal _PiecePerUnitOrder,
                string _Memo,
                object _PhotoCad,
                object _PhotoImage,
                int _CostAmountID,
                int _NumbID
            )
        {

            this.User = _User;
            this.Date = _Date;
            this.BuildingType = _BuildingType;
            this.VendorID = _VendorID;
            this.ManufactureID = _ManufactureID;
            this.GenericVendor = _GenericVendor;
            this.Description = _Description;
            this.ZipCode = _ZipCode;
            this.CostAmt = _CostAmt;
            this.Active = _active;
            this.CostItemID = _CostItem;
            this.Division = _Division;
            this.DivisionCost = _DivisionCost;
            this.PiecePerUnitOrder = _PiecePerUnitOrder;
            this.Memo = _Memo;
            this.PhotoCad = _PhotoCad;
            this.PhotoImage = _PhotoImage;
            this.CostAmountID = _CostAmountID;
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

        public event EventHandler PiecePerUnitOrderChanged;
        public decimal _PiecePerUnitOrder;
        public decimal PiecePerUnitOrder
        {
            get {return _PiecePerUnitOrder; }
            set
            {
                _PiecePerUnitOrder = value;
                if (PiecePerUnitOrderChanged != null) PiecePerUnitOrderChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler CostItemIDChanged;
        public int _CostItemID;
        public int CostItemID
        {
            get { return _CostItemID; }
            set
            {
                _CostItemID = value;
                if (CostItemIDChanged != null) CostItemIDChanged(this, EventArgs.Empty);
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


        public event EventHandler QuantityIDChanged;
        public int _QuantityID;
        public int QuantityID
        {
            get { return _QuantityID; }
            set
            {
                _QuantityID = value;
                if (QuantityIDChanged != null) QuantityIDChanged(this, EventArgs.Empty);
            }
        }


        public event EventHandler GenericVendorChanged;
        public string _GenericVendor;
        public string GenericVendor
        {
            get { return _GenericVendor; }
            set
            {
                _GenericVendor = value;
                if (GenericVendorChanged != null) GenericVendorChanged(this, EventArgs.Empty);
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
        public int _VendorID;
        public int VendorID
        {
            get { return _VendorID; }
            set
            {
                _VendorID = value;
                if (VendorIDChanged != null) VendorIDChanged(this, EventArgs.Empty);
            }
        }

        public event EventHandler ManufactureIDChanged;
        public int _ManufactureID;
        public int ManufactureID
        {
            get { return _ManufactureID; }
            set
            {
                _ManufactureID = value;
                if (ManufactureIDChanged != null) ManufactureIDChanged(this, EventArgs.Empty);
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

    }

    public class CostAmountDatas : ArrayList
    {
        public enum ItemsFields
        {
            User,
            Date,
            BuildingType,
            VendorID,
            ManufactureID,
            GenericVendor,
            Description,
            ZipCode,
            CostAmt,
            active,
            CostItemID,
            Division,
            DivisionCost,
            PiecePerUnitOrder,
            Memo,
            PhotoCad,
            PhotoImage,
            CostAmountID,
            NumbID
        }
    }

}
