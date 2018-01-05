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
    public partial class NormaANS : UserControl
    {
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();
        public NormaANS()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                TABELA_ANS ans = new TABELA_ANS();
                int codAns = Convert.ToInt32(txtCodAns.Text);
                string descricao = txtDescricao.Text.ToUpper();
                string resposta = txtResposta.Text.ToUpper();

                var codExistente = db.TABELA_ANS.Where(s => s.COD_ANS == codAns).FirstOrDefault();
                if (codExistente != null)
                {
                    MessageBox.Show("CODIGO ANS JA INSERIDO NO SISTEMA");
                }
                else
                {
                    ans.COD_ANS = codAns;
                    ans.DESCRICAO = descricao;
                    ans.RESPOSTA_AUTOMATICA = resposta;
                    db.TABELA_ANS.Add(ans);
                    db.SaveChanges();

                }
                MessageBox.Show("Codigo ADICIONADO COM SUCESSO");
                gdvTabelaAns.DataSource = db.TABELA_ANS.ToList();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }

        private void NormaANS_Load(object sender, EventArgs e)
        {
         
        }
    }
}
