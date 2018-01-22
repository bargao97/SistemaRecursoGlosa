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
    public partial class CadastrarFuncionario : UserControl
    {
        BancoRecursoGlosaEntities db = new BancoRecursoGlosaEntities();
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FUNCIONARIO func = new FUNCIONARIO();
            string nomeFuncionario = txtNomeFuncionario.Text.ToUpper();
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            var funcExistente = db.FUNCIONARIO.Where(s => s.USUARIO == usuario).ToList();
            if(funcExistente.Count() != 0)
            {
                MessageBox.Show("FUNCIONARIO JÁ CADASTRADO NO SISTEMA");
            }
            else
            {
                try
                {
                    func.NOME_FUNCIONARIO = nomeFuncionario;
                    func.USUARIO = usuario;
                    func.SENHA = senha;
                    db.FUNCIONARIO.Add(func);
                    db.SaveChanges();
                    MessageBox.Show("FUNCIONARIO CADASTRADO COM SUCESSO");
                    gdvFuncionarios.DataSource = db.FUNCIONARIO.Select(s => new
                    {
                        FUNCIONARIO = s.NOME_FUNCIONARIO,
                        USUARIO = s.USUARIO,
                        SENHA = s.SENHA
                    }).ToList();
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
                db.Dispose();
            }
        }
    }
}
