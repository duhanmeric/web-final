using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Final_Haber.Models;

namespace Web_Final_Haber.Components
{
    public class LatestNewsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public LatestNewsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<NewsArticle> latestNews = await _context.Articles
                .OrderByDescending(n => n.ArticleDate)
                .ToListAsync();

            return View(latestNews);
        }
    }
}