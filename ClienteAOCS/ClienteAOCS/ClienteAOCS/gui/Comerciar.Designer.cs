namespace ClienteAOCS.gui
{
    partial class Comerciar
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
            this.cantidad = new System.Windows.Forms.TextBox();
            this.imgVender = new System.Windows.Forms.PictureBox();
            this.imgComprar = new System.Windows.Forms.PictureBox();
            this.picInvUser = new System.Windows.Forms.PictureBox();
            this.picInvNpc = new System.Windows.Forms.PictureBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.imgCross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvNpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidad
            // 
            this.cantidad.BackColor = System.Drawing.Color.Black;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.ForeColor = System.Drawing.Color.White;
            this.cantidad.Location = new System.Drawing.Point(207, 440);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(42, 20);
            this.cantidad.TabIndex = 19;
            this.cantidad.Text = "1";
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imgVender
            // 
            this.imgVender.BackColor = System.Drawing.Color.Transparent;
            this.imgVender.Location = new System.Drawing.Point(253, 402);
            this.imgVender.Name = "imgVender";
            this.imgVender.Size = new System.Drawing.Size(172, 31);
            this.imgVender.TabIndex = 18;
            this.imgVender.TabStop = false;
            // 
            // imgComprar
            // 
            this.imgComprar.BackColor = System.Drawing.Color.Transparent;
            this.imgComprar.Location = new System.Drawing.Point(31, 404);
            this.imgComprar.Name = "imgComprar";
            this.imgComprar.Size = new System.Drawing.Size(172, 31);
            this.imgComprar.TabIndex = 17;
            this.imgComprar.TabStop = false;
            // 
            // picInvUser
            // 
            this.picInvUser.BackColor = System.Drawing.Color.Black;
            this.picInvUser.Location = new System.Drawing.Point(260, 133);
            this.picInvUser.Name = "picInvUser";
            this.picInvUser.Size = new System.Drawing.Size(160, 256);
            this.picInvUser.TabIndex = 16;
            this.picInvUser.TabStop = false;
            // 
            // picInvNpc
            // 
            this.picInvNpc.BackColor = System.Drawing.Color.Black;
            this.picInvNpc.Location = new System.Drawing.Point(37, 133);
            this.picInvNpc.Name = "picInvNpc";
            this.picInvNpc.Size = new System.Drawing.Size(160, 256);
            this.picInvNpc.TabIndex = 15;
            this.picInvNpc.TabStop = false;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(231, 91);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(0, 13);
            this.Label12.TabIndex = 14;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Location = new System.Drawing.Point(231, 72);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(0, 13);
            this.Label13.TabIndex = 13;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(141, 72);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(0, 13);
            this.Label11.TabIndex = 12;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(141, 50);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(0, 13);
            this.Label10.TabIndex = 11;
            // 
            // imgCross
            // 
            this.imgCross.BackColor = System.Drawing.Color.Transparent;
            this.imgCross.Location = new System.Drawing.Point(402, 26);
            this.imgCross.Name = "imgCross";
            this.imgCross.Size = new System.Drawing.Size(30, 30);
            this.imgCross.TabIndex = 10;
            this.imgCross.TabStop = false;
            // 
            // Comerciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 486);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.imgVender);
            this.Controls.Add(this.imgComprar);
            this.Controls.Add(this.picInvUser);
            this.Controls.Add(this.picInvNpc);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.imgCross);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comerciar";
            this.Text = "Comerciar";
            ((System.ComponentModel.ISupportInitialize)(this.imgVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvNpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox cantidad;
        internal System.Windows.Forms.PictureBox imgVender;
        internal System.Windows.Forms.PictureBox imgComprar;
        internal System.Windows.Forms.PictureBox picInvUser;
        internal System.Windows.Forms.PictureBox picInvNpc;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.PictureBox imgCross;
    }
}