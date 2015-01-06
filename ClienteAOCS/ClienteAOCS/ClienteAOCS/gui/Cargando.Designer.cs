namespace ClienteAOCS.gui
{
    partial class Cargando
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
            this.Status = new System.Windows.Forms.RichTextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Black;
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(158, 287);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(344, 103);
            this.Status.TabIndex = 3;
            this.Status.Text = "";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Black;
            this.Logo.Location = new System.Drawing.Point(14, 15);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(640, 480);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // Cargando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 510);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cargando";
            this.Text = "Cargando";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox Status;
        internal System.Windows.Forms.PictureBox Logo;
    }
}