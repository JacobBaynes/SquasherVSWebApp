using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquasherVSWebApp.Models
{
    public class Bug
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
        public ICollection<ProjectAssignment> ProjectAssignments { get; set; }
        public ICollection<SquasherAssignment> SquasherAssignments { get; set; }

    }
}
