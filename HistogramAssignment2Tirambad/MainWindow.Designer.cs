namespace HistogramAssignment2Tirambad
{
    partial class MainWindow
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
            this.rButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rButton
            // 
            this.rButton.Enabled = false;
            this.rButton.Location = new System.Drawing.Point(12, 71);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(30, 20);
            this.rButton.TabIndex = 0;
            this.rButton.Text = "R";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // gButton
            // 
            this.gButton.Enabled = false;
            this.gButton.Location = new System.Drawing.Point(48, 71);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(30, 20);
            this.gButton.TabIndex = 1;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // bButton
            // 
            this.bButton.Enabled = false;
            this.bButton.Location = new System.Drawing.Point(84, 71);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(30, 20);
            this.bButton.TabIndex = 2;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(102, 23);
            this.openButton.TabIndex = 13;
            this.openButton.Text = "Open Image";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(121, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(161, 212);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image Files (*.bmp;*.gif;*.exif;*.jpg;*.png;*.tiff)|*.bmp;*.gif;*.exif;*.jpg;*.jp" +
    "eg;*.png;*.tiff|All Files (*.*)|*.*";
            // 
            // fitButton
            // 
            this.fitButton.Enabled = false;
            this.fitButton.Location = new System.Drawing.Point(12, 42);
            this.fitButton.Name = "fitButton";
            this.fitButton.Size = new System.Drawing.Size(102, 23);
            this.fitButton.TabIndex = 16;
            this.fitButton.Text = "Fit Image";
            this.fitButton.UseVisualStyleBackColor = true;
            this.fitButton.Click += new System.EventHandler(this.fitButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 237);
            this.Controls.Add(this.fitButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.rButton);
            this.Name = "MainWindow";
            this.Text = "Original Color Image";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button bButton;
       
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button fitButton;
    }
}

