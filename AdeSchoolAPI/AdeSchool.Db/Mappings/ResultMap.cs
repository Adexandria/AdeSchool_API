using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class ResultMap : ClassMap<Result>
    {
        public ResultMap()
        {
            Id(s => s.ResultId).GeneratedBy.Guid();
            Map(s => s.Term);
            Map(s => s.Grade).CustomType<Grade>();
            Map(s => s.Score);
            Map(s => s.Subject);
            Map(s => s.Session);
            References(s => s.Student);
            References(s => s.Teacher);
            References(s => s.Subject);
            

        }
    }
}
