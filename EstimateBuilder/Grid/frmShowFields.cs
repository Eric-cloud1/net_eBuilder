/* L:2 */
using Janus.Windows.GridEX; 
/* L:2 */
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
namespace EstimateBuilder
{

    public class frmShowFields : System.Windows.Forms.Form
    {
        private ArrayList mAvailableFields;
        private ArrayList mVisibleFields;

        #region '" Windows Form Designer generated code "'

        public frmShowFields() : base()
        {

            InitializeComponent();

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        private System.ComponentModel.IContainer components = null;
        internal Janus.Windows.EditControls.UIButton btnCancel;
        internal Janus.Windows.EditControls.UIButton btnOk;
        internal Janus.Windows.EditControls.UIButton btnDown;
        internal Janus.Windows.EditControls.UIButton btnUp;
        internal Janus.Windows.EditControls.UIButton btnRemove;
        internal Janus.Windows.EditControls.UIButton btnAdd;
        internal System.Windows.Forms.ListBox lbVisible;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lbAvail;
        internal Janus.Windows.EditControls.UIGroupBox grbBackground;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.grbBackground = new Janus.Windows.EditControls.UIGroupBox();
            this.btnCancel = new Janus.Windows.EditControls.UIButton();
            this.btnOk = new Janus.Windows.EditControls.UIButton();
            this.btnDown = new Janus.Windows.EditControls.UIButton();
            this.btnUp = new Janus.Windows.EditControls.UIButton();
            this.btnRemove = new Janus.Windows.EditControls.UIButton();
            this.btnAdd = new Janus.Windows.EditControls.UIButton();
            this.lbVisible = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbAvail = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grbBackground)).BeginInit();
            this.grbBackground.SuspendLayout();
            this.SuspendLayout();

