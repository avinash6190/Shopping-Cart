using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AIMIA.Core;
using AIMIA.Models;
using AIMIA.Controllers;
using System.Web;
using System.Web.Mvc;
using Moq;

namespace AIMIA.UnitTest
{
    [TestClass]
    public class CartControllerTest
    {
        /// <summary>
        /// The mocked Category Service.
        /// </summary>
        private Mock<ICartService> mockCategoryService;

        /// <summary>
        /// Test Initialize
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            mockCategoryService = new Mock<ICartService>();
        }

        /// <summary>
        /// Test Add Cart with Correct Inputs
        /// </summary>
        [TestMethod]
        public void AddcartWithId()
        {
            mockCategoryService.Setup(m => m.AddCart(1, 1)).Returns(1);
            using (CartController cartController = new CartController(mockCategoryService.Object))
            {
               PetDetailsModel petDetails = new PetDetailsModel()
                {
                    PetId = 1,
                    PetName = "Riley"
                };
                
                JsonResult jsonResult = cartController.Add(1, 1, petDetails) as JsonResult;
                Assert.IsNotNull(jsonResult);
            };
        }

        /// <summary>
        /// Test Add Methods
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void AddcartWithNoPetDetails()
        {
            using (CartController cartController = new CartController(mockCategoryService.Object))
            {
                PetDetailsModel petDetails = null;
                cartController.Add(1, 1, petDetails);
            };
        }

    }
}
