namespace Inchizitia
{
    partial class frmDeleteQu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteQu));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDa = new System.Windows.Forms.Label();
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.lstB = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SeaShell;
            this.btnNext.Location = new System.Drawing.Point(446, 373);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 49);
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Continuă";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblDa
            // 
            this.lblDa.BackColor = System.Drawing.Color.Transparent;
            this.lblDa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.ForeColor = System.Drawing.Color.Black;
            this.lblDa.Location = new System.Drawing.Point(109, 299);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(357, 71);
            this.lblDa.TabIndex = 41;
            this.lblDa.Text = "Selectați întrebăriile pe care doriți să le ștergeți";
            this.lblDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(566, 3);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 43;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pbCloseLectie_Click);
            // 
            // lstB
            // 
            this.lstB.BackColor = System.Drawing.Color.BurlyWood;
            this.lstB.CheckOnClick = true;
            this.lstB.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstB.FormattingEnabled = true;
            this.lstB.Location = new System.Drawing.Point(35, 32);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(536, 234);
            this.lstB.TabIndex = 44;
            // 
            // frmDeleteQu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 436);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblDa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteQu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteQu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDeleteQu_FormClosed);
            this.Load += new System.EventHandler(this.frmDeleteQu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDeleteQu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDeleteQu_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.CheckedListBox lstB;
    }
}