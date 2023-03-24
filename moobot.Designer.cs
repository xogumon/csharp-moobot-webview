using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Moo.bot
{
    partial class Moobot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moobot));
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            closeButton = new Button();
            minimizeButton = new Button();
            titleBar = new Panel();
            appTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            titleBar.SuspendLayout();
            SuspendLayout();
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.BackColor = SystemColors.Window;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(0, 25);
            webView2.Margin = new Padding(0);
            webView2.Name = "webView2";
            webView2.Size = new Size(467, 525);
            webView2.Source = new Uri("https://moo.bot/", UriKind.Absolute);
            webView2.TabIndex = 0;
            webView2.UseWaitCursor = true;
            webView2.ZoomFactor = 1D;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.Transparent;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.WindowText;
            closeButton.Location = new Point(438, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(29, 25);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += Moobot_Close;
            closeButton.MouseDown += Moobot_MouseDown;
            closeButton.MouseMove += Moobot_MouseMove;
            closeButton.MouseUp += Moobot_MouseUp;
            // 
            // minimizeButton
            // 
            minimizeButton.AutoSize = true;
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.Dock = DockStyle.Right;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeButton.ForeColor = SystemColors.ActiveCaptionText;
            minimizeButton.Location = new Point(413, 0);
            minimizeButton.Margin = new Padding(0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(25, 25);
            minimizeButton.TabIndex = 0;
            minimizeButton.Text = "-";
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += Moobot_Minimize;
            minimizeButton.MouseDown += Moobot_MouseDown;
            minimizeButton.MouseMove += Moobot_MouseMove;
            minimizeButton.MouseUp += Moobot_MouseUp;
            // 
            // titleBar
            // 
            titleBar.AccessibleRole = AccessibleRole.TitleBar;
            titleBar.BackColor = Color.Transparent;
            titleBar.Controls.Add(minimizeButton);
            titleBar.Controls.Add(closeButton);
            titleBar.Controls.Add(appTitle);
            titleBar.Dock = DockStyle.Top;
            titleBar.Location = new Point(0, 0);
            titleBar.Margin = new Padding(0);
            titleBar.Name = "titleBar";
            titleBar.Size = new Size(467, 25);
            titleBar.TabIndex = 2;
            titleBar.MouseDown += Moobot_MouseDown;
            titleBar.MouseMove += Moobot_MouseMove;
            titleBar.MouseUp += Moobot_MouseUp;
            // 
            // appTitle
            // 
            appTitle.AccessibleRole = AccessibleRole.TitleBar;
            appTitle.AutoSize = true;
            appTitle.Location = new Point(3, 5);
            appTitle.Margin = new Padding(0);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(53, 15);
            appTitle.TabIndex = 0;
            appTitle.Text = "Moo.bot";
            appTitle.TextAlign = ContentAlignment.MiddleLeft;
            appTitle.MouseDown += Moobot_MouseDown;
            appTitle.MouseMove += Moobot_MouseMove;
            appTitle.MouseUp += Moobot_MouseUp;
            // 
            // Moobot
            // 
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(467, 550);
            Controls.Add(titleBar);
            Controls.Add(webView2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(467, 550);
            MinimumSize = new Size(467, 550);
            Name = "Moobot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Moo.bot";
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            titleBar.ResumeLayout(false);
            titleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private Button closeButton;
        private Button minimizeButton;
        private Panel titleBar;
        private Label appTitle;
    }
}