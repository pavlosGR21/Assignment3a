using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CandidCert.Models;
using Database.Services.Data;

namespace AppUi
{
    public class Crud
    {
        static AppDBContext appDBContext = new AppDBContext();
        //CREATE
        public static void CreateCandidate()
        {

            Candidate createCand = new Candidate();

            Console.WriteLine("Enter Candidate Number");
            createCand.CandidateNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Name");
            createCand.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Middle Name");
            createCand.MiddleName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            createCand.LastName = Console.ReadLine();

            Console.WriteLine("Enter Gender");
            createCand.Gender = Console.ReadLine();

            Console.WriteLine("Enter Languange");
            createCand.Language = Console.ReadLine();

            Console.WriteLine("Enter Birthdate");
            createCand.Birthdate = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("Enter Photo Id Type");
            createCand.PhotoIdType = Console.ReadLine();

            Console.WriteLine("Enter PhotoIdNumber");
            createCand.PhotoIdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Photo Id issue Date");
            createCand.PhotoIdDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Address");
            createCand.Address1 = Console.ReadLine();

            Console.WriteLine("Enter Address Number");
            createCand.Address2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Country");
            createCand.Country = Console.ReadLine();

            Console.WriteLine("Enter State");
            createCand.State = Console.ReadLine();

            Console.WriteLine("Enter City");
            createCand.City = Console.ReadLine();

            Console.WriteLine("Enter Postal Code");
            createCand.PostalCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile Number");
            createCand.MobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Landline Number");
            createCand.LandlineNumnber = Convert.ToInt32(Console.ReadLine());

            appDBContext.SaveChanges();
        }
        //READ
        public static void ReadCandidate()
        {
            Console.WriteLine("Type Candidate's Number");
            int CandidateNumber = Convert.ToInt32(Console.ReadLine());
            Candidate readCand= appDBContext.Candidates.Find(CandidateNumber);
            Console.WriteLine(readCand);
        }
        //UPDATE
        public static void UpdateCandidate()
        {
            Console.WriteLine("Type Candidate's Number to update Information");
            int CandidateNumber = Convert.ToInt32(Console.ReadLine());
            Candidate updateCandidate = appDBContext.Candidates.Find(CandidateNumber);
            Console.WriteLine(updateCandidate);
            Console.WriteLine("Choose the an option's number you want to make a change:\n1: First Name\n2 Middle Name");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 0: Console.WriteLine("First Name");
                    updateCandidate.FirstName= Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                case 1:
                    Console.WriteLine("Middle Name");
                    updateCandidate.MiddleName = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Last Name");
                    updateCandidate.LastName = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Gender");
                    updateCandidate.Gender = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Languange");
                    updateCandidate.Language = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("Birthdate");
                    updateCandidate.Birthdate = Convert.ToDateTime(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 7:
                    Console.WriteLine("Photo Id Type");
                    updateCandidate.PhotoIdType = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 8:
                    Console.WriteLine("Photo Id Number");
                    updateCandidate.PhotoIdNumber = Convert.ToInt32(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 9:
                    Console.WriteLine("Photo Id Date");
                    updateCandidate.PhotoIdDate = Convert.ToDateTime(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 10:
                    Console.WriteLine("Email");
                    updateCandidate.Email = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 11:
                    Console.WriteLine("Address");
                    updateCandidate.Address1 = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 12:
                    Console.WriteLine("Address Number");
                    updateCandidate.Address2 = Convert.ToInt32(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 13:
                    Console.WriteLine("Country");
                    updateCandidate.Country = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 14:
                    Console.WriteLine("State");
                    updateCandidate.State = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 15:
                    Console.WriteLine("City");
                    updateCandidate.City = Console.ReadLine();
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 16:
                    Console.WriteLine("Postal Code");
                    updateCandidate.PostalCode = Convert.ToInt32(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 17:
                    Console.WriteLine("Mobile Number");
                    updateCandidate.MobileNumber = Convert.ToInt64(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();
                    break;

                    case 18:
                    Console.WriteLine("Landline Number");
                    updateCandidate.LandlineNumnber = Convert.ToInt32(Console.ReadLine());
                    appDBContext.Candidates.AddOrUpdate(updateCandidate);
                    appDBContext.SaveChanges();
                    Console.WriteLine(updateCandidate);
                    Console.ReadLine();

                    appDBContext.SaveChanges();
                    break;

                    case 19:
                    return;
                   

            }

            
        }




        //DELETE
        public static void DeleteCandidate()
        {
            Console.WriteLine("Type Candidate's number you want to Delete.");
            int CandidateNumber = Convert.ToInt32(Console.ReadLine());
            Candidate readcand = appDBContext.Candidates.Find(CandidateNumber);
            appDBContext.Candidates.Remove(readcand);
        }

       
    }
}
