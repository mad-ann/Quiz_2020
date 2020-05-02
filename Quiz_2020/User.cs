using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2020
{
    class User
    {
        int id;
        string nev;
        string felhasznalonev;
        int pontszam;
        string email;
        DateTime szulido;

        public int ID { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Felhasznalonev { get => felhasznalonev; set => felhasznalonev = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
        public string Email { get => email; set => email = value; }
        
        public DateTime Szulido { get => szulido; set => szulido = value; }

        public User(int id, string nev, string felhasznalonev, int pontszam, string email, DateTime szulido)
        {
            ID = id;
            Nev = nev;
            Felhasznalonev = felhasznalonev;
            Pontszam = pontszam;
            Email = email;
            Szulido = szulido;
        }

        public override string ToString()
        {
            return $"{felhasznalonev}";
        }
    }
}
