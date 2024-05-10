namespace PIM_III_ADS_VENDAS.View
{
    partial class TelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            btnMapa = new Button();
            btnCompra = new Button();
            SuspendLayout();
            // 
            // btnMapa
            // 
            btnMapa.BackColor = Color.White;
            btnMapa.BackgroundImageLayout = ImageLayout.None;
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnMapa.Image = (Image)resources.GetObject("btnMapa.Image");
            btnMapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnMapa.Location = new Point(93, 830);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(847, 124);
            btnMapa.TabIndex = 0;
            btnMapa.Text = "Mapa";
            btnMapa.UseVisualStyleBackColor = false;
            btnMapa.Click += btnMapa_Click;
            // 
            // btnCompra
            // 
            btnCompra.BackColor = Color.White;
            btnCompra.BackgroundImageLayout = ImageLayout.None;
            btnCompra.Cursor = Cursors.Hand;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompra.Image = (Image)resources.GetObject("btnCompra.Image");
            btnCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompra.Location = new Point(1052, 830);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(847, 124);
            btnCompra.TabIndex = 1;
            btnCompra.Text = "Comprar";
            btnCompra.UseVisualStyleBackColor = false;
            btnCompra.Click += btnCompra_Click;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1920, 1100);
            Controls.Add(btnCompra);
            Controls.Add(btnMapa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaMenu";
            Text = "TelaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMapa;
        private Button btnCompra;
    }
}