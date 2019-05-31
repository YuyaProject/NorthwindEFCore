using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ODataCoreExample.Db.Entities
{
    public class CategoryEntityTypeConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //CREATE TABLE "Categories" (
            builder.ToTable("Categories");

            //	"CategoryID" "int" IDENTITY(1, 1) NOT NULL,
            //	CONSTRAINT "PK_Categories" PRIMARY KEY  CLUSTERED
            //    (
            //		"CategoryID"
            //	)
            builder.HasKey(m => m.Id).HasName("CategoryID");
            //	"CategoryName" nvarchar(15) NOT NULL,
            builder.Property(m => m.CategoryName).IsRequired().HasMaxLength(15);
            //	"Description" "ntext" NULL ,
            builder.Property(m => m.Description).HasMaxLength(int.MaxValue);
            //	"Picture" "image" NULL ,
            builder.Property(m => m.Picture).HasMaxLength(int.MaxValue);
            //)

            // CREATE  INDEX "CategoryName" ON "dbo"."Categories"("CategoryName")
            builder.HasIndex("CategoryName").HasName("CategoryName");

            //builder.HasData();
        }
    }
}