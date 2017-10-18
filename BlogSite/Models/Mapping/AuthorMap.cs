using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlogSite.Models.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            // Primary Key
            this.HasKey(t => t.AuthorId);

            // Properties
            this.Property(t => t.AuthorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MailAdres)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Author");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Surname).HasColumnName("Surname");
            this.Property(t => t.MailAdres).HasColumnName("MailAdres");
            this.Property(t => t.Detail).HasColumnName("Detail");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.ImageId).HasColumnName("ImageId");

            // Relationships
            this.HasMany(t => t.Users)
                .WithMany(t => t.Authors)
                .Map(m =>
                    {
                        m.ToTable("AuthorTrack");
                        m.MapLeftKey("AuthorId");
                        m.MapRightKey("UserId");
                    });

            this.HasOptional(t => t.Image)
                .WithMany(t => t.Authors)
                .HasForeignKey(d => d.ImageId);

        }
    }
}
