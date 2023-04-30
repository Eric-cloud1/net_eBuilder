using System.ComponentModel;
using IDIGITALTEKGRID;
using System.Text;
using Microsoft.VisualBasic;		 
using Janus.Windows.GridEX; 
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for Grid.
	/// </summary>
	public class Grid : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		
	
		protected  Janus.Windows.GridEX.GridEX GridEX; 
		protected  Janus.Windows.GridEX.GridEXPrintDocument printDocument; 
		protected  Janus.Windows.UI.CommandBars.UIRebar TopRebar1; 
		protected  Janus.Windows.UI.CommandBars.UIContextMenu cmHeader; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdView; 


		protected  Janus.Windows.UI.CommandBars.UICommand cmdShowFields; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdSort; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdGroupBy; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdFormatView; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdAutomaticFormatting; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdViewSummary; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdSortAscending; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdSortDescending; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdGroupByThisField; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdGroupByBox; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdRemoveThisColumn; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdColumnAlignment; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdBestFit; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdAlignLeft; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdAlignRight; 
		protected  Janus.Windows.UI.CommandBars.UICommand cmdAlignCenter; 

	

        private Janus.Windows.UI.CommandBars.UICommand cmdSortAscendingContext;
        private Janus.Windows.UI.CommandBars.UICommand cmdSortDescendingContext;
        protected Janus.Windows.UI.CommandBars.UICommand cmdSeparator1;
        private Janus.Windows.UI.CommandBars.UICommand cmdGroupByThisFieldContext;
        protected Janus.Windows.UI.CommandBars.UICommand cmdSeparator2;
        private Janus.Windows.UI.CommandBars.UICommand cmdRemoveThisColumnContext;
        protected Janus.Windows.UI.CommandBars.UICommand cmdSeparator3;
        private Janus.Windows.UI.CommandBars.UICommand cmdBestFitContext;
        protected  Janus.Windows.UI.CommandBars.UICommand Separator1; 


		internal   Janus.Windows.UI.CommandBars.UIRebar BottomRebar1; 
		internal   Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        protected Janus.Windows.UI.CommandBars.UICommandManager uiCmdManagerMenuBar;


		private Janus.Windows.UI.CommandBars.UICommand Separator2;
		private Janus.Windows.UI.CommandBars.UICommand cmdNewItem;

		private Janus.Windows.UI.CommandBars.UICommand Separator3;

		private Janus.Windows.UI.CommandBars.UICommand cmdPrintPreview;
	
		private Janus.Windows.UI.CommandBars.UICommand Separator4;
		private Janus.Windows.UI.CommandBars.UICommand cmdDelete;

		private Janus.Windows.UI.CommandBars.UICommandBar tbEdit;
		private Janus.Windows.UI.CommandBars.UICommand cmdImport;
        private Janus.Windows.UI.CommandBars.UICommand cmdFilter;
        internal   Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
		private Janus.Windows.UI.CommandBars.UICommand cmdNewItemMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdViewSummaryMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdPrintPreviewMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdDeleteMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdImportMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdFilterMenu;
		private Janus.Windows.UI.CommandBars.UICommand Separator5;
		private Janus.Windows.UI.CommandBars.UICommand cmdShowFieldsMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdSortMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdGroupByMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdFormatViewMenu;
		private Janus.Windows.UI.CommandBars.UICommand cmdAutomaticFormattingMenu;
		private Janus.Windows.UI.CommandBars.UICommand Separator6;
		private Janus.Windows.UI.CommandBars.UICommand cmdShowFields3;
		private Janus.Windows.UI.CommandBars.UICommand cmdSort3;
		private Janus.Windows.UI.CommandBars.UICommand cmdGroupBy3;
		private Janus.Windows.UI.CommandBars.UICommand cmdFormatView3;
		private Janus.Windows.UI.CommandBars.UICommand cmdAutomaticFormatting3;
		private Janus.Windows.UI.CommandBars.UICommand cmdViewContext;
        private Janus.Windows.UI.CommandBars.UICommand cmdFieldChooser;
        private Janus.Windows.UI.CommandBars.UICommand Separator7;
        private Janus.Windows.UI.CommandBars.UICommand cmdSaveViewMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdSaveView;
        public ComboBox dlSelectView;
        private Label lbSelectView;
        private Janus.Windows.UI.CommandBars.UICommand cmdColapse;
        private Janus.Windows.UI.CommandBars.UICommand cmdColapseMenu;
        private Janus.Windows.UI.CommandBars.UICommand Separator8;
        private Janus.Windows.UI.CommandBars.UICommand cmdExportViewMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdExportView;
        private Janus.Windows.UI.CommandBars.UICommand cmdSaveMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdSave;
        private OpenFileDialog openFileDialog1;
        private Janus.Windows.UI.CommandBars.UICommand cmdCopyRowMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdCopyRow;
        protected static bool _colapse;
        protected static bool _checkGroup = false;



        public Grid()  : base() 
		{
			//
			// Required for Windows Form Designer support
			//
            InitializeComponent();


        }

        #region '" Windows Form Designer generated code "'

        [System.Diagnostics.DebuggerStepThrough()]
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdView = new Janus.Windows.UI.CommandBars.UICommand("cmdView");
            this.cmdShowFields3 = new Janus.Windows.UI.CommandBars.UICommand("cmdShowFields");
            this.cmdSort3 = new Janus.Windows.UI.CommandBars.UICommand("cmdSort");
            this.cmdGroupBy3 = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupBy");
            this.cmdFormatView3 = new Janus.Windows.UI.CommandBars.UICommand("cmdFormatView");
            this.cmdAutomaticFormatting3 = new Janus.Windows.UI.CommandBars.UICommand("cmdAutomaticFormatting");
            this.Separator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdShowFields = new Janus.Windows.UI.CommandBars.UICommand("cmdShowFields");
            this.cmdSort = new Janus.Windows.UI.CommandBars.UICommand("cmdSort");
            this.cmdGroupBy = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupBy");
            this.cmdFormatView = new Janus.Windows.UI.CommandBars.UICommand("cmdFormatView");
            this.cmdAutomaticFormatting = new Janus.Windows.UI.CommandBars.UICommand("cmdAutomaticFormatting");
            this.cmdViewSummary = new Janus.Windows.UI.CommandBars.UICommand("cmdViewSummary");
            this.cmdSortAscending = new Janus.Windows.UI.CommandBars.UICommand("cmdSortAscending");
            this.cmdSortDescending = new Janus.Windows.UI.CommandBars.UICommand("cmdSortDescending");
            this.cmdGroupByThisField = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupByThisField");
            this.cmdGroupByBox = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupByBox");
            this.cmdRemoveThisColumn = new Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn");
            this.cmdColumnAlignment = new Janus.Windows.UI.CommandBars.UICommand("cmdColumnAlignment");
            this.cmdBestFit = new Janus.Windows.UI.CommandBars.UICommand("cmdBestFit");
            this.cmdAlignLeft = new Janus.Windows.UI.CommandBars.UICommand("cmdAlignLeft");
            this.cmdAlignRight = new Janus.Windows.UI.CommandBars.UICommand("cmdAlignRight");
            this.cmdAlignCenter = new Janus.Windows.UI.CommandBars.UICommand("cmdAlignCenter");
            this.cmdSortAscendingContext = new Janus.Windows.UI.CommandBars.UICommand("cmdSortAscending");
            this.cmdSortDescendingContext = new Janus.Windows.UI.CommandBars.UICommand("cmdSortDescending");
            this.cmdSeparator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdGroupByThisFieldContext = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupByThisField");
            this.cmdSeparator2 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdRemoveThisColumnContext = new Janus.Windows.UI.CommandBars.UICommand("cmdRemoveThisColumn");
            this.cmdSeparator3 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdBestFitContext = new Janus.Windows.UI.CommandBars.UICommand("cmdBestFit");
            this.GridEX = new Janus.Windows.GridEX.GridEX();
            this.printDocument = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.uiCmdManagerMenuBar = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.tbEdit = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.cmdColapseMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdColapse");
            this.cmdImportMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExportViewMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdExportView");
            this.Separator8 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdNewItemMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdNewItem");
            this.cmdViewSummaryMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdViewSummary");
            this.cmdPrintPreviewMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdPrintPreview");
            this.cmdDeleteMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdDelete");
            this.cmdFilterMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdFilter");
            this.Separator5 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdShowFieldsMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdShowFields");
            this.cmdSortMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdSort");
            this.cmdGroupByMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdGroupBy");
            this.cmdFormatViewMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdFormatView");
            this.cmdAutomaticFormattingMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdAutomaticFormatting");
            this.Separator7 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdSaveViewMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdSaveView");
            this.cmdSaveMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdSave");
            this.cmdColapse = new Janus.Windows.UI.CommandBars.UICommand("cmdColapse");
            this.cmdNewItem = new Janus.Windows.UI.CommandBars.UICommand("cmdNewItem");
            this.cmdPrintPreview = new Janus.Windows.UI.CommandBars.UICommand("cmdPrintPreview");
            this.cmdDelete = new Janus.Windows.UI.CommandBars.UICommand("cmdDelete");
            this.cmdImport = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdFilter = new Janus.Windows.UI.CommandBars.UICommand("cmdFilter");
            this.cmdFieldChooser = new Janus.Windows.UI.CommandBars.UICommand("cmdFieldChooser");
            this.cmdSaveView = new Janus.Windows.UI.CommandBars.UICommand("cmdSaveView");
            this.cmdExportView = new Janus.Windows.UI.CommandBars.UICommand("cmdExportView");
            this.cmdSave = new Janus.Windows.UI.CommandBars.UICommand("cmdSave");
            this.cmHeader = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.Separator6 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdViewContext = new Janus.Windows.UI.CommandBars.UICommand("cmdView");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.lbSelectView = new System.Windows.Forms.Label();
            this.dlSelectView = new System.Windows.Forms.ComboBox();
            this.Separator2 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.Separator3 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.Separator4 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdCopyRow = new Janus.Windows.UI.CommandBars.UICommand("cmdCopyRow");
            this.cmdCopyRowMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdCopyRow");
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            this.SuspendLayout();

            //this.loadsettings();
            // 
            // cmdView
            // 
            this.cmdView.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdShowFields3,
            this.cmdSort3,
            this.cmdGroupBy3,
            this.cmdFormatView3,
            this.cmdAutomaticFormatting3});
            this.cmdView.Key = "cmdView";
            this.cmdView.MergeType = Janus.Windows.UI.CommandBars.CommandMergeType.MergeItems;
            this.cmdView.Name = "cmdView";
            this.cmdView.Text = "View";
            // 
            // cmdShowFields3
            // 
            this.cmdShowFields3.Key = "cmdShowFields";
            this.cmdShowFields3.Name = "cmdShowFields3";
            // 
            // cmdSort3
            // 
            this.cmdSort3.Key = "cmdSort";
            this.cmdSort3.Name = "cmdSort3";
            // 
            // cmdGroupBy3
            // 
            this.cmdGroupBy3.Key = "cmdGroupBy";
            this.cmdGroupBy3.Name = "cmdGroupBy3";
            // 
            // cmdFormatView3
            // 
            this.cmdFormatView3.Key = "cmdFormatView";
            this.cmdFormatView3.Name = "cmdFormatView3";
            // 
            // cmdAutomaticFormatting3
            // 
            this.cmdAutomaticFormatting3.Key = "cmdAutomaticFormatting";
            this.cmdAutomaticFormatting3.Name = "cmdAutomaticFormatting3";
            // 
            // Separator1
            // 
            this.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator1.Key = "Separator";
            this.Separator1.Name = "Separator1";
            // 
            // cmdShowFields
            // 
            this.cmdShowFields.Key = "cmdShowFields";
            this.cmdShowFields.Name = "cmdShowFields";
            this.cmdShowFields.Text = "Fields...";
            // 
            // cmdSort
            // 
            this.cmdSort.Key = "cmdSort";
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Text = "Sort...";
            // 
            // cmdGroupBy
            // 
            this.cmdGroupBy.Key = "cmdGroupBy";
            this.cmdGroupBy.Name = "cmdGroupBy";
            this.cmdGroupBy.Text = "Group By...";
            // 
            // cmdFormatView
            // 
            this.cmdFormatView.Key = "cmdFormatView";
            this.cmdFormatView.Name = "cmdFormatView";
            this.cmdFormatView.Text = "Format View...";
            // 
            // cmdAutomaticFormatting
            // 
            this.cmdAutomaticFormatting.Key = "cmdAutomaticFormatting";
            this.cmdAutomaticFormatting.Name = "cmdAutomaticFormatting";
            this.cmdAutomaticFormatting.Text = "Formatting...";
            // 
            // cmdViewSummary
            // 
            this.cmdViewSummary.Key = "cmdViewSummary";
            this.cmdViewSummary.Name = "cmdViewSummary";
            this.cmdViewSummary.Text = "View...";
            // 
            // cmdSortAscending
            // 
            this.cmdSortAscending.ImageIndex = 6;
            this.cmdSortAscending.Key = "cmdSortAscending";
            this.cmdSortAscending.Name = "cmdSortAscending";
            this.cmdSortAscending.Text = "Sort &Ascending";
            // 
            // cmdSortDescending
            // 
            this.cmdSortDescending.ImageIndex = 7;
            this.cmdSortDescending.Key = "cmdSortDescending";
            this.cmdSortDescending.Name = "cmdSortDescending";
            this.cmdSortDescending.Text = "Sort &Descending";
            // 
            // cmdGroupByThisField
            // 
            this.cmdGroupByThisField.ImageIndex = 0;
            this.cmdGroupByThisField.Key = "cmdGroupByThisField";
            this.cmdGroupByThisField.Name = "cmdGroupByThisField";
            this.cmdGroupByThisField.Text = "&Group By This Field";
            // 
            // cmdGroupByBox
            // 
            this.cmdGroupByBox.CommandType = Janus.Windows.UI.CommandBars.CommandType.ToggleButton;
            this.cmdGroupByBox.Key = "cmdGroupByBox";
            this.cmdGroupByBox.Name = "cmdGroupByBox";
            this.cmdGroupByBox.Text = "Group &By Box";
            this.cmdGroupByBox.ToolTipText = "Group By Box";
            // 
            // cmdRemoveThisColumn
            // 
            this.cmdRemoveThisColumn.Key = "cmdRemoveThisColumn";
            this.cmdRemoveThisColumn.Name = "cmdRemoveThisColumn";
            this.cmdRemoveThisColumn.Text = "&Remove This Column";
            // 
            // cmdColumnAlignment
            // 
            this.cmdColumnAlignment.Key = "cmdColumnAlignment";
            this.cmdColumnAlignment.Name = "cmdColumnAlignment";
            // 
            // cmdBestFit
            // 
            this.cmdBestFit.Key = "cmdBestFit";
            this.cmdBestFit.Name = "cmdBestFit";
            this.cmdBestFit.Text = "Best &Fit";
            // 
            // cmdAlignLeft
            // 
            this.cmdAlignLeft.ImageIndex = 3;
            this.cmdAlignLeft.Key = "cmdAlignLeft";
            this.cmdAlignLeft.Name = "cmdAlignLeft";
            this.cmdAlignLeft.Text = "Align &Left";
            // 
            // cmdAlignRight
            // 
            this.cmdAlignRight.ImageIndex = 5;
            this.cmdAlignRight.Key = "cmdAlignRight";
            this.cmdAlignRight.Name = "cmdAlignRight";
            this.cmdAlignRight.Text = "Align &Right";
            // 
            // cmdAlignCenter
            // 
            this.cmdAlignCenter.ImageIndex = 4;
            this.cmdAlignCenter.Key = "cmdAlignCenter";
            this.cmdAlignCenter.Name = "cmdAlignCenter";
            this.cmdAlignCenter.Text = "&Center";
            // 
            // cmdSortAscendingContext
            // 
            this.cmdSortAscendingContext.Key = "cmdSortAscending";
            this.cmdSortAscendingContext.Name = "cmdSortAscendingContext";
            // 
            // cmdSortDescendingContext
            // 
            this.cmdSortDescendingContext.Key = "cmdSortDescending";
            this.cmdSortDescendingContext.Name = "cmdSortDescendingContext";
            // 
            // cmdSeparator1
            // 
            this.cmdSeparator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.cmdSeparator1.Key = "Separator";
            this.cmdSeparator1.Name = "cmdSeparator1";
            // 
            // cmdGroupByThisFieldContext
            // 
            this.cmdGroupByThisFieldContext.Key = "cmdGroupByThisField";
            this.cmdGroupByThisFieldContext.Name = "cmdGroupByThisFieldContext";
            // 
            // cmdSeparator2
            // 
            this.cmdSeparator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.cmdSeparator2.Key = "Separator";
            this.cmdSeparator2.Name = "cmdSeparator2";
            // 
            // cmdRemoveThisColumnContext
            // 
            this.cmdRemoveThisColumnContext.Key = "cmdRemoveThisColumn";
            this.cmdRemoveThisColumnContext.Name = "cmdRemoveThisColumnContext";
            // 
            // cmdSeparator3
            // 
            this.cmdSeparator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.cmdSeparator3.Key = "Separator";
            this.cmdSeparator3.Name = "cmdSeparator3";
            // 
            // cmdBestFitContext
            // 
            this.cmdBestFitContext.Key = "cmdBestFit";
            this.cmdBestFitContext.Name = "cmdBestFitContext";
            // 
            // GridEX
            // 
            this.GridEX.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.GridEX.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
            this.GridEX.Location = new System.Drawing.Point(0, 56);
            this.GridEX.Name = "GridEX";
            this.GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.GridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.GridEX.Size = new System.Drawing.Size(808, 555);
            this.GridEX.TabIndex = 1;
            this.GridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.GridEX.CellEdited += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GridEX_CellEdited);
            this.GridEX.SelectionChanged += new System.EventHandler(this.GridEX_SelectionChanged);
            this.GridEX.DoubleClick += new System.EventHandler(this.GridEX_DoubleClick);
            this.GridEX.DropDown += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GridEX_DropDown);
            this.GridEX.RecordAdded += new System.EventHandler(this.GridEX_RecordAdded);
            this.GridEX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GridEX_MouseUp);


            // 
            // printDocument
            // 
            this.printDocument.GridEX = this.GridEX;
            this.printDocument.PrintCellBackground = false;
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.AllowMerge = false;
            this.uiCmdManagerMenuBar.BottomRebar = this.BottomRebar1;
            this.uiCmdManagerMenuBar.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.tbEdit});
            this.uiCmdManagerMenuBar.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdColapse,
            this.cmdView,
            this.cmdShowFields,
            this.cmdSort,
            this.cmdGroupBy,
            this.cmdFormatView,
            this.cmdAutomaticFormatting,
            this.cmdViewSummary,
            this.cmdSortAscending,
            this.cmdSortDescending,
            this.cmdGroupByThisField,
            this.cmdGroupByBox,
            this.cmdRemoveThisColumn,
            this.cmdColumnAlignment,
            this.cmdBestFit,
            this.cmdAlignLeft,
            this.cmdAlignRight,
            this.cmdAlignCenter,
            this.cmdNewItem,
            this.cmdPrintPreview,
            this.cmdDelete,
            this.cmdImport,
            this.cmdFilter,
            this.cmdFieldChooser,
            this.cmdSaveView,
            this.cmdExportView,
            this.cmdSave,
            this.cmdCopyRow});
            this.uiCmdManagerMenuBar.ContainerControl = this;
            this.uiCmdManagerMenuBar.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmHeader});
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            this.uiCmdManagerMenuBar.Id = new System.Guid("deb99014-92e4-4dbc-b2ca-598d67fccefe");
            this.uiCmdManagerMenuBar.LeftRebar = this.LeftRebar1;
            this.uiCmdManagerMenuBar.RightRebar = this.RightRebar1;
            this.uiCmdManagerMenuBar.TopRebar = this.TopRebar1;
            this.uiCmdManagerMenuBar.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.commandManager_CommandClick);
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandManager = this.uiCmdManagerMenuBar;
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 0);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(0, 0);
            this.BottomRebar1.TabIndex = 0;
            // 
            // tbEdit
            // 
            this.tbEdit.CommandManager = this.uiCmdManagerMenuBar;
            this.tbEdit.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdCopyRowMenu,
            this.cmdColapseMenu,
            this.cmdImportMenu,
            this.cmdExportViewMenu,
            this.Separator8,
            this.cmdNewItemMenu,
            this.cmdViewSummaryMenu,
            this.cmdPrintPreviewMenu,
            this.cmdDeleteMenu,
            this.cmdFilterMenu,
            this.Separator5,
            this.cmdShowFieldsMenu,
            this.cmdSortMenu,
            this.cmdGroupByMenu,
            this.cmdFormatViewMenu,
            this.cmdAutomaticFormattingMenu,
            this.Separator7,
            this.cmdSaveViewMenu,
            this.cmdSaveMenu});
            this.tbEdit.Key = "tbEdit";
            this.tbEdit.Location = new System.Drawing.Point(0, 0);
            this.tbEdit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.RowIndex = 0;
            this.tbEdit.Size = new System.Drawing.Size(779, 26);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.Text = "Edit";
            // 
            // cmdColapseMenu
            // 
            this.cmdColapseMenu.Key = "cmdColapse";
            this.cmdColapseMenu.Name = "cmdColapseMenu";
            this.cmdColapseMenu.Text = "Cola&pse ";
            // 
            // cmdImportMenu
            // 
            this.cmdImportMenu.Key = "cmdImport";
            this.cmdImportMenu.Name = "cmdImportMenu";
            this.cmdImportMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            // 
            // cmdExportViewMenu
            // 
            this.cmdExportViewMenu.Key = "cmdExportView";
            this.cmdExportViewMenu.Name = "cmdExportViewMenu";
            this.cmdExportViewMenu.Text = "E&xport";
            // 
            // Separator8
            // 
            this.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator8.Key = "Separator";
            this.Separator8.Name = "Separator8";
            // 
            // cmdNewItemMenu
            // 
            this.cmdNewItemMenu.Key = "cmdNewItem";
            this.cmdNewItemMenu.Name = "cmdNewItemMenu";
            this.cmdNewItemMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.cmdNewItemMenu.Text = "New";
            // 
            // cmdViewSummaryMenu
            // 
            this.cmdViewSummaryMenu.Key = "cmdViewSummary";
            this.cmdViewSummaryMenu.Name = "cmdViewSummaryMenu";
            this.cmdViewSummaryMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.cmdViewSummaryMenu.Text = "View";
            // 
            // cmdPrintPreviewMenu
            // 
            this.cmdPrintPreviewMenu.Key = "cmdPrintPreview";
            this.cmdPrintPreviewMenu.Name = "cmdPrintPreviewMenu";
            this.cmdPrintPreviewMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            // 
            // cmdDeleteMenu
            // 
            this.cmdDeleteMenu.Key = "cmdDelete";
            this.cmdDeleteMenu.Name = "cmdDeleteMenu";
            this.cmdDeleteMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.cmdDeleteMenu.Text = "&Delete";
            // 
            // cmdFilterMenu
            // 
            this.cmdFilterMenu.Key = "cmdFilter";
            this.cmdFilterMenu.Name = "cmdFilterMenu";
            this.cmdFilterMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            // 
            // Separator5
            // 
            this.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator5.Key = "Separator";
            this.Separator5.Name = "Separator5";
            // 
            // cmdShowFieldsMenu
            // 
            this.cmdShowFieldsMenu.Key = "cmdShowFields";
            this.cmdShowFieldsMenu.Name = "cmdShowFieldsMenu";
            this.cmdShowFieldsMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.cmdShowFieldsMenu.Text = "Fiel&ds";
            // 
            // cmdSortMenu
            // 
            this.cmdSortMenu.Key = "cmdSort";
            this.cmdSortMenu.Name = "cmdSortMenu";
            this.cmdSortMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.cmdSortMenu.Text = "Sort";
            // 
            // cmdGroupByMenu
            // 
            this.cmdGroupByMenu.Key = "cmdGroupBy";
            this.cmdGroupByMenu.Name = "cmdGroupByMenu";
            this.cmdGroupByMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.cmdGroupByMenu.Text = "Group";
            // 
            // cmdFormatViewMenu
            // 
            this.cmdFormatViewMenu.Key = "cmdFormatView";
            this.cmdFormatViewMenu.Name = "cmdFormatViewMenu";
            this.cmdFormatViewMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.cmdFormatViewMenu.Text = "Format";
            // 
            // cmdAutomaticFormattingMenu
            // 
            this.cmdAutomaticFormattingMenu.Key = "cmdAutomaticFormatting";
            this.cmdAutomaticFormattingMenu.Name = "cmdAutomaticFormattingMenu";
            this.cmdAutomaticFormattingMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF;
            this.cmdAutomaticFormattingMenu.Text = "Formatting";
            // 
            // Separator7
            // 
            this.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator7.Key = "Separator";
            this.Separator7.Name = "Separator7";
            // 
            // cmdSaveViewMenu
            // 
            this.cmdSaveViewMenu.Key = "cmdSaveView";
            this.cmdSaveViewMenu.Name = "cmdSaveViewMenu";
            this.cmdSaveViewMenu.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV;
            this.cmdSaveViewMenu.Text = "Save V&iew";
            // 
            // cmdSaveMenu
            // 
            this.cmdSaveMenu.Key = "cmdSave";
            this.cmdSaveMenu.Name = "cmdSaveMenu";
            this.cmdSaveMenu.Text = "Sa&ve";
            // 
            // cmdColapse
            // 
            this.cmdColapse.Key = "cmdColapse";
            this.cmdColapse.Name = "cmdColapse";
            this.cmdColapse.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cmdColapse.Text = "Colapse ";
            // 
            // cmdNewItem
            // 
            this.cmdNewItem.Key = "cmdNewItem";
            this.cmdNewItem.Name = "cmdNewItem";
            this.cmdNewItem.Text = "New...";
            // 
            // cmdPrintPreview
            // 
            this.cmdPrintPreview.Key = "cmdPrintPreview";
            this.cmdPrintPreview.Name = "cmdPrintPreview";
            this.cmdPrintPreview.Text = "Print";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Key = "cmdDelete";
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Text = "Delete";
            // 
            // cmdImport
            // 
            this.cmdImport.Key = "cmdImport";
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Text = "Import";
            // 
            // cmdFilter
            // 
            this.cmdFilter.Key = "cmdFilter";
            this.cmdFilter.Name = "cmdFilter";
            this.cmdFilter.Text = "Filter";
            // 
            // cmdFieldChooser
            // 
            this.cmdFieldChooser.Key = "cmdFieldChooser";
            this.cmdFieldChooser.Name = "cmdFieldChooser";
            this.cmdFieldChooser.Text = "FieldChooser";
            // 
            // cmdSaveView
            // 
            this.cmdSaveView.Key = "cmdSaveView";
            this.cmdSaveView.Name = "cmdSaveView";
            this.cmdSaveView.Text = "Save View";
            // 
            // cmdExportView
            // 
            this.cmdExportView.Key = "cmdExportView";
            this.cmdExportView.Name = "cmdExportView";
            this.cmdExportView.Text = "Export";
            // 
            // cmdSave
            // 
            this.cmdSave.Key = "cmdSave";
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Text = "Save";
            // 
            // cmHeader
            // 
            this.cmHeader.CommandManager = this.uiCmdManagerMenuBar;
            this.cmHeader.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdSortAscendingContext,
            this.cmdSortDescendingContext,
            this.cmdSeparator1,
            this.cmdGroupByThisFieldContext,
            this.cmdSeparator2,
            this.cmdRemoveThisColumnContext,
            this.cmdSeparator3,
            this.cmdBestFitContext,
            this.Separator6,
            this.cmdViewContext});
            this.cmHeader.Key = "HeaderMenu";
            this.cmHeader.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmHeader_CommandClick);
            // 
            // Separator6
            // 
            this.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator6.Key = "Separator";
            this.Separator6.Name = "Separator6";
            // 
            // cmdViewContext
            // 
            this.cmdViewContext.Key = "cmdView";
            this.cmdViewContext.Name = "cmdViewContext";
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.uiCmdManagerMenuBar;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 0);
            this.LeftRebar1.TabIndex = 0;
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.uiCmdManagerMenuBar;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(0, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 0);
            this.RightRebar1.TabIndex = 0;
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.tbEdit});
            this.TopRebar1.CommandManager = this.uiCmdManagerMenuBar;
            this.TopRebar1.Controls.Add(this.lbSelectView);
            this.TopRebar1.Controls.Add(this.dlSelectView);
            this.TopRebar1.Controls.Add(this.tbEdit);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.MinimumSize = new System.Drawing.Size(0, 56);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(808, 56);
            this.TopRebar1.TabIndex = 0;
            // 
            // lbSelectView
            // 
            this.lbSelectView.AutoSize = true;
            this.lbSelectView.Location = new System.Drawing.Point(484, 31);
            this.lbSelectView.Name = "lbSelectView";
            this.lbSelectView.Size = new System.Drawing.Size(59, 13);
            this.lbSelectView.TabIndex = 2;
            this.lbSelectView.Text = "Select View";
            // 
            // dlSelectView
            // 
            this.dlSelectView.FormattingEnabled = true;
            this.dlSelectView.Location = new System.Drawing.Point(554, 28);
            this.dlSelectView.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.dlSelectView.Name = "dlSelectView";
            this.dlSelectView.Size = new System.Drawing.Size(190, 21);
            this.dlSelectView.TabIndex = 1;
            this.dlSelectView.SelectionChangeCommitted += new System.EventHandler(this.dlSelectView_SelectionChangeCommitted);
            // 
            // Separator2
            // 
            this.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator2.Key = "Separator";
            this.Separator2.Name = "Separator2";
            // 
            // Separator3
            // 
            this.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator3.Key = "Separator";
            this.Separator3.Name = "Separator3";
            // 
            // Separator4
            // 
            this.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator4.Key = "Separator";
            this.Separator4.Name = "Separator4";
            // 
            // cmdCopyRow
            // 
            this.cmdCopyRow.Key = "cmdCopyRow";
            this.cmdCopyRow.Name = "cmdCopyRow";
            this.cmdCopyRow.Text = "Copy &Row";
            // 
            // cmdCopyRowMenu
            // 
            this.cmdCopyRowMenu.Key = "cmdCopyRow";
            this.cmdCopyRowMenu.Name = "cmdCopyRowMenu";
            // 
            // Grid
            // 

            this.ClientSize = new System.Drawing.Size(808, 611);
            this.Controls.Add(this.GridEX);
            this.Controls.Add(this.TopRebar1);
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        [System.ComponentModel.Browsable(true)]



        public virtual void Init()
        {
            loadsettings();
        }


        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
                    try
                    {
                        components.Dispose();
                    }
                    catch { }
                }
			}
			base.Dispose( disposing );
		}

        public string[] settings = new string[3];
        public void loadsettings()
        {

            string _Grid = this.GetType().FullName;

            IDIGITALTEKGRID.ListDataProvider list = new IDIGITALTEKGRID.ListDataProvider();
            this.dlSelectView.DataSource = list.UserValidationView();
            this.dlSelectView.DisplayMember = "Description";
            this.dlSelectView.ValueMember = "Description";


            settings = list.SelectGridView(_Grid);
            if (settings[0] != "")
            {
                this.dlSelectView.SelectedValue = settings[0];
            }
            else
            {
                this.dlSelectView.SelectedValue = "Default";
            }

        }


		public virtual void  load()
		{
            loadsettings();
       
        
        }

		public virtual void  load(string _id)
		{
            this.resizeColumn();
		
		}
		public virtual void ShowNewItemDialog()
		{
		
		}
		public virtual void addItem()
		{

		}
	
		public void getDropDown(string _columns)
		{
			this.GridEX.RootTable.Columns[_columns].HasValueList = true;
			this.GridEX.RootTable.Columns[_columns].EditType = EditType.Combo;
			this.GridEX.RootTable.Columns[_columns].ColumnType = ColumnType.ImageAndText;

		}

		public static string GetColumnFriendlyName( GridEXColumn column ) 
		{ 
			if ( column.Caption.Length == 0 & !( ( column.Tag == null ) ) ) 
			{ 
				return System.Convert.ToString( column.Tag ); 
			} 
			else 
			{ 
				return column.Caption; 
			} 
		} 
        

	
    
		public Object CurrentItem 
		{ 
			get 
			{ 
				GridEXRow currentRow = null; 
				currentRow = GridEX.GetRow();
                //if (!(Janus.Windows.GridEX.GridEX.i.IsNothing(currentRow)) && currentRow.RowType == RowType.Record)

                if ( currentRow.RowType == RowType.Record)
                { 
					return ( ( DataRowView )( currentRow.DataRow ) ).Row; 
				} 
				else 
				{ 
					return null; 
				} 
			} 
		} 
		public  bool candelete 
		{ 
			get 
			{ 
				if ( this.GridEX.AllowDelete == Janus.Windows.GridEX.InheritableBoolean.True ) 
				{ 							
					GridEXSelectedItem item = null; 
					foreach ( Janus.Windows.GridEX.GridEXSelectedItem transtemp1 in  GridEX.SelectedItems ) 
					{ 
						item = transtemp1; 
						if ( item.RowType == RowType.Record ) 
						{ 
							return true; 
						} 
					}
				} 
				return false; 
			} 
		} 
		public  bool CanEdit 
		{ 
			get 
			{ 
				GridEXSelectedItem item = null; 
				foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp2 in GridEX.SelectedItems ) 
				{ 
					item = transTemp2; 
					if ( item.RowType == RowType.Record ) 
					{ 
						return true; 
					} 
				}
				return false; 
			} 
		} 
		


		#region Event Handler
		public event EventHandler CurrentItemChanged; 
		protected virtual void OnCurrentItemChanged( EventArgs e ) 
		{ 
			if ( null!= CurrentItemChanged ) CurrentItemChanged( this, e );
            //this.SaveData();

        }
		protected void GridEX_SelectionChanged( Object sender, System.EventArgs e ) 
		{ 
		//OnCurrentItemChanged( EventArgs.Empty ); 
            OnCurrentItemChanged(e);
            

        } 
		protected void GridEX_CurrentLayoutChanged(object sender, System.EventArgs e)
		{

		}
		protected void GridEX_CurrentLayoutChanging(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}
		protected  void GridEX_DoubleClick( Object sender, System.EventArgs e ) 
		{ 
			//if(IDIGITALTEKGRID.ApplicationBuilder.EditMode != DataFormEditMode.Open)
			//{
				GridArea clickArea = GridEX.HitTest(); 
				switch ( clickArea ) 
				{
					case GridArea.CellButton:				
						IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Open;
						this.Edit();				
						break;



                    default:
						break;
				}
		//	}
		
		}

        protected void GridEX_RecordAdded(Object sender, System.EventArgs e) 
		{ 
			
		    
		}

        

		protected  virtual  void GridEX_GetNewRow(object sender, Janus.Windows.GridEX.GetNewRowEventArgs e)
		{
			//Since an IList doesn´t have a method to add a new empty object,
			//Like a DataTable or a DataView has, create a new instance of the class 
			//the list contains and pass it to the GridEX control as the new record 
			//in which the control should copy the values entered by the user.
			//GridEX control will be responsible for adding it to the list.
			//e.NewRow = new ContactData();

			//Note: this event should not be handled if you are using an IBindingList as datasource
		}
		#endregion

		
		#region Menu ShowDialog	View 

		public void ShowDeleteDialog()
		{
			 this.Delete();
		}
		public void ShowViewSummaryDialog() 
		{ 
			frmViewSummary frm = new frmViewSummary(); 
			frm.ShowDialog( this.GridEX, this.ParentForm, this ); 
			
		} 
		public virtual void ShowImportViewDialog() 
		{
            
           // frmImport frm = new frmImport();
          //  frm.ShowDialog(this.GridEX, this.ParentForm, this, dataSource);
  	 			
		} 
		public void  ShowPrintPreviewDialog()
		{
			frmPrintPreview preview = new frmPrintPreview();
			preview.Show(this.printDocument, this.ParentForm);
			
		}
		public void ShowSortDialog() 
		{ 
			frmSort frm = new frmSort(); 
			frm.ShowDialog( this.GridEX, this.ParentForm ); 
			

		}    
		public void ShowFieldsDialog() 
		{ 
			frmShowFields frm = new frmShowFields(); 
			frm.ShowDialog( this.GridEX, this.ParentForm ); 
			
		}   
		public void ShowFormatViewDialog() 
		{ 
			frmFormatView frm = new frmFormatView(); 
			frm.ShowDialog( this.GridEX, this.ParentForm ); 
			
		}     
		public void ShowFormatConditionsDialog() 
		{ 
			frmFormatConditions frm = new frmFormatConditions(); 
			frm.ShowDialog( this.GridEX, this.ParentForm ); 
	 
		} 
		public void ShowGroupByDialog() 
		{ 
			frmGroupBy frm = new frmGroupBy(); 
			frm.ShowDialog( GridEX, this.ParentForm ); 
		
		} 
        public virtual void ShowSaveDialog()
        {
         
             for (int i = 1; i < this.MdiParent.MdiChildren.Length; i++)
             {
                 this.MdiParent.MdiChildren[i].Refresh();
             }
             //this.Close();

         }
        public virtual void ShowSaveLayoutDialog()
        {
            this.SaveSettings();
            for (int i = 1; i < this.MdiParent.MdiChildren.Length; i++)
            {
                 this.MdiParent.MdiChildren[i].Refresh();
            }



        }
        public void ShowFilterDialog()
        {
            IDIGITALTEKGRID.frmFilter filterDialog = new frmFilter();
            if (filterDialog.ShowDialog(this.GridEX.RootTable) == DialogResult.OK)
            {
                MessageBox.Show(GridEX.RecordCount + " rows(s) found.");
            }

        }
        public  void  ShowCurrentViewDialog()
		{
		//	this.LoadSettings();
		}
		public virtual void Edit() 
		{
            UpdateChanges();
            this.GridEX.Update();

        }
		public virtual void UpdateData() 
		{
            string _ViewName = this.GetType().FullName;
            _ViewName = "All Fields." + _ViewName;
            LoadSettings(_ViewName, true);
            UpdateChanges();
            this.GridEX.Update();
        }
		public virtual void Delete() 
		{ 
		
		}
		#endregion

		#region Context menu Command
		protected void GridEX_MouseUp( Object sender, System.Windows.Forms.MouseEventArgs e ) 
		{ 
			if ( e.Button == MouseButtons.Right ) 
			{ 
				if ( GridEX.HitTest( e.X, e.Y ) == GridArea.ColumnHeader ) 
				{ 
					GridEXColumn colClicked = GridEX.ColumnFromPoint( e.X, e.Y ); 
					//if ( !( Information.IsNothing( colClicked ) ) ) 
					if(colClicked!=null)
                    { 
						this.ShowHeaderMenu( colClicked ); 
					} 
				} 
			} 
		}
        protected virtual void GridEX_DropDown(Object sender, ColumnActionEventArgs e)
        {
        }


        public  void resizeColumn()
        {
            foreach (GridEXColumn column in this.GridEX.RootTable.Columns)
            {
                column.AutoSize();
            }
          
        }


        public GridEXColumn mContextMenuColumn; 
		protected void ShowHeaderMenu( GridEXColumn column ) 
		{ 
					
			mContextMenuColumn = column; 
			// Check SortAscending/SortDescending menus if the column is sorted
			if ( System.Convert.ToInt64( mContextMenuColumn.SortOrder ) == System.Convert.ToInt64(  Janus.Windows.GridEX.SortOrder.Ascending ) ) 
			{ 
				this.cmdSortAscending.IsChecked = true; 
			} 
			else 
			{ 
				this.cmdSortAscending.IsChecked = false; 
			} 
			if ( System.Convert.ToInt64( mContextMenuColumn.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Descending ) ) 
			{ 
				this.cmdSortDescending.IsChecked = true; 
			} 
			else 
			{ 
				this.cmdSortDescending.IsChecked = false; 
			} 
				
			if ( mContextMenuColumn.Group == null ) 
			{ 
				this.cmdGroupByThisField.Text = "&Group By This Field"; 
			} 
			else 
			{ 
				this.cmdGroupByThisField.Text = "Don't &Group By This Field"; 
			} 
					
			if ( this.GridEX.GroupByBoxVisible ) 
			{ 
				this.cmdGroupByBox.IsChecked = true; 
			} 
			else 
			{ 
				this.cmdGroupByBox.IsChecked = false; 
			} 
			if ( mContextMenuColumn.ColumnType == ColumnType.CheckBox ) 
			{ 
				this.cmdColumnAlignment.IsEnabled = false; 
			} 
			else 
			{ 
				this.cmdColumnAlignment.IsEnabled = true; 
				this.cmdAlignRight.IsChecked = ( mContextMenuColumn.TextAlignment == TextAlignment.Far ); 
				this.cmdAlignCenter.IsChecked = ( mContextMenuColumn.TextAlignment == TextAlignment.Center ); 
				this.cmdAlignLeft.IsChecked = ( mContextMenuColumn.TextAlignment == TextAlignment.Near | mContextMenuColumn.TextAlignment == TextAlignment.Empty ); 
			} 
			if ( ( this.GridEX.View !=  Janus.Windows.GridEX.View.TableView | this.GridEX.RootTable.CellLayoutMode == CellLayoutMode.UseColumnSets ) ) 
			{ 
				this.cmdFieldChooser.IsEnabled = false; 
			} 
			else 
			{ 
				this.cmdFieldChooser.IsEnabled = true; 
			} 
			if ( mContextMenuColumn.Table.CellLayoutMode == CellLayoutMode.UseColumnSets ) 
			{ 
				this.cmdRemoveThisColumn.IsEnabled = false; 
			} 
			else 
			{ 
				this.cmdRemoveThisColumn.IsEnabled = true; 
			} 
			if ( GridEX.IsFieldChooserVisible() ) 
			{ 
				this.uiCmdManagerMenuBar.Commands[ "cmdFieldChooser" ].Checked = Janus.Windows.UI.InheritableBoolean.True; 
			} 
			else 
			{ 
				this.uiCmdManagerMenuBar.Commands[ "cmdFieldChooser" ].Checked = Janus.Windows.UI.InheritableBoolean.False; 
			} 
			this.cmHeader.Show( this.GridEX ); 
			mContextMenuColumn = null; 
		} 
		public  bool Printable 
		{ 
			get 
			{ 
				return true; 
			} 
		} 
		public  Janus.Windows.UI.CommandBars.UICommandManager ControlCommandManager 
		{ 
			get 
			{ 
				return uiCmdManagerMenuBar; 
			} 
		} 
		public void commandManager_CommandClick( System.Object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e ) 
		{ 
			switch ( e.Command.Key ) 
			{
                case "cmdColapse":
                    if (this.GridEX.GroupMode == Janus.Windows.GridEX.GroupMode.Collapsed)
                    {
                        this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
                        _colapse = true;
                        this.GridEX.Refetch();
                    }
                    else
                    {
                        this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
                        _colapse = false;
                        this.GridEX.Refetch();
                    }
                    break;
                case "cmdShowFields":
					ShowFieldsDialog(); 
					break;
                case "cmdCopyRow":
                    this.InsertData();
                    break;
				case "cmdSort":
					ShowSortDialog(); 
					break;
				case "cmdGroupBy":
					ShowGroupByDialog(); 
					break;
				case "cmdFormatView":
					this.ShowFormatViewDialog(); 
					break;
				case "cmdAutomaticFormatting":
					this.ShowFormatConditionsDialog(); 
					break;
				case "cmdViewSummary":
					this.ShowViewSummaryDialog(); 
					break;
				case "cmdNewItem":
					this.ShowNewItemDialog(); 
					break;		
				case "cmdPrintPreview":
					this.ShowPrintPreviewDialog(); 
					break;
				case "cmdDelete":
					this.ShowDeleteDialog(); 
					break;
				case "cmdCurrentView":
					this.ShowCurrentViewDialog(); 
					break;	
				case "cmdImport":
					this.ShowImportViewDialog(); 
					break;	
				case "cmdFilter":
					this.ShowFilterDialog(); 
					break;
                case "cmdSave":
                    this.ShowSaveDialog();
                    break;
                case "cmdSaveView":
                    this.ShowSaveLayoutDialog();
                    break;
                case "cmdExportView":
                    this.ShowExportViewDialog();
                    break;
                default:
					this.cmHeader_CommandClick( cmHeader, e ); 
					break;
			}
            
		} 
		#endregion

		#region Header   				
		protected void cmHeader_CommandClick( System.Object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e ) 
		{ 
			switch ( e.Command.Key ) 
			{
                case "cmdColapse":
                    if (this.GridEX.GroupMode == Janus.Windows.GridEX.GroupMode.Collapsed)
                    {
                        this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
                        this.GridEX.Refetch();
                    }
                    else
                    {
                        this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
                        this.GridEX.Refetch();
                    }
                    break;
                case "cmdSortAscending":
					OnSortAscendingCommand(); 
					break;
				case "cmdSortDescending":
					OnSortDescendingCommand(); 
					break;
				case "cmdGroupByThisField":
					OnGroupByThisFieldCommand(); 
					break;
				case "cmdGroupByBox":
					OnGroupByBoxCommand(); 
					break;
				case "cmdRemoveThisColumn":
					OnRemoveThisColumnCommand(); 
					break;
				case "cmdBestFit":
					mContextMenuColumn.AutoSize(); 
					break;
				case "cmdShowFields":
					ShowFieldsDialog(); 
					break;
				case "cmdSort":
					ShowSortDialog(); 
					break;
				case "cmdGroupBy":
					ShowGroupByDialog(); 
					break;
				case "cmdFormatView":
					this.ShowFormatViewDialog(); 
					break;
				case "cmdAutomaticFormatting":
					this.ShowFormatConditionsDialog(); 
					break;
				case "cmdAlignLeft":
					mContextMenuColumn.TextAlignment = TextAlignment.Near; 
					break;
				case "cmdAlignRight":
					mContextMenuColumn.TextAlignment = TextAlignment.Far; 
					break;
				case "cmdAlignCenter":
					mContextMenuColumn.TextAlignment = TextAlignment.Center; 
					break;
                 case "cmdExportView":
                      this.ShowExportViewDialog();
                      break;
				
			}
            
		} 
        					
		protected void OnSortAscendingCommand() 
		{ 
			if ( !( mContextMenuColumn.Group == null ) ) 
			{ 
				mContextMenuColumn.Group.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending; 
			} 
			else if ( !( mContextMenuColumn.SortKey == null ) ) 
			{ 
				mContextMenuColumn.SortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending; 
			} 
			else 
			{ 
				mContextMenuColumn.Table.SortKeys.Clear(); 
				mContextMenuColumn.Table.SortKeys.Add( new GridEXSortKey( mContextMenuColumn, Janus.Windows.GridEX.SortOrder.Ascending ) ); 
			} 
		} 
        
		protected void OnSortDescendingCommand() 
		{ 
			if ( !( mContextMenuColumn.Group == null ) ) 
			{ 
				mContextMenuColumn.Group.SortOrder = ( ( Janus.Windows.GridEX.SortOrder )( Janus.Windows.GridEX.SortOrder.Descending ) ); 
			} 
			else if ( !( mContextMenuColumn.SortKey == null ) ) 
			{ 
				mContextMenuColumn.SortKey.SortOrder = ( ( Janus.Windows.GridEX.SortOrder )( Janus.Windows.GridEX.SortOrder.Descending ) ); 
			} 
			else 
			{ 
				mContextMenuColumn.Table.SortKeys.Clear(); 
				mContextMenuColumn.Table.SortKeys.Add( new GridEXSortKey( mContextMenuColumn, Janus.Windows.GridEX.SortOrder.Descending ) ); 
			} 
		} 
        
		protected void OnGroupByThisFieldCommand() 
		{ 
			if ( mContextMenuColumn.Group == null ) 
			{ 
				mContextMenuColumn.Table.Groups.Add( new GridEXGroup( mContextMenuColumn ) ); 
			} 
			else 
			{ 
				mContextMenuColumn.Table.Groups.Remove( mContextMenuColumn.Group ); 
			} 
		} 
        
		protected void OnGroupByBoxCommand() 
		{ 
			GridEX.GroupByBoxVisible = !( GridEX.GroupByBoxVisible ); 
		} 
        
		protected void OnRemoveThisColumnCommand() 
		{ 
			mContextMenuColumn.Visible = false; 
		} 
        	
		#endregion

		public  bool UpdateChanges() 
		{ 
			return this.GridEX.UpdateData(); 
		} 
        public object _dataSource;
		public object dataSource {get { return _dataSource; }
			set {  _dataSource = value; }}
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			try
			{
				base.OnClosing( e );
                IDIGITALTEKGRID.ListDataProvider list = new IDIGITALTEKGRID.ListDataProvider();

                string _Grid = this.GetType().FullName;
                string _View = this.dlSelectView.SelectedValue.ToString();
                list.SaveGridView(_Grid, _View, this.ClientSize.Width, this.ClientSize.Height);

                UpdateChanges();
                this.GridEX.Update();
        
			}
			catch{}
		}
		public void UpdateLayout() 
		{ 
			if ( !( ( this.GridEX.CurrentLayout == null ) ) ) 
			{ 
			// first clear all valuelist to avoid saving them in the layout
			// file. ValueList in this app, are filled when the control is loaded
			// so there is no need to preserve them
			GridEXTable t = null; 
			GridEXColumn c = null; 
			foreach ( Janus.Windows.GridEX.GridEXTable transTemp3 in GridEX.Tables ) 
			{ 
				 t = transTemp3; 
			foreach ( Janus.Windows.GridEX.GridEXColumn transTemp4 in t.Columns ) 
				{ 
					c = transTemp4;
					if ( c.HasValueList ) 
					{ c.ValueList.Clear(); } 
				 }
			}
			this.GridEX.CurrentLayout.Update(); 
			 } 
		} 
		public  virtual void SaveSettings() 
		{
            DialogResult settings = MessageBox.Show( "Do you want to save layout?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ); 
      
            if(settings == DialogResult.Yes)
                //&&(this.dlSelectView.SelectedValue.ToString()!="Default"))
               //  &&(this.dlSelectView.SelectedValue.ToString()!="Card")
               // &&(this.dlSelectView.SelectedValue.ToString()!="All Fields"))
                
            {
           
                    UpdateLayout();
                    System.IO.MemoryStream stream = new System.IO.MemoryStream();
                    this.GridEX.SaveLayoutFile(stream);
                    IDIGITALTEKGRID.SettingDataProvider Settings = new IDIGITALTEKGRID.SettingDataProvider();
                    IDIGITALTEKGRID.SettingData viewRow = new IDIGITALTEKGRID.SettingData();
                    viewRow.ViewName = this.GetType().FullName;
                    viewRow.ViewName = this.dlSelectView.SelectedValue.ToString() +"."+ viewRow.ViewName;
                    
                    viewRow.Layout = System.Convert.ToBase64String(stream.ToArray());
                    if (Settings.select(viewRow.ViewName).Count == 0)
                    { Settings.add(viewRow);}
                    else
                    {Settings.update(viewRow);}
                    stream.Close();

            }

        } 
		public virtual void LoadSettings(string _viewName, bool _viewChange) 
		{ 
			
		}

        public virtual void InsertData()
        {

        }


        public virtual bool SaveData()
        {
            UpdateChanges();
            this.GridEX.Update();
            return false;
        }

        public virtual void SetDataBinding(object _data)
        {

            string _ViewName = this.GetType().FullName;
            _ViewName = this.dlSelectView.SelectedValue.ToString() + "." + _ViewName;
            try
            {
                LoadSettings(_ViewName, false);
            }
            catch { }

           // GridEXLayout layout2 = this.GridEX.FindLayout("Grid");
           //this.GridEX.CurrentLayout = layout2;
            this.GridEX.SetDataBinding(_data, "");
            this.resizeColumn();
            this.GridEX.Refetch();
            this.BringToFront();
         

        }
        
        protected  void OnFolderViewChanged() 
		{ 
			UpdateLayout(); 
		
		}


        protected void Export(DataTable dtExport)
        {
            SaveFileDialog dlg = new SaveFileDialog();
             dlg.DefaultExt = ".txt";
             dlg.Filter = "Text Files (*txt)|*.txt|Excel Files (*.xls)|*.xls|CSV Files (*.csv)|*.csv";

            dlg.FileName = this.GetType().Name.Substring(0, this.GetType().Name.Length - 3);

            string fileName = dlg.FileName;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IDIGITALTEKGRID.Export objExport = new Export("Win");

                    //objExport.Export_with_XSLT_Windows(set1, textArray1, textArray2, FormatType, FileName);


                    objExport.ExportDetails(dtExport, IDIGITALTEKGRID.Export.ExportFormat.Excel, dlg.FileName);

                }
                catch { }
            }
        }

        public virtual void ShowExportViewDialog()
        {


        }


        protected void  dlSelectView_SelectionChangeCommitted(object sender, EventArgs e)
        {
 	        string _viewName = this.dlSelectView.SelectedValue.ToString();
            _viewName = _viewName + "." + this.GetType().FullName;
           
            try
            {
                LoadSettings(_viewName,true);
            }
            catch { }
        }

        void GridEX_CellEdited(object sender, ColumnActionEventArgs e)
        {
            if (_checkGroup == false)
            {
                SaveData();
            }
        }
    }







} 