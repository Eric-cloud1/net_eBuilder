/* L:2 */using Janus.Windows.GridEX; 
/* L:2 */
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder {
    public class frmFormatView : System.Windows.Forms.Form { 
    
        private Font mHeaderFont; 
        private Font mRowsFont; 
        #region '" Windows Form Designer generated code "' 
      
        public frmFormatView() : base() { 
   
          InitializeComponent(); 
  
        } 

        protected override void Dispose( bool disposing ) { 
            if ( disposing ) { 
                if ( !( ( components == null ) ) ) { 
                    components.Dispose(); 
                } 
            } 
            base.Dispose( disposing ); 
        } 
        
 
        private System.ComponentModel.IContainer components=null; 
     
       internal  System.Windows.Forms.FontDialog FontDialog1; 
       internal  Janus.Windows.EditControls.UIGroupBox UiGroupBox1; 
       internal  Janus.Windows.EditControls.UIButton btnCancel; 
       internal  Janus.Windows.EditControls.UIButton btnOK; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox3; 
       internal  Janus.Windows.EditControls.UICheckBox chkShadeGroupHeaders; 
       internal  Janus.Windows.EditControls.UIComboBox cboGridlineStyle; 
       internal  System.Windows.Forms.Label Label2; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox2; 
       internal  Janus.Windows.EditControls.UICheckBox chkAllowAddNew; 
       internal  Janus.Windows.EditControls.UICheckBox chkAllowEdit; 
       internal  System.Windows.Forms.Label lblRowsFont; 
       internal  Janus.Windows.EditControls.UIButton btnRowsFont; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox1; 
       internal  Janus.Windows.EditControls.UICheckBox chkAutoSize; 
       internal  System.Windows.Forms.Label lblHeaderFont; 
       internal  Janus.Windows.EditControls.UIButton btnHeaderFont; 
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() { 
            this.FontDialog1 = new System.Windows.Forms.FontDialog(); 
            this.UiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.btnCancel = new Janus.Windows.EditControls.UIButton(); 
            this.btnOK = new Janus.Windows.EditControls.UIButton(); 
            this.GroupBox3 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.chkShadeGroupHeaders = new Janus.Windows.EditControls.UICheckBox(); 
            this.cboGridlineStyle = new Janus.Windows.EditControls.UIComboBox(); 
            this.Label2 = new System.Windows.Forms.Label(); 
            this.GroupBox2 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.chkAllowAddNew = new Janus.Windows.EditControls.UICheckBox(); 
            this.chkAllowEdit = new Janus.Windows.EditControls.UICheckBox(); 
            this.lblRowsFont = new System.Windows.Forms.Label(); 
            this.btnRowsFont = new Janus.Windows.EditControls.UIButton(); 
            this.GroupBox1 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.chkAutoSize = new Janus.Windows.EditControls.UICheckBox(); 
            this.lblHeaderFont = new System.Windows.Forms.Label(); 
            this.btnHeaderFont = new Janus.Windows.EditControls.UIButton(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.UiGroupBox1 ) ).BeginInit(); 
            this.UiGroupBox1.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox3 ) ).BeginInit(); 
            this.GroupBox3.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox2 ) ).BeginInit(); 
            this.GroupBox2.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).BeginInit(); 
            this.GroupBox1.SuspendLayout(); 
            this.SuspendLayout(); 
     
            this.FontDialog1.AllowVerticalFonts = false; 
            this.FontDialog1.FontMustExist = true; 
            this.FontDialog1.ShowColor = true; 
     
            this.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel; 
            this.UiGroupBox1.Controls.AddRange( new System.Windows.Forms.Control[] { this.btnCancel, this.btnOK, this.GroupBox3, this.GroupBox2, this.GroupBox1 } ); 
            this.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill; 
            this.UiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.None; 
            this.UiGroupBox1.Name = "UiGroupBox1"; 
            this.UiGroupBox1.Size = new System.Drawing.Size( 538, 240 ); 
            this.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
          
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel; 
            this.btnCancel.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
            this.btnCancel.Location = new System.Drawing.Point( 448, 40 ); 
            this.btnCancel.Name = "btnCancel"; 
            this.btnCancel.Size = new System.Drawing.Size( 80, 24 ); 
            this.btnCancel.TabIndex = 11; 
            this.btnCancel.Text = "Cancel"; 
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
        
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK; 
            this.btnOK.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
            this.btnOK.Location = new System.Drawing.Point( 448, 8 ); 
            this.btnOK.Name = "btnOK"; 
            this.btnOK.Size = new System.Drawing.Size( 80, 24 ); 
            this.btnOK.TabIndex = 10; 
            this.btnOK.Text = "OK"; 
            this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
       
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox3.Controls.AddRange( new System.Windows.Forms.Control[] { this.chkShadeGroupHeaders, this.cboGridlineStyle, this.Label2 } ); 
            this.GroupBox3.Location = new System.Drawing.Point( 8, 164 ); 
            this.GroupBox3.Name = "GroupBox3"; 
            this.GroupBox3.Size = new System.Drawing.Size( 424, 68 ); 
            this.GroupBox3.Text = "Grid lines"; 
            this.GroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
          
            this.chkShadeGroupHeaders.Location = new System.Drawing.Point( 276, 23 ); 
            this.chkShadeGroupHeaders.Name = "chkShadeGroupHeaders"; 
            this.chkShadeGroupHeaders.Size = new System.Drawing.Size( 132, 16 ); 
            this.chkShadeGroupHeaders.TabIndex = 3; 
            this.chkShadeGroupHeaders.Text = "Shade group headings"; 

            this.cboGridlineStyle.Location = new System.Drawing.Point( 100, 21 ); 
            this.cboGridlineStyle.Name = "cboGridlineStyle"; 
            this.cboGridlineStyle.Size = new System.Drawing.Size( 168, 21 ); 
            this.cboGridlineStyle.TabIndex = 1; 
      
            this.Label2.AutoSize = true; 
            this.Label2.Location = new System.Drawing.Point( 12, 24 ); 
            this.Label2.Name = "Label2"; 
            this.Label2.Size = new System.Drawing.Size( 76, 14 ); 
            this.Label2.TabIndex = 0; 
            this.Label2.Text = "Grid line style:"; 
      
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox2.Controls.AddRange( new System.Windows.Forms.Control[] { this.chkAllowAddNew, this.chkAllowEdit, this.lblRowsFont, this.btnRowsFont } ); 
            this.GroupBox2.Location = new System.Drawing.Point( 8, 86 ); 
            this.GroupBox2.Name = "GroupBox2"; 
            this.GroupBox2.Size = new System.Drawing.Size( 424, 68 ); 
            this.GroupBox2.Text = "Rows"; 
            this.GroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
       
            this.chkAllowAddNew.Location = new System.Drawing.Point( 276, 48 ); 
            this.chkAllowAddNew.Name = "chkAllowAddNew"; 
            this.chkAllowAddNew.Size = new System.Drawing.Size( 132, 16 ); 
            this.chkAllowAddNew.TabIndex = 3; 
            this.chkAllowAddNew.Text = @"Show ""new item"" row"; 

            this.chkAllowEdit.Location = new System.Drawing.Point( 276, 20 ); 
            this.chkAllowEdit.Name = "chkAllowEdit"; 
            this.chkAllowEdit.Size = new System.Drawing.Size( 124, 20 ); 
            this.chkAllowEdit.TabIndex = 2; 
            this.chkAllowEdit.Text = "Allow in-cell editing"; 
  
            this.lblRowsFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
            this.lblRowsFont.FlatStyle = System.Windows.Forms.FlatStyle.System; 
            this.lblRowsFont.Location = new System.Drawing.Point( 100, 26 ); 
            this.lblRowsFont.Name = "lblRowsFont"; 
            this.lblRowsFont.Size = new System.Drawing.Size( 168, 20 ); 
            this.lblRowsFont.TabIndex = 1; 
            this.lblRowsFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
       
            this.btnRowsFont.Location = new System.Drawing.Point( 12, 24 ); 
            this.btnRowsFont.Name = "btnRowsFont"; 
            this.btnRowsFont.Size = new System.Drawing.Size( 76, 24 ); 
            this.btnRowsFont.TabIndex = 0; 
            this.btnRowsFont.Text = "Font..."; 
            this.btnRowsFont.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
      
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox1.Controls.AddRange( new System.Windows.Forms.Control[] { this.chkAutoSize, this.lblHeaderFont, this.btnHeaderFont } ); 
            this.GroupBox1.Location = new System.Drawing.Point( 8, 8 ); 
            this.GroupBox1.Name = "GroupBox1"; 
            this.GroupBox1.Size = new System.Drawing.Size( 424, 68 ); 
            this.GroupBox1.Text = "Column headings"; 
            this.GroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
     
            this.chkAutoSize.Location = new System.Drawing.Point( 276, 28 ); 
            this.chkAutoSize.Name = "chkAutoSize"; 
            this.chkAutoSize.Size = new System.Drawing.Size( 140, 16 ); 
            this.chkAutoSize.TabIndex = 2; 
            this.chkAutoSize.Text = "Automatic column sizing"; 
 
			this.lblHeaderFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
			this.lblHeaderFont.FlatStyle = System.Windows.Forms.FlatStyle.System; 
			this.lblHeaderFont.Location = new System.Drawing.Point( 100, 26 ); 
			this.lblHeaderFont.Name = "lblHeaderFont"; 
			this.lblHeaderFont.Size = new System.Drawing.Size( 168, 20 ); 
			this.lblHeaderFont.TabIndex = 1; 
			this.lblHeaderFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 

           this.btnHeaderFont.Location = new System.Drawing.Point( 12, 24 ); 
           this.btnHeaderFont.Name = "btnHeaderFont"; 
           this.btnHeaderFont.Size = new System.Drawing.Size( 76, 24 ); 
           this.btnHeaderFont.TabIndex = 0; 
           this.btnHeaderFont.Text = "Font..."; 
           this.btnHeaderFont.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

           this.AutoScaleDimensions = new System.Drawing.SizeF(5, 14);
           this.ClientSize = new System.Drawing.Size( 538, 240 ); 
           this.Controls.AddRange( new System.Windows.Forms.Control[] { this.UiGroupBox1 } ); 
           this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; 
           this.Name = "frmFormatView"; 
           this.Text = "Format Table View"; 
           ( ( System.ComponentModel.ISupportInitialize )( this.UiGroupBox1 ) ).EndInit(); 
           this.UiGroupBox1.ResumeLayout( false ); 
           ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox3 ) ).EndInit(); 
           this.GroupBox3.ResumeLayout( false ); 
           ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox2 ) ).EndInit(); 
           this.GroupBox2.ResumeLayout( false ); 
           ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).EndInit(); 
            this.GroupBox1.ResumeLayout( false ); 
            this.ResumeLayout( false ); 
     
            btnHeaderFont.Click += new System.EventHandler( btnHeaderFont_Click ); 

            btnOK.Click += new System.EventHandler( btnOK_Click ); 
       
            btnRowsFont.Click += new System.EventHandler( btnRowsFont_Click ); 
        } 
        
    
        #endregion 
       
        public Object ShowDialog( GridEX grid, Form parent ) { 
           if ( grid.HeaderFormatStyle.Font == null ) { 
                HeaderFont = ( ( System.Drawing.Font )( grid.Font.Clone() ) ); 
            } 
            else { 
                HeaderFont = ( ( System.Drawing.Font )( grid.HeaderFormatStyle.Font.Clone() ) ); 
            } 
            if ( grid.RowFormatStyle.Font == null ) { 
                RowsFont = ( ( System.Drawing.Font )( grid.Font.Clone() ) ); 
            } 
            else { 
                RowsFont = ( ( System.Drawing.Font )( grid.RowFormatStyle.Font.Clone() ) ); 
            } 
           if ( grid.AllowAddNew == InheritableBoolean.True ) { 
               this.chkAllowAddNew.Checked = true; 
            } 
            if ( grid.AllowEdit == InheritableBoolean.True ) { 
                this.chkAllowEdit.Checked = true; 
            } 
            if ( grid.ColumnAutoResize ) { 
                this.chkAutoSize.Checked = true; 
            } 
     
           this.cboGridlineStyle.Items.Add( "No grid lines" ); 
           this.cboGridlineStyle.Items.Add( "Small dots" ); 
           this.cboGridlineStyle.Items.Add( "Solid" ); 
            if ( grid.GridLines == GridLines.None ) { 
               this.cboGridlineStyle.SelectedIndex = 0; 
            } 
            else { 
               if ( grid.GridLineStyle == GridLineStyle.SmallDots ) { 
                    this.cboGridlineStyle.SelectedIndex = 1; 
                } 
                else { 
                    this.cboGridlineStyle.SelectedIndex = 2; 
                } 
            } 
            if ( grid.GroupRowFormatStyle.BackColor.Equals( SystemColors.Control ) ) { 
               this.chkShadeGroupHeaders.Checked = true; 
            } 
            this.ShowDialog( parent ); 
            
            if ( this.DialogResult == DialogResult.OK ) { 
               if ( mHeaderFont.Equals( grid.Font ) ) { 
                    grid.HeaderFormatStyle.Font = null; 
                } 
                else { 
                   grid.HeaderFormatStyle.Font = mHeaderFont; 
                } 
               if ( mRowsFont.Equals( grid.Font ) ) { 
                    grid.RowFormatStyle.Font = null; 
                } 
                else { 
                    grid.RowFormatStyle.Font = mRowsFont; 
                } 
                if ( this.chkAllowAddNew.Checked ) { 
                    grid.AllowAddNew = InheritableBoolean.True; 
                } 
                else { 
                    grid.AllowAddNew = InheritableBoolean.False; 
                } 
                if ( this.chkAllowEdit.Checked ) { 
                    grid.AllowEdit = InheritableBoolean.True; 
                } 
                else { 
                    grid.AllowEdit = InheritableBoolean.False; 
                } 
                grid.ColumnAutoResize = this.chkAutoSize.Checked; 
                switch ( this.cboGridlineStyle.SelectedIndex ) {
                    case 0:
                        grid.GridLines = GridLines.None; 
                        break;
                    case 1:
                        grid.GridLines = GridLines.Both; 
                        grid.GridLineStyle = GridLineStyle.SmallDots; 
                        break;
                    case 2:
                       grid.GridLines = GridLines.Both; 
                        grid.GridLineStyle = GridLineStyle.Solid; 
                        break;
                }
                
                if ( this.chkShadeGroupHeaders.Checked ) { 
                    grid.ThemedAreas = grid.ThemedAreas | ThemedArea.GroupRows; 
                    grid.GroupRowFormatStyle.BackColor = SystemColors.Control; 
                } 
                else { 
                    grid.ThemedAreas = grid.ThemedAreas ^ ThemedArea.GroupRows; 
                    grid.GroupRowFormatStyle.BackColor = SystemColors.Window; 
                } 
            } 
          return this.DialogResult; 
        } 
        
        private Font HeaderFont { 
            get { 
                return mHeaderFont; 
            } 
            set { 
               if ( value == null ) { 
                    mHeaderFont = null; 
                    this.lblHeaderFont.Text = ""; 
                } 
                else { 
                  if ( !( value.Equals( mHeaderFont ) ) ) { 
                        mHeaderFont = value; 
                        this.lblHeaderFont.Font = new Font( mHeaderFont.Name, this.lblHeaderFont.Font.Size, mHeaderFont.Style ); 
                        this.lblHeaderFont.Text = mHeaderFont.SizeInPoints.ToString() + " pt. " + mHeaderFont.Name; 
                    } 
                } 
            } 
        } 
        private Font RowsFont { 
            get { 
               return mRowsFont; 
            } 
            set { 
                if ( value == null ) { 
                    mRowsFont = null; 
                    this.lblRowsFont.Text = ""; 
                } 
                else { 
                    if ( !( value.Equals( mRowsFont ) ) ) { 
                        mRowsFont = value; 
                        this.lblRowsFont.Font = new Font( mRowsFont.Name, this.lblRowsFont.Font.Size, mRowsFont.Style ); 
                        this.lblRowsFont.Text = mRowsFont.SizeInPoints.ToString() + " pt. " + mRowsFont.Name; 
                    } 
                } 
            } 
        } 
        private void btnHeaderFont_Click( System.Object sender, System.EventArgs e ) { 
            this.FontDialog1.Font = mHeaderFont; 
            this.FontDialog1.ShowColor = false; 
            if ( this.FontDialog1.ShowDialog() == DialogResult.OK ) { 
               this.HeaderFont = this.FontDialog1.Font; 
            } 
        } 
        
  
        private void btnOK_Click( System.Object sender, System.EventArgs e ) { 
            this.Close(); 
        } 
        
      
        private void btnRowsFont_Click( System.Object sender, System.EventArgs e ) { 
            this.FontDialog1.Font = mRowsFont; 
            this.FontDialog1.ShowColor = false; 
            if ( this.FontDialog1.ShowDialog() == DialogResult.OK ) { 
                this.RowsFont = this.FontDialog1.Font; 
            } 
        } 
    
    } 

} 
