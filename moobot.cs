using Microsoft.Web.WebView2.Core;

namespace Moo.bot
{
    public partial class Moobot : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Moobot()
        {
            InitializeComponent();
            webView2.CoreWebView2InitializationCompleted += WebView2_CoreWebView2InitializationCompleted;
        }

        private async void WebView2_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            await webView2.EnsureCoreWebView2Async();
            webView2.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
        }

        private void CoreWebView2_DocumentTitleChanged(object? sender, object e)
        {
            string pageTitle = webView2.CoreWebView2.DocumentTitle;
            if (pageTitle != null)
            {
                appTitle.Text = pageTitle;
                Text = pageTitle;
            }
        }

        private void Moobot_Close(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Moobot_Minimize(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Moobot_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void Moobot_MouseMove(object? sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);
                Update();
            }
        }

        private void Moobot_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && mouseDown)
            {
                mouseDown = false;
            }
        }
    }
}