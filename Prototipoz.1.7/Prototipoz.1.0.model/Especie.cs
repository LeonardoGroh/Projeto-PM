using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipoz._1._0.DB;

namespace Prototipoz._1._0.model
{
    public class Especie
    {
        private static string nomeCientifico;
        private static string nomePoupular;
        private static string familia;
        private static decimal nvSeguranca;
        private static string in169;




        public static string NomeCientifico
        {
            get { return nomeCientifico; }
            set { nomeCientifico = value; }
        }

        public static string NomePopular
        {
            get { return nomePoupular; }
            set { nomePoupular = value; }
        }

        public static string Familia
        {
            get { return familia; }
            set { familia = value; }
        }

        public static decimal NvSeguranca
        {
            get { return nvSeguranca; }
            set { nvSeguranca = value; }
        }

        public static string IN169
        {
            get { return in169; }
            set { in169 = value; }
        }

        public static void cadastrarEspecie()
        {
          Banco.ExecutarComando("insert into especie values(null,'"+IN169+"','"+NomeCientifico+"','"+NomePopular+"','"+Familia+"',"+NvSeguranca+");"); 
        }
    }
}
