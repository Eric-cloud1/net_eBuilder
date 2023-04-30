using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for DataForm.
	/// </summary>
	public class DataForm : System.Windows.Forms.Form
	{
		private Janus.Windows.EditControls.UIButton btnCancel;
        private Janus.Windows.EditControls.UIButton btnOK;
        /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataForm(): base()
		{
			InitializeComponent();
			
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
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
            this.btnOK = new Janus.Windows.EditControls.UIButton();
            this.SuspendLayout();
// 
// btnCancel
// 
            this.btnCancel.Location = new System.Drawing.Point(488, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
// 
// btnOK
// 
            this.btnOK.Location = new System.Drawing.Point(408, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
// 
// DataForm
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(567, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.ResumeLayout(false);

        }
		#endregion


		#region ButtonClick
		public bool UpdateChanges() 
		{  
			try 
			{ 
				return ValidateData(); 
				
			} 
			catch ( Exception exc ) 
			{ 
				MessageBox.Show( exc.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Error ); 
				return false; 
			} 
		}



		private void btnOK_Click(object sender, System.EventArgs e)
		{

            if (! this.ValidateData() )
            {

				MessageBox.Show( "All fields are required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error ); 				
			
            }
     
            else
            {
                this.Close();
            }
        }

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Edit)
            {
               // DeleteData();
                IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Close;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

		IDIGITALTEKGRID.ApplicationBuilder _application = new ApplicationBuilder();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 
			DialogResult result = MessageBox.Show( "Do you want to save changes?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ); 
			if(IDIGITALTEKGRID.ApplicationBuilder.EditMode != DataFormEditMode.Close)
			{
				switch ( result ) 
				{
					case DialogResult.Yes:
						if(this.ValidateData())
						{
							if ( IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Edit) 
							{ 
								UpdateData() ;
							} 
							else if ( IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.AddNew) 
                            {
                                 			
								InsertData() ;
                                if (this.Name == "takeOff1")
                                {
                                    IDIGITALTEKGRID.Expression ExpressionDialog = new IDIGITALTEKGRID.Expression();
                                    ExpressionDialog.CreateExpression();
                                }
                            }
						}
						IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Close;
						break;
					case DialogResult.No:
						IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Close;
						break;
					case DialogResult.Cancel:
						e.Cancel = true; 
						CancelData();
						IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Close;
						break;
				}    
			}
		} 	
		#endregion


		public virtual void InsertData() 
		{ 	
	
		} 
		public virtual void UpdateData() 
		{ 		
		} 
		public virtual void CancelData() 
		{ 		
		} 
		public virtual void DeleteData() 
		{ 		
		} 
		public virtual bool ValidateData() 
		{  
			return true;
		} 

		
       
	
		}
}
