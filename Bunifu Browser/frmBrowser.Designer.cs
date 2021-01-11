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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bunifuToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgSpinner = new System.Windows.Forms.Button();
            this.imgRefresh = new System.Windows.Forms.Button();
            this.bunifuImageButton5 = new System.Windows.Forms.Button();
            this.bunifuImageButton6 = new System.Windows.Forms.Button();
            this.txtSerachOrUrl = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
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
            this.bunifuCards1.Location = new System.Drawing.Point(-8, -7);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.Size = new System.Drawing.Size(1527, 76);
            this.bunifuCards1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(5, 72);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1497, 846);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.AutoPopDelay = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            // 
            // imgSpinner
            // 
            this.imgSpinner.Image = ((System.Drawing.Image)(resources.GetObject("imgSpinner.Image")));
            this.imgSpinner.Location = new System.Drawing.Point(111, 849);
            this.imgSpinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgSpinner.Name = "imgSpinner";
            this.imgSpinner.Size = new System.Drawing.Size(40, 35);
            this.imgSpinner.TabIndex = 9;
            this.imgSpinner.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgSpinner, "Refresh");
            this.imgSpinner.Visible = false;
            // 
            // imgRefresh
            // 
            this.imgRefresh.Image = ((System.Drawing.Image)(resources.GetObject("imgRefresh.Image")));
            this.imgRefresh.Location = new System.Drawing.Point(63, 849);
            this.imgRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgRefresh.Name = "imgRefresh";
            this.imgRefresh.Size = new System.Drawing.Size(40, 35);
            this.imgRefresh.TabIndex = 8;
            this.imgRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.imgRefresh, "Refresh");
            this.imgRefresh.Visible = false;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.Location = new System.Drawing.Point(1451, 23);
            this.bunifuImageButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(48, 48);
            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "Settings");
            this.bunifuImageButton5.Click += new System.EventHandler(this.bunifuImageButton5_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.Location = new System.Drawing.Point(1389, 23);
            this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(48, 48);
            this.bunifuImageButton6.TabIndex = 6;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton6, "Downloads");
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // txtSerachOrUrl
            // 
            this.txtSerachOrUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerachOrUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSerachOrUrl.BackgroundImage")));
            this.txtSerachOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerachOrUrl.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSerachOrUrl.Location = new System.Drawing.Point(302, 32);
            this.txtSerachOrUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSerachOrUrl.MinimumSize = new System.Drawing.Size(132, 35);
            this.txtSerachOrUrl.Name = "txtSerachOrUrl";
            this.txtSerachOrUrl.Size = new System.Drawing.Size(1060, 34);
            this.txtSerachOrUrl.TabIndex = 5;
            this.txtSerachOrUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerachOrUrl_KeyUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(237, 25);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 48);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(169, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 48);
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnHome, "Home");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(97, 25);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(48, 48);
            this.btnForward.TabIndex = 2;
            this.btnForward.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "Forward");
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(29, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 48);
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "Back");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBrowser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1505, 931);
            this.Controls.Add(this.imgSpinner);
            this.Controls.Add(this.imgRefresh);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBrowser";
            this.Text = "New Tab";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
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