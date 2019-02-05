using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopshelfExample.Logic;
using TopshelfExample.Web.ViewModels.Home;

namespace TopshelfExample.Web.Controllers
{
    public class HomeController : Controller
    {
        private Downloader _downloader = new Downloader();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            return View(new DownloadViewModel());
        }

        [HttpPost]
        public ActionResult Download(DownloadViewModel viewModel)
        {
            if(ModelState.IsValid == false)
            {
                return View(viewModel);
            }

            BackgroundJob.Enqueue(() => _downloader.Download(viewModel.Url));

            return RedirectToAction("Download");
        }
    }
}