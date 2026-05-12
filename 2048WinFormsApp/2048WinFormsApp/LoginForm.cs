using System.Text.RegularExpressions;

namespace _2048WinFormsApp
{
    public partial class LoginForm : Form
    {
        private Point lastPoint;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var message = string.Empty;

            if (!IsValidName(userNameTextBox.Text, out message))
            {
                MessageBox.Show(message);
                return;
            }

            var user = new User(userNameTextBox.Text);

            Hide();
            var menuForm = new MenuForm(user);
            menuForm.Show();
        }

        public static bool IsValidName(string name, out string message)
        {
            message = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length < 2)
            {
                message = "Имя должно содержать больше одного символова. Пожалуйста введите имя снова!";
                return false;
            }

            var pattern = "^[A-Za-zА-Яа-яЁё-]+$";
            var regex = new Regex(pattern);

            if (!regex.IsMatch(name))
            {
                message = "Имя должно содержать только буквы и \"-\" (если имя является двойным)." +
                    " Пожалуйста введите имя снова!";
                return false;
            }

            if (char.IsLower(name[0]))
            {
                message = "Имя должно начинаться с большой буквы. Пожалуйста введите имя снова!";
                return false;
            }

            return true;
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
