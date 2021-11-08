namespace Inchizitia
{
    partial class frmDeleteLec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteLec));
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.lblDa = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.BurlyWood;
            this.clb.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(12, 12);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(299, 404);
            this.clb.TabIndex = 0;
            // 
            // lblDa
            // 
            this.lblDa.BackColor = System.Drawing.Color.Transparent;
            this.lblDa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.ForeColor = System.Drawing.Color.Black;
            this.lblDa.Location = new System.Drawing.Point(317, 122);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(282, 71);
            this.lblDa.TabIndex = 1;
            this.lblDa.Text = "Slectați lecțiile pe care doriți să le ștergeți";
            this.lblDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(557, 1);
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
            this.pictureBox1.Location = new System.Drawing.Point(423, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 58);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmDeleteLec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.clb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteLec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteLec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteLec_FormClosed);
            this.Load += new System.EventHandler(this.frmDeleteLec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDeleteLec_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDeleteLec_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}