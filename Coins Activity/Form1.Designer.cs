namespace Coins_Activity
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            countCoinsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Peso5Count = new Label();
            Peso1Count = new Label();
            Cent25Count = new Label();
            Cent10Count = new Label();
            Cent5Count = new Label();
            TotalValue = new Label();
            TotalCoinCount = new Label();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, countCoinsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(843, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // countCoinsToolStripMenuItem
            // 
            countCoinsToolStripMenuItem.Name = "countCoinsToolStripMenuItem";
            countCoinsToolStripMenuItem.Size = new Size(100, 24);
            countCoinsToolStripMenuItem.Text = "Count coins";
            countCoinsToolStripMenuItem.Click += countCoinsToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(343, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(325, 468);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(692, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Total Coins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(692, 131);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "5 Peso: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(692, 100);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 5;
            label3.Text = "COUNT FOR EACH";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 165);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "1 Peso: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 196);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "25 Cents: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 230);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 8;
            label6.Text = "10 Cents: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(700, 263);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 9;
            label7.Text = "5 Cents: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(692, 324);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 10;
            label8.Text = "Total Value:";
            // 
            // Peso5Count
            // 
            Peso5Count.AutoSize = true;
            Peso5Count.Location = new Point(779, 131);
            Peso5Count.Name = "Peso5Count";
            Peso5Count.Size = new Size(15, 20);
            Peso5Count.TabIndex = 11;
            Peso5Count.Text = "-";
            // 
            // Peso1Count
            // 
            Peso1Count.AutoSize = true;
            Peso1Count.Location = new Point(779, 165);
            Peso1Count.Name = "Peso1Count";
            Peso1Count.Size = new Size(15, 20);
            Peso1Count.TabIndex = 12;
            Peso1Count.Text = "-";
            // 
            // Cent25Count
            // 
            Cent25Count.AutoSize = true;
            Cent25Count.Location = new Point(779, 196);
            Cent25Count.Name = "Cent25Count";
            Cent25Count.Size = new Size(15, 20);
            Cent25Count.TabIndex = 13;
            Cent25Count.Text = "-";
            // 
            // Cent10Count
            // 
            Cent10Count.AutoSize = true;
            Cent10Count.Location = new Point(779, 230);
            Cent10Count.Name = "Cent10Count";
            Cent10Count.Size = new Size(15, 20);
            Cent10Count.TabIndex = 14;
            Cent10Count.Text = "-";
            // 
            // Cent5Count
            // 
            Cent5Count.AutoSize = true;
            Cent5Count.Location = new Point(779, 263);
            Cent5Count.Name = "Cent5Count";
            Cent5Count.Size = new Size(15, 20);
            Cent5Count.TabIndex = 15;
            Cent5Count.Text = "-";
            // 
            // TotalValue
            // 
            TotalValue.AutoSize = true;
            TotalValue.Location = new Point(700, 357);
            TotalValue.Name = "TotalValue";
            TotalValue.Size = new Size(15, 20);
            TotalValue.TabIndex = 16;
            TotalValue.Text = "-";
            // 
            // TotalCoinCount
            // 
            TotalCoinCount.AutoSize = true;
            TotalCoinCount.Location = new Point(700, 65);
            TotalCoinCount.Name = "TotalCoinCount";
            TotalCoinCount.Size = new Size(15, 20);
            TotalCoinCount.TabIndex = 17;
            TotalCoinCount.Text = "-";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 675);
            Controls.Add(TotalCoinCount);
            Controls.Add(TotalValue);
            Controls.Add(Cent5Count);
            Controls.Add(Cent10Count);
            Controls.Add(Cent25Count);
            Controls.Add(Peso1Count);
            Controls.Add(Peso5Count);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem countCoinsToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label Peso5Count;
        private Label Peso1Count;
        private Label Cent25Count;
        private Label Cent10Count;
        private Label Cent5Count;
        private Label TotalValue;
        private Label TotalCoinCount;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem openToolStripMenuItem;
    }
}
