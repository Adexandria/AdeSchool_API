using AdeSchool.Db.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeSchool.Db
{
    public class SessionFactory
    {
        public SessionFactory(IConfiguration config)
        {
            var connectionString = config.GetConnectionString("AdeSchoolDb");
            _session = ConfigureSession(connectionString).OpenSession();
        }
        
        public ISession _session;
        private  ISessionFactory _sessionFactory;

        private ISessionFactory ConfigureSession(string connectionString) => _sessionFactory ??
            Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012.ConnectionString
                (connectionString))
            .Mappings(m =>
            {
                m.FluentMappings.AddFromAssembly(typeof(StudentMap).Assembly);
            })
            .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true)).BuildSessionFactory();
    }
}
