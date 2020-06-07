using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EF.Core.Data;

namespace EF.Data.Mapping
{
    class BoatMap : EntityTypeConfiguration<Boat>
    {
        public BoatMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.BoatName).IsRequired();
            Property(t => t.CustomerName).IsRequired();
            Property(t => t.Quantity).IsRequired();
            Property(t => t.Rentdate).IsRequired();
            Property(t => t.price).IsRequired();
            ToTable("Boats");
        }
    }
}
