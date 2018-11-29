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
            this.stationBox = new System.Windows.Forms.GroupBox();
            this.stationList = new MaterialSkin.Controls.MaterialListView();
            this.stationPicture = new System.Windows.Forms.PictureBox();
            this.updateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mapButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.esriButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.graphButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.reportButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.updateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.mapBrowser.Url = new System.Uri("", System.UriKind.Relative);
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
            this.stationList.HoverSelection = true;
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
            this.stationPicture.Location = new System.Drawing.Point(923, 115);
            this.stationPicture.Margin = new System.Windows.Forms.Padding(12);
            this.stationPicture.Name = "stationPicture";
            this.stationPicture.Size = new System.Drawing.Size(210, 183);
            this.stationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stationPicture.TabIndex = 10;
            this.stationPicture.TabStop = false;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Depth = 0;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.updateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateLabel.Location = new System.Drawing.Point(21, 689);
            this.updateLabel.Margin = new System.Windows.Forms.Padding(12);
            this.updateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(0, 26);
            this.updateLabel.TabIndex = 11;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(772, 647);
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
            this.materialRaisedButton2.Location = new System.Drawing.Point(659, 647);
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
            this.materialDivider1.Location = new System.Drawing.Point(870, 115);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 589);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mapButton
            // 
            this.mapButton.AutoSize = true;
            this.mapButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapButton.Depth = 0;
            this.mapButton.Icon = null;
            this.mapButton.Location = new System.Drawing.Point(770, 121);
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
            this.esriButton.Location = new System.Drawing.Point(671, 121);
            this.esriButton.Margin = new System.Windows.Forms.Padding(12);
            this.esriButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.esriButton.Name = "esriButton";
            this.esriButton.Primary = false;
            this.esriButton.Size = new System.Drawing.Size(62, 36);
            this.esriButton.TabIndex = 19;
            this.esriButton.Text = "SAT";
            this.esriButton.UseVisualStyleBackColor = true;
            // 
            // graphButton
            // 
            this.graphButton.AutoSize = true;
            this.graphButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphButton.Depth = 0;
            this.graphButton.Icon = null;
            this.graphButton.Location = new System.Drawing.Point(538, 121);
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
            this.reportButton.Location = new System.Drawing.Point(225, 121);
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
            this.updateButton.Location = new System.Drawing.Point(16, 121);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 610);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = " ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 645);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = " ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 725);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.esriButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.stationPicture);
            this.Controls.Add(this.stationBox);
            this.Controls.Add(this.mapBrowser);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOAA Monitor: US Northeast";
            this.stationBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.GroupBox stationBox;
        private System.Windows.Forms.PictureBox stationPicture;
        private MaterialSkin.Controls.MaterialLabel updateLabel;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        public MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton mapButton;
        private MaterialSkin.Controls.MaterialFlatButton esriButton;
        private MaterialSkin.Controls.MaterialFlatButton graphButton;
        private MaterialSkin.Controls.MaterialFlatButton reportButton;
        private MaterialSkin.Controls.MaterialFlatButton updateButton;
        private MaterialSkin.Controls.MaterialListView stationList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

