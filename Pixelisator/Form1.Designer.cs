namespace Pixelisator
{
    partial class Form1
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
            this.LeftPicture = new System.Windows.Forms.PictureBox();
            this.RightPicture = new System.Windows.Forms.PictureBox();
            this.openBt = new System.Windows.Forms.Button();
            this.saveBt = new System.Windows.Forms.Button();
            this.redBt = new System.Windows.Forms.Button();
            this.greenBt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.blueBt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPicture
            // 
            this.LeftPicture.Location = new System.Drawing.Point(12, 12);
            this.LeftPicture.Name = "LeftPicture";
            this.LeftPicture.Size = new System.Drawing.Size(400, 400);
            this.LeftPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftPicture.TabIndex = 0;
            this.LeftPicture.TabStop = false;
            // 
            // RightPicture
            // 
            this.RightPicture.Location = new System.Drawing.Point(435, 12);
            this.RightPicture.Name = "RightPicture";
            this.RightPicture.Size = new System.Drawing.Size(406, 400);
            this.RightPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightPicture.TabIndex = 1;
            this.RightPicture.TabStop = false;
            // 
            // button1
            // 
            this.openBt.Location = new System.Drawing.Point(12, 418);
            this.openBt.Name = "button1";
            this.openBt.Size = new System.Drawing.Size(200, 162);
            this.openBt.TabIndex = 2;
            this.openBt.Text = "Open Image";
            this.openBt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.saveBt.Location = new System.Drawing.Point(218, 418);
            this.saveBt.Name = "button2";
            this.saveBt.Size = new System.Drawing.Size(200, 162);
            this.saveBt.TabIndex = 3;
            this.saveBt.Text = "Save Image";
            this.saveBt.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.redBt.Location = new System.Drawing.Point(435, 418);
            this.redBt.Name = "button3";
            this.redBt.Size = new System.Drawing.Size(200, 50);
            this.redBt.TabIndex = 4;
            this.redBt.Text = "Red Accent";
            this.redBt.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.greenBt.Location = new System.Drawing.Point(435, 474);
            this.greenBt.Name = "button4";
            this.greenBt.Size = new System.Drawing.Size(200, 50);
            this.greenBt.TabIndex = 5;
            this.greenBt.Text = "Green Accent";
            this.greenBt.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 598);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(829, 50);
            this.progressBar1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.blueBt.Location = new System.Drawing.Point(435, 530);
            this.blueBt.Name = "button5";
            this.blueBt.Size = new System.Drawing.Size(200, 50);
            this.blueBt.TabIndex = 7;
            this.blueBt.Text = "Blue Accent";
            this.blueBt.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(641, 418);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "Lighter Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(641, 474);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "Darker Edit";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(641, 530);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 26);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 660);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.blueBt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.greenBt);
            this.Controls.Add(this.redBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.openBt);
            this.Controls.Add(this.RightPicture);
            this.Controls.Add(this.LeftPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LeftPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftPicture;
        private System.Windows.Forms.PictureBox RightPicture;
        private System.Windows.Forms.Button openBt;
        private System.Windows.Forms.Button saveBt;
        private System.Windows.Forms.Button redBt;
        private System.Windows.Forms.Button greenBt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button blueBt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

