namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            Backpage = new Button();
            Gopage = new Button();
            cbUrl = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(685, 12);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(94, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(12, 54);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(1087, 214);
            lbTitles.TabIndex = 2;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(12, 274);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(607, 381);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            // 
            // Backpage
            // 
            Backpage.Location = new Point(12, 12);
            Backpage.Name = "Backpage";
            Backpage.Size = new Size(74, 33);
            Backpage.TabIndex = 4;
            Backpage.Text = "戻る";
            Backpage.UseVisualStyleBackColor = true;
            Backpage.Click += Backpage_Click;
            // 
            // Gopage
            // 
            Gopage.Location = new Point(92, 12);
            Gopage.Name = "Gopage";
            Gopage.Size = new Size(74, 33);
            Gopage.TabIndex = 5;
            Gopage.Text = "進む";
            Gopage.UseVisualStyleBackColor = true;
            // 
            // cbUrl
            // 
            cbUrl.Location = new Point(172, 18);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(507, 23);
            cbUrl.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 767);
            Controls.Add(cbUrl);
            Controls.Add(Gopage);
            Controls.Add(Backpage);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "RSSリーダー";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button Backpage;
        private Button Gopage;
        private ComboBox cbUrl;
    }
}
