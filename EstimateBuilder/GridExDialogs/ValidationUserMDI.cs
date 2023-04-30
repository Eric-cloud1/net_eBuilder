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
	/// Summary description for ValidationUserMDI.
	/// </summary>
    public class ValidationUserMDI : EstimateBuilder.Grid
    {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ValidationUserMDI()
		{
			//
			// Required for Windows Form Designer support
			//

		}
        public override void Refresh()
        {
            this.validationUser = new ValidationUserDatas();

            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.validationUserId;

            if (EstimateBuilder.ApplicationBuilder.validationUserId != "All")
            { this.validationUser = EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.select(EstimateBuilder.ApplicationBuilder.validationUserId); }
            else
            { this.validationUser = EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.select(); }
                this.GridEX.DataSource = this.validationUser.Clone();
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
            if (EstimateBuilder.ApplicationBuilder.validationUserId != "All")
            { dtExport = EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.selectData(EstimateBuilder.ApplicationBuilder.validationUserId); }
            else
            { dtExport = EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.selectData(); }

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
		protected  new void InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidationUserMDI));
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
            this.GridEX.Size = new System.Drawing.Size(742, 247);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(742, 56);
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
            this.lbHeader.Location = new System.Drawing.Point(66, 37);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 9;
            // 
            // ValidationUserMDI
            // 
            this.ClientSize = new System.Drawing.Size(742, 303);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "ValidationUserMDI";
            this.Text = "Validation User";
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

		
		private EstimateBuilder.ValidationUserDatas validationUser;
	



		public override void load()
		{
            base.load();


 

            validationUser = EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.select();
			this.SetDataBinding(validationUser);
            this.BringToFront();
        }

		
		public void createValidationUserMDI(string _id)
		{
			EstimateBuilder.ApplicationBuilder.validationUserId = _id;
            this.lbHeader.Text = EstimateBuilder.ApplicationBuilder.validationUserId;
			this.Select();
		}

		public  new void Select()
		{

            if (_colapse == true)
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Expanded;
            }
            else
            {
                this.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            }

			if(EstimateBuilder.ApplicationBuilder.validationUserId !="All")
			{this.load(EstimateBuilder.ApplicationBuilder.validationUserId);}
			else
			{this.load();}

			if(EstimateBuilder.ApplicationBuilder.OpenValidationUserMode != OpenValidationUser.On)
			{
				EstimateBuilder.ApplicationBuilder.OpenValidationUserMode = OpenValidationUser.On;
				this.Show();
			}

		}

		public override void load(string _id)
		{
            base.load();
            validationUser =   EstimateBuilder.ApplicationBuilder.ValidationUserDataSource.select(_id);
			this.SetDataBinding(validationUser);
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
                this.GridEX.DropDowns["GroupDescription"].SetDataBinding(list.GroupValidationSystem(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["TypeDescription"].SetDataBinding(list.TypeValidationSystem(), "");
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
 

		
		public override void ShowNewItemDialog()
		{
			EstimateBuilder.ValidationUser validationUserDialog = new EstimateBuilder.ValidationUser();
			validationUserDialog.CreateNewValidationUser(this);
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
                           EstimateBuilder.ValidationUserDataProvider ValidationUser = new EstimateBuilder.ValidationUserDataProvider();
                           this.validationUser.Remove((EstimateBuilder.ValidationUserData)item.GetRow().DataRow);
                           ValidationUser.delete((EstimateBuilder.ValidationUserData)item.GetRow().DataRow);
                           _DivisionDataProvider.selectValidationUser(EstimateBuilder.Builder.lstValidationUserDivision);
                       }
                   }

                   this.GridEX.DataSource = this.validationUser.Clone();
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
            EstimateBuilder.ValidationUserDataProvider ValidationUser = new EstimateBuilder.ValidationUserDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationUser.update((EstimateBuilder.ValidationUserData)this.GridEX.GetRow().DataRow);
            }
            _DivisionDataProvider.selectValidationUser(EstimateBuilder.Builder.lstValidationUserDivision);
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
					EstimateBuilder.ValidationUser validationUserDialog = new EstimateBuilder.ValidationUser(); 
					validationUserDialog.Edit((EstimateBuilder.ValidationUserData) item.GetRow().DataRow,  this); 
				} 
			}
		}

        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			EstimateBuilder.ValidationUserDatas _ValidationUserData = new EstimateBuilder.ValidationUserDatas();
	
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                EstimateBuilder.ValidationUserDataProvider ValidationUser = new EstimateBuilder.ValidationUserDataProvider();
               
				while (enumerator.MoveNext())
				{	
                    	string[] i  = (string[]) _importedData[count];

						bool i2,i3;
				
					
						try
						{
							i2=Convert.ToBoolean(i[2]);
						}
						catch
						{
							i2=false;
						}

                        try
                        {
                            i3 = Convert.ToBoolean(i[3]);
                        }
                        catch
                        {
                            i3 = false;
                        }

                        try
						{
					
							_ValidationUserData.Add(new ValidationUserData(i[0],i[1],i2,i3,i[4],i[5],"",0,0));
                            ValidationUser.add (new ValidationUserData(i[0], i[1], i2, i3, i[4], i[5], "", 0, 0));

						}
						catch{}
                        count++;
                    }
			
			this.GridEX.SetDataBinding(_ValidationUserData,"");
			this.GridEX.RetrieveStructure();
			EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.Insert;
		}
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			EstimateBuilder.ApplicationBuilder.OpenValidationUserMode = OpenValidationUser.Off;
          
            if (EstimateBuilder.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                EstimateBuilder.ValidationUserDataProvider ValidationUser = new EstimateBuilder.ValidationUserDataProvider();
               
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {
                    ValidationUser.add((EstimateBuilder.ValidationUserData)this.GridEX.GetRow(i).DataRow);
                }

            }

        }

        public override void InsertData()
        {
            try{
            EstimateBuilder.ValidationUserDataProvider ValidationUser = new EstimateBuilder.ValidationUserDataProvider();
           
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationUser.Copy((EstimateBuilder.ValidationUserData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                       }
            catch { }

        }



	}
}
