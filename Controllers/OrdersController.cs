using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using be_poc.Data;
using be_poc.Models;
using Microsoft.AspNetCore.Mvc;

namespace be_poc.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public OrdersController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            _appDbContext.Order.Add(order);
            await _appDbContext.SaveChangesAsync();
            return Ok(order);
        }
    }
}