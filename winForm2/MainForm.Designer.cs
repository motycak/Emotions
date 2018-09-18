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
            this.main1 = new Emotions.Components.Main();
            this.settings1 = new Emotions.Components.Settings();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.gameGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acStart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acReset = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acStop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.toolsGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acPrint = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acFullscreen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.main1);
            this.fluentDesignFormContainer1.Controls.Add(this.settings1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(44, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(990, 608);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // main1
            // 
            this.main1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main1.Location = new System.Drawing.Point(0, 0);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(990, 608);
            this.main1.TabIndex = 0;
            // 
            // settings1
            // 
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(990, 608);
            this.settings1.TabIndex = 1;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.gameGroup,
            this.toolsGroup});
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 260;
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(44, 608);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // gameGroup
            // 
            this.gameGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acStart,
            this.acReset});
            this.gameGroup.Expanded = true;
            this.gameGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gameGroup.ImageOptions.Image")));
            this.gameGroup.Name = "gameGroup";
            this.gameGroup.Text = "Game";
            // 
            // acStart
            // 
            this.acStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acStart.ImageOptions.Image")));
            this.acStart.Name = "acStart";
            this.acStart.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acStart.Text = "New Round";
            this.acStart.Click += new System.EventHandler(this.acStart_Click);
            // 
            // acReset
            // 
            this.acReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acReset.ImageOptions.Image")));
            this.acReset.Name = "acReset";
            this.acReset.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acReset.Text = "Restart Round";
            this.acReset.Click += new System.EventHandler(this.acReset_Click);
            // 
            // acStop
            // 
            this.acStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acStop.ImageOptions.Image")));
            this.acStop.Name = "acStop";
            this.acStop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acStop.Text = "Stop";
            this.acStop.Click += new System.EventHandler(this.acStop_Click);
            // 
            // toolsGroup
            // 
            this.toolsGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acPrint,
            this.acFullscreen,
            this.acSettings});
            this.toolsGroup.Expanded = true;
            this.toolsGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolsGroup.ImageOptions.Image")));
            this.toolsGroup.Name = "toolsGroup";
            this.toolsGroup.Text = "Tools";
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
            this.acFullscreen.Text = "Clear";
            this.acFullscreen.Click += new System.EventHandler(this.acFullscreen_Click);
            // 
            // acSettings
            // 
            this.acSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acSettings.ImageOptions.Image")));
            this.acSettings.Name = "acSettings";
            this.acSettings.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acSettings.Text = "Settings";
            this.acSettings.Click += new System.EventHandler(this.acSettings_Click);
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
            this.Text = "Emotion Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement gameGroup;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acReset;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acPrint;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFullscreen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStop;
        private Components.Main main1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acSettings;
        private Components.Settings settings1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement toolsGroup;
    }
}