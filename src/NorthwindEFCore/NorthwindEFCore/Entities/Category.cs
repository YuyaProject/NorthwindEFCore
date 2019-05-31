using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataCoreExample.Db.Entities
{
    //CREATE TABLE "Categories" (
    [Table("Categories")]
    public class Category : Entity<int>
    {
        //	"CategoryID" "int" IDENTITY(1, 1) NOT NULL,
        //	"CategoryName" nvarchar(15) NOT NULL,
        [StringLength(15), Required]
        public string CategoryName { get; set; }

        //	"Description" "ntext" NULL ,
        [StringLength(int.MaxValue)]
        public string Description { get; set; }

        //	"Picture" "image" NULL ,
        public byte[] Picture { get; set; }

        //	CONSTRAINT "PK_Categories" PRIMARY KEY  CLUSTERED
        //    (
        //		"CategoryID"
        //	)
        //)
        //GO
        // CREATE  INDEX "CategoryName" ON "dbo"."Categories"("CategoryName")
        //GO
    }
}