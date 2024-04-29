namespace PIM_III.View
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
            pictureBox2 = new PictureBox();
            lblNome = new Label();
            txbNome = new TextBox();
            lblIdade = new Label();
            txbEmail = new TextBox();
            lblEnail = new Label();
            txbIdade = new TextBox();
            lblCep = new Label();
            LblVendaDeIngressos = new Label();
            txbCep = new TextBox();
            gpbCadastro = new GroupBox();
            btnComprar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gpbCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.ButtonFace;
            BtnCancelar.Location = new Point(1207, 784);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(95, 43);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(773, 853);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(31, 125);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 15);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            txbNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbNome.Location = new Point(31, 143);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(382, 23);
            txbNome.TabIndex = 0;
            // 
            // lblIdade
            // 
            lblIdade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblIdade.AutoSize = true;
            lblIdade.BackColor = Color.Transparent;
            lblIdade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.ControlLightLight;
            lblIdade.Location = new Point(31, 297);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(38, 15);
            lblIdade.TabIndex = 16;
            lblIdade.Text = "Idade";
            // 
            // txbEmail
            // 
            txbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbEmail.Location = new Point(31, 229);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(382, 23);
            txbEmail.TabIndex = 1;
            // 
            // lblEnail
            // 
            lblEnail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEnail.AutoSize = true;
            lblEnail.BackColor = Color.Transparent;
            lblEnail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnail.ForeColor = SystemColors.ControlLightLight;
            lblEnail.Location = new Point(31, 211);
            lblEnail.Name = "lblEnail";
            lblEnail.Size = new Size(41, 15);
            lblEnail.TabIndex = 19;
            lblEnail.Text = "E-mail";
            // 
            // txbIdade
            // 
            txbIdade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbIdade.Location = new Point(31, 315);
            txbIdade.Name = "txbIdade";
            txbIdade.Size = new Size(100, 23);
            txbIdade.TabIndex = 2;
            // 
            // lblCep
            // 
            lblCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.ForeColor = SystemColors.ControlLightLight;
            lblCep.Location = new Point(313, 297);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(27, 15);
            lblCep.TabIndex = 20;
            lblCep.Text = "CEP";
            // 
            // LblVendaDeIngressos
            // 
            LblVendaDeIngressos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LblVendaDeIngressos.AutoSize = true;
            LblVendaDeIngressos.BackColor = Color.Transparent;
            LblVendaDeIngressos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblVendaDeIngressos.ForeColor = SystemColors.ControlLightLight;
            LblVendaDeIngressos.Location = new Point(152, 56);
            LblVendaDeIngressos.Name = "LblVendaDeIngressos";
            LblVendaDeIngressos.Size = new Size(115, 25);
            LblVendaDeIngressos.TabIndex = 23;
            LblVendaDeIngressos.Text = "Cadastre-se";
            // 
            // txbCep
            // 
            txbCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txbCep.Location = new Point(313, 315);
            txbCep.Name = "txbCep";
            txbCep.Size = new Size(100, 23);
            txbCep.TabIndex = 3;
            // 
            // gpbCadastro
            // 
            gpbCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gpbCadastro.Controls.Add(btnComprar);
            gpbCadastro.Controls.Add(txbCep);
            gpbCadastro.Controls.Add(LblVendaDeIngressos);
            gpbCadastro.Controls.Add(lblCep);
            gpbCadastro.Controls.Add(txbIdade);
            gpbCadastro.Controls.Add(lblEnail);
            gpbCadastro.Controls.Add(txbEmail);
            gpbCadastro.Controls.Add(lblIdade);
            gpbCadastro.Controls.Add(txbNome);
            gpbCadastro.Controls.Add(lblNome);
            gpbCadastro.Location = new Point(840, 137);
            gpbCadastro.Name = "gpbCadastro";
            gpbCadastro.Size = new Size(435, 481);
            gpbCadastro.TabIndex = 25;
            gpbCadastro.TabStop = false;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Right;
            btnComprar.BackColor = Color.Black;
            btnComprar.BackgroundImageLayout = ImageLayout.Zoom;
            btnComprar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = SystemColors.ButtonFace;
            btnComprar.Location = new Point(141, 394);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(160, 57);
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
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1341, 851);
            Controls.Add(gpbCadastro);
            Controls.Add(pictureBox2);
            Controls.Add(BtnCancelar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadastroVisitante";
            Text = "CadastroVisitante";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gpbCadastro.ResumeLayout(false);
            gpbCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnCancelar;
        private PictureBox pictureBox2;
        private Label lblNome;
        private TextBox txbNome;
        private Label lblIdade;
        private TextBox txbEmail;
        private Label lblEnail;
        private TextBox txbIdade;
        private Label lblCep;
        private Label LblVendaDeIngressos;
        private TextBox txbCep;
        private GroupBox gpbCadastro;
        private Button btnComprar;
    }
}