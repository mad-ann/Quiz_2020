using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2020
{
    class Valasz
    {
        int kod;
        int kerdes_id;
        string valasz;
        string helyes;

        public int Id { get => kod; set => kod = value; }

        public int Kerdes_Id { get => kerdes_id; set => kerdes_id = value; }
        public string ValasZ { get => valasz; set => valasz = value; }
        public string Helyes { get => helyes; set => helyes = value; }

        public Valasz(int id, string valasz, int kerdes_id, string helyes)
        {
            Id = id;
            ValasZ = valasz;
            Kerdes_Id = kerdes_id;
            Helyes = helyes;
        }
        public override string ToString()
        {
            return $"{valasz}";
        }
    }
}
