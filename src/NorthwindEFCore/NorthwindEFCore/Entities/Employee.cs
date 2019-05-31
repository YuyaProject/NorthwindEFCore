using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataCoreExample.Db.Entities
{
    //CREATE TABLE "Employees" (
    [Table("Employees")]
    public class Employee : Entity<int>
    {
        //	"EmployeeID" "int" IDENTITY(1, 1) NOT NULL,

        //	"LastName" nvarchar(20) NOT NULL,
        [StringLength(20), Required]
        public string LastName { get; set; }

        //	"FirstName" nvarchar(10) NOT NULL,
        [StringLength(10), Required]
        public string FirstName { get; set; }

        //	"Title" nvarchar(30) NULL ,
        [StringLength(30)]
        public string Title { get; set; }

        //	"TitleOfCourtesy" nvarchar(25) NULL ,
        [StringLength(25)]
        public string TitleOfCourtesy { get; set; }

        //	"BirthDate" "datetime" NULL ,
        public DateTime? BirthDate { get; set; }

        //	"HireDate" "datetime" NULL ,
        public DateTime? HireDate { get; set; }

        //	"Address" nvarchar(60) NULL ,
        [StringLength(60)]
        public string Address { get; set; }

        //	"City" nvarchar(15) NULL ,
        [StringLength(15)]
        public string City { get; set; }

        //	"Region" nvarchar(15) NULL ,
        [StringLength(15)]
        public string Region { get; set; }

        //	"PostalCode" nvarchar(10) NULL ,
        [StringLength(10)]
        public string PostalCode { get; set; }

        //	"Country" nvarchar(15) NULL ,
        [StringLength(15)]
        public string Country { get; set; }

        //	"HomePhone" nvarchar(24) NULL ,
        [StringLength(24)]
        public string HomePhone { get; set; }

        //	"Extension" nvarchar(4) NULL ,
        [StringLength(4)]
        public string Extension { get; set; }

        //	"Photo" "image" NULL ,
        public byte[] Photo { get; set; }

        //	"Notes" "ntext" NULL ,
        [StringLength(int.MaxValue)]
        public string Notes { get; set; }

        //	"ReportsTo" "int" NULL ,
        [Column("ReportsTo")]
        public int? ReportsToId { get; set; }
        public Employee ReportsTo { get; set; }

        //	"PhotoPath" nvarchar(255) NULL ,
        [StringLength(255)]
        public string PhotoPath { get; set; }

        //	CONSTRAINT "PK_Employees" PRIMARY KEY  CLUSTERED
        //    (
        //		"EmployeeID"
        //	),
        //	CONSTRAINT "FK_Employees_Employees" FOREIGN KEY
        //    (
        //		"ReportsTo"
        //	) REFERENCES "dbo"."Employees" (
        //		"EmployeeID"
        //	),
        //	CONSTRAINT "CK_Birthdate" CHECK(BirthDate<getdate())
        //)
        //GO
        // CREATE  INDEX "LastName" ON "dbo"."Employees"("LastName")
        //GO
        // CREATE  INDEX "PostalCode" ON "dbo"."Employees"("PostalCode")
        //GO
    }
}