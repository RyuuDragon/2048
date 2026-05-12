namespace _2048WinFormsApp
{
    partial class MenuForm
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
            startButton = new Button();
            exitButtun = new Button();
            ruleButton = new Button();
            closeButton = new Button();
            userLabel = new Label();
            resultsButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.LemonChiffon;
            startButton.Cursor = Cursors.Hand;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            startButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startButton.Location = new Point(150, 131);
            startButton.Name = "startButton";
            startButton.Size = new Size(222, 53);
            startButton.TabIndex = 0;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // exitButtun
            // 
            exitButtun.BackColor = Color.LemonChiffon;
            exitButtun.Cursor = Cursors.Hand;
            exitButtun.FlatAppearance.BorderSize = 0;
            exitButtun.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            exitButtun.FlatAppearance.MouseOverBackColor = Color.Lime;
            exitButtun.FlatStyle = FlatStyle.Flat;
            exitButtun.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButtun.Location = new Point(150, 341);
            exitButtun.Name = "exitButtun";
            exitButtun.Size = new Size(222, 53);
            exitButtun.TabIndex = 1;
            exitButtun.Text = "Выйти";
            exitButtun.UseVisualStyleBackColor = false;
            exitButtun.Click += exitButtun_Click;
            // 
            // ruleButton
            // 
            ruleButton.BackColor = Color.LemonChiffon;
            ruleButton.Cursor = Cursors.Hand;
            ruleButton.FlatAppearance.BorderSize = 0;
            ruleButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            ruleButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            ruleButton.FlatStyle = FlatStyle.Flat;
            ruleButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ruleButton.Location = new Point(150, 271);
            ruleButton.Name = "ruleButton";
            ruleButton.Size = new Size(222, 53);
            ruleButton.TabIndex = 2;
            ruleButton.Text = "Правила игры";
            ruleButton.UseVisualStyleBackColor = false;
            ruleButton.Click += ruleButton_Click;
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.Maroon;
            closeButton.FlatAppearance.MouseOverBackColor = Color.Red;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(448, 1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.TabIndex = 3;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLabel.Location = new Point(40, 69);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(229, 33);
            userLabel.TabIndex = 4;
            userLabel.Text = "Добро пожаловать";
            // 
            // resultsButton
            // 
            resultsButton.BackColor = Color.LemonChiffon;
            resultsButton.Cursor = Cursors.Hand;
            resultsButton.FlatAppearance.BorderSize = 0;
            resultsButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            resultsButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            resultsButton.FlatStyle = FlatStyle.Flat;
            resultsButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultsButton.Location = new Point(150, 201);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(222, 53);
            resultsButton.TabIndex = 5;
            resultsButton.Text = "Результаты";
            resultsButton.UseVisualStyleBackColor = false;
            resultsButton.Click += resultsButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(500, 450);
            Controls.Add(resultsButton);
            Controls.Add(userLabel);
            Controls.Add(closeButton);
            Controls.Add(ruleButton);
            Controls.Add(exitButtun);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "MenuForm";
            MouseDown += mainPanel_MouseDown;
            MouseMove += mainPanel_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Button exitButtun;
        private Button ruleButton;
        private Button closeButton;
        private Label userLabel;
        private Button resultsButton;
    }
}