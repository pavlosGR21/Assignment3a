using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidCert.Models;

namespace Database.Services.Data
{
    public class AppDBContext : DbContext
    {
        public virtual DbSet<Candidate> Candidates { get; set; }
        public AppDBContext() : base("name=MyConnectionString")
        {

        }
    }
}
