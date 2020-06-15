using System.Globalization;
using System.Threading;

namespace ACS
{
    partial class AcsRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public AcsRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {

            InitializeComponent();

        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen, andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            CultureInfo current = Thread.CurrentThread.CurrentCulture;
            if (current.TwoLetterISOLanguageName != "de")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-EN");
            }
            



            this.acsTab = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.editButton = this.Factory.CreateRibbonButton();
            this.sortButton = this.Factory.CreateRibbonButton();
            this.createButton = this.Factory.CreateRibbonButton();
            this.acsTab.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acsTab
            // 
            this.acsTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.acsTab.Groups.Add(this.group1);
            this.acsTab.Label = Properties.language.AcsRibbon_acsTab;
            this.acsTab.Name = "acsTab";
            // 
            // group1
            // 
            this.group1.Items.Add(this.editButton);
            this.group1.Items.Add(this.sortButton);
            this.group1.Items.Add(this.createButton);
            this.group1.Name = "group1";
            // 
            // editButton
            // 
            this.editButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.editButton.Image = global::ACS.Properties.Resources.Button_Edit;
            this.editButton.Label = Properties.language.AcsRibbon_editButton;
            this.editButton.Name = "editButton";
            this.editButton.ShowImage = true;
            this.editButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EditButtonClick);
            // 
            // sortButton
            // 
            this.sortButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.sortButton.Image = global::ACS.Properties.Resources.Button_Sort;
            this.sortButton.Label = Properties.language.AcsRibbon_sortButton;
            this.sortButton.Name = "sortButton";
            this.sortButton.ShowImage = true;
            this.sortButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SortButtonClick);
            // 
            // createButton
            // 
            this.createButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.createButton.Image = global::ACS.Properties.Resources.Button_Create;
            this.createButton.Label = Properties.language.AcsRibbon_createButton;
            this.createButton.Name = "createButton";
            this.createButton.ShowImage = true;
            this.createButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateButtonClick);
            // 
            // AcsRibbon
            // 
            this.Name = "AcsRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.acsTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AcsRibbon_Load);
            this.acsTab.ResumeLayout(false);
            this.acsTab.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab acsTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton editButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton sortButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton createButton;
    }

    partial class ThisRibbonCollection
    {
        internal AcsRibbon AcsRibbon
        {
            get { return this.GetRibbon<AcsRibbon>(); }
        }
    }
}
