namespace ClienteAOCS.gui
{
    partial class GuildUrl
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
            this.imgAceptar = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAceptar
            // 
            this.imgAceptar.BackColor = System.Drawing.Color.Transparent;
            this.imgAceptar.Location = new System.Drawing.Point(11, 66);
            this.imgAceptar.Name = "imgAceptar";
            this.imgAceptar.Size = new System.Drawing.Size(392, 17);
            this.imgAceptar.TabIndex = 3;
            this.imgAceptar.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.Black;
            this.txtUrl.ForeColor = System.Drawing.Color.White;
            this.txtUrl.Location = new System.Drawing.Point(14, 42);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(387, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // GuildUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 95);
            this.Controls.Add(this.imgAceptar);
            this.Controls.Add(this.txtUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildUrl";
            this.Text = "GuildUrl";
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgAceptar;
        internal System.Windows.Forms.TextBox txtUrl;
    }
}