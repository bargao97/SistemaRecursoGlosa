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
        public static string CPF_CNPJPuro;
        
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
            //Ocultando os campos de texto
            txtCNPJ.Visible = false;
            txtNomeFantasia.Visible = false;
            txtRazaoSocial.Visible = false;

            //Realizando a busca do cliente pelo id que foi salvo no userControl CadastrarClientes
            idPrestadorCadastroClientes = CadastrarClientes.idprestadorCadastrarClientes;
            var prestador = db.PRESTADORES.Where(s => s.IDPRESTADOR == idPrestadorCadastroClientes).FirstOrDefault(); ;
            
            //passando a variavel de cpf_cnpj sem mascara para uma classe universal do form
            CPF_CNPJPuro = prestador.CPF_CNPJ;

            //Atribuindo os valores encontrados para as labels
            lblTitulo.Text = "CLIENTE:" + prestador.NOME_FANTASIA;
            lblPrestador.Text = prestador.NOME_FANTASIA;
            lblRazaoSocial.Text = prestador.RAZAO_SOCIAL;
            lblCPF.Text = prestador.CPF_CNPJ;

            //Metodo de mascara do CEP
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Passando os valores da label para os campos de texto
            txtNomeFantasia.Text = lblPrestador.Text;
            txtRazaoSocial.Text = lblRazaoSocial.Text;
            txtCNPJ.Text = CPF_CNPJPuro;

            //Ocultando as labels
            lblPrestador.Visible = false;
            lblRazaoSocial.Visible = false;
            lblCPF.Visible = false;

            //Tornando os campos de texto visivel
            txtNomeFantasia.Visible = true;
            txtRazaoSocial.Visible = true;
            txtCNPJ.Visible = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //buscando o prestador para alteração
            var prestador = db.PRESTADORES.Where(s => s.IDPRESTADOR == idPrestadorCadastroClientes).FirstOrDefault();

            //atribuindo aos campos de texto ao prestador
            prestador.NOME_FANTASIA = txtNomeFantasia.Text;
            prestador.RAZAO_SOCIAL = txtRazaoSocial.Text;
            prestador.CPF_CNPJ = CPF_CNPJPuro;

            //Atribuindo os valores do prestador as labels
            lblPrestador.Text = prestador.NOME_FANTASIA;
            lblRazaoSocial.Text = prestador.RAZAO_SOCIAL;
            lblCPF.Text = prestador.CPF_CNPJ;
            
            //salvando a alteração no banco
            db.SaveChanges();

            MessageBox.Show("Cliente Alterado com sucesso");

            //limpando os campos de texto
            txtNomeFantasia.Text = "";
            txtRazaoSocial.Text = "";
            txtCNPJ.Text = "";

            //ocultando os campos de texto
            txtNomeFantasia.Visible = false;
            txtRazaoSocial.Visible = false;
            txtCNPJ.Visible = false;

            //mostrando novamente as labels com alterações
            lblPrestador.Visible = true;
            lblRazaoSocial.Visible = true;
            lblCPF.Visible = true;
            lblTitulo.Text = lblPrestador.Text;

            

        }

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            CPF_CNPJPuro = txtCNPJ.Text;
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
                string cnpj2Digitos2 = txtCNPJ.Text.Substring(12, 2);
                txtCNPJ.Text = "";
                txtCNPJ.Text = cnpj2Digitos + "." + cnpj3Digitos + "." + cnpj3Digitos2 + "/" + cnpj4Digitos + "-" + cnpj2Digitos2;
            }
            else if (txtCNPJ.Text.Length < 11)
            {
                MessageBox.Show("CPF nao possui a quantidade de caracteres obrigatorias");
                txtCNPJ.Text = "";
            }
            else if (txtCNPJ.Text.Length > 11 && txtCNPJ.Text.Length < 14)
            {
                MessageBox.Show("CNPJ nao possui a quantidade de caracteres obrigatorias");
                txtCNPJ.Text = "";
            }
            else if (txtCNPJ.Text.Length > 14)
            {
                MessageBox.Show(" CPF ou cnpj possui a quantidade de caractereres é maior que o oobrigatorio");
                txtCNPJ.Text = "";
            }
        }
    }
}
