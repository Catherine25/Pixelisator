namespace Pixelisator
{
    partial class Form1 {
        const int buttonWidth = 100,
        buttonHeight = 50,
        drawingPoint = 820,
        offset = 10;
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent() {
            this.WorkPicture = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkPicture
            // 
            this.WorkPicture.Location = new System.Drawing.Point(offset, offset);
            this.WorkPicture.Name = "WorkPicture";
            this.WorkPicture.Size = new System.Drawing.Size(1000-offset*2, drawingPoint-2*offset);
            this.WorkPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WorkPicture.TabIndex = 1;
            this.WorkPicture.TabStop = false;
            // 
            // button1
            // 
            this.openBt.Location = new System.Drawing.Point(offset, drawingPoint);
            this.openBt.Name = "button1";
            this.openBt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.openBt.TabIndex = 2;
            this.openBt.Text = "Open Image";
            this.openBt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.saveBt.Location = new System.Drawing.Point(2*offset+buttonWidth, drawingPoint);
            this.saveBt.Name = "button2";
            this.saveBt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.saveBt.TabIndex = 3;
            this.saveBt.Text = "Save Image";
            this.saveBt.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.redBt.Location = new System.Drawing.Point(3*offset+2*buttonWidth, drawingPoint);
            this.redBt.Name = "button3";
            this.redBt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.redBt.TabIndex = 4;
            this.redBt.Text = "Red Accent";
            this.redBt.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.greenBt.Location = new System.Drawing.Point(4*offset+3*buttonWidth, drawingPoint);
            this.greenBt.Name = "button4";
            this.greenBt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.greenBt.TabIndex = 5;
            this.greenBt.Text = "Green Accent";
            this.greenBt.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 880);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(980, 50);
            this.progressBar1.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.blueBt.Location = new System.Drawing.Point(5*offset+4*buttonWidth, drawingPoint);
            this.blueBt.Name = "button5";
            this.blueBt.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.blueBt.TabIndex = 7;
            this.blueBt.Text = "Blue Accent";
            this.blueBt.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6*offset+5*buttonWidth, drawingPoint);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.button6.TabIndex = 8;
            this.button6.Text = "Lighter Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(7*offset+6*buttonWidth, drawingPoint);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
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
            this.numericUpDown1.Location = new System.Drawing.Point(8*offset+7*buttonWidth, drawingPoint);
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
            this.numericUpDown1.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
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
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.blueBt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.greenBt);
            this.Controls.Add(this.redBt);
            this.Controls.Add(this.saveBt);
            this.Controls.Add(this.openBt);
            this.Controls.Add(this.WorkPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WorkPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox WorkPicture;
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

