namespace Inchizitia
{
    partial class frmAddLec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtContinut = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conținut:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitlu.Location = new System.Drawing.Point(164, 61);
            this.txtTitlu.Multiline = true;
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(305, 41);
            this.txtTitlu.TabIndex = 2;
            this.txtTitlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContinut
            // 
            this.txtContinut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContinut.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContinut.Location = new System.Drawing.Point(164, 145);
            this.txtContinut.Multiline = true;
            this.txtContinut.Name = "txtContinut";
            this.txtContinut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContinut.Size = new System.Drawing.Size(305, 278);
            this.txtContinut.TabIndex = 3;
            this.txtContinut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdd.BackgroundImage")));
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.Location = new System.Drawing.Point(223, 438);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(192, 50);
            this.pbAdd.TabIndex = 6;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.AddLec_Click);
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(493, -1);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 40;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pbCloseLectie_Click);
            // 
            // frmAddLec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 500);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.txtContinut);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddLec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddLec_FormClosed);
            this.Load += new System.EventHandler(this.frmAddLec_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddLec_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAddLec_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtContinut;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbCloseLectie;
    }
}