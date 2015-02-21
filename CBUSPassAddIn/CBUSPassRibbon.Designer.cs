namespace CBUSPassAddIn
{
    partial class CBUSPassRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CBUSPassRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CBUSPassRibbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpUserFunctions = this.Factory.CreateRibbonGroup();
            this.btnReports = this.Factory.CreateRibbonButton();
            this.grpInsert = this.Factory.CreateRibbonGroup();
            this.ebUserInput = this.Factory.CreateRibbonEditBox();
            this.btnSubmit = this.Factory.CreateRibbonButton();
            this.btnExecute = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.grpUserFunctions.SuspendLayout();
            this.grpInsert.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpUserFunctions);
            this.tab1.Groups.Add(this.grpInsert);
            this.tab1.Label = "CBUS Pass";
            this.tab1.Name = "tab1";
            // 
            // grpUserFunctions
            // 
            this.grpUserFunctions.Items.Add(this.btnReports);
            this.grpUserFunctions.Items.Add(this.btnExecute);
            this.grpUserFunctions.Label = "User Functions";
            this.grpUserFunctions.Name = "grpUserFunctions";
            // 
            // btnReports
            // 
            this.btnReports.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Label = "Reports";
            this.btnReports.Name = "btnReports";
            this.btnReports.ShowImage = true;
            this.btnReports.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnReports_Click);
            // 
            // grpInsert
            // 
            this.grpInsert.Items.Add(this.ebUserInput);
            this.grpInsert.Items.Add(this.btnSubmit);
            this.grpInsert.Label = "Inputs";
            this.grpInsert.Name = "grpInsert";
            // 
            // ebUserInput
            // 
            this.ebUserInput.Label = "Enter Value:";
            this.ebUserInput.Name = "ebUserInput";
            this.ebUserInput.Text = null;
            this.ebUserInput.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ebUserInput_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Label = "Submit Value";
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShowImage = true;
            this.btnSubmit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSubmit_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.Label = "Execute Job";
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.ShowImage = true;
            this.btnExecute.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExecute_Click);
            // 
            // CBUSPassRibbon
            // 
            this.Name = "CBUSPassRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CBUSPassRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpUserFunctions.ResumeLayout(false);
            this.grpUserFunctions.PerformLayout();
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpUserFunctions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnReports;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpInsert;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox ebUserInput;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSubmit;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExecute;
    }

    partial class ThisRibbonCollection
    {
        internal CBUSPassRibbon CBUSPassRibbon
        {
            get { return this.GetRibbon<CBUSPassRibbon>(); }
        }
    }
}
