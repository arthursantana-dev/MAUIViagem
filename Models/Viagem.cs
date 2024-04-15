using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIViagem.Models
{
    public class Viagem
    {

        string _origem;
        string _destino;
        double _distancia;
        double _rendimento;
        double _preco;

        [AutoIncrement, PrimaryKey]

        public int Id { get; set; }
        public string Origem { get { return _origem; } set { _origem = value; } }

        public string Destino { get { return _destino; } set { _destino = value; } }

        public double Distancia { get { return _distancia; } set { _distancia = value; } }
        public double Rendimento { get { return _rendimento; } set { _rendimento = value; } }
        public double Preco { get { return _preco; } set { _preco = value; } }

    }
}
