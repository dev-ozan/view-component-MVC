using Microsoft.EntityFrameworkCore;

namespace YazarVeAlintilari.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }

        public DbSet<Yazar> Yazars => Set<Yazar>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yazar>().HasData(
                 new Yazar { Id = 1, Soz = "Başarmak için ilk adım atmalısınız.", YazarAdi = "Zig Ziglar" },
                 new Yazar { Id = 2, Soz = "Sadece bugünü değil, yarını da düşünerek hareket edin.", YazarAdi = "Albert Einstein" },
                 new Yazar { Id = 3, Soz = "Başkalarının sınırlamaları sizi durduramaz, yeter ki inanın.", YazarAdi = "Roy T. Bennett" },
                 new Yazar { Id = 4, Soz = "Başarı, en çok denemekten korkmayanların elindedir.", YazarAdi = "Robert Kiyosaki" },
                 new Yazar { Id = 5, Soz = "Her adım, hedefe bir adım daha yaklaşmaktır.", YazarAdi = "Confucius" },
                 new Yazar { Id = 6, Soz = "Engeller sadece hedefe giden yolda ki yönlendirmelerdir.", YazarAdi = "Barbara Sher" },
                 new Yazar { Id = 7, Soz = "Zorluklar, gerçek potansiyelinizi ortaya çıkarmak için fırsatlardır.", YazarAdi = "Malcolm X" },
                 new Yazar { Id = 8, Soz = "Başkalarının başarısızlıklarından değil, kendi azminizden etkilenin.", YazarAdi = "Denis Waitley" },
                 new Yazar { Id = 9, Soz = "Başlamak için mükemmel bir zaman yoktur, zamanı kendiniz yaratırsınız.", YazarAdi = "George Bernard Shaw" },
                 new Yazar { Id = 10, Soz = "Hayal ettiğiniz yaşamı yaşamak için şimdi adım atın.", YazarAdi = "Sinan Taşyapar" }
                 );
        }

    }
}
