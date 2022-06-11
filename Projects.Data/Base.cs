using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{
    public  class Base
    {
        public static Dictionary<Guid, Base> Items = new Dictionary<Guid, Base>();
        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, this);
        }
    }
}
