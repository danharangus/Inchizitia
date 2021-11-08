namespace Inchizitia
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.AL1 = new System.Windows.Forms.PictureBox();
            this.AL2 = new System.Windows.Forms.PictureBox();
            this.AL = new System.Windows.Forms.Label();
            this.SL1 = new System.Windows.Forms.PictureBox();
            this.SL2 = new System.Windows.Forms.PictureBox();
            this.SL = new System.Windows.Forms.Label();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI = new System.Windows.Forms.Label();
            this.SI = new System.Windows.Forms.Label();
            this.SI2 = new System.Windows.Forms.PictureBox();
            this.SI1 = new System.Windows.Forms.PictureBox();
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.ML1 = new System.Windows.Forms.PictureBox();
            this.ML2 = new System.Windows.Forms.PictureBox();
            this.ML = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML2)).BeginInit();
            this.SuspendLayout();
            // 
            // AL1
            // 
            this.AL1.BackColor = System.Drawing.Color.Transparent;
            this.AL1.Image = ((System.Drawing.Image)(resources.GetObject("AL1.Image")));
            this.AL1.Location = new System.Drawing.Point(258, 133);
            this.AL1.Name = "AL1";
            this.AL1.Size = new System.Drawing.Size(25, 50);
            this.AL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AL1.TabIndex = 42;
            this.AL1.TabStop = false;
            this.AL1.Visible = false;
            // 
            // AL2
            // 
            this.AL2.BackColor = System.Drawing.Color.Transparent;
            this.AL2.Image = ((System.Drawing.Image)(resources.GetObject("AL2.Image")));
            this.AL2.Location = new System.Drawing.Point(625, 133);
            this.AL2.Name = "AL2";
            this.AL2.Size = new System.Drawing.Size(25, 50);
            this.AL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AL2.TabIndex = 43;
            this.AL2.TabStop = false;
            this.AL2.Visible = false;
            // 
            // AL
            // 
            this.AL.BackColor = System.Drawing.Color.Transparent;
            this.AL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AL.ForeColor = System.Drawing.Color.Black;
            this.AL.Location = new System.Drawing.Point(256, 122);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(400, 64);
            this.AL.TabIndex = 41;
            this.AL.Text = "Adaugare lectie";
            this.AL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AL.Click += new System.EventHandler(this.AL_Click);
            this.AL.MouseEnter += new System.EventHandler(this.lblAddLec_MouseEnter);
            this.AL.MouseLeave += new System.EventHandler(this.lblAddLec_MouseLeave);
            // 
            // SL1
            // 
            this.SL1.BackColor = System.Drawing.Color.Transparent;
            this.SL1.Image = ((System.Drawing.Image)(resources.GetObject("SL1.Image")));
            this.SL1.Location = new System.Drawing.Point(269, 209);
            this.SL1.Name = "SL1";
            this.SL1.Size = new System.Drawing.Size(25, 50);
            this.SL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SL1.TabIndex = 45;
            this.SL1.TabStop = false;
            this.SL1.Visible = false;
            // 
            // SL2
            // 
            this.SL2.BackColor = System.Drawing.Color.Transparent;
            this.SL2.Image = ((System.Drawing.Image)(resources.GetObject("SL2.Image")));
            this.SL2.Location = new System.Drawing.Point(614, 210);
            this.SL2.Name = "SL2";
            this.SL2.Size = new System.Drawing.Size(25, 50);
            this.SL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SL2.TabIndex = 46;
            this.SL2.TabStop = false;
            this.SL2.Visible = false;
            // 
            // SL
            // 
            this.SL.BackColor = System.Drawing.Color.Transparent;
            this.SL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.ForeColor = System.Drawing.Color.Black;
            this.SL.Location = new System.Drawing.Point(257, 199);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(400, 64);
            this.SL.TabIndex = 44;
            this.SL.Text = "Stergere lectie";
            this.SL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SL.Click += new System.EventHandler(this.SL_Click);
            this.SL.MouseEnter += new System.EventHandler(this.lblAddLec_MouseEnter);
            this.SL.MouseLeave += new System.EventHandler(this.lblAddLec_MouseLeave);
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = ((System.Drawing.Image)(resources.GetObject("AI1.Image")));
            this.AI1.Location = new System.Drawing.Point(235, 283);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(25, 50);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AI1.TabIndex = 48;
            this.AI1.TabStop = false;
            this.AI1.Visible = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = ((System.Drawing.Image)(resources.GetObject("AI2.Image")));
            this.AI2.Location = new System.Drawing.Point(655, 284);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(25, 50);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AI2.TabIndex = 49;
            this.AI2.TabStop = false;
            this.AI2.Visible = false;
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.Color.Transparent;
            this.AI.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AI.ForeColor = System.Drawing.Color.Black;
            this.AI.Location = new System.Drawing.Point(242, 276);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(430, 64);
            this.AI.TabIndex = 47;
            this.AI.Text = "Adaugare intrebari";
            this.AI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AI.Click += new System.EventHandler(this.AI_Click);
            this.AI.MouseEnter += new System.EventHandler(this.lblAddLec_MouseEnter);
            this.AI.MouseLeave += new System.EventHandler(this.lblAddLec_MouseLeave);
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.Transparent;
            this.SI.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SI.ForeColor = System.Drawing.Color.Black;
            this.SI.Location = new System.Drawing.Point(256, 353);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(400, 64);
            this.SI.TabIndex = 50;
            this.SI.Text = "Stergere intrebari";
            this.SI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SI.Click += new System.EventHandler(this.label1_Click);
            this.SI.MouseEnter += new System.EventHandler(this.lblAddLec_MouseEnter);
            this.SI.MouseLeave += new System.EventHandler(this.lblAddLec_MouseLeave);
            // 
            // SI2
            // 
            this.SI2.BackColor = System.Drawing.Color.Transparent;
            this.SI2.Image = ((System.Drawing.Image)(resources.GetObject("SI2.Image")));
            this.SI2.Location = new System.Drawing.Point(646, 363);
            this.SI2.Name = "SI2";
            this.SI2.Size = new System.Drawing.Size(25, 50);
            this.SI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SI2.TabIndex = 51;
            this.SI2.TabStop = false;
            this.SI2.Visible = false;
            // 
            // SI1
            // 
            this.SI1.BackColor = System.Drawing.Color.Transparent;
            this.SI1.Image = ((System.Drawing.Image)(resources.GetObject("SI1.Image")));
            this.SI1.Location = new System.Drawing.Point(236, 362);
            this.SI1.Name = "SI1";
            this.SI1.Size = new System.Drawing.Size(25, 50);
            this.SI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SI1.TabIndex = 52;
            this.SI1.TabStop = false;
            this.SI1.Visible = false;
            this.SI1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(858, 2);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 53;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pbCloseLectie_Click);
            // 
            // ML1
            // 
            this.ML1.BackColor = System.Drawing.Color.Transparent;
            this.ML1.Image = ((System.Drawing.Image)(resources.GetObject("ML1.Image")));
            this.ML1.Location = new System.Drawing.Point(237, 440);
            this.ML1.Name = "ML1";
            this.ML1.Size = new System.Drawing.Size(25, 50);
            this.ML1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ML1.TabIndex = 56;
            this.ML1.TabStop = false;
            this.ML1.Visible = false;
            // 
            // ML2
            // 
            this.ML2.BackColor = System.Drawing.Color.Transparent;
            this.ML2.Image = ((System.Drawing.Image)(resources.GetObject("ML2.Image")));
            this.ML2.Location = new System.Drawing.Point(647, 441);
            this.ML2.Name = "ML2";
            this.ML2.Size = new System.Drawing.Size(25, 50);
            this.ML2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ML2.TabIndex = 55;
            this.ML2.TabStop = false;
            this.ML2.Visible = false;
            // 
            // ML
            // 
            this.ML.BackColor = System.Drawing.Color.Transparent;
            this.ML.Font = new System.Drawing.Font("Modern No. 20", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ML.ForeColor = System.Drawing.Color.Black;
            this.ML.Location = new System.Drawing.Point(257, 430);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(400, 64);
            this.ML.TabIndex = 54;
            this.ML.Text = "Modificare lectii";
            this.ML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ML.Click += new System.EventHandler(this.ML_Click);
            this.ML.MouseEnter += new System.EventHandler(this.lblAddLec_MouseEnter);
            this.ML.MouseLeave += new System.EventHandler(this.lblAddLec_MouseLeave);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.ML1);
            this.Controls.Add(this.ML2);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.SI1);
            this.Controls.Add(this.SI2);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.AI1);
            this.Controls.Add(this.AI2);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.SL1);
            this.Controls.Add(this.SL2);
            this.Controls.Add(this.SL);
            this.Controls.Add(this.AL1);
            this.Controls.Add(this.AL2);
            this.Controls.Add(this.AL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdmin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.AL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AL1;
        private System.Windows.Forms.PictureBox AL2;
        private System.Windows.Forms.Label AL;
        private System.Windows.Forms.PictureBox SL1;
        private System.Windows.Forms.PictureBox SL2;
        private System.Windows.Forms.Label SL;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.Label AI;
        private System.Windows.Forms.Label SI;
        private System.Windows.Forms.PictureBox SI2;
        private System.Windows.Forms.PictureBox SI1;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.PictureBox ML1;
        private System.Windows.Forms.PictureBox ML2;
        private System.Windows.Forms.Label ML;
    }
}