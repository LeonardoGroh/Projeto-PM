using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipoz._1._0.DB;

namespace Prototipoz._1._0.model
{
    public class Usuario
    {
        private static string login;
        private static string senha;
        private static string nome;
        private static char tipo;
        private static char ativo;
        private static string email;
        private static string cpf;

        public static string Login
        {
            get { return login; }
            set { login = value; }
        }
        public static string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public static string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public static char Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public static char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        public static string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }


        public static void cadastrarUsuario()
        {
            Banco.ExecutarComando("insert into usuario values(null,'"+Nome+"','"+Cpf+"','"+Email+"',md5('"+Senha+"'),'"+Tipo+"','S','"+Login+"');");
        }

    }
}
