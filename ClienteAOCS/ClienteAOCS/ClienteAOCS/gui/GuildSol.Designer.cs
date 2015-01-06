namespace ClienteAOCS.gui
{
    partial class GuildSol
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
            this.imgEnviar = new System.Windows.Forms.PictureBox();
            this.imgCerrar = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEnviar
            // 
            this.imgEnviar.BackColor = System.Drawing.Color.Transparent;
            this.imgEnviar.Location = new System.Drawing.Point(223, 186);
            this.imgEnviar.Name = "imgEnviar";
            this.imgEnviar.Size = new System.Drawing.Size(63, 35);
            this.imgEnviar.TabIndex = 5;
            this.imgEnviar.TabStop = false;
            // 
            // imgCerrar
            // 
            this.imgCerrar.BackColor = System.Drawing.Color.Transparent;
            this.imgCerrar.Location = new System.Drawing.Point(17, 186);
            this.imgCerrar.Name = "imgCerrar";
            this.imgCerrar.Size = new System.Drawing.Size(63, 35);
            this.imgCerrar.TabIndex = 4;
            this.imgCerrar.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Black;
            this.Text1.ForeColor = System.Drawing.Color.White;
            this.Text1.Location = new System.Drawing.Point(21, 106);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(265, 69);
            this.Text1.TabIndex = 3;
            // 
            // GuildSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 233);
            this.Controls.Add(this.imgEnviar);
            this.Controls.Add(this.imgCerrar);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuildSol";
            this.Text = "GuildSol";
            ((System.ComponentModel.ISupportInitialize)(this.imgEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgEnviar;
        internal System.Windows.Forms.PictureBox imgCerrar;
        internal System.Windows.Forms.TextBox Text1;
    }
}