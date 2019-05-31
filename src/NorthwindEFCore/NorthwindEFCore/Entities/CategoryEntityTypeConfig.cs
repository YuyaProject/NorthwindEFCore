using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ODataCoreExample.Db.Entities
{
    public class CategoryEntityTypeConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex("CategoryName").HasName("CategoryName");

            //builder.HasData();
        }
    }
}