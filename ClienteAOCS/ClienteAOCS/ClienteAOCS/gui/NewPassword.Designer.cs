namespace ClienteAOCS.gui
{
    partial class NewPassword
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
            this.imgAceptar = new System.Windows.Forms.PictureBox();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAceptar
            // 
            this.imgAceptar.BackColor = System.Drawing.Color.Transparent;
            this.imgAceptar.Location = new System.Drawing.Point(66, 166);
            this.imgAceptar.Name = "imgAceptar";
            this.imgAceptar.Size = new System.Drawing.Size(185, 33);
            this.imgAceptar.TabIndex = 7;
            this.imgAceptar.TabStop = false;
            // 
            // Text3
            // 
            this.Text3.BackColor = System.Drawing.Color.Black;
            this.Text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text3.ForeColor = System.Drawing.Color.White;
            this.Text3.Location = new System.Drawing.Point(25, 133);
            this.Text3.Name = "Text3";
            this.Text3.PasswordChar = '*';
            this.Text3.Size = new System.Drawing.Size(267, 20);
            this.Text3.TabIndex = 6;
            // 
            // Text2
            // 
            this.Text2.BackColor = System.Drawing.Color.Black;
            this.Text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.ForeColor = System.Drawing.Color.White;
            this.Text2.Location = new System.Drawing.Point(25, 85);
            this.Text2.Name = "Text2";
            this.Text2.PasswordChar = '*';
            this.Text2.Size = new System.Drawing.Size(267, 20);
            this.Text2.TabIndex = 5;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Black;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.Color.White;
            this.Text1.Location = new System.Drawing.Point(25, 37);
            this.Text1.Name = "Text1";
            this.Text1.PasswordChar = '*';
            this.Text1.Size = new System.Drawing.Size(267, 20);
            this.Text1.TabIndex = 4;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 237);
            this.Controls.Add(this.imgAceptar);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPassword";
            this.Text = "NewPassword";
            ((System.ComponentModel.ISupportInitialize)(this.imgAceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox imgAceptar;
        internal System.Windows.Forms.TextBox Text3;
        internal System.Windows.Forms.TextBox Text2;
        internal System.Windows.Forms.TextBox Text1;
    }
}