using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class CadastrarClientes : UserControl
    {
        public CadastrarClientes()
        {
            InitializeComponent();
        }

        private void CadastrarOperadora_Load(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            //Preenche CPF
            if (txtCNPJ.Text.Length == 11)
            {
                //Seprara os campos de acordo com a posição dos caracteres
                string cpf2Digitos = txtCNPJ.Text.Substring(0, 3);
                string cpf3Digitos = txtCNPJ.Text.Substring(3, 3);
                string cpf3Digitos2 = txtCNPJ.Text.Substring(6, 3);
                string cpf2Digitos2 = txtCNPJ.Text.Substring(9, 2);
                //limpa os campos de textos
                txtCNPJ.Text = "";
                //preenche novamente com os campos certos
                txtCNPJ.Text = cpf2Digitos + "." + cpf3Digitos + "." + cpf3Digitos2 + "-" + cpf2Digitos2;
            }
            //preenche CNPJ com a mesma metodologia
            else if (txtCNPJ.Text.Length == 14)
            {
                string cnpj2Digitos = txtCNPJ.Text.Substring(0, 2);
                string cnpj3Digitos = txtCNPJ.Text.Substring(2, 3);
                string cnpj3Digitos2 = txtCNPJ.Text.Substring(5, 3);
                string cnpj4Digitos = txtCNPJ.Text.Substring(8, 4);
                string cnpj2Digitos2 = txtCNPJ.Text.Substring(12,2 );
                txtCNPJ.Text = "";
                txtCNPJ.Text = cnpj2Digitos + "." + cnpj3Digitos + "." + cnpj3Digitos2 + "/"+cnpj4Digitos+"-"+ cnpj2Digitos2;
            }
            else if(txtCNPJ.Text.Length <11)
            {
                MessageBox.Show("CPF nao possui a quantidade de caracteres obrigatorias");
            }
            else if (txtCNPJ.Text.Length > 11 && txtCNPJ.Text.Length < 14 && txtCNPJ.Text.Length > 14)
            {
                MessageBox.Show("CNPJ nao possui a quantidade de caracteres obrigatorias");
            }
        }
    }
}
