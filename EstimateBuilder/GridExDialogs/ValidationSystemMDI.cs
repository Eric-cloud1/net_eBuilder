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
	/// Summary description for ValidationSystem.
	/// </summary>
	public class ValidationSystemMDI : EstimateBuilder.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public ValidationSystemMDI()
		{
			//
			// Required for Windows Form Designer support

		}
        public override void Refresh()
        {
            this.validationSystem = new ValidationSystemDatas();

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.validationSystemId;

            if (EstimateBuilder.ApplicationBuilder.validationSystemId != "All")
            { this.validationSystem = EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.select(EstimateBuilder.ApplicationBuilder.validationSystemId); }
            else
            { this.validationSystem = EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.select(); }

           this.GridEX.DataSource = this.validationSystem.Clone();
           if (_colapse == true)
           {
               this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
           }
           else
           {
               this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
           }
           this.GridEX.Refetch();
        }

        public override void ShowExportViewDialog()
        {
            DataSet dtExport;
            if (EstimateBuilder.ApplicationBuilder.validationSystemId != "All")
            { dtExport = EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.selectData(EstimateBuilder.ApplicationBuilder.validationSystemId); }
            else
            { dtExport = EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.selectData(); }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationSystemMDI));
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
            gridEXLayout1.IsCurrentLayout = true;
            gridEXLayout1.Key = "Grid";
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            gridEXLayout1});
            this.GridEX.ScrollBars = Janus.Windows.GridEX.ScrollBars.Automatic;
            this.GridEX.Size = new System.Drawing.Size(863, 268);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(863, 56);
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
            this.lbHeader.Location = new System.Drawing.Point(66, 36);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 9;
            // 
            // ValidationSystemMDI
            // 
            this.ClientSize = new System.Drawing.Size(863, 324);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "ValidationSystemMDI";
            this.Text = "Validation System";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private Label lbHeader;
		private EstimateBuilder.ValidationSystemDatas validationSystem;



		public override void load()
		{
            base.load();

  

   

            InitializeComponent();
            validationSystem =  EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.select();
			this.SetDataBinding(validationSystem);
            this.BringToFront();
        }

		public void createValidationSystemMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.validationSystemId = _id;
            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.validationSystemId;
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

				
			if(EstimateBuilder.ApplicationBuilder.validationSystemId !="All")
			{this.load(EstimateBuilder.ApplicationBuilder.validationSystemId);}
			else
			{this.load();}

			if(EstimateBuilder.ApplicationBuilder.OpenValidationSystemMode != OpenValidationSystem.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenValidationSystemMode = OpenValidationSystem.On;
				this.Show();
			}
	
		}

	

		public override void load(string _id)
		{
            this.load();
            validationSystem =  EstimateBuilder.ApplicationBuilder.ValidationSystemDataSource.select(_id);
			this.SetDataBinding(validationSystem);
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

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }

        public override void ShowNewItemDialog()
		{
			EstimateBuilder.ValidationSystem validationSystemDialog = new EstimateBuilder.ValidationSystem();
			validationSystemDialog.CreateNewValidationSystem(this); 
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
                       //	this.GridEX.Delete();
                       item = transTemp1;
                       if (item.RowType == RowType.Record)
                       {
                           EstimateBuilder.ValidationSystemDataProvider ValidationSystem = new EstimateBuilder.ValidationSystemDataProvider();
                           this.validationSystem.Remove((EstimateBuilder.ValidationSystemData)item.GetRow().DataRow);

                           ValidationSystem.delete((EstimateBuilder.ValidationSystemData)item.GetRow().DataRow);
                           _DivisionDataProvider.selectValidationSystem(EstimateBuilder.Builder.lstValidationSystemDivision);
                       }
                   }

                   this.GridEX.DataSource = this.validationSystem.Clone();
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
            EstimateBuilder.ValidationSystemDataProvider ValidationSystem = new EstimateBuilder.ValidationSystemDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationSystem.update((EstimateBuilder.ValidationSystemData)this.GridEX.GetRow().DataRow);

            }
            _DivisionDataProvider.selectValidationSystem(EstimateBuilder.Builder.lstValidationSystemDivision);
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
					EstimateBuilder.ValidationSystem validationSystemDialog = new EstimateBuilder.ValidationSystem(); 
					validationSystemDialog.Edit((EstimateBuilder.ValidationSystemData) item.GetRow().DataRow,  this); 
				} 
			}
		}

        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			EstimateBuilder.ValidationSystemDatas _ValidationSystemData = new EstimateBuilder.ValidationSystemDatas();
			 int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                EstimateBuilder.ValidationSystemDataProvider ValidationSystem = new EstimateBuilder.ValidationSystemDataProvider();
               
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];
						try
						{
							_ValidationSystemData.Add(new ValidationSystemData(i[0],i[1],"",0,0));
                            ValidationSystem.add(new ValidationSystemData(i[0], i[1], "", 0, 0));
						}
						catch{}
                    count++;
				}
			this.GridEX.SetDataBinding(_ValidationSystemData,"");
			this.GridEX.RetrieveStructure();
	
		}

        public override void InsertData()
        {
            try{
            EstimateBuilder.ValidationSystemDataProvider ValidationSystem = new EstimateBuilder.ValidationSystemDataProvider();
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationSystem.Copy((EstimateBuilder.ValidationSystemData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                     }
            catch { }
        }

		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			EstimateBuilder.ApplicationBuilder.OpenValidationSystemMode = OpenValidationSystem.Off;

            this.ClientSize = new System.Drawing.Size(EstimateBuilder.ApplicationBuilder.XTakeoff, EstimateBuilder.ApplicationBuilder.YTakeoff);

            EstimateBuilder.ApplicationBuilder.XValidationSystem = this.ClientSize.Width;
            EstimateBuilder.ApplicationBuilder.YValidationSystem = this.ClientSize.Height;

           
            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                EstimateBuilder.ValidationSystemDataProvider ValidationSystem = new EstimateBuilder.ValidationSystemDataProvider();
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    ValidationSystem.add((EstimateBuilder.ValidationSystemData)this.GridEX.GetRow(i).DataRow);

                }

            }

        }

	}

}
