namespace _2048WinFormsApp
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            UserColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            closeButton = new Button();
            menuButton = new Button();
            exitButtun = new Button();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserColumn, ScoreColumn });
            resultsDataGridView.Location = new Point(34, 40);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 62;
            resultsDataGridView.Size = new Size(365, 576);
            resultsDataGridView.TabIndex = 0;
            // 
            // UserColumn
            // 
            UserColumn.HeaderText = "Имя";
            UserColumn.MinimumWidth = 8;
            UserColumn.Name = "UserColumn";
            UserColumn.Width = 150;
            // 
            // ScoreColumn
            // 
            ScoreColumn.HeaderText = "Очки";
            ScoreColumn.MinimumWidth = 8;
            ScoreColumn.Name = "ScoreColumn";
            ScoreColumn.Width = 150;
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
            closeButton.Location = new Point(629, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtun_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.LemonChiffon;
            menuButton.Cursor = Cursors.Hand;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            menuButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuButton.Location = new Point(432, 259);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(222, 53);
            menuButton.TabIndex = 6;
            menuButton.Text = "Главное меню";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
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
            exitButtun.Location = new Point(432, 329);
            exitButtun.Name = "exitButtun";
            exitButtun.Size = new Size(222, 53);
            exitButtun.TabIndex = 5;
            exitButtun.Text = "Выйти";
            exitButtun.UseVisualStyleBackColor = false;
            exitButtun.Click += exitButtun_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(678, 644);
            Controls.Add(menuButton);
            Controls.Add(exitButtun);
            Controls.Add(closeButton);
            Controls.Add(resultsDataGridView);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            MouseDown += mainPanel_MouseDown;
            MouseMove += mainPanel_MouseMove;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn UserColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
        private Button closeButton;
        private Button menuButton;
        private Button exitButtun;
    }
}