﻿namespace PIM_III_ADS_VENDAS.View
{
    partial class Pagamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            BtnCredito = new Button();
            imageList1 = new ImageList(components);
            BtnCancelar = new Button();
            BtnPix = new Button();
            BtnDebito = new Button();
            ptbQrCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbQrCode).BeginInit();
            SuspendLayout();
            // 
            // BtnCredito
            // 
            BtnCredito.BackColor = Color.White;
            BtnCredito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCredito.ForeColor = Color.Black;
            BtnCredito.Image = Properties.Resources.Payment;
            BtnCredito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCredito.Location = new Point(99, 18);
            BtnCredito.Name = "BtnCredito";
            BtnCredito.Size = new Size(160, 57);
            BtnCredito.TabIndex = 0;
            BtnCredito.Text = "Credito";
            BtnCredito.UseVisualStyleBackColor = false;
            BtnCredito.Click += BtnCredito_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "3925421-card-credit-payment-icon_111553.png");
            imageList1.Images.SetKeyName(1, "1495815224-jd15_84582.png");
            imageList1.Images.SetKeyName(2, "images-removebg-preview.png");
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.White;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(99, 247);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(160, 57);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnPix
            // 
            BtnPix.BackColor = Color.White;
            BtnPix.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPix.ForeColor = Color.Black;
            BtnPix.Image = Properties.Resources.Pix;
            BtnPix.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPix.Location = new Point(99, 150);
            BtnPix.Name = "BtnPix";
            BtnPix.Size = new Size(160, 57);
            BtnPix.TabIndex = 2;
            BtnPix.Text = "Pix";
            BtnPix.UseVisualStyleBackColor = false;
            BtnPix.Click += BtnPix_Click;
            // 
            // BtnDebito
            // 
            BtnDebito.BackColor = Color.White;
            BtnDebito.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDebito.ForeColor = Color.Black;
            BtnDebito.Image = Properties.Resources.Payment1;
            BtnDebito.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDebito.Location = new Point(99, 84);
            BtnDebito.Name = "BtnDebito";
            BtnDebito.Size = new Size(160, 57);
            BtnDebito.TabIndex = 1;
            BtnDebito.Text = "Debito";
            BtnDebito.UseVisualStyleBackColor = false;
            BtnDebito.Click += BtnDebito_Click;
            // 
            // ptbQrCode
            // 
            ptbQrCode.BackColor = Color.Transparent;
            ptbQrCode.Location = new Point(12, 347);
            ptbQrCode.Name = "ptbQrCode";
            ptbQrCode.Size = new Size(334, 193);
            ptbQrCode.SizeMode = PictureBoxSizeMode.Zoom;
            ptbQrCode.TabIndex = 4;
            ptbQrCode.TabStop = false;
            // 
            // Pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 235, 253);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(358, 552);
            Controls.Add(ptbQrCode);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnPix);
            Controls.Add(BtnDebito);
            Controls.Add(BtnCredito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pagamento";
            Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)ptbQrCode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCredito;
        private Button BtnCancelar;
        private Button BtnPix;
        private Button BtnDebito;
        private ImageList imageList1;
        private PictureBox ptbQrCode;
    }
}