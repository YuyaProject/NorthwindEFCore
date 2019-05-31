using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ODataCoreExample.Db.Entities
{
    public class CustomerEntityTypeConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex("CategoryName").HasName("CategoryName");

            //builder.HasData();
        }
    }
}