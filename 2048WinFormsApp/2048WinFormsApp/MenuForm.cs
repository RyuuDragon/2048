namespace _2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        private Point lastPoint;
        private readonly User user;

        public MenuForm(User user)
        {
            InitializeComponent();

            this.user = user;
            userLabel.Text = $"Добро пожаловать, {user.Name}!";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            var optionForm = new OptionForm(user);
            optionForm.Show();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            Hide();
            var resultsForm = new ResultsForm(user);
            resultsForm.Show();
        }

        private void ruleButton_Click(object sender, EventArgs e)
        {
            var message = "1. У вас есть поле размером NxN" +
                "\n2. В случайном месте будут появляться числа номиналом 2 или 4" +
                "\n3. Вы можите двигать числа в 4 направлениях, " +
                "если числа одинаковым номиналом сталкиваются, то они суммируются" +
                "\n4. Ваша задача дойти до числа 2048 или выше, удачи!";

            MessageBox.Show(message);
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
    }
}
