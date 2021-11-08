namespace Inchizitia
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pbNetwork = new System.Windows.Forms.PictureBox();
            this.pbNoNetwork = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbCloseLogin = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbPSH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoNetwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSH)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNetwork
            // 
            this.pbNetwork.BackColor = System.Drawing.Color.Transparent;
            this.pbNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pbNetwork.Image")));
            this.pbNetwork.Location = new System.Drawing.Point(370, 2);
            this.pbNetwork.Name = "pbNetwork";
            this.pbNetwork.Size = new System.Drawing.Size(28, 28);
            this.pbNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNetwork.TabIndex = 29;
            this.pbNetwork.TabStop = false;
            this.pbNetwork.Visible = false;
            // 
            // pbNoNetwork
            // 
            this.pbNoNetwork.BackColor = System.Drawing.Color.Transparent;
            this.pbNoNetwork.Image = ((System.Drawing.Image)(resources.GetObject("pbNoNetwork.Image")));
            this.pbNoNetwork.Location = new System.Drawing.Point(370, 2);
            this.pbNoNetwork.Name = "pbNoNetwork";
            this.pbNoNetwork.Size = new System.Drawing.Size(28, 28);
            this.pbNoNetwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNoNetwork.TabIndex = 28;
            this.pbNoNetwork.TabStop = false;
            this.pbNoNetwork.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.BurlyWood;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPass.Location = new System.Drawing.Point(133, 105);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 29);
            this.txtPass.TabIndex = 24;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(16, 105);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(111, 30);
            this.lblPass.TabIndex = 23;
            this.lblPass.Text = "Parola:";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.BurlyWood;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUser.Location = new System.Drawing.Point(133, 43);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 29);
            this.txtUser.TabIndex = 22;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(16, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 30);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Mail:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbCloseLogin
            // 
            this.pbCloseLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbCloseLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCloseLogin.BackgroundImage")));
            this.pbCloseLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCloseLogin.Location = new System.Drawing.Point(404, 2);
            this.pbCloseLogin.Name = "pbCloseLogin";
            this.pbCloseLogin.Size = new System.Drawing.Size(46, 28);
            this.pbCloseLogin.TabIndex = 40;
            this.pbCloseLogin.TabStop = false;
            this.pbCloseLogin.Click += new System.EventHandler(this.pbCloseLogin_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogin.BackgroundImage")));
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogin.Location = new System.Drawing.Point(279, 176);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(161, 50);
            this.pbLogin.TabIndex = 41;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pbPSH
            // 
            this.pbPSH.BackColor = System.Drawing.Color.Transparent;
            this.pbPSH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPSH.Location = new System.Drawing.Point(359, 103);
            this.pbPSH.Name = "pbPSH";
            this.pbPSH.Size = new System.Drawing.Size(35, 35);
            this.pbPSH.TabIndex = 42;
            this.pbPSH.TabStop = false;
            this.pbPSH.Click += new System.EventHandler(this.pbPSH_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 238);
            this.Controls.Add(this.pbPSH);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pbCloseLogin);
            this.Controls.Add(this.pbNetwork);
            this.Controls.Add(this.pbNoNetwork);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNoNetwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPSH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbNetwork;
        private System.Windows.Forms.PictureBox pbNoNetwork;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbCloseLogin;
        public System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbPSH;
    }
}