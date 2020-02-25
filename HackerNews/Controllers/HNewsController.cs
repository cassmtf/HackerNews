using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackerNews.Models;
using HackerNews.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackerNews.Controllers
{
    [Route("api/[controller]")]
    public class HNewsController : Controller
    {
        private readonly IOptions<AppSettingsModel> appSettings;

        public HNewsController(IOptions<AppSettingsModel> app)
        {
            appSettings = app;

        }

        /// <summary>
        /// Obtains the best stories from the Hacker News API and returns specific information
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<BestStoriesModel>> getBestStories()
        {
            // Init the search text to empty
            ViewBag.newsSearchText = "";
            // Get all the best stories
            var bestStoriesIDs = await HackerNewsService.GetBestStoriesIDs(appSettings);
            var bestStories = await HackerNewsService.GetBestStories(bestStoriesIDs, appSettings);
            return bestStories.OrderByDescending(i => i.time).Take(20).ToList();

        }

    }

}
