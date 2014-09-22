namespace Quick_Location_Finder
{
    partial class frmMainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.mapViewer = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.zoomLevels = new System.Windows.Forms.ComboBox();
            this.mapTypeColombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fullAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLongtitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.mapViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textLocation);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Location";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(691, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(9, 16);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(676, 20);
            this.textLocation.TabIndex = 0;
            this.textLocation.TextChanged += new System.EventHandler(this.textLocation_TextChanged);
            // 
            // mapViewer
            // 
            this.mapViewer.Controls.Add(this.webBrowser1);
            this.mapViewer.Location = new System.Drawing.Point(184, 65);
            this.mapViewer.Name = "mapViewer";
            this.mapViewer.Size = new System.Drawing.Size(587, 485);
            this.mapViewer.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(587, 485);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // zoomLevels
            // 
            this.zoomLevels.FormattingEnabled = true;
            this.zoomLevels.Items.AddRange(new object[] {
            "5 ",
            "8 ",
            "10 ",
            "12 ",
            "15 ",
            "18 ",
            "20"});
            this.zoomLevels.Location = new System.Drawing.Point(14, 65);
            this.zoomLevels.Name = "zoomLevels";
            this.zoomLevels.Size = new System.Drawing.Size(155, 21);
            this.zoomLevels.TabIndex = 2;
            this.zoomLevels.Text = "Select Zoom Levels";
            // 
            // mapTypeColombo
            // 
            this.mapTypeColombo.FormattingEnabled = true;
            this.mapTypeColombo.Items.AddRange(new object[] {
            "roadmap",
            "satellite ",
            "hybrid",
            "terrain"});
            this.mapTypeColombo.Location = new System.Drawing.Point(14, 101);
            this.mapTypeColombo.Name = "mapTypeColombo";
            this.mapTypeColombo.Size = new System.Drawing.Size(155, 21);
            this.mapTypeColombo.TabIndex = 3;
            this.mapTypeColombo.Text = "Select Map Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Address";
            // 
            // fullAddress
            // 
            this.fullAddress.Location = new System.Drawing.Point(21, 165);
            this.fullAddress.Multiline = true;
            this.fullAddress.Name = "fullAddress";
            this.fullAddress.ReadOnly = true;
            this.fullAddress.Size = new System.Drawing.Size(148, 145);
            this.fullAddress.TabIndex = 5;
            this.fullAddress.TextChanged += new System.EventHandler(this.fullAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longtitude";
            // 
            // txtLongtitude
            // 
            this.txtLongtitude.Location = new System.Drawing.Point(21, 340);
            this.txtLongtitude.Name = "txtLongtitude";
            this.txtLongtitude.Size = new System.Drawing.Size(148, 20);
            this.txtLongtitude.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(21, 396);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(148, 20);
            this.txtLatitude.TabIndex = 9;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quick_Location_Finder.Properties.Resources.Glass_plasma_globe;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLongtitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapTypeColombo);
            this.Controls.Add(this.zoomLevels);
            this.Controls.Add(this.mapViewer);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "Quick Location Finder";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mapViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel mapViewer;
        private System.Windows.Forms.ComboBox zoomLevels;
        private System.Windows.Forms.ComboBox mapTypeColombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fullAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLongtitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

