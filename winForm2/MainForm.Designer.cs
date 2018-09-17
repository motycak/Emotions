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
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.cmbResolutions = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbCameras = new DevExpress.XtraEditors.ComboBoxEdit();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.gameGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acStart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acReset = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acPrint = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acFullscreen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.pictureBox);
            this.fluentDesignFormContainer1.Controls.Add(this.lblTitle);
            this.fluentDesignFormContainer1.Controls.Add(this.progressBarControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.cmbResolutions);
            this.fluentDesignFormContainer1.Controls.Add(this.cmbCameras);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(44, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(990, 608);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(812, 512);
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
            this.lblTitle.Size = new System.Drawing.Size(812, 96);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "labelControl1";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBarControl1.EditValue = 50;
            this.progressBarControl1.Location = new System.Drawing.Point(812, 0);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ProgressKind = DevExpress.XtraEditors.Controls.ProgressKind.Vertical;
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            this.progressBarControl1.Size = new System.Drawing.Size(178, 608);
            this.progressBarControl1.TabIndex = 4;
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
            this.acStart.Name = "acStart";
            this.acStart.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acStart.Text = "New Round";
            // 
            // acReset
            // 
            this.acReset.Name = "acReset";
            this.acReset.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acReset.Text = "Reset Round";
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
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
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
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acStart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acReset;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acPrint;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acFullscreen;
    }
}