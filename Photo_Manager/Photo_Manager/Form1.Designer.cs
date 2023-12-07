namespace Photo_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button8 = new Button();
            button9 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SkyBlue;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(945, 12);
            button1.Name = "button1";
            button1.Size = new Size(175, 64);
            button1.TabIndex = 1;
            button1.Text = "Black and White";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(945, 82);
            button2.Name = "button2";
            button2.Size = new Size(175, 64);
            button2.TabIndex = 1;
            button2.Text = "Negative";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(945, 152);
            button3.Name = "button3";
            button3.Size = new Size(175, 64);
            button3.TabIndex = 1;
            button3.Text = "Soft Green";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(945, 222);
            button4.Name = "button4";
            button4.Size = new Size(175, 64);
            button4.TabIndex = 1;
            button4.Text = "Daltonian";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(945, 292);
            button5.Name = "button5";
            button5.Size = new Size(175, 64);
            button5.TabIndex = 1;
            button5.Text = "Light Red";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumSlateBlue;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(945, 395);
            button6.Name = "button6";
            button6.Size = new Size(175, 31);
            button6.TabIndex = 1;
            button6.Text = "Tag at The End";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightCoral;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(945, 432);
            button7.Name = "button7";
            button7.Size = new Size(175, 64);
            button7.TabIndex = 1;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(100, 509);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(747, 56);
            trackBar1.TabIndex = 2;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(100, 561);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(747, 56);
            trackBar2.TabIndex = 2;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(100, 603);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(747, 56);
            trackBar3.TabIndex = 2;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(16, 500);
            label1.Name = "label1";
            label1.Size = new Size(58, 31);
            label1.TabIndex = 3;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(16, 549);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 3;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Diagram;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(16, 594);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 3;
            label3.Text = "Blue";
            // 
            // button8
            // 
            button8.BackColor = Color.LightGreen;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(880, 515);
            button8.Name = "button8";
            button8.Size = new Size(240, 66);
            button8.TabIndex = 1;
            button8.Text = "Save Image";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Teal;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(880, 587);
            button9.Name = "button9";
            button9.Size = new Size(240, 66);
            button9.TabIndex = 1;
            button9.Text = "Open Image";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(945, 362);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your watermark...";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1132, 665);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Photo Manager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label1;
        private Label label2;
        private Button button8;
        private Button button9;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        internal Label label3;
        private TextBox textBox1;
    }
}