using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{
    public  class Base<T> where T:Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }
    }
    public static class DataBank
    {
        public static string Text { get; set; }
    }
}
