namespace Emotions.Components
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbCameras = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbResolutions = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCameras
            // 
            this.cmbCameras.Location = new System.Drawing.Point(88, 22);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCameras.Size = new System.Drawing.Size(243, 20);
            this.cmbCameras.TabIndex = 0;
            this.cmbCameras.EditValueChanged += new System.EventHandler(this.cmbCameras_EditValueChanged);
            // 
            // cmbResolutions
            // 
            this.cmbResolutions.Location = new System.Drawing.Point(88, 48);
            this.cmbResolutions.Name = "cmbResolutions";
            this.cmbResolutions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbResolutions.Size = new System.Drawing.Size(243, 20);
            this.cmbResolutions.TabIndex = 1;
            this.cmbResolutions.EditValueChanged += new System.EventHandler(this.cmbResolutions_EditValueChanged);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.settingsInfoBindingSource, "FaceApiKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsInfoBindingSource, "FaceApiKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEdit1.Location = new System.Drawing.Point(87, 74);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(244, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FaceApi Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolutions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Camera";
            // 
            // settingsInfoBindingSource
            // 
            this.settingsInfoBindingSource.DataSource = typeof(Emotions.SettingsInfo);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.cmbResolutions);
            this.Controls.Add(this.cmbCameras);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(543, 307);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResolutions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbCameras;
        private DevExpress.XtraEditors.ComboBoxEdit cmbResolutions;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        public System.Windows.Forms.BindingSource settingsInfoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
