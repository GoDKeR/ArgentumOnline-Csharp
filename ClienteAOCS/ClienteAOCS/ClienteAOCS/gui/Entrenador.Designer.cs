namespace ClienteAOCS.gui
{
    partial class Entrenador
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
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.imgLuchar = new System.Windows.Forms.PictureBox();
            this.lstCriaturas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLuchar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSalir
            // 
            this.imgSalir.BackColor = System.Drawing.Color.Transparent;
            this.imgSalir.Location = new System.Drawing.Point(148, 191);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(89, 25);
            this.imgSalir.TabIndex = 5;
            this.imgSalir.TabStop = false;
            // 
            // imgLuchar
            // 
            this.imgLuchar.BackColor = System.Drawing.Color.Transparent;
            this.imgLuchar.Location = new System.Drawing.Point(44, 191);
            this.imgLuchar.Name = "imgLuchar";
            this.imgLuchar.Size = new System.Drawing.Size(89, 25);
            this.imgLuchar.TabIndex = 4;
            this.imgLuchar.TabStop = false;
            // 
            // lstCriaturas
            // 
            this.lstCriaturas.BackColor = System.Drawing.Color.Black;
            this.lstCriaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCriaturas.ForeColor = System.Drawing.Color.White;
            this.lstCriaturas.FormattingEnabled = true;
            this.lstCriaturas.Location = new System.Drawing.Point(62, 28);
            this.lstCriaturas.Name = "lstCriaturas";
            this.lstCriaturas.Size = new System.Drawing.Size(157, 134);
            this.lstCriaturas.TabIndex = 3;
            // 
            // Entrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 245);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.imgLuchar);
            this.Controls.Add(this.lstCriaturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrenador";
            this.Text = "Entrenador";
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLuchar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgSalir;
        internal System.Windows.Forms.PictureBox imgLuchar;
        internal System.Windows.Forms.ListBox lstCriaturas;
    }
}