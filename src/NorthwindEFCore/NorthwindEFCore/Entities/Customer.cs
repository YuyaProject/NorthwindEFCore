using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataCoreExample.Db.Entities
{
    //CREATE TABLE "Customers" (
    [Table("Customers")]
    public class Customer : Entity<string>
    {
        //	"CustomerID" nchar(5) NOT NULL,
        [StringLength(5, MinimumLength = 5)]
        [Key]
        public override string Id { get; set; }

        //	"CompanyName" nvarchar(40) NOT NULL,
        [StringLength(40), Required]
        public string CompanyName { get; set; }

        //	"ContactName" nvarchar(30) NULL ,
        [StringLength(30)]
        public string ContactName { get; set; }

        //	"ContactTitle" nvarchar(30) NULL ,
        [StringLength(30)]
        public string ContactTitle { get; set; }

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

        //	"Phone" nvarchar(24) NULL ,
        [StringLength(24)]
        public string Phone { get; set; }

        //	"Fax" nvarchar(24) NULL ,
        [StringLength(24)]
        public string Fax { get; set; }

        //	CONSTRAINT "PK_Customers" PRIMARY KEY  CLUSTERED
        //    (
        //		"CustomerID"
        //	)
        //)
        //GO
        // CREATE  INDEX "City" ON "dbo"."Customers"("City")
        //GO
        // CREATE  INDEX "CompanyName" ON "dbo"."Customers"("CompanyName")
        //GO
        // CREATE  INDEX "PostalCode" ON "dbo"."Customers"("PostalCode")
        //GO
        // CREATE  INDEX "Region" ON "dbo"."Customers"("Region")
        //GO
    }
}