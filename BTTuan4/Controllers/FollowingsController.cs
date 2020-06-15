using BTTuan4.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTuan4.Controllers
{
    public class FollowingsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Followings
        //public ActionResult Follow(Following followingDto)
        //{
        //    //var userId = User.Identity.GetUserId();
        //    //if (_dbContext.Followings.Any(f => f.FolloweeID == userId && f.FolloweeID == followingDto.FolloweeID))
        //    //    return BadRequest("Following already exists!");
        //    //var following = new Following
        //    //{
        //    //    FollowerID = userId,
        //    //    FolloweeID = followingDto.FolloweeID
        //    //};
        //    //_dbContext.Followings.Add(following);
        //    //_dbContext.SaveChanges();
        //    return Ok();
        //}
    }
}