namespace ClienteAOCS.gui
{
    partial class Cantidad
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
            this.imgTirarTodo = new System.Windows.Forms.PictureBox();
            this.imgTirar = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTirarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTirar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTirarTodo
            // 
            this.imgTirarTodo.BackColor = System.Drawing.Color.Transparent;
            this.imgTirarTodo.Location = new System.Drawing.Point(113, 54);
            this.imgTirarTodo.Name = "imgTirarTodo";
            this.imgTirarTodo.Size = new System.Drawing.Size(89, 25);
            this.imgTirarTodo.TabIndex = 5;
            this.imgTirarTodo.TabStop = false;
            // 
            // imgTirar
            // 
            this.imgTirar.BackColor = System.Drawing.Color.Transparent;
            this.imgTirar.Location = new System.Drawing.Point(15, 54);
            this.imgTirar.Name = "imgTirar";
            this.imgTirar.Size = new System.Drawing.Size(89, 25);
            this.imgTirar.TabIndex = 4;
            this.imgTirar.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(31, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 98);
            this.Controls.Add(this.imgTirarTodo);
            this.Controls.Add(this.imgTirar);
            this.Controls.Add(this.txtCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cantidad";
            this.Text = "Cantidad";
            ((System.ComponentModel.ISupportInitialize)(this.imgTirarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTirar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgTirarTodo;
        internal System.Windows.Forms.PictureBox imgTirar;
        internal System.Windows.Forms.TextBox txtCantidad;
    }
}