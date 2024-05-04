namespace PIM_III_ADS_VENDAS.View
{
    partial class LoginCompra
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
            btnCadastrarSe = new Button();
            btnComprar = new Button();
            lblEnail = new Label();
            txbEmail = new TextBox();
            txbNome = new TextBox();
            lblNome = new Label();
            SuspendLayout();
            // 
            // btnCadastrarSe
            // 
            btnCadastrarSe.Anchor = AnchorStyles.Right;
            btnCadastrarSe.BackColor = Color.White;
            btnCadastrarSe.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrarSe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarSe.ForeColor = Color.Black;
            btnCadastrarSe.Location = new Point(1269, 547);
            btnCadastrarSe.Name = "btnCadastrarSe";
            btnCadastrarSe.Size = new Size(139, 38);
            btnCadastrarSe.TabIndex = 25;
            btnCadastrarSe.Text = "Cadastrar-se";
            btnCadastrarSe.UseVisualStyleBackColor = false;
            btnCadastrarSe.Click += btnCadastrarSe_Click;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Right;
            btnComprar.BackColor = Color.White;
            btnComprar.BackgroundImageLayout = ImageLayout.Zoom;
            btnComprar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Location = new Point(1512, 547);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(139, 38);
            btnComprar.TabIndex = 24;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblEnail
            // 
            lblEnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEnail.AutoSize = true;
            lblEnail.BackColor = Color.Transparent;
            lblEnail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnail.ForeColor = SystemColors.ControlLightLight;
            lblEnail.Location = new Point(1269, 337);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(41, 15);
            lblEnail.TabIndex = 19;
            lblEnail.Text = "E-mail";
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbEmail.Location = new Point(1269, 355);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(382, 23);
            txbEmail.TabIndex = 1;
            txbEmail.Click += TextBox1_Click;
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbNome.Location = new Point(1269, 289);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(382, 23);
            txbNome.TabIndex = 0;
            txbNome.Click += TextBox1_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(1269, 251);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 15);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome ";
            // 
            // LoginCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.telaLoginmain;
            ClientSize = new Size(1920, 1100);
            Controls.Add(btnCadastrarSe);
            Controls.Add(lblEnail);
            Controls.Add(btnComprar);
            Controls.Add(txbEmail);
            Controls.Add(txbNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginCompra";
            Text = "LoginCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEnail;
        private TextBox txbEmail;
        private TextBox txbNome;
        private Label lblNome;
        private Button btnComprar;
        private Button btnCadastrarSe;
    }
}