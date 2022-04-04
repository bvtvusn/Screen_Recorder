namespace ScreenCapture
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartRecording = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.chkIncludeCursor = new System.Windows.Forms.CheckBox();
            this.btnRunFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartRecording
            // 
            this.btnStartRecording.Location = new System.Drawing.Point(12, 38);
            this.btnStartRecording.Name = "btnStartRecording";
            this.btnStartRecording.Size = new System.Drawing.Size(98, 23);
            this.btnStartRecording.TabIndex = 0;
            this.btnStartRecording.Text = "Start Recording";
            this.btnStartRecording.UseVisualStyleBackColor = true;
            this.btnStartRecording.Click += new System.EventHandler(this.btnStartRecording_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(116, 40);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(187, 20);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.Text = "filename";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(13, 282);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(61, 13);
            this.lblDimensions.TabIndex = 4;
            this.lblDimensions.Text = "Dimensions";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(326, 20);
            this.txtPath.TabIndex = 5;
            this.txtPath.Text = "path";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(309, 41);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(29, 20);
            this.txtExtension.TabIndex = 6;
            this.txtExtension.Text = "mp4";
            // 
            // chkIncludeCursor
            // 
            this.chkIncludeCursor.AutoSize = true;
            this.chkIncludeCursor.Checked = true;
            this.chkIncludeCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeCursor.Location = new System.Drawing.Point(16, 67);
            this.chkIncludeCursor.Name = "chkIncludeCursor";
            this.chkIncludeCursor.Size = new System.Drawing.Size(94, 17);
            this.chkIncludeCursor.TabIndex = 7;
            this.chkIncludeCursor.Text = "Include Cursor";
            this.chkIncludeCursor.UseVisualStyleBackColor = true;
            // 
            // btnRunFile
            // 
            this.btnRunFile.Location = new System.Drawing.Point(240, 63);
            this.btnRunFile.Name = "btnRunFile";
            this.btnRunFile.Size = new System.Drawing.Size(98, 23);
            this.btnRunFile.TabIndex = 8;
            this.btnRunFile.Text = "Play video file";
            this.btnRunFile.UseVisualStyleBackColor = true;
            this.btnRunFile.Click += new System.EventHandler(this.btnRunFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 303);
            this.Controls.Add(this.btnRunFile);
            this.Controls.Add(this.chkIncludeCursor);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnStartRecording);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartRecording;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.CheckBox chkIncludeCursor;
        private System.Windows.Forms.Button btnRunFile;
    }
}

