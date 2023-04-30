namespace EstimateBuilder
{
    partial class frmSaveTakeOff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveTakeOff));
            this.btOK = new Janus.Windows.EditControls.UIButton();
            this.btCancel = new Janus.Windows.EditControls.UIButton();
            this.dlProject = new System.Windows.Forms.ComboBox();
            progressBarSaveJob = new System.Windows.Forms.ProgressBar();
            this.lbSelectJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(48, 90);
            this.btOK.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(80, 24);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "Save to Job";
            this.btOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(153, 90);
            this.btCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(80, 24);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dlProject
            // 
            this.dlProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dlProject.FormattingEnabled = true;
            this.dlProject.Location = new System.Drawing.Point(107, 16);
            this.dlProject.Name = "dlProject";
            this.dlProject.Size = new System.Drawing.Size(130, 21);
            this.dlProject.TabIndex = 11;
            this.dlProject.Text = "Select Job";
            // 
            // progressBarSaveJob
            // 
            progressBarSaveJob.Location = new System.Drawing.Point(107, 57);
            progressBarSaveJob.Name = "progressBarSaveJob";
            progressBarSaveJob.Size = new System.Drawing.Size(130, 14);
            progressBarSaveJob.TabIndex = 13;
            // 
            // lbSelectJob
            // 
            this.lbSelectJob.AutoSize = true;
            this.lbSelectJob.Location = new System.Drawing.Point(28, 19);
            this.lbSelectJob.Name = "lbSelectJob";
            this.lbSelectJob.Size = new System.Drawing.Size(53, 13);
            this.lbSelectJob.TabIndex = 14;
            this.lbSelectJob.Text = "Select Job";
            // 
            // frmSaveTakeOff
            // 
            this.ClientSize = new System.Drawing.Size(295, 123);
            this.Controls.Add(this.lbSelectJob);
            this.Controls.Add(progressBarSaveJob);
            this.Controls.Add(this.dlProject);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "frmSaveTakeOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private Janus.Windows.EditControls.UIButton btOK;
        private Janus.Windows.EditControls.UIButton btCancel;
        private System.Windows.Forms.ComboBox dlProject;
        private System.Windows.Forms.Label lbSelectJob;
        public static System.Windows.Forms.ProgressBar progressBarSaveJob;

    }
}