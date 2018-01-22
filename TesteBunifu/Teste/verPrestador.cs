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
            idPrestadorCadastroClientes = CadastrarClientes.idprestadorCadastrarClientes;
            var prestador = db.PRESTADORES.Where(s => s.IDPRESTADOR == idPrestadorCadastroClientes).FirstOrDefault(); ;
            lblTitulo.Text = "CLIENTE:" + prestador.NOME_FANTASIA;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
