namespace ClienteAOCS.gui
{
    partial class Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.imgSalir = new System.Windows.Forms.PictureBox();
            this.imgCrearPJ = new System.Windows.Forms.PictureBox();
            this.imgConectarse = new System.Windows.Forms.PictureBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrearPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConectarse)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSalir
            // 
            this.imgSalir.Location = new System.Drawing.Point(675, 560);
            this.imgSalir.Name = "imgSalir";
            this.imgSalir.Size = new System.Drawing.Size(79, 18);
            this.imgSalir.TabIndex = 9;
            this.imgSalir.TabStop = false;
            // 
            // imgCrearPJ
            // 
            this.imgCrearPJ.Location = new System.Drawing.Point(409, 268);
            this.imgCrearPJ.Name = "imgCrearPJ";
            this.imgCrearPJ.Size = new System.Drawing.Size(79, 18);
            this.imgCrearPJ.TabIndex = 8;
            this.imgCrearPJ.TabStop = false;
            // 
            // imgConectarse
            // 
            this.imgConectarse.Location = new System.Drawing.Point(324, 268);
            this.imgConectarse.Name = "imgConectarse";
            this.imgConectarse.Size = new System.Drawing.Size(79, 18);
            this.imgConectarse.TabIndex = 7;
            this.imgConectarse.TabStop = false;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.Color.Black;
            this.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswd.ForeColor = System.Drawing.Color.White;
            this.txtPasswd.Location = new System.Drawing.Point(325, 249);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(165, 13);
            this.txtPasswd.TabIndex = 6;
            this.txtPasswd.Text = "123";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(325, 216);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 13);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.imgSalir);
            this.Controls.Add(this.imgCrearPJ);
            this.Controls.Add(this.imgConectarse);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connect";
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.Connect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrearPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConectarse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgSalir;
        internal System.Windows.Forms.PictureBox imgCrearPJ;
        internal System.Windows.Forms.PictureBox imgConectarse;
        internal System.Windows.Forms.TextBox txtPasswd;
        internal System.Windows.Forms.TextBox txtNombre;
    }
}