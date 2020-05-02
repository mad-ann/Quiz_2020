using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2020
{
    class Kategoria
    {
        int id;
        string megnevezes;

        public int Id { get => id; set => id = value; }
        public string Megnevezes { get => megnevezes; set => megnevezes = value; }

        public Kategoria(int id, string megnevezes)
        {
            Id = id;
            Megnevezes = megnevezes;
        }
        public override string ToString()
        {
            return $"{megnevezes}";
        }
    }
}
