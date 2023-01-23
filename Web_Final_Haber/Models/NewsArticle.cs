using System.ComponentModel.DataAnnotations;

namespace Web_Final_Haber.Models
{
    public class NewsArticle
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleCover { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleBody { get; set; }
        public string ArticleAuthor { get; set; }
        public DateTime ArticleDate{ get; set; }
    }
}
