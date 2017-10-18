using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlogSite.Models.Mapping
{
    public class JournalMap : EntityTypeConfiguration<Journal>
    {
        public JournalMap()
        {
            // Primary Key
            this.HasKey(t => t.JournalId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContentPart)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Journal");
            this.Property(t => t.JournalId).HasColumnName("JournalId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ContentPart).HasColumnName("ContentPart");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.DisplayCount).HasColumnName("DisplayCount");
            this.Property(t => t.LikeCount).HasColumnName("LikeCount");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.ImageId).HasColumnName("ImageId");

            // Relationships
            this.HasMany(t => t.Tags)
                .WithMany(t => t.Journals)
                .Map(m =>
                    {
                        m.ToTable("JournalTag");
                        m.MapLeftKey("JournalId");
                        m.MapRightKey("TagId");
                    });

            this.HasRequired(t => t.Author)
                .WithMany(t => t.Journals)
                .HasForeignKey(d => d.AuthorId);
            this.HasRequired(t => t.Category)
                .WithMany(t => t.Journals)
                .HasForeignKey(d => d.CategoryId);
            this.HasOptional(t => t.Image)
                .WithMany(t => t.Journals)
                .HasForeignKey(d => d.ImageId);

        }
    }
}
