using DatabaseConfig.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConfig.Models;
using ConsoleTools;
using System.Security.Cryptography.X509Certificates;


namespace AppUi
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            ConsoleMenu adminMenu = new ConsoleMenu()
                .Add("Create new Candidate", () => Crud.CreateCandidate())
                .Add("Update a Candidate", () => Crud.UpdateCandidate())
                .Add("Delete a Candidate", () => Crud.DeleteCandidate())
                .Add("Main Menu",  ConsoleMenu.Close)
                 .Configure(config => { config.ItemForegroundColor = ConsoleColor.Red; });



            ConsoleMenu candidateMenu = new ConsoleMenu(args, level: 1)
              .Add("Find a Candidate", () => Crud.ReadCandidate())
              .Add("Export PDF", () => ExportToPDF.ExportPDF())
              .Add ("Main Menu",  ConsoleMenu.Close)
              .Configure(config => { config.ItemForegroundColor = ConsoleColor.Yellow; });


            ConsoleMenu MainMenu = new ConsoleMenu(args, level: 0)
                .Add("Admin's Ui", adminMenu.Show)
                .Add("Candidates Ui", candidateMenu.Show)
                .Add("Terminate", () => Environment.Exit(0))
                .Configure(config => { config.ItemForegroundColor = ConsoleColor.Magenta; });
            MainMenu.Show();
        }


        public static void DBinserts(AppDBContext appDBContext)
        {
           


            
        }

        

    }
}