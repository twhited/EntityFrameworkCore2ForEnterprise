using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Core.DomainDrivenDesign.HumanResources;

namespace OnlineStore.Core.DomainDrivenDesign.Configurations.HumanResources
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Mapping for table
            builder.ToTable("Employee", "HumanResources");

            // Set key for entity
            builder.HasKey(p => p.EmployeeID);

            // Set identity for entity (auto increment)
            builder.Property(p => p.EmployeeID).UseSqlServerIdentityColumn();

            // Set mapping for columns
            builder.Property(p => p.EmployeeID).HasColumnType("int").IsRequired();
            builder.Property(p => p.FirstName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.MiddleName).HasColumnType("varchar(25)");
            builder.Property(p => p.LastName).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.BirthDate).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.CreationUser).HasColumnType("varchar(25)").IsRequired();
            builder.Property(p => p.CreationDateTime).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastUpdateUser).HasColumnType("varchar(25)");
            builder.Property(p => p.LastUpdateDateTime).HasColumnType("datetime");

            // Set concurrency token for entity
            builder
                .Property(p => p.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
        }
    }
}
