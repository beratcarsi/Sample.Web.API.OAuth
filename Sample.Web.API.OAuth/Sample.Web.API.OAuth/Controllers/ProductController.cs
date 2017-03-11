using System.Collections.Generic;
using System.Web.Http;

namespace Sample.Web.API.OAuth.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<string> List()
        {
            List<string> products = new List<string>();

            products.Add("Bilgisayar");
            products.Add("Klavye");
            products.Add("Kamera");
            products.Add("Disk");

            return products;
        }

    }
}