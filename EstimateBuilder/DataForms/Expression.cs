using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for Expression.
	/// </summary>
	public class Expression :  EstimateBuilder.frmLargeForm
	{
        private EstimateBuilderControl.Expression expression1;

        private System.ComponentModel.IContainer components = null;

		public Expression()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
	
			//
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expression));
            this.expression1 = new EstimateBuilderControl.Expression();
            this.SuspendLayout();
// 
// expression1
// 
            this.expression1.Location = new System.Drawing.Point(0, 0);
            this.expression1.Name = "expression1";
            this.expression1.Size = new System.Drawing.Size(563, 583);
            this.expression1.TabIndex = 0;
// 
// Expression
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(588, 621);
            this.Controls.Add(this.expression1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Expression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.Controls.SetChildIndex(this.expression1, 0);
            this.ResumeLayout(false);

        }
		#endregion

		public  EstimateBuilder.ExpressionMDI  expression = new EstimateBuilder.ExpressionMDI();

         

	
		protected EstimateBuilder.ExpressionData FormExpression = new ExpressionData();

        //TODO: Create expression as owned by Main Form
        public void CreateExpression()
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
            this.expression1.Expression_Load();
            this.Show();
		}

		public void CreateNewExpression( EstimateBuilder.ExpressionMDI  _expression)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
			this.expression = _expression;
            this.expression1.Expression_Load();
            this.Show();
		}

		public void CreateExpression( EstimateBuilder.ExpressionMDI  _expression)
		{
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
			this.expression = _expression;
            this.expression1.Expression_Load();
            this.Show();
		}

		public void Edit( EstimateBuilder.ExpressionData  _formExpression,  EstimateBuilder.ExpressionMDI  _expression ) 
		{
            this.expression1.Expression_Load();
            this.expression1.txtDescription.Text = _formExpression.Description;
            this.expression1.dlDivision.Text = _formExpression.Division;
            this.expression1.dlDivisionCost.Text = _formExpression.DivisionCost;   
            this.expression1.txtExpressionID.Text = _formExpression.Value;
            this.expression1.dlJob.SelectedValue = "0";
            this.expression1.dlBuildingType.Text = _formExpression.BuildingType;
            this.expression1.loadBuildingTypeJob(_formExpression.BuildingType);
            this.expression1.txtExpressionID.Text = _formExpression.ExpressionID.ToString();
			this.expression1.txtMemo.Text = _formExpression.Memo;
            this.expression1.txtExpression.Text = _formExpression.Value;
            this.expression1.dlAssembly.SelectedValue = _formExpression.AssemblyID ;
            this.expression1.dlUnit.Text = _formExpression.Unit;
            EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Edit;
            EstimateBuilder.ApplicationBuilder.SaveExpressionMode = SaveExpression.False;
            this.expression = _expression;	
			this.Show(); 
		}
	
		public override void InsertData() 
		{
            FormExpression.Description = this.expression1.txtDescription.Text;

            if (this.expression1.dlUnit.SelectedIndex != -1)
            {
                FormExpression.Unit = this.expression1.dlUnit.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Unit = this.expression1.dlUnit.Text;
            }

            if (this.expression1.dlBuildingType.SelectedIndex != -1)
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.Text;
            }


            if (this.expression1.dlDivisionCost.SelectedIndex != -1)
            {
                FormExpression.DivisionCost = this.expression1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormExpression.DivisionCost = this.expression1.dlDivisionCost.Text;
            }

            if (this.expression1.dlDivision.SelectedIndex != -1)
            {
                FormExpression.Division = this.expression1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Division = this.expression1.dlDivision.Text;
            }


            if (this.expression1.dlAssembly.SelectedIndex != -1)
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.SelectedValue.ToString());
            }
            else
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.Text);
            }


            if (Convert.ToInt32(this.expression1.txtExpressionID.Text) is Int32)
            {
                FormExpression.ExpressionID = Convert.ToInt32(this.expression1.txtExpressionID.Text);
            }


            FormExpression.Memo = this.expression1.txtMemo.Text;
            FormExpression.Value = this.expression1.txtExpression.Text.Replace("  ", " ");

            EstimateBuilder.ApplicationBuilder.ExpressionDataSource.add(FormExpression);	
		} 

		public override void UpdateData() 
		{
            FormExpression.Description = this.expression1.txtDescription.Text;

            if (this.expression1.dlUnit.SelectedIndex != -1)
            {
                FormExpression.Unit = this.expression1.dlUnit.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Unit = this.expression1.dlUnit.Text;
            }

            if (this.expression1.dlBuildingType.SelectedIndex != -1)
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.Text;
            }
            if (this.expression1.dlDivisionCost.SelectedIndex != -1)
            {
                FormExpression.DivisionCost = this.expression1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
                FormExpression.DivisionCost = this.expression1.dlDivisionCost.Text;
            }

            if (this.expression1.dlDivision.SelectedIndex != -1)
            {
                FormExpression.Division = this.expression1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Division = this.expression1.dlDivision.Text;
            }


            if (this.expression1.dlAssembly.SelectedIndex != -1)
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.SelectedValue.ToString());
            }
            else
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.Text);
            }


            if (Convert.ToInt32(this.expression1.txtExpressionID.Text) is Int32)
            {
                FormExpression.ExpressionID = Convert.ToInt32(this.expression1.txtExpressionID.Text);
            }


            FormExpression.Memo = this.expression1.txtMemo.Text;
            FormExpression.Value = this.expression1.txtExpression.Text.Replace("  ", " ");

            EstimateBuilder.ApplicationBuilder.ExpressionDataSource.update(FormExpression);		
		} 
		public override void CancelData() 
		{ 				
			this.expression1.txtDescription.Text = "";
			this.expression1.dlDivision.SelectedText = "";
			this.expression1.dlDivisionCost.SelectedText = "";

			this.expression1.txtMemo.Text = "";
            this.expression1.txtExpressionID.Text = "";
            this.expression1.txtExpression.Text = "";
            this.expression1.dlAssembly.Text="";
		} 
		public override void DeleteData() 
		{

         
            FormExpression.Description = this.expression1.txtDescription.Text ;

            if (this.expression1.dlUnit.SelectedIndex != -1)
            {
                FormExpression.Unit = this.expression1.dlUnit.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Unit = this.expression1.dlUnit.Text;
            }
            if (this.expression1.dlBuildingType.SelectedIndex != -1)
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.SelectedValue.ToString();
            }
            else
            {
                FormExpression.BuildingType = this.expression1.dlBuildingType.Text;
            }

            if (this.expression1.dlDivisionCost.SelectedIndex != -1)
            {
              FormExpression.DivisionCost = this.expression1.dlDivisionCost.SelectedValue.ToString();
            }
            else
            {
              FormExpression.DivisionCost = this.expression1.dlDivisionCost.Text;
            }

            if (this.expression1.dlDivision.SelectedIndex != -1)
            {
                FormExpression.Division = this.expression1.dlDivision.SelectedValue.ToString();
            }
            else
            {
                FormExpression.Division = this.expression1.dlDivision.Text;
            }


            if (this.expression1.dlAssembly.SelectedIndex != -1)
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.SelectedValue.ToString());
            }
            else
            {
                FormExpression.AssemblyID = Convert.ToInt32(this.expression1.dlAssembly.Text);
            }


            if (Convert.ToInt32(this.expression1.txtExpressionID.Text) is Int32)
            {
                FormExpression.ExpressionID = Convert.ToInt32(this.expression1.txtExpressionID.Text);
            }

	
			FormExpression.Memo = this.expression1.txtMemo.Text ;
            FormExpression.Value = this.expression1.txtExpression.Text.Replace("  ", " ");


            EstimateBuilder.ApplicationBuilder.ExpressionDataSource.delete(FormExpression);

		} 
		public override bool ValidateData() 
		{ 
			bool valide = true;
			if(this.expression1.txtDescription.Text.Length ==0)valide = false;
			if(this.expression1.dlDivision.Text.Length ==0)valide = false;
			if(this.expression1.dlDivisionCost.Text.Length ==0)valide = false;
		
		

			if(this.expression1.dlAssembly.Text.Length ==0)valide = false;
		
		
			return valide; 
		}	
	

 
		public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{
         
                base.OnClosing(e);

                try
                {
                    foreach (Form item in this.expression.MdiParent.MdiChildren)
                    {
                        item.Refresh();
                    }
                    this.expression.MdiParent.Refresh();
                }
                catch { }


                _DivisionDataProvider.selectExpression(EstimateBuilder.Builder.lstExpressionDivision);
          

          


        } 


	}
}
