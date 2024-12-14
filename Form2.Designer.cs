namespace DisenyQuiz
{
    partial class DisneyQuizGame
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisneyQuizGame));
            lblscore = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            characterCorrect = new Button();
            character03 = new Button();
            character02 = new Button();
            character01 = new Button();
            lblTimer = new Label();
            btnexit = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblscore
            // 
            lblscore.Anchor = AnchorStyles.None;
            lblscore.BackColor = Color.MistyRose;
            lblscore.BorderStyle = BorderStyle.Fixed3D;
            lblscore.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblscore.Location = new Point(1628, 426);
            lblscore.Margin = new Padding(6, 0, 6, 0);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(503, 102);
            lblscore.TabIndex = 39;
            lblscore.Text = "Az eddig elért pontjaid: ";
            lblscore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(1284, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(704, 145);
            label2.TabIndex = 38;
            label2.Text = "Disney Quiz";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(1338, 280);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(572, 85);
            label1.TabIndex = 37;
            label1.Text = "Kit látsz a képen?\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(258, 123);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 1000);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // characterCorrect
            // 
            characterCorrect.Anchor = AnchorStyles.None;
            characterCorrect.BackColor = Color.MistyRose;
            characterCorrect.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            characterCorrect.Location = new Point(1637, 831);
            characterCorrect.Margin = new Padding(4, 2, 4, 2);
            characterCorrect.Name = "characterCorrect";
            characterCorrect.Size = new Size(500, 205);
            characterCorrect.TabIndex = 35;
            characterCorrect.Text = "characterCorrect";
            characterCorrect.UseVisualStyleBackColor = false;
            // 
            // character03
            // 
            character03.Anchor = AnchorStyles.None;
            character03.BackColor = Color.MistyRose;
            character03.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character03.Location = new Point(1637, 604);
            character03.Margin = new Padding(4, 2, 4, 2);
            character03.Name = "character03";
            character03.Size = new Size(500, 205);
            character03.TabIndex = 34;
            character03.Text = "character03";
            character03.UseVisualStyleBackColor = false;
            // 
            // character02
            // 
            character02.Anchor = AnchorStyles.None;
            character02.BackColor = Color.MistyRose;
            character02.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character02.Location = new Point(1115, 831);
            character02.Margin = new Padding(4, 2, 4, 2);
            character02.Name = "character02";
            character02.Size = new Size(500, 205);
            character02.TabIndex = 33;
            character02.Text = "character02";
            character02.UseVisualStyleBackColor = false;
            // 
            // character01
            // 
            character01.Anchor = AnchorStyles.None;
            character01.BackColor = Color.MistyRose;
            character01.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character01.Location = new Point(1119, 604);
            character01.Margin = new Padding(4, 2, 4, 2);
            character01.Name = "character01";
            character01.Size = new Size(500, 205);
            character01.TabIndex = 32;
            character01.Text = "character01";
            character01.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.None;
            lblTimer.BackColor = Color.MistyRose;
            lblTimer.BorderStyle = BorderStyle.Fixed3D;
            lblTimer.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTimer.Location = new Point(1115, 426);
            lblTimer.Margin = new Padding(6, 0, 6, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(503, 102);
            lblTimer.TabIndex = 40;
            lblTimer.Text = "timer";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            btnexit.Anchor = AnchorStyles.None;
            btnexit.BackColor = Color.MistyRose;
            btnexit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnexit.Location = new Point(14, 18);
            btnexit.Margin = new Padding(4, 2, 4, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(197, 1181);
            btnexit.TabIndex = 41;
            btnexit.Text = "Kilépés";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(1111, 547);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1014, 11);
            label3.TabIndex = 42;
            label3.Text = "          ";
            // 
            // DisneyQuizGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(2164, 1218);
            Controls.Add(label3);
            Controls.Add(btnexit);
            Controls.Add(lblTimer);
            Controls.Add(lblscore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(characterCorrect);
            Controls.Add(character03);
            Controls.Add(character02);
            Controls.Add(character01);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "DisneyQuizGame";
            Text = "DisneyQuiz/Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblscore;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button characterCorrect;
        private Button character03;
        private Button character02;
        private Button character01;
        private Button btnRandomCharacter;
        private Label lblTimer;
        private Button btnexit;
        private Label label3;
    }
}
