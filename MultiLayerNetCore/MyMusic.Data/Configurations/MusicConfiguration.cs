using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.Configurations
{
    public class MusicConfiguration:IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .UseIdentityColumn();
            builder.Property(x=>x.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasOne(x=>x.Artist)
                .WithMany(a=>a.Musics)
                .HasForeignKey(x=>x.ArtistId);
            builder.ToTable("Musics");
        }
    }
}
