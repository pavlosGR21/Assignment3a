using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidCert.Models
{


    [Table("Candidates")]

    public class Candidate
    {
        [Key]
        public int CandidateNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhotoIdType { get; set; }
        public int PhotoIdNumber { get; set; }
        public DateTime PhotoIdDate { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public int Address2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public int MobileNumber { get; set; }
        public string LandlineNumnber { get; set; }

        public Candidate( string FirstName, string MiddleName, string LastName, string Gender, string Languange,
                         DateTime Birthdate, string PhotoIdType, int PhotoIdNumber, DateTime PhotoIdDate, string Email, string Address1, 
                         int Address2, string Country, string State, string City, int PostalCode, int MobileNumber, int LandlineNumber) 
        {
            FirstName = FirstName;
            MiddleName = MiddleName;
            LastName = LastName;
            Gender = Gender;
            Languange = Languange;
            Birthdate = Birthdate;
            PhotoIdType = PhotoIdType;
            PhotoIdNumber = PhotoIdNumber;
            PhotoIdDate = PhotoIdDate;
            Email = Email;
            Address1 = Address1;
            Address2 = Address2;
            Country = Country;
            State = State;
            City = City;
            PostalCode = PostalCode;
            MobileNumber = MobileNumber;
            LandlineNumber = LandlineNumber;



        }

        public Candidate()
        {
        }
    }

}
