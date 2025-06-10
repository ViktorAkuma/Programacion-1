using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Pokemon.Models
{
    public class QueryPokemon
    {


            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public List<Pokemon> results { get; set; }
    }
}
