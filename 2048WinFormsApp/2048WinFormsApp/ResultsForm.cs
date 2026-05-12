namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        private readonly User user;
        private Point lastPoint;

        public ResultsForm(User user)
        {
            InitializeComponent();

            resultsDataGridView.ReadOnly = true;

            this.user = user;
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = ResultsStorage.GetAll();
            foreach (var result in results)
            {
                var user = result[0];
                var score = result[1];

                resultsDataGridView.Rows.Add(user, score);
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Hide();
            var menuForm = new MenuForm(user);
            menuForm.Show();
        }

        private void exitButtun_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButtun_Click(object sender, EventArgs e)
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
    }
}
