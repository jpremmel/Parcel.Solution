using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/parcels/order-details")]
        public ActionResult OrderDetails(string recipient, float height, float width, float length, float weight)
        {
            Package package = new Package(recipient, height, width, length, weight);
            return View(package);
        }


    }
}