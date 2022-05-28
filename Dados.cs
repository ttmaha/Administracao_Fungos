using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Leitor_de_Mapa
{
    class Dados
    {

        private string descricao;
        private string latitude;
        private string longitude;
        public string genero;
        public string especie;
        public string data;
        public string namefoto;
        private Form1 form1;


        public Dados()
        {
            this.form1 = new Form1();

        }


        //propriedades
        public string Descricao { get => descricao; set => descricao = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Data { get => data; set => data = value; }
        public string Namefoto { get => namefoto; set => namefoto = value; }



    }
}
