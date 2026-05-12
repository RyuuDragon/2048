namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private readonly User user;
        private Label[,] labelsMap;
        private readonly int mapSize;
        private const int LabelSize = 100;
        private const int StartXPoint = 70;
        private const int StartYPoint = 150;
        private const int NextLabelDistance = 106;
        private Point lastPoint;
        private static readonly Random random = new();
        private int score = 0;
        private int bestResult;

        public MainForm(User user, int mapSize)
        {
            InitializeComponent();

            this.user = user;
            this.mapSize = mapSize;

            SetFormSize();
            ShowForm();

            KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeMap();

            ShowBestResult();

            GenerateNumber();

            ShowScore();
        }

        private void SetFormSize()
        {
            if (mapSize == 4)
            {
                Size = new Size(600, 600);
                closeButton.Location = new Point(550, 0);
            }

            if (mapSize == 5)
            {
                Size = new Size(700, 700);
                closeButton.Location = new Point(650, 0);
            }

            if (mapSize == 6)
            {
                Size = new Size(800, 800);
                closeButton.Location = new Point(750, 0);
            }

            if (mapSize == 7)
            {
                Size = new Size(900, 900);
                closeButton.Location = new Point(850, 0);
            }

            if (mapSize == 8)
            {
                Size = new Size(1000, 1000);
                closeButton.Location = new Point(950, 0);
            }
        }

        private void ShowForm()
        {
            var size = SystemInformation.PrimaryMonitorSize;
            if (Location.X < 0)
            {
                Location = new Point(0, Location.Y);
            }
            if (Location.Y < 0)
            {
                Location = new Point(Location.X, 0);
            }
            if (Location.X + Size.Width > size.Width)
            {
                Location = new Point(size.Width - Size.Width, Location.Y);
            }
            if (Location.Y + Size.Height > size.Height)
            {
                Location = new Point(Location.X, size.Height - Size.Height);
            }
        }

        private void InitializeMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var x = StartXPoint + indexColumn * NextLabelDistance;
            var y = StartYPoint + indexRow * NextLabelDistance;

            var label = new Label
            {
                BackColor = Color.Silver,
                Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point),
                Size = new Size(LabelSize, LabelSize),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(x, y)
            };


            return label;
        }

        private void ShowScore()
        {
            scoreLabel.Text = $"Счет: {score}";
        }

        private void ShowBestResult()
        {
            if (ResultsStorage.IsEmpty())
            {
                SaveUserResult();
            }

            bestResult = ResultsStorage.GetBestResult(user.Name);

            bestResultLabel.Text = $"Лучший: {bestResult}";
        }

        private void GenerateNumber()
        {
            var emptyLabels = LinearSearch();

            if (emptyLabels.Count > 0)
            {
                var randomCoordinatesIndex = random.Next(emptyLabels.Count);

                var coordinates = emptyLabels[randomCoordinatesIndex];

                var indexRow = coordinates.Item1;
                var indexColumn = coordinates.Item2;

                var randomNumber = ChoiceWeightedRandom();
                labelsMap[indexRow, indexColumn].Text = randomNumber.ToString();
                SetColor(labelsMap[indexRow, indexColumn]);
            }
            else
            {
                if (!CanMove())
                {
                    SaveUserResult();

                    var message = $"Игра окончена, Ваш результат: {score}";
                    MessageBox.Show(message);

                    Close();
                    var menuForm = new MenuForm(user);
                    menuForm.Show();
                }
            }
        }

        private bool CanMove()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text)
                    {
                        return true;
                    }
                }
            }

            for (var j = 0; j < mapSize; j++)
            {
                for (var i = 0; i < mapSize - 1; i++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private int ChoiceWeightedRandom()
        {
            var numbersChance = new (int Number, int Chance)[]
            {
                (Number: 2, Chance: 75),
                (Number: 4, Chance: 25)
            };

            var chance = random.Next(1, 101);

            var randomNumber = numbersChance[0].Number;

            var sumChance = 0;
            for (var i = 0; i < numbersChance.Length; i++)
            {
                sumChance += numbersChance[i].Chance;
                if (chance <= sumChance)
                {
                    return numbersChance[i].Number;
                }
            }

            return randomNumber;
        }

        private List<(int, int)> LinearSearch()
        {
            var emptyLabels = new List<(int Row, int Column)>();

            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        emptyLabels.Add((i, j));
                    }
                }
            }

            return emptyLabels;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            var key = keyData & Keys.KeyCode;

            if (key == Keys.Up || key == Keys.Down || key == Keys.Left || key == Keys.Right)
            {
                MoveArrow(key);

                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                MoveArrow(e.KeyCode);
            }
        }

        private void MoveArrow(Keys key)
        {
            if (key == Keys.Right || key == Keys.D)
            {
                PressRight();
            }

            if (key == Keys.Left || key == Keys.A)
            {
                PressLeft();
            }

            if (key == Keys.Up || key == Keys.W)
            {
                PressUp();
            }

            if (key == Keys.Down || key == Keys.S)
            {
                PressDown();
            }

            GenerateNumber();
            ShowScore();
        }

        private void PressRight()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (var k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    SetColor(labelsMap[i, j]);

                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = Color.Silver;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < mapSize; i++)
            {
                for (var j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (var k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                SetColor(labelsMap[i, j]);

                                labelsMap[i, k].Text = string.Empty;
                                labelsMap[i, k].BackColor = Color.Silver;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressLeft()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (var k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    SetColor(labelsMap[i, j]);

                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = Color.Silver;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (var k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                SetColor(labelsMap[i, j]);

                                labelsMap[i, k].Text = string.Empty;
                                labelsMap[i, k].BackColor = Color.Silver;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressUp()
        {
            for (var j = 0; j < mapSize; j++)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (var k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    SetColor(labelsMap[i, j]);

                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = Color.Silver;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var j = 0; j < mapSize; j++)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (var k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                SetColor(labelsMap[i, j]);

                                labelsMap[k, j].Text = string.Empty;
                                labelsMap[k, j].BackColor = Color.Silver;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void PressDown()
        {
            for (var j = 0; j < mapSize; j++)
            {
                for (var i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (var k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    SetColor(labelsMap[i, j]);

                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = Color.Silver;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (var j = 0; j < mapSize; j++)
            {
                for (var i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (var k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                SetColor(labelsMap[i, j]);

                                labelsMap[k, j].Text = string.Empty;
                                labelsMap[k, j].BackColor = Color.Silver;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void SetColor(Label label)
        {
            switch (label.Text)
            {
                case "2": label.BackColor = Color.LightGray; break;
                case "4": label.BackColor = Color.DarkGray; break;
                case "8": label.BackColor = Color.Orange; break;
                case "16": label.BackColor = Color.DarkOrange; break;
                case "32": label.BackColor = Color.OrangeRed; break;
                case "64": label.BackColor = Color.Red; break;
                case "128": label.BackColor = Color.LightYellow; break;
                case "512": label.BackColor = Color.GreenYellow; break;
                case "1024": label.BackColor = Color.LightGoldenrodYellow; break;
                case "2048": label.BackColor = Color.Yellow; break;
                case "4096": label.BackColor = Color.Gold; break;
                case "8192": label.BackColor = Color.MediumPurple; break;
                case "16384": label.BackColor = Color.Purple; break;
                case "32768": label.BackColor = Color.RebeccaPurple; break;
                case "65536": label.BackColor = Color.ForestGreen; break;
                case "131072": label.BackColor = Color.DarkGreen; break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            SaveUserResult();

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

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var message = "1. У вас есть поле размером NxN" +
                "\n2. В случайном месте будут появляться числа номиналом 2 или 4" +
                "\n3. Вы можите двигать числа в 4 направлениях, " +
                "если числа одинаковым номиналом сталкиваются, то они суммируются" +
                "\n4. Ваша задача дойти до числа 2048 или выше, удачи!";

            MessageBox.Show(message);
        }

        private void startAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUserResult();

            Hide();
            var mainForm = new MainForm(user, mapSize);
            mainForm.Show();
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUserResult();

            Hide();
            var menuForm = new MenuForm(user);
            menuForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveUserResult();

            Application.Exit();
        }

        private void SaveUserResult()
        {
            var result = new string[] { user.Name, score.ToString() };

            ResultsStorage.Append(result);
        }
    }
}
