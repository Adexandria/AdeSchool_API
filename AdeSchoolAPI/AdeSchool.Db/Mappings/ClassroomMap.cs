using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class ClassroomMap :ClassMap<Classroom>
    {
        public ClassroomMap()
        {
            Table("Classroom");
            Id(x => x.ClassroomId).GeneratedBy.Guid();
            Map(x => x.Name);
            HasManyToMany(x => x.Teachers);
            HasMany(x => x.Students);
        }
    }
}
