using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula223.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aula223.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}