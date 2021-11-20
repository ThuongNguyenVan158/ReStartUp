using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReStartUp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStartUp.Data.Configurations
{
    public class EmailConfiguration: IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            //builder.ToTable("EMAIL");
            builder.HasKey(email => email.Id);
            builder.Property(Em => Em.email).IsRequired();
        }
    }
}
