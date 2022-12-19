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
        public long MobileNumber { get; set; }
        public int LandlineNumnber { get; set; }

        public Candidate( string firstName, string middleName, string lastName, string gender, string languange,
                         DateTime birthdate, string photoIdType, int photoIdNumber, DateTime photoIdDate, string email, string address1, 
                         int address2, string country, string state, string city, int postalCode, long mobileNumber, int landlineNumber) 
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            Language = languange;
            Birthdate = birthdate;
            PhotoIdType = photoIdType;
            PhotoIdNumber = photoIdNumber;
            PhotoIdDate = photoIdDate;
            Email = email;
            Address1 = address1;
            Address2 = address2;
            Country = country;
            State = state;
            City = city;
            PostalCode = postalCode;
            MobileNumber = mobileNumber;
            LandlineNumnber= landlineNumber;



        }

        public Candidate()
        {

        }
    }

}
