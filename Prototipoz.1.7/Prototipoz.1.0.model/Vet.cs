using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipoz._1._0.model
{
    public class Vet
    {
        private static int idVet;
        private static char fezes;
        private static string vermifugo;
        private static DateTime ano;
        private static string obs;
        private static DateTime data;
        private static int idUsuario;

        public static int IDVet
        {
            get { return idVet; }
            set { idVet= value; }
        }
        public static char Fezes
        {
            get { return fezes; }
            set { fezes = value; }
        }
        public static string Vermifugo
        {
            get { return vermifugo; }
            set { vermifugo= value; }
        }
        public static DateTime Ano
        {
            get { return ano; }
            set { ano= value; }
        }
        public static string Obs
        {
            get { return obs; }
            set { obs= value; }
        }
        public static DateTime Data
        {
            get { return data; }
            set { data= value; }
        }
    }
}