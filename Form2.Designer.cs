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
            lblscore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblscore.BackColor = Color.MistyRose;
            lblscore.BorderStyle = BorderStyle.Fixed3D;
            lblscore.Font = new Font("Times New Roman", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblscore.Location = new Point(887, 219);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(271, 48);
            lblscore.TabIndex = 39;
            lblscore.Text = "Az eddig elért pontjaid: ";
            lblscore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(702, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(351, 73);
            label2.TabIndex = 38;
            label2.Text = "Disney Quiz";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(731, 150);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 43);
            label1.TabIndex = 37;
            label1.Text = "Kit látsz a képen?\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(144, 20);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 552);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // characterCorrect
            // 
            characterCorrect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            characterCorrect.BackColor = Color.MistyRose;
            characterCorrect.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            characterCorrect.Location = new Point(889, 405);
            characterCorrect.Margin = new Padding(2, 1, 2, 1);
            characterCorrect.Name = "characterCorrect";
            characterCorrect.Size = new Size(269, 96);
            characterCorrect.TabIndex = 35;
            characterCorrect.Text = "characterCorrect";
            characterCorrect.UseVisualStyleBackColor = false;
            // 
            // character03
            // 
            character03.Anchor = AnchorStyles.Right;
            character03.BackColor = Color.MistyRose;
            character03.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character03.Location = new Point(889, 302);
            character03.Margin = new Padding(2, 1, 2, 1);
            character03.Name = "character03";
            character03.Size = new Size(269, 96);
            character03.TabIndex = 34;
            character03.Text = "character03";
            character03.UseVisualStyleBackColor = false;
            // 
            // character02
            // 
            character02.Anchor = AnchorStyles.Bottom;
            character02.BackColor = Color.MistyRose;
            character02.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character02.Location = new Point(611, 405);
            character02.Margin = new Padding(2, 1, 2, 1);
            character02.Name = "character02";
            character02.Size = new Size(269, 96);
            character02.TabIndex = 33;
            character02.Text = "character02";
            character02.UseVisualStyleBackColor = false;
            // 
            // character01
            // 
            character01.BackColor = Color.MistyRose;
            character01.Font = new Font("Times New Roman", 24F, FontStyle.Bold);
            character01.Location = new Point(611, 302);
            character01.Margin = new Padding(2, 1, 2, 1);
            character01.Name = "character01";
            character01.Size = new Size(269, 96);
            character01.TabIndex = 32;
            character01.Text = "character01";
            character01.UseVisualStyleBackColor = false;
            // 
            // lblTimer
            // 
            lblTimer.Anchor = AnchorStyles.Top;
            lblTimer.BackColor = Color.MistyRose;
            lblTimer.BorderStyle = BorderStyle.Fixed3D;
            lblTimer.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTimer.Location = new Point(611, 219);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(271, 48);
            lblTimer.TabIndex = 40;
            lblTimer.Text = "timer";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnexit.BackColor = Color.MistyRose;
            btnexit.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnexit.Location = new Point(19, 10);
            btnexit.Margin = new Padding(2, 1, 2, 1);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(106, 580);
            btnexit.TabIndex = 41;
            btnexit.Text = "Kilépés";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(612, 278);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(546, 5);
            label3.TabIndex = 42;
            label3.Text = "          ";
            // 
            // DisneyQuizGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1200, 600);
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
            Margin = new Padding(2, 1, 2, 1);
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
