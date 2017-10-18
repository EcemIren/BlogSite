using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace BlogSite.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentId);

            // Properties
            this.Property(t => t.CommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CommentContent)
                .IsRequired()
                .HasMaxLength(1500);

            this.Property(t => t.NameSurname)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Comment");
            this.Property(t => t.CommentId).HasColumnName("CommentId");
            this.Property(t => t.CommentContent).HasColumnName("CommentContent");
            this.Property(t => t.JournalId).HasColumnName("JournalId");
            this.Property(t => t.CreationDate).HasColumnName("CreationDate");
            this.Property(t => t.NameSurname).HasColumnName("NameSurname");
            this.Property(t => t.LikeCount).HasColumnName("LikeCount");

            // Relationships
            this.HasRequired(t => t.Journal)
                .WithMany(t => t.Comments)
                .HasForeignKey(d => d.JournalId);

        }
    }
}
