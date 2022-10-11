using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class GuardianMap : ClassMap<Guardian>
    {
        public GuardianMap()
        {
            Table("Guardian");
            Id(x => x.GuardianId).GeneratedBy.Guid();
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Address);
            Map(x => x.Relationship).CustomType<Relationship>();
            Map(x => x.PhoneNumber);
            Map(s => s.Title).CustomType<Title>();
            HasManyToMany(x => x.Students);
            
        }
    }
}
