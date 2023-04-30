#region Using directives

using Janus.Windows.GridEX;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DragNDrop;
using System.Collections;
using System.IO;

#endregion

namespace EstimateBuilder
{
    partial class frmImport : Form
    {
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TreeView DragAndDropListTree;
        private System.Windows.Forms.TreeView DragAndDropOverTree;
        private Janus.Windows.EditControls.UIButton btOK ;
        private Janus.Windows.EditControls.UIButton btCancel;
        protected OpenFileDialog openFileDialog1;
        private ArrayList mAvailableFields;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmImport()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.DragAndDropListTree = new System.Windows.Forms.TreeView();
            this.DragAndDropOverTree = new System.Windows.Forms.TreeView();

            this.columnHeader2 = new System.Windows.Forms.ColumnHeader("");
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader("");
          
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader("");
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader("");
            this.btOK = new Janus.Windows.EditControls.UIButton();
            this.btCancel = new Janus.Windows.EditControls.UIButton();
            this.SuspendLayout();
// 
// DragAndDropListView1
// 

            this.DragAndDropListTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
          

            this.DragAndDropListTree.Location = new System.Drawing.Point(13, 13);
            this.DragAndDropListTree.Name = "DragOverList1";
            this.DragAndDropListTree.Size = new System.Drawing.Size(165, 250);
            this.DragAndDropListTree.TabIndex = 0;
     
            this.DragAndDropListTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
          
// 
// columnHeader2
// 
            this.columnHeader2.Width = 160;
            this.columnHeader2.Text = "File";
// 
// ListView2
// 


            this.DragAndDropOverTree.AllowDrop = true;

            this.DragAndDropOverTree.HideSelection = false;
            this.DragAndDropOverTree.ImageIndex = -1;
            this.DragAndDropOverTree.Location = new System.Drawing.Point(234, 13);
            this.DragAndDropOverTree.Name = "DragAndDropTree";
            this.DragAndDropOverTree.SelectedImageIndex = -1;
            this.DragAndDropOverTree.Size = new System.Drawing.Size(165, 250);
            this.DragAndDropOverTree.TabIndex = 1;
            this.DragAndDropOverTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            this.DragAndDropOverTree.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.DragAndDropOverTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
// 
// columnHeader4
// 
            this.columnHeader4.Width = 160;
            this.columnHeader4.Text = "Grid";
// 
// btOK
// 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(225, 295);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(80, 24);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "OK";
            this.btOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
// 
// btCancel
// 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(319, 295);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 24);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
// 
// frmImport
// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5, 13);
            this.ClientSize = new System.Drawing.Size(424, 331);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.DragAndDropOverTree);
            this.Controls.Add(this.DragAndDropListTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmImport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            this.ResumeLayout(false);

        }

        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.ContactMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null; 
            int i = 0; 
            for ( i=1; i<=grid.RootTable.Columns.Count - 1; i++ ) 
            { 
                column = grid.RootTable.Columns.GetColumnInPosition( i ); 
                 AddAvailableField( column, false );       
            }

