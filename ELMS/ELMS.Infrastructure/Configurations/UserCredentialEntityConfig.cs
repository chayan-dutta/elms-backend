using ELMS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ELMS.Infrastructure.Configurations;

public class UserCredentialEntityConfig : IEntityTypeConfiguration<UserCredentialEntity>
{
    public void Configure(EntityTypeBuilder<UserCredentialEntity> builder)
    {
        builder
            .HasOne<EmployeeEntity>()
            .WithOne()
            .HasForeignKey<UserCredentialEntity>(uc => uc.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
