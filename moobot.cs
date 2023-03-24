namespace Moo.bot
{
    public partial class Moobot : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Moobot()
        {
            InitializeComponent();
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