            this.grbBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel;
            this.grbBackground.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnCancel, this.btnOk, this.btnDown, this.btnUp, this.btnRemove, this.btnAdd, this.lbVisible, this.Label2, this.Label1, this.lbAvail });
            this.grbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.grbBackground.Name = "grbBackground";
            this.grbBackground.Size = new System.Drawing.Size(482, 240);
            this.grbBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;

            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(393, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(305, 208);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 24);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "OK";
            this.btnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnDown.Location = new System.Drawing.Point(201, 124);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(83, 24);
            this.btnDown.TabIndex = 23;
            this.btnDown.Text = "Move Down";
            this.btnDown.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnUp.Location = new System.Drawing.Point(201, 92);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(83, 24);
            this.btnUp.TabIndex = 22;
            this.btnUp.Text = "Move Up";
            this.btnUp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.btnRemove.Location = new System.Drawing.Point(201, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 24);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "<- Remove";
            this.btnRemove.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;


            this.btnAdd.Location = new System.Drawing.Point(201, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 24);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add ->";
            this.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;

            this.lbVisible.Location = new System.Drawing.Point(289, 28);
            this.lbVisible.Name = "lbVisible";
            this.lbVisible.Size = new System.Drawing.Size(184, 173);
            this.lbVisible.TabIndex = 19;

            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(289, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(159, 14);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Show these fields in this order:";

            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(9, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 14);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Available Fields:";

            this.lbAvail.Location = new System.Drawing.Point(9, 28);
            this.lbAvail.Name = "lbAvail";
            this.lbAvail.Size = new System.Drawing.Size(184, 173);
            this.lbAvail.TabIndex = 16;

            this.AutoScaleDimensions = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(482, 240);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.grbBackground });
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmShowFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Show Fields";
            ((System.ComponentModel.ISupportInitialize)(this.grbBackground)).EndInit();
            this.grbBackground.ResumeLayout(false);
            this.ResumeLayout(false);

            btnAdd.Click += new System.EventHandler(btnAdd_Click);

            btnRemove.Click += new System.EventHandler(btnRemove_Click);

            lbVisible.SelectedIndexChanged += new System.EventHandler(lbVisible_SelectedIndexChanged);

            btnUp.Click += new System.EventHandler(btnUp_Click);

            btnDown.Click += new System.EventHandler(btnDown_Click);

            btnCancel.Click += new System.EventHandler(btnCancel_Click);

            btnOk.Click += new System.EventHandler(btnOK_Click);

            lbAvail.DoubleClick += new System.EventHandler(lbAvail_DoubleClick);

            lbVisible.DoubleClick += new System.EventHandler(lbVisible_DoubleClick);
        }


        #endregion



        public DialogResult ShowDialog(Janus.Windows.GridEX.GridEX grid, Form parent)
        {
            GridEXColumn column = null;
            int i = 0;
            this.lbAvail.DisplayMember = "Caption";
            this.lbVisible.DisplayMember = "Caption";

            for (i = 0; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                //if ((column.Key != "Icon") && (column.Key != "NumbID"))
                //{
                    if (column.ShowInFieldChooser)
                    {
                        if (column.Visible)
                        {
                            AddVisibleField(column, false);
                        }
                        else
                        {
                            AddAvailableField(column, false);
                        }
                    }
                //}
            }
            FillAvailableList();
            FillVisibleList();
            return this.ShowDialog(parent);
        }


        private void AddAvailableField(GridEXColumn column, bool refresh)
        {
            if (mAvailableFields == null)
            {
                mAvailableFields = new ArrayList();
            }
            if ((column.Key != "Icon") && (column.Key != "NumbID"))
                mAvailableFields.Add(column);
            if (refresh)
            {
                FillAvailableList();
            }
        }



        private void FillAvailableList()
        {


            GridEXColumn column = null;
            this.lbAvail.Items.Clear();
            if (!(mAvailableFields == null))
            {
                foreach (Janus.Windows.GridEX.GridEXColumn transTemp0 in mAvailableFields)
                {
                    column = transTemp0;
                    //if ((column.Key != "Icon") && (column.Key != "NumbID"))
                        lbAvail.Items.Add(EstimateBuilder.Grid.GetColumnFriendlyName(column));
                }
            }
            if (lbAvail.Items.Count > 0)
            {
                lbAvail.SelectedIndex = 0;
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void AddVisibleField(GridEXColumn column, bool refresh)
        {
            if (mVisibleFields == null)
            {
                mVisibleFields = new ArrayList();
            }
           // if ((column.Key != "Icon") && (column.Key != "NumbID"))
                mVisibleFields.Add(column);
            if (refresh)
            {
                FillVisibleList();
            }
        }


        private void FillVisibleList()
        {
            GridEXColumn column = null;
            this.lbVisible.Items.Clear();
            if (!(mVisibleFields == null))
            {
                foreach (Janus.Windows.GridEX.GridEXColumn transTemp1 in mVisibleFields)
                {
                    column = transTemp1;
                    //if ((column.Key != "Icon") && (column.Key != "NumbID"))
                        lbVisible.Items.Add(EstimateBuilder.Grid.GetColumnFriendlyName(column));
                }
            }
            if (lbVisible.Items.Count > 0)
            {
                lbVisible.SelectedIndex = 0;
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }


        private void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            GridEXColumn column = null;
            int selIndex = 0;
            if (lbAvail.SelectedIndex != -1)
            {
                selIndex = lbAvail.SelectedIndex;
                column = ((GridEXColumn)(mAvailableFields[selIndex]));
                mAvailableFields.Remove(column);
                FillAvailableList();
                this.AddVisibleField(column, true);
                lbVisible.SelectedIndex = lbVisible.Items.Count - 1;
                if (selIndex < lbAvail.Items.Count)
                {
                    lbAvail.SelectedIndex = selIndex;
                }
                else
                {
                    lbAvail.SelectedIndex = lbAvail.Items.Count - 1;
                }
            }
        }


        private void btnRemove_Click(System.Object sender, System.EventArgs e)
        {
            GridEXColumn column = null;
            int selIndex = 0;
            if (lbVisible.SelectedIndex != -1)
            {
                selIndex = lbVisible.SelectedIndex;
                column = ((GridEXColumn)(mVisibleFields[selIndex]));
                if ((column.Caption != "View") && (column.Caption != "ID"))
                {
                    mVisibleFields.Remove(column);
                    FillVisibleList();
                    this.AddAvailableField(column, true);
                    lbAvail.SelectedIndex = lbAvail.Items.Count - 1;
                    if (selIndex < lbVisible.Items.Count)
                    {
                        lbVisible.SelectedIndex = selIndex;
                    }
                    else
                    {
                        lbVisible.SelectedIndex = lbVisible.Items.Count - 1;
                    }
                }
            }
        }


        private void lbVisible_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            this.btnUp.Enabled = (lbVisible.SelectedIndex > 0);
            this.btnDown.Enabled = (lbVisible.SelectedIndex < lbVisible.Items.Count - 1);
        }


        private void btnUp_Click(System.Object sender, System.EventArgs e)
        {
            GridEXColumn column = null;
            int selIndex = lbVisible.SelectedIndex;
            column = ((GridEXColumn)(this.mVisibleFields[selIndex]));
            mVisibleFields.Remove(column);
            mVisibleFields.Insert(selIndex - 1, column);
            FillVisibleList();
            lbVisible.SelectedIndex = selIndex - 1;
        }


        private void btnDown_Click(System.Object sender, System.EventArgs e)
        {
            GridEXColumn column = null;
            int selIndex = lbVisible.SelectedIndex;
            column = ((GridEXColumn)(this.mVisibleFields[selIndex]));
            mVisibleFields.Remove(column);
            mVisibleFields.Insert(selIndex + 1, column);
            FillVisibleList();
            lbVisible.SelectedIndex = selIndex + 1;
        }


        private void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }


        private void btnOK_Click(System.Object sender, System.EventArgs e)
        {
            GridEXColumn column = null;
            int pos = 0;
            if (!(mAvailableFields == null))
            {
                foreach (Janus.Windows.GridEX.GridEXColumn transTemp2 in mAvailableFields)
                {
                    column = transTemp2;
                    column.Visible = false;
                }
            }
            if (!(mVisibleFields == null))
            {
                pos = 0;
                foreach (Janus.Windows.GridEX.GridEXColumn transTemp3 in mVisibleFields)
                {
                    column = transTemp3;
                    column.Visible = true;
                    column.Position = pos;
                    pos = pos + 1;
                }
            }
            this.Close();
        }


        private void lbAvail_DoubleClick(System.Object sender, System.EventArgs e)
        {
            this.btnAdd_Click(null, EventArgs.Empty);
        }


        private void lbVisible_DoubleClick(System.Object sender, System.EventArgs e)
        {
            this.btnRemove_Click(null, EventArgs.Empty);
        }

    }


}
