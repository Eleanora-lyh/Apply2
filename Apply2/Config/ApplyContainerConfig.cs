using Apply2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Apply2.Config
{
    public class ApplyContainerConfig : IEntityTypeConfiguration<ApplyContainer>
    {
        public void Configure(EntityTypeBuilder<ApplyContainer> builder)
        {
            builder.ToTable("T_Applys");
            builder.Property(b => b.Location).HasMaxLength(20).IsRequired();
            builder.Property(b => b.Mail).HasMaxLength(20);
            //builder.ToTable("T_Dogs");
        }
    }
}
