namespace _2048WinFormsApp
{
    partial class OptionForm
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
            callAnswerLabel = new Label();
            sevenSizeButton = new Button();
            fiveSizeButton = new Button();
            sixSizeButton = new Button();
            fourSizeButton = new Button();
            eightSizeButton = new Button();
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
            closeButton.Location = new Point(750, -1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += exitButtun_Click;
            // 
            // callAnswerLabel
            // 
            callAnswerLabel.AutoSize = true;
            callAnswerLabel.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            callAnswerLabel.Location = new Point(244, 84);
            callAnswerLabel.Name = "callAnswerLabel";
            callAnswerLabel.Size = new Size(323, 39);
            callAnswerLabel.TabIndex = 5;
            callAnswerLabel.Text = "Выберите размер поля";
            // 
            // sevenSizeButton
            // 
            sevenSizeButton.BackColor = Color.LemonChiffon;
            sevenSizeButton.Cursor = Cursors.Hand;
            sevenSizeButton.FlatAppearance.BorderSize = 0;
            sevenSizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            sevenSizeButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            sevenSizeButton.FlatStyle = FlatStyle.Flat;
            sevenSizeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sevenSizeButton.Location = new Point(435, 281);
            sevenSizeButton.Name = "sevenSizeButton";
            sevenSizeButton.Size = new Size(222, 53);
            sevenSizeButton.TabIndex = 6;
            sevenSizeButton.Text = "7x7";
            sevenSizeButton.UseVisualStyleBackColor = false;
            sevenSizeButton.Click += sevenSizeButton_Click;
            // 
            // fiveSizeButton
            // 
            fiveSizeButton.BackColor = Color.LemonChiffon;
            fiveSizeButton.Cursor = Cursors.Hand;
            fiveSizeButton.FlatAppearance.BorderSize = 0;
            fiveSizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            fiveSizeButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            fiveSizeButton.FlatStyle = FlatStyle.Flat;
            fiveSizeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fiveSizeButton.Location = new Point(435, 180);
            fiveSizeButton.Name = "fiveSizeButton";
            fiveSizeButton.Size = new Size(222, 53);
            fiveSizeButton.TabIndex = 7;
            fiveSizeButton.Text = "5x5";
            fiveSizeButton.UseVisualStyleBackColor = false;
            fiveSizeButton.Click += fiveSizeButton_Click;
            // 
            // sixSizeButton
            // 
            sixSizeButton.BackColor = Color.LemonChiffon;
            sixSizeButton.Cursor = Cursors.Hand;
            sixSizeButton.FlatAppearance.BorderSize = 0;
            sixSizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            sixSizeButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            sixSizeButton.FlatStyle = FlatStyle.Flat;
            sixSizeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sixSizeButton.Location = new Point(158, 281);
            sixSizeButton.Name = "sixSizeButton";
            sixSizeButton.Size = new Size(222, 53);
            sixSizeButton.TabIndex = 8;
            sixSizeButton.Text = "6x6";
            sixSizeButton.UseVisualStyleBackColor = false;
            sixSizeButton.Click += sixSizeButton_Click;
            // 
            // fourSizeButton
            // 
            fourSizeButton.BackColor = Color.LemonChiffon;
            fourSizeButton.Cursor = Cursors.Hand;
            fourSizeButton.FlatAppearance.BorderSize = 0;
            fourSizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            fourSizeButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            fourSizeButton.FlatStyle = FlatStyle.Flat;
            fourSizeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fourSizeButton.Location = new Point(158, 180);
            fourSizeButton.Name = "fourSizeButton";
            fourSizeButton.Size = new Size(222, 53);
            fourSizeButton.TabIndex = 9;
            fourSizeButton.Text = "4x4";
            fourSizeButton.UseVisualStyleBackColor = false;
            fourSizeButton.Click += fourSizeButton_Click;
            // 
            // eightSizeButton
            // 
            eightSizeButton.BackColor = Color.LemonChiffon;
            eightSizeButton.Cursor = Cursors.Hand;
            eightSizeButton.FlatAppearance.BorderSize = 0;
            eightSizeButton.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            eightSizeButton.FlatAppearance.MouseOverBackColor = Color.Lime;
            eightSizeButton.FlatStyle = FlatStyle.Flat;
            eightSizeButton.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eightSizeButton.Location = new Point(292, 372);
            eightSizeButton.Name = "eightSizeButton";
            eightSizeButton.Size = new Size(222, 53);
            eightSizeButton.TabIndex = 10;
            eightSizeButton.Text = "8x8";
            eightSizeButton.UseVisualStyleBackColor = false;
            eightSizeButton.Click += eightSizeButton_Click;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 508);
            Controls.Add(eightSizeButton);
            Controls.Add(fourSizeButton);
            Controls.Add(sixSizeButton);
            Controls.Add(fiveSizeButton);
            Controls.Add(sevenSizeButton);
            Controls.Add(callAnswerLabel);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OptionForm";
            Text = "OptionForm";
            MouseDown += mainPanel_MouseDown;
            MouseMove += mainPanel_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeButton;
        private Label callAnswerLabel;
        private Button sevenSizeButton;
        private Button fiveSizeButton;
        private Button sixSizeButton;
        private Button fourSizeButton;
        private Button eightSizeButton;
    }
}