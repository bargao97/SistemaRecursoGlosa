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
    public partial class Form1 : Form
    {
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();

        //ID do operador para a tela verOpeadora tela cadastrar cliente
        


        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarOperadoras_Click(object sender, EventArgs e)
        {
            cadastrarOperadora2.BringToFront();
        } 

        private void btnInicio_Click(object sender, EventArgs e)
        {
            menuPrincipal2.BringToFront();
        }

        private void btnCadastrarANS_Click(object sender, EventArgs e)
        {
            NormaANS ns = new NormaANS();
            ns.carregarGrid();
            normaANS2.BringToFront();
        }

        private void NAns_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPrincipal2.BringToFront();
        }

        private void btnCadastrarClientes_Click(object sender, EventArgs e)
        {
            cadastrarClientes2.BringToFront();
            cadastrarClientes2.carregarGrid();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            cadastrarFuncionario2.BringToFront();
        }
    }
}  
