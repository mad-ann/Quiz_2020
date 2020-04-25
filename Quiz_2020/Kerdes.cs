using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2020
{
    class Kerdes
    {
        int id;
        string szoveg;
        int kategoria_id;
        List<Valasz> valaszok = new List<Valasz>();
        public int Id { get => id; set => id = value; }
        public string Szoveg { get => szoveg; set => szoveg = value; }

        public int Kategoria_id { get => kategoria_id; set => kategoria_id = value; }
        public List<Valasz> Valaszok { get => valaszok; set => valaszok = value; }

        public Kerdes(int id, string szoveg, int kategoria_id)
        {
            Id = id;
            Szoveg = szoveg;
            kategoria_id = Kategoria_id;
        }

        public override string ToString()
        {
            return $"{szoveg}";
        }

        public void AddValasz(Valasz valasz)
        {
            valaszok.Add(valasz);
        }
    }
}
