namespace ClienteAOCS.gui
{
    partial class GuildAdm
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
            this.imgDetalles = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.GuildsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDetalles
            // 
            this.imgDetalles.BackColor = System.Drawing.Color.Transparent;
            this.imgDetalles.Location = new System.Drawing.Point(151, 320);
            this.imgDetalles.Name = "imgDetalles";
            this.imgDetalles.Size = new System.Drawing.Size(89, 25);
            this.imgDetalles.TabIndex = 7;
            this.imgDetalles.TabStop = false;
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(31, 320);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(57, 25);
            this.imgCerrar.TabIndex = 6;
            this.imgCerrar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Black;
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(32, 295);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(207, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // GuildsList
            // 
            this.GuildsList.BackColor = System.Drawing.Color.Black;
            this.GuildsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuildsList.ForeColor = System.Drawing.Color.White;
            this.GuildsList.FormattingEnabled = true;
            this.GuildsList.Location = new System.Drawing.Point(32, 23);
            this.GuildsList.Name = "GuildsList";
            this.GuildsList.Size = new System.Drawing.Size(205, 225);
            this.GuildsList.TabIndex = 4;
            // 
            // GuildAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 369);
            this.Controls.Add(this.imgDetalles);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.GuildsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildAdm";
            this.Text = "GuildAdm";
            ((System.ComponentModel.ISupportInitialize)(this.imgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgDetalles;
        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.ListBox GuildsList;
    }
}