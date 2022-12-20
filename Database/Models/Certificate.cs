using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConfig.Models
{

    [Table("Certificates")]
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual CertTitle CertTitle { get; set; }
        public int AssessmentTestCode { get; set; }
        public DateTime ExaminationDate { get; set; }
        public DateTime ScoreReportDate { get; set; }
        public int MaximumScore { get; set; }
        public string AssessmentResultLabel { get; set; }
        public int PercentageScore { get; set; } = 100;

       
        public Certificate(  CertTitle certTitle, Candidate candidate ,int assessmentTestCode, DateTime examinationDate, DateTime scoreReportDate, int maximumScore, string assessmentResultLabel, int percentageScore)
        {
            
           
            CertTitle = certTitle;
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
