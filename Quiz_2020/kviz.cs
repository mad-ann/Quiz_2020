using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2020
{
    class Kviz
    {
        int id;
        string szoveg;
        int kategoria_id;
        List<Kerdes> kerdesek = new List<Kerdes>();
        
        public int Id { get => id; set => id = value; }
        public string Szoveg { get => szoveg; set => szoveg = value; }
        public int Kategoria_id { get => kategoria_id; set => kategoria_id = value; }
       
        public List<Kerdes> Kerdesek { get => kerdesek; set => kerdesek = value; }
    }
}
