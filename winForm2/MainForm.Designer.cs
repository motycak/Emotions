namespace Emotions
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.cmbResolutions = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCameras = new DevExpress.XtraEditors.ComboBoxEdit();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.gameGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acStart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acReset = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acStop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acPrint = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acFullscreen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.prgHappines = new DevExpress.XtraEditors.ProgressBarControl();
            this.prgAnger = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblAnger = new DevExpress.XtraEditors.LabelControl();
            this.prgSadness = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblSadness = new DevExpress.XtraEditors.LabelControl();
            this.prgSurprise = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblSurprise = new DevExpress.XtraEditors.LabelControl();
            this.prgDisgust = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblDisgust = new DevExpress.XtraEditors.LabelControl();
            this.prgContempt = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblContempt = new DevExpress.XtraEditors.LabelControl();
            this.prgNeutral = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblNeutral = new DevExpress.XtraEditors.LabelControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prgHappines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgAnger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgSadness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgSurprise.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgDisgust.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgContempt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgNeutral.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.pictureBox);
            this.fluentDesignFormContainer1.Controls.Add(this.lblTitle);
            this.fluentDesignFormContainer1.Controls.Add(this.panelControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.cmbResolutions);
            this.fluentDesignFormContainer1.Controls.Add(this.cmbCameras);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(774, 608);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(561, 512);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(561, 96);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "labelControl1";
            // 
            // cmbResolutions
            // 
            this.cmbResolutions.Location = new System.Drawing.Point(296, 470);
            this.cmbResolutions.Name = "cmbResolutions";
            this.cmbResolutions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResolutions.Size = new System.Drawing.Size(100, 20);
            this.cmbResolutions.TabIndex = 2;
            this.cmbResolutions.SelectedIndexChanged += new System.EventHandler(this.cmbResolutions_SelectedIndexChanged);
            // 
            // cmbCameras
            // 
            this.cmbCameras.Location = new System.Drawing.Point(177, 470);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCameras.Size = new System.Drawing.Size(100, 20);
            this.cmbCameras.TabIndex = 1;
            this.cmbCameras.SelectedIndexChanged += new System.EventHandler(this.cmbCameras_SelectedIndexChanged);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.gameGroup,
            this.acPrint,
            this.acFullscreen});
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Single;
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 608);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // gameGroup
            // 
            this.gameGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acStart,
            this.acReset,
            this.acStop});
            this.gameGroup.Expanded = true;
            this.gameGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gameGroup.ImageOptions.Image")));
            this.gameGroup.Name = "gameGroup";
            this.gameGroup.Text = "Game";
            // 
            // acStart
            // 
            this.acStart.Name = "acStart";
            this.acStart.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acStart.Text = "New Round";
            this.acStart.Click += new System.EventHandler(this.acStart_Click);
            // 
            // acReset
            // 
            this.acReset.Name = "acReset";
            this.acReset.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acReset.Text = "Reset Round";
            this.acReset.Click += new System.EventHandler(this.acReset_Click);
            // 
            // acStop
            // 
            this.acStop.Name = "acStop";
            this.acStop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acStop.Text = "Stop";
            this.acStop.Click += new System.EventHandler(this.acStop_Click);
            // 
            // acPrint
            // 
            this.acPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acPrint.ImageOptions.Image")));
            this.acPrint.Name = "acPrint";
            this.acPrint.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acPrint.Text = "Print";
            this.acPrint.Click += new System.EventHandler(this.acPrint_Click);
            // 
            // acFullscreen
            // 
            this.acFullscreen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acFullscreen.ImageOptions.Image")));
            this.acFullscreen.Name = "acFullscreen";
            this.acFullscreen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acFullscreen.Text = "Fullscreen";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1034, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.prgNeutral);
            this.panelControl1.Controls.Add(this.lblNeutral);
            this.panelControl1.Controls.Add(this.prgContempt);
            this.panelControl1.Controls.Add(this.lblContempt);
            this.panelControl1.Controls.Add(this.prgDisgust);
            this.panelControl1.Controls.Add(this.lblDisgust);
            this.panelControl1.Controls.Add(this.prgSurprise);
            this.panelControl1.Controls.Add(this.lblSurprise);
            this.panelControl1.Controls.Add(this.prgSadness);
            this.panelControl1.Controls.Add(this.lblSadness);
            this.panelControl1.Controls.Add(this.prgAnger);
            this.panelControl1.Controls.Add(this.lblAnger);
            this.panelControl1.Controls.Add(this.prgHappines);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(561, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(20);
            this.panelControl1.Size = new System.Drawing.Size(213, 608);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(22, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Šťastie";
            // 
            // prgHappines
            // 
            this.prgHappines.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgHappines.Location = new System.Drawing.Point(22, 35);
            this.prgHappines.Name = "prgHappines";
            this.prgHappines.Size = new System.Drawing.Size(169, 18);
            this.prgHappines.TabIndex = 1;
            // 
            // prgAnger
            // 
            this.prgAnger.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgAnger.Location = new System.Drawing.Point(22, 86);
            this.prgAnger.Name = "prgAnger";
            this.prgAnger.Size = new System.Drawing.Size(169, 18);
            this.prgAnger.TabIndex = 3;
            // 
            // lblAnger
            // 
            this.lblAnger.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblAnger.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAnger.Location = new System.Drawing.Point(22, 53);
            this.lblAnger.Name = "lblAnger";
            this.lblAnger.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblAnger.Size = new System.Drawing.Size(169, 33);
            this.lblAnger.TabIndex = 2;
            this.lblAnger.Text = "Hnev";
            // 
            // prgSadness
            // 
            this.prgSadness.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgSadness.Location = new System.Drawing.Point(22, 137);
            this.prgSadness.Name = "prgSadness";
            this.prgSadness.Size = new System.Drawing.Size(169, 18);
            this.prgSadness.TabIndex = 5;
            // 
            // lblSadness
            // 
            this.lblSadness.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblSadness.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSadness.Location = new System.Drawing.Point(22, 104);
            this.lblSadness.Name = "lblSadness";
            this.lblSadness.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblSadness.Size = new System.Drawing.Size(169, 33);
            this.lblSadness.TabIndex = 4;
            this.lblSadness.Text = "Smútok";
            // 
            // prgSurprise
            // 
            this.prgSurprise.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgSurprise.Location = new System.Drawing.Point(22, 188);
            this.prgSurprise.Name = "prgSurprise";
            this.prgSurprise.Size = new System.Drawing.Size(169, 18);
            this.prgSurprise.TabIndex = 7;
            // 
            // lblSurprise
            // 
            this.lblSurprise.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblSurprise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurprise.Location = new System.Drawing.Point(22, 155);
            this.lblSurprise.Name = "lblSurprise";
            this.lblSurprise.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblSurprise.Size = new System.Drawing.Size(169, 33);
            this.lblSurprise.TabIndex = 6;
            this.lblSurprise.Text = "Prekvapenie";
            // 
            // prgDisgust
            // 
            this.prgDisgust.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgDisgust.Location = new System.Drawing.Point(22, 239);
            this.prgDisgust.Name = "prgDisgust";
            this.prgDisgust.Size = new System.Drawing.Size(169, 18);
            this.prgDisgust.TabIndex = 9;
            // 
            // lblDisgust
            // 
            this.lblDisgust.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblDisgust.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisgust.Location = new System.Drawing.Point(22, 206);
            this.lblDisgust.Name = "lblDisgust";
            this.lblDisgust.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblDisgust.Size = new System.Drawing.Size(169, 33);
            this.lblDisgust.TabIndex = 8;
            this.lblDisgust.Text = "Znechutenie";
            // 
            // prgContempt
            // 
            this.prgContempt.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgContempt.Location = new System.Drawing.Point(22, 290);
            this.prgContempt.Name = "prgContempt";
            this.prgContempt.Size = new System.Drawing.Size(169, 18);
            this.prgContempt.TabIndex = 11;
            // 
            // lblContempt
            // 
            this.lblContempt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblContempt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContempt.Location = new System.Drawing.Point(22, 257);
            this.lblContempt.Name = "lblContempt";
            this.lblContempt.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblContempt.Size = new System.Drawing.Size(169, 33);
            this.lblContempt.TabIndex = 10;
            this.lblContempt.Text = "Opovrhnutie";
            // 
            // prgNeutral
            // 
            this.prgNeutral.Dock = System.Windows.Forms.DockStyle.Top;
            this.prgNeutral.Location = new System.Drawing.Point(22, 341);
            this.prgNeutral.Name = "prgNeutral";
            this.prgNeutral.Size = new System.Drawing.Size(169, 18);
            this.prgNeutral.TabIndex = 13;
            // 
            // lblNeutral
            // 
            this.lblNeutral.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblNeutral.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNeutral.Location = new System.Drawing.Point(22, 308);
            this.lblNeutral.Name = "lblNeutral";
            this.lblNeutral.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblNeutral.Size = new System.Drawing.Size(169, 33);
            this.lblNeutral.TabIndex = 12;
            this.lblNeutral.Text = "Neutral";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 638);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prgHappines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgAnger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgSadness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgSurprise.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgDisgust.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgContempt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prgNeutral.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement gameGroup;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCameras;
        private DevExpress.XtraEditors.ComboBoxEdit cmbResolutions;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acReset;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acPrint;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFullscreen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStop;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ProgressBarControl prgDisgust;
        private DevExpress.XtraEditors.LabelControl lblDisgust;
        private DevExpress.XtraEditors.ProgressBarControl prgSurprise;
        private DevExpress.XtraEditors.LabelControl lblSurprise;
        private DevExpress.XtraEditors.ProgressBarControl prgSadness;
        private DevExpress.XtraEditors.LabelControl lblSadness;
        private DevExpress.XtraEditors.ProgressBarControl prgAnger;
        private DevExpress.XtraEditors.LabelControl lblAnger;
        private DevExpress.XtraEditors.ProgressBarControl prgHappines;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ProgressBarControl prgContempt;
        private DevExpress.XtraEditors.LabelControl lblContempt;
        private DevExpress.XtraEditors.ProgressBarControl prgNeutral;
        private DevExpress.XtraEditors.LabelControl lblNeutral;
    }
}