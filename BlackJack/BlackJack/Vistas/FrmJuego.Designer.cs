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
            this.c1 = new System.Windows.Forms.PictureBox();
            this.c5 = new System.Windows.Forms.PictureBox();
            this.c4 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.btnQuedarse = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalJugadas = new System.Windows.Forms.TextBox();
            this.txtGanadas = new System.Windows.Forms.TextBox();
            this.fotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartaUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCinco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // CartaUno
            // 
            this.CartaUno.Location = new System.Drawing.Point(262, 280);
            this.CartaUno.Margin = new System.Windows.Forms.Padding(4);
            this.CartaUno.Name = "CartaUno";
            this.CartaUno.Size = new System.Drawing.Size(98, 139);
            this.CartaUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CartaUno.TabIndex = 1;
            this.CartaUno.TabStop = false;
            // 
            // cartaTres
            // 
            this.cartaTres.Location = new System.Drawing.Point(368, 280);
            this.cartaTres.Margin = new System.Windows.Forms.Padding(4);
            this.cartaTres.Name = "cartaTres";
            this.cartaTres.Size = new System.Drawing.Size(110, 139);
            this.cartaTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaTres.TabIndex = 2;
            this.cartaTres.TabStop = false;
            // 
            // cartaDos
            // 
            this.cartaDos.Location = new System.Drawing.Point(314, 280);
            this.cartaDos.Margin = new System.Windows.Forms.Padding(4);
            this.cartaDos.Name = "cartaDos";
            this.cartaDos.Size = new System.Drawing.Size(95, 139);
            this.cartaDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaDos.TabIndex = 2;
            this.cartaDos.TabStop = false;
            // 
            // cartaCinco
            // 
            this.cartaCinco.Location = new System.Drawing.Point(544, 280);
            this.cartaCinco.Margin = new System.Windows.Forms.Padding(4);
            this.cartaCinco.Name = "cartaCinco";
            this.cartaCinco.Size = new System.Drawing.Size(91, 139);
            this.cartaCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaCinco.TabIndex = 3;
            this.cartaCinco.TabStop = false;
            this.cartaCinco.Click += new System.EventHandler(this.cartaCinco_Click);
            // 
            // cartaCuatro
            // 
            this.cartaCuatro.Location = new System.Drawing.Point(473, 280);
            this.cartaCuatro.Margin = new System.Windows.Forms.Padding(4);
            this.cartaCuatro.Name = "cartaCuatro";
            this.cartaCuatro.Size = new System.Drawing.Size(97, 139);
            this.cartaCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartaCuatro.TabIndex = 4;
            this.cartaCuatro.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(2, 89);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 57);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Juego Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.BackgroundImage = global::BlackJack.Properties.Resources.naipe;
            this.btnCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarta.Location = new System.Drawing.Point(314, 446);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(68, 67);
            this.btnCarta.TabIndex = 6;
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnRebajar
            // 
            this.btnRebajar.Location = new System.Drawing.Point(2, 152);
            this.btnRebajar.Name = "btnRebajar";
            this.btnRebajar.Size = new System.Drawing.Size(107, 57);
            this.btnRebajar.TabIndex = 7;
            this.btnRebajar.Text = "Rebarajar";
            this.btnRebajar.UseVisualStyleBackColor = true;
            this.btnRebajar.Click += new System.EventHandler(this.btnRebajar_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(262, 47);
            this.c1.Margin = new System.Windows.Forms.Padding(4);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(91, 139);
            this.c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c1.TabIndex = 8;
            this.c1.TabStop = false;
            // 
            // c5
            // 
            this.c5.Location = new System.Drawing.Point(527, 47);
            this.c5.Margin = new System.Windows.Forms.Padding(4);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(91, 139);
            this.c5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c5.TabIndex = 9;
            this.c5.TabStop = false;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(447, 47);
            this.c4.Margin = new System.Windows.Forms.Padding(4);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(91, 139);
            this.c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c4.TabIndex = 10;
            this.c4.TabStop = false;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(392, 47);
            this.c3.Margin = new System.Windows.Forms.Padding(4);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(91, 139);
            this.c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c3.TabIndex = 11;
            this.c3.TabStop = false;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(330, 47);
            this.c2.Margin = new System.Windows.Forms.Padding(4);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(91, 139);
            this.c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c2.TabIndex = 12;
            this.c2.TabStop = false;
            // 
            // btnQuedarse
            // 
            this.btnQuedarse.BackgroundImage = global::BlackJack.Properties.Resources.can_stock_photo_csp8697630;
            this.btnQuedarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuedarse.Location = new System.Drawing.Point(407, 451);
            this.btnQuedarse.Name = "btnQuedarse";
            this.btnQuedarse.Size = new System.Drawing.Size(107, 57);
            this.btnQuedarse.TabIndex = 13;
            this.btnQuedarse.UseVisualStyleBackColor = true;
            this.btnQuedarse.Click += new System.EventHandler(this.btnQuedarse_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(721, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ganadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Jugadas";
            // 
            // txtTotalJugadas
            // 
            this.txtTotalJugadas.Location = new System.Drawing.Point(799, 139);
            this.txtTotalJugadas.Name = "txtTotalJugadas";
            this.txtTotalJugadas.ReadOnly = true;
            this.txtTotalJugadas.Size = new System.Drawing.Size(100, 22);
            this.txtTotalJugadas.TabIndex = 17;
            // 
            // txtGanadas
            // 
            this.txtGanadas.Location = new System.Drawing.Point(799, 172);
            this.txtGanadas.Name = "txtGanadas";
            this.txtGanadas.ReadOnly = true;
            this.txtGanadas.Size = new System.Drawing.Size(100, 22);
            this.txtGanadas.TabIndex = 18;
            // 
            // fotoPerfil
            // 
            this.fotoPerfil.Location = new System.Drawing.Point(799, 68);
            this.fotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPerfil.Name = "fotoPerfil";
            this.fotoPerfil.Size = new System.Drawing.Size(72, 64);
            this.fotoPerfil.TabIndex = 19;
            this.fotoPerfil.TabStop = false;
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources._1_split33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 530);
            this.Controls.Add(this.fotoPerfil);
            this.Controls.Add(this.txtGanadas);
            this.Controls.Add(this.txtTotalJugadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnQuedarse);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c1);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJuego_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.CartaUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCinco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox c1;
        private System.Windows.Forms.PictureBox c5;
        private System.Windows.Forms.PictureBox c4;
        private System.Windows.Forms.PictureBox c3;
        private System.Windows.Forms.PictureBox c2;
        private System.Windows.Forms.Button btnQuedarse;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalJugadas;
        private System.Windows.Forms.TextBox txtGanadas;
        private System.Windows.Forms.PictureBox fotoPerfil;
    }
}