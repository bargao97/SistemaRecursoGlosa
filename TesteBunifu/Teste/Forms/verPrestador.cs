using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Database;
namespace Teste
{
    public partial class verPrestador : Form
    {
        
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();

        public static int idPrestadorCadastroClientes;
        
        public verPrestador()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verPrestador_Load(object sender, EventArgs e)
        {

            txtCNPJ.Visible = false;
            txtNomeFantasia.Visible = false;
            txtRazaoSocial.Visible = false;

            idPrestadorCadastroClientes = CadastrarClientes.idprestadorCadastrarClientes;
            var prestador = db.PRESTADORES.Where(s => s.IDPRESTADOR == idPrestadorCadastroClientes).FirstOrDefault(); ;


            lblTitulo.Text = "CLIENTE:" + prestador.NOME_FANTASIA;
            lblPrestador.Text = prestador.NOME_FANTASIA;
            lblRazaoSocial.Text = prestador.RAZAO_SOCIAL;
            lblCPF.Text = prestador.CPF_CNPJ;
            if (lblCPF.Text.Length == 11)
            {

                //Seprara os campos de acordo com a posição dos caracteres
                string cpf2Digitos = lblCPF.Text.Substring(0, 3);
                string cpf3Digitos = lblCPF.Text.Substring(3, 3);
                string cpf3Digitos2 = lblCPF.Text.Substring(6, 3);
                string cpf2Digitos2 = lblCPF.Text.Substring(9, 2);
                //limpa os campos de textos
                lblCPF.Text = "";
                //preenche novamente com os campos certos
                lblCPF.Text = cpf2Digitos + "." + cpf3Digitos + "." + cpf3Digitos2 + "-" + cpf2Digitos2;
            }
            //preenche CNPJ com a mesma metodologia
            else if (lblCPF.Text.Length == 14)
            {
                string cnpj2Digitos = lblCPF.Text.Substring(0, 2);
                string cnpj3Digitos = lblCPF.Text.Substring(2, 3);
                string cnpj3Digitos2 = lblCPF.Text.Substring(5, 3);
                string cnpj4Digitos = lblCPF.Text.Substring(8, 4);
                string cnpj2Digitos2 = lblCPF.Text.Substring(12, 2);
                lblCPF.Text = "";
                lblCPF.Text = cnpj2Digitos + "." + cnpj3Digitos + "." + cnpj3Digitos2 + "/" + cnpj4Digitos + "-" + cnpj2Digitos2;
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
