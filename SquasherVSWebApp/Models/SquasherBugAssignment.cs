using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquasherVSWebApp.Models
{
    public class SquasherBugAssignment
    {
        public int ID { get; set; }
        public int SquasherID { get; set; }
        public int BugID { get; set; }
        public Squasher Squasher { get; set; }
        public Bug Bug { get; set; }
    }
}
