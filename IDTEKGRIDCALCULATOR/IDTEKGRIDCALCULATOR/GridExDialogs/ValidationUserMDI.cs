using System.ComponentModel;
using IDIGITALTEKGRID;
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

namespace IDIGITALTEKGRID
{
	/// <summary>
	/// Summary description for ValidationUserMDI.
	/// </summary>
    public class ValidationUserMDI : IDIGITALTEKGRID.Grid
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

            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.validationUserId;

            if (IDIGITALTEKGRID.ApplicationBuilder.validationUserId != "All")
            { this.validationUser = IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.validationUserId); }
            else
            { this.validationUser = IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.select(); }
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
            if (IDIGITALTEKGRID.ApplicationBuilder.validationUserId != "All")
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.validationUserId); }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.selectData(); }

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

		
		private IDIGITALTEKGRID.ValidationUserDatas validationUser;
	



		public override void load()
		{
            base.load();


 

            validationUser = IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.select();
			this.SetDataBinding(validationUser);
            this.BringToFront();
        }

		
		public void createValidationUserMDI(string _id)
		{
			IDIGITALTEKGRID.ApplicationBuilder.validationUserId = _id;
            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.validationUserId;
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

			if(IDIGITALTEKGRID.ApplicationBuilder.validationUserId !="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.validationUserId);}
			else
			{this.load();}

			if(IDIGITALTEKGRID.ApplicationBuilder.OpenValidationUserMode != OpenValidationUser.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenValidationUserMode = OpenValidationUser.On;
				this.Show();
			}

		}

		public override void load(string _id)
		{
            base.load();
            validationUser =   IDIGITALTEKGRID.ApplicationBuilder.ValidationUserDataSource.select(_id);
			this.SetDataBinding(validationUser);
            this.BringToFront();
        }


        public override void LoadSettings(string _viewName, bool _ViewChanged)
        {
            IDIGITALTEKGRID.SettingDataProvider Settings = new IDIGITALTEKGRID.SettingDataProvider();
            IDIGITALTEKGRID.SettingDatas viewRow = new IDIGITALTEKGRID.SettingDatas();
            viewRow = Settings.select(_viewName);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(System.Convert.FromBase64String(viewRow[0].Layout));
            this.GridEX.LoadLayoutFile(stream);
            stream.Close();
            IDIGITALTEKGRID.ListDataProvider list = new ListDataProvider();
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
			IDIGITALTEKGRID.ValidationUser validationUserDialog = new IDIGITALTEKGRID.ValidationUser();
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
                   IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();



                   foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                   {
                       //this.GridEX.Delete(); 
                       item = transTemp1;
                       if (item.RowType == RowType.Record)
                       {
                           IDIGITALTEKGRID.ValidationUserDataProvider ValidationUser = new IDIGITALTEKGRID.ValidationUserDataProvider();
                           this.validationUser.Remove((IDIGITALTEKGRID.ValidationUserData)item.GetRow().DataRow);
                           ValidationUser.delete((IDIGITALTEKGRID.ValidationUserData)item.GetRow().DataRow);
                           _DivisionDataProvider.selectValidationUser(IDIGITALTEKGRID.Builder.lstValidationUserDivision);
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



        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
        public override bool SaveData()
        {
            base.SaveData();
            IDIGITALTEKGRID.ValidationUserDataProvider ValidationUser = new IDIGITALTEKGRID.ValidationUserDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationUser.update((IDIGITALTEKGRID.ValidationUserData)this.GridEX.GetRow().DataRow);
            }
            _DivisionDataProvider.selectValidationUser(IDIGITALTEKGRID.Builder.lstValidationUserDivision);
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
					IDIGITALTEKGRID.ValidationUser validationUserDialog = new IDIGITALTEKGRID.ValidationUser(); 
					validationUserDialog.Edit((IDIGITALTEKGRID.ValidationUserData) item.GetRow().DataRow,  this); 
				} 
			}
		}

        public void addItem(ArrayList _importedData)
        {
			//Creating the collection
			IDIGITALTEKGRID.ValidationUserDatas _ValidationUserData = new IDIGITALTEKGRID.ValidationUserDatas();
	
			    int count =0;
		        System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
                IDIGITALTEKGRID.ValidationUserDataProvider ValidationUser = new IDIGITALTEKGRID.ValidationUserDataProvider();
               
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
			IDIGITALTEKGRID.ApplicationBuilder.EditMode = DataFormEditMode.Insert;
		}
		protected override void OnClosing( System.ComponentModel.CancelEventArgs e ) 
		{ 
			base.OnClosing( e ); 		
			IDIGITALTEKGRID.ApplicationBuilder.OpenValidationUserMode = OpenValidationUser.Off;
          
            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                IDIGITALTEKGRID.ValidationUserDataProvider ValidationUser = new IDIGITALTEKGRID.ValidationUserDataProvider();
               
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {
                    ValidationUser.add((IDIGITALTEKGRID.ValidationUserData)this.GridEX.GetRow(i).DataRow);
                }

            }

        }

        public override void InsertData()
        {
            try{
            IDIGITALTEKGRID.ValidationUserDataProvider ValidationUser = new IDIGITALTEKGRID.ValidationUserDataProvider();
           
            Janus.Windows.GridEX.GridEXSelectedItem item = null;
            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
                ValidationUser.Copy((IDIGITALTEKGRID.ValidationUserData)this.GridEX.GetRow().DataRow);
            }
            this.Refresh();
                       }
            catch { }

        }



	}
}
