using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquasherVSWebApp.Models
{
    public class ProjectSquasherAssignment
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int SquasherID { get; set; }
        public Project Project { get; set; }
        public Squasher Squasher { get; set; }
    }
}
