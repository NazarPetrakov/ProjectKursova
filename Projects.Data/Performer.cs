using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{
    public class Performer : Base<Performer>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public DateTime Birthday { get; set;  }

        public string GetFullName()
        {
            int age = (DateTime.Now - Birthday).Days / 365;
            if (Name == null)
                return "Anonym";
            else
                return Name + " " + Surname + ", " + age + " years old";
           
        }

        public override string ToString()
        {
            return Login;
        }

    }
}
