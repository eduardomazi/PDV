namespace SisPadoca
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            LblNCM = new Label();
            TxbNCM = new TextBox();
            BtnNovo = new Button();
            ImgLista = new ImageList(components);
            CmbUnidade = new ComboBox();
            PbxImagem = new PictureBox();
            TxbDescricao = new TextBox();
            LblDescricao = new Label();
            TxbBarcode = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            LblLote = new Label();
            TxbLote = new TextBox();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(187, 45);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(35, 15);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            // 
            // TxbNCM
            // 
            TxbNCM.Location = new Point(187, 63);
            TxbNCM.Name = "TxbNCM";
            TxbNCM.Size = new Size(105, 23);
            TxbNCM.TabIndex = 1;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(40, 222);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(91, 51);
            BtnNovo.TabIndex = 2;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // CmbUnidade
            // 
            CmbUnidade.FormattingEnabled = true;
            CmbUnidade.Items.AddRange(new object[] { "unitário", "kilo", "dúzia" });
            CmbUnidade.Location = new Point(431, 118);
            CmbUnidade.Name = "CmbUnidade";
            CmbUnidade.Size = new Size(121, 23);
            CmbUnidade.TabIndex = 3;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = (Image)resources.GetObject("PbxImagem.Image");
            PbxImagem.Location = new Point(40, 45);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(128, 151);
            PbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagem.TabIndex = 4;
            PbxImagem.TabStop = false;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(187, 118);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(225, 23);
            TxbDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(187, 100);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // TxbBarcode
            // 
            TxbBarcode.Location = new Point(187, 173);
            TxbBarcode.Name = "TxbBarcode";
            TxbBarcode.Size = new Size(225, 23);
            TxbBarcode.TabIndex = 8;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(187, 155);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(97, 15);
            LblCodigoBarras.TabIndex = 7;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(431, 100);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(94, 15);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Unidade medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(431, 155);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(30, 15);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // TxbLote
            // 
            TxbLote.Location = new Point(431, 173);
            TxbLote.Name = "TxbLote";
            TxbLote.Size = new Size(121, 23);
            TxbLote.TabIndex = 11;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(150, 222);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(91, 51);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(256, 222);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(91, 51);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(364, 222);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(91, 51);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(461, 222);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(91, 51);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 314);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TxbLote);
            Controls.Add(LblLote);
            Controls.Add(LblUnidade);
            Controls.Add(TxbBarcode);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(PbxImagem);
            Controls.Add(CmbUnidade);
            Controls.Add(BtnNovo);
            Controls.Add(TxbNCM);
            Controls.Add(LblNCM);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private TextBox TxbNCM;
        private Button BtnNovo;
        private ImageList ImgLista;
        private ComboBox CmbUnidade;
        private PictureBox PbxImagem;
        private TextBox TxbDescricao;
        private Label LblDescricao;
        private TextBox TxbBarcode;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private Label LblLote;
        private TextBox TxbLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
    }
}