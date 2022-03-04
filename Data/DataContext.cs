using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject_201810088.Models;

namespace FinalProject_201810088.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Manga> Mangas { get; set; }

        public DbSet<Drawer> Drawers { get; set; }

        public DbSet<Work> Works { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manga>().HasData(
                new Manga { MangaId = 1, Name = "Tokyo Ghoul", NoOfEpisodes = 24, Description = "it is a 24 Episodes anime", },
                new Manga { MangaId = 2, Name = "One Piece", NoOfEpisodes = 32, Description = "it is a 32 Episodes anime", },
                new Manga { MangaId = 3, Name = "Detective Conan", NoOfEpisodes = 40, Description = "it is a 40 Episodes anime", },
                new Manga { MangaId = 4, Name = "Dragon Ball", NoOfEpisodes = 60, Description = "it is a 60 Episodes anime", },
                new Manga { MangaId = 5, Name = "Death Note", NoOfEpisodes = 12, Description = "it is a 12 Episodes anime", }
                );

            modelBuilder.Entity<Drawer>().HasData(
                new Drawer { DrawerId = 1, Name = "Sui Ishida", CostPerManga = 120, EmailAddress = "Drawer1@gmail.com", PhoneNumber = "+962779783215", ProfilePicture = "/Images/Drawer.jpg" },
                new Drawer { DrawerId = 2, Name = "Eiichiro Oda", CostPerManga = 70, EmailAddress = "Drawer2@gmail.com", PhoneNumber = "+962779783220", ProfilePicture = "/Images/Drawer.jpg" },
                new Drawer { DrawerId = 3, Name = "Gosho Aoyama", CostPerManga = 35, EmailAddress = "Drawer3@gmail.com", PhoneNumber = "+962779783235", ProfilePicture = "/Images/Drawer.jpg" },
                new Drawer { DrawerId = 4, Name = "Akira Toriyama", CostPerManga = 40, EmailAddress = "Drawer4@gmail.com", PhoneNumber = "+962779783240", ProfilePicture = "/Images/Drawer.jpg" },
                new Drawer { DrawerId = 5, Name = "Tsugumi Ohba", CostPerManga = 55, EmailAddress = "Drawer5@gmail.com", PhoneNumber = "+962779783255", ProfilePicture = "/Images/Drawer.jpg" }
            );

            modelBuilder.Entity<Work>().HasData(
                new Work { WorkId = 1, DrawerId = 1, MangaId = 1, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(-2), AirsAt = DateTime.Now.AddHours(5), Status = StatusType.OnProgress },
                new Work { WorkId = 2, DrawerId = 2, MangaId = 2, StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(2), AirsAt = DateTime.Now.AddHours(8), Status = StatusType.Finished },
                new Work { WorkId = 3, DrawerId = 3, MangaId = 3, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(10), AirsAt = DateTime.Now.AddHours(-3), Status = StatusType.NotStarted },
                new Work { WorkId = 4, DrawerId = 3, MangaId = 1, StartDate = DateTime.Now.AddDays(7), EndDate = DateTime.Now.AddDays(15), AirsAt = DateTime.Now.AddHours(2), Status = StatusType.OnProgress },
                new Work { WorkId = 5, DrawerId = 1, MangaId = 3, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(15), AirsAt = DateTime.Now.AddHours(1), Status = StatusType.NotStarted },
                new Work { WorkId = 6, DrawerId = 4, MangaId = 4, StartDate = DateTime.Now.AddDays(-7), EndDate = DateTime.Now.AddDays(14), AirsAt = DateTime.Now.AddHours(4), Status = StatusType.NotStarted },
                new Work { WorkId = 7, DrawerId = 5, MangaId = 4, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(3), AirsAt = DateTime.Now.AddHours(7), Status = StatusType.Finished },
                new Work { WorkId = 8, DrawerId = 1, MangaId = 5, StartDate = DateTime.Now.AddDays(-8), EndDate = DateTime.Now.AddDays(-3), AirsAt = DateTime.Now.AddHours(5), Status = StatusType.OnProgress }
            );
        }
    }
}
