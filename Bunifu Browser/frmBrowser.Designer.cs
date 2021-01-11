namespace Bunifu_Browser
{
    partial class frmBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrowser));
            this.bunifuCards1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton5 = new System.Windows.Forms.Button();
            this.bunifuImageButton6 = new System.Windows.Forms.Button();
            this.txtSerachOrUrl = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bunifuToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgRefresh = new System.Windows.Forms.Button();
            this.imgSpinner = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;

            this.bunifuCards1.Controls.Add(this.bunifuImageButton5);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton6);
            this.bunifuCards1.Controls.Add(this.txtSerachOrUrl);
            this.bunifuCards1.Controls.Add(this.btnRefresh);
            this.bunifuCards1.Controls.Add(this.btnHome);
            this.bunifuCards1.Controls.Add(this.btnForward);
            this.bunifuCards1.Controls.Add(this.btnBack);

            this.bunifuCards1.Location = new System.Drawing.Point(-6, -6);
            this.bunifuCards1.Name = "bunifuCards1";

            this.bunifuCards1.Size = new System.Drawing.Size(1145, 66);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.bunifuCards1, "");

            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));

            this.bunifuImageButton5.Location = new System.Drawing.Point(1088, 20);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(30, 30);

            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "Settings");

            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));

            this.bunifuImageButton6.Location = new System.Drawing.Point(1042, 20);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(30, 30);

            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton6, "Downloads");

            // 
            // txtSerachOrUrl
            // 
            this.txtSerachOrUrl.AcceptsReturn = false;
            this.txtSerachOrUrl.AcceptsTab = false;
            this.txtSerachOrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));

            this.txtSerachOrUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSerachOrUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;

            this.txtSerachOrUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSerachOrUrl.BackgroundImage")));

            this.txtSerachOrUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSerachOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;

            this.txtSerachOrUrl.HideSelection = true;

            this.txtSerachOrUrl.Lines = new string[0];
            this.txtSerachOrUrl.Location = new System.Drawing.Point(226, 19);
            this.txtSerachOrUrl.MaxLength = 32767;
            this.txtSerachOrUrl.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSerachOrUrl.Modified = false;
            this.txtSerachOrUrl.Multiline = false;
            this.txtSerachOrUrl.Name = "txtSerachOrUrl";
            this.txtSerachOrUrl.PasswordChar = '\0';

            this.txtSerachOrUrl.ReadOnly = false;
            this.txtSerachOrUrl.SelectedText = "";
            this.txtSerachOrUrl.SelectionLength = 0;
            this.txtSerachOrUrl.SelectionStart = 0;
            this.txtSerachOrUrl.ShortcutsEnabled = true;
            this.txtSerachOrUrl.Size = new System.Drawing.Size(796, 37);

            this.txtSerachOrUrl.TabIndex = 5;
            this.txtSerachOrUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.bunifuToolTip1.SetToolTip(this.txtSerachOrUrl, "");

            this.txtSerachOrUrl.UseSystemPasswordChar = false;
            this.txtSerachOrUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerachOrUrl_KeyUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));

            this.btnRefresh.Location = new System.Drawing.Point(178, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);

            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");


            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));

            this.btnHome.Location = new System.Drawing.Point(127, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(30, 30);

            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "Home");

            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));

            this.btnForward.Location = new System.Drawing.Point(73, 22);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 30);

            this.btnForward.TabIndex = 2;
            this.btnForward.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Forward");

            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));

            this.btnBack.Location = new System.Drawing.Point(22, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);

            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "Back");

            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(4, 62);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1123, 733);
            this.webBrowser1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.webBrowser1, "");

            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;

            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;

            this.bunifuToolTip1.InitialDelay = 0;

            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;

            this.bunifuToolTip1.Tag = null;

            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // imgRefresh
            // 
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));

            this.imgRefresh.Location = new System.Drawing.Point(47, 736);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(30, 30);

            this.imgRefresh.TabIndex = 8;
            this.imgRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgRefresh, "Refresh");

            this.imgRefresh.Visible = false;

            // 
            // imgSpinner
            // 
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));

            this.imgSpinner.Location = new System.Drawing.Point(83, 736);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Size = new System.Drawing.Size(30, 30);

            this.imgSpinner.TabIndex = 9;
            this.imgSpinner.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgSpinner, "Refresh");

            this.imgSpinner.Visible = false;

            // 
            // frmBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1129, 807);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBrowser";
            this.Text = "New Tab";
            this.bunifuCards1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.imgRefresh)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.imgSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bunifuCards1;
        private System.Windows.Forms.TextBox txtSerachOrUrl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button  btnHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button bunifuImageButton5;
        private System.Windows.Forms.Button bunifuImageButton6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolTip bunifuToolTip1;
        private System.Windows.Forms.Button imgRefresh;
        private System.Windows.Forms.Button imgSpinner;
    }
}