namespace Inchizitia
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbNoNetwork = new System.Windows.Forms.PictureBox();
            this.pbNetwork = new System.Windows.Forms.PictureBox();
            this.pbCloseRegister = new System.Windows.Forms.PictureBox();
            this.pbRegister = new System.Windows.Forms.PictureBox();
            this.pbPSH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.BurlyWood;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMail.ForeColor = System.Drawing.Color.Black;
            this.txtMail.Location = new System.Drawing.Point(137, 130);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 31);
            this.txtMail.TabIndex = 12;
            this.txtMail.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(20, 122);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(111, 40);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail:";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(137, 79);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(217, 31);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(20, 75);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(111, 40);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Parola:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.BurlyWood;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(137, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(217, 31);
            this.txtUser.TabIndex = 8;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(20, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 40);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Nume utilizator:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbNoNetwork
            // 
            this.pbNoNetwork.BackColor = System.Drawing.Color.Transparent;
            this.pbNoNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pbNoNetwork.Image")));
            this.pbNoNetwork.Location = new System.Drawing.Point(365, 2);
            this.pbNoNetwork.Name = "pbNoNetwork";
            this.pbNoNetwork.Size = new System.Drawing.Size(28, 28);
            this.pbNoNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNoNetwork.TabIndex = 14;
            this.pbNoNetwork.TabStop = false;
            this.pbNoNetwork.Visible = false;
            // 
            // pbNetwork
            // 
            this.pbNetwork.BackColor = System.Drawing.Color.Transparent;
            this.pbNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pbNetwork.Image")));
            this.pbNetwork.Location = new System.Drawing.Point(365, 2);
            this.pbNetwork.Name = "pbNetwork";
            this.pbNetwork.Size = new System.Drawing.Size(28, 28);
            this.pbNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNetwork.TabIndex = 15;
            this.pbNetwork.TabStop = false;
            this.pbNetwork.Visible = false;
            // 
            // pbCloseRegister
            // 
            this.pbCloseRegister.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseRegister.BackgroundImage")));
            this.pbCloseRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseRegister.Location = new System.Drawing.Point(399, 2);
            this.pbCloseRegister.Name = "pbCloseRegister";
            this.pbCloseRegister.Size = new System.Drawing.Size(46, 28);
            this.pbCloseRegister.TabIndex = 40;
            this.pbCloseRegister.TabStop = false;
            this.pbCloseRegister.Click += new System.EventHandler(this.closeRegister_Click);
            // 
            // pbRegister
            // 
            this.pbRegister.BackColor = System.Drawing.Color.Transparent;
            this.pbRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRegister.BackgroundImage")));
            this.pbRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRegister.Location = new System.Drawing.Point(284, 176);
            this.pbRegister.Name = "pbRegister";
            this.pbRegister.Size = new System.Drawing.Size(161, 50);
            this.pbRegister.TabIndex = 41;
            this.pbRegister.TabStop = false;
            this.pbRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbPSH
            // 
            this.pbPSH.BackColor = System.Drawing.Color.Transparent;
            this.pbPSH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPSH.Location = new System.Drawing.Point(365, 75);
            this.pbPSH.Name = "pbPSH";
            this.pbPSH.Size = new System.Drawing.Size(35, 35);
            this.pbPSH.TabIndex = 43;
            this.pbPSH.TabStop = false;
            this.pbPSH.Click += new System.EventHandler(this.pbPSH_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 238);
            this.Controls.Add(this.pbPSH);
            this.Controls.Add(this.pbRegister);
            this.Controls.Add(this.pbCloseRegister);
            this.Controls.Add(this.pbNetwork);
            this.Controls.Add(this.pbNoNetwork);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegister_FormClosed);
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbNoNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbNoNetwork;
        private System.Windows.Forms.PictureBox pbNetwork;
        private System.Windows.Forms.PictureBox pbCloseRegister;
        public System.Windows.Forms.PictureBox pbRegister;
        private System.Windows.Forms.PictureBox pbPSH;
    }
}