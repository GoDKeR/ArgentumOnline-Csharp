namespace ClienteAOCS.gui
{
    partial class GuildFoundation
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
            this.imgSiguiente = new System.Windows.Forms.PictureBox();
            this.imgCancelar = new System.Windows.Forms.PictureBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtClanName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSiguiente
            // 
            this.imgSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.imgSiguiente.Location = new System.Drawing.Point(165, 219);
            this.imgSiguiente.Name = "imgSiguiente";
            this.imgSiguiente.Size = new System.Drawing.Size(89, 25);
            this.imgSiguiente.TabIndex = 7;
            this.imgSiguiente.TabStop = false;
            // 
            // imgCancelar
            // 
            this.imgCancelar.BackColor = System.Drawing.Color.Transparent;
            this.imgCancelar.Location = new System.Drawing.Point(21, 219);
            this.imgCancelar.Name = "imgCancelar";
            this.imgCancelar.Size = new System.Drawing.Size(89, 25);
            this.imgCancelar.TabIndex = 6;
            this.imgCancelar.TabStop = false;
            // 
            // txtWeb
            // 
            this.txtWeb.BackColor = System.Drawing.Color.Black;
            this.txtWeb.ForeColor = System.Drawing.Color.White;
            this.txtWeb.Location = new System.Drawing.Point(29, 187);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(223, 20);
            this.txtWeb.TabIndex = 5;
            // 
            // txtClanName
            // 
            this.txtClanName.BackColor = System.Drawing.Color.Black;
            this.txtClanName.ForeColor = System.Drawing.Color.White;
            this.txtClanName.Location = new System.Drawing.Point(29, 124);
            this.txtClanName.Name = "txtClanName";
            this.txtClanName.Size = new System.Drawing.Size(223, 20);
            this.txtClanName.TabIndex = 4;
            // 
            // GuildFoundation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 256);
            this.Controls.Add(this.imgSiguiente);
            this.Controls.Add(this.imgCancelar);
            this.Controls.Add(this.txtWeb);
            this.Controls.Add(this.txtClanName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildFoundation";
            this.Text = "GuildFoundation";
            ((System.ComponentModel.ISupportInitialize)(this.imgSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgSiguiente;
        internal System.Windows.Forms.PictureBox imgCancelar;
        internal System.Windows.Forms.TextBox txtWeb;
        internal System.Windows.Forms.TextBox txtClanName;
    }
}