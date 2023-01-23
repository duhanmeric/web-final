using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Web_Final_Haber.Models;

namespace Web_Final_Haber.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Articles.Any())
            {
                context.Articles.AddRange(
                new NewsArticle
                {
                    ArticleTitle = "Düzcedeki deprem herkesi korkuttu!",
                    ArticleBody = "Kandilli Rasathanesi verilerine göre, Düzce'nin Gölyaka ilçesinde 6.1 büyüklüğünde bir deprem meydana geldi.\r\n\r\nDepremin derinliği 4.5 kilometre olarak ölçüldü.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2022/12/12/2011327/kapak_161751.jpg",
                    ArticleDate = DateTime.Now,
                },
                new NewsArticle
                {
                    ArticleTitle = "Ronaldo yeniden Şampiyonlar Ligi'nde oynayabilir! Sözleşmesindeki özel madde...",
                    ArticleBody = "Suudi Arabistan ekibi Al Nassr'a transfer olan Portekizli yıldız Cristiano Ronaldo'nun sözleşmesinde özel bir madde olduğu iddia edildi. Bu maddeye göre Ronaldo yeniden Şampiyonlar Ligi'nde oynayabilir. İngiltere Premier Lig ekibi Manchester United'ın sözleşmesini feshettiği Portekizli Cristiano Ronaldo büyük bir sürprize imza atarak Suudi Arabistan ekibi Al Nassr ile anlaşma sağladı.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2023/1/3/2017932/kapak_095803.jpg",
                    ArticleDate = DateTime.Now,
                },
                new NewsArticle
                {
                    ArticleTitle = "İstanbul Boğazı tek yönlü gemi trafiğine açıldı",
                    ArticleBody = "İstanbul'da etkili olan yoğun sis nedeniyle 1 Ocak'tan beri kapalı olan İstanbul Boğazı'ndaki gemi trafiği, güney-kuzey yönlü olarak açıldı. Kıyı Emniyeti Genel Müdürlüğü'nün internet sitesinden yapılan duyuruda, İstanbul Boğazı'nda gemi trafiğinin güney-kuzey yönlü olarak saat 11.40 itibarıyla açıldığı kaydedildi.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2023/1/3/2018000/kapak_121943.jpg",
                    ArticleDate = DateTime.Now,
                },
                new NewsArticle
                {
                    ArticleTitle = "Küçükçekmece gölünün MR'ı çekildi: Kaybediyoruz!",
                    ArticleBody = "İstanbul'da etkili olan yoğun sis nedeniyle 1 Ocak'tan beri kapalı olan İstanbul Boğazı'ndaki gemi trafiği, güney-kuzey yönlü olarak açıldı. Kıyı Emniyeti Genel Müdürlüğü'nün internet sitesinden yapılan duyuruda, İstanbul Boğazı'nda gemi trafiğinin güney-kuzey yönlü olarak saat 11.40 itibarıyla açıldığı kaydedildi.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2023/1/3/111024637-88e21907-0962-4eb5-acb2-cd88162e253147856375.jpg",
                    ArticleDate = DateTime.Now,
                },
                new NewsArticle
                {
                    ArticleTitle = "Premier Lig'de Liverpool'dan yeni yıla kötü başlangıç",
                    ArticleBody = "Alman teknik direktör Jürgen Klopp yönetimindeki Liverpool, İngiltere Premier Lig'in 19. haftasında deplasmanda konuk olduğu Brentford'a 3-1 mağlup oldu.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2023/1/2/2017839/kapak_223932.jpg",
                    ArticleDate = DateTime.Now,
                },
                new NewsArticle
                {
                    ArticleTitle = "Covid-19 vaka sayısı düşüyor, grip artıyor",
                    ArticleBody = "Antalya İl Sağlık Müdürü Opr. Dr. İsmail Başıbüyük, Covid-19'un eski yıkıcı ve tahrip edici etkisinin ortadan kalktığını, günlük vaka sayısının 10-15'e kadar düştüğünü söyledi. Dr. Başıbüyük, son dönemde artan mevsimsel grip vakalarına karşı korunmak için de 'maske-mesafe-hijyen' kurallarının uygulanmasını ve risk grubundakilerin mutlaka aşılarını yaptırmasını istedi.",
                    ArticleAuthor = "Meriç Korkmaz",
                    ArticleCover = "https://www.cumhuriyet.com.tr/Archive/2023/1/2/2017585/kapak_094407.jpg",
                    ArticleDate = DateTime.Now,
                });
                context.SaveChanges();
            }
        }
    }
}
