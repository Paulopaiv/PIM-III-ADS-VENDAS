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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCompra));
            pictureBox2 = new PictureBox();
            gpbCadastro = new GroupBox();
            btnCadastrarSe = new Button();
            btnComprar = new Button();
            LblVendaDeIngressos = new Label();
            BtnRegistrar = new Button();
            lblEnail = new Label();
            txbEmail = new TextBox();
            txbNome = new TextBox();
            lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gpbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(773, 815);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // gpbCadastro
            // 
            gpbCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gpbCadastro.Controls.Add(btnCadastrarSe);
            gpbCadastro.Controls.Add(btnComprar);
            gpbCadastro.Controls.Add(LblVendaDeIngressos);
            gpbCadastro.Controls.Add(BtnRegistrar);
            gpbCadastro.Controls.Add(lblEnail);
            gpbCadastro.Controls.Add(txbEmail);
            gpbCadastro.Controls.Add(txbNome);
            gpbCadastro.Controls.Add(lblNome);
            gpbCadastro.Location = new Point(824, 182);
            gpbCadastro.Name = "gpbCadastro";
            gpbCadastro.Size = new Size(443, 417);
            gpbCadastro.TabIndex = 26;
            gpbCadastro.TabStop = false;
            // 
            // btnCadastrarSe
            // 
            btnCadastrarSe.Anchor = AnchorStyles.Right;
            btnCadastrarSe.BackColor = Color.Black;
            btnCadastrarSe.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrarSe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarSe.ForeColor = SystemColors.ButtonFace;
            btnCadastrarSe.Location = new Point(248, 312);
            btnCadastrarSe.Name = "btnCadastrarSe";
            btnCadastrarSe.Size = new Size(160, 57);
            btnCadastrarSe.TabIndex = 25;
            btnCadastrarSe.Text = "Cadastrar-se";
            btnCadastrarSe.UseVisualStyleBackColor = false;
            btnCadastrarSe.Click += btnCadastrarSe_Click;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Right;
            btnComprar.BackColor = Color.Black;
            btnComprar.BackgroundImageLayout = ImageLayout.Zoom;
            btnComprar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = SystemColors.ButtonFace;
            btnComprar.Location = new Point(26, 312);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(160, 57);
            btnComprar.TabIndex = 24;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // LblVendaDeIngressos
            // 
            LblVendaDeIngressos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LblVendaDeIngressos.AutoSize = true;
            LblVendaDeIngressos.BackColor = Color.Transparent;
            LblVendaDeIngressos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblVendaDeIngressos.ForeColor = SystemColors.ControlLightLight;
            LblVendaDeIngressos.Location = new Point(186, 60);
            LblVendaDeIngressos.Name = "LblVendaDeIngressos";
            LblVendaDeIngressos.Size = new Size(63, 25);
            LblVendaDeIngressos.TabIndex = 23;
            LblVendaDeIngressos.Text = "Login";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Anchor = AnchorStyles.Right;
            BtnRegistrar.BackColor = Color.Black;
            BtnRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRegistrar.ForeColor = SystemColors.ButtonFace;
            BtnRegistrar.Location = new Point(385, 587);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(160, 57);
            BtnRegistrar.TabIndex = 5;
            BtnRegistrar.Text = "Registrar-se";
            BtnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblEnail
            // 
            lblEnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEnail.AutoSize = true;
            lblEnail.BackColor = Color.Transparent;
            lblEnail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnail.ForeColor = SystemColors.ControlLightLight;
            lblEnail.Location = new Point(26, 215);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(41, 15);
            lblEnail.TabIndex = 19;
            lblEnail.Text = "E-mail";
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbEmail.Location = new Point(26, 233);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(382, 23);
            txbEmail.TabIndex = 1;
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbNome.Location = new Point(26, 147);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(382, 23);
            txbNome.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(26, 129);
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
            ClientSize = new Size(1304, 812);
            Controls.Add(gpbCadastro);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginCompra";
            Text = "LoginCompra";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gpbCadastro.ResumeLayout(false);
            gpbCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private GroupBox gpbCadastro;
        private Button BtnRegistrar;
        private Label lblEnail;
        private TextBox txbEmail;
        private TextBox txbNome;
        private Label lblNome;
        private Label LblVendaDeIngressos;
        private Button btnComprar;
        private Button btnCadastrarSe;
    }
}