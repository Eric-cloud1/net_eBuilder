/* L:1 */using Janus.Windows.GridEX; 
/* L:2 */using Janus.Windows.EditControls; 
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder {
    public class frmGroupBy : System.Windows.Forms.Form { 
     
        #region '" Windows Form Designer generated code "' 

        public frmGroupBy() : base() { 

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
        

        private System.ComponentModel.IContainer components  = null; 
  
       internal  Janus.Windows.EditControls.UIComboBox cboExpandCollapse; 
       internal  System.Windows.Forms.Label Label1; 
       internal  Janus.Windows.EditControls.UIButton btnClear; 
       internal  Janus.Windows.EditControls.UIButton btnCancel; 
       internal  Janus.Windows.EditControls.UIButton btnOK; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox4; 
       internal  Janus.Windows.EditControls.UIComboBox cboColumn3; 
       internal  Janus.Windows.EditControls.UIRadioButton optDescending3; 
       internal  Janus.Windows.EditControls.UIRadioButton optAscending3; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox3; 
       internal  Janus.Windows.EditControls.UIComboBox cboColumn2; 
       internal  Janus.Windows.EditControls.UIRadioButton optDescending2; 
       internal  Janus.Windows.EditControls.UIRadioButton optAscending2; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox2; 
       internal  Janus.Windows.EditControls.UIComboBox cboColumn1; 
       internal  Janus.Windows.EditControls.UIRadioButton optDescending1; 
       internal  Janus.Windows.EditControls.UIRadioButton optAscending1; 
       internal  Janus.Windows.EditControls.UIGroupBox GroupBox1; 
       internal  Janus.Windows.EditControls.UIRadioButton optDescending0; 
       internal  Janus.Windows.EditControls.UIRadioButton optAscending0; 
       internal Janus.Windows.EditControls.UIComboBox cboColumn0; 
       internal Janus.Windows.EditControls.UIGroupBox grbBackground; 
        [ System.Diagnostics.DebuggerStepThrough() ]
        private void InitializeComponent() { 
            this.grbBackground = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboExpandCollapse = new Janus.Windows.EditControls.UIComboBox(); 
            this.Label1 = new System.Windows.Forms.Label(); 
            this.btnClear = new Janus.Windows.EditControls.UIButton(); 
            this.btnCancel = new Janus.Windows.EditControls.UIButton(); 
            this.btnOK = new Janus.Windows.EditControls.UIButton(); 
            this.GroupBox4 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn3 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending3 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending3 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.GroupBox3 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn2 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending2 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending2 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.GroupBox2 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.cboColumn1 = new Janus.Windows.EditControls.UIComboBox(); 
            this.optDescending1 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending1 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.GroupBox1 = new Janus.Windows.EditControls.UIGroupBox(); 
            this.optDescending0 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.optAscending0 = new Janus.Windows.EditControls.UIRadioButton(); 
            this.cboColumn0 = new Janus.Windows.EditControls.UIComboBox(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).BeginInit(); 
            this.grbBackground.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox4 ) ).BeginInit(); 
            this.GroupBox4.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox3 ) ).BeginInit(); 
            this.GroupBox3.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox2 ) ).BeginInit(); 
            this.GroupBox2.SuspendLayout(); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).BeginInit(); 
            this.GroupBox1.SuspendLayout(); 
            this.SuspendLayout(); 
 
            this.grbBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel; 
            this.grbBackground.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboExpandCollapse, this.Label1, this.btnClear, this.btnCancel, this.btnOK, this.GroupBox4, this.GroupBox3, this.GroupBox2, this.GroupBox1 } ); 
            this.grbBackground.Dock = System.Windows.Forms.DockStyle.Fill; 
            this.grbBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None; 
            this.grbBackground.Name = "grbBackground"; 
            this.grbBackground.Size = new System.Drawing.Size( 426, 304 ); 
            this.grbBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 

            this.cboExpandCollapse.Location = new System.Drawing.Point( 108, 276 ); 
            this.cboExpandCollapse.Name = "cboExpandCollapse"; 
            this.cboExpandCollapse.Size = new System.Drawing.Size( 192, 20 ); 
            this.cboExpandCollapse.TabIndex = 17; 
            this.cboExpandCollapse.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.Label1.AutoSize = true; 
            this.Label1.BackColor = System.Drawing.Color.Transparent; 
            this.Label1.Location = new System.Drawing.Point( 4, 280 ); 
            this.Label1.Name = "Label1"; 
            this.Label1.Size = new System.Drawing.Size( 93, 13 ); 
            this.Label1.TabIndex = 16; 
            this.Label1.Text = "Expand/Collapse:"; 
 
            this.btnClear.Location = new System.Drawing.Point( 336, 72 ); 
            this.btnClear.Name = "btnClear"; 
            this.btnClear.Size = new System.Drawing.Size( 84, 24 ); 
            this.btnClear.TabIndex = 15; 
            this.btnClear.Text = "Clear All"; 
            this.btnClear.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 
      
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel; 
            this.btnCancel.Location = new System.Drawing.Point( 336, 44 ); 
            this.btnCancel.Name = "btnCancel"; 
            this.btnCancel.Size = new System.Drawing.Size( 84, 24 ); 
            this.btnCancel.TabIndex = 14; 
            this.btnCancel.Text = "Cancel"; 
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK; 
            this.btnOK.Location = new System.Drawing.Point( 336, 16 ); 
            this.btnOK.Name = "btnOK"; 
            this.btnOK.Size = new System.Drawing.Size( 84, 24 ); 
            this.btnOK.TabIndex = 13; 
            this.btnOK.Text = "OK"; 
            this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

            this.GroupBox4.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox4.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn3, this.optDescending3, this.optAscending3 } ); 
            this.GroupBox4.Location = new System.Drawing.Point( 32, 208 ); 
            this.GroupBox4.Name = "GroupBox4"; 
            this.GroupBox4.Size = new System.Drawing.Size( 296, 58 ); 
            this.GroupBox4.Text = "Then By"; 
            this.GroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
 
            this.cboColumn3.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn3.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn3.Name = "cboColumn3"; 
            this.cboColumn3.Size = new System.Drawing.Size( 184, 20 ); 
            this.cboColumn3.TabIndex = 10; 
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
			
			
			this.GroupBox3.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox3.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn2, this.optDescending2, this.optAscending2 } ); 
            this.GroupBox3.Location = new System.Drawing.Point( 24, 142 ); 
            this.GroupBox3.Name = "GroupBox3"; 
            this.GroupBox3.Size = new System.Drawing.Size( 296, 56 ); 
            this.GroupBox3.Text = "Then By"; 
            this.GroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
 
            this.cboColumn2.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn2.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn2.Name = "cboColumn2"; 
            this.cboColumn2.Size = new System.Drawing.Size( 184, 20 ); 
            this.cboColumn2.TabIndex = 10; 
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

            this.GroupBox2.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox2.Controls.AddRange( new System.Windows.Forms.Control[] { this.cboColumn1, this.optDescending1, this.optAscending1 } ); 
            this.GroupBox2.Location = new System.Drawing.Point( 16, 74 ); 
            this.GroupBox2.Name = "GroupBox2"; 
            this.GroupBox2.Size = new System.Drawing.Size( 296, 58 ); 
            this.GroupBox2.Text = "Then By"; 
            this.GroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
 
            this.cboColumn1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn1.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn1.Name = "cboColumn1"; 
            this.cboColumn1.Size = new System.Drawing.Size( 184, 20 ); 
            this.cboColumn1.TabIndex = 10; 
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
 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent; 
            this.GroupBox1.Controls.AddRange( new System.Windows.Forms.Control[] { this.optDescending0, this.optAscending0, this.cboColumn0 } ); 
            this.GroupBox1.Location = new System.Drawing.Point( 8, 8 ); 
            this.GroupBox1.Name = "GroupBox1"; 
            this.GroupBox1.Size = new System.Drawing.Size( 296, 56 ); 
            this.GroupBox1.Text = "Group Items By"; 
            this.GroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 

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

            this.cboColumn0.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList; 
            this.cboColumn0.Location = new System.Drawing.Point( 8, 16 ); 
            this.cboColumn0.Name = "cboColumn0"; 
            this.cboColumn0.Size = new System.Drawing.Size( 184, 20 ); 
            this.cboColumn0.TabIndex = 9; 
            this.cboColumn0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size( 426, 304 ); 
            this.Controls.AddRange( new System.Windows.Forms.Control[] { this.grbBackground } ); 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; 
            this.Name = "frmGroupBy"; 
            this.Text = "Group By"; 
            ( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).EndInit(); 
            this.grbBackground.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox4 ) ).EndInit(); 
            this.GroupBox4.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox3 ) ).EndInit(); 
            this.GroupBox3.ResumeLayout( false ); 
            ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox2 ) ).EndInit(); 
           this.GroupBox2.ResumeLayout( false ); 
          ( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).EndInit(); 
           this.GroupBox1.ResumeLayout( false ); 
           this.ResumeLayout( false ); 

            cboColumn0.SelectedIndexChanged += new System.EventHandler( cboColumn0_SelectedItemChanged ); 
 
            cboColumn1.SelectedIndexChanged += new System.EventHandler( cboColumn1_SelectedItemChanged ); 

            cboColumn2.SelectedIndexChanged += new System.EventHandler( cboColumn2_SelectedItemChanged ); 

            cboColumn3.SelectedIndexChanged += new System.EventHandler( cboColumn3_SelectedItemChanged ); 
 
            btnClear.Click += new System.EventHandler( btnClear_Click ); 

            btnCancel.Click += new System.EventHandler( btnCancel_Click ); 

            btnOK.Click += new System.EventHandler( btnOK_Click ); 
        } 
        
        
        #endregion 
  
        public DialogResult ShowDialog( GridEX grid, Form parent ) { 
            GridEXGroup group = null; 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn0 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn1 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn2 ); 
            this.FillColumnList( grid.RootTable.Columns, this.cboColumn3 ); 
            this.cboExpandCollapse.Items.Add( "All Expanded" ); 
            this.cboExpandCollapse.Items.Add( "All Collapsed" ); 
            if ( grid.GroupMode == GroupMode.Collapsed ) { 
               cboExpandCollapse.SelectedIndex = 1; 
            } 
            else { 
                cboExpandCollapse.SelectedIndex = 0; 
            } 
            Janus.Windows.GridEX.GridEXGroupCollection transTemp0 = grid.RootTable.Groups;
            if ( transTemp0.Count == 0 ) { 
                SetGroup( null, true, cboColumn0, optAscending0, optDescending0 ); 
            } 
            else { 
               if ( transTemp0.Count >= 1 ) { 
                    group = transTemp0[ 0 ]; 
                    SetGroup( group.Column, ( System.Convert.ToInt64( group.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn0, optAscending0, optDescending0 ); 
                } 
                if ( transTemp0.Count >= 2 ) { 
                    group = transTemp0[ 1 ]; 
                    SetGroup( group.Column, ( System.Convert.ToInt64( group.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn1, optAscending1, optDescending1 ); 
                } 
                if ( transTemp0.Count >= 3 ) { 
                    group = transTemp0[ 2 ]; 
                    SetGroup( group.Column, ( System.Convert.ToInt64( group.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn2, optAscending2, optDescending2 ); 
                } 
                if ( transTemp0.Count >= 4 ) { 
                   group = transTemp0[ 3 ]; 
                    SetGroup( group.Column, ( System.Convert.ToInt64( group.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ), cboColumn3, optAscending3, optDescending3 ); 
                } 
            } 
            
            this.ShowDialog( parent ); 
            if ( this.DialogResult == DialogResult.OK ) { 
                grid.RootTable.Groups.Clear(); 
                CreateGroups( grid ); 
            } 
            return this.DialogResult; 
        } 
        
        private void CreateGroups( GridEX grid ) { 
           int groupsCount = 0; 
            if ( cboColumn3.SelectedIndex > 0 ) { 
                groupsCount = 4; 
            } 
            else if ( cboColumn2.SelectedIndex > 0 ) { 
                groupsCount = 3; 
            } 
            else if ( cboColumn1.SelectedIndex > 0 ) { 
               groupsCount = 2; 
            } 
            else if ( cboColumn0.SelectedIndex > 0 ) { 
                groupsCount = 1; 
            } 
            else { 
                groupsCount = 0; 
            } 
            GridEXGroup[] groups = new GridEXGroup[ groupsCount - 1 + 1 ]; 
            if ( groupsCount > 0 ) { 
                groups[ 0 ] = CreateGroup( ( ( Janus.Windows.GridEX.GridEXColumn )( cboColumn0.SelectedItem.Value ) ), optAscending0.Checked ); 
            } 
            if ( groupsCount > 1 ) { 
                groups[ 1 ] = CreateGroup( ( ( Janus.Windows.GridEX.GridEXColumn )( cboColumn1.SelectedItem.Value ) ), optAscending1.Checked ); 
            } 
            if ( groupsCount > 2 ) { 
                groups[ 2 ] = CreateGroup( ( ( Janus.Windows.GridEX.GridEXColumn )( cboColumn2.SelectedItem.Value ) ), optAscending2.Checked ); 
            } 
            if ( groupsCount > 3 ) { 
                groups[ 3 ] = CreateGroup( ( ( Janus.Windows.GridEX.GridEXColumn )( cboColumn3.SelectedItem.Value ) ), optAscending3.Checked ); 
            } 
            if ( cboExpandCollapse.SelectedIndex == 0 ) { 
                grid.GroupMode = GroupMode.Expanded; 
            } 
            else { 
                grid.GroupMode = GroupMode.Collapsed; 
            } 
            grid.RootTable.Groups.AddRange( groups ); 
        } 
        
        private GridEXGroup CreateGroup( GridEXColumn column, bool ascending ) { 
            GridEXGroup group = new GridEXGroup(); 
            group.Column = column; 
            if ( !( ascending ) ) { 
                group.SortOrder = ( ( Janus.Windows.GridEX.SortOrder )( Janus.Windows.GridEX.SortOrder.Descending ) ); 
            } 
            return group; 
        } 
        
        private void FillColumnList( GridEXColumnCollection columns, Janus.Windows.EditControls.UIComboBox combo ) { 
            GridEXColumn column = null; 
            int i = 0; 
           combo.DisplayMember = "Name"; 
           combo.Items.Clear(); 
           combo.Items.Add( "(None)", null ); 
            for ( i=1; i<=columns.Count - 1; i++ ) { 
                column = columns[ i ]; 
                if ( column.AllowGroup ) { 
                    combo.Items.Add( EstimateBuilder.Grid.GetColumnFriendlyName( column ), column ); 
                } 
            } 
        } 
        
        private void SetGroup( GridEXColumn column, bool ascending, UIComboBox combo, UIRadioButton optAscending, UIRadioButton optDescending ) { 
		combo.SelectedValue = column; 
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
        
       
        private void btnCancel_Click( System.Object sender, System.EventArgs e ) { 
           this.Close(); 
        } 
        
      
        private void btnOK_Click( System.Object sender, System.EventArgs e ) { 
            this.Close(); 
        } 

    } 
    
  
} 
