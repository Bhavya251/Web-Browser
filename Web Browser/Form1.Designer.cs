namespace Web_Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.mlNext = new MetroFramework.Controls.MetroLink();
            this.txtPageURL = new MetroFramework.Controls.MetroTextBox();
            this.mbtnSearch = new MetroFramework.Controls.MetroButton();
            this.mbtnNewTab = new MetroFramework.Controls.MetroButton();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(545, 452);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 0;
            this.metroUserControl1.UseSelectable = true;
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 24;
            this.mlBack.Location = new System.Drawing.Point(23, 63);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(32, 32);
            this.mlBack.TabIndex = 1;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // mlNext
            // 
            this.mlNext.Image = ((System.Drawing.Image)(resources.GetObject("mlNext.Image")));
            this.mlNext.ImageSize = 20;
            this.mlNext.Location = new System.Drawing.Point(58, 63);
            this.mlNext.Name = "mlNext";
            this.mlNext.Size = new System.Drawing.Size(32, 32);
            this.mlNext.TabIndex = 2;
            this.mlNext.UseSelectable = true;
            this.mlNext.Click += new System.EventHandler(this.mlNext_Click);
            // 
            // txtPageURL
            // 
            this.txtPageURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPageURL.CustomButton.Image = null;
            this.txtPageURL.CustomButton.Location = new System.Drawing.Point(474, 1);
            this.txtPageURL.CustomButton.Name = "";
            this.txtPageURL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPageURL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPageURL.CustomButton.TabIndex = 1;
            this.txtPageURL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPageURL.CustomButton.UseSelectable = true;
            this.txtPageURL.CustomButton.Visible = false;
            this.txtPageURL.Lines = new string[0];
            this.txtPageURL.Location = new System.Drawing.Point(96, 69);
            this.txtPageURL.MaxLength = 32767;
            this.txtPageURL.Name = "txtPageURL";
            this.txtPageURL.PasswordChar = '\0';
            this.txtPageURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPageURL.SelectedText = "";
            this.txtPageURL.SelectionLength = 0;
            this.txtPageURL.SelectionStart = 0;
            this.txtPageURL.ShortcutsEnabled = true;
            this.txtPageURL.Size = new System.Drawing.Size(496, 23);
            this.txtPageURL.TabIndex = 3;
            this.txtPageURL.UseSelectable = true;
            this.txtPageURL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPageURL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnSearch
            // 
            this.mbtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnSearch.Location = new System.Drawing.Point(598, 69);
            this.mbtnSearch.Name = "mbtnSearch";
            this.mbtnSearch.Size = new System.Drawing.Size(33, 23);
            this.mbtnSearch.TabIndex = 4;
            this.mbtnSearch.Text = "Go";
            this.mbtnSearch.UseSelectable = true;
            this.mbtnSearch.Click += new System.EventHandler(this.mbtnSearch_Click);
            // 
            // mbtnNewTab
            // 
            this.mbtnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnNewTab.Location = new System.Drawing.Point(637, 69);
            this.mbtnNewTab.Name = "mbtnNewTab";
            this.mbtnNewTab.Size = new System.Drawing.Size(75, 23);
            this.mbtnNewTab.TabIndex = 5;
            this.mbtnNewTab.Text = "New Tab";
            this.mbtnNewTab.UseSelectable = true;
            this.mbtnNewTab.Click += new System.EventHandler(this.mbtnNewTab_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl.Location = new System.Drawing.Point(23, 101);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(686, 303);
            this.metroTabControl.TabIndex = 6;
            this.metroTabControl.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 427);
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.mbtnNewTab);
            this.Controls.Add(this.mbtnSearch);
            this.Controls.Add(this.txtPageURL);
            this.Controls.Add(this.mlNext);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.metroUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroLink mlNext;
        private MetroFramework.Controls.MetroTextBox txtPageURL;
        private MetroFramework.Controls.MetroButton mbtnSearch;
        private MetroFramework.Controls.MetroButton mbtnNewTab;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
    }
}

