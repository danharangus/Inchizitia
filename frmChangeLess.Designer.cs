namespace Inchizitia
{
    partial class frmChangeLess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeLess));
            this.cmbLec = new System.Windows.Forms.ComboBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLec
            // 
            this.cmbLec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLec.FormattingEnabled = true;
            this.cmbLec.Location = new System.Drawing.Point(44, 23);
            this.cmbLec.Name = "cmbLec";
            this.cmbLec.Size = new System.Drawing.Size(499, 21);
            this.cmbLec.TabIndex = 0;
            this.cmbLec.SelectedIndexChanged += new System.EventHandler(this.cmbLec_SelectedIndexChanged);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClose.Location = new System.Drawing.Point(544, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(65, 50);
            this.pbClose.TabIndex = 19;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(172, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 59);
            this.button1.TabIndex = 20;
            this.button1.Text = "Modificare continut";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(44, 77);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(499, 363);
            this.txtChange.TabIndex = 21;
            this.txtChange.Text = "";
            // 
            // frmChangeLess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 531);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.cmbLec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeLess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeLess";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChangeLess_FormClosed);
            this.Load += new System.EventHandler(this.frmChangeLess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLec;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtChange;
    }
}