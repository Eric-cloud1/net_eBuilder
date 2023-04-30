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
	/// Summary description for ContactData.
	/// </summary>
	/// 

	public class ContactMDI: IDIGITALTEKGRID.Grid
	{
		private System.ComponentModel.IContainer components = null;
        private Label lbHeader;
		public IDIGITALTEKGRID.ContactDatas contact = null;	
	
	
		public ContactMDI() 
		{
            
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

        public override void Init()
        {
            base.Init();
            InitializeComponent();

        }

        public override void Refresh()
        {
            this.contact = new ContactDatas();
            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.contactId;
   
            if (IDIGITALTEKGRID.ApplicationBuilder.contactId != "All")
            { contact = IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.select(IDIGITALTEKGRID.ApplicationBuilder.contactId); }
            else
            { contact = IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.select(); }

            this.GridEX.DataSource = this.contact.Clone();
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
            if (IDIGITALTEKGRID.ApplicationBuilder.contactId != "All")
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.selectData(IDIGITALTEKGRID.ApplicationBuilder.contactId); }
            else
            { dtExport = IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.selectData(); }


            this.Export(dtExport.Tables[0]);
        }


        public void createContactMDI(string _id)
		{	
			
			IDIGITALTEKGRID.ApplicationBuilder.contactId = _id;
            this.lbHeader.Text = IDIGITALTEKGRID.ApplicationBuilder.contactId;
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

			if( IDIGITALTEKGRID.ApplicationBuilder.contactId !="All")
			{this.load(IDIGITALTEKGRID.ApplicationBuilder.contactId);}
			else
			{this.load();}

			if(IDIGITALTEKGRID.ApplicationBuilder.OpenContactMode != OpenContact.On)
			{
				IDIGITALTEKGRID.ApplicationBuilder.OpenContactMode = OpenContact.On;
				this.Show();
			}
		
		}
	
		public override void load(string _id)
		{
            base.load();

   




            this.contact = new ContactDatas();
			contact = IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.select(_id);
			this.SetDataBinding(contact);
            this.BringToFront();
        }

		public override void load()
		{
            base.load();
            this.contact = new ContactDatas();
			contact =  IDIGITALTEKGRID.ApplicationBuilder.ContactDataSource.select();
			this.SetDataBinding(contact);
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
                this.GridEX.DropDowns["dlDivision"].SetDataBinding(list.UserValidationDivision(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlDivisionCost"].SetDataBinding(list.UserValidationDivisionCost(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlRegion"].SetDataBinding(list.Regions(), "");
            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlContract"].SetDataBinding(list.ContactType(), "");

            }
            catch { }
            try
            {
                this.GridEX.DropDowns["dlState"].SetDataBinding(list.USStates(), "");
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
           GridEXSelectedItem item = null;
         foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
            {
               item = transTemp1;
               if ((item.RowType == RowType.Record) && (e.Column.Caption == "Division Cost"))
              {
                  //  IDIGITALTEKGRID.ListDataProvider list = new ListDataProvider();
                  //  IDIGITALTEKGRID.ContactData i = (IDIGITALTEKGRID.ContactData)item.GetRow().DataRow;
                  // this.GridEX.DropDowns["dlDivisionCost"].SetDataBinding(list.UserValidationDivisionCost(i.Division), "");
                  
                 //   this.GridEX.DropDowns["dlDivision"].Tables[0].ro..Refetch();
                }

            }
        }

        public override void ShowNewItemDialog()
		{
			IDIGITALTEKGRID.Contact contactDialog = new IDIGITALTEKGRID.Contact(); 
			contactDialog.CreateNewContact(this);
		}


	


        public IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();

		public override bool SaveData() 
		{
            base.SaveData();
            IDIGITALTEKGRID.ContactDataProvider Contact  = new IDIGITALTEKGRID.ContactDataProvider();

            foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
             {
                 Contact.update((IDIGITALTEKGRID.ContactData)this.GridEX.GetRow().DataRow);
              }
          

              _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstQuantityJob);
              _DivisionDataProvider.selectTakeOffJob(IDIGITALTEKGRID.Builder.lstTakeOffJob);
              _DivisionDataProvider.selectJob(IDIGITALTEKGRID.Builder.lstJobDivision);
              _DivisionDataProvider.selectEstimateProject(IDIGITALTEKGRID.Builder.lstEstimateProject, "all");
              _DivisionDataProvider.selectContact(IDIGITALTEKGRID.Builder.lstContactDivision);

              return true;

        }

		public override void Delete() 
		{ 

            DialogResult result = MessageBox.Show("Do you want to delete that Item?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            switch (result)
            {
                case DialogResult.Yes:
                    //Delete Item
                    IDIGITALTEKGRID.DivisionDataProvider _DivisionDataProvider = new DivisionDataProvider();
                    GridEXSelectedItem item = null;
                    foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                    {
                        item = transTemp1;
                        if (item.RowType == RowType.Record)
                        {
                            IDIGITALTEKGRID.ContactDataProvider Contact = new IDIGITALTEKGRID.ContactDataProvider();
                            this.contact.Remove((IDIGITALTEKGRID.ContactData)item.GetRow().DataRow);
                            Contact.delete((IDIGITALTEKGRID.ContactData)item.GetRow().DataRow);
                            _DivisionDataProvider.selectContact(IDIGITALTEKGRID.Builder.lstContactDivision);
                        }
                        //this.GridEX.Delete();
                    }
                    this.GridEX.DataSource = this.contact.Clone();
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
			IDIGITALTEKGRID.Contact contactDialog = new IDIGITALTEKGRID.Contact(); 
			foreach ( Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems ) 
			{ 
				item = transTemp1;
				if ( item.RowType == RowType.Record ) 
				{ 		
					contactDialog.Edit(  (IDIGITALTEKGRID.ContactData) item.GetRow().DataRow,   this); 
				} 
			}
		}

		protected IDIGITALTEKGRID.ContactDatas _contactData ;

        public override void ShowImportViewDialog()
        {
            frmImport frm = new frmImport();
            frm.ShowDialog(this.GridEX, this.ParentForm, this);

        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            IDIGITALTEKGRID.ApplicationBuilder.OpenContactMode = OpenContact.Off;

             IDIGITALTEKGRID.ApplicationBuilder.XContact = this.ClientSize.Width;
             IDIGITALTEKGRID.ApplicationBuilder.YContact = this.ClientSize.Height;

            if (IDIGITALTEKGRID.ApplicationBuilder.EditMode == DataFormEditMode.Insert)
            {
                base.UpdateData();
                IDIGITALTEKGRID.ContactDataProvider Contact = new IDIGITALTEKGRID.ContactDataProvider();
                for (int i = 0; i < this.GridEX.RecordCount; i++)
                {

                    Contact.add((IDIGITALTEKGRID.ContactData)this.GridEX.GetRow(i).DataRow);

                }

            }


        }


        public override void InsertData()
        {
            try
            {
                IDIGITALTEKGRID.ContactDataProvider Contact = new IDIGITALTEKGRID.ContactDataProvider();
                Janus.Windows.GridEX.GridEXSelectedItem item = null;
                foreach (Janus.Windows.GridEX.GridEXSelectedItem transTemp1 in this.GridEX.SelectedItems)
                {
                    Contact.Copy((IDIGITALTEKGRID.ContactData)this.GridEX.GetRow().DataRow);
                }
                this.Refresh();
               }
            catch { }
        }



        public  void addItem(ArrayList _importedData)
		{
			int count =0;
			_contactData = new IDIGITALTEKGRID.ContactDatas();
			
              System.Collections.IEnumerator enumerator = _importedData.GetEnumerator();
              IDIGITALTEKGRID.ContactDataProvider Contact = new IDIGITALTEKGRID.ContactDataProvider();

				while (enumerator.MoveNext())
				{		
					string[] i  = (string[]) _importedData[count];

						int i12,i18;
						try
						{i12= Convert.ToInt32(i[12]);}
						catch{i12=0;}
                        try
                        { i18 = Convert.ToInt32(i[18]); }
                        catch { i18 = 0; }

                        try
						{
							_contactData.Add(new ContactData(i[0],i[1],i[2],i[3],i[4],i[5],i[6],i[7],i[7],i[8],i[9],i[10],i[11],i12,i[13],i[14],i[15],i[16],i[17],i18,"",0,0));
                            Contact.add(new ContactData(i[0], i[1], i[2], i[3], i[4], i[5], i[6], i[7], i[7], i[8], i[9], i[10], i[11], i12, i[13], i[14], i[15], i[16], i[17], i18, "", 0, 0));   
						}
						catch{}
                        count++;
                    }

			this.GridEX.SetDataBinding(_contactData,"");
			this.GridEX.RetrieveStructure();
		
		}

     

		#region '" Windows Form Designer generated code "' 		
		[ System.Diagnostics.DebuggerStepThrough() ]
		protected new void InitializeComponent()
		{
            Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactMDI));
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
            //this.GridEX.aAutoRelocate = true;
            this.GridEX.ColumnAutoResize = true;
            this.GridEX.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            gridEXLayout1.LayoutString = resources.GetString("gridEXLayout1.LayoutString");
            this.GridEX.DesignTimeLayout = gridEXLayout1;
            this.GridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.GridEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GridEX.Size = new System.Drawing.Size(811, 308);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Controls.Add(this.lbHeader);
            this.TopRebar1.Size = new System.Drawing.Size(811, 56);
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
            this.lbHeader.Location = new System.Drawing.Point(62, 35);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(0, 0);
            this.lbHeader.TabIndex = 4;
            // 
            // ContactMDI
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 364);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 40);
            this.Name = "ContactMDI";
            this.Text = "Contact";
            ((System.ComponentModel.ISupportInitialize)(this.GridEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.TopRebar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCmdManagerMenuBar)).EndInit();
            this.ResumeLayout(false);

        }

      
           
        } 

		#endregion 				

     
        

	

	
	

}


