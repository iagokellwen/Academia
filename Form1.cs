namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void lb_acesso_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_red;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2){
                    //PROCEDIMENTOS
                }else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
        
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
                    f_GestaoUsuarios.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso não permitido");
                }
            }
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

            }
            
            else
            {
                MessageBox.Show("É necessario ter um usuário logado");
            }
        }
    }
}