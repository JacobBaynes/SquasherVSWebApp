using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquasherVSWebApp.Models
{
    public class Squasher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ProjectSquasherAssignment> ProjectSquasherAssignments { get; set; }
        public ICollection<SquasherBugAssignment> SquasherBugAssignments { get; set; }

    }
}
