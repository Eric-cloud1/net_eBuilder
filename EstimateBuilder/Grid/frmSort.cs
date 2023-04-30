/* L:1 */using Janus.Windows.GridEX; 
/* L:3 */using Janus.Windows.EditControls; 
/* L:3 */
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder {
    public class frmSort : System.Windows.Forms.Form { 

        #region '" Windows Form Designer generated code "' 

        public frmSort() : base() { 

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
        

        private System.ComponentModel.IContainer components = null; 
        internal  Janus.Windows.EditControls.UIGroupBox grbBackground; 
        internal  Janus.Windows.EditControls.UIButton btnClear; 
        internal  Janus.Windows.EditControls.UIComboBox cboColumn3; 
        internal  Janus.Windows.EditControls.UIRadioButton optDescending3; 
        internal  Janus.Windows.EditControls.UIRadioButton optAscending3; 
        internal  Janus.Windows.EditControls.UIButton btnOK; 
        internal  Janus.Windows.EditControls.UIComboBox cboColumn1; 
        internal  Janus.Windows.EditControls.UIRadioButton optDescending1; 
        internal  Janus.Windows.EditControls.UIRadioButton optAscending1; 
        internal  Janus.Windows.EditControls.UIComboBox cboColumn0; 
        internal  Janus.Windows.EditControls.UIRadioButton optDescending0; 
        internal  Janus.Windows.EditControls.UIRadioButton optAscending0; 
        internal  Janus.Windows.EditControls.UIButton btnCancel; 
        internal Janus.Windows.EditControls.UIComboBox cboColumn2; 
        internal Janus.Windows.EditControls.UIRadioButton optDescending2; 
        internal Janus.Windows.EditControls.UIRadioButton optAscending2; 
        internal Janus.Windows.EditControls.UIGroupBox grbSort4; 
        internal Janus.Windows.EditControls.UIGroupBox grbSort2; 
        internal  Janus.Windows.EditControls.UIGroupBox grbSort1; 
        internal Janus.Windows.EditControls.UIGroupBox grbSort3; 
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() { 
            this.grbBackground = new Janus.Windows.EditControls.UIGroupBox(); 
            this.btnClear = new Janus.Windows.EditControls.UIButton(); 
            this.grbSort4 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn3 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending3 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending3 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.btnOK = new Janus.Windows.EditControls.UIButton(); 
            this.grbSort2 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn1 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending1 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending1 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.grbSort1 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn0 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending0 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending0 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.btnCancel = new Janus.Windows.EditControls.UIButton(); 
            this.grbSort3 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn2 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending2 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending2 = new Janus.Windows.EditControls.UIRadioButton(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).BeginInit(); 
            this.grbBackground.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort4 ) ).BeginInit(); 
            this.grbSort4.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort2 ) ).BeginInit(); 
            this.grbSort2.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort1 ) ).BeginInit(); 
            this.grbSort1.SuspendLayout(); 
           ( ( System.ComponentModel.ISupportInitialize )( this.grbSort3 ) ).BeginInit(); 
            this.grbSort3.SuspendLayout(); 
            this.SuspendLayout(); 
          
            this.grbBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel; 
            this.grbBackground.Controls.AddRange( new System.Windows.Forms.Control[] { this.btnClear, this.grbSort4, this.btnOK, this.grbSort2, this.grbSort1, this.btnCancel, this.grbSort3 } ); 
            this.grbBackground.Dock = System.Windows.Forms.DockStyle.Fill; 
            this.grbBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None; 
            this.grbBackground.Name = "grbBackground"; 
            this.grbBackground.Size = new System.Drawing.Size( 400, 302 ); 
            this.grbBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
   
        

            this.grbSort4.BackColor = System.Drawing.Color.Transparent; 
            this.grbSort4.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn3, this.optDescending3, this.optAscending3 } ); 
            this.grbSort4.Location = new System.Drawing.Point( 8, 230 ); 
            this.grbSort4.Name = "grbSort4"; 
            this.grbSort4.Size = new System.Drawing.Size( 296, 64 ); 
            this.grbSort4.Text = "Then By"; 
            this.grbSort4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 

            this.cboColumn3.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn3.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn3.Name = "cboColumn3"; 
            this.cboColumn3.Size = new System.Drawing.Size( 176, 20 ); 
            this.cboColumn3.TabIndex = 4; 
            this.cboColumn3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
  
            this.optDescending3.Enabled = false; 
            this.optDescending3.Location = new System.Drawing.Point( 196, 36 ); 
            this.optDescending3.Name = "optDescending3"; 
            this.optDescending3.Size = new System.Drawing.Size( 88, 16 ); 
            this.optDescending3.TabIndex = 2; 
            this.optDescending3.Text = "Descending"; 
            this.optDescending3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.optAscending3.Checked = true; 
            this.optAscending3.Enabled = false; 
            this.optAscending3.Location = new System.Drawing.Point( 196, 16 ); 
            this.optAscending3.Name = "optAscending3"; 
            this.optAscending3.Size = new System.Drawing.Size( 88, 16 ); 
            this.optAscending3.TabIndex = 1; 
            this.optAscending3.Text = "Ascending"; 
            this.optAscending3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK; 
            this.btnOK.Location = new System.Drawing.Point( 312, 8 ); 
            this.btnOK.Name = "btnOK"; 
            this.btnOK.Size = new System.Drawing.Size( 80, 24 ); 
            this.btnOK.TabIndex = 11; 
            this.btnOK.Text = "OK"; 
            this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnClear.Location = new System.Drawing.Point(312, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 24);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear All";
            this.btnClear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            
            
            this.grbSort2.BackColor = System.Drawing.Color.Transparent; 
            this.grbSort2.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn1, this.optDescending1, this.optAscending1 } ); 
            this.grbSort2.Location = new System.Drawing.Point( 8, 82 ); 
            this.grbSort2.Name = "grbSort2"; 
            this.grbSort2.Size = new System.Drawing.Size( 296, 64 ); 
            this.grbSort2.Text = "Then By"; 
            this.grbSort2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 

            this.cboColumn1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn1.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn1.Name = "cboColumn1"; 
            this.cboColumn1.Size = new System.Drawing.Size( 176, 20 ); 
            this.cboColumn1.TabIndex = 4; 
            this.cboColumn1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
 
            this.optDescending1.Enabled = false; 
            this.optDescending1.Location = new System.Drawing.Point( 196, 36 ); 
            this.optDescending1.Name = "optDescending1"; 
            this.optDescending1.Size = new System.Drawing.Size( 88, 16 ); 
            this.optDescending1.TabIndex = 2; 
            this.optDescending1.Text = "Descending"; 
            this.optDescending1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
     
            this.optAscending1.Checked = true; 
            this.optAscending1.Enabled = false; 
            this.optAscending1.Location = new System.Drawing.Point( 196, 16 ); 
            this.optAscending1.Name = "optAscending1"; 
            this.optAscending1.Size = new System.Drawing.Size( 88, 16 ); 
            this.optAscending1.TabIndex = 1; 
            this.optAscending1.Text = "Ascending"; 
            this.optAscending1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
      
            this.grbSort1.BackColor = System.Drawing.Color.Transparent; 
            this.grbSort1.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn0, this.optDescending0, this.optAscending0 } ); 
            this.grbSort1.Location = new System.Drawing.Point( 8, 8 ); 
            this.grbSort1.Name = "grbSort1"; 
            this.grbSort1.Size = new System.Drawing.Size( 296, 64 ); 
            this.grbSort1.Text = "Sort Items By"; 
            this.grbSort1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
    
            this.cboColumn0.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn0.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn0.Name = "cboColumn0"; 
            this.cboColumn0.Size = new System.Drawing.Size( 176, 20 ); 
            this.cboColumn0.TabIndex = 3; 
            this.cboColumn0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
 
            this.optDescending0.Enabled = false; 
            this.optDescending0.Location = new System.Drawing.Point( 196, 36 ); 
            this.optDescending0.Name = "optDescending0"; 
            this.optDescending0.Size = new System.Drawing.Size( 88, 16 ); 
            this.optDescending0.TabIndex = 2; 
            this.optDescending0.Text = "Descending"; 
            this.optDescending0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.optAscending0.Checked = true; 
            this.optAscending0.Enabled = false; 
            this.optAscending0.Location = new System.Drawing.Point( 196, 16 ); 
            this.optAscending0.Name = "optAscending0"; 
            this.optAscending0.Size = new System.Drawing.Size( 88, 16 ); 
            this.optAscending0.TabIndex = 1; 
            this.optAscending0.Text = "Ascending"; 
            this.optAscending0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

      

            this.grbSort3.BackColor = System.Drawing.Color.Transparent; 
            this.grbSort3.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn2, this.optDescending2, this.optAscending2 } ); 
            this.grbSort3.Location = new System.Drawing.Point( 8, 156 ); 
            this.grbSort3.Name = "grbSort3"; 
            this.grbSort3.Size = new System.Drawing.Size( 296, 64 ); 
            this.grbSort3.Text = "Then By"; 
            this.grbSort3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
    
            this.cboColumn2.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn2.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn2.Name = "cboColumn2"; 
            this.cboColumn2.Size = new System.Drawing.Size( 176, 20 ); 
            this.cboColumn2.TabIndex = 4; 
            this.cboColumn2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.optDescending2.Enabled = false; 
            this.optDescending2.Location = new System.Drawing.Point( 196, 36 ); 
            this.optDescending2.Name = "optDescending2"; 
            this.optDescending2.Size = new System.Drawing.Size( 88, 16 ); 
            this.optDescending2.TabIndex = 2; 
            this.optDescending2.Text = "Descending"; 
            this.optDescending2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.optAscending2.Checked = true; 
            this.optAscending2.Enabled = false; 
            this.optAscending2.Location = new System.Drawing.Point( 196, 16 ); 
            this.optAscending2.Name = "optAscending2"; 
            this.optAscending2.Size = new System.Drawing.Size( 88, 16 ); 
            this.optAscending2.TabIndex = 1; 
            this.optAscending2.Text = "Ascending"; 
            this.optAscending2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size( 400, 302 ); 
            this.Controls.AddRange( new System.Windows.Forms.Control[] { this.grbBackground } ); 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; 
            this.Name = "frmSort"; 
            this.Text = "Sort"; 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).EndInit(); 
            this.grbBackground.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort4 ) ).EndInit(); 
            this.grbSort4.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort2 ) ).EndInit(); 
            this.grbSort2.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort1 ) ).EndInit(); 
            this.grbSort1.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbSort3 ) ).EndInit(); 
            this.grbSort3.ResumeLayout( false ); 
            this.ResumeLayout( false ); 

            cboColumn0.SelectedItemChanged += new System.EventHandler( cboColumn0_SelectedItemChanged ); 

            cboColumn1.SelectedItemChanged += new System.EventHandler( cboColumn1_SelectedItemChanged ); 

            cboColumn2.SelectedItemChanged += new System.EventHandler( cboColumn2_SelectedItemChanged ); 

            cboColumn3.SelectedItemChanged += new System.EventHandler( cboColumn3_SelectedItemChanged ); 

            btnClear.Click += new System.EventHandler( btnClear_Click ); 

     
        } 

        #endregion 
    
        public DialogResult ShowDialog( GridEX grid, Form parent ) { 
            GridEXSortKey sortKey = null; 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn0 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn1 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn2 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn3 ); 
            Janus.Windows.GridEX.GridEXSortKeyCollection transTemp0 = grid.RootTable.SortKeys;
            if ( transTemp0.Count == 0 ) { 
                SetSortKey( null, true, cboColumn0, optAscending0, optDescending0 ); 
            } 
            else { 
                if ( transTemp0.Count >= 1 ) { 
                    sortKey = transTemp0[ 0 ]; 
                    SetSortKey( sortKey.Column, ( System.Convert.ToInt64( sortKey.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn0, optAscending0, optDescending0 ); 
                } 
                if ( transTemp0.Count >= 2 ) { 
                    sortKey = transTemp0[ 1 ]; 
                    SetSortKey( sortKey.Column, ( System.Convert.ToInt64( sortKey.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn1, optAscending1, optDescending1 ); 
                } 
                if ( transTemp0.Count >= 3 ) { 
                    sortKey = transTemp0[ 2 ]; 
                    SetSortKey( sortKey.Column, ( System.Convert.ToInt64( sortKey.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn2, optAscending2, optDescending2 ); 
                } 
                if ( transTemp0.Count >= 4 ) { 
                    sortKey = transTemp0[ 3 ]; 
                    SetSortKey( sortKey.Column, ( System.Convert.ToInt64( sortKey.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn3, optAscending3, optDescending3 ); 
                } 
            } 
            
            this.ShowDialog(); 
            if ( this.DialogResult == DialogResult.OK ) 
            { 
                grid.RootTable.SortKeys.Clear(); 
                CreateSortKeys( grid );
                grid.Refetch();
                return DialogResult.OK;
            }       
            else
            { return DialogResult.Cancel;}
        } 
        
        private void CreateSortKeys( GridEX grid ) { 
           int sortKeysCount = 0; 
            if ( cboColumn3.SelectedIndex > 0 ) { 
                sortKeysCount = 4; 
            } 
            else if ( cboColumn2.SelectedIndex > 0 ) { 
                sortKeysCount = 3; 
            } 
            else if ( cboColumn1.SelectedIndex > 0 ) { 
                sortKeysCount = 2; 
            } 
            else if ( cboColumn0.SelectedIndex > 0 ) { 
                sortKeysCount = 1; 
            } 
            else { 
               sortKeysCount = 0; 
            } 
           GridEXSortKey[] sortKeys = new GridEXSortKey[ sortKeysCount - 1 + 1 ]; 
           if ( sortKeysCount > 0 ) { 
                sortKeys[ 0 ] = CreateSortKey( ( ( Janus.Windows.GridEX.GridEXColumn )( ( ( UIComboBoxItem )( cboColumn0.SelectedItem ) ).Value ) ), optAscending0.Checked ); 
            } 
            if ( sortKeysCount > 1 ) { 
                sortKeys[ 1 ] = CreateSortKey( ( ( Janus.Windows.GridEX.GridEXColumn )( ( ( UIComboBoxItem )( cboColumn1.SelectedItem ) ).Value ) ), optAscending1.Checked ); 
            } 
            if ( sortKeysCount > 2 ) { 
                sortKeys[ 2 ] = CreateSortKey( ( ( Janus.Windows.GridEX.GridEXColumn )( ( ( UIComboBoxItem )( cboColumn2.SelectedItem ) ).Value ) ), optAscending2.Checked ); 
            } 
            if ( sortKeysCount > 3 ) { 
               sortKeys[ 3 ] = CreateSortKey( ( ( Janus.Windows.GridEX.GridEXColumn )( ( ( UIComboBoxItem )( cboColumn3.SelectedItem ) ).Value ) ), optAscending3.Checked ); 
            } 
            grid.RootTable.SortKeys.AddRange( sortKeys );
          
        } 
        
        private GridEXSortKey CreateSortKey( GridEXColumn column, bool ascending ) { 
            GridEXSortKey sortKey = new GridEXSortKey(); 
            sortKey.Column = column; 
            if ( !( ascending ) ) { 
                sortKey.SortOrder = ( ( Janus.Windows.GridEX.SortOrder )( Janus.Windows.GridEX.SortOrder.Descending ) ); 
            } 
            return sortKey; 
        } 
        
        private void FillColumnList( GridEXColumnCollection columns, Janus.Windows.EditControls.UIComboBox combo ) { 
          GridEXColumn column = null; 
          int i = 0; 
    
            combo.Items.Clear(); 
            combo.Items.Add( "(None)", null ); 
            for ( i=1; i<=columns.Count - 1; i++ ) { 
                column = columns[ i ]; 
                if ( column.AllowSort ) { 
                   combo.Items.Add( EstimateBuilder.Grid.GetColumnFriendlyName( column ), column ); 
                } 
            } 
        } 
        
        private void SetSortKey( GridEXColumn column, bool ascending, UIComboBox combo, UIRadioButton optAscending, UIRadioButton optDescending ) { 
            Janus.Windows.EditControls.UIComboBoxItem item = null; 
            if ( column == null ) { 
                combo.SelectedIndex = 0; 
            } 
            else { 
                foreach ( Janus.Windows.EditControls.UIComboBoxItem transTemp1 in combo.Items ) { 
                    item = transTemp1; 
                    if ( ( ( Janus.Windows.GridEX.GridEXColumn )( item.Value ) ) == column ) { 
                        combo.SelectedItem = item; 
                        break; 
                    } 
                }
            } 
            if ( ascending ) { 
                optAscending.Checked = true; 
            } 
            else { 
                optDescending.Checked = true; 
            } 
        } 
        
        private void cboColumn0_SelectedItemChanged( System.Object sender, System.EventArgs e ) { 
            if ( cboColumn0.SelectedIndex == 0 ) { 
                this.optAscending0.Enabled = false; 
               this.optDescending0.Enabled = false; 
                cboColumn1.SelectedIndex = 0; 
                cboColumn1.Enabled = false; 
            } 
            else { 
                this.optAscending0.Enabled = true; 
                this.optDescending0.Enabled = true; 
                cboColumn1.Enabled = true; 
                if ( cboColumn1.SelectedIndex == -1 ) { 
                    cboColumn1.SelectedIndex = 0; 
                } 
            } 
        } 
            
        private void cboColumn1_SelectedItemChanged( System.Object sender, System.EventArgs e ) { 
            if ( cboColumn1.SelectedIndex == 0 ) { 
                this.optAscending1.Enabled = false; 
                this.optDescending1.Enabled = false; 
                cboColumn2.SelectedIndex = 0; 
                cboColumn2.Enabled = false; 
            } 
            else { 
                this.optAscending1.Enabled = true; 
                this.optDescending1.Enabled = true; 
               cboColumn2.Enabled = true; 
                if ( cboColumn2.SelectedIndex == -1 ) { 
                    cboColumn2.SelectedIndex = 0; 
                } 
            } 
        } 
          
        private void cboColumn2_SelectedItemChanged( System.Object sender, System.EventArgs e ) { 
            if ( cboColumn2.SelectedIndex == 0 ) { 
                this.optAscending2.Enabled = false; 
                this.optDescending2.Enabled = false; 
                cboColumn3.SelectedIndex = 0; 
                cboColumn3.Enabled = false; 
            } 
            else { 
                this.optAscending2.Enabled = true; 
                this.optDescending2.Enabled = true; 
                cboColumn3.Enabled = true; 
                if ( cboColumn3.SelectedIndex == -1 ) { 
                    cboColumn3.SelectedIndex = 0; 
                } 
            } 
        } 

        private void cboColumn3_SelectedItemChanged( System.Object sender, System.EventArgs e ) { 
            if ( cboColumn3.SelectedIndex == 0 ) { 
                this.optAscending3.Enabled = false; 
                this.optDescending3.Enabled = false; 
            } 
            else { 
                this.optAscending3.Enabled = true; 
                this.optDescending3.Enabled = true; 
            } 
        } 
        
        private void btnClear_Click( System.Object sender, System.EventArgs e ) { 
            cboColumn0.SelectedIndex = 0; 
        } 

    

   
        

    } 
    

} 
