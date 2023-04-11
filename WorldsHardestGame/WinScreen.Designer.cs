namespace WorldsHardestGame
{
    partial class WinScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.retryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.deathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retryButton
            // 
            this.retryButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryButton.Location = new System.Drawing.Point(140, 243);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(170, 78);
            this.retryButton.TabIndex = 0;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(140, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 78);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.PaleGreen;
            this.winLabel.Location = new System.Drawing.Point(151, 31);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(159, 34);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "You Win!!";
            // 
            // deathLabel
            // 
            this.deathLabel.AutoSize = true;
            this.deathLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathLabel.ForeColor = System.Drawing.Color.Crimson;
            this.deathLabel.Location = new System.Drawing.Point(151, 154);
            this.deathLabel.Name = "deathLabel";
            this.deathLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deathLabel.Size = new System.Drawing.Size(127, 34);
            this.deathLabel.TabIndex = 3;
            this.deathLabel.Text = "Deaths:";
            this.deathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.deathLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.retryButton);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(450, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label deathLabel;
    }
}
