using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIMIA.Core;
using AIMIA.Models;
using System.Collections;


namespace AIMIA.Controllers
{
    public class CartController : Controller
    {

        private ICartService _cartService;

        IList<PetDetailsModel> cartCollection = new List<PetDetailsModel>();


        [Microsoft.Practices.Unity.InjectionConstructor]
        public CartController(ICartService icartServices)
        {
            this._cartService = icartServices;
        }

        public ActionResult Index()
        {
            return View();
        }

        ///<summary>
        /// Add the Cart
        ///</summary>
        ///<param name="petId"></param>
        ///<returns></returns>
        [HttpPost]
        public ActionResult Add(int id, int count, PetDetailsModel petDetails)
        {
            if (petDetails == null)
            {
                throw new ArgumentException("PetDetails Should not be Null");
            }
            int items = _cartService.AddCart(id, count);
            return Json(items, JsonRequestBehavior.AllowGet);
        }
    }
}
