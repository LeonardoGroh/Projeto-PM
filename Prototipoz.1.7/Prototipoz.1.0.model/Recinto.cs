using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipoz._1._0.DB;

namespace Prototipoz._1._0.model
{
    public class Recinto
    {
        private static int idRecinto;
        private static string planta;
        private static decimal nvSeguranca;

        public static int IDRecinto
        {
            get { return idRecinto; }
            set { idRecinto = value; }
        }
        public static string Planta
        {
            get { return planta; }
            set { planta = value; }
        }
        public static decimal NvSeguranca
        {
            get { return nvSeguranca; }
            set { nvSeguranca= value; }
        }

        public static void cadastrarRecinto()
        {
            Banco.ExecutarComando("INSERT into recinto values(" + IDRecinto + ",'planta'," + NvSeguranca + ",1);");
        }
    
    }
}
