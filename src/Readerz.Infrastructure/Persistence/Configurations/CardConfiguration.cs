﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Readerz.Domain.Entities;

namespace Readerz.Infrastructure.Persistence.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.Property(e => e.Back)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Front)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}