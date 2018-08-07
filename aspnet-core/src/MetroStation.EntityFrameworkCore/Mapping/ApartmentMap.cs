using System;
using MetroStation.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroStation.Mapping
{
    public class ApartmentMap : EntityMappingConfiguration<Apartment>
    {
        public override void Map(EntityTypeBuilder<Apartment> b)
        {
            b.ToTable("Apartment");
        }
    }
}
