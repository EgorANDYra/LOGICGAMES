
namespace logical_games
{
    partial class Form2
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
            this.chooseGameLabel = new System.Windows.Forms.Label();
            this.bullsAndCows = new System.Windows.Forms.Button();
            this.collector = new System.Windows.Forms.Button();
            this.comb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseGameLabel
            // 
            this.chooseGameLabel.AutoSize = true;
            this.chooseGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseGameLabel.Location = new System.Drawing.Point(411, 112);
            this.chooseGameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseGameLabel.Name = "chooseGameLabel";
            this.chooseGameLabel.Size = new System.Drawing.Size(151, 29);
            this.chooseGameLabel.TabIndex = 1;
            this.chooseGameLabel.Text = "Выбор игры";
            // 
            // bullsAndCows
            // 
            this.bullsAndCows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bullsAndCows.Location = new System.Drawing.Point(416, 188);
            this.bullsAndCows.Margin = new System.Windows.Forms.Padding(4);
            this.bullsAndCows.Name = "bullsAndCows";
            this.bullsAndCows.Size = new System.Drawing.Size(163, 52);
            this.bullsAndCows.TabIndex = 2;
            this.bullsAndCows.Text = "\"Быки и коровы\"";
            this.bullsAndCows.UseVisualStyleBackColor = true;
            this.bullsAndCows.Click += new System.EventHandler(this.bullsAndCows_Click);
            // 
            // collector
            // 
            this.collector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collector.Location = new System.Drawing.Point(416, 247);
            this.collector.Margin = new System.Windows.Forms.Padding(4);
            this.collector.Name = "collector";
            this.collector.Size = new System.Drawing.Size(163, 52);
            this.collector.TabIndex = 3;
            this.collector.Text = "\"Сборщик\"";
            this.collector.UseVisualStyleBackColor = true;
            this.collector.Click += new System.EventHandler(this.collector_Click);
            // 
            // comb
            // 
            this.comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comb.Location = new System.Drawing.Point(416, 306);
            this.comb.Margin = new System.Windows.Forms.Padding(4);
            this.comb.Name = "comb";
            this.comb.Size = new System.Drawing.Size(163, 52);
            this.comb.TabIndex = 4;
            this.comb.Text = "\"Гребёнка\"";
            this.comb.UseVisualStyleBackColor = true;
            this.comb.Click += new System.EventHandler(this.comb_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comb);
            this.Controls.Add(this.collector);
            this.Controls.Add(this.bullsAndCows);
            this.Controls.Add(this.chooseGameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Выбор игры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseGameLabel;
        private System.Windows.Forms.Button bullsAndCows;
        private System.Windows.Forms.Button collector;
        private System.Windows.Forms.Button comb;
    }
}