namespace ClienteAOCS.gui
{
    partial class GuildNews
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
            this.txtClanesAliados = new System.Windows.Forms.TextBox();
            this.txtClanesGuerra = new System.Windows.Forms.TextBox();
            this.news = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAceptar
            // 
            this.imgAceptar.BackColor = System.Drawing.Color.Transparent;
            this.imgAceptar.Location = new System.Drawing.Point(12, 415);
            this.imgAceptar.Name = "imgAceptar";
            this.imgAceptar.Size = new System.Drawing.Size(290, 25);
            this.imgAceptar.TabIndex = 7;
            this.imgAceptar.TabStop = false;
            // 
            // txtClanesAliados
            // 
            this.txtClanesAliados.BackColor = System.Drawing.Color.Black;
            this.txtClanesAliados.ForeColor = System.Drawing.Color.White;
            this.txtClanesAliados.Location = new System.Drawing.Point(12, 335);
            this.txtClanesAliados.Multiline = true;
            this.txtClanesAliados.Name = "txtClanesAliados";
            this.txtClanesAliados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClanesAliados.Size = new System.Drawing.Size(285, 68);
            this.txtClanesAliados.TabIndex = 6;
            // 
            // txtClanesGuerra
            // 
            this.txtClanesGuerra.BackColor = System.Drawing.Color.Black;
            this.txtClanesGuerra.ForeColor = System.Drawing.Color.White;
            this.txtClanesGuerra.Location = new System.Drawing.Point(12, 231);
            this.txtClanesGuerra.Multiline = true;
            this.txtClanesGuerra.Name = "txtClanesGuerra";
            this.txtClanesGuerra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtClanesGuerra.Size = new System.Drawing.Size(285, 68);
            this.txtClanesGuerra.TabIndex = 5;
            // 
            // news
            // 
            this.news.BackColor = System.Drawing.Color.Black;
            this.news.ForeColor = System.Drawing.Color.White;
            this.news.Location = new System.Drawing.Point(12, 54);
            this.news.Multiline = true;
            this.news.Name = "news";
            this.news.Size = new System.Drawing.Size(285, 140);
            this.news.TabIndex = 4;
            // 
            // GuildNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 452);
            this.Controls.Add(this.imgAceptar);
            this.Controls.Add(this.txtClanesAliados);
            this.Controls.Add(this.txtClanesGuerra);
            this.Controls.Add(this.news);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildNews";
            this.Text = "GuildNews";
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgAceptar;
        internal System.Windows.Forms.TextBox txtClanesAliados;
        internal System.Windows.Forms.TextBox txtClanesGuerra;
        internal System.Windows.Forms.TextBox news;
    }
}