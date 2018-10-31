using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.Core
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }

        public ICollection<Achievement> Achievements { get; set; }
    }
}
