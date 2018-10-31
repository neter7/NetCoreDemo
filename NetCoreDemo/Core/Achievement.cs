using NetCoreDemo.Application.EnumsType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.Core
{
    public class Achievement
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public Grade Grade { get; set; }

    }
}
