namespace Inchizitia
{
    partial class frmLectiiTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectiiTest));
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbCloseLectiiTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectiiTest)).BeginInit();
            this.SuspendLayout();
            // 
            // clb
            // 
            this.clb.BackColor = System.Drawing.Color.BurlyWood;
            this.clb.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(23, 39);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(376, 469);
            this.clb.TabIndex = 34;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.SeaShell;
            this.btnNext.Location = new System.Drawing.Point(749, 539);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 49);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Continuă";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(439, 182);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(418, 90);
            this.lbl1.TabIndex = 40;
            this.lbl1.Text = "Selectaţi lecţiile care vor fi evaluate în testul grilă";
            // 
            // pbCloseLectiiTest
            // 
            this.pbCloseLectiiTest.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLectiiTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLectiiTest.BackgroundImage")));
            this.pbCloseLectiiTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLectiiTest.Location = new System.Drawing.Point(853, 2);
            this.pbCloseLectiiTest.Name = "pbCloseLectiiTest";
            this.pbCloseLectiiTest.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLectiiTest.TabIndex = 41;
            this.pbCloseLectiiTest.TabStop = false;
            this.pbCloseLectiiTest.Click += new System.EventHandler(this.closeLectiiTest_Click);
            // 
            // frmLectiiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pbCloseLectiiTest);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.clb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLectiiTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLectiiTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLectiiTest_FormClosed);
            this.Load += new System.EventHandler(this.frmLectiiTest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLectiiTest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLectiiTest_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLectiiTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clb;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbCloseLectiiTest;
    }
}