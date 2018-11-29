namespace NOAA_Monitor
{
    partial class MainWindow
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.dataList = new MaterialSkin.Controls.MaterialListView();
            this.stationBox = new System.Windows.Forms.GroupBox();
            this.stationList = new MaterialSkin.Controls.MaterialListView();
            this.stationPicture = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mapButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.esriButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.graphButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.reportButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.updateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataBox.SuspendLayout();
            this.stationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBrowser
            // 
            this.mapBrowser.Location = new System.Drawing.Point(274, 181);
            this.mapBrowser.Margin = new System.Windows.Forms.Padding(12);
            this.mapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.Size = new System.Drawing.Size(564, 463);
            this.mapBrowser.TabIndex = 0;
            // 
            // dataBox
            // 
            this.dataBox.Controls.Add(this.dataList);
            this.dataBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBox.Location = new System.Drawing.Point(21, 248);
            this.dataBox.Margin = new System.Windows.Forms.Padding(12);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(237, 405);
            this.dataBox.TabIndex = 8;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Buoy Data";
            // 
            // dataList
            // 
            this.dataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataList.Depth = 0;
            this.dataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.dataList.FullRowSelect = true;
            this.dataList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.dataList.Location = new System.Drawing.Point(6, 25);
            this.dataList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dataList.MouseState = MaterialSkin.MouseState.OUT;
            this.dataList.Name = "dataList";
            this.dataList.OwnerDraw = true;
            this.dataList.Size = new System.Drawing.Size(225, 371);
            this.dataList.TabIndex = 0;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.View = System.Windows.Forms.View.Details;
            // 
            // stationBox
            // 
            this.stationBox.Controls.Add(this.stationList);
            this.stationBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stationBox.Location = new System.Drawing.Point(895, 304);
            this.stationBox.Margin = new System.Windows.Forms.Padding(12);
            this.stationBox.Name = "stationBox";
            this.stationBox.Size = new System.Drawing.Size(273, 400);
            this.stationBox.TabIndex = 9;
            this.stationBox.TabStop = false;
            // 
            // stationList
            // 
            this.stationList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.stationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stationList.Depth = 0;
            this.stationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.stationList.FullRowSelect = true;
            this.stationList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.stationList.Location = new System.Drawing.Point(6, 25);
            this.stationList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.stationList.MouseState = MaterialSkin.MouseState.OUT;
            this.stationList.Name = "stationList";
            this.stationList.OwnerDraw = true;
            this.stationList.Size = new System.Drawing.Size(261, 369);
            this.stationList.TabIndex = 0;
            this.stationList.UseCompatibleStateImageBehavior = false;
            this.stationList.View = System.Windows.Forms.View.Details;
            this.stationList.SelectedIndexChanged += new System.EventHandler(this.stationList_SelectedIndexChanged);
            // 
            // stationPicture
            // 
            this.stationPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stationPicture.Location = new System.Drawing.Point(895, 86);
            this.stationPicture.Margin = new System.Windows.Forms.Padding(12);
            this.stationPicture.Name = "stationPicture";
            this.stationPicture.Size = new System.Drawing.Size(273, 194);
            this.stationPicture.TabIndex = 10;
            this.stationPicture.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 677);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(392, 27);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Last Update: YYYY-MM-DD hh:mm GMT";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(772, 662);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(66, 36);
            this.materialRaisedButton1.TabIndex = 13;
            this.materialRaisedButton1.Text = "Exit";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(659, 662);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(12);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(74, 36);
            this.materialRaisedButton2.TabIndex = 14;
            this.materialRaisedButton2.Text = "Save";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(870, 86);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 618);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mapButton
            // 
            this.mapButton.AutoSize = true;
            this.mapButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapButton.Depth = 0;
            this.mapButton.Icon = null;
            this.mapButton.Location = new System.Drawing.Point(607, 122);
            this.mapButton.Margin = new System.Windows.Forms.Padding(12);
            this.mapButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mapButton.Name = "mapButton";
            this.mapButton.Primary = false;
            this.mapButton.Size = new System.Drawing.Size(68, 36);
            this.mapButton.TabIndex = 18;
            this.mapButton.Text = "Map";
            this.mapButton.UseVisualStyleBackColor = true;
            // 
            // esriButton
            // 
            this.esriButton.AutoSize = true;
            this.esriButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.esriButton.Depth = 0;
            this.esriButton.Icon = null;
            this.esriButton.Location = new System.Drawing.Point(508, 122);
            this.esriButton.Margin = new System.Windows.Forms.Padding(12);
            this.esriButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.esriButton.Name = "esriButton";
            this.esriButton.Primary = false;
            this.esriButton.Size = new System.Drawing.Size(66, 36);
            this.esriButton.TabIndex = 19;
            this.esriButton.Text = "ESRI";
            this.esriButton.UseVisualStyleBackColor = true;
            // 
            // graphButton
            // 
            this.graphButton.AutoSize = true;
            this.graphButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphButton.Depth = 0;
            this.graphButton.Icon = null;
            this.graphButton.Location = new System.Drawing.Point(381, 122);
            this.graphButton.Margin = new System.Windows.Forms.Padding(12);
            this.graphButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.graphButton.Name = "graphButton";
            this.graphButton.Primary = false;
            this.graphButton.Size = new System.Drawing.Size(92, 36);
            this.graphButton.TabIndex = 20;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.AutoSize = true;
            this.reportButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportButton.Depth = 0;
            this.reportButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Icon = null;
            this.reportButton.Location = new System.Drawing.Point(21, 181);
            this.reportButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reportButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportButton.Name = "reportButton";
            this.reportButton.Primary = false;
            this.reportButton.Size = new System.Drawing.Size(208, 36);
            this.reportButton.TabIndex = 21;
            this.reportButton.Text = "Generate Report";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Depth = 0;
            this.updateButton.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(21, 115);
            this.updateButton.Margin = new System.Windows.Forms.Padding(16);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = false;
            this.updateButton.Size = new System.Drawing.Size(160, 36);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update Data";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 725);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.esriButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.stationPicture);
            this.Controls.Add(this.stationBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.mapBrowser);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAA Monitor: US Northeast";
            this.dataBox.ResumeLayout(false);
            this.stationBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.GroupBox stationBox;
        private System.Windows.Forms.PictureBox stationPicture;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton mapButton;
        private MaterialSkin.Controls.MaterialFlatButton esriButton;
        private MaterialSkin.Controls.MaterialFlatButton graphButton;
        private MaterialSkin.Controls.MaterialFlatButton reportButton;
        private MaterialSkin.Controls.MaterialFlatButton updateButton;
        private MaterialSkin.Controls.MaterialListView dataList;
        private MaterialSkin.Controls.MaterialListView stationList;
    }
}

