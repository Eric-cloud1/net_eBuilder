using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder {
    public class frmDefineViews : System.Windows.Forms.Form { 
     
        #region '" windows form designer generated code "' 
   
        public frmDefineViews() : base() { InitializeComponent();  } 
   
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(this.Components != null)
				{
					Components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        
        

        // required by the windows form designer
        private System.ComponentModel.IContainer  Components   = null; 
    
        // note: the following procedure is required by the windows form designer
        // it can be modified using the windows form designer.  
        // do not modify it using the code editor.
      internal Janus.Windows.EditControls.UIGroupBox  GrbBackground; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton6; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton5; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton4; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton3; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton2; 
      internal Janus.Windows.EditControls.UIRadioButton  Uibutton1; 
	  internal Janus.Windows.GridEX.GridEX  Gridex1; 
        [System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() { 

            Janus.Windows.GridEX.GridEXLayout GridexLayout1 = new Janus.Windows.GridEX.GridEXLayout(); 
            this.GrbBackground = new Janus.Windows.EditControls.UIGroupBox(); 
            this.Uibutton6 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Uibutton5 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Uibutton4 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Uibutton3 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Uibutton2 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Uibutton1 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.Gridex1 = new Janus.Windows.GridEX.GridEX(); 


            ( ( System.ComponentModel.ISupportInitialize)( this.GrbBackground ) ).BeginInit(); 
            this.GrbBackground.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize)( this.Gridex1) ).BeginInit(); 
            this.SuspendLayout(); 
    
            // grbbackground
            // 
            this.GrbBackground.BackgroundStyle  = Janus.Windows.EditControls.BackgroundStyle.Panel; 
            this.GrbBackground.Controls.AddRange(new System.Windows.Forms.Control[] { this.Uibutton6, this.Uibutton5, this.Uibutton4, this.Uibutton3, this.Uibutton2, this.Uibutton1, this.Gridex1 } ); 
            this.GrbBackground.Dock  = System.Windows.Forms.DockStyle.Fill; 
            this.GrbBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None; 
            this.GrbBackground.Name = "grbbackground"; 
            this.GrbBackground.Size = new System.Drawing.Size( 416, 214 ); 
            this.GrbBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
           
            this.Uibutton6.Location = new System.Drawing.Point(224,179); 
            this.Uibutton6.Name  = "uibutton6"; 
            this.Uibutton6.Size  = new System.Drawing.Size( 88, 24 ); 
            this.Uibutton6.TabIndex = 13; 
            this.Uibutton6.Text = "close"; 
            this.Uibutton6.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;  

            this.Uibutton5.Location = new System.Drawing.Point( 128, 179 ); 
            this.Uibutton5.Name = "uibutton5"; 
            this.Uibutton5.Size = new System.Drawing.Size( 88, 24 ); 
            this.Uibutton5.TabIndex = 12; 
            this.Uibutton5.Text = "apply view"; 
            this.Uibutton5.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
           
	        
			this.Uibutton4.Location = new System.Drawing.Point( 320, 107 ); 
			this.Uibutton4.Name  = "uibutton4"; 
			this.Uibutton4.Size = new  System.Drawing.Size( 88, 24 ); 
			this.Uibutton4.TabIndex = 11; 
			this.Uibutton4.Text = "rename..."; 
			this.Uibutton4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;  
           
            this.Uibutton3.Location = new System.Drawing.Point( 320, 75 ); 
            this.Uibutton3.Name = "uibutton3"; 
            this.Uibutton3.Size = new  System.Drawing.Size( 88, 24 ); 
            this.Uibutton3.TabIndex  = 10; 
            this.Uibutton3.Text = "modify..."; 
            this.Uibutton3.VisualStyle =  Janus.Windows.UI.VisualStyle.Office2003;
        
            this.Uibutton2.Location  = new System.Drawing.Point( 320, 43 ); 
            this.Uibutton2.Name = "uibutton2"; 
            this.Uibutton2.Size = new System.Drawing.Size( 88, 24 ); 
            this.Uibutton2.TabIndex = 9; 
            this.Uibutton2.Text = "copy..."; 
            this.Uibutton2.VisualStyle  = Janus.Windows.UI.VisualStyle.Office2003;
     
			 this.Uibutton2.Location = new System.Drawing.Point( 320, 11 ); 
			this.Uibutton2.Name = "uibutton1"; 
			this.Uibutton2.Size = new System.Drawing.Size( 88, 24 ); 
			this.Uibutton2.TabIndex = 8; 
			this.Uibutton2.Text = "new..."; 
			this.Uibutton2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
    
			this.Gridex1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False; 
			this.Gridex1.ColumnAutoResize = true; 
			GridexLayout1.LayoutString  = @"<gridexlayoutdata><roottable><columns collection=""true""><column0 id=""viewname""><c" + "aption>view name</caption><datamember>viewname</datamember><key>viewname</key><p" + "osition>0</position><selectable>false</selectable><width>202</width></column0><c" + @"olumn1 id=""viewtype""><allowsize>false</allowsize><caption>view type</caption><da" + "tamember>viewtype</datamember><key>viewtype</key><position>1</position><selectab" + @"le>false</selectable></column1></columns><groupcondition id="""" /></roottable></g" + 
				"ridexlayoutdata>"; 
            this.Gridex1.DesignTimeLayout = GridexLayout1; 
            this.Gridex1.GroupByBoxVisible = false; 
			this.Gridex1.Location= new System.Drawing.Point( 8, 11 ); 
			this.Gridex1.Name = "gridex1"; 
			this.Gridex1.Size = new System.Drawing.Size( 304, 160 ); 
			this.Gridex1.TabIndex= 7; 
			this.Gridex1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003 ;

            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size( 416, 214 ); 
			this.Controls.AddRange( new System.Windows.Forms.Control[] { this.GrbBackground } ); 
			this.Name = "frmdefineviews"; 
			this.Text = "custom view organizer"; 
			( ( System.ComponentModel.ISupportInitialize )( this.GrbBackground ) ).EndInit(); 
			this.GrbBackground.ResumeLayout( false ); 
				( ( System.ComponentModel.ISupportInitialize)( this.Gridex1) ).EndInit(); 
			this.ResumeLayout( false ); 
		} 

        #endregion 
  } 

} 
