using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for Assembly.
	/// </summary>
    public class Assembly : IDIGITALTEKGRID.DataForm
	{
        private IDIGITALTEKGRIDCONTROL.Assembly assembly1;

        private System.ComponentModel.IContainer components = null;

		public Assembly()
		{
			//
			// Required for Windows Form Designer support
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assembly));
            this.assembly1 = new IDIGITALTEKGRIDControl.Assembly();
            this.SuspendLayout();
// 
// assembly1
// 
            this.assembly1.Location = new System.Drawing.Point(0, 0);
            this.assembly1.Name = "assembly1";
            this.assembly1.Size = new System.Drawing.Size(563, 345);
            this.assembly1.TabIndex = 0;
// 
// Assembly
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.assembly1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Assembly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.assembly1, 0);
            this.ResumeLayout(false);

        }
		#endregion


        public IDIGITALTEKGRID.AssemblyMDI assembly = new IDIGITALTEKGRID.AssemblyMDI();

		public void CreateAssembly()
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.assembly1.Assembly_Load();
            this.Show();
		}
		public void CreateNewAssembly( IDIGITALTEKGRID.AssemblyMDI  _assembly)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.assembly = _assembly;
            this.assembly1.Assembly_Load();
            this.Show();
		}
		public void CreateAssembly( IDIGITALTEKGRID.AssemblyMDI  _assembly)
		{
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.assembly = _assembly;
            this.assembly1.Assembly_Load();
            this.Show();
		}
	 
		public void Edit( IDIGITALTEKGRID.AssemblyData  _formAssembly,  IDIGITALTEKGRID.AssemblyMDI  _assembly ) 
		{
            this.assembly1.Assembly_Load();
            
            this.assembly1.txtAssemblyID.Text  =_formAssembly.AssemblyID.ToString();
			this.assembly1.txtDescription.Text   =_formAssembly.Description;
            this.assembly1.dlDivision.Text = _formAssembly.Division;
            this.assembly1.dlDivisionCost.Text = _formAssembly.DivisionCost;
            this.assembly1.txtMemo.Text =  _formAssembly.Memo;
			//this.assembly1.imgPhotoCAD.ToString() = _formAssembly.PhotoCad;
			//this.assembly1.imgPhotoImage.ToString() =  _formAssembly.PhotoImage;
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.assembly = _assembly;			
			this.Show(); 
		}

        protected IDIGITALTEKGRID.AssemblyData FormAssembly = new AssemblyData();
        protected IDIGITALTEKGRID.AssemblyDataProvider DataAssembly = new AssemblyDataProvider();

		public override void InsertData() 
		{



            if (this.assembly1.dlDivision.SelectedIndex != -1)
            {
                FormAssembly.Division = this.assembly1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.Division = this.assembly1.dlDivision.Text;
            }

            if (this.assembly1.dlDivisionCost.SelectedIndex != -1)
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.Text;
            }

            try
            {
                FormAssembly.AssemblyID = Convert.ToInt32(this.assembly1.txtAssemblyID.Text);
            }
            catch { }

            FormAssembly.Description = this.assembly1.txtDescription.Text;
            FormAssembly.Memo = this.assembly1.txtMemo.Text;
            FormAssembly.PhotoCad = null;
            FormAssembly.PhotoImage = null;


            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			DataAssembly.add(FormAssembly);	
		} 

		public override void UpdateData() 
		{

            if (this.assembly1.dlDivision.SelectedIndex != -1)
            {
                FormAssembly.Division = this.assembly1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.Division = this.assembly1.dlDivision.Text;
            }

            if (this.assembly1.dlDivisionCost.SelectedIndex != -1)
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.Text;
            }

            try
            {
                FormAssembly.AssemblyID = Convert.ToInt32(this.assembly1.txtAssemblyID.Text);
            }
            catch { }
			
			FormAssembly.Description = this.assembly1.txtDescription.Text;
			FormAssembly.Memo = this.assembly1.txtMemo.Text;
			FormAssembly.PhotoCad = null ;
			FormAssembly.PhotoImage = null ;
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			DataAssembly.update(FormAssembly);	
		
		} 
		public override void CancelData() 
		{ 	
			this.assembly1.txtDescription.Text = "";
			this.assembly1.dlDivision.Text = "";
			this.assembly1.dlDivisionCost.Text = "";
			this.assembly1.txtMemo.Text = "";
		
		} 

		public override void DeleteData() 
		{

            if (this.assembly1.dlDivision.SelectedIndex != -1)
            {
                FormAssembly.Division = this.assembly1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.Division = this.assembly1.dlDivision.Text;
            }

            if (this.assembly1.dlDivisionCost.SelectedIndex != -1)
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormAssembly.DivisionCost = this.assembly1.dlDivisionCost.Text;
            }

            try
            {
                FormAssembly.AssemblyID = Convert.ToInt32(this.assembly1.txtAssemblyID.Text);
            }
            catch { }

            FormAssembly.Description = this.assembly1.txtDescription.Text;
            FormAssembly.Memo = this.assembly1.txtMemo.Text;
            FormAssembly.PhotoCad = null;
            FormAssembly.PhotoImage = null;

            IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Delete;
			DataAssembly.delete(FormAssembly);
		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;

			if(this.assembly1.txtDescription.Text.Length ==0)valide = false;
		
			if(this.assembly1.dlDivision.Text.Length ==0)valide = false;
			if(this.assembly1.dlDivisionCost.Text.Length ==0)valide = false;
			return valide; 	
		}



        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );

            try
            {
                foreach (Form item in this.assembly.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }
                this.assembly.MdiParent.Refresh();
            }
            catch { }

          

            _DivisionDataProvider.selectAssembly(IDIGITALTEKGRID.Builder.lstAssemblyDivision);
		
		} 


	
		
	}
}
