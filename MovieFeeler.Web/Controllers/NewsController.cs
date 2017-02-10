using MovieFeeler.Manager.Imp;
using MovieFeeler.Manager.Interfaces;
using MovieFeeler.Model;
using MovieFeeler.Rest.Client;
using MovieFeeler.Rest.Client.Interfaces;
using MovieFeeler.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFeeler.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsManager _newsMgr = null;
        public NewsController()
        {
            _newsMgr = new NewsManager();
        }

        public ActionResult Index(int? page = 1)
        {
            NewsViewModel model = new NewsViewModel();
            model.NewsPaged = new MvcPaging.PagedList<News>(_newsMgr.GetNewsQueryable(), page.Value, 20);            
            return View(model);
        }

        public ActionResult Detail(int id)
        {
            NewsViewModel model = new NewsViewModel();
            model.News = _newsMgr.GetNews();
            model.Newsdetail = _newsMgr.Get(id);
            return View(model);
        }
    }
}
