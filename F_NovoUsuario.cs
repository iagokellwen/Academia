﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Name = tb_nome.Text;
            usuario.username = tb_username.Text;
            usuario.password = tb_senha.Text;
            usuario.status = cb_status.Text;
            usuario.nivel =Convert.ToInt32( Math.Round (nup_nivel.Value,0));

            Banco.NovoUsuario(usuario);
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_senha.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            nup_nivel.Value=0;
            tb_nome.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Clear();
            tb_senha.Clear();
            tb_username.Clear();
            cb_status.Text = "";
            nup_nivel.Value = 0;
            tb_nome.Focus();
        }
    }
}
