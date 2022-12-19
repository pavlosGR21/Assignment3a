using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidCert.Models
{

    [Table("Certificates")]
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }
        [Required]
        [ForeignKey("Title")]
        public int CandidateNumber { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual CertTitles CertTitles { get; set; }
        public string Title { get; set; }
        [Required]
        [ForeignKey("CandidateNumber")]
       public int AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public int MaximumScore { get; set; }
        public string AssessmentResultLabel { get; set; }
        public int PercentageScore { get; set; } = 100;

       
        public Certificate(  CertTitles certTitles, int candidateNumber, Candidate candidate int assessmentTestCode, DateTime examinationDate, DateTime scoreReportDate, int maximumScore, string assessmentResultLabel, int percentageScore)
        {
            
           
            CertTitles = certTitles;
            CandidateNumber = candidateNumber;
            Candidate = candidate;
            AssessmentTestCode = assessmentTestCode;
            ExaminationDate = examinationDate;
            ScoreReportDate = scoreReportDate;
            MaximumScore = maximumScore;
            AssessmentResultLabel = assessmentResultLabel;
            PercentageScore = percentageScore;
        }
        public Certificate() 
        { 
        }
    }
}
