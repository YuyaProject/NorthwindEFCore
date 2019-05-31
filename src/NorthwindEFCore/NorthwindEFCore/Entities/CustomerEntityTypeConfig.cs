using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ODataCoreExample.Db.Entities
{
    public class CustomerEntityTypeConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //CREATE TABLE "Customers" (
            builder.ToTable("Customers");

            //	"CustomerID" nchar(5) NOT NULL,
            //	CONSTRAINT "PK_Customers" PRIMARY KEY  CLUSTERED
            //    (
            //		"CustomerID"
            //	)
            builder.HasKey(m => m.Id).HasName("CustomerID");
            builder.Property(m => m.Id).HasColumnName("CustomerID").HasMaxLength(5).IsRequired();

            //	"CompanyName" nvarchar(40) NOT NULL,
            builder.Property(m => m.CompanyName).HasMaxLength(40).IsRequired();
            builder.HasIndex("CompanyName").HasName("CompanyName");

            //	"ContactName" nvarchar(30) NULL ,
            builder.Property(m => m.ContactName).HasMaxLength(30);

            //	"ContactTitle" nvarchar(30) NULL ,
            builder.Property(m => m.ContactTitle).HasMaxLength(30);
            
            //	"Address" nvarchar(60) NULL ,
            builder.Property(m => m.Address).HasMaxLength(60);
            
            //	"City" nvarchar(15) NULL ,
            builder.Property(m => m.City).HasMaxLength(15);
            builder.HasIndex("City").HasName("City");

            //	"Region" nvarchar(15) NULL ,
            builder.Property(m => m.Region).HasMaxLength(15);
            builder.HasIndex("Region").HasName("Region");

            //	"PostalCode" nvarchar(10) NULL ,
            builder.Property(m => m.PostalCode).HasMaxLength(10);
            builder.HasIndex("PostalCode").HasName("PostalCode");

            //	"Country" nvarchar(15) NULL ,
            builder.Property(m => m.Country).HasMaxLength(15);
            
            //	"Phone" nvarchar(24) NULL ,
            builder.Property(m => m.Phone).HasMaxLength(24);

            //	"Fax" nvarchar(24) NULL ,
            builder.Property(m => m.Fax).HasMaxLength(24);

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

            //builder.HasData();
        }
    }
}