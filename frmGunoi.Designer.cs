namespace Inchizitia
{
    partial class frmGunoi
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
            this.SuspendLayout();
            // 
            // frmGunoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 509);
            this.Name = "frmGunoi";
            this.Text = "frmGunoi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGunoi_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGunoi_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}