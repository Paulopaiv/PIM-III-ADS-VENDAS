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
            btnMapa.BackColor = Color.Transparent;
            btnMapa.BackgroundImageLayout = ImageLayout.None;
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMapa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnMapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnMapa.Location = new Point(93, 873);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(874, 140);
            btnMapa.TabIndex = 0;
            btnMapa.Text = " ";
            btnMapa.UseVisualStyleBackColor = false;
            btnMapa.Click += btnMapa_Click;
            // 
            // btnCompra
            // 
            btnCompra.BackColor = Color.Transparent;
            btnCompra.BackgroundImageLayout = ImageLayout.None;
            btnCompra.Cursor = Cursors.Hand;
            btnCompra.FlatAppearance.BorderSize = 0;
            btnCompra.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCompra.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompra.Location = new Point(1007, 873);
            btnCompra.Name = "btnCompra";
            btnCompra.Size = new Size(839, 140);
            btnCompra.TabIndex = 1;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMapa;
        private Button btnCompra;
    }
}