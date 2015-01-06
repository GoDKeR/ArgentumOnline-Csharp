namespace ClienteAOCS.gui
{
    partial class PeaceProp
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
            this.imgRechazar = new System.Windows.Forms.PictureBox();
            this.imgAceptar = new System.Windows.Forms.PictureBox();
            this.imgDetalle = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.lista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgRechazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgRechazar
            // 
            this.imgRechazar.BackColor = System.Drawing.Color.Transparent;
            this.imgRechazar.Location = new System.Drawing.Point(255, 157);
            this.imgRechazar.Name = "imgRechazar";
            this.imgRechazar.Size = new System.Drawing.Size(64, 32);
            this.imgRechazar.TabIndex = 9;
            this.imgRechazar.TabStop = false;
            // 
            // imgAceptar
            // 
            this.imgAceptar.BackColor = System.Drawing.Color.Transparent;
            this.imgAceptar.Location = new System.Drawing.Point(175, 157);
            this.imgAceptar.Name = "imgAceptar";
            this.imgAceptar.Size = new System.Drawing.Size(64, 32);
            this.imgAceptar.TabIndex = 8;
            this.imgAceptar.TabStop = false;
            // 
            // imgDetalle
            // 
            this.imgDetalle.BackColor = System.Drawing.Color.Transparent;
            this.imgDetalle.Location = new System.Drawing.Point(95, 157);
            this.imgDetalle.Name = "imgDetalle";
            this.imgDetalle.Size = new System.Drawing.Size(64, 32);
            this.imgDetalle.TabIndex = 7;
            this.imgDetalle.TabStop = false;
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(15, 157);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(64, 32);
            this.imgCerrar.TabIndex = 6;
            this.imgCerrar.TabStop = false;
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.Black;
            this.lista.ForeColor = System.Drawing.Color.White;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(15, 29);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(308, 108);
            this.lista.TabIndex = 5;
            // 
            // PeaceProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 219);
            this.Controls.Add(this.imgRechazar);
            this.Controls.Add(this.imgAceptar);
            this.Controls.Add(this.imgDetalle);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeaceProp";
            this.Text = "PeaceProp";
            ((System.ComponentModel.ISupportInitialize)(this.imgRechazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgRechazar;
        internal System.Windows.Forms.PictureBox imgAceptar;
        internal System.Windows.Forms.PictureBox imgDetalle;
        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.ListBox lista;
    }
}