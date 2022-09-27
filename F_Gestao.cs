using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.obterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv =(DataGridView) sender;
            int contLinhas=dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt=Banco.obterDadosUsuarios(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("ID_USUARIO").ToString();
                tb_nome.Text= dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                nup_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
           
        }

        private void btn_novoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.Id = Convert.ToInt32 (tb_id.Text);
            u.Name = tb_nome.Text;
            u.username = tb_username.Text;
            u.password = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel =Convert.ToInt32( Math.Round(nup_nivel.Value,0));

            Banco.AtualizarUsuarios(u);
            //dgv_usuarios.DataSource = Banco.obterUsuariosIdNome();
            //dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
            //dgv_usuarios[0, linha].Value = tb_id.Text;
            dgv_usuarios[1, linha].Value = tb_nome.Text;

        }

        private void btn_fecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluirUsurario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão ?","Excluir ?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.DeletarUsuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }

        }
    }
}
