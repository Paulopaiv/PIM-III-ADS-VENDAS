namespace PIM_III_ADS_VENDAS.View
{
    partial class CadastroVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVisitante));
            BtnCancelar = new Button();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            txbIdade = new TextBox();
            txbCep = new TextBox();
            btnComprar = new Button();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.BackColor = Color.White;
            BtnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.Black;
            BtnCancelar.Location = new Point(1140, 822);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(246, 57);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbNome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbNome.Location = new Point(1140, 440);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(556, 35);
            txbNome.TabIndex = 0;
            txbNome.Click += TextBox1_Click;
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbEmail.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbEmail.Location = new Point(1140, 594);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(556, 35);
            txbEmail.TabIndex = 1;
            txbEmail.Click += TextBox1_Click;
            // 
            // txbIdade
            // 
            txbIdade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbIdade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbIdade.Location = new Point(1140, 748);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(100, 35);
            txbIdade.TabIndex = 2;
            txbIdade.Click += TextBox1_Click;
            // 
            // txbCep
            // 
            txbCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbCep.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txbCep.Location = new Point(1536, 748);
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(151, 35);
            txbCep.TabIndex = 3;
            txbCep.Click += TextBox1_Click;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComprar.BackColor = Color.White;
            btnComprar.BackgroundImageLayout = ImageLayout.Zoom;
            btnComprar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Location = new Point(1467, 822);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(229, 57);
            btnComprar.TabIndex = 25;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // CadastroVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1061);
            Controls.Add(btnComprar);
            Controls.Add(txbCep);
            Controls.Add(BtnCancelar);
            Controls.Add(txbEmail);
            Controls.Add(txbIdade);
            Controls.Add(txbNome);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroVisitante";
            Text = "CadastroVisitante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnCancelar;
        private TextBox txbNome;
        private TextBox txbEmail;
        private TextBox txbIdade;
        private TextBox txbCep;
        private Button btnComprar;
    }
}