namespace _2048WinFormsApp
{
    partial class MainForm
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
            closeButton = new Button();
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            правилаИгрыToolStripMenuItem = new ToolStripMenuItem();
            начатьСначалаToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            bestResultLabel = new Label();
            главноеМенюToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            closeButton.Location = new Point(950, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.TabIndex = 2;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(80, 54);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(89, 39);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "score";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { правилаИгрыToolStripMenuItem, начатьСначалаToolStripMenuItem, главноеМенюToolStripMenuItem, выйтиToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(78, 29);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            правилаИгрыToolStripMenuItem.Size = new Size(270, 34);
            правилаИгрыToolStripMenuItem.Text = "Правила игры";
            правилаИгрыToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // начатьСначалаToolStripMenuItem
            // 
            начатьСначалаToolStripMenuItem.Name = "начатьСначалаToolStripMenuItem";
            начатьСначалаToolStripMenuItem.Size = new Size(270, 34);
            начатьСначалаToolStripMenuItem.Text = "Начать сначала";
            начатьСначалаToolStripMenuItem.Click += startAgainToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(270, 34);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // bestResultLabel
            // 
            bestResultLabel.AutoSize = true;
            bestResultLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bestResultLabel.Location = new Point(80, 110);
            bestResultLabel.Name = "bestResultLabel";
            bestResultLabel.Size = new Size(159, 39);
            bestResultLabel.TabIndex = 5;
            bestResultLabel.Text = "bestResult";
            // 
            // главноеМенюToolStripMenuItem
            // 
            главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            главноеМенюToolStripMenuItem.Size = new Size(270, 34);
            главноеМенюToolStripMenuItem.Text = "Главное меню";
            главноеМенюToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1000, 1000);
            Controls.Add(bestResultLabel);
            Controls.Add(scoreLabel);
            Controls.Add(closeButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            MouseDown += mainPanel_MouseDown;
            MouseMove += mainPanel_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private ToolStripMenuItem начатьСначалаToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private Label bestResultLabel;
        private ToolStripMenuItem главноеМенюToolStripMenuItem;
    }
}
