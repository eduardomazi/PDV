namespace SisPadoca
{
    partial class FrmClientes
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
            BtnFechar = new Button();
            BtnCancelar = new Button();
            BtnExcluir = new Button();
            BtnNovo = new Button();
            TxbNome = new TextBox();
            lblObservacoes = new Label();
            TxbObservacoes = new TextBox();
            LblEmail = new Label();
            MtbCelular = new MaskedTextBox();
            LblCelular = new Label();
            LblEstado = new Label();
            lblCidade = new Label();
            MtbCEP = new MaskedTextBox();
            CmbEstado = new ComboBox();
            TxbBairro = new TextBox();
            TxbEndereco = new TextBox();
            DtpDataNasc = new DateTimePicker();
            CmbSexo = new ComboBox();
            TxbEmail = new TextBox();
            LblBairro = new Label();
            LblEndereco = new Label();
            LblCEP = new Label();
            LblDataNasc = new Label();
            LblSexo = new Label();
            LblNome = new Label();
            MtbCPF = new MaskedTextBox();
            LblCPF = new Label();
            BtnEditar = new Button();
            TxbCidade = new TextBox();
            SuspendLayout();
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new Font("Tahoma", 12F);
            BtnFechar.Location = new Point(874, 690);
            BtnFechar.Margin = new Padding(4, 5, 4, 5);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(143, 83);
            BtnFechar.TabIndex = 76;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new Font("Tahoma", 12F);
            BtnCancelar.Location = new Point(714, 690);
            BtnCancelar.Margin = new Padding(4, 5, 4, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(143, 83);
            BtnCancelar.TabIndex = 75;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new Font("Tahoma", 12F);
            BtnExcluir.Location = new Point(396, 690);
            BtnExcluir.Margin = new Padding(4, 5, 4, 5);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(143, 83);
            BtnExcluir.TabIndex = 74;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.Font = new Font("Tahoma", 12F);
            BtnNovo.Location = new Point(64, 690);
            BtnNovo.Margin = new Padding(4, 5, 4, 5);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(143, 83);
            BtnNovo.TabIndex = 72;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // TxbNome
            // 
            TxbNome.Font = new Font("Tahoma", 12F);
            TxbNome.Location = new Point(309, 138);
            TxbNome.Margin = new Padding(4, 5, 4, 5);
            TxbNome.Name = "TxbNome";
            TxbNome.Size = new Size(551, 36);
            TxbNome.TabIndex = 71;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Font = new Font("Tahoma", 12F);
            lblObservacoes.Location = new Point(427, 510);
            lblObservacoes.Margin = new Padding(4, 0, 4, 0);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(149, 29);
            lblObservacoes.TabIndex = 81;
            lblObservacoes.Text = "Observações";
            // 
            // TxbObservacoes
            // 
            TxbObservacoes.Font = new Font("Tahoma", 12F);
            TxbObservacoes.Location = new Point(427, 562);
            TxbObservacoes.Margin = new Padding(4, 5, 4, 5);
            TxbObservacoes.Name = "TxbObservacoes";
            TxbObservacoes.Size = new Size(593, 36);
            TxbObservacoes.TabIndex = 70;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Tahoma", 12F);
            LblEmail.Location = new Point(537, 237);
            LblEmail.Margin = new Padding(4, 0, 4, 0);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(78, 29);
            LblEmail.TabIndex = 80;
            LblEmail.Text = "E-mail";
            // 
            // MtbCelular
            // 
            MtbCelular.Font = new Font("Tahoma", 12F);
            MtbCelular.Location = new Point(309, 283);
            MtbCelular.Margin = new Padding(4, 5, 4, 5);
            MtbCelular.Mask = "(99) 00000-0000";
            MtbCelular.Name = "MtbCelular";
            MtbCelular.Size = new Size(204, 36);
            MtbCelular.TabIndex = 69;
            // 
            // LblCelular
            // 
            LblCelular.AutoSize = true;
            LblCelular.Font = new Font("Tahoma", 12F);
            LblCelular.Location = new Point(309, 237);
            LblCelular.Margin = new Padding(4, 0, 4, 0);
            LblCelular.Name = "LblCelular";
            LblCelular.Size = new Size(85, 29);
            LblCelular.TabIndex = 79;
            LblCelular.Text = "Celular";
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Font = new Font("Tahoma", 12F);
            LblEstado.Location = new Point(311, 510);
            LblEstado.Margin = new Padding(4, 0, 4, 0);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(84, 29);
            LblEstado.TabIndex = 78;
            LblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Tahoma", 12F);
            lblCidade.Location = new Point(69, 510);
            lblCidade.Margin = new Padding(4, 0, 4, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(84, 29);
            lblCidade.TabIndex = 77;
            lblCidade.Text = "Cidade";
            // 
            // MtbCEP
            // 
            MtbCEP.Font = new Font("Tahoma", 12F);
            MtbCEP.Location = new Point(69, 418);
            MtbCEP.Margin = new Padding(4, 5, 4, 5);
            MtbCEP.Mask = "00,000-99";
            MtbCEP.Name = "MtbCEP";
            MtbCEP.Size = new Size(210, 36);
            MtbCEP.TabIndex = 61;
            // 
            // CmbEstado
            // 
            CmbEstado.Font = new Font("Tahoma", 12F);
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(309, 562);
            CmbEstado.Margin = new Padding(4, 5, 4, 5);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(90, 37);
            CmbEstado.TabIndex = 68;
            // 
            // TxbBairro
            // 
            TxbBairro.Font = new Font("Tahoma", 12F);
            TxbBairro.Location = new Point(789, 418);
            TxbBairro.Margin = new Padding(4, 5, 4, 5);
            TxbBairro.Name = "TxbBairro";
            TxbBairro.Size = new Size(231, 36);
            TxbBairro.TabIndex = 64;
            // 
            // TxbEndereco
            // 
            TxbEndereco.Font = new Font("Tahoma", 12F);
            TxbEndereco.Location = new Point(309, 418);
            TxbEndereco.Margin = new Padding(4, 5, 4, 5);
            TxbEndereco.Name = "TxbEndereco";
            TxbEndereco.Size = new Size(447, 36);
            TxbEndereco.TabIndex = 62;
            // 
            // DtpDataNasc
            // 
            DtpDataNasc.Font = new Font("Tahoma", 12F);
            DtpDataNasc.Format = DateTimePickerFormat.Short;
            DtpDataNasc.Location = new Point(69, 283);
            DtpDataNasc.Margin = new Padding(4, 5, 4, 5);
            DtpDataNasc.Name = "DtpDataNasc";
            DtpDataNasc.Size = new Size(210, 36);
            DtpDataNasc.TabIndex = 59;
            DtpDataNasc.Value = new DateTime(2026, 9, 15, 20, 30, 46, 0);
            // 
            // CmbSexo
            // 
            CmbSexo.Font = new Font("Tahoma", 12F);
            CmbSexo.FormattingEnabled = true;
            CmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            CmbSexo.Location = new Point(879, 138);
            CmbSexo.Margin = new Padding(4, 5, 4, 5);
            CmbSexo.Name = "CmbSexo";
            CmbSexo.Size = new Size(141, 37);
            CmbSexo.TabIndex = 57;
            // 
            // TxbEmail
            // 
            TxbEmail.Font = new Font("Tahoma", 12F);
            TxbEmail.Location = new Point(537, 283);
            TxbEmail.Margin = new Padding(4, 5, 4, 5);
            TxbEmail.Name = "TxbEmail";
            TxbEmail.Size = new Size(483, 36);
            TxbEmail.TabIndex = 55;
            // 
            // LblBairro
            // 
            LblBairro.AutoSize = true;
            LblBairro.Font = new Font("Tahoma", 12F);
            LblBairro.Location = new Point(789, 373);
            LblBairro.Margin = new Padding(4, 0, 4, 0);
            LblBairro.Name = "LblBairro";
            LblBairro.Size = new Size(76, 29);
            LblBairro.TabIndex = 67;
            LblBairro.Text = "Bairro";
            // 
            // LblEndereco
            // 
            LblEndereco.AutoSize = true;
            LblEndereco.Font = new Font("Tahoma", 12F);
            LblEndereco.Location = new Point(309, 373);
            LblEndereco.Margin = new Padding(4, 0, 4, 0);
            LblEndereco.Name = "LblEndereco";
            LblEndereco.Size = new Size(111, 29);
            LblEndereco.TabIndex = 65;
            LblEndereco.Text = "Endereço";
            // 
            // LblCEP
            // 
            LblCEP.AutoSize = true;
            LblCEP.Font = new Font("Tahoma", 12F);
            LblCEP.Location = new Point(69, 373);
            LblCEP.Margin = new Padding(4, 0, 4, 0);
            LblCEP.Name = "LblCEP";
            LblCEP.Size = new Size(53, 29);
            LblCEP.TabIndex = 63;
            LblCEP.Text = "CEP";
            // 
            // LblDataNasc
            // 
            LblDataNasc.AutoSize = true;
            LblDataNasc.Font = new Font("Tahoma", 12F);
            LblDataNasc.Location = new Point(69, 237);
            LblDataNasc.Margin = new Padding(4, 0, 4, 0);
            LblDataNasc.Name = "LblDataNasc";
            LblDataNasc.Size = new Size(225, 29);
            LblDataNasc.TabIndex = 60;
            LblDataNasc.Text = "Data de nascimento";
            // 
            // LblSexo
            // 
            LblSexo.AutoSize = true;
            LblSexo.Font = new Font("Tahoma", 12F);
            LblSexo.Location = new Point(879, 87);
            LblSexo.Margin = new Padding(4, 0, 4, 0);
            LblSexo.Name = "LblSexo";
            LblSexo.Size = new Size(64, 29);
            LblSexo.TabIndex = 58;
            LblSexo.Text = "Sexo";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Tahoma", 12F);
            LblNome.Location = new Point(274, 87);
            LblNome.Margin = new Padding(4, 0, 4, 0);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(75, 29);
            LblNome.TabIndex = 56;
            LblNome.Text = "Nome";
            // 
            // MtbCPF
            // 
            MtbCPF.Font = new Font("Tahoma", 12F);
            MtbCPF.Location = new Point(69, 138);
            MtbCPF.Margin = new Padding(4, 5, 4, 5);
            MtbCPF.Mask = "###,###,###-##";
            MtbCPF.Name = "MtbCPF";
            MtbCPF.Size = new Size(210, 36);
            MtbCPF.TabIndex = 54;
            // 
            // LblCPF
            // 
            LblCPF.AutoSize = true;
            LblCPF.Font = new Font("Tahoma", 12F);
            LblCPF.Location = new Point(69, 87);
            LblCPF.Margin = new Padding(4, 0, 4, 0);
            LblCPF.Name = "LblCPF";
            LblCPF.Size = new Size(53, 29);
            LblCPF.TabIndex = 53;
            LblCPF.Text = "CPF";
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new Font("Tahoma", 12F);
            BtnEditar.Location = new Point(229, 690);
            BtnEditar.Margin = new Padding(4, 5, 4, 5);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(143, 83);
            BtnEditar.TabIndex = 73;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // TxbCidade
            // 
            TxbCidade.Font = new Font("Tahoma", 12F);
            TxbCidade.Location = new Point(69, 562);
            TxbCidade.Margin = new Padding(4, 5, 4, 5);
            TxbCidade.Name = "TxbCidade";
            TxbCidade.Size = new Size(210, 36);
            TxbCidade.TabIndex = 66;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(974, 524);
            Controls.Add(BtnFechar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnNovo);
            Controls.Add(TxbNome);
            Controls.Add(lblObservacoes);
            Controls.Add(TxbObservacoes);
            Controls.Add(LblEmail);
            Controls.Add(MtbCelular);
            Controls.Add(LblCelular);
            Controls.Add(LblEstado);
            Controls.Add(lblCidade);
            Controls.Add(MtbCEP);
            Controls.Add(CmbEstado);
            Controls.Add(TxbBairro);
            Controls.Add(TxbEndereco);
            Controls.Add(DtpDataNasc);
            Controls.Add(CmbSexo);
            Controls.Add(TxbEmail);
            Controls.Add(LblBairro);
            Controls.Add(LblEndereco);
            Controls.Add(LblCEP);
            Controls.Add(LblDataNasc);
            Controls.Add(LblSexo);
            Controls.Add(LblNome);
            Controls.Add(MtbCPF);
            Controls.Add(LblCPF);
            Controls.Add(BtnEditar);
            Controls.Add(TxbCidade);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += FrmClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnFechar;
        private Button BtnCancelar;
        private Button BtnExcluir;
        private Button BtnNovo;
        private TextBox TxbNome;
        private Label lblObservacoes;
        private TextBox TxbObservacoes;
        private Label LblEmail;
        private MaskedTextBox MtbCelular;
        private Label LblCelular;
        private Label LblEstado;
        private Label lblCidade;
        private MaskedTextBox MtbCEP;
        private ComboBox CmbEstado;
        private TextBox TxbBairro;
        private TextBox TxbEndereco;
        private DateTimePicker DtpDataNasc;
        private ComboBox CmbSexo;
        private TextBox TxbEmail;
        private Label LblBairro;
        private Label LblEndereco;
        private Label LblCEP;
        private Label LblDataNasc;
        private Label LblSexo;
        private Label LblNome;
        private MaskedTextBox MtbCPF;
        private Label LblCPF;
        private Button BtnEditar;
        private TextBox TxbCidade;
    }
}