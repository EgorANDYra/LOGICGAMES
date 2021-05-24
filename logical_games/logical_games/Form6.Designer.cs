
namespace logical_games
{
    partial class Form6
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
            this.label3 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePlayerButton = new System.Windows.Forms.Button();
            this.writeWordButton = new System.Windows.Forms.Button();
            this.secondPlayerEnter = new System.Windows.Forms.TextBox();
            this.secondPlayerWords = new System.Windows.Forms.RichTextBox();
            this.firstPlayerEnter = new System.Windows.Forms.TextBox();
            this.firstPlayerWords = new System.Windows.Forms.RichTextBox();
            this.enterMainLettersButton = new System.Windows.Forms.Button();
            this.bullsAndCowsGameLabel = new System.Windows.Forms.Label();
            this.mainLettersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(337, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Буквы";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(319, 367);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(113, 58);
            this.helpButton.TabIndex = 26;
            this.helpButton.Text = "Как играть?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(568, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Игрок 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Игрок 1";
            // 
            // changePlayerButton
            // 
            this.changePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePlayerButton.Location = new System.Drawing.Point(319, 302);
            this.changePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.changePlayerButton.Name = "changePlayerButton";
            this.changePlayerButton.Size = new System.Drawing.Size(113, 58);
            this.changePlayerButton.TabIndex = 23;
            this.changePlayerButton.Text = "Передать ход";
            this.changePlayerButton.UseVisualStyleBackColor = true;
            this.changePlayerButton.Click += new System.EventHandler(this.changePlayerButton_Click);
            // 
            // writeWordButton
            // 
            this.writeWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeWordButton.Location = new System.Drawing.Point(319, 236);
            this.writeWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeWordButton.Name = "writeWordButton";
            this.writeWordButton.Size = new System.Drawing.Size(113, 58);
            this.writeWordButton.TabIndex = 22;
            this.writeWordButton.Text = "Записать";
            this.writeWordButton.UseVisualStyleBackColor = true;
            this.writeWordButton.Click += new System.EventHandler(this.writeWordButton_Click);
            // 
            // secondPlayerEnter
            // 
            this.secondPlayerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPlayerEnter.Location = new System.Drawing.Point(508, 197);
            this.secondPlayerEnter.Margin = new System.Windows.Forms.Padding(4);
            this.secondPlayerEnter.Name = "secondPlayerEnter";
            this.secondPlayerEnter.Size = new System.Drawing.Size(189, 26);
            this.secondPlayerEnter.TabIndex = 21;
            this.secondPlayerEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondPlayerEnter_KeyPress);
            // 
            // secondPlayerWords
            // 
            this.secondPlayerWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPlayerWords.Location = new System.Drawing.Point(508, 229);
            this.secondPlayerWords.Margin = new System.Windows.Forms.Padding(4);
            this.secondPlayerWords.Name = "secondPlayerWords";
            this.secondPlayerWords.ReadOnly = true;
            this.secondPlayerWords.Size = new System.Drawing.Size(189, 202);
            this.secondPlayerWords.TabIndex = 20;
            this.secondPlayerWords.Text = "";
            // 
            // firstPlayerEnter
            // 
            this.firstPlayerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPlayerEnter.Location = new System.Drawing.Point(55, 197);
            this.firstPlayerEnter.Margin = new System.Windows.Forms.Padding(4);
            this.firstPlayerEnter.Name = "firstPlayerEnter";
            this.firstPlayerEnter.Size = new System.Drawing.Size(189, 26);
            this.firstPlayerEnter.TabIndex = 19;
            this.firstPlayerEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPlayerEnter_KeyPress);
            // 
            // firstPlayerWords
            // 
            this.firstPlayerWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPlayerWords.Location = new System.Drawing.Point(55, 229);
            this.firstPlayerWords.Margin = new System.Windows.Forms.Padding(4);
            this.firstPlayerWords.Name = "firstPlayerWords";
            this.firstPlayerWords.ReadOnly = true;
            this.firstPlayerWords.Size = new System.Drawing.Size(189, 202);
            this.firstPlayerWords.TabIndex = 18;
            this.firstPlayerWords.Text = "";
            // 
            // enterMainLettersButton
            // 
            this.enterMainLettersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterMainLettersButton.Location = new System.Drawing.Point(319, 149);
            this.enterMainLettersButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterMainLettersButton.Name = "enterMainLettersButton";
            this.enterMainLettersButton.Size = new System.Drawing.Size(113, 41);
            this.enterMainLettersButton.TabIndex = 17;
            this.enterMainLettersButton.Text = "Ввести";
            this.enterMainLettersButton.UseVisualStyleBackColor = true;
            this.enterMainLettersButton.Click += new System.EventHandler(this.enterMainLettersButton_Click);
            // 
            // bullsAndCowsGameLabel
            // 
            this.bullsAndCowsGameLabel.AutoSize = true;
            this.bullsAndCowsGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bullsAndCowsGameLabel.Location = new System.Drawing.Point(313, 30);
            this.bullsAndCowsGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullsAndCowsGameLabel.Name = "bullsAndCowsGameLabel";
            this.bullsAndCowsGameLabel.Size = new System.Drawing.Size(123, 29);
            this.bullsAndCowsGameLabel.TabIndex = 16;
            this.bullsAndCowsGameLabel.Text = "Гребёнка";
            // 
            // mainLettersTextBox
            // 
            this.mainLettersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLettersTextBox.Location = new System.Drawing.Point(279, 101);
            this.mainLettersTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainLettersTextBox.Name = "mainLettersTextBox";
            this.mainLettersTextBox.ReadOnly = true;
            this.mainLettersTextBox.Size = new System.Drawing.Size(183, 26);
            this.mainLettersTextBox.TabIndex = 15;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePlayerButton);
            this.Controls.Add(this.writeWordButton);
            this.Controls.Add(this.secondPlayerEnter);
            this.Controls.Add(this.secondPlayerWords);
            this.Controls.Add(this.firstPlayerEnter);
            this.Controls.Add(this.firstPlayerWords);
            this.Controls.Add(this.enterMainLettersButton);
            this.Controls.Add(this.bullsAndCowsGameLabel);
            this.Controls.Add(this.mainLettersTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Text = "Гребенка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changePlayerButton;
        private System.Windows.Forms.Button writeWordButton;
        private System.Windows.Forms.TextBox secondPlayerEnter;
        private System.Windows.Forms.RichTextBox secondPlayerWords;
        private System.Windows.Forms.TextBox firstPlayerEnter;
        private System.Windows.Forms.RichTextBox firstPlayerWords;
        public System.Windows.Forms.Button enterMainLettersButton;
        private System.Windows.Forms.Label bullsAndCowsGameLabel;
        public System.Windows.Forms.TextBox mainLettersTextBox;
    }
}