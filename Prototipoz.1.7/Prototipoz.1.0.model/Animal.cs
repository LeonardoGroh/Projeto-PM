using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipoz._1._0.DB;



 namespace Prototipoz._1._0.model
{
    public class Animal
    {
        private static string marcacao;
        private static int numeroZoo;
        private static int idEspecie;      
        private static string nomeZoo;   
        private static string origem;
        private static string sexo;
        private static string dia;
        private static string mes;
        private static string ano;
        private static string necessidades;
        private static int recinto;
        private static byte[] imagem;
        private static string desfecho;
        private static DateTime dataDesfecho;

        public static string Marcacao
        {
            get { return marcacao; }
            set { marcacao = value; }
        }
             

       
        public static string Origem
        {
            get { return origem; }
            set { origem = value; }
        }
        public static string Sexo
        {
            get { return sexo; }
            set {sexo = value; }
        }
        public static string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public static string Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public static string Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public static string Necessidades
        {
            get { return necessidades;}
            set { necessidades = value; }
        }


        public static int Recinto
        {
            get { return recinto; }
            set { recinto = value; }
        }
       
       
        public static byte[] Foto
        {
            get { return imagem; }
            set { imagem = value; }
        }
        public static string NomeZoo
        {
            get { return nomeZoo; }
            set {nomeZoo= value;}
        }
        public static int NumeroZoo
        {
            get { return numeroZoo; }
            set { numeroZoo= value; } 
        }
        public static int IDEspecie
        {
            get { return idEspecie; }
            set { idEspecie = value; }
        }    
        public static DateTime DataDeDesfecho
        {
            get { return dataDesfecho; }
            set { dataDesfecho= value; }
        }
        public static string Desfecho
        {
            get { return desfecho; }
            set { desfecho = value; }
        }


        public static void cadastrarAnimal()
    {
        Banco.ExecutarComando("INSERT into animal values(" + Animal.NumeroZoo + ",'" + Animal.Necessidades + "','" + Animal.Origem + "','" + Animal.Ano + "-" + Animal.Mes + "-" + Animal.Dia + "',null,'" + Animal.Sexo + "',null,null," + Animal.IDEspecie + ",'" + Animal.Foto + "','" + Animal.Marcacao + "','" + Animal.NomeZoo + "'," + Animal.Recinto + ");");
    }
    
 }

}
