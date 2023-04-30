using System.ComponentModel;
using EstimateBuilder;
using System.Text;
using Microsoft.VisualBasic;		 
using Janus.Windows.GridEX; 
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ExpressionMDI.
	/// </summary>
	public class ExpressionMDI : EstimateBuilder.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExpressionMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}
        public override void Refresh()
        {
            this.expression = new ExpressionDatas();

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.expressionId;

            if (EstimateBuilder.ApplicationBuilder.expressionId != "All")
            { this.expression = EstimateBuilder.ApplicationBuilder.ExpressionDataSource.select(EstimateBuilder.ApplicationBuilder.expressionId); }
            else
            { this.expression = EstimateBuilder.ApplicationBuilder.ExpressionDataSource.select(); }

            this.GridEX.DataSource = this.expression.Clone();
            this.GridEX.Refetch();
        
        }

        public override void ShowExportViewDialog()
        {
            DataSet dtExport;
            if (EstimateBuilder.ApplicationBuilder.expressionId != "All")
            { dtExport = EstimateBuilder.ApplicationBuilder.ExpressionDataSource.selectData(EstimateBuilder.ApplicationBuilder.expressionId); }
            else
            { dtExport = EstimateBuilder.ApplicationBuilder.ExpressionDataSource.selectData(); }

            this.Export(dtExport.Tables[0]);
        }

        public override void Init()
        {
            base.Init();
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
		protected new void InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressionMDI));
            this.lbHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEX
            // 
            this.GridEX.ColumnAutoResize = true;
            this.GridEX.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            gridEXLayout1.Description = "Grid";
            gridEXLayout1.IsCurrentLayout = true;
            gridEXLayout1.Key = "Grid";
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            gridEXLayout1});
            this.GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic;
            this.GridEX.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.GridEX.Size = new System.Drawing.Size(964, 314);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(964, 56);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            this.TopRebar1.Controls.SetChildIndex(this.lbHeader, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(67, 34);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 6;
            // 
            // ExpressionMDI
            // 
            this.ClientSize = new System.Drawing.Size(964, 370);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "ExpressionMDI";
            this.Text = "Expression";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		private EstimateBuilder.ExpressionDatas expression;
        private Label lbHeader;
		public EstimateBuilder.ExpressionDataProvider DataSource;

			
	

		public override void load()
		{
            base.load();
            expression =  EstimateBuilder.ApplicationBuilder.ExpressionDataSource.select();
			this.SetDataBinding(expression);
            this.BringToFront();
        }

		public void createExpressionMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.expressionId = _id;

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.expressionId;

			this.Select();
		}





        public new void Select()
        {
            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }

		
			if(EstimateBuilder.ApplicationBuilder.expressionId !="All")
			{this.load(EstimateBuilder.ApplicationBuilder.expressionId);}
			else
			{this.load();}	
			if(EstimateBuilder.ApplicationBuilder.OpenExpressionMode != OpenExpression.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenExpressionMode = OpenExpression.On;
				this.Show();
			}
			
		}

		public override void load(string _id)
		{
            base.load();
            expression =  EstimateBuilder.ApplicationBuilder.ExpressionDataSource.select(_id);
			this.SetDataBinding(expression);
            this.BringToFront();
        }

        public override void LoadSettings(string _viewName, bool _ViewChanged)
        {
            EstimateBuilder.SettingDataProvider Settings = new EstimateBuilder.SettingDataProvider();
            EstimateBuilder.SettingDatas viewRow = new EstimateBuilder.SettingDatas();
            viewRow = Settings.select(_viewName);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(System.Convert.FromBase64String(viewRow[0].Layout));
            this.GridEX.LoadLayoutFile(stream);
            stream.Close();


            EstimateBuilder.ListDataProvider list = new ListDataProvider();

            try
            {
                this.GridEX.DropDowns["dlDivision"].SetDataBinding(list.UserValidationDivision(), "");


            }
            catch { }

            try
            {
                this.GridEX.DropDowns["dlBuildingType"].SetDataBinding(list.UserValidationBuildingType(), "");


            }
            catch { }

           

            if (_ViewChanged == true)
            {
                this.GridEX.Refetch();
            }
        }

        public override void SetDataBinding(object _data)
		{
            base.SetDataBinding(_data);
            this.resizeColumn(); 
           

        }


        protected override void GridEX_DropDown(Object sender, ColumnActionEventArgs e)
        {

        }

        public override void ShowNewItemDialog()
		{
			EstimateBuilder.Expression ExpressionDialog = new EstimateBuilder.Expression();
			ExpressionDialog.CreateNewExpression(this);
		}

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }

        public override void Delete() 
		{ 
	

            DialogResult result = MessageBox.Show("Do you want to delete that Item?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.Yes:
                    //Delete Item
                    GridEXSelectedItem item = null;
                    EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();


                    foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                    {
                        //this.GridEX.Delete(); 
                        item = transTemp1;
                        if (item.RowType == RowType.Record)
                        {
                            EstimateBuilder.ExpressionDataProvider Expression = new EstimateBuilder.ExpressionDataProvider();
                            this.expression.Remove((EstimateBuilder.ExpressionData)item.GetRow().DataRow);
                            Expression.delete((EstimateBuilder.ExpressionData)item.GetRow().DataRow);
                            _DivisionDataProvider.selectExpression(EstimateBuilder.Builder.lstExpressionDivision);
                        }
                    }
                    this.GridEX.DataSource = this.expression.Clone();
                    this.GridEX.Refetch();
                    break;

                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }



        public EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
	


        public override bool SaveData()
        {
            base.SaveData();
            EstimateBuilder.ExpressionDataProvider Expression = new EstimateBuilder.ExpressionDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                Expression.update((EstimateBuilder.ExpressionData)this.GridEX.GetRow().DataRow);
            } _DivisionDataProvider.selectExpression(EstimateBuilder.Builder.lstExpressionDivision);
          

            return true;
        }



        public override void Edit() 
		{ 
			Janus.Windows.GridEX.GridEXSelectedItem item = null; 
			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 
					EstimateBuilder.Expression expressionDialog = new EstimateBuilder.Expression(); 
					expressionDialog.Edit(  (EstimateBuilder.ExpressionData) item.GetRow().DataRow,   this); 
				} 
			}
		}

        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			EstimateBuilder.ExpressionDatas _expressionData = new EstimateBuilder.ExpressionDatas();

			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                EstimateBuilder.ExpressionDataProvider Expression = new EstimateBuilder.ExpressionDataProvider();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						int i5;
					
						try
						{
							i5=Convert.ToInt32(i[4]);
						}
						catch
						{
							i5=0;
						}

					
						try
						{
							_expressionData.Add(new ExpressionData(i[0],i[1],i[2],i[3],i[4],i5,i[6],"",0,0));
                            Expression.add(new ExpressionData(i[0], i[1], i[2], i[3], i[4], i5, i[6], "", 0, 0));
						}
						catch{}
                        count++;
                    }
				
			this.GridEX.SetDataBinding(_expressionData,"");
			this.GridEX.RetrieveStructure();
		

		}

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			EstimateBuilder.ApplicationBuilder.OpenExpressionMode = OpenExpression.Off;

            EstimateBuilder.ApplicationBuilder.XExpression = this.ClientSize.Width;
            EstimateBuilder.ApplicationBuilder.YExpression = this.ClientSize.Height;
 

            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                EstimateBuilder.ExpressionDataProvider Expression = new EstimateBuilder.ExpressionDataProvider();

                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    Expression.add((EstimateBuilder.ExpressionData)this.GridEX.GetRow(i).DataRow);

                }
            }
        }


	}
}
