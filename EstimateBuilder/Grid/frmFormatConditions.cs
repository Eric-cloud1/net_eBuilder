/* L:1 */
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder
{
    public class frmFormatConditions : System.Windows.Forms.Form
    {

        #region '" Windows Form Designer generated code "'

        public frmFormatConditions() : base()
        {
   
            InitializeComponent();
  
        }
 
        protected override void Dispose(bool disposing)
        {
         
            if (disposing)
            {
        
                if (!((components == null)))
                {
         
                    components.Dispose();
                }
            }
    
            base.Dispose(disposing);
        }

 
        private System.ComponentModel.IContainer components;

        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIGroupBox UiGroupBox1;
        /* L:34 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBar ExplorerBar1;
        /* L:35 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.UI.Tab.UITab UiTab1;
        /* L:36 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.ImageList ImageList1;
        /* L:37 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBar ExplorerBar2;
        /* L:38 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBarContainerControl ExplorerBarContainerControl4;
        /* L:39 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIGroupBox UiGroupBox2;
        /* L:40 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.GridEX.EditControls.EditBox txtConditionName;
        /* L:41 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.GridEX.EditControls.EditBox txtValue2;
        /* L:42 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.GridEX.EditControls.EditBox txtValue1;
        /* L:43 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIComboBox cboFields;
        /* L:44 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblFields;
        /* L:45 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblValue1;
        /* L:46 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblValue2;
        /* L:47 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblName;
        /* L:48 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIComboBox cboCondition;
        /* L:49 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblCondition;
        /* L:50 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnMoveDown;
        /* L:51 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnMoveUp;
        /* L:52 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnDelete;
        /* L:53 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnNew;
        /* L:54 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnCancel;
        /* L:55 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIButton btnOK;
        /* L:56 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.GridEX.GridEX jsgConditions;
        /* L:57 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBarContainerControl excConditionName;
        /* L:58 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBarContainerControl excAppearance;
        /* L:59 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.ExplorerBar.ExplorerBarContainerControl excConditionCriteria;
        /* L:60 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UICheckBox chkStrikeout;
        /* L:61 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UICheckBox chkUnderline;
        /* L:62 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UICheckBox chkItalic;
        /* L:63 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UICheckBox chkBold;
        /* L:64 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIColorButton btnBackColor;
        /* L:65 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblBackColor;
        /* L:66 */
        internal /* TRANSINFO: WithEvents */ System.Windows.Forms.Label lblForeColor;
        /* L:67 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.EditControls.UIColorButton btnForeColor;
        /* L:68 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.UI.Tab.UITabPage fontPage;
        /* L:69 */
        internal /* TRANSINFO: WithEvents */ Janus.Windows.UI.Tab.UITabPage colorsPage;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
         
            this.components = new System.ComponentModel.Container();
         
            Janus.Windows.GridEX.GridEXLayout GridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
      
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmFormatView));
      
            Janus.Windows.ExplorerBar.ExplorerBarGroup ExplorerBarGroup1 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
       
            Janus.Windows.ExplorerBar.ExplorerBarGroup ExplorerBarGroup2 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
       
            Janus.Windows.ExplorerBar.ExplorerBarGroup ExplorerBarGroup3 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
           
            Janus.Windows.ExplorerBar.ExplorerBarGroup ExplorerBarGroup4 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
      
            this.ExplorerBarContainerControl4 = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
            
            this.jsgConditions = new Janus.Windows.GridEX.GridEX();
        
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
          
            this.excConditionName = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
            
            this.txtConditionName = new Janus.Windows.GridEX.EditControls.EditBox();
         
            this.lblName = new System.Windows.Forms.Label();
           
            this.excConditionCriteria = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
       
            this.lblFields = new System.Windows.Forms.Label();
          
            this.txtValue2 = new Janus.Windows.GridEX.EditControls.EditBox();
          
            this.txtValue1 = new Janus.Windows.GridEX.EditControls.EditBox();
       
            this.cboCondition = new Janus.Windows.EditControls.UIComboBox();
        
            this.lblCondition = new System.Windows.Forms.Label();
        
            this.lblValue1 = new System.Windows.Forms.Label();
        
            this.lblValue2 = new System.Windows.Forms.Label();
          
            this.cboFields = new Janus.Windows.EditControls.UIComboBox();
      
            this.excAppearance = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
        
            this.UiTab1 = new Janus.Windows.UI.Tab.UITab();
         
            this.fontPage = new Janus.Windows.UI.Tab.UITabPage();
    
            this.UiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
        
            this.chkStrikeout = new Janus.Windows.EditControls.UICheckBox();
           
            this.chkUnderline = new Janus.Windows.EditControls.UICheckBox();
         
            this.chkItalic = new Janus.Windows.EditControls.UICheckBox();
      
            this.chkBold = new Janus.Windows.EditControls.UICheckBox();
       
            this.colorsPage = new Janus.Windows.UI.Tab.UITabPage();
          
            this.lblBackColor = new System.Windows.Forms.Label();
          
            this.btnBackColor = new Janus.Windows.EditControls.UIColorButton();
      
            this.lblForeColor = new System.Windows.Forms.Label();
          
            this.btnForeColor = new Janus.Windows.EditControls.UIColorButton();
           
            this.UiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
         
            this.ExplorerBar2 = new Janus.Windows.ExplorerBar.ExplorerBar();
        
            this.ExplorerBar1 = new Janus.Windows.ExplorerBar.ExplorerBar();
           
            this.btnMoveDown = new Janus.Windows.EditControls.UIButton();
          
            this.btnMoveUp = new Janus.Windows.EditControls.UIButton();
           
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
        
            this.btnNew = new Janus.Windows.EditControls.UIButton();
        
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
     
            this.btnOK = new Janus.Windows.EditControls.UIButton();
           
            this.ExplorerBarContainerControl4.SuspendLayout();
        
            ((System.ComponentModel.ISupportInitialize)(this.jsgConditions)).BeginInit();
      
            this.excConditionName.SuspendLayout();
         
            this.excConditionCriteria.SuspendLayout();
            
            this.excAppearance.SuspendLayout();
         
            ((System.ComponentModel.ISupportInitialize)(this.UiTab1)).BeginInit();
      
            this.UiTab1.SuspendLayout();
        
            this.fontPage.SuspendLayout();
        
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox2)).BeginInit();
            
            this.UiGroupBox2.SuspendLayout();
        
            this.colorsPage.SuspendLayout();
    
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox1)).BeginInit();
           
            this.UiGroupBox1.SuspendLayout();
         
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar2)).BeginInit();
       
            this.ExplorerBar2.SuspendLayout();
         
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar1)).BeginInit();
        
            this.ExplorerBar1.SuspendLayout();
          
            this.SuspendLayout();

            this.ExplorerBarContainerControl4.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
       
            this.ExplorerBarContainerControl4.Controls.AddRange(new System.Windows.Forms.Control[] { this.jsgConditions });
        
            this.ExplorerBarContainerControl4.Location = new System.Drawing.Point(8, 27);
        
            this.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4";
         
            this.ExplorerBarContainerControl4.Size = new System.Drawing.Size(252, 289);
          
            this.ExplorerBarContainerControl4.TabIndex = 1;
          
    
            this.jsgConditions.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
      
            this.jsgConditions.ColumnAutoResize = true;
   
            GridEXLayout1.LayoutString = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""clmEnabled"">" + "<AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</Allo" + "wSort><ColumnType>CheckBox</ColumnType><EditType>CheckBox</EditType><Key>clmEnab" + @"led</Key><Position>0</Position><Width>39</Width></Column0><Column1 ID=""clmImage""" + "><AllowDrag>False</AllowDrag><AllowSize>False</AllowSize><Bound>False</Bound><Co" + "lumnType>Image</ColumnType><ImageIndex>5</ImageIndex><Key>clmImage</Key><Positio" +
 "n>1</Position><Selectable>False</Selectable><Width>28</Width></Column1><Column2 " + @"ID=""clmName""><Key>clmName</Key><Position>2</Position><Width>185</Width></Column2" + @"></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>";
      
            this.jsgConditions.DesignTimeLayout = GridEXLayout1;
      
            this.jsgConditions.Dock = System.Windows.Forms.DockStyle.Fill;
           
            this.jsgConditions.ExternalImageList = this.ImageList1;
           
            this.jsgConditions.GroupByBoxVisible = false;
         
            this.jsgConditions.Name = "jsgConditions";
         
            this.jsgConditions.Size = new System.Drawing.Size(252, 289);
         
            this.jsgConditions.TabIndex = 0;
       
            this.jsgConditions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
  
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
           
            this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
           
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
        
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;

            this.excConditionName.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtConditionName, this.lblName });
           
            this.excConditionName.Location = new System.Drawing.Point(8, 7);
          
            this.excConditionName.Name = "excConditionName";
           
            this.excConditionName.Size = new System.Drawing.Size(280, 27);
           
            this.excConditionName.TabIndex = 1;

            this.txtConditionName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);

            this.txtConditionName.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
       
            this.txtConditionName.Location = new System.Drawing.Point(104, 4);
       
            this.txtConditionName.Name = "txtConditionName";
     
            this.txtConditionName.Size = new System.Drawing.Size(170, 21);
       
            this.txtConditionName.TabIndex = 0;
      
            this.txtConditionName.Text = "EditBox1";
    
            this.txtConditionName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
    
            this.txtConditionName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;

            this.lblName.AutoSize = true;
  
            this.lblName.BackColor = System.Drawing.Color.Transparent;
   
            this.lblName.Location = new System.Drawing.Point(8, 8);
           
            this.lblName.Name = "lblName";
       
            this.lblName.Size = new System.Drawing.Size(86, 14);
      
            this.lblName.TabIndex = 4;
      
            this.lblName.Text = "Condition name:";
    
            this.excConditionCriteria.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblFields, this.txtValue2, this.txtValue1, this.cboCondition, this.lblCondition, this.lblValue1, this.lblValue2, this.cboFields });
    
            this.excConditionCriteria.Location = new System.Drawing.Point(8, 61);
            
            this.excConditionCriteria.Name = "excConditionCriteria";
     
            this.excConditionCriteria.Size = new System.Drawing.Size(280, 101);
          
            this.excConditionCriteria.TabIndex = 2;
       
            this.lblFields.AutoSize = true;
  
            this.lblFields.BackColor = System.Drawing.Color.Transparent;
   
            this.lblFields.Location = new System.Drawing.Point(8, 7);
        
            this.lblFields.Name = "lblFields";

            this.lblFields.Size = new System.Drawing.Size(37, 14);
        
            this.lblFields.TabIndex = 4;
         
            this.lblFields.Text = "Fields:";

            this.txtValue2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);

            this.txtValue2.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
 
            this.txtValue2.Location = new System.Drawing.Point(72, 76);
      
            this.txtValue2.Name = "txtValue2";
 
            this.txtValue2.Size = new System.Drawing.Size(200, 21);
     
            this.txtValue2.TabIndex = 3;
      
            this.txtValue2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
          
            this.txtValue2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
   
            this.txtValue1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
  
            this.txtValue1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
 
            this.txtValue1.Location = new System.Drawing.Point(72, 52);
    
            this.txtValue1.Name = "txtValue1";
    
            this.txtValue1.Size = new System.Drawing.Size(200, 21);

            this.txtValue1.TabIndex = 2;
   
            this.txtValue1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
        
            this.txtValue1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
          
            this.cboCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
           
            this.cboCondition.Location = new System.Drawing.Point(72, 28);
           
            this.cboCondition.Name = "cboCondition";
          
            this.cboCondition.Size = new System.Drawing.Size(200, 21);
           
            this.cboCondition.TabIndex = 1;
  
            this.cboCondition.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
       
            this.lblCondition.AutoSize = true;
       
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
          
            this.lblCondition.Location = new System.Drawing.Point(8, 32);
         
            this.lblCondition.Name = "lblCondition";
            
            this.lblCondition.Size = new System.Drawing.Size(55, 14);
         
            this.lblCondition.TabIndex = 4;
          
            this.lblCondition.Text = "Condition:";
  
            this.lblValue1.AutoSize = true;
   
            this.lblValue1.BackColor = System.Drawing.Color.Transparent;
         
            this.lblValue1.Location = new System.Drawing.Point(8, 56);
          
            this.lblValue1.Name = "lblValue1";
        
            this.lblValue1.Size = new System.Drawing.Size(45, 14);
     
            this.lblValue1.TabIndex = 4;
           
            this.lblValue1.Text = "Value 1:";
      
            this.lblValue2.AutoSize = true;

            this.lblValue2.BackColor = System.Drawing.Color.Transparent;
  
            this.lblValue2.Location = new System.Drawing.Point(8, 80);
  
            this.lblValue2.Name = "lblValue2";
 
            this.lblValue2.Size = new System.Drawing.Size(45, 14);
     
            this.lblValue2.TabIndex = 4;
        
            this.lblValue2.Text = "Value 2:";

            this.cboFields.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);

            this.cboFields.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;

            this.cboFields.Location = new System.Drawing.Point(72, 4);
 
            this.cboFields.Name = "cboFields";

            this.cboFields.Size = new System.Drawing.Size(200, 21);
    
            this.cboFields.TabIndex = 0;
  
            this.cboFields.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
 
            this.excAppearance.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);

            this.excAppearance.Controls.AddRange(new System.Windows.Forms.Control[] { this.UiTab1 });
       
            this.excAppearance.Location = new System.Drawing.Point(8, 189);
    
            this.excAppearance.Name = "excAppearance";
  
            this.excAppearance.Size = new System.Drawing.Size(280, 127);
     
            this.excAppearance.TabIndex = 3;
 
            this.UiTab1.BackColor = System.Drawing.Color.Transparent;
            /* L:310 */
            this.UiTab1.Controls.AddRange(new System.Windows.Forms.Control[] { this.fontPage, this.colorsPage });
            /* L:311 */
            this.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            /* L:312 */
            this.UiTab1.FocusOnClick = false;
            /* L:313 */
            this.UiTab1.ImageList = this.ImageList1;
            /* L:314 */
            this.UiTab1.Name = "UiTab1";
            /* L:315 */
            this.UiTab1.SelectedIndex = 0;
            /* L:316 */
            this.UiTab1.Size = new System.Drawing.Size(280, 127);
            /* L:317 */
            this.UiTab1.TabIndex = 0;
            /* L:318 */
            this.UiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] { this.fontPage, this.colorsPage });
            /* L:319 */
            this.UiTab1.TabsStateStyles.SelectedFormatStyle.FontBold = Janus.Windows.UI.TriState.True;
            /* L:323 */
            this.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            /* L:321 */
            // 
            /* L:322 */
            // fontPage
            /* L:323 */
            // 
            /* L:324 */
            this.fontPage.Controls.AddRange(new System.Windows.Forms.Control[] { this.UiGroupBox2 });
            /* L:325 */
            this.fontPage.ImageIndex = 0;
            /* L:326 */
            this.fontPage.Location = new System.Drawing.Point(1, 23);
            /* L:327 */
            this.fontPage.Name = "fontPage";
            /* L:328 */
            this.fontPage.Size = new System.Drawing.Size(278, 103);
            /* L:332 */
            this.fontPage.Text = "Font";
            /* L:330 */
            // 
            /* L:331 */
            // UiGroupBox2
            /* L:332 */
            // 
            /* L:333 */
            this.UiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            /* L:334 */
            this.UiGroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] { this.chkStrikeout, this.chkUnderline, this.chkItalic, this.chkBold });
            /* L:335 */
            this.UiGroupBox2.Location = new System.Drawing.Point(8, 8);
            /* L:336 */
            this.UiGroupBox2.Name = "UiGroupBox2";
            /* L:337 */
            this.UiGroupBox2.Size = new System.Drawing.Size(248, 40);
            /* L:338 */
            this.UiGroupBox2.Text = "Font Style";
            /* L:342 */
            this.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            /* L:340 */
            // 
            /* L:341 */
            // chkStrikeout
            /* L:342 */
            // 
            /* L:343 */
            this.chkStrikeout.BackColor = System.Drawing.Color.Transparent;
            /* L:344 */
            this.chkStrikeout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            /* L:345 */
            this.chkStrikeout.Location = new System.Drawing.Point(176, 16);
            /* L:346 */
            this.chkStrikeout.Name = "chkStrikeout";
            /* L:347 */
            this.chkStrikeout.Size = new System.Drawing.Size(64, 16);
            /* L:348 */
            this.chkStrikeout.TabIndex = 7;
            /* L:349 */
            this.chkStrikeout.Text = "Strikeout";
            /* L:353 */
            this.chkStrikeout.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:351 */
            // 
            /* L:352 */
            // chkUnderline
            /* L:353 */
            // 
            /* L:354 */
            this.chkUnderline.BackColor = System.Drawing.Color.Transparent;
            /* L:355 */
            this.chkUnderline.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            /* L:356 */
            this.chkUnderline.Location = new System.Drawing.Point(104, 16);
            /* L:357 */
            this.chkUnderline.Name = "chkUnderline";
            /* L:358 */
            this.chkUnderline.Size = new System.Drawing.Size(72, 16);
            /* L:359 */
            this.chkUnderline.TabIndex = 6;
            /* L:360 */
            this.chkUnderline.Text = "Underline";
            /* L:364 */
            this.chkUnderline.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:362 */
            // 
            /* L:363 */
            // chkItalic
            /* L:364 */
            // 
            /* L:365 */
            this.chkItalic.BackColor = System.Drawing.Color.Transparent;
            /* L:366 */
            this.chkItalic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            /* L:367 */
            this.chkItalic.Location = new System.Drawing.Point(56, 16);
            /* L:368 */
            this.chkItalic.Name = "chkItalic";
            /* L:369 */
            this.chkItalic.Size = new System.Drawing.Size(48, 16);
            /* L:370 */
            this.chkItalic.TabIndex = 5;
            /* L:371 */
            this.chkItalic.Text = "Italic";
            /* L:375 */
            this.chkItalic.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:373 */
            // 
            /* L:374 */
            // chkBold
            /* L:375 */
            // 
            /* L:376 */
            this.chkBold.BackColor = System.Drawing.Color.Transparent;
            /* L:377 */
            this.chkBold.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            /* L:378 */
            this.chkBold.Location = new System.Drawing.Point(8, 16);
            /* L:379 */
            this.chkBold.Name = "chkBold";
            /* L:380 */
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            /* L:381 */
            this.chkBold.TabIndex = 4;
            /* L:382 */
            this.chkBold.Text = "Bold";
            /* L:386 */
            this.chkBold.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:384 */
            // 
            /* L:385 */
            // colorsPage
            /* L:386 */
            // 
            /* L:387 */
            this.colorsPage.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblBackColor, this.btnBackColor, this.lblForeColor, this.btnForeColor });
            /* L:388 */
            this.colorsPage.ImageIndex = 3;
            /* L:389 */
            this.colorsPage.Location = new System.Drawing.Point(1, 23);
            /* L:390 */
            this.colorsPage.Name = "colorsPage";
            /* L:391 */
            this.colorsPage.Size = new System.Drawing.Size(278, 103);
            /* L:395 */
            this.colorsPage.Text = "Colors";
            /* L:393 */
            // 
            /* L:394 */
            // lblBackColor
            /* L:395 */
            // 
            /* L:396 */
            this.lblBackColor.AutoSize = true;
            /* L:397 */
            this.lblBackColor.Location = new System.Drawing.Point(8, 44);
            /* L:398 */
            this.lblBackColor.Name = "lblBackColor";
            /* L:399 */
            this.lblBackColor.Size = new System.Drawing.Size(67, 14);
            /* L:400 */
            this.lblBackColor.TabIndex = 1;
            /* L:407 */
            this.lblBackColor.Text = "Background:";
            /* L:402 */
            // 
            /* L:403 */
            // btnBackColor
            /* L:404 */
            // 
            /* L:405 */
            // 
            /* L:406 */
            // btnBackColor.ColorPicker
            /* L:407 */
            // 
            /* L:408 */
            this.btnBackColor.ColorPicker.AutomaticButtonText = "None";
            /* L:409 */
            this.btnBackColor.ColorPicker.AutomaticColor = System.Drawing.Color.Empty;
            /* L:410 */
            this.btnBackColor.ColorPicker.Size = new System.Drawing.Size(100, 100);
            /* L:411 */
            this.btnBackColor.ColorPicker.TabIndex = 0;
            /* L:412 */
            this.btnBackColor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            /* L:413 */
            this.btnBackColor.ImageReplaceableColor = System.Drawing.Color.Empty;
            /* L:414 */
            this.btnBackColor.ImageSize = new System.Drawing.Size(25, 15);
            /* L:415 */
            this.btnBackColor.Location = new System.Drawing.Point(88, 40);
            /* L:416 */
            this.btnBackColor.Name = "btnBackColor";
            /* L:417 */
            this.btnBackColor.Size = new System.Drawing.Size(128, 23);
            /* L:418 */
            this.btnBackColor.TabIndex = 0;
            /* L:419 */
            this.btnBackColor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:423 */
            this.btnBackColor.WordWrap = false;
            /* L:421 */
            // 
            /* L:422 */
            // lblForeColor
            /* L:423 */
            // 
            /* L:424 */
            this.lblForeColor.AutoSize = true;
            /* L:425 */
            this.lblForeColor.Location = new System.Drawing.Point(8, 12);
            /* L:426 */
            this.lblForeColor.Name = "lblForeColor";
            /* L:427 */
            this.lblForeColor.Size = new System.Drawing.Size(30, 14);
            /* L:428 */
            this.lblForeColor.TabIndex = 1;
            /* L:435 */
            this.lblForeColor.Text = "Text:";
            /* L:430 */
            // 
            /* L:431 */
            // btnForeColor
            /* L:432 */
            // 
            /* L:433 */
            // 
            /* L:434 */
            // btnForeColor.ColorPicker
            /* L:435 */
            // 
            /* L:436 */
            this.btnForeColor.ColorPicker.AutomaticButtonText = "None";
            /* L:437 */
            this.btnForeColor.ColorPicker.AutomaticColor = System.Drawing.Color.Empty;
            /* L:438 */
            this.btnForeColor.ColorPicker.Size = new System.Drawing.Size(100, 100);
            /* L:439 */
            this.btnForeColor.ColorPicker.TabIndex = 0;
            /* L:440 */
            this.btnForeColor.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near;
            /* L:441 */
            this.btnForeColor.ImageReplaceableColor = System.Drawing.Color.Empty;
            /* L:442 */
            this.btnForeColor.ImageSize = new System.Drawing.Size(25, 15);
            /* L:443 */
            this.btnForeColor.Location = new System.Drawing.Point(88, 8);
            /* L:444 */
            this.btnForeColor.Name = "btnForeColor";
            /* L:445 */
            this.btnForeColor.Size = new System.Drawing.Size(128, 23);
            /* L:446 */
            this.btnForeColor.TabIndex = 0;
            /* L:447 */
            this.btnForeColor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:451 */
            this.btnForeColor.WordWrap = false;
            /* L:449 */
            // 
            /* L:450 */
            // UiGroupBox1
            /* L:451 */
            // 
            /* L:452 */
            this.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel;
            /* L:453 */
            this.UiGroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] { this.ExplorerBar2, this.ExplorerBar1, this.btnMoveDown, this.btnMoveUp, this.btnDelete, this.btnNew, this.btnCancel, this.btnOK });
            /* L:454 */
            this.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            /* L:455 */
            this.UiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            /* L:456 */
            this.UiGroupBox1.Name = "UiGroupBox1";
            /* L:457 */
            this.UiGroupBox1.Size = new System.Drawing.Size(576, 395);
            /* L:461 */
            this.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            /* L:459 */
            // 
            /* L:460 */
            // ExplorerBar2
            /* L:461 */
            // 
            /* L:463 */
            this.ExplorerBar2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
            /* L:464 */
            this.ExplorerBar2.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items;
            /* L:465 */
            this.ExplorerBar2.Controls.AddRange(new System.Windows.Forms.Control[] { this.ExplorerBarContainerControl4 });
            /* L:466 */
            ExplorerBarGroup1.Container = true;
            /* L:467 */
            ExplorerBarGroup1.ContainerControl = this.ExplorerBarContainerControl4;
            /* L:468 */
            ExplorerBarGroup1.ContainerHeight = 290;
            /* L:469 */
            ExplorerBarGroup1.Expandable = false;
            /* L:470 */
            ExplorerBarGroup1.Key = "Group1";
            /* L:471 */
            ExplorerBarGroup1.SpecialGroup = true;
            /* L:472 */
            ExplorerBarGroup1.Text = "Format Conditions";
            /* L:473 */
            this.ExplorerBar2.Groups.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarGroup[] { ExplorerBarGroup1 });
            /* L:474 */
            this.ExplorerBar2.GroupSeparation = 4;
            /* L:475 */
            this.ExplorerBar2.Location = new System.Drawing.Point(4, 32);
            /* L:476 */
            this.ExplorerBar2.Name = "ExplorerBar2";
            /* L:477 */
            this.ExplorerBar2.Size = new System.Drawing.Size(268, 324);
            /* L:478 */
            this.ExplorerBar2.TabIndex = 8;
            /* L:479 */
            this.ExplorerBar2.Text = "ExplorerBar2";
            /* L:483 */
            this.ExplorerBar2.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003;
            /* L:481 */
            // 
            /* L:482 */
            // ExplorerBar1
            /* L:483 */
            // 
            /* L:486 */
            this.ExplorerBar1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
            /* L:487 */
            this.ExplorerBar1.BackgroundFormatStyle.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items;
            /* L:488 */
            this.ExplorerBar1.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items;
            /* L:489 */
            this.ExplorerBar1.Controls.AddRange(new System.Windows.Forms.Control[] { this.excConditionName, this.excConditionCriteria, this.excAppearance });
            /* L:490 */
            ExplorerBarGroup2.Container = true;
            /* L:491 */
            ExplorerBarGroup2.ContainerControl = this.excConditionName;
            /* L:492 */
            ExplorerBarGroup2.ContainerHeight = 28;
            /* L:493 */
            ExplorerBarGroup2.Key = "Group1";
            /* L:494 */
            ExplorerBarGroup2.ShowGroupCaption = false;
            /* L:495 */
            ExplorerBarGroup2.Text = "New Group";
            /* L:496 */
            ExplorerBarGroup3.Container = true;
            /* L:497 */
            ExplorerBarGroup3.ContainerControl = this.excConditionCriteria;
            /* L:498 */
            ExplorerBarGroup3.ContainerHeight = 102;
            /* L:499 */
            ExplorerBarGroup3.Expandable = false;
            /* L:500 */
            ExplorerBarGroup3.ImageIndex = 2;
            /* L:501 */
            ExplorerBarGroup3.Key = "Group2";
            /* L:502 */
            ExplorerBarGroup3.Text = "Condition";
            /* L:503 */
            ExplorerBarGroup4.Container = true;
            /* L:504 */
            ExplorerBarGroup4.ContainerControl = this.excAppearance;
            /* L:505 */
            ExplorerBarGroup4.ContainerHeight = 128;
            /* L:506 */
            ExplorerBarGroup4.Expandable = false;
            /* L:507 */
            ExplorerBarGroup4.ImageIndex = 1;
            /* L:508 */
            ExplorerBarGroup4.Key = "Group3";
            /* L:509 */
            ExplorerBarGroup4.Text = "Appearence";
            /* L:510 */
            this.ExplorerBar1.Groups.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarGroup[] { ExplorerBarGroup2, ExplorerBarGroup3, ExplorerBarGroup4 });
            /* L:511 */
            this.ExplorerBar1.GroupSeparation = 6;
            /* L:512 */
            this.ExplorerBar1.ImageList = this.ImageList1;
            /* L:513 */
            this.ExplorerBar1.Location = new System.Drawing.Point(276, 32);
            /* L:514 */
            this.ExplorerBar1.Name = "ExplorerBar1";
            /* L:515 */
            this.ExplorerBar1.Size = new System.Drawing.Size(296, 324);
            /* L:516 */
            this.ExplorerBar1.TabIndex = 7;
            /* L:517 */
            this.ExplorerBar1.Text = "ExplorerBar1";
            /* L:521 */
            this.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003;
            /* L:519 */
            // 
            /* L:520 */
            // btnMoveDown
            /* L:521 */
            // 
            /* L:522 */
            this.btnMoveDown.Enabled = false;
            /* L:523 */
            this.btnMoveDown.Location = new System.Drawing.Point(256, 4);
            /* L:524 */
            this.btnMoveDown.Name = "btnMoveDown";
            /* L:525 */
            this.btnMoveDown.Size = new System.Drawing.Size(80, 24);
            /* L:526 */
            this.btnMoveDown.TabIndex = 6;
            /* L:527 */
            this.btnMoveDown.Text = "Move Down";
            /* L:531 */
            this.btnMoveDown.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:529 */
            // 
            /* L:530 */
            // btnMoveUp
            /* L:531 */
            // 
            /* L:532 */
            this.btnMoveUp.Enabled = false;
            /* L:533 */
            this.btnMoveUp.Location = new System.Drawing.Point(172, 4);
            /* L:534 */
            this.btnMoveUp.Name = "btnMoveUp";
            /* L:535 */
            this.btnMoveUp.Size = new System.Drawing.Size(80, 24);
            /* L:536 */
            this.btnMoveUp.TabIndex = 5;
            /* L:537 */
            this.btnMoveUp.Text = "Move Up";
            /* L:541 */
            this.btnMoveUp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:539 */
            // 
            /* L:540 */
            // btnDelete
            /* L:541 */
            // 
            /* L:542 */
            this.btnDelete.Location = new System.Drawing.Point(88, 4);
            /* L:543 */
            this.btnDelete.Name = "btnDelete";
            /* L:544 */
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            /* L:545 */
            this.btnDelete.TabIndex = 3;
            /* L:546 */
            this.btnDelete.Text = "Delete";
            /* L:550 */
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:548 */
            // 
            /* L:549 */
            // btnNew
            /* L:550 */
            // 
            /* L:551 */
            this.btnNew.Location = new System.Drawing.Point(4, 4);
            /* L:552 */
            this.btnNew.Name = "btnNew";
            /* L:553 */
            this.btnNew.Size = new System.Drawing.Size(80, 24);
            /* L:554 */
            this.btnNew.TabIndex = 2;
            /* L:555 */
            this.btnNew.Text = "New";
            /* L:559 */
            this.btnNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:557 */
            // 
            /* L:558 */
            // btnCancel
            /* L:559 */
            // 
            /* L:560 */
            this.btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            /* L:561 */
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            /* L:562 */
            this.btnCancel.Location = new System.Drawing.Point(492, 364);
            /* L:563 */
            this.btnCancel.Name = "btnCancel";
            /* L:564 */
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            /* L:565 */
            this.btnCancel.TabIndex = 10;
            /* L:566 */
            this.btnCancel.Text = "Cancel";
            /* L:570 */
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:568 */
            // 
            /* L:569 */
            // btnOK
            /* L:570 */
            // 
            /* L:571 */
            this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            /* L:572 */
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            /* L:573 */
            this.btnOK.Location = new System.Drawing.Point(404, 364);
            /* L:574 */
            this.btnOK.Name = "btnOK";
            /* L:575 */
            this.btnOK.Size = new System.Drawing.Size(80, 24);
            /* L:576 */
            this.btnOK.TabIndex = 9;
            /* L:577 */
            this.btnOK.Text = "OK";
            /* L:581 */
            this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            /* L:579 */
            // 
            /* L:580 */
            // frmFormatView
            /* L:581 */
            // 
            /* L:582 */
            this.AutoScaleDimensions = new System.Drawing.Size(5, 14);
            /* L:583 */
            this.ClientSize = new System.Drawing.Size(576, 395);
            /* L:584 */
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.UiGroupBox1 });
            /* L:585 */
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            /* L:586 */
            this.MaximizeBox = false;
            /* L:587 */
            this.MinimizeBox = false;
            /* L:588 */
            this.Name = "frmFormatView";
            /* L:589 */
            this.Text = "Format View";
            /* L:590 */
            this.ExplorerBarContainerControl4.ResumeLayout(false);
            /* L:591 */
            ((System.ComponentModel.ISupportInitialize)(this.jsgConditions)).EndInit();
            /* L:592 */
            this.excConditionName.ResumeLayout(false);
            /* L:593 */
            this.excConditionCriteria.ResumeLayout(false);
            /* L:594 */
            this.excAppearance.ResumeLayout(false);
            /* L:595 */
            ((System.ComponentModel.ISupportInitialize)(this.UiTab1)).EndInit();
            /* L:596 */
            this.UiTab1.ResumeLayout(false);
            /* L:597 */
            this.fontPage.ResumeLayout(false);
            /* L:598 */
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox2)).EndInit();
            /* L:599 */
            this.UiGroupBox2.ResumeLayout(false);
            /* L:600 */
            this.colorsPage.ResumeLayout(false);
            /* L:601 */
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox1)).EndInit();
            /* L:602 */
            this.UiGroupBox1.ResumeLayout(false);
            /* L:603 */
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar2)).EndInit();
            /* L:604 */
            this.ExplorerBar2.ResumeLayout(false);
            /* L:605 */
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar1)).EndInit();
            /* L:606 */
            this.ExplorerBar1.ResumeLayout(false);
            /* L:608 */
            this.ResumeLayout(false);
            /* L:608 */
            // events handled by cboCondition_SelectedIndexChanged
            /* TRANSWARNING: check EventHandler assignment */
            cboCondition.SelectedIndexChanged += new System.EventHandler(cboCondition_SelectedIndexChanged);
            // events handled by btnMoveUp_Click
            /* TRANSWARNING: check EventHandler assignment */
            btnMoveUp.Click += new System.EventHandler(btnMoveUp_Click);
            // events handled by btnMoveDown_Click
            /* TRANSWARNING: check EventHandler assignment */
            btnMoveDown.Click += new System.EventHandler(btnMoveDown_Click);
            // events handled by btnNew_Click
            /* TRANSWARNING: check EventHandler assignment */
            btnNew.Click += new System.EventHandler(btnNew_Click);
            // events handled by btnDelete_Click
            /* TRANSWARNING: check EventHandler assignment */
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // events handled by txtConditionName_TextChanged
            /* TRANSWARNING: check EventHandler assignment */
            txtConditionName.TextChanged += new System.EventHandler(txtConditionName_TextChanged);
            // events handled by jsgConditions_UpdatingRecord
            /* TRANSWARNING: check EventHandler assignment */
            jsgConditions.UpdatingRecord += new System.ComponentModel.CancelEventHandler(jsgConditions_UpdatingRecord);
            // events handled by jsgConditions_CurrentCellChanging
            /* TRANSWARNING: check EventHandler assignment */
            jsgConditions.CurrentCellChanging += new Janus.Windows.GridEX.CurrentCellChangingEventHandler(jsgConditions_CurrentCellChanging);
            // events handled by jsgConditions_SelectionChanged
            /* TRANSWARNING: check EventHandler assignment */
            jsgConditions.SelectionChanged += new System.EventHandler(jsgConditions_SelectionChanged);
            // events handled by jsgConditions_FormattingRow
            /* TRANSWARNING: check EventHandler assignment */
            jsgConditions.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(jsgConditions_FormattingRow);
            // events handled by FormatsForm_Closing
            /* TRANSWARNING: check EventHandler assignment */
            base.Closing += new System.ComponentModel.CancelEventHandler(FormatsForm_Closing);
        }

        /* L:610 */
        #endregion
        /* L:612 */
        /* L:613 */
        private bool mTwoValues;
        /* L:614 */
        private Janus.Windows.GridEX.GridEX mGridEX;
        /* L:615 */
        private System.Collections.ArrayList tempConditions;
        /* L:616 */
        private GridEXFormatCondition mActiveCondition;
        private GridEXFormatCondition ActiveCondition
        {
            get
            {
                /* L:619 */
                return mActiveCondition;
            }
            set
            {
                /* L:628 */
                if (!(value == mActiveCondition))
                {
                    /* L:625 */
                    if (!(mActiveCondition == null))
                    {
                        /* L:624 */
                        this.GetConditionValues();
                    }
                    /* L:626 */
                    mActiveCondition = value;
                    /* L:627 */
                    OnActiveConditionChanged();
                }
            }
        }
        /* L:631 */
        private void PopulateCombos()
        {
            /* L:633 */
            cboFields.DataSource = mGridEX.RootTable.Columns;
            /* L:635 */
            cboFields.DisplayMember = "DataMember";
            /* L:635 */
            /* L:636 */
            Array values = System.Enum.GetValues(Janus.Windows.GridEX.ConditionOperator.EndsWith.GetType());
            /* L:637 */
            Object value = null;
            /* L:641 */
            foreach (object transTemp0 in values)
            {
                value = transTemp0; /* TRANSWARNING: check temp variable in foreach */
                /* L:639 */
                cboCondition.Items.Add(value);
            }
            /* L:641 */
            /* L:642 */
            this.chkBold.IndeterminatedValue = Janus.Windows.GridEX.TriState.Empty;
            /* L:643 */
            this.chkItalic.IndeterminatedValue = Janus.Windows.GridEX.TriState.Empty;
            /* L:644 */
            this.chkStrikeout.IndeterminatedValue = Janus.Windows.GridEX.TriState.Empty;
            /* L:646 */
            this.chkUnderline.IndeterminatedValue = Janus.Windows.GridEX.TriState.Empty;
            /* L:646 */
            /* L:647 */
            this.chkBold.CheckedValue = Janus.Windows.GridEX.TriState.True;
            /* L:648 */
            this.chkItalic.CheckedValue = Janus.Windows.GridEX.TriState.True;
            /* L:649 */
            this.chkStrikeout.CheckedValue = Janus.Windows.GridEX.TriState.True;
            /* L:651 */
            this.chkUnderline.CheckedValue = Janus.Windows.GridEX.TriState.True;
            /* L:651 */
            /* L:652 */
            this.chkBold.UncheckedValue = Janus.Windows.GridEX.TriState.False;
            /* L:653 */
            this.chkItalic.UncheckedValue = Janus.Windows.GridEX.TriState.False;
            /* L:654 */
            this.chkStrikeout.UncheckedValue = Janus.Windows.GridEX.TriState.False;
            /* L:656 */
            this.chkUnderline.UncheckedValue = Janus.Windows.GridEX.TriState.False;
            /* L:656 */
        }

        /* L:658 */
        public void ShowDialog(Janus.Windows.GridEX.GridEX gridEx, System.Windows.Forms.Form parentForm)
        {
            /* L:660 */
            mGridEX = gridEx;
            /* L:662 */
            this.PopulateCombos();
            /* L:662 */
            /* L:664 */
            tempConditions = new System.Collections.ArrayList();
            /* L:664 */
            /* L:665 */
            GridEXFormatCondition cond = null;
            /* L:670 */
            foreach (Janus.Windows.GridEX.GridEXFormatCondition transTemp1 in this.mGridEX.RootTable.FormatConditions)
            {
                cond = transTemp1; /* TRANSWARNING: check temp variable in foreach */
                /* L:667 */
                GridEXFormatCondition cloneCond = cond.Clone();
                /* L:668 */
                tempConditions.Add(cloneCond);
            }
            /* L:670 */
            /* L:671 */
            this.jsgConditions.RootTable.Columns["clmName"].DataMember = "Key";
            /* L:672 */
            this.jsgConditions.RootTable.Columns["clmEnabled"].DataMember = "Enabled";
            /* L:673 */
            this.jsgConditions.SetDataBinding(tempConditions, "");
            /* L:674 */
            OnActiveConditionChanged();
            /* L:675 */
            this.ShowDialog(parentForm);
        }

        /* L:677 */
        private bool GetConditionValues()
        {
            /* L:720 */
            if (!(mActiveCondition == null))
            {
                /* L:684 */
                if (this.cboFields.SelectedItem == null)
                {
                    /* L:681 */
                    MessageBox.Show("Select the field for the condition", "");
                    /* L:682 */
                    this.cboFields.Focus();
                    /* L:683 */
                    return false;
                }
                /* L:685 */
                GridEXColumn column = ((Janus.Windows.GridEX.GridEXColumn)(this.cboFields.SelectedItem.Value));
                /* L:695 */
                try
                {
                    /* L:687 */
                    Object value1 = Convert.ChangeType(txtValue1.Text, column.Type);
                    /* L:688 */
                    mActiveCondition.Value1 = value1;
                }
                catch
                {
                    /* L:690 */
                    MessageBox.Show("Value 1 is not valid", "");
                    /* L:691 */
                    txtValue1.Focus();
                    /* L:692 */
                    txtValue1.SelectionStart = txtValue1.Text.Length;
                    /* L:693 */
                    return false;
                }
                /* L:695 */
                /* L:710 */
                if ((mTwoValues))
                {
                    /* L:697 */
                    /* L:706 */
                    try
                    {
                        /* L:699 */
                        Object value2 = Convert.ChangeType(txtValue2.Text, column.Type);
                        /* L:700 */
                        mActiveCondition.Value2 = value2;
                    }
                    catch
                    {
                        /* L:702 */
                        MessageBox.Show("Value 2 is not valid", "");
                        /* L:703 */
                        txtValue2.SelectionStart = 0;
                        /* L:705 */
                        return false;
                        /* L:705 */
                    }
                }
                else
                {
                    /* L:708 */
                    /* L:709 */
                    mActiveCondition.Value2 = null;
                }
                /* L:711 */
                mActiveCondition.Key = txtConditionName.Text;
                /* L:712 */
                mActiveCondition.Column = column;
                /* L:713 */
                mActiveCondition.ConditionOperator = ((Janus.Windows.GridEX.ConditionOperator)(this.cboCondition.SelectedItem.Value));
                /* L:714 */
                mActiveCondition.FormatStyle.BackColor = this.btnBackColor.SelectedColor;
                /* L:715 */
                mActiveCondition.FormatStyle.ForeColor = this.btnForeColor.SelectedColor;
                /* L:716 */
                mActiveCondition.FormatStyle.FontBold = ((Janus.Windows.GridEX.TriState)(this.chkBold.BindableValue));
                /* L:717 */
                mActiveCondition.FormatStyle.FontItalic = ((Janus.Windows.GridEX.TriState)(this.chkItalic.BindableValue));
                /* L:718 */
                mActiveCondition.FormatStyle.FontUnderline = ((Janus.Windows.GridEX.TriState)(this.chkUnderline.BindableValue));
                /* L:719 */
                mActiveCondition.FormatStyle.FontStrikeout = ((Janus.Windows.GridEX.TriState)(this.chkStrikeout.BindableValue));
            }
            /* L:721 */
            return true;
        }

        /* L:723 */
        private void OnActiveConditionChanged()
        {
            /* L:759 */
            if (mActiveCondition == null)
            {
                /* L:726 */
                this.excConditionName.Group.Enabled = false;
                /* L:727 */
                this.excConditionCriteria.Group.Enabled = false;
                /* L:728 */
                this.excAppearance.Group.Enabled = false;
                /* L:729 */
                this.txtConditionName.Text = "";
                /* L:730 */
                this.cboFields.SelectedItem = null;
                /* L:731 */
                this.cboCondition.SelectedValue = null;
                /* L:732 */
                this.txtValue1.Text = "";
                /* L:733 */
                this.txtValue2.Text = "";
                /* L:734 */
                this.btnBackColor.SelectedColor = Color.Empty;
                /* L:735 */
                this.btnForeColor.SelectedColor = Color.Empty;
                /* L:736 */
                this.chkBold.CheckState = CheckState.Indeterminate;
                /* L:737 */
                this.chkItalic.CheckState = CheckState.Indeterminate;
                /* L:738 */
                this.chkUnderline.CheckState = CheckState.Indeterminate;
                /* L:739 */
                this.chkStrikeout.CheckState = CheckState.Indeterminate;
            }
            else
            {
                /* L:741 */
                this.excConditionName.Group.Enabled = true;
                /* L:742 */
                this.excConditionCriteria.Group.Enabled = true;
                /* L:743 */
                this.excAppearance.Group.Enabled = true;
                /* L:744 */
                this.txtConditionName.Text = mActiveCondition.Key;
                /* L:749 */
                if (mActiveCondition.Column == null)
                {
                    /* L:746 */
                    this.cboFields.SelectedIndex = -1;
                }
                else
                {
                    /* L:748 */
                    this.cboFields.SelectedValue = mActiveCondition.Column;
                }
                /* L:750 */
                this.cboCondition.SelectedValue = mActiveCondition.ConditionOperator;
                /* L:751 */
                this.txtValue1.Text = mActiveCondition.Value1 + "";
                /* L:752 */
                this.txtValue2.Text = mActiveCondition.Value2 + "";
                /* L:753 */
                this.btnBackColor.SelectedColor = mActiveCondition.FormatStyle.BackColor;
                /* L:754 */
                this.btnForeColor.SelectedColor = mActiveCondition.FormatStyle.ForeColor;
                /* L:755 */
                chkBold.BindableValue = mActiveCondition.FormatStyle.FontBold;
                /* L:756 */
                chkItalic.BindableValue = mActiveCondition.FormatStyle.FontItalic;
                /* L:757 */
                chkUnderline.BindableValue = mActiveCondition.FormatStyle.FontUnderline;
                /* L:758 */
                chkStrikeout.BindableValue = mActiveCondition.FormatStyle.FontStrikeout;
            }
        }

        /* L:761 */
        private void cboCondition_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            /* L:775 */
            if (!(cboCondition.SelectedValue == null))
            {
                /* L:774 */
                switch (((ConditionOperator)(cboCondition.SelectedValue)))
                {
                    case ConditionOperator.Between:
                    case ConditionOperator.NotBetween:
                        /* L:766 */
                        txtValue2.Enabled = true;
                        /* L:767 */
                        lblValue2.Enabled = true;
                        /* L:768 */
                        mTwoValues = true;
                        break;
                    default:
                        /* L:770 */
                        txtValue2.Text = "";
                        /* L:771 */
                        txtValue2.Enabled = false;
                        /* L:772 */
                        lblValue2.Enabled = false;
                        /* L:773 */
                        mTwoValues = false;
                        break;
                }

            }
        }

        /* L:777 */
        private void btnMoveUp_Click(System.Object sender, System.EventArgs e)
        {
            /* L:779 */
            int index = this.jsgConditions.Row;
            /* L:780 */
            Object condition = this.tempConditions[index];
            /* L:781 */
            this.tempConditions.Remove(condition);
            /* L:782 */
            this.tempConditions.Insert(index - 1, condition);
            /* L:783 */
            this.jsgConditions.Refetch();
            /* L:784 */
            this.jsgConditions.Row = index - 1;
            /* L:785 */
            this.jsgConditions.Focus();
        }

        /* L:787 */
        private void btnMoveDown_Click(System.Object sender, System.EventArgs e)
        {
            /* L:789 */
            int index = this.jsgConditions.Row;
            /* L:790 */
            Object condition = this.tempConditions[index];
            /* L:791 */
            this.tempConditions.Remove(condition);
            /* L:792 */
            this.tempConditions.Insert(index + 1, condition);
            /* L:793 */
            this.jsgConditions.Refetch();
            /* L:794 */
            this.jsgConditions.Row = index + 1;
            /* L:796 */
            this.jsgConditions.Focus();
            /* L:796 */
        }

        /* L:798 */
        private void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            /* L:807 */
            if (this.GetConditionValues())
            {
                /* L:801 */
                GridEXFormatCondition condition = new GridEXFormatCondition();
                /* L:802 */
                condition.Key = "Untitled";
                /* L:803 */
                this.tempConditions.Add(condition);
                /* L:804 */
                this.jsgConditions.Refetch();
                /* L:805 */
                this.jsgConditions.Row = this.jsgConditions.RecordCount - 1;
                /* L:806 */
                this.jsgConditions.Focus();
            }
        }

        /* L:809 */
        private void btnDelete_Click(Object sender, System.EventArgs e)
        {
            /* L:811 */
            //int index = 0;
            /* L:812 */
            this.jsgConditions.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            /* L:813 */
            mActiveCondition = null;
            /* L:814 */
            OnActiveConditionChanged();
            /* L:815 */
            this.jsgConditions.Delete();
            /* L:817 */
            this.jsgConditions.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
            /* L:817 */
        }

        /* L:819 */
        private void txtConditionName_TextChanged(Object sender, System.EventArgs e)
        {
            /* L:824 */
            if (!(mActiveCondition == null))
            {
                /* L:822 */
                this.ActiveCondition.Key = txtConditionName.Text;
                /* L:823 */
                this.jsgConditions.Refresh();
            }
        }

        /* L:826 */
        private void jsgConditions_UpdatingRecord(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            /* L:828 */
            Janus.Windows.GridEX.GridEXRow row = null;
            /* L:829 */
            row = jsgConditions.GetRow();
            /* L:831 */
            this.txtConditionName.Text = System.Convert.ToString(row.Cells["clmName"].Value);
            /* L:831 */
        }

        /* L:833 */
        private void jsgConditions_CurrentCellChanging(Object sender, Janus.Windows.GridEX.CurrentCellChangingEventArgs e)
        {
            /* L:841 */
            if (!(e.Row == null))
            {
                /* L:840 */
                if (this.jsgConditions.Row >= 0 && !(e.Row.Position == this.jsgConditions.Row))
                {
                    /* L:839 */
                    if (!(this.GetConditionValues()))
                    {
                        /* L:838 */
                        e.Cancel = true;
                    }
                }
            }
        }

        /* L:843 */
        private void jsgConditions_SelectionChanged(Object sender, System.EventArgs e)
        {
            /* L:845 */
            Janus.Windows.GridEX.GridEXRow currentRow = this.jsgConditions.GetRow();
            /* L:863 */
           // if (!(Information.IsNothing(currentRow)))
            if(currentRow!=null)
            {
                /* L:847 */
                ActiveCondition = ((GridEXFormatCondition)(currentRow.DataRow));
                /* L:852 */
                if (currentRow.Position == 0)
                {
                    /* L:849 */
                    this.btnMoveUp.Enabled = false;
                }
                else
                {
                    /* L:851 */
                    this.btnMoveUp.Enabled = true;
                }
                /* L:858 */
                if (currentRow.Position < this.jsgConditions.RowCount - 1)
                {
                    /* L:854 */
                    this.btnMoveDown.Enabled = true;
                }
                else
                {
                    /* L:856 */
                    this.btnMoveDown.Enabled = false;
                }
                /* L:858 */
            }
            else
            {
                /* L:860 */
                this.btnMoveDown.Enabled = false;
                /* L:861 */
                this.btnMoveUp.Enabled = false;
                /* L:862 */
                ActiveCondition = null;
            }
        }

        /* L:865 */
        /* L:866 */
        private void jsgConditions_FormattingRow(Object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            /* L:871 */
            if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                /* L:869 */
                GridEXFormatCondition formatCondition = ((GridEXFormatCondition)(e.Row.DataRow));
                /* L:870 */
                e.Row.RowStyle = new GridEXFormatStyle(formatCondition.FormatStyle);
            }
        }

        /* L:873 */
        private void FormatsForm_Closing(Object sender, System.ComponentModel.CancelEventArgs e)
        {
            /* L:885 */
            if (this.DialogResult == DialogResult.OK)
            {
                /* L:884 */
                if (GetConditionValues())
                {
                    /* L:877 */
                    mGridEX.RootTable.FormatConditions.Clear();
                    /* L:878 */
                    GridEXFormatCondition condition = null;
                    /* L:881 */
                    foreach (Janus.Windows.GridEX.GridEXFormatCondition transTemp2 in tempConditions)
                    {
                        condition = transTemp2; /* TRANSWARNING: check temp variable in foreach */
                        /* L:880 */
                        mGridEX.RootTable.FormatConditions.Add(condition);
                    }
                }
                else
                {
                    /* L:883 */
                    e.Cancel = true;
                }
            }
        }

        /* L:887 */
    }

    /* L:888 */
}
