#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace EstimateBuilder
{
    partial class frmSaveTakeOff : Form
    {
        

        public frmSaveTakeOff()
        {
            InitializeComponent();
            EstimateBuilder.ListDataProvider list = new ListDataProvider();

            this.dlProject.DataSource = list.JobIDJob();
            this.dlProject.DisplayMember = "Job";
            this.dlProject.ValueMember = "JobID";
            this.dlProject.SelectedValue = 0;
        }


        void btCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        protected  bool _save = false;
        protected  EstimateBuilder.TakeoffMDI takeOffMDI = new EstimateBuilder.TakeoffMDI();
        protected EstimateBuilder.QuantityMDI quantityMDI = new EstimateBuilder.QuantityMDI();


        void btOK_Click(object sender, System.EventArgs e)
        {
            EstimateBuilder.ApplicationBuilder.SaveJobId = this.dlProject.SelectedValue.ToString();      
              
            if (takeOffMDI != null)
            {
            

               _save = takeOffMDI.SaveData();
               
            }

            if (quantityMDI != null)
            {
                quantityMDI.SaveData();
                _save = true;
            }
            if (_save == true)
            {
                EstimateBuilder.ApplicationBuilder.SaveJobId = null;
                this.Close();
            }
        }

        public DialogResult ShowDialog(Form parent, EstimateBuilder.TakeoffMDI _takeOffMDI, EstimateBuilder.QuantityMDI _quantityMDI)
        {

            EstimateBuilder.ApplicationBuilder.SaveJobId = null;
            takeOffMDI = _takeOffMDI;
              quantityMDI = _quantityMDI;
        
            return this.ShowDialog(parent);
        }

       


        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
        }




    }
}