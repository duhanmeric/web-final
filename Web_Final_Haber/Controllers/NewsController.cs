using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Final_Haber.Models;
using Web_Final_Haber.Pages;

namespace Web_Final_Haber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class NewsController : Controller
    {
        private readonly AppDbContext _context;

        public NewsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<NewsArticle> GetNews()
        {
            IEnumerable<NewsArticle> latestNews = _context.Articles
                .OrderByDescending(n => n.ArticleDate);

            return latestNews;
        }
    }
}
