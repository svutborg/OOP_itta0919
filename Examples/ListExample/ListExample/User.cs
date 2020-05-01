using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class User
    {
        string name;
        string surname;
        int iD;

        public User(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            ID = id;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int ID { get => iD; set => iD = value; }

        public override string ToString()
        {
            return $"Name: {Name} {Surname}     ID: {ID}";
        }
    }
}
