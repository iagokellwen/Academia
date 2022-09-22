using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username=tb_username.Text;
            string senha=tb_senha.Text;

            if (username == "" || senha == "")
            { 
                MessageBox.Show("Usuário ou senha inválidos");
                tb_username.Focus();
                return;
            }
            string sql= "SELECT * FROM tb_usuario WHERE T_USERNAME='"+username+"' AND T_SENHAUSUARIO='"+senha+"'";
            dt = Banco.consulta(sql); 
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.pb_ledLogado.Image = Properties.Resources.led_green_md;
                Globais.nivel= int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
