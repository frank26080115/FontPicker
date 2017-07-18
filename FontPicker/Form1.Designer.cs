namespace FontPicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExample = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFontFilter = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.panelContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchPath = new System.Windows.Forms.TextBox();
            this.btnSearchBrowse = new System.Windows.Forms.Button();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.grpboxFontSize = new System.Windows.Forms.GroupBox();
            this.trkFontSize = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpboxFontSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtExample);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(611, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Example Text";
            // 
            // txtExample
            // 
            this.txtExample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExample.Location = new System.Drawing.Point(3, 16);
            this.txtExample.Margin = new System.Windows.Forms.Padding(2);
            this.txtExample.Name = "txtExample";
            this.txtExample.Size = new System.Drawing.Size(604, 20);
            this.txtExample.TabIndex = 2;
            this.txtExample.TextChanged += new System.EventHandler(this.txtExample_TextChanged);
            this.txtExample.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExample_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtFontFilter);
            this.groupBox2.Location = new System.Drawing.Point(6, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(611, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Filter";
            // 
            // txtFontFilter
            // 
            this.txtFontFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFontFilter.Location = new System.Drawing.Point(3, 16);
            this.txtFontFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFontFilter.Name = "txtFontFilter";
            this.txtFontFilter.Size = new System.Drawing.Size(604, 20);
            this.txtFontFilter.TabIndex = 4;
            this.txtFontFilter.TextChanged += new System.EventHandler(this.txtFontFilter_TextChanged);
            this.txtFontFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFontFilter_KeyDown);
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.panelContent);
            this.grpResults.Location = new System.Drawing.Point(6, 101);
            this.grpResults.Margin = new System.Windows.Forms.Padding(2);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(2);
            this.grpResults.Size = new System.Drawing.Size(641, 423);
            this.grpResults.TabIndex = 6;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(2, 15);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelContent.Size = new System.Drawing.Size(637, 406);
            this.panelContent.TabIndex = 7;
            this.panelContent.Click += new System.EventHandler(this.panelContent_Click);
            this.panelContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelContent_MouseDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(620, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 92);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkSubfolders);
            this.groupBox3.Controls.Add(this.btnSearchBrowse);
            this.groupBox3.Controls.Add(this.txtSearchPath);
            this.groupBox3.Location = new System.Drawing.Point(8, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 53);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Folder";
            // 
            // txtSearchPath
            // 
            this.txtSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPath.Location = new System.Drawing.Point(6, 19);
            this.txtSearchPath.Name = "txtSearchPath";
            this.txtSearchPath.Size = new System.Drawing.Size(537, 20);
            this.txtSearchPath.TabIndex = 0;
            this.txtSearchPath.TextChanged += new System.EventHandler(this.txtSearchPath_TextChanged);
            // 
            // btnSearchBrowse
            // 
            this.btnSearchBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchBrowse.Location = new System.Drawing.Point(549, 16);
            this.btnSearchBrowse.Name = "btnSearchBrowse";
            this.btnSearchBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBrowse.TabIndex = 1;
            this.btnSearchBrowse.Text = "Browse";
            this.btnSearchBrowse.UseVisualStyleBackColor = true;
            this.btnSearchBrowse.Click += new System.EventHandler(this.btnSearchBrowse_Click);
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(630, 21);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(82, 17);
            this.chkSubfolders.TabIndex = 2;
            this.chkSubfolders.Text = "Subfolders?";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            this.chkSubfolders.CheckedChanged += new System.EventHandler(this.chkSubfolders_CheckedChanged);
            // 
            // grpboxFontSize
            // 
            this.grpboxFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxFontSize.Controls.Add(this.trkFontSize);
            this.grpboxFontSize.Location = new System.Drawing.Point(652, 101);
            this.grpboxFontSize.Name = "grpboxFontSize";
            this.grpboxFontSize.Size = new System.Drawing.Size(74, 421);
            this.grpboxFontSize.TabIndex = 8;
            this.grpboxFontSize.TabStop = false;
            this.grpboxFontSize.Text = "Size";
            // 
            // trkFontSize
            // 
            this.trkFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkFontSize.LargeChange = 24;
            this.trkFontSize.Location = new System.Drawing.Point(6, 19);
            this.trkFontSize.Maximum = 100;
            this.trkFontSize.Minimum = 8;
            this.trkFontSize.Name = "trkFontSize";
            this.trkFontSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkFontSize.Size = new System.Drawing.Size(45, 396);
            this.trkFontSize.SmallChange = 4;
            this.trkFontSize.TabIndex = 0;
            this.trkFontSize.Value = 20;
            this.trkFontSize.Scroll += new System.EventHandler(this.trkFontSize_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 594);
            this.Controls.Add(this.grpboxFontSize);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Font Picker";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpboxFontSize.ResumeLayout(false);
            this.grpboxFontSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtExample;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFontFilter;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.FlowLayoutPanel panelContent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Button btnSearchBrowse;
        private System.Windows.Forms.TextBox txtSearchPath;
        private System.Windows.Forms.GroupBox grpboxFontSize;
        private System.Windows.Forms.TrackBar trkFontSize;
        private System.Windows.Forms.Timer timer1;
    }
}

