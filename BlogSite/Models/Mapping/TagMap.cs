using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace BlogSite.Models.Mapping
{
    public class TagMap : EntityTypeConfiguration<Tag>
    {
        public TagMap()
        {
            // Primary Key
            this.HasKey(t => t.TagId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tag");
            this.Property(t => t.TagId).HasColumnName("TagId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
