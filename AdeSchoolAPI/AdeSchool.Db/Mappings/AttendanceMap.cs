using AdeSchool.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db.Mappings
{
    public class AttendanceMap :ClassMap<Attendance>
    {
        public AttendanceMap()
        {
            Id(s => s.AttendanceId).GeneratedBy.Guid();
            Map(s => s.Date);
            Map(s => s.IsPresent);
            References(s => s.Student);
            
        }
    }
}
