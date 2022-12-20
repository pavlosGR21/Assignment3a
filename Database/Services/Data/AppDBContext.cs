using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConfig.Models;


namespace DatabaseConfig.Services.Data
{
    public class AppDBContext : DbContext
    {
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<CertTitle> CertTitle { get; set; }
       
        public AppDBContext() : base("name=MyConnectionString")
        {

        }
    }
}
