using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSS.Interfaces;
using INSS.Entidades;
using INSS.Extensions;
using System.Windows.Forms;

namespace INSS.FormsApp
{
    public partial class FormINSS : Form
    {
        public FormINSS()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!VerificaCamposPreenchidos())
            {
                MessageBox.Show("Preencha os campos de Salário Bruto ou Selecione a tabela do INSS!", "Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var salario = txtSalarioBruto.Text.Replace(".", ",").ConvertStringToDecimal();
                var data = new DateTime(cbAno.SelectedItem.ConvertObjectToInt(), 1, 1);

                var resultado = new CalculoINSS().CalcularDesconto(data, salario);
                if (resultado.Equals(0))
                {
                    MessageBox.Show($"A tabela do INSS do ano {data.Year} não existe. Entre em contato com suporte.", "Aviso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lblResultado.Text = $"R$ {resultado}";
            }
        }

        private bool VerificaCamposPreenchidos()
        {
            if (cbAno.SelectedItem == null || string.IsNullOrEmpty(txtSalarioBruto.Text) || txtSalarioBruto.Text.Equals("0"))
                return false;

            return true;
        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSalarioBruto.Text, "[^0-9].[^0-9]"))
            {
                MessageBox.Show("O campo Salário Bruto só aceita números.", "Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtSalarioBruto.Text = txtSalarioBruto.Text.Remove(txtSalarioBruto.Text.Length - 1);
            }
        }
    }
}
