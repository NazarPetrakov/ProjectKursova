using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Data
{
    public class ProjectList : Base<ProjectList>
    {
        public string Name { get; set; }

        public string ProjectStatus = "-";

        private Guid _performerId;

        
        public Performer Performer
        {
            get { return Performer.Items[_performerId]; }
            set { _performerId = value.Id; }
        }
        
        public override string ToString()
        {
            return Name + " (" + ProjectStatus + ")";
        }
    }
}
