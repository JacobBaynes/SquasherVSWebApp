using System;
using System.Linq;
using SquasherVSWebApp.Models;

namespace SquasherVSWebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SquasherContext context)
        {
            context.Database.EnsureCreated();

            if (context.Bugs.Any())
            {
                return;  // DB has been seeded
            }

            var bugs = new Bug[]
            {
                new Bug{Title="NavBar Update", Description="The NavBar needs updating", Severity="High"},
                new Bug{Title="Home link", Description="The home link on the about page doesn't work", Severity="Mid"},
                new Bug{Title="Typos", Description="The Bugs Feed page has types", Severity="High"},
                new Bug{Title="Post Error", Description="The create new bug page is not posting to database", Severity="High"},
                new Bug{Title="Style changes", Description="The site needs style changes", Severity="low"}
            };
            foreach (Bug b in bugs)
            {
                context.Bugs.Add(b);
            }
            context.SaveChanges();

            var projects = new Project[]
            {
                new Project{Name="Squasher"},
                new Project{Name="Fizikel"},
                new Project{Name="Todo"},
                new Project{Name="SquasherXamarin"},
            };
            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }
            context.SaveChanges();

            var squashers = new Squasher[]
            {
                new Squasher{Name="Jake" },
                new Squasher{Name="KT" },
                new Squasher{Name="Brian" },
                new Squasher{Name="Amos" },
            };
            foreach (Squasher s in squashers)
            {
                context.Squashers.Add(s);
            }
            context.SaveChanges();
        }
    }
}
