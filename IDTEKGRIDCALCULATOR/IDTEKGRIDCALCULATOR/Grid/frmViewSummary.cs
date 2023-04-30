using Janus.Windows.GridEX; 
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace IDIGITALTEKGRID
{
	public class frmViewSummary : System.Windows.Forms.Form 
	{ 
	
		#region '" Windows Form Designer generated code "' 

		public frmViewSummary() : base() 
		{ 

			InitializeComponent(); 
		} 


		protected override void Dispose( bool disposing ) 
		{ 
			if ( disposing ) 
			{ 
				if ( !( ( components == null ) ) ) 
				{ 
					components.Dispose(); 
				} 
			} 
			base.Dispose( disposing ); 
		} 
    


		private System.ComponentModel.IContainer components = null; 


		internal Janus.Windows.EditControls.UIGroupBox grbBackground; 
		internal  Janus.Windows.EditControls.UIButton btnCancel; 
		internal  Janus.Windows.EditControls.UIButton btnOK; 
		internal  Janus.Windows.EditControls.UIGroupBox GroupBox1; 
		internal  Janus.Windows.EditControls.UIButton btnAutoFormatting; 
		internal  System.Windows.Forms.Label lblFormat; 
		internal  Janus.Windows.EditControls.UIButton btnFormat; 
		internal  System.Windows.Forms.Label lblSort; 
		internal Janus.Windows.EditControls.UIButton btnSort; 
		internal  System.Windows.Forms.Label lblGroupBy; 
		internal  Janus.Windows.EditControls.UIButton btnGroupBy; 
		internal  System.Windows.Forms.Label lblFields; 
		internal Janus.Windows.EditControls.UIButton btnFields; 
		internal System.Windows.Forms.Label Label2; 
		[ System.Diagnostics.DebuggerStepThrough() ]
		private void InitializeComponent() 
		{ 
			this.grbBackground = new Janus.Windows.EditControls.UIGroupBox(); 
			this.btnCancel = new Janus.Windows.EditControls.UIButton(); 
			this.btnOK = new Janus.Windows.EditControls.UIButton(); 
			this.GroupBox1 = new Janus.Windows.EditControls.UIGroupBox(); 
			this.btnAutoFormatting = new Janus.Windows.EditControls.UIButton(); 
			this.lblFormat = new System.Windows.Forms.Label(); 
			this.btnFormat = new Janus.Windows.EditControls.UIButton(); 
			this.lblSort = new System.Windows.Forms.Label(); 
			this.btnSort = new Janus.Windows.EditControls.UIButton(); 
			this.lblGroupBy = new System.Windows.Forms.Label(); 
			this.btnGroupBy = new Janus.Windows.EditControls.UIButton(); 
			this.lblFields = new System.Windows.Forms.Label(); 
			this.btnFields = new Janus.Windows.EditControls.UIButton(); 
			this.Label2 = new System.Windows.Forms.Label(); 
			( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).BeginInit(); 
			this.grbBackground.SuspendLayout(); 
			( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).BeginInit(); 
			this.GroupBox1.SuspendLayout(); 
			this.SuspendLayout(); 

			this.grbBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel; 
			this.grbBackground.Controls.AddRange( new System.Windows.Forms.Control[] { this.btnCancel, this.btnOK, this.GroupBox1 } ); 
			this.grbBackground.Dock = System.Windows.Forms.DockStyle.Fill; 
			this.grbBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None; 
			this.grbBackground.Name = "grbBackground"; 
			this.grbBackground.Size = new System.Drawing.Size( 584, 214 ); 
			this.grbBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 
			 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel; 
			this.btnCancel.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
			this.btnCancel.Location = new System.Drawing.Point( 496, 48 ); 
			this.btnCancel.Name = "btnCancel"; 
			this.btnCancel.Size = new System.Drawing.Size( 80, 24 ); 
			this.btnCancel.TabIndex = 11; 
			this.btnCancel.Text = "Cancel"; 
			this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK; 
			this.btnOK.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
			this.btnOK.Location = new System.Drawing.Point( 496, 16 ); 
			this.btnOK.Name = "btnOK"; 
			this.btnOK.Size = new System.Drawing.Size( 80, 24 ); 
			this.btnOK.TabIndex = 10; 
			this.btnOK.Text = "OK"; 
			this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.GroupBox1.BackColor = System.Drawing.Color.Transparent; 
			this.GroupBox1.Controls.AddRange( new System.Windows.Forms.Control[] { this.btnAutoFormatting, this.lblFormat, this.btnFormat, this.lblSort, this.btnSort, this.lblGroupBy, this.btnGroupBy, this.lblFields, this.btnFields, this.Label2 } ); 
			this.GroupBox1.Location = new System.Drawing.Point( 8, 8 ); 
			this.GroupBox1.Name = "GroupBox1"; 
			this.GroupBox1.Size = new System.Drawing.Size( 480, 197 ); 
			this.GroupBox1.Text = "Description"; 
			this.GroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003; 


			this.btnAutoFormatting.Location = new System.Drawing.Point( 8, 164 ); 
			this.btnAutoFormatting.Name = "btnAutoFormatting"; 
			this.btnAutoFormatting.Size = new System.Drawing.Size( 128, 24 ); 
			this.btnAutoFormatting.TabIndex = 8; 
			this.btnAutoFormatting.Text = "Automatic Formatting..."; 
			this.btnAutoFormatting.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.lblFormat.Location = new System.Drawing.Point( 143, 126 ); 
			this.lblFormat.Name = "lblFormat"; 
			this.lblFormat.Size = new System.Drawing.Size( 327, 28 ); 
			this.lblFormat.TabIndex = 7; 
			this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
			 
			this.btnFormat.Location = new System.Drawing.Point( 8, 128 ); 
			this.btnFormat.Name = "btnFormat"; 
			this.btnFormat.Size = new System.Drawing.Size( 128, 24 ); 
			this.btnFormat.TabIndex = 6; 
			this.btnFormat.Text = "Format..."; 
			this.btnFormat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.lblSort.Location = new System.Drawing.Point( 143, 90 ); 
			this.lblSort.Name = "lblSort"; 
			this.lblSort.Size = new System.Drawing.Size( 327, 28 ); 
			this.lblSort.TabIndex = 5; 
			this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 
 
			this.btnSort.Location = new System.Drawing.Point( 8, 92 ); 
			this.btnSort.Name = "btnSort"; 
			this.btnSort.Size = new System.Drawing.Size( 128, 24 ); 
			this.btnSort.TabIndex = 4; 
			this.btnSort.Text = "Sort..."; 
			this.btnSort.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 


			this.lblGroupBy.Location = new System.Drawing.Point( 143, 54 ); 
			this.lblGroupBy.Name = "lblGroupBy"; 
			this.lblGroupBy.Size = new System.Drawing.Size( 327, 28 ); 
			this.lblGroupBy.TabIndex = 3; 
			this.lblGroupBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 

			this.btnGroupBy.Location = new System.Drawing.Point( 8, 56 ); 
			this.btnGroupBy.Name = "btnGroupBy"; 
			this.btnGroupBy.Size = new System.Drawing.Size( 128, 24 ); 
			this.btnGroupBy.TabIndex = 2; 
			this.btnGroupBy.Text = "Group By..."; 
			this.btnGroupBy.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.lblFields.Location = new System.Drawing.Point( 143, 18 ); 
			this.lblFields.Name = "lblFields"; 
			this.lblFields.Size = new System.Drawing.Size( 327, 28 ); 
			this.lblFields.TabIndex = 1; 
			this.lblFields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; 

			this.btnFields.Location = new System.Drawing.Point( 8, 20 ); 
			this.btnFields.Name = "btnFields"; 
			this.btnFields.Size = new System.Drawing.Size( 128, 24 ); 
			this.btnFields.TabIndex = 0; 
			this.btnFields.Text = "Fields..."; 
			this.btnFields.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003; 

			this.Label2.Location = new System.Drawing.Point( 143, 162 ); 
			this.Label2.Name = "Label2"; 
			this.Label2.Size = new System.Drawing.Size( 327, 28 ); 
			this.Label2.TabIndex = 9; 
			this.Label2.Text = "Condition font and color formatting."; 
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.AutoScaleDimensions = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size( 584, 214 ); 
			this.Controls.AddRange( new System.Windows.Forms.Control[] { this.grbBackground } ); 
			this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte( 0 ) ); 
			this.Name = "frmViewSummary"; 
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; 
			this.Text = "View Summary"; 
			( ( System.ComponentModel.ISupportInitialize )( this.grbBackground ) ).EndInit(); 
			this.grbBackground.ResumeLayout( false ); 
			( ( System.ComponentModel.ISupportInitialize )( this.GroupBox1 ) ).EndInit(); 
			this.GroupBox1.ResumeLayout( false ); 
			this.ResumeLayout( false ); 

			btnFields.Click += new System.EventHandler( btnFields_Click ); 

			btnGroupBy.Click += new System.EventHandler( btnGroupBy_Click ); 

			btnSort.Click += new System.EventHandler( btnSort_Click ); 

			btnFormat.Click += new System.EventHandler( btnFormat_Click ); 

			btnOK.Click += new System.EventHandler( btnOK_Click ); 
 
			btnAutoFormatting.Click += new System.EventHandler( btnAutoFormatting_Click ); 
		} 
        

		#endregion 
		
	
		private GridEX mGridEX; 
		private IDIGITALTEKGRID.Grid mView; 
		public Object ShowDialog( GridEX grid, Form parent, IDIGITALTEKGRID.Grid GridEXView ) 
		{ 
			mGridEX = grid; 
			mView = GridEXView; 
			SetFieldsLabel(); 
			SetGroupByLabel(); 
			SetSortLabel(); 
			SetFormatLabel(); 
			if ( grid.RootTable.CellLayoutMode == CellLayoutMode.UseColumnSets ) 
					   { 
						  this.btnFields.Enabled = false; 
					   } 
			if ( mGridEX.View != Janus.Windows.GridEX.View.TableView ) 
					   { 
						  this.btnGroupBy.Enabled = false; 
					   } 
			return this.ShowDialog( parent ); 
		} 
        
		private void SetFieldsLabel() 
		{ 
			System.Text.StringBuilder strFields = new System.Text.StringBuilder(); 
			GridEXColumn column = null; 
			int i = 0; 
			for ( i=0; i<=mGridEX.RootTable.Columns.Count - 1; i++ ) 
					   { 
						   column = mGridEX.RootTable.Columns.GetColumnInPosition( i ); 
						   if ( !( ( column == null ) ) && column.Visible ) 
									  { 
										  if ( strFields.Length > 0 ) 
													 { 
														strFields.Append( ", " ); 
													 } 
										  strFields.Append( IDIGITALTEKGRID.Grid.GetColumnFriendlyName( column ) ); 
									  } 
					   } 
			this.lblFields.Text = strFields.ToString(); 
			if ( mGridEX.RootTable.CellLayoutMode == CellLayoutMode.UseColumnSets ) 
					   { 
						   this.btnFields.Enabled = false; 
					   } 
		} 
        
		private void SetGroupByLabel() 
		{ 
			
			System.Text.StringBuilder strFields = new System.Text.StringBuilder(); 
			GridEXGroup group = null; 
			if ( mGridEX.RootTable.Groups.Count == 0 ) 
					   { 
						   this.lblGroupBy.Text = "None"; 
					   } 
					   else 
					   { 
						   foreach ( Janus.Windows.GridEX.GridEXGroup transTemp0 in mGridEX.RootTable.Groups ) 
									  { 
										  group = transTemp0; 
										  if ( strFields.Length > 0 ) 
													 { 
														 strFields.Append( ", " ); 
													 } 
										  strFields.Append(IDIGITALTEKGRID.Grid.GetColumnFriendlyName( group.Column ) ); 
										  if ( System.Convert.ToInt64( group.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ) 
													 { 
														 strFields.Append( " (Ascending)" ); 
													 } 
													 else 
													 { 
														 strFields.Append( " (Descending)" ); 
													 } 
									  }
						   this.lblGroupBy.Text = strFields.ToString(); 
					   } 
		} 
        
		private void SetSortLabel() 
		{ 
			System.Text.StringBuilder strFields = new System.Text.StringBuilder(); 
			GridEXSortKey sortKey = null; 
			if ( mGridEX.RootTable.SortKeys.Count == 0 ) 
					   { 
						   this.lblSort.Text = "None"; 
					   } 
					   else 
					   { 
						   foreach ( Janus.Windows.GridEX.GridEXSortKey transTemp1 in mGridEX.RootTable.SortKeys ) 
									  { 
										  sortKey = transTemp1; 
										  if ( strFields.Length > 0 ) 
													 { 
														strFields.Append( ", " ); 
													 } 
										  strFields.Append( IDIGITALTEKGRID.Grid.GetColumnFriendlyName( sortKey.Column ) ); 
										  if ( System.Convert.ToInt64( sortKey.SortOrder ) == System.Convert.ToInt64( Janus.Windows.GridEX.SortOrder.Ascending ) ) 
													 { 
														 strFields.Append( " (Ascending)" ); 
													 } 
													 else 
													 { 
														 strFields.Append( " (Descending)" ); 
													 } 
									  }
						   this.lblSort.Text = strFields.ToString(); 
					   } 
		} 
        
		private void SetFormatLabel() 
		{ 
			if ( mGridEX.View == Janus.Windows.GridEX.View.TableView ) 
					   { 
						  lblFormat.Text = "Fonts and other Table View settings."; 
					   } 
					   else 
					   { 
						   lblFormat.Text = "Fonts and other Card View settings."; 
					   } 
		} 
        
		private void btnFields_Click( System.Object sender, System.EventArgs e ) 
		{ 
			mView.ShowFieldsDialog(); 
			SetFieldsLabel(); 
		} 
        
	
		private void btnGroupBy_Click( System.Object sender, System.EventArgs e ) 
		{ 
			mView.ShowGroupByDialog(); 
			SetGroupByLabel(); 
		} 
        

		private void btnSort_Click( System.Object sender, System.EventArgs e ) 
		{ 
			mView.ShowSortDialog(); 
			SetSortLabel(); 
		} 
        
	
		private void btnFormat_Click( System.Object sender, System.EventArgs e ) 
		{ 
			mView.ShowFormatViewDialog(); 
		} 
        
		
		private void btnOK_Click( System.Object sender, System.EventArgs e ) 
		{ 
			this.Close(); 
		} 
        

		private void btnAutoFormatting_Click( System.Object sender, System.EventArgs e ) 
		{ 
			mView.ShowFormatConditionsDialog(); 
		} 
        
	}
}
