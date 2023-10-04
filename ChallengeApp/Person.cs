using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }
    }
}
