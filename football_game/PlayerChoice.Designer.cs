﻿namespace football_game
{
    partial class PlayerChoice
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(334, 228);
            button1.Name = "button1";
            button1.Size = new Size(250, 60);
            button1.TabIndex = 0;
            button1.Text = "player1(공격)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += player1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(334, 321);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(250, 60);
            button2.TabIndex = 1;
            button2.Text = "player2(수비)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += player2_Click;
            // 
            // PlayerChoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.choice;
            ClientSize = new Size(899, 678);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PlayerChoice";
            Text = "Fooball game";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}