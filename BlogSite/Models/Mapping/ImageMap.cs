using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlogSite.Models.Mapping
{
    public class ImageMap : EntityTypeConfiguration<Image>
    {
        public ImageMap()
        {
            // Primary Key
            this.HasKey(t => t.ImageId);

            // Properties
            this.Property(t => t.SmallSize)
                .HasMaxLength(250);

            this.Property(t => t.MediumSize)
                .HasMaxLength(250);

            this.Property(t => t.BigSize)
                .HasMaxLength(250);

            this.Property(t => t.Video)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Image");
            this.Property(t => t.ImageId).HasColumnName("ImageId");
            this.Property(t => t.SmallSize).HasColumnName("SmallSize");
            this.Property(t => t.MediumSize).HasColumnName("MediumSize");
            this.Property(t => t.BigSize).HasColumnName("BigSize");
            this.Property(t => t.Video).HasColumnName("Video");
            this.Property(t => t.MakaleId).HasColumnName("MakaleId");

            // Relationships
            this.HasOptional(t => t.Journal)
                .WithMany(t => t.Images)
                .HasForeignKey(d => d.MakaleId);

        }
    }
}
