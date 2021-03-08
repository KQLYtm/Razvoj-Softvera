using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sppo.Areas.Identity.Data;
using sppo.Data;
using sppo.Service;
using SPPO.EntityModels;

namespace sppo.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly MyContext _context;
        private readonly UserManager<Profile> _userManager;
        INotiService _nootiService = null;
        List<Notification> _oNotifications = new List<Notification>();

        public NotificationsController(INotiService notiService,MyContext context, UserManager<Profile> userManager)
        {
            _nootiService = notiService;
            _context = context;
            _userManager = userManager;
        }
        public IActionResult AllNotifications()
        {
            return View();
        }
        public JsonResult GetNotifications(bool bIsGetOnlyUnread=false)
        {
            var nToUserId = _userManager.GetUserId(User);
            //int nToUserId = 2;
            //int.TryParse(a, out nToUserId);
            _oNotifications = new List<Notification>();
            _oNotifications = _nootiService.GetNotifications(nToUserId, bIsGetOnlyUnread);
            return Json(_oNotifications);
        }
    }
}
