using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
    public class ParcelsController : Controller
    {

        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Package> packageList = Package.PackageList;
            return View(packageList);
        }

        [HttpPost("/parcels/order-details")]
        public ActionResult OrderDetails(string recipient, float height, float width, float length, float weight)
        {
            ActionResult result;
            if (recipient == "" || height == 0 || width == 0 || length == 0 || weight == 0)
            {
                result = RedirectToAction("Index", "Home"); //using overload constructor
            }
            else
            {
                Package package = new Package(recipient, height, width, length, weight);
                result = View(package);
            }
            return result;
        }


    }
}