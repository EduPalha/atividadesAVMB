using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidades;
using System.Text;

namespace BaseDados
{
    public class Conexao
    {
        private MySqlConnection Connection;
        private string Server;
        private string Database;
        private string Uid;
        private string Password;
        private string Port;
        public Conexao()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            Server = "127.0.0.1";
            Database = "provaNicolasLInguages2";
            Uid = "root";
            Password = "";
            Port = "3306";
            string connectionstring = "SERVER=" + Server + ";" + "PORT=" + Port + ";" + "DATABASE=" +
            Database + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";";

            this.Connection = new MySqlConnection(connectionstring);
        }

        public bool AbrirConexao()
        {
            try
            {
                Connection.Open();
                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ExecutarQuery(string query)
        {
            int r = 0;
            try
            {
                AbrirConexao();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                r = cmd.ExecuteNonQuery();
            }

            finally
            {
                FecharConexao();
            }

            return r > 0;
        }

        public bool FecharConexao()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();

                return true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public bool InserirCLasse(Classe Classe)
        {
            try
            {
                string query = string.Format("INSERT INTO classe (descricao, forca, HP, destresa, defesa) values('{0}', {1}, {2}, {3}, {4})", Classe.Descricao, Classe.Forca, Classe.HP, Classe.Destresa, Classe.Defesa);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool AlterarClasse(Classe Classe)
        {
            try
            {
                string query = string.Format("update classe set descricao='{0}', forca={1}, HP={2}, destresa={3}, defesa={4} WHERE codigo={5}", Classe.Descricao, Classe.Forca, Classe.HP, Classe.Destresa, Classe.Defesa, Classe.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirClasse(Classe Classe)
        {
            try
            {
                string query = string.Format("delete from classe where codigo = {0}", Classe.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public List<Classe> ListarClasses()
        {
            List<Classe> listaRegistros = new List<Classe>();

            try
            {
                AbrirConexao();
                string query = @"SELECT codigo,descricao,forca,hp,destresa,defesa FROM classe";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Classe obj = new Classe();
                    obj.Codigo = Convert.ToInt32(reader["codigo"]);
                    obj.Descricao = reader["descricao"].ToString();
                    obj.Forca = Convert.ToInt32(reader["forca"]);
                    obj.HP = Convert.ToInt32(reader["hp"]);
                    obj.Destresa = Convert.ToInt32(reader["destresa"]);
                    obj.Defesa = Convert.ToInt32(reader["defesa"]);

                    listaRegistros.Add(obj);
                }
                reader.Close();
            }

            finally
            {
                FecharConexao();
            }

            return listaRegistros;
        }

        public bool InserirPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("INSERT INTO personagens (nome, codigo_classe, XP, pontos_livres, nivel, forca, hp, destresa, defesa) " +
                    "values('{0}', '{1}', {2}, {3}, {4}, {5}, '{6}', {7}, {8}", Personagem.Nome, Personagem.Classe.Codigo, Personagem.XP, Personagem.PontosLivres, Personagem.Nivel, Personagem.Forca, Personagem.HP, Personagem.Destresa, Personagem.Defesa);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool AlterarPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("UPDATE Personagens SET nome = '{0}', codigo_classe = {1}, XP = {2}, pontos_livres = {3}, nivel = {4}, forca = {5}, hp = {6}, destresa = {7}, defesa = {8} " +
                    "WHERE codigo = {8}", Personagem.Nome, Personagem.Classe.Codigo, Personagem.XP, Personagem.PontosLivres, Personagem.Nivel, Personagem.Forca, Personagem.HP, Personagem.Destresa, Personagem.Destresa);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public bool ExcluirPersonagem(Personagem Personagem)
        {
            try
            {
                string query = string.Format("DELETE FROM Personagens WHERE codigo = {0}", Personagem.Codigo);
                return ExecutarQuery(query);
            }

            catch (Exception ex)
            {
                FecharConexao();
                throw ex;
            }

            finally
            {
                FecharConexao();
            }
        }

        public List<Personagem> ListarPersonagens()
        {
            List<Personagem> listaRegistros = new List<Personagem>();

            try
            {
                AbrirConexao();
                string query = @"SELECT 
                                        Codigo, 
                                        nome, 
                                        codClasse, 
                                        classe,
                                        classe_forca,
                                        classe_HP,
                                        classe_destresa,
                                        classe_defesa,
                                        XP, 
                                        pontos_livres, 
                                        nivel, 
                                        forca, 
                                        hp, 
                                        destresa, 
                                        defesa 
                                                FROM vw_personagens";
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Personagem obj = new Personagem();
                    obj.Codigo = Convert.ToInt32(reader["Codigo"]);
                    obj.Nome = reader["nome"].ToString();
                    obj.Classe.Codigo = Convert.ToInt32(reader["codClasse"]);
                    obj.Classe.Descricao = reader["classe"].ToString();
                    obj.Classe.Forca = Convert.ToInt32(reader["classe_forca"]);
                    obj.Classe.HP = Convert.ToInt32(reader["classe_HP"]);
                    obj.Classe.Destresa = Convert.ToInt32(reader["classe_destresa"]);
                    obj.Classe.Defesa = Convert.ToInt32(reader["classe_defesa"]);
                    obj.XP = Convert.ToInt32(reader["XP"]);
                    obj.PontosLivres = Convert.ToInt32(reader["pontos_livres"]);
                    obj.Nivel = Convert.ToInt32(reader["nivel"]);
                    obj.Forca = Convert.ToInt32(reader["forca"]);
                    obj.HP = Convert.ToInt32(reader["hp"]);
                    obj.Destresa = Convert.ToInt32(reader["destresa"]);
                    obj.Defesa = Convert.ToInt32(reader["defesa"]);

                    listaRegistros.Add(obj);
                }
                reader.Close();
            }

            finally
            {
                FecharConexao();
            }
            return listaRegistros;
        }

    }
}
