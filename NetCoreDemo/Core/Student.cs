using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.Core
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("学员姓名")]
        public string Name { get; set; }

        [DisplayName("学员邮箱")]
        public string Email { get; set; }

        public ICollection<Achievement> Achievements { get; set; }
    }
}
