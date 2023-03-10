namespace Database.Migrations
{
    using DatabaseConfig.Models;
    using DatabaseConfig.Services.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseConfig.Services.Data.AppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseConfig.Services.Data.AppDBContext context)
        {
            AppDBContext appDBContext = new AppDBContext();
            DateTime PavlosDoB = new DateTime(1988, 08, 13);
            DateTime PavlosPiD = new DateTime(2010, 05, 22);

            Candidate Pavlos = new Candidate(123456, "Pavlos", null, "Xanthopoulos", "Male", "Greek", PavlosDoB, "National card", 789568,
                PavlosPiD, "pavlos.xanthopoulos@hotmail.com", "Olimpou", 29, "Greece", "Athens", "Ilioupoli", 16345, 6908446301, 2114020854);

            DateTime MariaDoB = new DateTime(1989, 07, 03);
            DateTime MariaPiD = new DateTime(2011, 02, 10);

            Candidate Maria = new Candidate(456789, "Maria", "Melina", "Karra", "Female", "Greek", MariaDoB, "Passport", 521236,
                 MariaPiD, "maria@gmail.com", "Olimpou", 29, "Greece", "Athens", "Ilioupoli", 16345, 6935458952, 2114020854);

            DateTime JohnDoB = new DateTime(1991, 08, 11);
            DateTime JohnPiD = new DateTime(2012, 05, 26);

            Candidate John = new Candidate(789123, "John", "Danglar", "Stamatopoulos", "Male", "Greek", JohnDoB, "Passport", 125485,
                 JohnPiD, "John.Dang@hotmail.com", "kanari", 35, "Greece", "Athens", "Alimos", 17343, 6980525485, 2105847858);

            appDBContext.Candidates.Add(Pavlos);
            appDBContext.Candidates.Add(Maria);
            appDBContext.Candidates.Add(John);
            appDBContext.SaveChanges();


            CertTitle JavaAdvanced = new CertTitle("Java Advanced");
            CertTitle CSharpAdvanced = new CertTitle("C# Advanced");
            CertTitle PythonAdvanced = new CertTitle("Python Advanced");

            DateTime JavaDeD = new DateTime(2022, 08, 05);
            DateTime JavaSrD = new DateTime(2022, 08, 10);

            Certificate Java = new Certificate(JavaAdvanced, Pavlos, 0185, JavaDeD, JavaSrD, 100, "Pass", 100);

            DateTime CsharpDeD = new DateTime(2022, 12, 15);
            DateTime CsharpSrD = new DateTime(2022, 12, 20);

            Certificate Csharp = new Certificate(CSharpAdvanced, Maria, 0185, CsharpDeD, CsharpSrD, 100, "Pass", 78);

            DateTime PythonDeD = new DateTime(2020, 10, 20);
            DateTime PythonSrD = new DateTime(2020, 10, 25);

            Certificate Python = new Certificate(PythonAdvanced, John, 0185, PythonDeD, PythonSrD, 100, "Fail", 55);

            appDBContext.Certificates.Add(Java);
            appDBContext.Certificates.Add(Csharp);
            appDBContext.Certificates.Add(Python);
            appDBContext.SaveChanges();
        }
    }
}
