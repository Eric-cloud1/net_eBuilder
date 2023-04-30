#region Using directives
using Janus.Windows.GridEX;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#endregion

namespace IDIGITALTEKGRID
{
    partial class frmFilter : Form
    {
        public frmFilter()
        {
            InitializeComponent();
        }
   

            //internal Janus.Windows.GridEX.EditControls.EditBox txtValue2;
        //internal Janus.Windows.GridEX.EditControls.EditBox txtValue1;
      //  internal Janus.Windows.EditControls.UIComboBox cboCondition;
       // internal Janus.Windows.EditControls.UIComboBox cboColumn;
        //  internal Janus.Windows.EditControls.UIComboBox cboOperator;
       // internal Janus.Windows.EditControls.UIComboBox cboFields;
   




        /// <summary>
        /// Clean up any resources being used.
        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup1 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
            Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup2 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.excConditionCriteria = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
            this.lblFields = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.cboColumn = new System.Windows.Forms.ComboBox();
            this.ExplorerBar1 = new Janus.Windows.ExplorerBar.ExplorerBar();
            this.Button2 = new  Janus.Windows.EditControls.UIButton();
            this.Button1 = new Janus.Windows.EditControls.UIButton();
            this.UiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.excConditionCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar1)).BeginInit();
            this.ExplorerBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox1)).BeginInit();
            this.UiGroupBox1.SuspendLayout();
            this.SuspendLayout();
// 
// ImageList1
// 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
// 
// excConditionCriteria
// 
            this.excConditionCriteria.Controls.Add(this.lblFields);
            this.excConditionCriteria.Controls.Add(this.txtValue2);
            this.excConditionCriteria.Controls.Add(this.txtValue1);
            this.excConditionCriteria.Controls.Add(this.cboOperator);
            this.excConditionCriteria.Controls.Add(this.lblCondition);
            this.excConditionCriteria.Controls.Add(this.lblValue1);
            this.excConditionCriteria.Controls.Add(this.lblValue2);
            this.excConditionCriteria.Controls.Add(this.cboColumn);
            this.excConditionCriteria.Location = new System.Drawing.Point(8, 34);
            this.excConditionCriteria.Name = "excConditionCriteria";
            this.excConditionCriteria.Size = new System.Drawing.Size(368, 101);
            this.excConditionCriteria.TabIndex = 2;
// 
// lblFields
// 
            this.lblFields.AutoSize = true;
            this.lblFields.BackColor = System.Drawing.Color.Transparent;
            this.lblFields.Location = new System.Drawing.Point(8, 7);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(38, 14);
            this.lblFields.TabIndex = 4;
            this.lblFields.Text = "Fields:";
// 
// txtValue2
// 
            this.txtValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue2.Enabled = false;
            this.txtValue2.Location = new System.Drawing.Point(72, 76);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(288, 20);
            this.txtValue2.TabIndex = 3;
// 
// txtValue1
// 
            this.txtValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue1.Location = new System.Drawing.Point(72, 52);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(288, 20);
            this.txtValue1.TabIndex = 2;
// 
// cboOperator
// 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(72, 28);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(219, 21);
            this.cboOperator.TabIndex = 10;
            this.cboOperator.SelectedIndexChanged += new System.EventHandler(this.cboOperator_SelectedIndexChanged);
// 
// lblCondition
// 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Location = new System.Drawing.Point(8, 32);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(55, 14);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition:";
// 
// lblValue1
// 
            this.lblValue1.AutoSize = true;
            this.lblValue1.BackColor = System.Drawing.Color.Transparent;
            this.lblValue1.Location = new System.Drawing.Point(8, 56);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(46, 14);
            this.lblValue1.TabIndex = 4;
            this.lblValue1.Text = "Value 1:";
// 
// lblValue2
// 
            this.lblValue2.AutoSize = true;
            this.lblValue2.BackColor = System.Drawing.Color.Transparent;
            this.lblValue2.Location = new System.Drawing.Point(8, 80);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(46, 14);
            this.lblValue2.TabIndex = 4;
            this.lblValue2.Text = "Value 2:";
// 
// cboColumn
// 
            this.cboColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.Location = new System.Drawing.Point(72, 4);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(219, 21);
            this.cboColumn.TabIndex = 0;
