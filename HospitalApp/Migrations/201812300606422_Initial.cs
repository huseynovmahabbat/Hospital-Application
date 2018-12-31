namespace HospitalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 30),
                        PIN = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                        SpecialtyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DoctorSpecialties", t => t.SpecialtyId, cascadeDelete: true)
                .Index(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.PatientNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        RecieptTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.DoctorSpecialties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "SpecialtyId", "dbo.DoctorSpecialties");
            DropForeignKey("dbo.PatientNotes", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientNotes", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.Patients", new[] { "Email" });
            DropIndex("dbo.PatientNotes", new[] { "PatientId" });
            DropIndex("dbo.PatientNotes", new[] { "DoctorId" });
            DropIndex("dbo.Doctors", new[] { "SpecialtyId" });
            DropTable("dbo.DoctorSpecialties");
            DropTable("dbo.Patients");
            DropTable("dbo.PatientNotes");
            DropTable("dbo.Doctors");
        }
    }
}
