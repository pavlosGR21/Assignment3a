namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
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
                        MobileNumber = c.Int(nullable: false),
                        LandlineNumnber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CandidateNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
