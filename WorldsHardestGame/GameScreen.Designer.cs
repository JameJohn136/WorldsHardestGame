namespace WorldsHardestGame
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.deathsLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // deathsLabel
            // 
            this.deathsLabel.AutoSize = true;
            this.deathsLabel.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathsLabel.Location = new System.Drawing.Point(3, 3);
            this.deathsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deathsLabel.Name = "deathsLabel";
            this.deathsLabel.Size = new System.Drawing.Size(80, 17);
            this.deathsLabel.TabIndex = 0;
            this.deathsLabel.Text = "Deaths: 0";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Location = new System.Drawing.Point(6, 23);
            this.posLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(35, 13);
            this.posLabel.TabIndex = 1;
            this.posLabel.Text = "label1";
            this.posLabel.Click += new System.EventHandler(this.posLabel_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.posLabel);
            this.Controls.Add(this.deathsLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(450, 488);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label deathsLabel;
        private System.Windows.Forms.Label posLabel;
    }
}
