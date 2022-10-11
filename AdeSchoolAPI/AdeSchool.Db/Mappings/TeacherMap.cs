using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class TeacherMap :ClassMap<Teacher>
    {
        public TeacherMap()
        {
            Id(s => s.TeacherId).GeneratedBy.Guid();
            Map(s => s.FirstName);
            Map(s => s.LastName);
            Map(s => s.MiddleName);
            Map(s => s.Title);
            HasOne(s => s.Subject).PropertyRef(s => s.Teacher);
            HasMany(s => s.Students);
            HasMany(s => s.Classrooms);
        }
    }
}
