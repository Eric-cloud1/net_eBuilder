using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using EstimateBuilder;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for TakeOff.
	/// </summary>
	public class TakeOff : EstimateBuilder.DataForm
	{
        private EstimateBuilderControl.TakeOff takeOff1;

        private System.ComponentModel.IContainer components = null;

		public TakeOff()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeOff));
            this.takeOff1 = new EstimateBuilderControl.TakeOff();
            this.SuspendLayout();
// 
// takeOff1
// 
            this.takeOff1.BackColor = System.Drawing.SystemColors.Control;
            this.takeOff1.Location = new System.Drawing.Point(0, 0);
            this.takeOff1.Name = "takeOff1";
            this.takeOff1.Size = new System.Drawing.Size(575, 345);
            this.takeOff1.TabIndex = 0;
// 
// TakeOff
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.takeOff1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "TakeOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.takeOff1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		public  EstimateBuilder.TakeoffMDI  takeOff = new EstimateBuilder.TakeoffMDI();
		protected EstimateBuilder.TakeOffData FormTakeOff = new TakeOffData();

        //TODO: Create takeoff as owned by Main Form
		public void CreateTakeOff()
		{

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.takeOff1.TakeOff_Load();
            this.Show();
		}

		public void CreateNewTakeOff( EstimateBuilder.TakeoffMDI  _takeOff)
		{

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.takeOff = _takeOff;
            this.takeOff1.TakeOff_Load();
            
            this.takeOff1.txtTakeOff.Text = "0";
            this.Show();
		}

		public void CreateTakeOff( EstimateBuilder.TakeoffMDI  _takeOff)
		{

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.takeOff = _takeOff;
            this.takeOff1.TakeOff_Load();
            this.Show();
		}

		public void Edit( EstimateBuilder.TakeOffData  _formTakeOff,  EstimateBuilder.TakeoffMDI  _takeOff ) 
		{
            this.takeOff1.TakeOff_Load();
            
            if(this.takeOff1.chkActive.Checked ==true)
			{_formTakeOff.Active = true; }
			else{_formTakeOff.Active = false;};

			this.takeOff1.txtDescription.Text =  _formTakeOff.Description;
			this.takeOff1.txtNote.Text = _formTakeOff.Memo;
            this.takeOff1.txtTakeOffID.Text = _formTakeOff.TakeOffID.ToString();

            this.takeOff1.dlDivision.Text =  _formTakeOff.Division;
			this.takeOff1.dlDivisionCost.Text = _formTakeOff.DivisionCost;
			this.takeOff1.dlDivisionPrint.Text = _formTakeOff.DivisionPrint;
			this.takeOff1.dlInput.Text = _formTakeOff.Input;
			this.takeOff1.dlLocation.Text = _formTakeOff.Location;
			this.takeOff1.dlMethod.Text = _formTakeOff.Method;
            this.takeOff1.dlBuildingType.Text = _formTakeOff.BuildingType;

   
            this.takeOff1.dlSaveJob.Text = "";

            this.takeOff1.txtTakeOff.Text = _formTakeOff.TakeOff.ToString();
			this.takeOff1.dlUnits.Text =  _formTakeOff.Units;

			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.takeOff = _takeOff;	
			this.Show(); 
		}

           

	
		public override void InsertData() 
		{

            if (this.takeOff1.chkActive.Checked == true)
            { FormTakeOff.Active = true; }
            else { FormTakeOff.Active = false; };

            FormTakeOff.TakeOffID = Convert.ToInt32(this.takeOff1.txtTakeOffID.Text);
            FormTakeOff.JobTakeOffID = FormTakeOff.JobID + "-" + FormTakeOff.TakeOffID;
            FormTakeOff.Description = this.takeOff1.txtDescription.Text;
            FormTakeOff.Memo = this.takeOff1.txtNote.Text;

            try
            {
                FormTakeOff.TakeOff = Convert.ToDecimal(this.takeOff1.txtTakeOff.Text);
            }
            catch { }


            if (this.takeOff1.dlSaveJob.SelectedIndex != -1)
            {
                FormTakeOff.JobID = Convert.ToInt32(this.takeOff1.dlSaveJob.SelectedValue);
            }
            else
            {
                FormTakeOff.JobID = 0;
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.Text;
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.Text;
            }

            if (this.takeOff1.dlDivisionCost.SelectedIndex != -1)
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.Text;
            }

            if (this.takeOff1.dlDivisionPrint.SelectedIndex != -1)
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.Text;
            }

            if (this.takeOff1.dlInput.SelectedIndex != -1)
            {
                FormTakeOff.Input = this.takeOff1.dlInput.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Input = this.takeOff1.dlInput.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.Text;
            }

            if (this.takeOff1.dlUnits.SelectedIndex != -1)
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.Text;
            }
            if (FormTakeOff.JobID != 0)
            {
                EstimateBuilder.ApplicationBuilder.TakeOffDataSource.add(FormTakeOff, FormTakeOff.JobID.ToString());
            }
                     EstimateBuilder.ApplicationBuilder.TakeOffDataSource.add(FormTakeOff);

        } 

		public override void UpdateData() 
		{
            if (this.takeOff1.chkActive.Checked == true)
            { FormTakeOff.Active = true; }
            else { FormTakeOff.Active = false; };

            FormTakeOff.TakeOffID = Convert.ToInt32(this.takeOff1.txtTakeOffID.Text);
            FormTakeOff.JobTakeOffID = FormTakeOff.JobID + "-" + FormTakeOff.TakeOffID;
            FormTakeOff.Description = this.takeOff1.txtDescription.Text;
            FormTakeOff.Memo = this.takeOff1.txtNote.Text;

            try
            {
                FormTakeOff.TakeOff = Convert.ToDecimal(this.takeOff1.txtTakeOff.Text);
            }
            catch { }

            if (this.takeOff1.dlSaveJob.SelectedIndex != -1)
            {
                FormTakeOff.JobID = Convert.ToInt32(this.takeOff1.dlSaveJob.SelectedValue);
            }
            else
            {
                FormTakeOff.JobID = 0;
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.Text;
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.Text;
            }

            if (this.takeOff1.dlDivisionCost.SelectedIndex != -1)
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.Text;
            }

            if (this.takeOff1.dlDivisionPrint.SelectedIndex != -1)
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.Text;
            }

            if (this.takeOff1.dlInput.SelectedIndex != -1)
            {
                FormTakeOff.Input = this.takeOff1.dlInput.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Input = this.takeOff1.dlInput.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.Text;
            }

            if (this.takeOff1.dlUnits.SelectedIndex != -1)
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.Text;
            }
			
             EstimateBuilder.ApplicationBuilder.TakeOffDataSource.update(FormTakeOff); 
       
        } 

		public override void CancelData() 
		{ 
			this.takeOff1.dlBuildingType.Text =  "";
			this.takeOff1.txtDescription.Text =   "";
			this.takeOff1.chkActive.Checked = false;		
			this.takeOff1.txtNote.Text =   "";
			this.takeOff1.dlDivision.Text =    "";		
			this.takeOff1.dlDivisionCost.Text =   "";
			this.takeOff1.dlDivisionPrint.Text =   "";
			this.takeOff1.dlInput.Text =  "";
			this.takeOff1.dlLocation.Text =   "";
			this.takeOff1.dlMethod.Text =   "";
			this.takeOff1.dlUnits.Text =  "";	
		
			this.takeOff1.txtTakeOff.Text =   "";			
		} 
		public override void DeleteData() 
		{
            if (this.takeOff1.chkActive.Checked == true)
            { FormTakeOff.Active = true; }
            else { FormTakeOff.Active = false; };

            FormTakeOff.TakeOffID = Convert.ToInt32(this.takeOff1.txtTakeOffID.Text);
            FormTakeOff.JobTakeOffID = FormTakeOff.JobID + "-" + FormTakeOff.TakeOffID;
            FormTakeOff.Description = this.takeOff1.txtDescription.Text;
            FormTakeOff.Memo = this.takeOff1.txtNote.Text;

            try
            {
                FormTakeOff.TakeOff = Convert.ToDecimal(this.takeOff1.txtTakeOff.Text);
            }
            catch { }

            if (this.takeOff1.dlSaveJob.SelectedIndex != -1)
            {
                FormTakeOff.JobID = Convert.ToInt32(this.takeOff1.dlSaveJob.SelectedValue);
            }
            else
            {
                FormTakeOff.JobID = Convert.ToInt32(this.takeOff1.dlSaveJob.Text);
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.BuildingType = this.takeOff1.dlBuildingType.Text;
            }

            if (this.takeOff1.dlBuildingType.SelectedIndex != -1)
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Division = this.takeOff1.dlDivision.Text;
            }

            if (this.takeOff1.dlDivisionCost.SelectedIndex != -1)
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionCost = this.takeOff1.dlDivisionCost.Text;
            }

            if (this.takeOff1.dlDivisionPrint.SelectedIndex != -1)
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.DivisionPrint = this.takeOff1.dlDivisionPrint.Text;
            }

            if (this.takeOff1.dlInput.SelectedIndex != -1)
            {
                FormTakeOff.Input = this.takeOff1.dlInput.SelectedValue.ToString();
            }
            else
            {
                FormTakeOff.Input = this.takeOff1.dlInput.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Location = this.takeOff1.dlLocation.Text;
            }

            if (this.takeOff1.dlLocation.SelectedIndex != -1)
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Method = this.takeOff1.dlMethod.Text;
            }

            if (this.takeOff1.dlUnits.SelectedIndex != -1)
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.SelectedValue.ToString();
            }
            else
            {

                FormTakeOff.Units = this.takeOff1.dlUnits.Text;
            }
			
			EstimateBuilder.ApplicationBuilder.TakeOffDataSource.delete(FormTakeOff);
		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;
			if(this.takeOff1.dlBuildingType.Text.Length ==0)valide = false;
			if(this.takeOff1.txtDescription.Text.Length ==0)valide = false;
			if(this.takeOff1.dlDivision.Text.Length ==0)valide = false;
			if(this.takeOff1.dlDivisionCost.Text.Length ==0)valide = false;
			if(this.takeOff1.dlDivisionPrint.Text.Length ==0)valide = false;
			if(this.takeOff1.dlInput.Text.Length ==0)valide = false;
			if(this.takeOff1.dlLocation.Text.Length ==0)valide = false;
			if(this.takeOff1.dlMethod.Text.Length ==0)valide = false;
			if(this.takeOff1.txtTakeOff.Text.Length ==0)valide = false;
			if(this.takeOff1.dlMethod.Text.Length ==0)valide = false;
			if(this.takeOff1.dlUnits.Text.Length ==0)valide = false;
			return valide; 
		}	
	


		
		public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e );
            try
            {
                foreach (Form item in this.takeOff.MdiParent.MdiChildren)
                {
                    item.Refresh();
                }


                this.takeOff.Refresh();
            }
            catch { }


            _DivisionDataProvider.selectTakeOff(EstimateBuilder.Builder.lstTakeOffDivision);
		
		} 

	}
}
