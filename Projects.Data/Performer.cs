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
        public string SurName { get; set; }
        public string Login { get; set; }
        public int Age { get; set;  }

        public override string ToString()
        {
            return Login;
        }

    }
}
