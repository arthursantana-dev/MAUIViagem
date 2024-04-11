using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIViagem.Models
{
    public class Pedagio
    {
        string _local;
        double _valor;


        [AutoIncrement, PrimaryKey]

        public int Id { get; set;}
        public string Local { get { return _local; } set { 

                _local = value;
            
            }
        }

        public double Valor { get { return _valor; } set {
                _valor = value;    
            
        } }

    }

    
}
