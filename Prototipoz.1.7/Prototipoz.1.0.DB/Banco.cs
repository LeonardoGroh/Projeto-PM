using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Prototipoz._1._0.DB
{
    public class Banco
    {
     public static MySqlConnection conn = null;
        public static MySqlCommand cmd = null;
        public static MySqlDataAdapter dataAdapter;

        public static string server = null;
        public static string port = null;
        public static string database = null;
        public static string user = null;
        public static string password = null;
        public static bool verificarVaga = false;
        //método utilizado para abrir a conexão com o banco de dados
        private static void AbrirConexao()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

                builder.Server = String.IsNullOrWhiteSpace(server) ? "localhost" : server;
                builder.Port = String.IsNullOrWhiteSpace(port) ? 3307 : uint.Parse(port);
                builder.Database = String.IsNullOrWhiteSpace(database) ? "mydb" : database;
                builder.UserID = String.IsNullOrWhiteSpace(user) ? "root" : user;
                builder.Password = String.IsNullOrWhiteSpace(password) ? "mysql" : password;

                conn = new MySqlConnection();

                conn.ConnectionString = builder.ConnectionString;

                conn.Open();
               
            }
            catch (MySqlException me)
            {
                if (me.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    throw new Exception("Impossível se conectar com o banco de dados,verifique a sua conexão com a internet e se o erro persistir contate o suporte ");
                }

                else
                {
                    throw new Exception(me.Message); 
                } 
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //método utilizado para fechar a conexão com o banco de dados
        private static void FecharConexao()
        {
            try
            {
                conn.Close();
                conn.Dispose();
            }
            catch (MySqlException me)
            {
                throw new Exception(me.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        // método utilizado para executar um comando no banco( geralmente do tipo INSERT) 
        public static int ExecutarComando(string SQL)
        {
            try
            {
                AbrirConexao();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conn;
                comando.CommandText = SQL;
                comando.CommandType = CommandType.Text;

                
                return comando.ExecuteNonQuery();
            }
            catch (MySqlException me)
            {
                
                throw new Exception(me.Message);
               
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        //busca no banco de dados um dado específico
        public static object RecuperarDado(string SQL)
        {
            try
            {
                AbrirConexao();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conn;
                comando.CommandText = SQL;
                comando.CommandType = CommandType.Text;

                return comando.ExecuteScalar();
            }
            catch (MySqlException me)
            {
                throw new Exception(me.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        //busca no banco um conjunto de dados
        public static DataSet RecuperarRegistro(string SQL)
        {
            try
            {
                AbrirConexao();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(SQL, conn);

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                return dataSet;
            }
            catch (MySqlException me)
            {
                throw new Exception(me.Message);
                                
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        
       
        }
        // método utilizado para ler uma informação no banco e verificar se ela existe
        public static object LerDado(string SQL)
        {
            try
            {
                AbrirConexao();
                
                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conn;
                comando.CommandText = SQL;
                comando.CommandType = CommandType.Text;
                
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    return "True"; 
                }
                else
                {
                    return "False";
                  
                }
                
            }
            catch (MySqlException me)
            {
                throw new Exception(me.Message);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
       
    }
    }
