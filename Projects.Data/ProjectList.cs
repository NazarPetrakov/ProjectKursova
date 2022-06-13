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

        public string TaskStatus = "-";

        private Guid _performerId;

        public Performer Performer
        {
            get { return Performer.Items[_performerId]; }
            set { _performerId = value.Id; }
        }
        public List<ListTask> ListTasks
        {
            get
            { 
                return ListTask.Items.Values.Where(lt => lt.ProjectList == this).ToList();  
            }
        }
        public override string ToString()
        {
            return Name + " (" + TaskStatus + ")";
        }
    }
}
