namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateNumber = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Language = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        PhotoIdType = c.String(),
                        PhotoIdNumber = c.Int(nullable: false),
                        PhotoIdDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Address1 = c.String(),
                        Address2 = c.Int(nullable: false),
                        Country = c.String(),
                        State = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        MobileNumber = c.Long(nullable: false),
                        LandlineNumnber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CandidateNumber);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        CertificateId = c.Int(nullable: false, identity: true),
                        AssessmentTestCode = c.Int(nullable: false),
                        ExaminationDate = c.DateTime(nullable: false),
                        ScoreReportDate = c.DateTime(nullable: false),
                        MaximumScore = c.Int(nullable: false),
                        AssessmentResultLabel = c.String(),
                        PercentageScore = c.Int(nullable: false),
                        Candidate_CandidateNumber = c.Int(),
                        CertTitle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CertificateId)
                .ForeignKey("dbo.Candidates", t => t.Candidate_CandidateNumber)
                .ForeignKey("dbo.CertTitle", t => t.CertTitle_Id)
                .Index(t => t.Candidate_CandidateNumber)
                .Index(t => t.CertTitle_Id);
            
            CreateTable(
                "dbo.CertTitle",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "CertTitle_Id", "dbo.CertTitle");
            DropForeignKey("dbo.Certificates", "Candidate_CandidateNumber", "dbo.Candidates");
            DropIndex("dbo.Certificates", new[] { "CertTitle_Id" });
            DropIndex("dbo.Certificates", new[] { "Candidate_CandidateNumber" });
            DropTable("dbo.CertTitle");
            DropTable("dbo.Certificates");
            DropTable("dbo.Candidates");
        }
    }
}
