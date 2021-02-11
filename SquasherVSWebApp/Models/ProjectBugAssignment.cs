using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquasherVSWebApp.Models
{
    public class ProjectBugAssignment
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int BugID { get; set; }

        public Bug Bug { get; set; }
        public Project Project { get; set; }

    }
}
