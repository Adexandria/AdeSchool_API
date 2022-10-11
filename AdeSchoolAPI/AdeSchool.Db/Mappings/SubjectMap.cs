using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class SubjectMap : ClassMap<Subject>
    {
        public SubjectMap()
        {
            Id(s => s.SubjectId).GeneratedBy.Guid();
            Map(s => s.Name);
            Map(s => s.Description);
            HasOne(s => s.Teacher).PropertyRef(s=>s.Subject);
            HasMany(s => s.Results);
            HasMany(s => s.Students);

        }
    }
}
