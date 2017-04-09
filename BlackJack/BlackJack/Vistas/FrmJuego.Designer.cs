namespace BlackJack.Vistas
{
    partial class FrmJuego
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
            this.CartaUno = new System.Windows.Forms.PictureBox();
            this.cartaTres = new System.Windows.Forms.PictureBox();
            this.cartaDos = new System.Windows.Forms.PictureBox();
            this.cartaCinco = new System.Windows.Forms.PictureBox();
            this.cartaCuatro = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnRebajar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCuatro)).BeginInit();
            this.SuspendLayout();
            // 
            // CartaUno
            // 
            this.CartaUno.Location = new System.Drawing.Point(96, 104);
            this.CartaUno.Margin = new System.Windows.Forms.Padding(4);
            this.CartaUno.Name = "CartaUno";
            this.CartaUno.Size = new System.Drawing.Size(98, 151);
            this.CartaUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CartaUno.TabIndex = 1;
            this.CartaUno.TabStop = false;
            // 
            // cartaTres
            // 
            this.cartaTres.Location = new System.Drawing.Point(401, 240);
            this.cartaTres.Margin = new System.Windows.Forms.Padding(4);
            this.cartaTres.Name = "cartaTres";
            this.cartaTres.Size = new System.Drawing.Size(110, 147);
            this.cartaTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaTres.TabIndex = 2;
            this.cartaTres.TabStop = false;
            // 
            // cartaDos
            // 
            this.cartaDos.Location = new System.Drawing.Point(216, 220);
            this.cartaDos.Margin = new System.Windows.Forms.Padding(4);
            this.cartaDos.Name = "cartaDos";
            this.cartaDos.Size = new System.Drawing.Size(95, 139);
            this.cartaDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaDos.TabIndex = 2;
            this.cartaDos.TabStop = false;
            // 
            // cartaCinco
            // 
            this.cartaCinco.Location = new System.Drawing.Point(706, 129);
            this.cartaCinco.Margin = new System.Windows.Forms.Padding(4);
            this.cartaCinco.Name = "cartaCinco";
            this.cartaCinco.Size = new System.Drawing.Size(91, 126);
            this.cartaCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaCinco.TabIndex = 3;
            this.cartaCinco.TabStop = false;
            // 
            // cartaCuatro
            // 
            this.cartaCuatro.Location = new System.Drawing.Point(601, 209);
            this.cartaCuatro.Margin = new System.Windows.Forms.Padding(4);
            this.cartaCuatro.Name = "cartaCuatro";
            this.cartaCuatro.Size = new System.Drawing.Size(97, 141);
            this.cartaCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaCuatro.TabIndex = 4;
            this.cartaCuatro.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(273, 452);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 57);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Juego Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(376, 452);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(107, 57);
            this.btnCarta.TabIndex = 6;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnRebajar
            // 
            this.btnRebajar.Location = new System.Drawing.Point(476, 452);
            this.btnRebajar.Name = "btnRebajar";
            this.btnRebajar.Size = new System.Drawing.Size(107, 57);
            this.btnRebajar.TabIndex = 7;
            this.btnRebajar.Text = "Rebarajar";
            this.btnRebajar.UseVisualStyleBackColor = true;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources._1_split33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.btnRebajar);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cartaCuatro);
            this.Controls.Add(this.cartaCinco);
            this.Controls.Add(this.cartaDos);
            this.Controls.Add(this.cartaTres);
            this.Controls.Add(this.CartaUno);
            this.Name = "FrmJuego";
            this.Text = "FrmJuego";
            ((System.ComponentModel.ISupportInitialize)(this.CartaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCuatro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CartaUno;
        private System.Windows.Forms.PictureBox cartaTres;
        private System.Windows.Forms.PictureBox cartaDos;
        private System.Windows.Forms.PictureBox cartaCinco;
        private System.Windows.Forms.PictureBox cartaCuatro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnRebajar;
    }
}