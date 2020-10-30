namespace MemberManagementSystem
{
    partial class frmCodeScann
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
            this.picWebCam = new System.Windows.Forms.PictureBox();
            this.tWebCamTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // picWebCam
            // 
            this.picWebCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWebCam.Location = new System.Drawing.Point(13, 13);
            this.picWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.picWebCam.Name = "picWebCam";
            this.picWebCam.Size = new System.Drawing.Size(707, 506);
            this.picWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWebCam.TabIndex = 33;
            this.picWebCam.TabStop = false;
            // 
            // tWebCamTimer
            // 
            this.tWebCamTimer.Tick += new System.EventHandler(this.tWebCamTimer_Tick);
            // 
            // frmCodeScann
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(733, 532);
            this.Controls.Add(this.picWebCam);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCodeScann";
            this.Text = "二维码扫描";
            this.Load += new System.EventHandler(this.frmCodeScann_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWebCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebCam;
        private System.Windows.Forms.Timer tWebCamTimer;
    }
}