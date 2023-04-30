using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
//using EstimateBuilder;

namespace EstimateBuilder
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Builder : System.Windows.Forms.Form
    {

        private System.Windows.Forms.MenuItem menuFile;
        private System.ComponentModel.IContainer components;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private System.Windows.Forms.ImageList LargeIcon;
        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager;
        private Janus.Windows.UI.Dock.UIPanelGroup uipNavigator;
        private Janus.Windows.UI.Dock.UIPanelGroup uipContact;
        private Janus.Windows.UI.Dock.UIPanel uipContactTree;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipContactDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipTakeOff;
        private Janus.Windows.UI.Dock.UIPanel uipTakeOffDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipTakeOffDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanel uipJobDivision;
        private Janus.Windows.UI.Dock.UIPanel uipTakeOffJob;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipTakeOffJobContainer;

        private Janus.Windows.UI.Dock.UIPanelGroup uipExpression;
        private Janus.Windows.UI.Dock.UIPanel uipExpressionDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipExpressionDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipQuantity;
        private Janus.Windows.UI.Dock.UIPanel uipQuantityDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipQuantityDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipAssembly;
        private Janus.Windows.UI.Dock.UIPanel uipAssemblyDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipAssemblyDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipCostAmount;
        private Janus.Windows.UI.Dock.UIPanel uipCostAmountDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipCostAmountDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipCostItem;
        private Janus.Windows.UI.Dock.UIPanel uipCostItemDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipCostItemDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipEstimate;
        
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipEstimateProjectContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipValidationUser;
        private Janus.Windows.UI.Dock.UIPanel uipValidationUserDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipValidationUserDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipValidationSystem;
        private Janus.Windows.UI.Dock.UIPanel uipValidationSystemDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipValidationSystemDivisionContainer;
        private Janus.Windows.UI.Dock.UIPanelGroup uipJob;
        private Janus.Windows.UI.Dock.UIPanel uipEstimateDivision;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipJobDivisionContainer;

        private Janus.Windows.UI.CommandBars.UICommandManager uiCmdManagerMenuBar;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UICommandBar uiCmdBarMenu;
        private Janus.Windows.UI.CommandBars.UICommandBar uiCmdBarIcon;
        private Janus.Windows.UI.CommandBars.UICommand CmdFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdJob;
        private Janus.Windows.UI.CommandBars.UICommand cmdExpression;
        private Janus.Windows.UI.CommandBars.UICommand cmdAssembly;
        private Janus.Windows.UI.CommandBars.UICommand CmdCostItem;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationUser;
        private Janus.Windows.UI.CommandBars.UICommand CmdHelpEstimateBuilder;
        private Janus.Windows.UI.CommandBars.UICommand CmdNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdCost;
        private Janus.Windows.UI.CommandBars.UICommand cmdContact;
        private Janus.Windows.UI.CommandBars.UICommand cmdTakeOff;
        private Janus.Windows.UI.CommandBars.UICommand cmdTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuantity;
        private Janus.Windows.UI.CommandBars.UICommand cmdCostAmount;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationSystem;
        private Janus.Windows.UI.CommandBars.UICommand cmdAssemblyIcon;
        private Janus.Windows.UI.CommandBars.UICommand CmdJobNew;
        private Janus.Windows.UI.CommandBars.UICommand CmdFileMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdTakeOffIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdExpressionIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationUserIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationSystemIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdContactIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdEstimateIcon;
        public static ListView lstContactDivision;
        public static ListView lstTakeOffDivision;
        public static ListView lstQuantityDivision;
        public static ListView lstQuantityJob;
        public static ListView lstCostAmountDivision;
        public static ListView lstExpressionDivision;
        public static ListView lstAssemblyDivision;
        public static ListView lstCostItemDivision;
        public static ListView lstValidationUserDivision;
        public static ListView lstValidationSystemDivision;
        public static ListView lstJobDivision;
        public static ListView lstTakeOffJob;
        public static ListView lstEstimateBuildingType;
        public static ListView lstEstimateProject;
        public static ListView lstGroup;
        public static ProgressBar progressEstimate;



        private System.Windows.Forms.ColumnHeader clmItem1;
        private System.Windows.Forms.ColumnHeader clmItem2;
        private System.Windows.Forms.ColumnHeader clmItem3;
        private System.Windows.Forms.ColumnHeader clmItem4;
        private System.Windows.Forms.ColumnHeader clmItem5;
        private System.Windows.Forms.ColumnHeader clmItem6;
        private System.Windows.Forms.ColumnHeader clmItem7;
        private System.Windows.Forms.ColumnHeader clmItem8;
        private System.Windows.Forms.ColumnHeader clmItem9;
        private System.Windows.Forms.ColumnHeader clmItem10;
        private System.Windows.Forms.ColumnHeader clmItem11;
        private System.Windows.Forms.ColumnHeader clmItem12;
        private System.Windows.Forms.ColumnHeader clmItem13;
        private System.Windows.Forms.ColumnHeader clmItem14;
        private System.Windows.Forms.ColumnHeader clmItem15;
        private ColumnHeader columnHeader1;


        public EstimateBuilder.ContactMDI newContactChild ;
        public EstimateBuilder.EstimateMDI newEstimateChild;
        public EstimateBuilder.AssemblyMDI newAssemblyChild;
        public EstimateBuilder.CostAmountMDI newCostAmountChild;
        public EstimateBuilder.CostItemMDI newCostItemChild;
        public EstimateBuilder.JobMDI newJobChild ;
        public EstimateBuilder.ExpressionMDI newExpressionChild ;
        public EstimateBuilder.QuantityMDI newQuantityChild ;
        public EstimateBuilder.TakeoffMDI newTakeOffChild ;
        public EstimateBuilder.ValidationSystemMDI newValidationSystemChild ;
        private Janus.Windows.UI.Dock.UIPanel uipQuantityJob;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipQuantityJobContainer;
        private Janus.Windows.UI.Dock.UIPanel uipEstimateProject;
        private Janus.Windows.UI.Dock.UIPanel uipEstimateBuilding;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipEstimateBuildingContainer;
        private Janus.Windows.UI.CommandBars.UICommand CmdNewFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdTakeOffNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdContactNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdAssemblyNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdExpressionNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuantityNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdCostAmountNew;
        private Janus.Windows.UI.CommandBars.UICommand CmdCostItemNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationUserNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdValidationSystemNew;
  
        private Janus.Windows.UI.CommandBars.UICommand cmdCostAmountIcon;
        private Janus.Windows.UI.CommandBars.UICommand CmdCostItemIcon;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuantityIcon;
        private Janus.Windows.UI.CommandBars.UICommand CmdHelpEstimateBuilder1;
        private Janus.Windows.UI.CommandBars.UICommand SeparatorFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdExitFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit;
        private Janus.Windows.UI.CommandBars.UICommand cmdHelpAboutMenu;
        private Janus.Windows.UI.CommandBars.UICommand cmdHelpAbout;
        private Janus.Windows.UI.Dock.UIPanel uipTakeoffGroup;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uipTakeoffGroupContainer;
   
        



        public EstimateBuilder.ValidationUserMDI newValidationUserChild ;



        public Builder()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();


        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory1 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory2 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory3 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory4 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory5 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory6 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory7 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            Janus.Windows.UI.CommandBars.UICommandCategory uiCommandCategory8 = new Janus.Windows.UI.CommandBars.UICommandCategory();
            lstJobDivision = new System.Windows.Forms.ListView();
            this.clmItem11 = new System.Windows.Forms.ColumnHeader();
            lstValidationUserDivision = new System.Windows.Forms.ListView();
            this.clmItem3 = new System.Windows.Forms.ColumnHeader();
            lstValidationSystemDivision = new System.Windows.Forms.ListView();
            this.clmItem1 = new System.Windows.Forms.ColumnHeader();
            this.clmItem4 = new System.Windows.Forms.ColumnHeader();
            lstCostItemDivision = new System.Windows.Forms.ListView();
            this.clmItem5 = new System.Windows.Forms.ColumnHeader();
            lstCostAmountDivision = new System.Windows.Forms.ListView();
            this.clmItem6 = new System.Windows.Forms.ColumnHeader();
            lstAssemblyDivision = new System.Windows.Forms.ListView();
            this.clmItem7 = new System.Windows.Forms.ColumnHeader();
            lstTakeOffDivision = new System.Windows.Forms.ListView();
            this.clmItem8 = new System.Windows.Forms.ColumnHeader();
            lstExpressionDivision = new System.Windows.Forms.ListView();
            this.clmItem9 = new System.Windows.Forms.ColumnHeader();
            lstContactDivision = new System.Windows.Forms.ListView();
            this.clmItem10 = new System.Windows.Forms.ColumnHeader();
            lstQuantityDivision = new System.Windows.Forms.ListView();
            this.clmItem2 = new System.Windows.Forms.ColumnHeader();
            this.clmItem12 = new System.Windows.Forms.ColumnHeader();
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.LargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.uiPanelManager = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uipNavigator = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipContact = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipContactTree = new Janus.Windows.UI.Dock.UIPanel();
            this.uipContactDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipJob = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipJobDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipJobDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipAssembly = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipAssemblyDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipAssemblyDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipTakeOff = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipTakeOffDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipTakeOffDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipTakeOffJob = new Janus.Windows.UI.Dock.UIPanel();
            this.uipTakeOffJobContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            lstTakeOffJob = new System.Windows.Forms.ListView();
            this.uipTakeoffGroup = new Janus.Windows.UI.Dock.UIPanel();
            this.uipTakeoffGroupContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            lstGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.uipExpression = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipExpressionDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipExpressionDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipQuantity = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipQuantityDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipQuantityDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipQuantityJob = new Janus.Windows.UI.Dock.UIPanel();
            this.uipQuantityJobContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            lstQuantityJob = new System.Windows.Forms.ListView();
            this.clmItem13 = new System.Windows.Forms.ColumnHeader();
            this.uipCostItem = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipCostItemDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipCostItemDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipCostAmount = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipCostAmountDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipCostAmountDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipEstimate = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipEstimateBuilding = new Janus.Windows.UI.Dock.UIPanel();
            this.uipEstimateBuildingContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            lstEstimateBuildingType = new System.Windows.Forms.ListView();
            this.clmItem14 = new System.Windows.Forms.ColumnHeader();
            this.uipEstimateProject = new Janus.Windows.UI.Dock.UIPanel();
            this.uipEstimateProjectContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            lstEstimateProject = new System.Windows.Forms.ListView();
            this.clmItem15 = new System.Windows.Forms.ColumnHeader();
            this.uipValidationUser = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipValidationUserDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipValidationUserDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uipValidationSystem = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uipValidationSystemDivision = new Janus.Windows.UI.Dock.UIPanel();
            this.uipValidationSystemDivisionContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.uiCmdManagerMenuBar = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.uiCmdBarMenu = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.CmdFileMenu = new Janus.Windows.UI.CommandBars.UICommand("CmdFile");
            this.CmdHelpEstimateBuilder1 = new Janus.Windows.UI.CommandBars.UICommand("CmdHelpEstimateBuilder");
            this.uiCmdBarIcon = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.cmdContactIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdContact");
            this.cmdEstimateIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdJob");
            this.cmdAssemblyIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdAssembly");
            this.cmdTakeOffIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdTakeOff");
            this.cmdExpressionIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdExpression");
            this.cmdQuantityIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdQuantity");
            this.CmdCostItemIcon = new Janus.Windows.UI.CommandBars.UICommand("CmdCostItem");
            this.cmdCostAmountIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdCostAmount");
            this.cmdValidationUserIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationUser");
            this.cmdValidationSystemIcon = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationSystem");
            this.CmdFile = new Janus.Windows.UI.CommandBars.UICommand("CmdFile");
            this.CmdNewFile = new Janus.Windows.UI.CommandBars.UICommand("CmdNew");
            this.SeparatorFile = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdExitFile = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.CmdNew = new Janus.Windows.UI.CommandBars.UICommand("CmdNew");
            this.cmdContactNew = new Janus.Windows.UI.CommandBars.UICommand("cmdContact");
            this.CmdJobNew = new Janus.Windows.UI.CommandBars.UICommand("cmdJob");
            this.cmdAssemblyNew = new Janus.Windows.UI.CommandBars.UICommand("cmdAssembly");
            this.cmdTakeOffNew = new Janus.Windows.UI.CommandBars.UICommand("cmdTakeOff");
            this.cmdExpressionNew = new Janus.Windows.UI.CommandBars.UICommand("cmdExpression");
            this.cmdQuantityNew = new Janus.Windows.UI.CommandBars.UICommand("cmdQuantity");
            this.cmdCostAmountNew = new Janus.Windows.UI.CommandBars.UICommand("cmdCostAmount");
            this.CmdCostItemNew = new Janus.Windows.UI.CommandBars.UICommand("CmdCostItem");
            this.cmdValidationUserNew = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationUser");
            this.cmdValidationSystemNew = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationSystem");
            this.cmdCost = new Janus.Windows.UI.CommandBars.UICommand("cmdCost");
            this.cmdContact = new Janus.Windows.UI.CommandBars.UICommand("cmdContact");
            this.cmdJob = new Janus.Windows.UI.CommandBars.UICommand("cmdJob");
            this.cmdTakeOff = new Janus.Windows.UI.CommandBars.UICommand("cmdTakeOff");
            this.cmdTask = new Janus.Windows.UI.CommandBars.UICommand("cmdTask");
            this.cmdExpression = new Janus.Windows.UI.CommandBars.UICommand("cmdExpression");
            this.cmdQuantity = new Janus.Windows.UI.CommandBars.UICommand("cmdQuantity");
            this.cmdAssembly = new Janus.Windows.UI.CommandBars.UICommand("cmdAssembly");
            this.cmdCostAmount = new Janus.Windows.UI.CommandBars.UICommand("cmdCostAmount");
            this.CmdCostItem = new Janus.Windows.UI.CommandBars.UICommand("CmdCostItem");
            this.cmdValidationUser = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationUser");
            this.cmdValidationSystem = new Janus.Windows.UI.CommandBars.UICommand("cmdValidationSystem");
            this.CmdHelpEstimateBuilder = new Janus.Windows.UI.CommandBars.UICommand("CmdHelpEstimateBuilder");
            this.cmdHelpAboutMenu = new Janus.Windows.UI.CommandBars.UICommand("cmdHelpAbout");
            this.cmdExit = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdHelpAbout = new Janus.Windows.UI.CommandBars.UICommand("cmdHelpAbout");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            progressEstimate = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uipNavigator)).BeginInit();
            this.uipNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipContact)).BeginInit();
            this.uipContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipContactTree)).BeginInit();
            this.uipContactTree.SuspendLayout();
            this.uipContactDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipJob)).BeginInit();
            this.uipJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipJobDivision)).BeginInit();
            this.uipJobDivision.SuspendLayout();
            this.uipJobDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipAssembly)).BeginInit();
            this.uipAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipAssemblyDivision)).BeginInit();
            this.uipAssemblyDivision.SuspendLayout();
            this.uipAssemblyDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOff)).BeginInit();
            this.uipTakeOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOffDivision)).BeginInit();
            this.uipTakeOffDivision.SuspendLayout();
            this.uipTakeOffDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOffJob)).BeginInit();
            this.uipTakeOffJob.SuspendLayout();
            this.uipTakeOffJobContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeoffGroup)).BeginInit();
            this.uipTakeoffGroup.SuspendLayout();
            this.uipTakeoffGroupContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipExpression)).BeginInit();
            this.uipExpression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipExpressionDivision)).BeginInit();
            this.uipExpressionDivision.SuspendLayout();
            this.uipExpressionDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantity)).BeginInit();
            this.uipQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantityDivision)).BeginInit();
            this.uipQuantityDivision.SuspendLayout();
            this.uipQuantityDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantityJob)).BeginInit();
            this.uipQuantityJob.SuspendLayout();
            this.uipQuantityJobContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipCostItem)).BeginInit();
            this.uipCostItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipCostItemDivision)).BeginInit();
            this.uipCostItemDivision.SuspendLayout();
            this.uipCostItemDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipCostAmount)).BeginInit();
            this.uipCostAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipCostAmountDivision)).BeginInit();
            this.uipCostAmountDivision.SuspendLayout();
            this.uipCostAmountDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimate)).BeginInit();
            this.uipEstimate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimateBuilding)).BeginInit();
            this.uipEstimateBuilding.SuspendLayout();
            this.uipEstimateBuildingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimateProject)).BeginInit();
            this.uipEstimateProject.SuspendLayout();
            this.uipEstimateProjectContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationUser)).BeginInit();
            this.uipValidationUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationUserDivision)).BeginInit();
            this.uipValidationUserDivision.SuspendLayout();
            this.uipValidationUserDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationSystem)).BeginInit();
            this.uipValidationSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationSystemDivision)).BeginInit();
            this.uipValidationSystemDivision.SuspendLayout();
            this.uipValidationSystemDivisionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdBarMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdBarIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstJobDivision
            // 
            lstJobDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstJobDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem11});
            lstJobDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstJobDivision.FullRowSelect = true;
            lstJobDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstJobDivision.Location = new System.Drawing.Point(0, 0);
            lstJobDivision.MultiSelect = false;
            lstJobDivision.Name = "lstJobDivision";
            lstJobDivision.Scrollable = false;
            lstJobDivision.Size = new System.Drawing.Size(167, 249);
            lstJobDivision.TabIndex = 0;
            lstJobDivision.UseCompatibleStateImageBehavior = false;
            lstJobDivision.View = System.Windows.Forms.View.Details;
            lstJobDivision.DoubleClick += new System.EventHandler(this.JobDivision_Click);
            // 
            // clmItem11
            // 
            this.clmItem11.Text = "Item";
            this.clmItem11.Width = 300;
            // 
            // lstValidationUserDivision
            // 
            lstValidationUserDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstValidationUserDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem3});
            lstValidationUserDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstValidationUserDivision.FullRowSelect = true;
            lstValidationUserDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstValidationUserDivision.Location = new System.Drawing.Point(0, 0);
            lstValidationUserDivision.MultiSelect = false;
            lstValidationUserDivision.Name = "lstValidationUserDivision";
            lstValidationUserDivision.Scrollable = false;
            lstValidationUserDivision.Size = new System.Drawing.Size(167, 249);
            lstValidationUserDivision.TabIndex = 0;
            lstValidationUserDivision.UseCompatibleStateImageBehavior = false;
            lstValidationUserDivision.View = System.Windows.Forms.View.Details;
            lstValidationUserDivision.DoubleClick += new System.EventHandler(this.ValidationUserDivision_Click);
            // 
            // clmItem3
            // 
            this.clmItem3.Text = "Item";
            this.clmItem3.Width = 300;
            // 
            // lstValidationSystemDivision
            // 
            lstValidationSystemDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstValidationSystemDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem1});
            lstValidationSystemDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstValidationSystemDivision.FullRowSelect = true;
            lstValidationSystemDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstValidationSystemDivision.Location = new System.Drawing.Point(0, 0);
            lstValidationSystemDivision.MultiSelect = false;
            lstValidationSystemDivision.Name = "lstValidationSystemDivision";
            lstValidationSystemDivision.Scrollable = false;
            lstValidationSystemDivision.Size = new System.Drawing.Size(167, 249);
            lstValidationSystemDivision.TabIndex = 0;
            lstValidationSystemDivision.UseCompatibleStateImageBehavior = false;
            lstValidationSystemDivision.View = System.Windows.Forms.View.Details;
            lstValidationSystemDivision.DoubleClick += new System.EventHandler(this.ValidationSystemDivision_Click);
            // 
            // clmItem1
            // 
            this.clmItem1.Text = "Item";
            this.clmItem1.Width = 300;
            // 
            // clmItem4
            // 
            this.clmItem4.Text = "Item";
            this.clmItem4.Width = 300;
            // 
            // lstCostItemDivision
            // 
            lstCostItemDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstCostItemDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem5});
            lstCostItemDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCostItemDivision.FullRowSelect = true;
            lstCostItemDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstCostItemDivision.Location = new System.Drawing.Point(0, 0);
            lstCostItemDivision.MultiSelect = false;
            lstCostItemDivision.Name = "lstCostItemDivision";
            lstCostItemDivision.Scrollable = false;
            lstCostItemDivision.Size = new System.Drawing.Size(167, 249);
            lstCostItemDivision.TabIndex = 0;
            lstCostItemDivision.UseCompatibleStateImageBehavior = false;
            lstCostItemDivision.View = System.Windows.Forms.View.Details;
            lstCostItemDivision.DoubleClick += new System.EventHandler(this.costItemDivision_Click);
            // 
            // clmItem5
            // 
            this.clmItem5.Text = "Item";
            this.clmItem5.Width = 300;
            // 
            // lstCostAmountDivision
            // 
            lstCostAmountDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstCostAmountDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem6});
            lstCostAmountDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstCostAmountDivision.FullRowSelect = true;
            lstCostAmountDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstCostAmountDivision.Location = new System.Drawing.Point(0, 0);
            lstCostAmountDivision.MultiSelect = false;
            lstCostAmountDivision.Name = "lstCostAmountDivision";
            lstCostAmountDivision.Scrollable = false;
            lstCostAmountDivision.Size = new System.Drawing.Size(167, 249);
            lstCostAmountDivision.TabIndex = 0;
            lstCostAmountDivision.UseCompatibleStateImageBehavior = false;
            lstCostAmountDivision.View = System.Windows.Forms.View.Details;
            lstCostAmountDivision.DoubleClick += new System.EventHandler(this.CostAmountDivision_Click);
            // 
            // clmItem6
            // 
            this.clmItem6.Text = "Item";
            this.clmItem6.Width = 300;
            // 
            // lstAssemblyDivision
            // 
            lstAssemblyDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstAssemblyDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem7});
            lstAssemblyDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstAssemblyDivision.FullRowSelect = true;
            lstAssemblyDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstAssemblyDivision.Location = new System.Drawing.Point(0, 0);
            lstAssemblyDivision.MultiSelect = false;
            lstAssemblyDivision.Name = "lstAssemblyDivision";
            lstAssemblyDivision.Scrollable = false;
            lstAssemblyDivision.Size = new System.Drawing.Size(167, 249);
            lstAssemblyDivision.TabIndex = 0;
            lstAssemblyDivision.UseCompatibleStateImageBehavior = false;
            lstAssemblyDivision.View = System.Windows.Forms.View.Details;
            lstAssemblyDivision.DoubleClick += new System.EventHandler(this.AssemblyDivision_Click);
            // 
            // clmItem7
            // 
            this.clmItem7.Text = "Item";
            this.clmItem7.Width = 300;
            // 
            // lstTakeOffDivision
            // 
            lstTakeOffDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstTakeOffDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem8});
            lstTakeOffDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTakeOffDivision.FullRowSelect = true;
            lstTakeOffDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstTakeOffDivision.Location = new System.Drawing.Point(0, 0);
            lstTakeOffDivision.MultiSelect = false;
            lstTakeOffDivision.Name = "lstTakeOffDivision";
            lstTakeOffDivision.Size = new System.Drawing.Size(167, 63);
            lstTakeOffDivision.TabIndex = 0;
            lstTakeOffDivision.UseCompatibleStateImageBehavior = false;
            lstTakeOffDivision.View = System.Windows.Forms.View.Details;
            lstTakeOffDivision.DoubleClick += new System.EventHandler(this.TakeOffDivision_Click);
            // 
            // clmItem8
            // 
            this.clmItem8.Text = "Item";
            this.clmItem8.Width = 167;
            // 
            // lstExpressionDivision
            // 
            lstExpressionDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstExpressionDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem9});
            lstExpressionDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstExpressionDivision.FullRowSelect = true;
            lstExpressionDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstExpressionDivision.Location = new System.Drawing.Point(0, 0);
            lstExpressionDivision.MultiSelect = false;
            lstExpressionDivision.Name = "lstExpressionDivision";
            lstExpressionDivision.Scrollable = false;
            lstExpressionDivision.Size = new System.Drawing.Size(167, 249);
            lstExpressionDivision.TabIndex = 0;
            lstExpressionDivision.UseCompatibleStateImageBehavior = false;
            lstExpressionDivision.View = System.Windows.Forms.View.Details;
            lstExpressionDivision.DoubleClick += new System.EventHandler(this.ExpressionDivision_Click);
            // 
            // clmItem9
            // 
            this.clmItem9.Text = "Item";
            this.clmItem9.Width = 300;
            // 
            // lstContactDivision
            // 
            lstContactDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstContactDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem10});
            lstContactDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstContactDivision.FullRowSelect = true;
            lstContactDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstContactDivision.Location = new System.Drawing.Point(0, 0);
            lstContactDivision.MultiSelect = false;
            lstContactDivision.Name = "lstContactDivision";
            lstContactDivision.Scrollable = false;
            lstContactDivision.Size = new System.Drawing.Size(167, 245);
            lstContactDivision.TabIndex = 0;
            lstContactDivision.UseCompatibleStateImageBehavior = false;
            lstContactDivision.View = System.Windows.Forms.View.Details;
            lstContactDivision.DoubleClick += new System.EventHandler(this.ContactDivision_Click);
            // 
            // clmItem10
            // 
            this.clmItem10.Text = "Item";
            this.clmItem10.Width = 300;
            // 
            // lstQuantityDivision
            // 
            lstQuantityDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstQuantityDivision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem2});
            lstQuantityDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            lstQuantityDivision.FullRowSelect = true;
            lstQuantityDivision.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstQuantityDivision.Location = new System.Drawing.Point(0, 0);
            lstQuantityDivision.MultiSelect = false;
            lstQuantityDivision.Name = "lstQuantityDivision";
            lstQuantityDivision.Scrollable = false;
            lstQuantityDivision.Size = new System.Drawing.Size(167, 119);
            lstQuantityDivision.TabIndex = 0;
            lstQuantityDivision.UseCompatibleStateImageBehavior = false;
            lstQuantityDivision.View = System.Windows.Forms.View.Details;
            lstQuantityDivision.DoubleClick += new System.EventHandler(this.QuantityDivision_Click);
            // 
            // clmItem2
            // 
            this.clmItem2.Text = "Item";
            this.clmItem2.Width = 300;
            // 
            // clmItem12
            // 
            this.clmItem12.Text = "Item";
            this.clmItem12.Width = 167;
            // 
            // menuFile
            // 
            this.menuFile.Index = -1;
            this.menuFile.Text = "";
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.BackColor = System.Drawing.Color.White;
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 23);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(194, 330);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // uiPanel1
            // 
            this.uiPanel1.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.Window;
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(196, 353);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "Panel 1";
            // 
            // LargeIcon
            // 
            this.LargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeIcon.ImageStream")));
            this.LargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeIcon.Images.SetKeyName(0, "BRIDGE.ICO");
            this.LargeIcon.Images.SetKeyName(1, "ClassDesigner.ico");
            this.LargeIcon.Images.SetKeyName(2, "CRDFLE01.ICO");
            this.LargeIcon.Images.SetKeyName(3, "DISK08.ICO");
            this.LargeIcon.Images.SetKeyName(4, "DRAG1PG.ICO");
            this.LargeIcon.Images.SetKeyName(5, "GRAPH05.ICO");
            this.LargeIcon.Images.SetKeyName(6, "GRAPH06.ICO");
            this.LargeIcon.Images.SetKeyName(7, "HAMMER.ICO");
            this.LargeIcon.Images.SetKeyName(8, "MISC28.ICO");
            this.LargeIcon.Images.SetKeyName(9, "MOUSE01.ICO");
            this.LargeIcon.Images.SetKeyName(10, "VisioCD.ICO");
            this.LargeIcon.Images.SetKeyName(11, "DESKTOP.ICO");
            // 
            // uiPanelManager
            // 
            this.uiPanelManager.ContainerControl = this;
            this.uiPanelManager.LargeImageList = this.LargeIcon;
            this.uipNavigator.Id = new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d");
            this.uipNavigator.StaticGroup = true;
            this.uipContact.Id = new System.Guid("15f8f450-d130-4b59-907e-dc3992f3a640");
            this.uipContact.StaticGroup = true;
            this.uipContactTree.Id = new System.Guid("b053d8e5-7cf9-45a5-9f33-8fc86645f9a3");
            this.uipContact.Panels.Add(this.uipContactTree);
            this.uipNavigator.Panels.Add(this.uipContact);
            this.uipJob.Id = new System.Guid("35acaa0a-d71d-4e63-ac6b-ea8de1804a37");
            this.uipJob.StaticGroup = true;
            this.uipJobDivision.Id = new System.Guid("fae84f18-216b-4b6a-996a-8860ee5e5791");
            this.uipJob.Panels.Add(this.uipJobDivision);
            this.uipNavigator.Panels.Add(this.uipJob);
            this.uipAssembly.Id = new System.Guid("d179001d-c221-4e5b-b495-cbb4ab843ed1");
            this.uipAssembly.StaticGroup = true;
            this.uipAssemblyDivision.Id = new System.Guid("3046d953-c2c9-4436-af8a-624e1495136a");
            this.uipAssembly.Panels.Add(this.uipAssemblyDivision);
            this.uipNavigator.Panels.Add(this.uipAssembly);
            this.uipTakeOff.Id = new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40");
            this.uipTakeOff.StaticGroup = true;
            this.uipTakeOffDivision.Id = new System.Guid("8cfff2f1-e99f-4045-a80f-f781d244091e");
            this.uipTakeOff.Panels.Add(this.uipTakeOffDivision);
            this.uipTakeOffJob.Id = new System.Guid("e28adf01-b5a6-4fbf-a0da-95888244407e");
            this.uipTakeOff.Panels.Add(this.uipTakeOffJob);
            this.uipTakeoffGroup.Id = new System.Guid("d400a12f-61ae-4088-84e0-bcfd0c5fd7e0");
            this.uipTakeOff.Panels.Add(this.uipTakeoffGroup);
            this.uipNavigator.Panels.Add(this.uipTakeOff);
            this.uipExpression.Id = new System.Guid("edaeec2b-49b2-4994-9090-55b5e964fc83");
            this.uipExpression.StaticGroup = true;
            this.uipExpressionDivision.Id = new System.Guid("d6a6bb26-c289-4063-a7cc-4ea836d1e4a2");
            this.uipExpression.Panels.Add(this.uipExpressionDivision);
            this.uipNavigator.Panels.Add(this.uipExpression);
            this.uipQuantity.Id = new System.Guid("1e96da3e-9f30-4c7d-b445-4040df551108");
            this.uipQuantity.StaticGroup = true;
            this.uipQuantityDivision.Id = new System.Guid("dd4b45b5-61c0-440a-8896-cbbf8ea7f0df");
            this.uipQuantity.Panels.Add(this.uipQuantityDivision);
            this.uipQuantityJob.Id = new System.Guid("6c697890-6d46-4c50-b62c-bfcc8366b8a7");
            this.uipQuantity.Panels.Add(this.uipQuantityJob);
            this.uipNavigator.Panels.Add(this.uipQuantity);
            this.uipCostItem.Id = new System.Guid("bfc9255f-cd88-4995-9fe2-7dd9620f3d09");
            this.uipCostItem.StaticGroup = true;
            this.uipCostItemDivision.Id = new System.Guid("fc47c50c-e5cd-4b14-bc14-17512c24eae5");
            this.uipCostItem.Panels.Add(this.uipCostItemDivision);
            this.uipNavigator.Panels.Add(this.uipCostItem);
            this.uipCostAmount.Id = new System.Guid("5b143736-c922-44a7-97e7-77bfbe9d6cb0");
            this.uipCostAmount.StaticGroup = true;
            this.uipCostAmountDivision.Id = new System.Guid("6f1293af-c369-487d-a170-c8714533800d");
            this.uipCostAmount.Panels.Add(this.uipCostAmountDivision);
            this.uipNavigator.Panels.Add(this.uipCostAmount);
            this.uipEstimate.Id = new System.Guid("6102fe7d-fe0d-4614-87b5-ee4a415ccc7c");
            this.uipEstimate.StaticGroup = true;
            this.uipEstimateBuilding.Id = new System.Guid("9835e434-4f37-4c87-8117-17b3c438afa7");
            this.uipEstimate.Panels.Add(this.uipEstimateBuilding);
            this.uipEstimateProject.Id = new System.Guid("d7759460-00d6-4720-bf53-c4bb5937dab1");
            this.uipEstimate.Panels.Add(this.uipEstimateProject);
            this.uipNavigator.Panels.Add(this.uipEstimate);
            this.uipValidationUser.Id = new System.Guid("2cacfc0b-448f-46e4-be46-1075cbf387de");
            this.uipValidationUser.StaticGroup = true;
            this.uipValidationUserDivision.Id = new System.Guid("1b1d3214-5667-4729-b0ef-9883ed620364");
            this.uipValidationUser.Panels.Add(this.uipValidationUserDivision);
            this.uipNavigator.Panels.Add(this.uipValidationUser);
            this.uipValidationSystem.Id = new System.Guid("260aa567-b905-4765-838b-a3b4a3417b36");
            this.uipValidationSystem.StaticGroup = true;
            this.uipValidationSystemDivision.Id = new System.Guid("1d92b71c-3137-4b53-b069-9e90990a7e8a");
            this.uipValidationSystem.Panels.Add(this.uipValidationSystemDivision);
            this.uipNavigator.Panels.Add(this.uipValidationSystem);
            this.uiPanelManager.Panels.Add(this.uipNavigator);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager.BeginPanelInfo();
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, Janus.Windows.UI.Dock.PanelDockStyle.Left, true, new System.Drawing.Size(173, 697), true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("15f8f450-d130-4b59-907e-dc3992f3a640"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("b053d8e5-7cf9-45a5-9f33-8fc86645f9a3"), new System.Guid("15f8f450-d130-4b59-907e-dc3992f3a640"), 157, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("35acaa0a-d71d-4e63-ac6b-ea8de1804a37"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("fae84f18-216b-4b6a-996a-8860ee5e5791"), new System.Guid("35acaa0a-d71d-4e63-ac6b-ea8de1804a37"), 152, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d179001d-c221-4e5b-b495-cbb4ab843ed1"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("3046d953-c2c9-4436-af8a-624e1495136a"), new System.Guid("d179001d-c221-4e5b-b495-cbb4ab843ed1"), 158, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("8cfff2f1-e99f-4045-a80f-f781d244091e"), new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40"), 85, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("e28adf01-b5a6-4fbf-a0da-95888244407e"), new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40"), 86, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d400a12f-61ae-4088-84e0-bcfd0c5fd7e0"), new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40"), 85, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("edaeec2b-49b2-4994-9090-55b5e964fc83"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d6a6bb26-c289-4063-a7cc-4ea836d1e4a2"), new System.Guid("edaeec2b-49b2-4994-9090-55b5e964fc83"), 156, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("1e96da3e-9f30-4c7d-b445-4040df551108"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("dd4b45b5-61c0-440a-8896-cbbf8ea7f0df"), new System.Guid("1e96da3e-9f30-4c7d-b445-4040df551108"), 85, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("6c697890-6d46-4c50-b62c-bfcc8366b8a7"), new System.Guid("1e96da3e-9f30-4c7d-b445-4040df551108"), 78, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("bfc9255f-cd88-4995-9fe2-7dd9620f3d09"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("fc47c50c-e5cd-4b14-bc14-17512c24eae5"), new System.Guid("bfc9255f-cd88-4995-9fe2-7dd9620f3d09"), 158, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("5b143736-c922-44a7-97e7-77bfbe9d6cb0"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("6f1293af-c369-487d-a170-c8714533800d"), new System.Guid("5b143736-c922-44a7-97e7-77bfbe9d6cb0"), 158, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("6102fe7d-fe0d-4614-87b5-ee4a415ccc7c"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("9835e434-4f37-4c87-8117-17b3c438afa7"), new System.Guid("6102fe7d-fe0d-4614-87b5-ee4a415ccc7c"), 81, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("d7759460-00d6-4720-bf53-c4bb5937dab1"), new System.Guid("6102fe7d-fe0d-4614-87b5-ee4a415ccc7c"), 77, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("2cacfc0b-448f-46e4-be46-1075cbf387de"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("1b1d3214-5667-4729-b0ef-9883ed620364"), new System.Guid("2cacfc0b-448f-46e4-be46-1075cbf387de"), 159, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("260aa567-b905-4765-838b-a3b4a3417b36"), new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, -1, true);
            this.uiPanelManager.AddDockPanelInfo(new System.Guid("1d92b71c-3137-4b53-b069-9e90990a7e8a"), new System.Guid("260aa567-b905-4765-838b-a3b4a3417b36"), 158, true);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("9d78b8f1-4c0c-40fc-a62f-a6d92501606d"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("15f8f450-d130-4b59-907e-dc3992f3a640"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("b053d8e5-7cf9-45a5-9f33-8fc86645f9a3"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("584bd9d6-cc75-48fc-baff-9402019f1e77"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("077a4c49-d91d-49be-a11b-0bdeee63fb40"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("8cfff2f1-e99f-4045-a80f-f781d244091e"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("e28adf01-b5a6-4fbf-a0da-95888244407e"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("4d169b57-0eb2-4490-b98d-21c412d9d46e"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("edaeec2b-49b2-4994-9090-55b5e964fc83"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("d6a6bb26-c289-4063-a7cc-4ea836d1e4a2"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("a87ee5eb-c013-4c30-adf5-d7288e093a7a"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("1e96da3e-9f30-4c7d-b445-4040df551108"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("dd4b45b5-61c0-440a-8896-cbbf8ea7f0df"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("6c697890-6d46-4c50-b62c-bfcc8366b8a7"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("53355aa4-3bf9-4d52-99bf-3a3928b86e3a"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("d179001d-c221-4e5b-b495-cbb4ab843ed1"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("3046d953-c2c9-4436-af8a-624e1495136a"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("26e6ee3c-c9a2-4c80-85ae-3e79819977d7"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("5b143736-c922-44a7-97e7-77bfbe9d6cb0"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("6f1293af-c369-487d-a170-c8714533800d"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("a5d745cf-8b94-441a-80c2-1ab060a668f4"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("bfc9255f-cd88-4995-9fe2-7dd9620f3d09"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("fc47c50c-e5cd-4b14-bc14-17512c24eae5"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("920f0677-794a-4971-9ace-731d26e388a7"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("6102fe7d-fe0d-4614-87b5-ee4a415ccc7c"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("9835e434-4f37-4c87-8117-17b3c438afa7"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("d7759460-00d6-4720-bf53-c4bb5937dab1"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("597c87d0-0f96-4e1f-99f3-1e92b80cc8cd"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("2cacfc0b-448f-46e4-be46-1075cbf387de"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("1b1d3214-5667-4729-b0ef-9883ed620364"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("02fe663d-3e19-461a-a6dc-22774adcc828"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("260aa567-b905-4765-838b-a3b4a3417b36"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("1d92b71c-3137-4b53-b069-9e90990a7e8a"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("a5d95a03-52ac-453e-8ca7-a8d9b0d8ef79"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("35acaa0a-d71d-4e63-ac6b-ea8de1804a37"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("fae84f18-216b-4b6a-996a-8860ee5e5791"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("1b4343b3-b095-4f2a-aab0-94cda5b01596"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.AddFloatingPanelInfo(new System.Guid("d400a12f-61ae-4088-84e0-bcfd0c5fd7e0"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager.EndPanelInfo();
            // 
            // uipNavigator
            // 
            this.uipNavigator.BackColor = System.Drawing.Color.White;
            this.uipNavigator.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uipNavigator.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator;
            this.uipNavigator.Location = new System.Drawing.Point(3, 53);
            this.uipNavigator.Name = "uipNavigator";
            this.uipNavigator.Size = new System.Drawing.Size(173, 697);
            this.uipNavigator.TabIndex = 4;
            this.uipNavigator.SelectedPanelChanging += new Janus.Windows.UI.Dock.PanelActionCancelEventHandler(this.uipPanel_Click);
            // 
            // uipContact
            // 
            this.uipContact.Icon = ((System.Drawing.Icon)(resources.GetObject("uipContact.Icon")));
            this.uipContact.Location = new System.Drawing.Point(0, 0);
            this.uipContact.Name = "uipContact";
            this.uipContact.Size = new System.Drawing.Size(169, 307);
            this.uipContact.TabIndex = 4;
            this.uipContact.Text = "Contact";
            // 
            // uipContactTree
            // 
            this.uipContactTree.InnerContainer = this.uipContactDivisionContainer;
            this.uipContactTree.Location = new System.Drawing.Point(0, 38);
            this.uipContactTree.Name = "uipContactTree";
            this.uipContactTree.Size = new System.Drawing.Size(169, 269);
            this.uipContactTree.TabIndex = 4;
            this.uipContactTree.Text = "Division";
            // 
            // uipContactDivisionContainer
            // 
            this.uipContactDivisionContainer.Controls.Add(lstContactDivision);
            this.uipContactDivisionContainer.Location = new System.Drawing.Point(1, 23);
            this.uipContactDivisionContainer.Name = "uipContactDivisionContainer";
            this.uipContactDivisionContainer.Size = new System.Drawing.Size(167, 245);
            this.uipContactDivisionContainer.TabIndex = 0;
            // 
            // uipJob
            // 
            this.uipJob.Icon = ((System.Drawing.Icon)(resources.GetObject("uipJob.Icon")));
            this.uipJob.Location = new System.Drawing.Point(0, 0);
            this.uipJob.Name = "uipJob";
            this.uipJob.Size = new System.Drawing.Size(169, 307);
            this.uipJob.TabIndex = 4;
            this.uipJob.Text = "Job";
            // 
            // uipJobDivision
            // 
            this.uipJobDivision.BackColor = System.Drawing.Color.White;
            this.uipJobDivision.ImageIndex = 0;
            this.uipJobDivision.InnerContainer = this.uipJobDivisionContainer;
            this.uipJobDivision.LargeImageIndex = 0;
            this.uipJobDivision.Location = new System.Drawing.Point(0, 38);
            this.uipJobDivision.Name = "uipJobDivision";
            this.uipJobDivision.Size = new System.Drawing.Size(169, 269);
            this.uipJobDivision.TabIndex = 4;
            this.uipJobDivision.Text = "Building Type";
            // 
            // uipJobDivisionContainer
            // 
            this.uipJobDivisionContainer.BackColor = System.Drawing.Color.White;
            this.uipJobDivisionContainer.Controls.Add(lstJobDivision);
            this.uipJobDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipJobDivisionContainer.Name = "uipJobDivisionContainer";
            this.uipJobDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipJobDivisionContainer.TabIndex = 0;
            // 
            // uipAssembly
            // 
            this.uipAssembly.BackColor = System.Drawing.Color.White;
            this.uipAssembly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uipAssembly.Icon = ((System.Drawing.Icon)(resources.GetObject("uipAssembly.Icon")));
            this.uipAssembly.Location = new System.Drawing.Point(0, 0);
            this.uipAssembly.Name = "uipAssembly";
            this.uipAssembly.Size = new System.Drawing.Size(169, 307);
            this.uipAssembly.TabIndex = 4;
            this.uipAssembly.Text = "Assembly";
            // 
            // uipAssemblyDivision
            // 
            this.uipAssemblyDivision.ImageIndex = 0;
            this.uipAssemblyDivision.InnerContainer = this.uipAssemblyDivisionContainer;
            this.uipAssemblyDivision.LargeImageIndex = 0;
            this.uipAssemblyDivision.Location = new System.Drawing.Point(0, 38);
            this.uipAssemblyDivision.Name = "uipAssemblyDivision";
            this.uipAssemblyDivision.Size = new System.Drawing.Size(169, 269);
            this.uipAssemblyDivision.TabIndex = 4;
            this.uipAssemblyDivision.Text = "Division";
            // 
            // uipAssemblyDivisionContainer
            // 
            this.uipAssemblyDivisionContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uipAssemblyDivisionContainer.Controls.Add(lstAssemblyDivision);
            this.uipAssemblyDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipAssemblyDivisionContainer.Name = "uipAssemblyDivisionContainer";
            this.uipAssemblyDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipAssemblyDivisionContainer.TabIndex = 0;
            // 
            // uipTakeOff
            // 
            this.uipTakeOff.Icon = ((System.Drawing.Icon)(resources.GetObject("uipTakeOff.Icon")));
            this.uipTakeOff.Location = new System.Drawing.Point(0, 0);
            this.uipTakeOff.Name = "uipTakeOff";
            this.uipTakeOff.Size = new System.Drawing.Size(169, 307);
            this.uipTakeOff.TabIndex = 4;
            this.uipTakeOff.Text = "Takeoff";
            // 
            // uipTakeOffDivision
            // 
            this.uipTakeOffDivision.InnerContainer = this.uipTakeOffDivisionContainer;
            this.uipTakeOffDivision.Location = new System.Drawing.Point(0, 38);
            this.uipTakeOffDivision.Name = "uipTakeOffDivision";
            this.uipTakeOffDivision.Size = new System.Drawing.Size(169, 87);
            this.uipTakeOffDivision.TabIndex = 0;
            this.uipTakeOffDivision.Text = "Building Type";
            // 
            // uipTakeOffDivisionContainer
            // 
            this.uipTakeOffDivisionContainer.Controls.Add(lstTakeOffDivision);
            this.uipTakeOffDivisionContainer.Location = new System.Drawing.Point(1, 23);
            this.uipTakeOffDivisionContainer.Name = "uipTakeOffDivisionContainer";
            this.uipTakeOffDivisionContainer.Size = new System.Drawing.Size(167, 63);
            this.uipTakeOffDivisionContainer.TabIndex = 0;
            // 
            // uipTakeOffJob
            // 
            this.uipTakeOffJob.InnerAreaStyle = Janus.Windows.UI.Dock.PanelInnerAreaStyle.Window;
            this.uipTakeOffJob.InnerContainer = this.uipTakeOffJobContainer;
            this.uipTakeOffJob.Location = new System.Drawing.Point(0, 129);
            this.uipTakeOffJob.Name = "uipTakeOffJob";
            this.uipTakeOffJob.Size = new System.Drawing.Size(169, 88);
            this.uipTakeOffJob.TabIndex = 0;
            this.uipTakeOffJob.Text = "Job";
            // 
            // uipTakeOffJobContainer
            // 
            this.uipTakeOffJobContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uipTakeOffJobContainer.Controls.Add(lstTakeOffJob);
            this.uipTakeOffJobContainer.Location = new System.Drawing.Point(1, 23);
            this.uipTakeOffJobContainer.Name = "uipTakeOffJobContainer";
            this.uipTakeOffJobContainer.Size = new System.Drawing.Size(167, 64);
            this.uipTakeOffJobContainer.TabIndex = 0;
            // 
            // lstTakeOffJob
            // 
            lstTakeOffJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstTakeOffJob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem12});
            lstTakeOffJob.Dock = System.Windows.Forms.DockStyle.Fill;
            lstTakeOffJob.FullRowSelect = true;
            lstTakeOffJob.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstTakeOffJob.Location = new System.Drawing.Point(0, 0);
            lstTakeOffJob.MultiSelect = false;
            lstTakeOffJob.Name = "lstTakeOffJob";
            lstTakeOffJob.Size = new System.Drawing.Size(167, 64);
            lstTakeOffJob.TabIndex = 1;
            lstTakeOffJob.UseCompatibleStateImageBehavior = false;
            lstTakeOffJob.View = System.Windows.Forms.View.Details;
            lstTakeOffJob.DoubleClick += new System.EventHandler(this.TakeOffJob_Click);
            // 
            // uipTakeoffGroup
            // 
            this.uipTakeoffGroup.InnerContainer = this.uipTakeoffGroupContainer;
            this.uipTakeoffGroup.Location = new System.Drawing.Point(0, 221);
            this.uipTakeoffGroup.Name = "uipTakeoffGroup";
            this.uipTakeoffGroup.Size = new System.Drawing.Size(169, 86);
            this.uipTakeoffGroup.TabIndex = 4;
            this.uipTakeoffGroup.Text = "Group";
            // 
            // uipTakeoffGroupContainer
            // 
            this.uipTakeoffGroupContainer.Controls.Add(lstGroup);
            this.uipTakeoffGroupContainer.Location = new System.Drawing.Point(1, 23);
            this.uipTakeoffGroupContainer.Name = "uipTakeoffGroupContainer";
            this.uipTakeoffGroupContainer.Size = new System.Drawing.Size(167, 62);
            this.uipTakeoffGroupContainer.TabIndex = 0;
            // 
            // lstGroup
            // 
            lstGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            lstGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            lstGroup.FullRowSelect = true;
            lstGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstGroup.Location = new System.Drawing.Point(0, 0);
            lstGroup.MaximumSize = new System.Drawing.Size(167, 0);
            lstGroup.MultiSelect = false;
            lstGroup.Name = "lstGroup";
            lstGroup.Size = new System.Drawing.Size(167, 62);
            lstGroup.TabIndex = 2;
            lstGroup.UseCompatibleStateImageBehavior = false;
            lstGroup.View = System.Windows.Forms.View.Details;
            lstGroup.DoubleClick += new System.EventHandler(this.TakeOffGroup_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 165;
            // 
            // uipExpression
            // 
            this.uipExpression.Icon = ((System.Drawing.Icon)(resources.GetObject("uipExpression.Icon")));
            this.uipExpression.Location = new System.Drawing.Point(0, 0);
            this.uipExpression.Name = "uipExpression";
            this.uipExpression.Size = new System.Drawing.Size(169, 307);
            this.uipExpression.TabIndex = 4;
            this.uipExpression.Text = "Expression";
            // 
            // uipExpressionDivision
            // 
            this.uipExpressionDivision.ImageIndex = 0;
            this.uipExpressionDivision.InnerContainer = this.uipExpressionDivisionContainer;
            this.uipExpressionDivision.LargeImageIndex = 0;
            this.uipExpressionDivision.Location = new System.Drawing.Point(0, 38);
            this.uipExpressionDivision.Name = "uipExpressionDivision";
            this.uipExpressionDivision.Size = new System.Drawing.Size(169, 269);
            this.uipExpressionDivision.TabIndex = 4;
            this.uipExpressionDivision.Text = "Division";
            // 
            // uipExpressionDivisionContainer
            // 
            this.uipExpressionDivisionContainer.Controls.Add(lstExpressionDivision);
            this.uipExpressionDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipExpressionDivisionContainer.Name = "uipExpressionDivisionContainer";
            this.uipExpressionDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipExpressionDivisionContainer.TabIndex = 0;
            // 
            // uipQuantity
            // 
            this.uipQuantity.Icon = ((System.Drawing.Icon)(resources.GetObject("uipQuantity.Icon")));
            this.uipQuantity.Location = new System.Drawing.Point(0, 0);
            this.uipQuantity.Name = "uipQuantity";
            this.uipQuantity.Size = new System.Drawing.Size(169, 307);
            this.uipQuantity.TabIndex = 4;
            this.uipQuantity.Text = "Quantity";
            // 
            // uipQuantityDivision
            // 
            this.uipQuantityDivision.ImageIndex = 2;
            this.uipQuantityDivision.InnerContainer = this.uipQuantityDivisionContainer;
            this.uipQuantityDivision.LargeImageIndex = 2;
            this.uipQuantityDivision.Location = new System.Drawing.Point(0, 38);
            this.uipQuantityDivision.Name = "uipQuantityDivision";
            this.uipQuantityDivision.Size = new System.Drawing.Size(169, 139);
            this.uipQuantityDivision.TabIndex = 4;
            this.uipQuantityDivision.Text = "Division";
            // 
            // uipQuantityDivisionContainer
            // 
            this.uipQuantityDivisionContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uipQuantityDivisionContainer.Controls.Add(lstQuantityDivision);
            this.uipQuantityDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipQuantityDivisionContainer.Name = "uipQuantityDivisionContainer";
            this.uipQuantityDivisionContainer.Size = new System.Drawing.Size(167, 119);
            this.uipQuantityDivisionContainer.TabIndex = 0;
            // 
            // uipQuantityJob
            // 
            this.uipQuantityJob.InnerContainer = this.uipQuantityJobContainer;
            this.uipQuantityJob.Location = new System.Drawing.Point(0, 181);
            this.uipQuantityJob.Name = "uipQuantityJob";
            this.uipQuantityJob.Size = new System.Drawing.Size(169, 126);
            this.uipQuantityJob.TabIndex = 4;
            this.uipQuantityJob.Text = "Job";
            // 
            // uipQuantityJobContainer
            // 
            this.uipQuantityJobContainer.Controls.Add(lstQuantityJob);
            this.uipQuantityJobContainer.Location = new System.Drawing.Point(1, 23);
            this.uipQuantityJobContainer.Name = "uipQuantityJobContainer";
            this.uipQuantityJobContainer.Size = new System.Drawing.Size(167, 102);
            this.uipQuantityJobContainer.TabIndex = 0;
            // 
            // lstQuantityJob
            // 
            lstQuantityJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstQuantityJob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem13});
            lstQuantityJob.Dock = System.Windows.Forms.DockStyle.Fill;
            lstQuantityJob.FullRowSelect = true;
            lstQuantityJob.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstQuantityJob.Location = new System.Drawing.Point(0, 0);
            lstQuantityJob.MultiSelect = false;
            lstQuantityJob.Name = "lstQuantityJob";
            lstQuantityJob.Scrollable = false;
            lstQuantityJob.Size = new System.Drawing.Size(167, 102);
            lstQuantityJob.TabIndex = 2;
            lstQuantityJob.UseCompatibleStateImageBehavior = false;
            lstQuantityJob.View = System.Windows.Forms.View.Details;
            lstQuantityJob.DoubleClick += new System.EventHandler(this.QuantityJob_Click);
            // 
            // clmItem13
            // 
            this.clmItem13.Text = "Item";
            this.clmItem13.Width = 300;
            // 
            // uipCostItem
            // 
            this.uipCostItem.Icon = ((System.Drawing.Icon)(resources.GetObject("uipCostItem.Icon")));
            this.uipCostItem.Location = new System.Drawing.Point(0, 0);
            this.uipCostItem.Name = "uipCostItem";
            this.uipCostItem.Size = new System.Drawing.Size(169, 307);
            this.uipCostItem.TabIndex = 4;
            this.uipCostItem.Text = "Cost Item";
            // 
            // uipCostItemDivision
            // 
            this.uipCostItemDivision.ImageIndex = 4;
            this.uipCostItemDivision.InnerContainer = this.uipCostItemDivisionContainer;
            this.uipCostItemDivision.LargeImageIndex = 4;
            this.uipCostItemDivision.Location = new System.Drawing.Point(0, 38);
            this.uipCostItemDivision.Name = "uipCostItemDivision";
            this.uipCostItemDivision.Size = new System.Drawing.Size(169, 269);
            this.uipCostItemDivision.TabIndex = 4;
            this.uipCostItemDivision.Text = "Cost Type";
            // 
            // uipCostItemDivisionContainer
            // 
            this.uipCostItemDivisionContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uipCostItemDivisionContainer.Controls.Add(lstCostItemDivision);
            this.uipCostItemDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipCostItemDivisionContainer.Name = "uipCostItemDivisionContainer";
            this.uipCostItemDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipCostItemDivisionContainer.TabIndex = 0;
            // 
            // uipCostAmount
            // 
            this.uipCostAmount.Icon = ((System.Drawing.Icon)(resources.GetObject("uipCostAmount.Icon")));
            this.uipCostAmount.Location = new System.Drawing.Point(0, 0);
            this.uipCostAmount.Name = "uipCostAmount";
            this.uipCostAmount.Size = new System.Drawing.Size(169, 307);
            this.uipCostAmount.TabIndex = 4;
            this.uipCostAmount.Text = "Cost Amount";
            // 
            // uipCostAmountDivision
            // 
            this.uipCostAmountDivision.ImageIndex = 2;
            this.uipCostAmountDivision.InnerContainer = this.uipCostAmountDivisionContainer;
            this.uipCostAmountDivision.LargeImageIndex = 2;
            this.uipCostAmountDivision.Location = new System.Drawing.Point(0, 38);
            this.uipCostAmountDivision.Name = "uipCostAmountDivision";
            this.uipCostAmountDivision.Size = new System.Drawing.Size(169, 269);
            this.uipCostAmountDivision.TabIndex = 4;
            this.uipCostAmountDivision.Text = "Building Type";
            // 
            // uipCostAmountDivisionContainer
            // 
            this.uipCostAmountDivisionContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uipCostAmountDivisionContainer.Controls.Add(lstCostAmountDivision);
            this.uipCostAmountDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipCostAmountDivisionContainer.Name = "uipCostAmountDivisionContainer";
            this.uipCostAmountDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipCostAmountDivisionContainer.TabIndex = 0;
            // 
            // uipEstimate
            // 
            this.uipEstimate.Icon = ((System.Drawing.Icon)(resources.GetObject("uipEstimate.Icon")));
            this.uipEstimate.Location = new System.Drawing.Point(0, 0);
            this.uipEstimate.Name = "uipEstimate";
            this.uipEstimate.Size = new System.Drawing.Size(169, 307);
            this.uipEstimate.TabIndex = 4;
            this.uipEstimate.Text = "Estimate";
            // 
            // uipEstimateBuilding
            // 
            this.uipEstimateBuilding.InnerContainer = this.uipEstimateBuildingContainer;
            this.uipEstimateBuilding.Location = new System.Drawing.Point(0, 38);
            this.uipEstimateBuilding.Name = "uipEstimateBuilding";
            this.uipEstimateBuilding.Size = new System.Drawing.Size(169, 136);
            this.uipEstimateBuilding.TabIndex = 4;
            this.uipEstimateBuilding.Text = "Building Type";
            // 
            // uipEstimateBuildingContainer
            // 
            this.uipEstimateBuildingContainer.Controls.Add(lstEstimateBuildingType);
            this.uipEstimateBuildingContainer.Location = new System.Drawing.Point(1, 23);
            this.uipEstimateBuildingContainer.Name = "uipEstimateBuildingContainer";
            this.uipEstimateBuildingContainer.Size = new System.Drawing.Size(167, 112);
            this.uipEstimateBuildingContainer.TabIndex = 0;
            // 
            // lstEstimateBuildingType
            // 
            lstEstimateBuildingType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstEstimateBuildingType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem14});
            lstEstimateBuildingType.Dock = System.Windows.Forms.DockStyle.Fill;
            lstEstimateBuildingType.FullRowSelect = true;
            lstEstimateBuildingType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstEstimateBuildingType.Location = new System.Drawing.Point(0, 0);
            lstEstimateBuildingType.MultiSelect = false;
            lstEstimateBuildingType.Name = "lstEstimateBuildingType";
            lstEstimateBuildingType.Scrollable = false;
            lstEstimateBuildingType.Size = new System.Drawing.Size(167, 112);
            lstEstimateBuildingType.TabIndex = 1;
            lstEstimateBuildingType.UseCompatibleStateImageBehavior = false;
            lstEstimateBuildingType.View = System.Windows.Forms.View.Details;
            lstEstimateBuildingType.DoubleClick += new System.EventHandler(this.EstimateDivision_Click);
            // 
            // clmItem14
            // 
            this.clmItem14.Text = "Item";
            this.clmItem14.Width = 300;
            // 
            // uipEstimateProject
            // 
            this.uipEstimateProject.ImageIndex = 3;
            this.uipEstimateProject.InnerContainer = this.uipEstimateProjectContainer;
            this.uipEstimateProject.LargeImageIndex = 3;
            this.uipEstimateProject.Location = new System.Drawing.Point(0, 178);
            this.uipEstimateProject.Name = "uipEstimateProject";
            this.uipEstimateProject.Size = new System.Drawing.Size(169, 129);
            this.uipEstimateProject.TabIndex = 4;
            this.uipEstimateProject.Text = "Project";
            // 
            // uipEstimateProjectContainer
            // 
            this.uipEstimateProjectContainer.Controls.Add(lstEstimateProject);
            this.uipEstimateProjectContainer.Location = new System.Drawing.Point(1, 19);
            this.uipEstimateProjectContainer.Name = "uipEstimateProjectContainer";
            this.uipEstimateProjectContainer.Size = new System.Drawing.Size(167, 109);
            this.uipEstimateProjectContainer.TabIndex = 0;
            // 
            // lstEstimateProject
            // 
            lstEstimateProject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lstEstimateProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmItem15});
            lstEstimateProject.Dock = System.Windows.Forms.DockStyle.Fill;
            lstEstimateProject.FullRowSelect = true;
            lstEstimateProject.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstEstimateProject.Location = new System.Drawing.Point(0, 0);
            lstEstimateProject.MultiSelect = false;
            lstEstimateProject.Name = "lstEstimateProject";
            lstEstimateProject.Scrollable = false;
            lstEstimateProject.Size = new System.Drawing.Size(167, 109);
            lstEstimateProject.TabIndex = 2;
            lstEstimateProject.UseCompatibleStateImageBehavior = false;
            lstEstimateProject.View = System.Windows.Forms.View.Details;
            lstEstimateProject.DoubleClick += new System.EventHandler(this.EstimateProjectDivision_Click);
            // 
            // clmItem15
            // 
            this.clmItem15.Text = "Item";
            this.clmItem15.Width = 300;
            // 
            // uipValidationUser
            // 
            this.uipValidationUser.Icon = ((System.Drawing.Icon)(resources.GetObject("uipValidationUser.Icon")));
            this.uipValidationUser.Location = new System.Drawing.Point(0, 0);
            this.uipValidationUser.Name = "uipValidationUser";
            this.uipValidationUser.Size = new System.Drawing.Size(169, 307);
            this.uipValidationUser.TabIndex = 4;
            this.uipValidationUser.Text = "Validation User";
            // 
            // uipValidationUserDivision
            // 
            this.uipValidationUserDivision.ImageIndex = 2;
            this.uipValidationUserDivision.InnerContainer = this.uipValidationUserDivisionContainer;
            this.uipValidationUserDivision.LargeImageIndex = 2;
            this.uipValidationUserDivision.Location = new System.Drawing.Point(0, 38);
            this.uipValidationUserDivision.Name = "uipValidationUserDivision";
            this.uipValidationUserDivision.Size = new System.Drawing.Size(169, 269);
            this.uipValidationUserDivision.TabIndex = 4;
            this.uipValidationUserDivision.Text = "Group";
            // 
            // uipValidationUserDivisionContainer
            // 
            this.uipValidationUserDivisionContainer.Controls.Add(lstValidationUserDivision);
            this.uipValidationUserDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipValidationUserDivisionContainer.Name = "uipValidationUserDivisionContainer";
            this.uipValidationUserDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipValidationUserDivisionContainer.TabIndex = 0;
            // 
            // uipValidationSystem
            // 
            this.uipValidationSystem.Icon = ((System.Drawing.Icon)(resources.GetObject("uipValidationSystem.Icon")));
            this.uipValidationSystem.Location = new System.Drawing.Point(0, 0);
            this.uipValidationSystem.Name = "uipValidationSystem";
            this.uipValidationSystem.Size = new System.Drawing.Size(169, 307);
            this.uipValidationSystem.TabIndex = 4;
            this.uipValidationSystem.Text = "Validation System";
            // 
            // uipValidationSystemDivision
            // 
            this.uipValidationSystemDivision.ImageIndex = 1;
            this.uipValidationSystemDivision.InnerContainer = this.uipValidationSystemDivisionContainer;
            this.uipValidationSystemDivision.LargeImageIndex = 1;
            this.uipValidationSystemDivision.Location = new System.Drawing.Point(0, 38);
            this.uipValidationSystemDivision.Name = "uipValidationSystemDivision";
            this.uipValidationSystemDivision.Size = new System.Drawing.Size(169, 269);
            this.uipValidationSystemDivision.TabIndex = 4;
            this.uipValidationSystemDivision.Text = "Type";
            // 
            // uipValidationSystemDivisionContainer
            // 
            this.uipValidationSystemDivisionContainer.BackColor = System.Drawing.Color.White;
            this.uipValidationSystemDivisionContainer.Controls.Add(lstValidationSystemDivision);
            this.uipValidationSystemDivisionContainer.Location = new System.Drawing.Point(1, 19);
            this.uipValidationSystemDivisionContainer.Name = "uipValidationSystemDivisionContainer";
            this.uipValidationSystemDivisionContainer.Size = new System.Drawing.Size(167, 249);
            this.uipValidationSystemDivisionContainer.TabIndex = 0;
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.BottomRebar = this.BottomRebar1;
            uiCommandCategory1.CategoryName = "File";
            uiCommandCategory2.CategoryName = "Edit";
            uiCommandCategory3.CategoryName = "Format";
            uiCommandCategory4.CategoryName = "View";
            uiCommandCategory5.CategoryName = "Tool";
            uiCommandCategory6.CategoryName = "Data";
            uiCommandCategory7.CategoryName = "Window";
            uiCommandCategory8.CategoryName = "Help";
            this.uiCmdManagerMenuBar.Categories.AddRange(new Janus.Windows.UI.CommandBars.UICommandCategory[] {
            uiCommandCategory1,
            uiCommandCategory2,
            uiCommandCategory3,
            uiCommandCategory4,
            uiCommandCategory5,
            uiCommandCategory6,
            uiCommandCategory7,
            uiCommandCategory8});
            this.uiCmdManagerMenuBar.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCmdBarMenu,
            this.uiCmdBarIcon});
            this.uiCmdManagerMenuBar.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.CmdFile,
            this.CmdNew,
            this.cmdCost,
            this.cmdContact,
            this.cmdJob,
            this.cmdTakeOff,
            this.cmdTask,
            this.cmdExpression,
            this.cmdQuantity,
            this.cmdAssembly,
            this.cmdCostAmount,
            this.CmdCostItem,
            this.cmdValidationUser,
            this.cmdValidationSystem,
            this.CmdHelpEstimateBuilder,
            this.cmdExit,
            this.cmdHelpAbout});
            this.uiCmdManagerMenuBar.ContainerControl = this;
            this.uiCmdManagerMenuBar.Id = new System.Guid("75269c13-4eee-48dc-a3cd-0f46e47a3ac5");
            this.uiCmdManagerMenuBar.ImageList = this.LargeIcon;
            this.uiCmdManagerMenuBar.LargeImageList = this.LargeIcon;
            this.uiCmdManagerMenuBar.LeftRebar = this.LeftRebar1;
            this.uiCmdManagerMenuBar.RightRebar = this.RightRebar1;
            this.uiCmdManagerMenuBar.TopRebar = this.TopRebar1;
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandManager = null;
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 0);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(0, 0);
            this.BottomRebar1.TabIndex = 0;
            // 
            // uiCmdBarMenu
            // 
            this.uiCmdBarMenu.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu;
            this.uiCmdBarMenu.CommandManager = this.uiCmdManagerMenuBar;
            this.uiCmdBarMenu.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.CmdFileMenu,
            this.CmdHelpEstimateBuilder1});
            this.uiCmdBarMenu.Key = "Menu";
            this.uiCmdBarMenu.Location = new System.Drawing.Point(0, 0);
            this.uiCmdBarMenu.Name = "uiCmdBarMenu";
            this.uiCmdBarMenu.RowIndex = 0;
            this.uiCmdBarMenu.Size = new System.Drawing.Size(1028, 24);
            this.uiCmdBarMenu.TabIndex = 0;
            this.uiCmdBarMenu.Text = "Menu";
            this.uiCmdBarMenu.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.uiCommandBar1_CommandClick);
            // 
            // CmdFileMenu
            // 
            this.CmdFileMenu.Key = "CmdFile";
            this.CmdFileMenu.Name = "CmdFileMenu";
            // 
            // CmdHelpEstimateBuilder1
            // 
            this.CmdHelpEstimateBuilder1.Key = "CmdHelpEstimateBuilder";
            this.CmdHelpEstimateBuilder1.Name = "CmdHelpEstimateBuilder1";
            // 
            // uiCmdBarIcon
            // 
            this.uiCmdBarIcon.CommandManager = this.uiCmdManagerMenuBar;
            this.uiCmdBarIcon.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdContactIcon,
            this.cmdEstimateIcon,
            this.cmdAssemblyIcon,
            this.cmdTakeOffIcon,
            this.cmdExpressionIcon,
            this.cmdQuantityIcon,
            this.CmdCostItemIcon,
            this.cmdCostAmountIcon,
            this.cmdValidationUserIcon,
            this.cmdValidationSystemIcon});
            this.uiCmdBarIcon.CommandsStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.uiCmdBarIcon.FloatingLocation = new System.Drawing.Point(283, 114);
            this.uiCmdBarIcon.FloatingSize = new System.Drawing.Size(266, 22);
            this.uiCmdBarIcon.ImageList = this.LargeIcon;
            this.uiCmdBarIcon.Key = "EstimateTools";
            this.uiCmdBarIcon.LargeImageList = this.LargeIcon;
            this.uiCmdBarIcon.Location = new System.Drawing.Point(0, 24);
            this.uiCmdBarIcon.Name = "uiCmdBarIcon";
            this.uiCmdBarIcon.RowIndex = 1;
            this.uiCmdBarIcon.Size = new System.Drawing.Size(877, 26);
            this.uiCmdBarIcon.TabIndex = 1;
            this.uiCmdBarIcon.Text = "EstimateTools";
            this.uiCmdBarIcon.CommandClick += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.uiCommandBar2_CommandClick);
            // 
            // cmdContactIcon
            // 
            this.cmdContactIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdContactIcon.HotImageIndex = 8;
            this.cmdContactIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdContactIcon.Icon")));
            this.cmdContactIcon.Key = "cmdContact";
            this.cmdContactIcon.LargeImageIndex = 8;
            this.cmdContactIcon.Name = "cmdContactIcon";
            this.cmdContactIcon.ToolTipText = "Contact Management";
            // 
            // cmdEstimateIcon
            // 
            this.cmdEstimateIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdEstimateIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdEstimateIcon.Icon")));
            this.cmdEstimateIcon.Key = "cmdJob";
            this.cmdEstimateIcon.LargeImageIndex = 7;
            this.cmdEstimateIcon.Name = "cmdEstimateIcon";
            this.cmdEstimateIcon.ToolTipText = "Estimate";
            // 
            // cmdAssemblyIcon
            // 
            this.cmdAssemblyIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdAssemblyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdAssemblyIcon.Icon")));
            this.cmdAssemblyIcon.Key = "cmdAssembly";
            this.cmdAssemblyIcon.Name = "cmdAssemblyIcon";
            this.cmdAssemblyIcon.ToolTipText = "Assembly";
            // 
            // cmdTakeOffIcon
            // 
            this.cmdTakeOffIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdTakeOffIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdTakeOffIcon.Icon")));
            this.cmdTakeOffIcon.Key = "cmdTakeOff";
            this.cmdTakeOffIcon.LargeImageIndex = 0;
            this.cmdTakeOffIcon.Name = "cmdTakeOffIcon";
            this.cmdTakeOffIcon.Text = "&Takeoff";
            this.cmdTakeOffIcon.ToolTipText = "Takeoff";
            // 
            // cmdExpressionIcon
            // 
            this.cmdExpressionIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdExpressionIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdExpressionIcon.Icon")));
            this.cmdExpressionIcon.Key = "cmdExpression";
            this.cmdExpressionIcon.LargeImageIndex = 1;
            this.cmdExpressionIcon.Name = "cmdExpressionIcon";
            this.cmdExpressionIcon.ToolTipText = "Expression";
            // 
            // cmdQuantityIcon
            // 
            this.cmdQuantityIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdQuantityIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdQuantityIcon.Icon")));
            this.cmdQuantityIcon.Key = "cmdQuantity";
            this.cmdQuantityIcon.LargeImageIndex = 4;
            this.cmdQuantityIcon.Name = "cmdQuantityIcon";
            // 
            // CmdCostItemIcon
            // 
            this.CmdCostItemIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.CmdCostItemIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("CmdCostItemIcon.Icon")));
            this.CmdCostItemIcon.Key = "CmdCostItem";
            this.CmdCostItemIcon.LargeImageIndex = 4;
            this.CmdCostItemIcon.Name = "CmdCostItemIcon";
            // 
            // cmdCostAmountIcon
            // 
            this.cmdCostAmountIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdCostAmountIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdCostAmountIcon.Icon")));
            this.cmdCostAmountIcon.Key = "cmdCostAmount";
            this.cmdCostAmountIcon.LargeImageIndex = 6;
            this.cmdCostAmountIcon.Name = "cmdCostAmountIcon";
            // 
            // cmdValidationUserIcon
            // 
            this.cmdValidationUserIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdValidationUserIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdValidationUserIcon.Icon")));
            this.cmdValidationUserIcon.Key = "cmdValidationUser";
            this.cmdValidationUserIcon.LargeImageIndex = 3;
            this.cmdValidationUserIcon.Name = "cmdValidationUserIcon";
            this.cmdValidationUserIcon.ToolTipText = "Validation User";
            // 
            // cmdValidationSystemIcon
            // 
            this.cmdValidationSystemIcon.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.TextImage;
            this.cmdValidationSystemIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("cmdValidationSystemIcon.Icon")));
            this.cmdValidationSystemIcon.Key = "cmdValidationSystem";
            this.cmdValidationSystemIcon.LargeImageIndex = 2;
            this.cmdValidationSystemIcon.Name = "cmdValidationSystemIcon";
            this.cmdValidationSystemIcon.ToolTipText = "Validation System";
            // 
            // CmdFile
            // 
            this.CmdFile.CategoryName = "File";
            this.CmdFile.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.CmdNewFile,
            this.SeparatorFile,
            this.cmdExitFile});
            this.CmdFile.Key = "CmdFile";
            this.CmdFile.Name = "CmdFile";
            this.CmdFile.Text = "&File";
            // 
            // CmdNewFile
            // 
            this.CmdNewFile.Key = "CmdNew";
            this.CmdNewFile.Name = "CmdNewFile";
            // 
            // SeparatorFile
            // 
            this.SeparatorFile.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.SeparatorFile.Key = "Separator";
            this.SeparatorFile.Name = "SeparatorFile";
            // 
            // cmdExitFile
            // 
            this.cmdExitFile.Key = "cmdExit";
            this.cmdExitFile.Name = "cmdExitFile";
            // 
            // CmdNew
            // 
            this.CmdNew.CategoryName = "File";
            this.CmdNew.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdContactNew,
            this.CmdJobNew,
            this.cmdAssemblyNew,
            this.cmdTakeOffNew,
            this.cmdExpressionNew,
            this.cmdQuantityNew,
            this.cmdCostAmountNew,
            this.CmdCostItemNew,
            this.cmdValidationUserNew,
            this.cmdValidationSystemNew});
            this.CmdNew.Key = "CmdNew";
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Text = "&New";
            // 
            // cmdContactNew
            // 
            this.cmdContactNew.Key = "cmdContact";
            this.cmdContactNew.Name = "cmdContactNew";
            // 
            // CmdJobNew
            // 
            this.CmdJobNew.Key = "cmdJob";
            this.CmdJobNew.Name = "CmdJobNew";
            // 
            // cmdAssemblyNew
            // 
            this.cmdAssemblyNew.Key = "cmdAssembly";
            this.cmdAssemblyNew.Name = "cmdAssemblyNew";
            // 
            // cmdTakeOffNew
            // 
            this.cmdTakeOffNew.Key = "cmdTakeOff";
            this.cmdTakeOffNew.Name = "cmdTakeOffNew";
            // 
            // cmdExpressionNew
            // 
            this.cmdExpressionNew.Key = "cmdExpression";
            this.cmdExpressionNew.Name = "cmdExpressionNew";
            // 
            // cmdQuantityNew
            // 
            this.cmdQuantityNew.Key = "cmdQuantity";
            this.cmdQuantityNew.Name = "cmdQuantityNew";
            // 
            // cmdCostAmountNew
            // 
            this.cmdCostAmountNew.Key = "cmdCostAmount";
            this.cmdCostAmountNew.Name = "cmdCostAmountNew";
            // 
            // CmdCostItemNew
            // 
            this.CmdCostItemNew.Key = "CmdCostItem";
            this.CmdCostItemNew.Name = "CmdCostItemNew";
            // 
            // cmdValidationUserNew
            // 
            this.cmdValidationUserNew.Key = "cmdValidationUser";
            this.cmdValidationUserNew.Name = "cmdValidationUserNew";
            // 
            // cmdValidationSystemNew
            // 
            this.cmdValidationSystemNew.Key = "cmdValidationSystem";
            this.cmdValidationSystemNew.Name = "cmdValidationSystemNew";
            // 
            // cmdCost
            // 
            this.cmdCost.Key = "cmdCost";
            this.cmdCost.Name = "cmdCost";
            // 
            // cmdContact
            // 
            this.cmdContact.CategoryName = "File";
            this.cmdContact.Key = "cmdContact";
            this.cmdContact.LargeImageIndex = 8;
            this.cmdContact.Name = "cmdContact";
            this.cmdContact.Text = "&Contact Management";
            // 
            // cmdJob
            // 
            this.cmdJob.CategoryName = "File";
            this.cmdJob.Key = "cmdJob";
            this.cmdJob.Name = "cmdJob";
            this.cmdJob.Text = "&Job";
            // 
            // cmdTakeOff
            // 
            this.cmdTakeOff.CategoryName = "File";
            this.cmdTakeOff.Key = "cmdTakeOff";
            this.cmdTakeOff.Name = "cmdTakeOff";
            this.cmdTakeOff.Text = "&TakeOff";
            // 
            // cmdTask
            // 
            this.cmdTask.Key = "cmdTask";
            this.cmdTask.Name = "cmdTask";
            // 
            // cmdExpression
            // 
            this.cmdExpression.CategoryName = "File";
            this.cmdExpression.Key = "cmdExpression";
            this.cmdExpression.Name = "cmdExpression";
            this.cmdExpression.Text = "&Expression";
            // 
            // cmdQuantity
            // 
            this.cmdQuantity.CategoryName = "File";
            this.cmdQuantity.Key = "cmdQuantity";
            this.cmdQuantity.Name = "cmdQuantity";
            this.cmdQuantity.Text = "&Quantity";
            // 
            // cmdAssembly
            // 
            this.cmdAssembly.CategoryName = "File";
            this.cmdAssembly.Key = "cmdAssembly";
            this.cmdAssembly.Name = "cmdAssembly";
            this.cmdAssembly.Text = "&Assembly";
            // 
            // cmdCostAmount
            // 
            this.cmdCostAmount.CategoryName = "File";
            this.cmdCostAmount.Key = "cmdCostAmount";
            this.cmdCostAmount.Name = "cmdCostAmount";
            this.cmdCostAmount.Text = "&Cost Amount";
            // 
            // CmdCostItem
            // 
            this.CmdCostItem.CategoryName = "File";
            this.CmdCostItem.Key = "CmdCostItem";
            this.CmdCostItem.Name = "CmdCostItem";
            this.CmdCostItem.Text = "Cost &Item";
            // 
            // cmdValidationUser
            // 
            this.cmdValidationUser.CategoryName = "File";
            this.cmdValidationUser.Key = "cmdValidationUser";
            this.cmdValidationUser.Name = "cmdValidationUser";
            this.cmdValidationUser.Text = "&Validation User";
            // 
            // cmdValidationSystem
            // 
            this.cmdValidationSystem.CategoryName = "File";
            this.cmdValidationSystem.Key = "cmdValidationSystem";
            this.cmdValidationSystem.Name = "cmdValidationSystem";
            this.cmdValidationSystem.Text = "Validation &System";
            // 
            // CmdHelpEstimateBuilder
            // 
            this.CmdHelpEstimateBuilder.CategoryName = "Help";
            this.CmdHelpEstimateBuilder.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdHelpAboutMenu});
            this.CmdHelpEstimateBuilder.Key = "CmdHelpEstimateBuilder";
            this.CmdHelpEstimateBuilder.Name = "CmdHelpEstimateBuilder";
            this.CmdHelpEstimateBuilder.Text = "Help &Estimate Builder";
            // 
            // cmdHelpAboutMenu
            // 
            this.cmdHelpAboutMenu.Key = "cmdHelpAbout";
            this.cmdHelpAboutMenu.Name = "cmdHelpAboutMenu";
            // 
            // cmdExit
            // 
            this.cmdExit.CategoryName = "File";
            this.cmdExit.Key = "cmdExit";
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Text = "Exit";
            // 
            // cmdHelpAbout
            // 
            this.cmdHelpAbout.CategoryName = "Help";
            this.cmdHelpAbout.Key = "cmdHelpAbout";
            this.cmdHelpAbout.Name = "cmdHelpAbout";
            this.cmdHelpAbout.Text = "About";
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = null;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 0);
            this.LeftRebar1.TabIndex = 0;
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = null;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(0, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 0);
            this.RightRebar1.TabIndex = 0;
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCmdBarMenu,
            this.uiCmdBarIcon});
            this.TopRebar1.CommandManager = this.uiCmdManagerMenuBar;
            this.TopRebar1.Controls.Add(progressEstimate);
            this.TopRebar1.Controls.Add(this.uiCmdBarMenu);
            this.TopRebar1.Controls.Add(this.uiCmdBarIcon);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(1028, 50);
            this.TopRebar1.TabIndex = 8;
            // 
            // progressEstimate
            // 
            progressEstimate.Location = new System.Drawing.Point(911, 31);
            progressEstimate.Name = "progressEstimate";
            progressEstimate.Size = new System.Drawing.Size(159, 16);
            progressEstimate.TabIndex = 2;
            // 
            // Builder
            // 
            this.ClientSize = new System.Drawing.Size(1028, 753);
            this.Controls.Add(this.uipNavigator);
            this.Controls.Add(this.TopRebar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Builder";
            this.Text = "Builder 2.07142005.0949 ";
            this.Load += new System.EventHandler(this.Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uipNavigator)).EndInit();
            this.uipNavigator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipContact)).EndInit();
            this.uipContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipContactTree)).EndInit();
            this.uipContactTree.ResumeLayout(false);
            this.uipContactDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipJob)).EndInit();
            this.uipJob.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipJobDivision)).EndInit();
            this.uipJobDivision.ResumeLayout(false);
            this.uipJobDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipAssembly)).EndInit();
            this.uipAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipAssemblyDivision)).EndInit();
            this.uipAssemblyDivision.ResumeLayout(false);
            this.uipAssemblyDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOff)).EndInit();
            this.uipTakeOff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOffDivision)).EndInit();
            this.uipTakeOffDivision.ResumeLayout(false);
            this.uipTakeOffDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeOffJob)).EndInit();
            this.uipTakeOffJob.ResumeLayout(false);
            this.uipTakeOffJobContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipTakeoffGroup)).EndInit();
            this.uipTakeoffGroup.ResumeLayout(false);
            this.uipTakeoffGroupContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipExpression)).EndInit();
            this.uipExpression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipExpressionDivision)).EndInit();
            this.uipExpressionDivision.ResumeLayout(false);
            this.uipExpressionDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantity)).EndInit();
            this.uipQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantityDivision)).EndInit();
            this.uipQuantityDivision.ResumeLayout(false);
            this.uipQuantityDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipQuantityJob)).EndInit();
            this.uipQuantityJob.ResumeLayout(false);
            this.uipQuantityJobContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipCostItem)).EndInit();
            this.uipCostItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipCostItemDivision)).EndInit();
            this.uipCostItemDivision.ResumeLayout(false);
            this.uipCostItemDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipCostAmount)).EndInit();
            this.uipCostAmount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipCostAmountDivision)).EndInit();
            this.uipCostAmountDivision.ResumeLayout(false);
            this.uipCostAmountDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimate)).EndInit();
            this.uipEstimate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimateBuilding)).EndInit();
            this.uipEstimateBuilding.ResumeLayout(false);
            this.uipEstimateBuildingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipEstimateProject)).EndInit();
            this.uipEstimateProject.ResumeLayout(false);
            this.uipEstimateProjectContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationUser)).EndInit();
            this.uipValidationUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationUserDivision)).EndInit();
            this.uipValidationUserDivision.ResumeLayout(false);
            this.uipValidationUserDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationSystem)).EndInit();
            this.uipValidationSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uipValidationSystemDivision)).EndInit();
            this.uipValidationSystemDivision.ResumeLayout(false);
            this.uipValidationSystemDivisionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdBarMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdBarIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        #region MyCode



        public EstimateBuilder.ApplicationBuilder application = new ApplicationBuilder();
        public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
        protected static EstimateBuilder.ListDataProvider DataSource = new ListDataProvider();
        public static DataTable DataSourceDivision;
        public static DataTable DataSourceDivisionCost;
        public static DataTable DataSourceDivisionPrint;
        public static DataTable DataSourceDivisionInput;
        public static DataTable DataSourceDivisionUnits;
        public static DataTable DataSourceLocation;
        public static DataTable DataSourceMethod;
        public static DataTable DataSourceType;
        public static DataTable DataSourceJobIDJob;
        public static DataTable DataSourceCostItemIDDesc;
        public static DataTable DataSourceContract;
        public static DataTable DataSourcePhase;
        public static DataTable DataSourceAssemblyIDName;
        public static DataTable DataSourceUnits;
        public static DataTable DataSourceContactIDOwner;
        public static DataTable DataSourceProjectIDName;
        public static DataTable DataSourceContactJobIDJob;
        public static DataTable DataSourceUSStates;
        public static DataTable DataSourceRegions;
        public static DataTable DataSourceContactType;
        public static DataTable DataSourceManufactureIDCompany;
        public static DataTable DataSourceVendorIDCompany;
        public static DataTable DataSourceContractors;
        public static DataTable DataSourceValidationType;
        public static DataTable DataSourceValidationGroup;
        public static DataTable DataSourceAccounting;
        public static DataTable DataSourceDescExpressionID;
        public static DataTable DataSourceValidationPhase;
        public static DataTable DataSourceValidationSystem;
        public static DataTable DataSourceCostType;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            EstimateBuilder.ApplicationBuilder.OpenContactMode = OpenContact.Off;

            Application.Run(new Builder());

        }

        public void loadDLL()
        {

            DataSourceJobIDJob = DataSource.JobIDJob();
            DataSourceCostItemIDDesc = DataSource.CostItemIDDescription();
            DataSourceAssemblyIDName = DataSource.AssemblyIDName();
            DataSourceContactIDOwner = DataSource.ContactIDOwner();
            DataSourceProjectIDName = DataSource.ProjectIDName();
            DataSourceContactJobIDJob = DataSource.ContactJobIDJob();
            DataSourceContactType = DataSource.ContactType();
            DataSourceManufactureIDCompany = DataSource.ManufactureIDCompany();
            DataSourceVendorIDCompany = DataSource.VendorIDCompany();


            _DivisionDataProvider.selectQuantityDivision(lstQuantityDivision);
            _DivisionDataProvider.selectTakeOffJob(lstQuantityJob);
            _DivisionDataProvider.selectAssembly(lstAssemblyDivision);
            _DivisionDataProvider.selectContact(lstContactDivision);
            _DivisionDataProvider.selectCostAmount(lstCostAmountDivision);
            _DivisionDataProvider.selectCostItem(lstCostItemDivision);
            _DivisionDataProvider.selectJob(lstJobDivision);
            _DivisionDataProvider.selectExpression(lstExpressionDivision);
            _DivisionDataProvider.selectEstimateBuildingType(lstEstimateBuildingType);
            _DivisionDataProvider.selectEstimateProject(lstEstimateProject, "All");
            _DivisionDataProvider.selectTakeOff(lstTakeOffDivision);
            _DivisionDataProvider.selectTakeOffJob(lstTakeOffJob);
            _DivisionDataProvider.selectValidationSystem(lstValidationSystemDivision);
            _DivisionDataProvider.selectValidationUser(lstValidationUserDivision);
            _DivisionDataProvider.selectValidationTakeoff(lstGroup);

        }

        public static void LoadValidationDLL()
        {
            DataSourceDivision = DataSource.UserValidationDivision();
            DataSourceDivisionCost = DataSource.UserValidationDivisionCost();
            DataSourceDivisionPrint = DataSource.UserValidationDivisionPrint();
            DataSourceDivisionInput = DataSource.UserValidationInput();
            DataSourceDivisionUnits = DataSource.UserValidationUnits();
            DataSourceLocation = DataSource.UserValidationLocation();
            DataSourceMethod = DataSource.UserValidationMethod();
            DataSourceType = DataSource.UserValidationBuildingType();
            DataSourceContract = DataSource.UserValidationContract();
            DataSourcePhase = DataSource.UserValidationPhase();
            DataSourceContractors = DataSource.UserValidationContractors();
            DataSourceValidationType = DataSource.UserValidationType();
            DataSourceValidationGroup = DataSource.UserValidationGroup();
            DataSourceUnits = DataSource.UserValidationUnits();
            DataSourceAccounting = DataSource.UserValidationAccounting();
            DataSourceDescExpressionID = DataSource.DescriptionExpressionID();
            DataSourceValidationPhase = DataSource.UserValidationPhase();
            DataSourceValidationSystem = DataSource.TypeValidationSystem();
            DataSourceCostType = DataSource.UserValidationCostType();
            DataSourceUSStates = DataSource.USStates();
            DataSourceRegions = DataSource.Regions();
        }


        private void Builder_Load(object sender, System.EventArgs e)
        {

            EstimateBuilder.ApplicationBuilder.OpenContactMode = OpenContact.On;
            EstimateBuilder.ApplicationBuilder.OpenAssemblyMode = OpenAssembly.Off;
            EstimateBuilder.ApplicationBuilder.OpenCostAmountMode = OpenCostAmount.Off;
            EstimateBuilder.ApplicationBuilder.OpenCostItemMode = OpenCostItem.Off;
            EstimateBuilder.ApplicationBuilder.OpenJobMode = OpenJob.Off;
            EstimateBuilder.ApplicationBuilder.OpenExpressionMode = OpenExpression.Off;
            EstimateBuilder.ApplicationBuilder.OpenQuantityMode = OpenQuantity.Off;
            EstimateBuilder.ApplicationBuilder.OpenEstimateMode = OpenEstimate.Off;
            EstimateBuilder.ApplicationBuilder.OpenTakeOffMode = OpenTakeOff.Off;
            EstimateBuilder.ApplicationBuilder.OpenTakeOffJobMode = OpenTakeOffJob.Off;
            EstimateBuilder.ApplicationBuilder.OpenValidationSystemMode = OpenValidationSystem.Off;
            EstimateBuilder.ApplicationBuilder.OpenValidationUserMode = OpenValidationUser.Off;
            EstimateBuilder.ApplicationBuilder.OpenQuantityJobMode = OpenQuantityJob.Off;

            loadDLL();
            LoadValidationDLL();
        }


        #region Select Division

     
       
        private void ValidationSystemDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstValidationSystemDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.validationSystemId = _id;
            loadValidationSystemMDI(EstimateBuilder.ApplicationBuilder.validationSystemId);

        }
        private void ValidationUserDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstValidationUserDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.validationUserId = _id;
            loadValidationUserMDI(EstimateBuilder.ApplicationBuilder.validationUserId);

        }
        private void JobDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstJobDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.jobId = _id;
            loadJobMDI(EstimateBuilder.ApplicationBuilder.jobId);
        }
        private void EstimateDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstEstimateBuildingType.FocusedItem.Text;
            _DivisionDataProvider.selectEstimateProject(lstEstimateProject, _id);
            EstimateBuilder.ApplicationBuilder.estimateId = "0-" + _id;
            loadEstimateMDI(EstimateBuilder.ApplicationBuilder.estimateId);
        }
        private void EstimateProjectDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstEstimateProject.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.estimateId = _id;
            loadEstimateMDI(EstimateBuilder.ApplicationBuilder.estimateId);
        }
        private void costItemDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstCostItemDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.costItemId = _id;
            loadCostItemMDI(EstimateBuilder.ApplicationBuilder.costItemId);
        }
        private void CostAmountDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstCostAmountDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.costAmountId = _id;
            loadCostAmountMDI(EstimateBuilder.ApplicationBuilder.costAmountId);
        }
        private void AssemblyDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstAssemblyDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.assemblyId = _id;
            loadAssemblyMDI(EstimateBuilder.ApplicationBuilder.assemblyId);
        }
        private void TakeOffDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstTakeOffDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.takeOffId = _id;
            EstimateBuilder.ApplicationBuilder.takeOffJobId = null;
            EstimateBuilder.ApplicationBuilder.takeOffGroup = null;
            loadTakeOffMDI(EstimateBuilder.ApplicationBuilder.takeOffId);

        }
        private void TakeOffJob_Click(object sender, System.EventArgs e)
        {
            string _id = lstTakeOffJob.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.takeOffJobId = _id;
            EstimateBuilder.ApplicationBuilder.takeOffId = null;
            EstimateBuilder.ApplicationBuilder.takeOffGroup = null;
            loadTakeOffJobMDI(EstimateBuilder.ApplicationBuilder.takeOffJobId);

        }

        void TakeOffGroup_Click(object sender, EventArgs e)
        {
            string _id = lstGroup.FocusedItem.Text;
            
            EstimateBuilder.ApplicationBuilder.takeOffGroup = _id;


            loadTakeOffGroupMDI(EstimateBuilder.ApplicationBuilder.takeOffGroup, EstimateBuilder.ApplicationBuilder.takeOffJobId, EstimateBuilder.ApplicationBuilder.takeOffId);
        }
        private void QuantityDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstQuantityDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.quantityId = _id;
            EstimateBuilder.ApplicationBuilder.quantityJobId = null;
            loadQuantityMDI(EstimateBuilder.ApplicationBuilder.quantityId);
        }
        private void QuantityJob_Click(object sender, System.EventArgs e)
        {
            string _id = lstQuantityJob.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.quantityJobId = _id;
            EstimateBuilder.ApplicationBuilder.quantityId = null;
            loadQuantityJobMDI(EstimateBuilder.ApplicationBuilder.quantityJobId);

        }
        private void ExpressionDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstExpressionDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.expressionId = _id;
            loadExpressionMDI(EstimateBuilder.ApplicationBuilder.expressionId);

        }
        private void ContactDivision_Click(object sender, System.EventArgs e)
        {
            string _id = lstContactDivision.FocusedItem.Text;
            EstimateBuilder.ApplicationBuilder.contactId = _id;
            loadContactMDI(EstimateBuilder.ApplicationBuilder.contactId);
        }
        #endregion

        public override void Refresh()
        {
            this.loadDLL();
        }
        public void minimizeChild()
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
        }

        #region Load Entry Form
        private void CreateNewContact()
        {
            EstimateBuilder.Contact form = new Contact();
            form.Location.Offset(25, 25);
            form.CreateContact();
        }
        private void CreateNewAssembly()
        {
            EstimateBuilder.Assembly form = new Assembly();
            form.Location.Offset(25, 25);
            form.CreateAssembly();


        }
        private void CreateNewTakeOff()
        {
            EstimateBuilder.TakeOff form = new TakeOff();
            form.Location.Offset(25, 25);
            form.CreateTakeOff();
        }
        private void CreateNewExpression()
        {
            EstimateBuilder.Expression form = new Expression();
            form.Location.Offset(25, 25);
            form.CreateExpression();
        }
        private void CreateNewQuantity()
        {
            EstimateBuilder.Quantity form = new Quantity();
            form.Location.Offset(0, 25);
            form.CreateQuantity();
        }
        private void CreateNewCostAmount()
        {
            EstimateBuilder.CostAmount form = new CostAmount();
            form.Location.Offset(0, 25);
            form.CreateCostAmount();
        }
        private void CreateNewCostItem()
        {
            EstimateBuilder.CostItem form = new CostItem();
            form.Location.Offset(0, 25);
            form.CreateCostItem();
        }
        private void CreateNewValidationUser()
        {
            EstimateBuilder.ValidationUser form = new ValidationUser();
            form.Location.Offset(0, 25);
            form.CreateValidationUser();
        }
        private void CreateNewValidationSystem()
        {
            EstimateBuilder.ValidationSystem form = new ValidationSystem();
            form.Location.Offset(0, 25);
            form.CreateValidationSystem();
        }
        private void CreateNewJob()
        {
            EstimateBuilder.Job form = new Job();
            form.Location.Offset(0, 25);
            form.CreateJob();

        }
        #endregion
        #region Load MDI

        private void loadAssemblyMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenAssemblyMode == OpenAssembly.Off)
            {
                newAssemblyChild = new AssemblyMDI();
                // newAssemblyChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newAssemblyChild.Init();
                newAssemblyChild.MdiParent = this;
                newAssemblyChild.createAssemblyMDI(_selected);

            }
            else
            {
                //  newAssemblyChild.Dock = System.Windows.Forms.DockStyle.None;
                newAssemblyChild.Refresh();
                newAssemblyChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                newAssemblyChild.BringToFront();
            }
        }

        private void loadContactMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenContactMode == OpenContact.Off)
            {
                newContactChild = new ContactMDI();
                //  newContactChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newContactChild.Init();
                newContactChild.MdiParent = this;
                newContactChild.createContactMDI(_selected);

            }
            else
            {
                // newContactChild.Dock = System.Windows.Forms.DockStyle.None;
                newContactChild.Refresh();
                newContactChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                newContactChild.BringToFront();
                //newContactChild.Location = new System.Drawing.Point(60, 50);
            }
        }
        private void loadEstimateMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenEstimateMode == OpenEstimate.Off)
            {
                newEstimateChild = new EstimateMDI();
                newEstimateChild.Init();
                newEstimateChild.MdiParent = this;
                //  newEstimateChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newEstimateChild.createEstimatetMDI(_selected);
                EstimateBuilder.Builder.progressEstimate.Increment(-300);

            }
            else
            {

                newEstimateChild.Refresh();
                newEstimateChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //   newEstimateChild.Dock = System.Windows.Forms.DockStyle.None;
                newEstimateChild.BringToFront();
                EstimateBuilder.Builder.progressEstimate.Increment(-300);

            }
        }

        private void loadCostAmountMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenCostAmountMode == OpenCostAmount.Off)
            {
                newCostAmountChild = new CostAmountMDI();
                newCostAmountChild.Init();
                newCostAmountChild.MdiParent = this;
                // newCostAmountChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newCostAmountChild.createCostAmountMDI(_selected);
            }
            else
            {
                newCostAmountChild.Refresh();
                newCostAmountChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newCostAmountChild.Dock = System.Windows.Forms.DockStyle.None;
                newCostAmountChild.BringToFront();
            }
        }
        private void loadCostItemMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenCostItemMode == OpenCostItem.Off)
            {
                newCostItemChild = new CostItemMDI();
                newCostItemChild.Init();
                newCostItemChild.MdiParent = this;
                //  newCostItemChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newCostItemChild.createCostItemMDI(_selected);
            }
            else
            {
                newCostItemChild.Refresh();
                newCostItemChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newCostItemChild.Dock = System.Windows.Forms.DockStyle.None;
                newCostItemChild.BringToFront();
            }

        }
        private void loadJobMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenJobMode == OpenJob.Off)
            {
                newJobChild = new JobMDI();
                newJobChild.Init();
                newJobChild.MdiParent = this;
                //  newJobChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newJobChild.createJobMDI(_selected);
            }
            else
            {
                newJobChild.Refresh();
                newJobChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newJobChild.Dock = System.Windows.Forms.DockStyle.None;
                newJobChild.BringToFront();
            }
        }
        private void loadExpressionMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenExpressionMode == OpenExpression.Off)
            {
                newExpressionChild = new ExpressionMDI();
                newExpressionChild.Init();
                newExpressionChild.MdiParent = this;
                //  newExpressionChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newExpressionChild.createExpressionMDI(_selected);
            }
            else
            {
                newExpressionChild.Refresh();
                newExpressionChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //  newExpressionChild.Dock = System.Windows.Forms.DockStyle.None;
                newExpressionChild.BringToFront();
            }
        }
        private void loadQuantityMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenQuantityMode == OpenQuantity.Off)
            {
                newQuantityChild = new QuantityMDI();
                newQuantityChild.Init();
                newQuantityChild.MdiParent = this;
                // newQuantityChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newQuantityChild.createQuantityMDI(_selected);
            }
            else
            {
                newQuantityChild.Refresh();
                newQuantityChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newQuantityChild.Dock = System.Windows.Forms.DockStyle.None;
                newQuantityChild.BringToFront();
            }
        }
        private void loadQuantityJobMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenQuantityMode == OpenQuantity.Off)
            {
                newQuantityChild = new QuantityMDI();
                newQuantityChild.Init();
                newQuantityChild.MdiParent = this;
                //newQuantityChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newQuantityChild.createQuantityJobMDI(_selected);
            }
            else
            {
                newQuantityChild.Refresh();
                newQuantityChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //newQuantityChild.Dock = System.Windows.Forms.DockStyle.None;
                newQuantityChild.BringToFront();
            }
        }
        private void loadTakeOffMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenTakeOffMode == OpenTakeOff.Off)
            {
                newTakeOffChild = new TakeoffMDI();
                newTakeOffChild.Init();
                newTakeOffChild.MdiParent = this;
                // newTakeOffChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newTakeOffChild.createTakeOffMDI(_selected);

            }
            else
            {
                newTakeOffChild.Refresh();
                newTakeOffChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //newTakeOffChild.Dock = System.Windows.Forms.DockStyle.None;
                newTakeOffChild.BringToFront();
            }

        }
        private void loadTakeOffJobMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenTakeOffMode == OpenTakeOff.Off)
            {
                newTakeOffChild = new TakeoffMDI();
                newTakeOffChild.Init();
                newTakeOffChild.MdiParent = this;
                // newTakeOffChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newTakeOffChild.createTakeOffJobMDI(_selected);

            }
            else
            {
                newTakeOffChild.Refresh();
                newTakeOffChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newTakeOffChild.Dock = System.Windows.Forms.DockStyle.None;
                newTakeOffChild.BringToFront();
            }

        }

        private void loadTakeOffGroupMDI(string _selected, string _job, string _division)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenTakeOffMode == OpenTakeOff.Off)
            {
                newTakeOffChild = new TakeoffMDI();
                newTakeOffChild.Init();
                newTakeOffChild.MdiParent = this;
                // newTakeOffChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newTakeOffChild.createTakeOffGroupMDI(_selected, _job,  _division);

            }
            else
            {
                newTakeOffChild.Refresh();
                newTakeOffChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newTakeOffChild.Dock = System.Windows.Forms.DockStyle.None;
                newTakeOffChild.BringToFront();
            }

        }
        private void loadValidationSystemMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenValidationSystemMode == OpenValidationSystem.Off)
            {
                newValidationSystemChild = new ValidationSystemMDI();
                newValidationSystemChild.Init();
                newValidationSystemChild.MdiParent = this;
                // newValidationSystemChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newValidationSystemChild.createValidationSystemMDI(_selected);
            }
            else
            {
                newValidationSystemChild.Refresh();
                newValidationSystemChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                //newValidationSystemChild.Dock = System.Windows.Forms.DockStyle.None;
                newValidationSystemChild.BringToFront();
            }
        }
        private void loadValidationUserMDI(string _selected)
        {
            if (EstimateBuilder.ApplicationBuilder.OpenValidationUserMode == OpenValidationUser.Off)
            {
                newValidationUserChild = new EstimateBuilder.ValidationUserMDI();
                newValidationUserChild.Init();
                newValidationUserChild.MdiParent = this;
                //newValidationUserChild.Dock = System.Windows.Forms.DockStyle.Fill;
                newValidationUserChild.createValidationUserMDI(_selected);
            }
            else
            {
                newValidationUserChild.Refresh();
                newValidationUserChild.WindowState = System.Windows.Forms.FormWindowState.Normal;
                // newValidationUserChild.Dock = System.Windows.Forms.DockStyle.None;
                newValidationUserChild.BringToFront();
            }
        }


        #endregion
        #region Command
        private void uipPanel_Click(object sender, Janus.Windows.UI.Dock.PanelActionCancelEventArgs e)
        {

            if (e.Panel.Name == "uipContact")
            {
                loadContactMDI("All");

            }
            else if (e.Panel.Name == "uipTakeOff")
            {
                loadTakeOffMDI("All");

            }
            else if (e.Panel.Name == "uipExpression")
            {
                loadExpressionMDI("All");

            }
            else if (e.Panel.Name == "uipQuantity")
            {
                loadQuantityMDI("All");

            }
            else if (e.Panel.Name == "uipAssembly")
            {
                loadAssemblyMDI("All");

            }
            else if (e.Panel.Name == "uipCostAmount")
            {
                loadCostAmountMDI("All");

            }
            else if (e.Panel.Name == "uipCostItem")
            {
                loadCostItemMDI("All");

            }
            else if (e.Panel.Name == "uipEstimate")
            {
                loadEstimateMDI("All");

            }
            else if (e.Panel.Name == "uipValidationUser")
            {
                loadValidationUserMDI("All");

            }
            else if (e.Panel.Name == "uipValidationSystem")
            {
                loadValidationSystemMDI("All");

            }
            else if (e.Panel.Name == "uipJob")
            {
                loadJobMDI("All");

            }
        }
        private void uiCommandBar2_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (e.Command.Key == "cmdAssembly")
            {
                CreateNewAssembly();
            }
            else if (e.Command.Key == "cmdTakeOff")
            {
                CreateNewTakeOff();
            }
            else if (e.Command.Key == "cmdExpression")
            {
                CreateNewExpression();
            }
            else if (e.Command.Key == "cmdQuantity")
            {
                CreateNewQuantity();
            }
            else if (e.Command.Key == "cmdCostAmount")
            {
                CreateNewCostAmount();
            }
            else if (e.Command.Key == "CmdCostItem")
            {
                CreateNewCostItem();
            }
            else if (e.Command.Key == "cmdValidationUser")
            {
                CreateNewValidationUser();
            }
            else if (e.Command.Key == "cmdValidationSystem")
            {
                CreateNewValidationSystem();
            }
            else if (e.Command.Key == "cmdContact")
            {
                CreateNewContact();
            }
            else if (e.Command.Key == "cmdJob")
            {
                CreateNewJob();
            }
            else if (e.Command.Key == "cmdExit")
            {
                this.Close();
            }

        }
        private void uiCommandBar1_CommandClick(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (e.Command.Key == "cmdAssembly")
            {
                CreateNewAssembly();
            }
            else if (e.Command.Key == "cmdTakeOff")
            {
                CreateNewTakeOff();
            }
            else if (e.Command.Key == "cmdExpression")
            {
                CreateNewExpression();
            }
            else if (e.Command.Key == "cmdQuantity")
            {
                CreateNewQuantity();
            }
            else if (e.Command.Key == "cmdCostAmount")
            {
                CreateNewCostAmount();
            }
            else if (e.Command.Key == "CmdCostItem")
            {
                CreateNewCostItem();
            }
            else if (e.Command.Key == "cmdValidationUser")
            {
                CreateNewValidationUser();
            }
            else if (e.Command.Key == "cmdValidationSystem")
            {
                CreateNewValidationSystem();
            }
            else if (e.Command.Key == "cmdContact")
            {
                CreateNewContact();
            }

            else if (e.Command.Key == "cmdJob")
            {
                CreateNewJob();
            }
            else if (e.Command.Key == "cmdExit")
            {
                this.Close();
            }

        }
        #endregion
        #endregion





    }
}
