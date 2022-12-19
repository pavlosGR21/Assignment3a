using Database.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidCert.Models;

namespace AppUi
{
    public class Program 
    {
        public AppDBContext appDBContext = new AppDBContext();

        public static void Main(string[] args)
        {

        }


         public static void DBinserts(AppDBContext appDBContext)
        {
            DateTime PavlosDoB = new DateTime(1988, 08, 13);
            DateTime PavlosPiD = new DateTime(2010, 05, 22);

            Candidate Pavlos = new Candidate( "Pavlos", null, "Xanthopoulos", "Male", "Greek", PavlosDoB, "National card", 789568,
                PavlosPiD , "pavlos.xanthopoulos@hotmail.com", "Olimpou", 29, "Greece", "Athens", "Ilioupoli", 16345, 6908446301, 2114020854);

            DateTime MariaDoB = new DateTime(1989, 07, 03);
            DateTime MariaPiD = new DateTime(2011, 02, 10);

            Candidate Maria = new Candidate("Maria", "Melina", "Karra", "Female", "Greek", MariaDoB, "Passport", 521236,
                 PavlosPiD, "pavlos.xanthopoulos@hotmail.com", "Olimpou", 29, "Greece", "Athens", "Ilioupoli", 16345, 6935458952, 2114020854);

            DateTime JohnDoB = new DateTime(1991, 08, 11);
            DateTime JohnPiD = new DateTime(2012, 05, 26);

            Candidate John = new Candidate("John", "Danglar", "Stamatopoulos", "Male", "Greek", JohnDoB, "Passport", 521236,
                 JohnPiD, "pavlos.xanthopoulos@hotmail.com", "Olimpou", 29, "Greece", "Athens", "Ilioupoli", 16345, 6935458952, 2114020854);

            appDBContext.Candidates.Add(Pavlos);
            appDBContext.Candidates.Add(Maria);
            appDBContext.Candidates.Add(John);
            appDBContext.SaveChanges();



         
        }
    }
}