// 
// ExplorerBar1
// 
            this.ExplorerBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplorerBar1.BackgroundFormatStyle.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items;
            this.ExplorerBar1.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items;
            this.ExplorerBar1.Controls.Add(this.excConditionCriteria);
            explorerBarGroup1.ContainerHeight = 28;
            explorerBarGroup1.Key = "Group1";
            explorerBarGroup1.ShowGroupCaption = false;
            explorerBarGroup1.Text = "New Group";
            explorerBarGroup2.Container = true;
            explorerBarGroup2.ContainerControl = this.excConditionCriteria;
            explorerBarGroup2.ContainerHeight = 102;
            explorerBarGroup2.Expandable = false;
            explorerBarGroup2.ImageIndex = 2;
            explorerBarGroup2.Key = "Group2";
            explorerBarGroup2.Text = "Condition";
            this.ExplorerBar1.Groups.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarGroup[] {
            explorerBarGroup1,
            explorerBarGroup2});
            this.ExplorerBar1.GroupSeparation = 6;
            this.ExplorerBar1.ImageList = this.ImageList1;
            this.ExplorerBar1.Location = new System.Drawing.Point(24, 20);
            this.ExplorerBar1.Name = "ExplorerBar1";
            this.ExplorerBar1.Size = new System.Drawing.Size(384, 250);
            this.ExplorerBar1.TabIndex = 7;
            this.ExplorerBar1.Text = "ExplorerBar1";
            this.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003;
// 
// Button2
// 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(323, 321);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(80, 24);
            this.Button2.TabIndex = 10;
            this.Button2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.Button2.Text = "Cancel";
// 
// Button1
// 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.Location = new System.Drawing.Point(235, 321);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(80, 24);
            this.Button1.TabIndex = 9;
            this.Button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.Button1.Text = "OK";
// 
// UiGroupBox1
// 
            this.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel;
            this.UiGroupBox1.Controls.Add(this.ExplorerBar1);
            this.UiGroupBox1.Controls.Add(this.Button2);
            this.UiGroupBox1.Controls.Add(this.Button1);
            this.UiGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.UiGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UiGroupBox1.Name = "UiGroupBox1";
            this.UiGroupBox1.Size = new System.Drawing.Size(420, 373);
            this.UiGroupBox1.TabIndex = 1;
            this.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
// 
// frmFilter
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(420, 373);
            this.Controls.Add(this.UiGroupBox1);
            this.Name = "frmFilter";
            this.Text = "formFilter";
            this.excConditionCriteria.ResumeLayout(false);
            this.excConditionCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerBar1)).EndInit();
            this.ExplorerBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UiGroupBox1)).EndInit();
            this.UiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DialogResult ShowDialog(GridEXTable table)
        {
            try{
                this.cboColumn.DataSource = table.Columns;
                this.cboColumn.DisplayMember = "Caption";
                this.cboColumn.SelectedItem = table.Columns[0];
            }
            catch{}
            FillOperatorCombo();
            if (ShowDialog() == DialogResult.OK)
            {
                //getting the column selected by the user
                GridEXColumn column = (GridEXColumn)cboColumn.SelectedItem;
                //getting the condition operator
                ConditionOperator conditionOp = (ConditionOperator)cboOperator.SelectedItem;
                GridEXFilterCondition filter;
                //in cases where the type of the data is not string,
                //it is necessary to parse the text entered by the user
                //to convert it to the same type of the data.
                object value1 = ParseText(this.txtValue1.Text, column);
                object value2 = null;
                if (txtValue2.Enabled)
                {
                    value2 = ParseText(txtValue2.Text, column);
                }
                //create the filter
                filter = new GridEXFilterCondition(column, conditionOp, value1, value2);
                //apply the filter
                table.FilterCondition = filter;
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.Cancel;
            }
        }
        protected System.Array array;
        private void FillOperatorCombo()
        {
            array = System.Enum.GetValues(typeof(ConditionOperator));
            cboOperator.DataSource = array;
            cboOperator.SelectedItem = array.GetValue(0);
        }

        private void cboOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConditionOperator conditionOp;
            conditionOp = (ConditionOperator)cboOperator.SelectedItem;
            if (conditionOp == ConditionOperator.Between || conditionOp == ConditionOperator.NotBetween)
            {
                this.txtValue2.Enabled = true;
            }
            else
            {
                txtValue2.Enabled = false;
            }
        }

        private object ParseText(string text, GridEXColumn column)
        {
            if (column.Type.Equals(typeof(Int32)))
            {
                return Int32.Parse(text);
            }
            else if (column.Type.Equals(typeof(DateTime)))
            {
                return DateTime.Parse(text);
            }
            else if (column.Type.Equals(typeof(Int16)))
            {
                return Int16.Parse(text);
            }
            else if (column.Type.Equals(typeof(Double)))
            {
                return Double.Parse(text);
            }
            else
            {
                return text;
            }
        }

    }
}