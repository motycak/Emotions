namespace winForm2
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabCamera = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabEmotion = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabSettings = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cmbResolutions = new System.Windows.Forms.ComboBox();
            this.cmbCameras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabEmotion.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridGroupingControl1.Size = new System.Drawing.Size(1039, 554);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowEdit = false;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.AllowRemove = false;
            gridColumnDescriptor1.HeaderText = "Nahnevaný";
            gridColumnDescriptor1.MappingName = "Anger";
            gridColumnDescriptor1.Width = 75;
            gridColumnDescriptor2.HeaderText = "Opovrhnutie";
            gridColumnDescriptor2.MappingName = "Contempt";
            gridColumnDescriptor2.Width = 79;
            gridColumnDescriptor3.HeaderText = "Znechutenie";
            gridColumnDescriptor3.MappingName = "Disgust";
            gridColumnDescriptor3.Width = 79;
            gridColumnDescriptor4.HeaderText = "Strach";
            gridColumnDescriptor4.MappingName = "Fear";
            gridColumnDescriptor5.HeaderText = "Šťastie";
            gridColumnDescriptor5.MappingName = "Happiness";
            gridColumnDescriptor6.HeaderText = "Neutral";
            gridColumnDescriptor6.MappingName = "Neutral";
            gridColumnDescriptor6.ReadOnly = true;
            gridColumnDescriptor7.HeaderText = "Smútok";
            gridColumnDescriptor7.MappingName = "Sadness";
            gridColumnDescriptor8.HeaderText = "Prekvapenie";
            gridColumnDescriptor8.MappingName = "Surprise";
            gridColumnDescriptor8.Width = 84;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Image"),
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            gridColumnDescriptor7,
            gridColumnDescriptor8});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 25;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridGroupingControl1.VersionInfo = "15.2460.0.40";
            this.gridGroupingControl1.TableControlCellDrawn += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableControlDrawCellEventHandler(this.gridGroupingControl1_TableControlCellDrawn);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(1042, 636);
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabCamera);
            this.tabControlAdv1.Controls.Add(this.tabEmotion);
            this.tabControlAdv1.Controls.Add(this.tabSettings);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.InActiveTabForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.SeparatorColor = System.Drawing.SystemColors.ControlDark;
            this.tabControlAdv1.ShowSeparator = false;
            this.tabControlAdv1.Size = new System.Drawing.Size(1042, 636);
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.pictureBox1);
            this.tabCamera.Image = null;
            this.tabCamera.ImageSize = new System.Drawing.Size(16, 16);
            this.tabCamera.Location = new System.Drawing.Point(1, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.ShowCloseButton = true;
            this.tabCamera.Size = new System.Drawing.Size(1039, 612);
            this.tabCamera.TabIndex = 2;
            this.tabCamera.Text = "Kamera";
            this.tabCamera.ThemesEnabled = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1018, 584);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabEmotion
            // 
            this.tabEmotion.Controls.Add(this.gridGroupingControl1);
            this.tabEmotion.Image = null;
            this.tabEmotion.ImageSize = new System.Drawing.Size(16, 16);
            this.tabEmotion.Location = new System.Drawing.Point(1, 22);
            this.tabEmotion.Name = "tabEmotion";
            this.tabEmotion.ShowCloseButton = true;
            this.tabEmotion.Size = new System.Drawing.Size(1039, 612);
            this.tabEmotion.TabIndex = 1;
            this.tabEmotion.Text = "Aktuálne Emócie";
            this.tabEmotion.ThemesEnabled = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.autoLabel2);
            this.tabSettings.Controls.Add(this.autoLabel1);
            this.tabSettings.Controls.Add(this.cmbResolutions);
            this.tabSettings.Controls.Add(this.cmbCameras);
            this.tabSettings.Image = null;
            this.tabSettings.ImageSize = new System.Drawing.Size(16, 16);
            this.tabSettings.Location = new System.Drawing.Point(1, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.ShowCloseButton = true;
            this.tabSettings.Size = new System.Drawing.Size(1039, 612);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Nastavenia";
            this.tabSettings.ThemesEnabled = false;
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoLabel2.Location = new System.Drawing.Point(11, 80);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(65, 15);
            this.autoLabel2.TabIndex = 3;
            this.autoLabel2.Text = "Rozlíšenie";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoLabel1.Location = new System.Drawing.Point(11, 53);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(51, 15);
            this.autoLabel1.TabIndex = 2;
            this.autoLabel1.Text = "Kamera";
            // 
            // cmbResolutions
            // 
            this.cmbResolutions.FormattingEnabled = true;
            this.cmbResolutions.Location = new System.Drawing.Point(109, 80);
            this.cmbResolutions.Name = "cmbResolutions";
            this.cmbResolutions.Size = new System.Drawing.Size(121, 21);
            this.cmbResolutions.TabIndex = 1;
            this.cmbResolutions.SelectedIndexChanged += new System.EventHandler(this.cmbResolutions_SelectedIndexChanged);
            // 
            // cmbCameras
            // 
            this.cmbCameras.FormattingEnabled = true;
            this.cmbCameras.Location = new System.Drawing.Point(109, 53);
            this.cmbCameras.Name = "cmbCameras";
            this.cmbCameras.Size = new System.Drawing.Size(121, 21);
            this.cmbCameras.TabIndex = 0;
            this.cmbCameras.SelectedIndexChanged += new System.EventHandler(this.cmbCameras_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1042, 636);
            this.Controls.Add(this.tabControlAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartFeedback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabEmotion.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabEmotion;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabCamera;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbResolutions;
        private System.Windows.Forms.ComboBox cmbCameras;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
    }
}

