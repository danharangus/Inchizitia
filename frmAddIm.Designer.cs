namespace Inchizitia
{
    partial class frmAddIm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddIm));
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.Location = new System.Drawing.Point(50, 23);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(388, 320);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(50, 365);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(388, 37);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pbPrev
            // 
            this.pbPrev.BackColor = System.Drawing.Color.Transparent;
            this.pbPrev.Image = ((System.Drawing.Image)(resources.GetObject("pbPrev.Image")));
            this.pbPrev.Location = new System.Drawing.Point(12, 425);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(50, 50);
            this.pbPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPrev.TabIndex = 8;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.lblPrev_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(438, 425);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(50, 50);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 9;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(68, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 50);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.lblAddImg_Click);
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(460, 1);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 40;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pbCloseLectie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(255, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // frmAddIm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbPrev);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddIm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddIm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddIm_FormClosed);
            this.Load += new System.EventHandler(this.frmAddIm_Load);
            this.Click += new System.EventHandler(this.txtDesc_TextChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddIm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAddIm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}