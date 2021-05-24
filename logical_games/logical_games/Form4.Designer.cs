
namespace logical_games
{
    partial class Form4
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
            this.mainWordTextBox = new System.Windows.Forms.TextBox();
            this.bullsAndCowsGameLabel = new System.Windows.Forms.Label();
            this.enterMainWordButton = new System.Windows.Forms.Button();
            this.firstPlayerWords = new System.Windows.Forms.RichTextBox();
            this.firstPlayerEnter = new System.Windows.Forms.TextBox();
            this.secondPlayerEnter = new System.Windows.Forms.TextBox();
            this.secondPlayerWords = new System.Windows.Forms.RichTextBox();
            this.writeWordButton = new System.Windows.Forms.Button();
            this.changePlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainWordTextBox
            // 
            this.mainWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainWordTextBox.Location = new System.Drawing.Point(279, 98);
            this.mainWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainWordTextBox.Name = "mainWordTextBox";
            this.mainWordTextBox.ReadOnly = true;
            this.mainWordTextBox.Size = new System.Drawing.Size(183, 26);
            this.mainWordTextBox.TabIndex = 0;
            // 
            // bullsAndCowsGameLabel
            // 
            this.bullsAndCowsGameLabel.AutoSize = true;
            this.bullsAndCowsGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bullsAndCowsGameLabel.Location = new System.Drawing.Point(313, 27);
            this.bullsAndCowsGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bullsAndCowsGameLabel.Name = "bullsAndCowsGameLabel";
            this.bullsAndCowsGameLabel.Size = new System.Drawing.Size(119, 29);
            this.bullsAndCowsGameLabel.TabIndex = 3;
            this.bullsAndCowsGameLabel.Text = "Сборщик";
            // 
            // enterMainWordButton
            // 
            this.enterMainWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterMainWordButton.Location = new System.Drawing.Point(319, 146);
            this.enterMainWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterMainWordButton.Name = "enterMainWordButton";
            this.enterMainWordButton.Size = new System.Drawing.Size(113, 41);
            this.enterMainWordButton.TabIndex = 4;
            this.enterMainWordButton.Text = "Ввести";
            this.enterMainWordButton.UseVisualStyleBackColor = true;
            this.enterMainWordButton.Click += new System.EventHandler(this.enterMainWordButton_Click);
            // 
            // firstPlayerWords
            // 
            this.firstPlayerWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPlayerWords.Location = new System.Drawing.Point(55, 226);
            this.firstPlayerWords.Margin = new System.Windows.Forms.Padding(4);
            this.firstPlayerWords.Name = "firstPlayerWords";
            this.firstPlayerWords.ReadOnly = true;
            this.firstPlayerWords.Size = new System.Drawing.Size(189, 202);
            this.firstPlayerWords.TabIndex = 5;
            this.firstPlayerWords.Text = "";
            // 
            // firstPlayerEnter
            // 
            this.firstPlayerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPlayerEnter.Location = new System.Drawing.Point(55, 194);
            this.firstPlayerEnter.Margin = new System.Windows.Forms.Padding(4);
            this.firstPlayerEnter.Name = "firstPlayerEnter";
            this.firstPlayerEnter.Size = new System.Drawing.Size(189, 26);
            this.firstPlayerEnter.TabIndex = 6;
            this.firstPlayerEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPlayerEnter_KeyPress);
            // 
            // secondPlayerEnter
            // 
            this.secondPlayerEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPlayerEnter.Location = new System.Drawing.Point(508, 194);
            this.secondPlayerEnter.Margin = new System.Windows.Forms.Padding(4);
            this.secondPlayerEnter.Name = "secondPlayerEnter";
            this.secondPlayerEnter.Size = new System.Drawing.Size(189, 26);
            this.secondPlayerEnter.TabIndex = 8;
            this.secondPlayerEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondPlayerEnter_KeyPress);
            // 
            // secondPlayerWords
            // 
            this.secondPlayerWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondPlayerWords.Location = new System.Drawing.Point(508, 226);
            this.secondPlayerWords.Margin = new System.Windows.Forms.Padding(4);
            this.secondPlayerWords.Name = "secondPlayerWords";
            this.secondPlayerWords.ReadOnly = true;
            this.secondPlayerWords.Size = new System.Drawing.Size(189, 202);
            this.secondPlayerWords.TabIndex = 7;
            this.secondPlayerWords.Text = "";
            // 
            // writeWordButton
            // 
            this.writeWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeWordButton.Location = new System.Drawing.Point(319, 234);
            this.writeWordButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeWordButton.Name = "writeWordButton";
            this.writeWordButton.Size = new System.Drawing.Size(113, 58);
            this.writeWordButton.TabIndex = 9;
            this.writeWordButton.Text = "Записать";
            this.writeWordButton.UseVisualStyleBackColor = true;
            this.writeWordButton.Click += new System.EventHandler(this.writeWordButton_Click);
            // 
            // changePlayerButton
            // 
            this.changePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePlayerButton.Location = new System.Drawing.Point(319, 299);
            this.changePlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.changePlayerButton.Name = "changePlayerButton";
            this.changePlayerButton.Size = new System.Drawing.Size(113, 58);
            this.changePlayerButton.TabIndex = 10;
            this.changePlayerButton.Text = "Передать ход";
            this.changePlayerButton.UseVisualStyleBackColor = true;
            this.changePlayerButton.Click += new System.EventHandler(this.changePlayerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(568, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Игрок 2";
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(319, 364);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(113, 58);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Как играть?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(292, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Главное слово";
            // 
            // Form4
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
            this.Controls.Add(this.enterMainWordButton);
            this.Controls.Add(this.bullsAndCowsGameLabel);
            this.Controls.Add(this.mainWordTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Сборщик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox mainWordTextBox;
        private System.Windows.Forms.Label bullsAndCowsGameLabel;
        public System.Windows.Forms.Button enterMainWordButton;
        private System.Windows.Forms.RichTextBox firstPlayerWords;
        private System.Windows.Forms.TextBox firstPlayerEnter;
        private System.Windows.Forms.TextBox secondPlayerEnter;
        private System.Windows.Forms.RichTextBox secondPlayerWords;
        private System.Windows.Forms.Button writeWordButton;
        private System.Windows.Forms.Button changePlayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label3;
    }
}