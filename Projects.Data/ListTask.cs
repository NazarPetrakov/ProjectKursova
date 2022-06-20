using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{

    public class ListTask : Base<ListTask>
    {
        public string Name { get; set; }

        public string TaskStatus = "-";
        

        private Guid _projectListId;
        
        public  ProjectList ProjectList
        {
            get { return ProjectList.Items[_projectListId]; }
            set { _projectListId = value.Id; }
        }
        public override string ToString()
        {
            return Name + " (" + TaskStatus + ")";
        }
    }
}
