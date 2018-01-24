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
    public partial class CadastrarOperadora : UserControl
    {
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();
        public CadastrarOperadora()
        {
            InitializeComponent();
        }

        private void CadastrarOperadora_Load(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            OPERADORAS op = new OPERADORAS();
            string Operadora = txtNomeFantasia.Text.ToUpper();
            int registro_ANS = Convert.ToInt32(txtRegistroAns.Text.ToUpper());
            var opExistentes = db.OPERADORAS.Where(s => s.NOME_FANTASIA == Operadora ||s.REGISTRO_ANS == registro_ANS).ToList();
            if(opExistentes.Count() != 0)
            {
                MessageBox.Show("OPERADORA JA CADASTRADA NO SISTEMA");
            }
            else
            {
                try
                {
                    op.NOME_FANTASIA = Operadora;
                    op.REGISTRO_ANS = registro_ANS;
                    db.OPERADORAS.Add(op);
                    db.SaveChanges();
                    MessageBox.Show("OPERADORA JA CADASTRADA COM SUCESSO");
                    gdvOperadoras.DataSource = db.OPERADORAS.ToList();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException er)
                {
                    string rs = "";
                    foreach (var eve in er.EntityValidationErrors)
                    {
                        rs = string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        MessageBox.Show(rs);

                        foreach (var ve in eve.ValidationErrors)
                        {
                            rs += "<br />" + string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                            MessageBox.Show(rs);
                        }
                    }
                    throw new Exception(rs);
                }
            }
        }

        private void gdvOperadoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
