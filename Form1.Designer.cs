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
            btnRandomCharacter = new Button();
            character01 = new Button();
            character02 = new Button();
            character03 = new Button();
            characterCorrect = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRandomCharacter
            // 
            btnRandomCharacter.Location = new Point(914, 922);
            btnRandomCharacter.Name = "btnRandomCharacter";
            btnRandomCharacter.Size = new Size(1374, 141);
            btnRandomCharacter.TabIndex = 0;
            btnRandomCharacter.Text = "Új szereplő kérése";
            btnRandomCharacter.UseVisualStyleBackColor = true;
            // 
            // character01
            // 
            character01.Font = new Font("Segoe UI", 19.875F);
            character01.Location = new Point(914, 448);
            character01.Name = "character01";
            character01.Size = new Size(655, 181);
            character01.TabIndex = 3;
            character01.Text = "character01";
            character01.UseVisualStyleBackColor = true;
            // 
            // character02
            // 
            character02.Font = new Font("Segoe UI", 19.875F);
            character02.Location = new Point(914, 704);
            character02.Name = "character02";
            character02.Size = new Size(655, 181);
            character02.TabIndex = 4;
            character02.Text = "character02";
            character02.UseVisualStyleBackColor = true;
            // 
            // character03
            // 
            character03.Font = new Font("Segoe UI", 19.875F);
            character03.Location = new Point(1633, 448);
            character03.Name = "character03";
            character03.Size = new Size(655, 181);
            character03.TabIndex = 5;
            character03.Text = "character03";
            character03.UseVisualStyleBackColor = true;
            // 
            // characterCorrect
            // 
            characterCorrect.Font = new Font("Segoe UI", 19.875F);
            characterCorrect.Location = new Point(1633, 704);
            characterCorrect.Name = "characterCorrect";
            characterCorrect.Size = new Size(655, 181);
            characterCorrect.TabIndex = 6;
            characterCorrect.Text = "characterCorrect";
            characterCorrect.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(847, 1021);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(1142, 289);
            label1.Name = "label1";
            label1.Size = new Size(934, 100);
            label1.TabIndex = 8;
            label1.Text = "Találd ki ki látható a képen!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(1226, 69);
            label2.Name = "label2";
            label2.Size = new Size(741, 170);
            label2.TabIndex = 9;
            label2.Text = "Disney Quiz";
            // 
            // DisneyQuiz
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2338, 1108);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(characterCorrect);
            Controls.Add(character03);
            Controls.Add(character02);
            Controls.Add(character01);
            Controls.Add(btnRandomCharacter);
            Name = "DisneyQuiz";
            Text = "Disney Quiz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRandomCharacter;
        private Button character01;
        private Button character02;
        private Button character03;
        private Button characterCorrect;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
