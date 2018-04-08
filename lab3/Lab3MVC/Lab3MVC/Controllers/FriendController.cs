using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3MVC.Models;

namespace Lab3MVC.Controllers
{
    public class FriendController : Controller
    {
        private static List<FriendModel> friends = new List<FriendModel>()
        {
            new FriendModel()
            {
                FriendID = 0,
                Name = "Kostadin Krstev",
                Hometown = "Negotino"
            }
        };

        // GET: Friend
        public ActionResult AllFriends()
        {
            return View(friends);
        }

        public ActionResult AddFriend()
        {
            FriendModel model = new FriendModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
                return View("AddFriend", model);
            friends.Add(model);
            return RedirectToAction("AllFriends", "Friend");
        }

        public ActionResult EditFriend(int id)
        {
            var model = friends.ElementAt(id);
            model.ID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditFriendPost(FriendModel model)
        {
            if (!ModelState.IsValid)
                return View("EditFriend", model);
            friends.RemoveAt(model.ID);
            friends.Insert(model.ID, model);
            return RedirectToAction("AllFriends", "Friend");
        }

        public ActionResult DeleteFriend(int id)
        {
            friends.RemoveAt(id);
            return RedirectToAction("AllFriends", "Friend");
        }
    }
}