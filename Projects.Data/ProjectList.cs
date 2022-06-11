using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{
    public class ProjectList : Base
    {
        public string Name { get; set; }

        public List<ListTask> Tasks
        {
            get
            {
                List<ListTask> res = new List<ListTask>();
                foreach (var item in Base.Items.Values)
                {
                    if (item is ListTask && ((ListTask)item).ProjectList == this)

                        res.Add((ListTask)item);

                }
                return res;

            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
