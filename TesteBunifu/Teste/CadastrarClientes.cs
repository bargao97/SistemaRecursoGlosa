using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Database;
namespace Teste
{
    public partial class CadastrarClientes : UserControl
    {
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();
        public static int idprestadorCadastrarClientes;
        public static string CPF_CNPJ_SemMascara;
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
            
            CPF_CNPJ_SemMascara = txtCNPJ.Text;
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
                txtCNPJ.Text = "";
            }
            else if (txtCNPJ.Text.Length > 11 && txtCNPJ.Text.Length < 14)
            {
                MessageBox.Show("CNPJ nao possui a quantidade de caracteres obrigatorias");
                txtCNPJ.Text = "";
            }
            else if(txtCNPJ.Text.Length > 14)
            {
                MessageBox.Show(" CPF ou cnpj possui a quantidade de caractereres é maior que o oobrigatorio");
                txtCNPJ.Text = "";
            }
        }

        private void txtRazaoSocial_OnValueChanged(object sender, EventArgs e)
        {
           txtNomeFantasia.Text=txtRazaoSocial.Text;
        }
        public void carregarGrid()
        {
            gdvPrestadores.DataSource = db.PRESTADORES.Select(s => new
            {
                Id = s.IDPRESTADOR,
                Nome_Fantasia = s.NOME_FANTASIA,
                Razao_Social = s.RAZAO_SOCIAL,
                CPF_CNPJ = s.CPF_CNPJ
            }).ToList();
        }
        private void gdvPrestadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var IdPrestador = gdvPrestadores.Rows[e.RowIndex].Cells[0].Value;
            idprestadorCadastrarClientes = Convert.ToInt32(IdPrestador);
            verPrestador vp = new verPrestador();
            vp.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PRESTADORES prestador = new PRESTADORES();

                prestador.CPF_CNPJ = CPF_CNPJ_SemMascara.ToString();
                prestador.RAZAO_SOCIAL = txtRazaoSocial.Text;
                prestador.NOME_FANTASIA = txtNomeFantasia.Text;

                db.PRESTADORES.Add(prestador);
                db.SaveChanges();

                MessageBox.Show("Prestador cadastrado com sucesso");

                gdvPrestadores.DataSource = db.PRESTADORES.Select(s => new
                {
                    Id = s.IDPRESTADOR,
                    Nome_Fantasia = s.NOME_FANTASIA,
                    Razao_Social = s.RAZAO_SOCIAL,
                    CPF_CNPJ = s.CPF_CNPJ
                }).ToList();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
