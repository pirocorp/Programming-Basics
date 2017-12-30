using System.Web.Mvc;

namespace Ratings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DrawRating (int rating)
        {
            var fullStars = rating * 10 / 100;
            var emptyStars = (100 - rating) * 10 / 100;
            var halfStars = 10 - fullStars - emptyStars;

            var stars = "";
            for (int i = 0; i < fullStars; i++)
            {
                stars += "<img src='/images/full-star.png' />";
            }
            //for (int i = 0; i < halfStars; i++)
            //{
            //    stars += "<img src='/images/half-star.png' />";
            //}
            if (rating % 10 >= 5)
            {
                stars += "<img src='/images/half-star.png' />";
            }
            else if (rating % 10 > 0)
            {
                stars += "<img src='/images/empty-star.png' />";
            }

            for (int i = 0; i < emptyStars; i++)
            {
                stars += "<img src='/images/empty-star.png' />";
            }

            ViewBag.Stars = stars;
            ViewBag.Rating = rating;
            return View("Index");
        }
    }
}