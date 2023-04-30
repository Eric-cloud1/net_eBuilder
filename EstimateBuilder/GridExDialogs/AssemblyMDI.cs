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
	/// Summary description for AssemblyMDI.
	/// </summary>
	public class AssemblyMDI :  EstimateBuilder.Grid
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private Label lbHeader;
		private EstimateBuilder.AssemblyDatas assembly;

		public AssemblyMDI()
		{
			//
			// Required for Windows Form Designer support
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


        public  override void Init()
        {
            base.Init();
            InitializeComponent();
        }

        public override void Refresh()
        {
            this.assembly = new AssemblyDatas();
            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.assemblyId;

            if (EstimateBuilder.ApplicationBuilder.assemblyId != "All")
            { this.assembly = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.select(EstimateBuilder.ApplicationBuilder.contactId); }
            else
            { this.assembly = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.select(); }

            this.GridEX.DataSource = this.assembly.Clone();
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
            if (EstimateBuilder.ApplicationBuilder.assemblyId != "All")
            {
                dtExport = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.selectData(EstimateBuilder.ApplicationBuilder.contactId);
            }
            else
            {
                dtExport = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.selectData();
            }

            this.Export(dtExport.Tables[0]);
        }



        public void createAssemblyMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.assemblyId = _id;
            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.assemblyId;

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

			if(EstimateBuilder.ApplicationBuilder.assemblyId!="All")
			{this.load(EstimateBuilder.ApplicationBuilder.assemblyId);}
			else
			{this.load();}
			if(EstimateBuilder.ApplicationBuilder.OpenAssemblyMode != OpenAssembly.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenAssemblyMode = OpenAssembly.On;
				this.Show();
			}		
		}

		public override void load()
		{
            base.load();

            assembly = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.select();
			this.SetDataBinding(assembly);
            this.BringToFront();
        }

		public override void load(string _id)
		{
            base.load();
            assembly = EstimateBuilder.ApplicationBuilder.AssemblyDataSource.select(_id);
			this.SetDataBinding(assembly);
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
            catch 
            { }
            this.resizeColumn();

            if (_ViewChanged == true)
            {
                this.GridEX.Refetch();
            }
        }


    

        public override void SetDataBinding(object _data)
		{
            base.SetDataBinding(_data);
            //GridEX.RootTable.ColumnSets.GetColumnSetInPosition(0).SetColumnWidth(0, 300);
            //this.GridEX.Refetch();

           
        }

        protected override void GridEX_DropDown(Object sender, ColumnActionEventArgs e)
        {
            GridEXSelectedItem item = null;
            foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{  
				item = transTemp1;
				if (( item.RowType == RowType.Record ) && (e.Column.Caption == "DivisionCost"))
				{
                    EstimateBuilder.ListDataProvider list = new ListDataProvider();
                    EstimateBuilder.AssemblyData i = (EstimateBuilder.AssemblyData)item.GetRow().DataRow; 
                     this.GridEX.DropDowns["dlDivisionCost"].SetDataBinding(list.UserValidationDivisionCost(i.Division), "");
                    this.GridEX.DropDowns["dlDivisionCost"].Refetch();
                }
            }   
        }

        public override void ShowSaveDialog()
        {
            base.ShowSaveDialog();

        }
        public override void ShowNewItemDialog()
		{
			EstimateBuilder.Assembly AssemblyDialog = new EstimateBuilder.Assembly();
			AssemblyDialog.CreateNewAssembly(this);
		}

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }

      

        public override bool SaveData()
        {
            base.SaveData();
            EstimateBuilder.AssemblyDataProvider Assembly = new EstimateBuilder.AssemblyDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                Assembly.update((EstimateBuilder.AssemblyData)this.GridEX.GetRow().DataRow);
            }

             EstimateBuilder.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
            _DivisionDataProvider.selectAssembly(EstimateBuilder.Builder.lstAssemblyDivision);
           
            return true;
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
			        foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			        { 
				        //this.GridEX.Delete(); 
				        item = transTemp1;
				        if ( item.RowType == RowType.Record ) 
				        { 
					        EstimateBuilder.AssemblyDataProvider Assembly  = new EstimateBuilder.AssemblyDataProvider(); 
					        this.assembly.Remove((EstimateBuilder.AssemblyData) item.GetRow().DataRow);
					        Assembly.delete((EstimateBuilder.AssemblyData) item.GetRow().DataRow);
                            _DivisionDataProvider.selectAssembly(EstimateBuilder.Builder.lstAssemblyDivision);
                        } 
			        }
                    this.GridEX.DataSource = this.assembly.Clone();
                    this.GridEX.Refetch();
                    break;

                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                 }

        }
		public override void Edit() 
		{ 
			GridEXSelectedItem item = null; 
			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 
					EstimateBuilder.Assembly assemblyDialog = new EstimateBuilder.Assembly(); 
					assemblyDialog.Edit(  (EstimateBuilder.AssemblyData) item.GetRow().DataRow,   this); 
				} 
			}
		}
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 
			EstimateBuilder.ApplicationBuilder.OpenAssemblyMode = OpenAssembly.Off;


       
            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                EstimateBuilder.AssemblyDataProvider Assembly = new EstimateBuilder.AssemblyDataProvider();
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {
                    Assembly.add((EstimateBuilder.AssemblyData)this.GridEX.GetRow(i).DataRow);
                }
            }


        }

        public override void InsertData()
        {
            try
            {
                EstimateBuilder.AssemblyDataProvider Assembly = new EstimateBuilder.AssemblyDataProvider();
                Janus.Windows.GridEX.GridEXSelectedItem item = null;
                foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                {
                    Assembly.Copy((EstimateBuilder.AssemblyData)this.GridEX.GetRow().DataRow);
                }
                this.Refresh();
            }
            catch { }
        }

		protected EstimateBuilder.AssemblyDatas _assemblyData;
        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			 _assemblyData = new EstimateBuilder.AssemblyDatas();
             EstimateBuilder.AssemblyDataProvider Assembly = new EstimateBuilder.AssemblyDataProvider();

                int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];

				
						try
						{
							_assemblyData.Add(new AssemblyData(i[0],i[1],i[2],null,null,"",0,0));
                            Assembly.add(new AssemblyData(i[0], i[1], i[2], null, null, "", 0, 0));
			
						}
						catch{}
                     count++;
				}
             this.GridEX.SetDataBinding(_assemblyData,"");
			this.GridEX.RetrieveStructure();

           
		}
	

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		protected  new void InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblyMDI));
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
            this.GridEX.AutoSize = true;
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
            this.GridEX.Size = new System.Drawing.Size(882, 356);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(882, 56);
            this.TopRebar1.Controls.SetChildIndex(this.lbHeader, 0);
            this.TopRebar1.Controls.SetChildIndex(this.dlSelectView, 0);
            // 
            // uiCmdManagerMenuBar
            // 
            this.uiCmdManagerMenuBar.EditContextMenu.SetUseJanusEditMenu(this.GridEX, true);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Location = new System.Drawing.Point(34, 31);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 3;
            // 
            // AssemblyMDI
            // 
            this.ClientSize = new System.Drawing.Size(882, 412);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "AssemblyMDI";
            this.Text = "Assembly";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

#endregion
}
