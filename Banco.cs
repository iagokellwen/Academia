using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Academia
{
     class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data source =D:\\C#\\Parte 2\\Academia\\Academia\\banco\\bd_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable obterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                
                cmd.CommandText = "SELECT * FROM tb_usuario";
                da = new SQLiteDataAdapter(cmd.CommandText,vcon);
                da.Fill(dt);
               vcon.Close();
                return dt;
                

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        //funcões do FORM F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuario(T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES (@nome, @username, @password, @status, @nivel) ";
                cmd.Parameters.AddWithValue("@nome", u.Name);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido");
                vcon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário");
                ConexaoBanco().Close();
            }
        }
        //funções do FORM F_GestãoUsuario

        public static DataTable obterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "SELECT ID_USUARIO as 'ID Usuário',T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable obterDadosUsuarios(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_usuario WHERE ID_USUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //fim funções do FORM F_GestãoUsuario



        //FIM - funcões do FORM F_NovoUsuario

        public static void AtualizarUsuarios(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "UPDATE tb_usuario SET T_NOMEUSUARIO='" + u.Name + "',T_USERNAME='" + u.username + "', T_SENHAUSUARIO='" + u.password + "', T_STATUSUSUARIO='" + u.status + "', N_NIVELUSUARIO=" + u.nivel + " WHERE ID_USUARIO=" + u.Id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "DELETE FROM tb_usuario WHERE ID_USUARIO=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                cmd.ExecuteNonQuery();
                vcon.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Rotinas gerais
        public static bool existeUsername(Usuario u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuario WHERE T_USERNAME='"+u.username+"' ";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();

            return res;
        }
    }
}
