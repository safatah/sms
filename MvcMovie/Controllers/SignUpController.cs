using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HappyHelper.Data;
using HappyHelper.Models;

namespace HappyHelper.Controllers
{
    public class SignUpController : Controller
    {
        private readonly HappyHelperContext _context;

        public SignUpController(HappyHelperContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}