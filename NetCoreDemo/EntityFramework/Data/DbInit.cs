using NetCoreDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDemo.EntityFramework.Data
{
    public class DbInit
    {
        public static void Initialize(NetCoreDemoDbConttext context)
        {
            context.Database.EnsureCreated();
            // 如果有数据则 不执行数据初始化 
            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[] {
                new Student{ Name ="张三",Email="zhangsan@.com"},
                new Student{ Name ="李四",Email="zhangsan@.com"},
                new Student{ Name ="王五",Email="zhangsan@.com"},
                new Student{ Name ="赵六",Email="zhangsan@.com"},
                new Student{ Name ="刘希",Email="zhangsan@.com"}
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[] {
                new Course{Name="数学",CreationTime = DateTime.Now,CourseGrade = Application.EnumsType.Grade.A },
                new Course{Name="语文",CreationTime = DateTime.Now,CourseGrade = Application.EnumsType.Grade.A },
                new Course{Name="化学",CreationTime = DateTime.Now,CourseGrade = Application.EnumsType.Grade.A },
                new Course{Name="英语",CreationTime = DateTime.Now,CourseGrade = Application.EnumsType.Grade.A },
                new Course{Name="地理",CreationTime = DateTime.Now ,CourseGrade = Application.EnumsType.Grade.A},
                new Course{Name="物理",CreationTime = DateTime.Now,CourseGrade = Application.EnumsType.Grade.A }
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var achieventments = new Achievement[] {
                new Achievement{ StudentId=1,CourseId=1,Grade = Application.EnumsType.Grade.A},
                new Achievement{ StudentId=1,CourseId=2,Grade = Application.EnumsType.Grade.A},
                new Achievement{ StudentId=1,CourseId=3,Grade = Application.EnumsType.Grade.G},
                new Achievement{ StudentId=1,CourseId=4,Grade = Application.EnumsType.Grade.A},
                new Achievement{ StudentId=1,CourseId=5,Grade = Application.EnumsType.Grade.B},
                new Achievement{ StudentId=1,CourseId=6,Grade = Application.EnumsType.Grade.F},

                new Achievement{ StudentId=2,CourseId=2,Grade = Application.EnumsType.Grade.A},
                new Achievement{ StudentId=2,CourseId=3,Grade = Application.EnumsType.Grade.C},
                new Achievement{ StudentId=2,CourseId=4,Grade = Application.EnumsType.Grade.D},
                new Achievement{ StudentId=2,CourseId=5,Grade = Application.EnumsType.Grade.F},
                new Achievement{ StudentId=2,CourseId=6,Grade = Application.EnumsType.Grade.E},

                new Achievement{ StudentId=3,CourseId=1,Grade = Application.EnumsType.Grade.A},
                new Achievement{ StudentId=3,CourseId=3,Grade = Application.EnumsType.Grade.B},
                new Achievement{ StudentId=4,CourseId=4,Grade = Application.EnumsType.Grade.B},
                new Achievement{ StudentId=4,CourseId=2,Grade = Application.EnumsType.Grade.C},
                new Achievement{ StudentId=5,CourseId=1,Grade = Application.EnumsType.Grade.E},
                new Achievement{ StudentId=5,CourseId=4,Grade = Application.EnumsType.Grade.F},
                new Achievement{ StudentId=5,CourseId=1,Grade = Application.EnumsType.Grade.E},
            };
            context.Achievements.AddRange(achieventments);
            context.SaveChanges();

        }
    }
}
