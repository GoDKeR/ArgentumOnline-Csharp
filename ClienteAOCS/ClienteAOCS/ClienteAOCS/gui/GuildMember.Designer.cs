namespace ClienteAOCS.gui
{
    partial class GuildMember
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
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.imgNoticias = new System.Windows.Forms.PictureBox();
            this.imgDetalles = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstMiembros = new System.Windows.Forms.ListBox();
            this.lstClanes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoticias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(203, 313);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(185, 33);
            this.imgCerrar.TabIndex = 11;
            this.imgCerrar.TabStop = false;
            // 
            // imgNoticias
            // 
            this.imgNoticias.BackColor = System.Drawing.Color.Transparent;
            this.imgNoticias.Location = new System.Drawing.Point(11, 313);
            this.imgNoticias.Name = "imgNoticias";
            this.imgNoticias.Size = new System.Drawing.Size(185, 33);
            this.imgNoticias.TabIndex = 10;
            this.imgNoticias.TabStop = false;
            // 
            // imgDetalles
            // 
            this.imgDetalles.BackColor = System.Drawing.Color.Transparent;
            this.imgDetalles.Location = new System.Drawing.Point(11, 265);
            this.imgDetalles.Name = "imgDetalles";
            this.imgDetalles.Size = new System.Drawing.Size(177, 25);
            this.imgDetalles.TabIndex = 9;
            this.imgDetalles.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Black;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(16, 227);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // lstMiembros
            // 
            this.lstMiembros.BackColor = System.Drawing.Color.Black;
            this.lstMiembros.ForeColor = System.Drawing.Color.White;
            this.lstMiembros.FormattingEnabled = true;
            this.lstMiembros.Location = new System.Drawing.Point(206, 31);
            this.lstMiembros.Name = "lstMiembros";
            this.lstMiembros.Size = new System.Drawing.Size(174, 160);
            this.lstMiembros.TabIndex = 7;
            // 
            // lstClanes
            // 
            this.lstClanes.BackColor = System.Drawing.Color.Black;
            this.lstClanes.ForeColor = System.Drawing.Color.White;
            this.lstClanes.FormattingEnabled = true;
            this.lstClanes.Location = new System.Drawing.Point(14, 31);
            this.lstClanes.Name = "lstClanes";
            this.lstClanes.Size = new System.Drawing.Size(174, 160);
            this.lstClanes.TabIndex = 6;
            // 
            // GuildMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 376);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.imgNoticias);
            this.Controls.Add(this.imgDetalles);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstMiembros);
            this.Controls.Add(this.lstClanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildMember";
            this.Text = "GuildMember";
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNoticias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.PictureBox imgNoticias;
        internal System.Windows.Forms.PictureBox imgDetalles;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.ListBox lstMiembros;
        internal System.Windows.Forms.ListBox lstClanes;
    }
}