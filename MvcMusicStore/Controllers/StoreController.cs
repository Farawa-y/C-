using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index() => "hello from store.index";

        public string Browse()
        {
            return "hello from store.browse";
        }

        public string Detail() => "hello from store.detail";
    }
}