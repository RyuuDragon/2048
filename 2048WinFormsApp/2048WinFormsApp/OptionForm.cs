namespace _2048WinFormsApp
{
    public partial class OptionForm : Form
    {
        private Point lastPoint;
        private readonly User user;
        private int mapSize;

        public OptionForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void exitButtun_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var x = e.X - lastPoint.X;
                var y = e.Y - lastPoint.Y;

                Left += x;
                Top += y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void fourSizeButton_Click(object sender, EventArgs e)
        {
            mapSize = 4;
            ShowGame();
        }

        private void fiveSizeButton_Click(object sender, EventArgs e)
        {
            mapSize = 5;
            ShowGame();
        }

        private void sixSizeButton_Click(object sender, EventArgs e)
        {
            mapSize = 6;
            ShowGame();
        }

        private void sevenSizeButton_Click(object sender, EventArgs e)
        {
            mapSize = 7;
            ShowGame();
        }

        private void eightSizeButton_Click(object sender, EventArgs e)
        {
            mapSize = 8;
            ShowGame();
        }

        private void ShowGame()
        {
            Hide();
            var mainForm = new MainForm(user, mapSize);
            mainForm.Show();
        }
    }
}