             this.ShowDialog(parent);
             if (this.DialogResult == DialogResult.OK)
             {
                 ArrayList _importedData = saveData(grid, parent, _text);
                 dataSource.addItem(_importedData);


                 EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;
                
                 return DialogResult.OK;
             }
             else
             { return DialogResult.Cancel; }

         }

        public DialogResult ShowDialog(GridEX grid, Form parent, EstimateBuilder.QuantityMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }

        public DialogResult ShowDialog(GridEX grid, Form parent, EstimateBuilder.JobMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }


        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.AssemblyMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }


        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.CostAmountMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }



        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.CostItemMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }


        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.EstimateMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }



        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.ExpressionMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }


        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.TakeoffMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }


        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.ValidationSystemMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }

        public DialogResult ShowDialog(GridEX grid, Form parent,  EstimateBuilder.ValidationUserMDI dataSource)
        {

            StreamReader _text = getData();
            GridEXColumn column = null;
            int i = 0;
            for (i = 1; i <= grid.RootTable.Columns.Count - 1; i++)
            {
                column = grid.RootTable.Columns.GetColumnInPosition(i);
                AddAvailableField(column, false);
            }

            this.ShowDialog(parent);
            if (this.DialogResult == DialogResult.OK)
            {
                ArrayList _importedData = saveData(grid, parent, _text);
                dataSource.addItem(_importedData);


                EstimateBuilder.ApplicationBuilder.EditMode = DataFormEditMode.AddNew;

                return DialogResult.OK;
            }
            else
            { return DialogResult.Cancel; }

        }

         #region Routine

         private void tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Get the node underneath the mouse.
            TreeNode node = tree.GetNodeAt(e.X, e.Y);
            tree.SelectedNode = node;

            // Start the drag-and-drop operation with a cloned copy of the node.
            if ((node != null)&&(tree.Name=="DragOverList1"))
                tree.DoDragDrop(node.Clone(), DragDropEffects.Move);

            if ((tree.Name != "DragOverList1") && (tree.SelectedNode.Parent != null))
                tree.Nodes.Remove(node);
        }



         private void tree_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
         {
             // Get the tree.
             TreeView tree = (TreeView)sender;
            

             // Get the screen point.
             Point pt = new Point(e.X, e.Y);

             // Convert to a point in the TreeView's coordinate system.
             pt = tree.PointToClient(pt);

             // Get the node underneath the mouse.
             TreeNode node = tree.GetNodeAt(pt);

             // Add a child node.
             
                 node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));
             

             // Show the newly added node if it is not already visible.
             node.Expand();
         }

        private void tree_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Drag and drop denied by default.
            e.Effect = DragDropEffects.None;

            // Is it a valid format?
            if (e.Data.GetData(typeof(TreeNode)) != null)
            {
                // Get the screen point.
                Point pt = new Point(e.X, e.Y);

                // Convert to a point in the TreeView's coordinate system.
                pt = tree.PointToClient(pt);

                // Is the mouse over a valid node?
                TreeNode node = tree.GetNodeAt(pt);
                if (node != null)
                    {
                    e.Effect = DragDropEffects.Move;
                    tree.SelectedNode = node;
                    
                }
            }
        }
         private void AddAvailableField(GridEXColumn column, bool refresh)
        {
            if (mAvailableFields == null)
            {
                mAvailableFields = new ArrayList();
            }
            mAvailableFields.Add(column);
          
             FillAvailableList();
           
        }
        
        private void FillAvailableList()
        {
             GridEXColumn column = null;
           this.DragAndDropOverTree.Nodes.Clear();
            if (!(mAvailableFields == null))
            {
                foreach (Janus.Windows.GridEX.GridEXColumn transTemp0 in mAvailableFields)
                {
                    column = transTemp0;
                    this.DragAndDropOverTree.Nodes.Add(EstimateBuilder.Grid.GetColumnFriendlyName(column));
                }
            }
          
        }






        public StreamReader getData()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            this.openFileDialog1.FilterIndex = 2;
            StreamReader importData = null;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importData = File.OpenText(openFileDialog1.FileName);
                string input = null;
                const char del1 = ',';
                const char del2 = '\t';
                const char del3 = '"';

                char[] delimiter = new char[] { del1, del2, del3 };
                int count = 0;
                while ((input = importData.ReadLine()) != null)
                {
                   
                    input = input.Replace("''", "");
                    string[] i = input.Split(delimiter);
                    if (count == 0)
                    {
                        for (int j = 0; j < i.Length; j++)
                        {
                            this.DragAndDropListTree.Nodes.Add(j+"-"+i[j]);
                        }
                        break;
                    }               
                }

            }
            return importData ;

        }

        private ArrayList saveData(GridEX grid, Form parent, StreamReader _dataSource )
        {

            ArrayList importedData = new ArrayList();
            string input = null;
                const char del1 = ',';
                const char del2 = '\t';
                const char del3 = '"';
                int w = this.DragAndDropOverTree.Nodes.Count;
            


                char[] delimiter = new char[] { del1, del2, del3 };
               
                while ((input = _dataSource.ReadLine()) != null)
                {                
                    input = input.Replace("''", "");
                    string[] i = input.Split(delimiter);
                    string[] k = new string[w] ;
                    
                    int count = 0;


                    foreach (TreeNode node in this.DragAndDropOverTree.Nodes)
                     {
                        if (node.Nodes.Count > 0)
                        {
                            foreach (TreeNode nodeChild in node.Nodes)
                            {
                                string _id = nodeChild.Text;
                                 int y = _id.IndexOf("-");
                                _id = _id.Substring(0, y); 
                                y = Convert.ToInt32(_id);
                                y = y - 1;

                                k[count] = i[y];
                            }
                        }
                        else
                        {
                           k[count]= null;
                        }
                         count++;
                          
                     }
                     importedData.Add(k);
                 }
                 return importedData;
             }
        #endregion

        }
}