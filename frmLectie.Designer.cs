namespace Inchizitia
{
    partial class frmLectie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectie));
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbPrev = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlPrim = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.tAdd = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            this.pnlPrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.Transparent;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(110, 147);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(287, 209);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseDown);
            this.pbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseMove);
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(107, 380);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(287, 31);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descriere mirifica sugestiva";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseDown);
            this.lblDesc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseMove);
            // 
            // pbPrev
            // 
            this.pbPrev.BackColor = System.Drawing.Color.Transparent;
            this.pbPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPrev.BackgroundImage")));
            this.pbPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPrev.Location = new System.Drawing.Point(107, 414);
            this.pbPrev.Name = "pbPrev";
            this.pbPrev.Size = new System.Drawing.Size(37, 27);
            this.pbPrev.TabIndex = 3;
            this.pbPrev.TabStop = false;
            this.pbPrev.Click += new System.EventHandler(this.pbPrev_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNext.BackgroundImage")));
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbNext.Location = new System.Drawing.Point(360, 414);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(34, 27);
            this.pbNext.TabIndex = 4;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(62, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(381, 113);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Titlu Lectiei";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click_1);
            this.lblTitlu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseDown);
            this.lblTitlu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseMove);
            // 
            // lbl0
            // 
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Location = new System.Drawing.Point(119, 151);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(311, 377);
            this.lbl0.TabIndex = 6;
            this.lbl0.Text = "label1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(3, 0);
            this.lbl1.MaximumSize = new System.Drawing.Size(310, 0);
            this.lbl1.MinimumSize = new System.Drawing.Size(310, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(310, 432);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = resources.GetString("lbl1.Text");
            // 
            // pnlPrim
            // 
            this.pnlPrim.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrim.Controls.Add(this.pbAdd);
            this.pnlPrim.Controls.Add(this.pbDel);
            this.pnlPrim.Controls.Add(this.pbImg);
            this.pnlPrim.Controls.Add(this.lblDesc);
            this.pnlPrim.Controls.Add(this.pbPrev);
            this.pnlPrim.Controls.Add(this.pbNext);
            this.pnlPrim.Controls.Add(this.lblTitlu);
            this.pnlPrim.Location = new System.Drawing.Point(11, 87);
            this.pnlPrim.Name = "pnlPrim";
            this.pnlPrim.Size = new System.Drawing.Size(428, 459);
            this.pnlPrim.TabIndex = 10;
            this.pnlPrim.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrim_Paint);
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAdd.BackgroundImage")));
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.Location = new System.Drawing.Point(370, 116);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(27, 25);
            this.pbAdd.TabIndex = 7;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbDel
            // 
            this.pbDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDel.BackgroundImage")));
            this.pbDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDel.Location = new System.Drawing.Point(111, 116);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(27, 25);
            this.pbDel.TabIndex = 6;
            this.pbDel.TabStop = false;
            this.pbDel.Visible = false;
            this.pbDel.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(651, 69);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(35, 13);
            this.lblNr.TabIndex = 11;
            this.lblNr.Text = "label1";
            this.lblNr.Visible = false;
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(853, 1);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 39;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // tAdd
            // 
            this.tAdd.Interval = 500;
            this.tAdd.Tick += new System.EventHandler(this.tAdd_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(460, 99);
            this.panel1.MaximumSize = new System.Drawing.Size(1000000000, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 399);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(457, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 41;
            // 
            // frmLectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.pnlPrim);
            this.Controls.Add(this.lbl0);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLectie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLectie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLectie_FormClosed);
            this.Load += new System.EventHandler(this.frmLectie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectie_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            this.pnlPrim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbPrev;
        private System.Windows.Forms.PictureBox pbNext;
        public System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnlPrim;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.Timer tAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}