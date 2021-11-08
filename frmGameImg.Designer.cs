namespace Inchizitia
{
    partial class frmGameImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameImg));
            this.tBg = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Label();
            this.tWrong = new System.Windows.Forms.Timer(this.components);
            this.tTime = new System.Windows.Forms.Timer(this.components);
            this.pbCloseLectie = new System.Windows.Forms.PictureBox();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).BeginInit();
            this.pnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBg
            // 
            this.tBg.Interval = 1000;
            this.tBg.Tick += new System.EventHandler(this.tShow_Tick);
            // 
            // lTime
            // 
            this.lTime.BackColor = System.Drawing.Color.Transparent;
            this.lTime.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(2, 0);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(995, 52);
            this.lTime.TabIndex = 0;
            this.lTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTime.Click += new System.EventHandler(this.lTime_Click);
            // 
            // tWrong
            // 
            this.tWrong.Interval = 500;
            this.tWrong.Tick += new System.EventHandler(this.tWrong_Tick);
            // 
            // tTime
            // 
            this.tTime.Interval = 1000;
            this.tTime.Tick += new System.EventHandler(this.tTime_Tick);
            // 
            // pbCloseLectie
            // 
            this.pbCloseLectie.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectie.BackgroundImage")));
            this.pbCloseLectie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectie.Location = new System.Drawing.Point(951, 0);
            this.pbCloseLectie.Name = "pbCloseLectie";
            this.pbCloseLectie.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectie.TabIndex = 40;
            this.pbCloseLectie.TabStop = false;
            this.pbCloseLectie.Click += new System.EventHandler(this.pbCloseLectie_Click);
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlStart.Controls.Add(this.lblB);
            this.pnlStart.Controls.Add(this.lblBP);
            this.pnlStart.Controls.Add(this.label2);
            this.pnlStart.Controls.Add(this.label1);
            this.pnlStart.Controls.Add(this.button1);
            this.pnlStart.Location = new System.Drawing.Point(69, 91);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(781, 357);
            this.pnlStart.TabIndex = 46;
            this.pnlStart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStart_Paint);
            this.pnlStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameImg_MouseDown);
            this.pnlStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGameImg_MouseMove);
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(434, 251);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(280, 42);
            this.lblB.TabIndex = 50;
            this.lblB.Text = "label4";
            this.lblB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBP
            // 
            this.lblBP.BackColor = System.Drawing.Color.Transparent;
            this.lblBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBP.Location = new System.Drawing.Point(434, 181);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(280, 43);
            this.lblBP.TabIndex = 49;
            this.lblBP.Text = "label3";
            this.lblBP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 31);
            this.label2.TabIndex = 48;
            this.label2.Text = "Cel mai bun scor personal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cel mai bun scor:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(276, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 89);
            this.button1.TabIndex = 46;
            this.button1.Text = "Incepe Jocul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmGameImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pbCloseLectie);
            this.Controls.Add(this.lTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameImg_FormClosed);
            this.Load += new System.EventHandler(this.frmGameImg_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGameImg_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGameImg_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectie)).EndInit();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tBg;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer tWrong;
        private System.Windows.Forms.Timer tTime;
        private System.Windows.Forms.PictureBox pbCloseLectie;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}