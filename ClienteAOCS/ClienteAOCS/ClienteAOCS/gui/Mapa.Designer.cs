namespace ClienteAOCS.gui
{
    partial class Mapa
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.imgToggleMap0 = new System.Windows.Forms.PictureBox();
            this.imgToggleMap1 = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleMap0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(10, 523);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(545, 65);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Mapa de Argentum Online, Presione Arriba y Abajo para cambiar entre mapa global /" +
    " laberintos. Presione cualquier otra tecla para salir.";
            // 
            // imgToggleMap0
            // 
            this.imgToggleMap0.Location = new System.Drawing.Point(274, 499);
            this.imgToggleMap0.Name = "imgToggleMap0";
            this.imgToggleMap0.Size = new System.Drawing.Size(65, 17);
            this.imgToggleMap0.TabIndex = 6;
            this.imgToggleMap0.TabStop = false;
            // 
            // imgToggleMap1
            // 
            this.imgToggleMap1.Location = new System.Drawing.Point(266, 3);
            this.imgToggleMap1.Name = "imgToggleMap1";
            this.imgToggleMap1.Size = new System.Drawing.Size(65, 17);
            this.imgToggleMap1.TabIndex = 5;
            this.imgToggleMap1.TabStop = false;
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(546, 11);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(17, 17);
            this.imgCerrar.TabIndex = 4;
            this.imgCerrar.TabStop = false;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(573, 590);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.imgToggleMap0);
            this.Controls.Add(this.imgToggleMap1);
            this.Controls.Add(this.imgCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mapa";
            this.Text = "Mapa";
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleMap0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgToggleMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblTexto;
        internal System.Windows.Forms.PictureBox imgToggleMap0;
        internal System.Windows.Forms.PictureBox imgToggleMap1;
        internal System.Windows.Forms.PictureBox imgCerrar;
    }
}