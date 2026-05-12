namespace _2048WinFormsApp
{
    partial class LoginForm
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
            closeButton = new Button();
            nextButton = new Button();
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            SuspendLayout();
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
            closeButton.Location = new Point(748, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += exitButtun_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.LemonChiffon;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(302, 250);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(222, 53);
            nextButton.TabIndex = 5;
            nextButton.Text = "Войти";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(284, 64);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(261, 39);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "Введите ваше имя";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(284, 165);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(261, 31);
            userNameTextBox.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(userNameTextBox);
            Controls.Add(userNameLabel);
            Controls.Add(nextButton);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            MouseDown += mainPanel_MouseDown;
            MouseMove += mainPanel_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Button nextButton;
        private Label userNameLabel;
        private TextBox userNameTextBox;
    }
}