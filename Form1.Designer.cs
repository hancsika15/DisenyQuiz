namespace DisenyQuiz
{
    partial class DisneyQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisneyQuiz));
            label1 = new Label();
            btnGame = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 72F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(72, 49);
            label1.Name = "label1";
            label1.Size = new Size(647, 434);
            label1.TabIndex = 0;
            label1.Text = "Disney\r\nQuiz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGame
            // 
            btnGame.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            btnGame.Location = new Point(72, 561);
            btnGame.Name = "btnGame";
            btnGame.Size = new Size(647, 122);
            btnGame.TabIndex = 1;
            btnGame.Text = "Játék";
            btnGame.UseVisualStyleBackColor = true;
            btnGame.Click += btnGame_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            btnExit.Location = new Point(72, 742);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(647, 122);
            btnExit.TabIndex = 1;
            btnExit.Text = "Kilépés";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // DisneyQuiz
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bga1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(789, 946);
            Controls.Add(btnExit);
            Controls.Add(btnGame);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DisneyQuiz";
            Text = "Disney Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGame;
        private Button btnExit;
    }
}
