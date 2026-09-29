using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisPadoca
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            foreach (Control controles in this.Controls)
            {
                if (controles is TextBox or MaskedTextBox
                    or ComboBox or DateTimePicker)
                {
                    controles.Enabled = false;
                }
                BtnEditar.Enabled = false;

            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox or ComboBox
                    or DateTimePicker or MaskedTextBox)
                {
                    ctrl.Enabled = true;
                }
            }
            MtbCPF.Focus();
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = true;
            BtnCancelar.Text = "Salvar";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // teste
        }
    }
}
