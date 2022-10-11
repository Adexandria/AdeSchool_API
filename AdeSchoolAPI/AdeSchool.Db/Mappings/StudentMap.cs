using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class StudentMap :ClassMap<Student>
    {
        public StudentMap()
        {
            Table("Student");
            Id(x => x.StudentId).GeneratedBy.Guid();
            Map(x => x.FirstName);
            Map(x => x.MiddleName);
            Map(x => x.LastName);
            Map(x => x.DateOfBirth);
            Map(x => x.Address);
            Map(x => x.StateOfOrigin).CustomType<StateOfOrigin>();
            Map(x => x.Class).CustomType<Class>();
            References(x => x.Classroom);
            HasManyToMany(x => x.Teachers);
            HasManyToMany(x => x.Subjects);
            HasManyToMany(x => x.Parents);
            HasMany(x => x.Results);
            HasMany(x => x.Attendances);
        }
    }
}
