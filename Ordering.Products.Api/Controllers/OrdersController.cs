﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ordering.products.api.DBContext;
using ordering.products.api.Model;
using Ordering.Products.Api.Interfaces;

namespace Ordering.Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _Context;


        public OrdersController(IOrderRepository Context)
        {
            _Context = Context;
        }

        // GET: api/Orders
        [HttpGet("{UserId}")]
        public ActionResult<IEnumerable<Order>> GetOrders(string UserId)
        {
            return _Context.GetOrders(UserId);
        }

        // GET: api/Orders/5
        [HttpGet]
        public ActionResult<Order> GetOrder(int Id , string UserId)
        {
            var Order = _Context.GetOrderId(Id,UserId);

            if (Order == null)
            {
                return NotFound();
            }

            return Order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public IActionResult PutOrder(int Id, Order Order)
        {
            if (Id != Order.Id)
            {
                return BadRequest();
            }



            try
            {
                var newOrder = _Context.EditOrder(Order);
                if (newOrder != null)
                {
                    return CreatedAtAction("order updated",newOrder);
                }
                
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Order> PostOrder(Order Order)
        {
           
            try
            {
               var newOrder =  _Context.PostOrder(Order);
                if (newOrder != null)
                {
                    return Ok(newOrder);
                }

            }
            catch (DbUpdateException)
            {
                if (OrderExists(Order.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrder", new { id = Order.Id }, Order);
        }

        // DELETE: api/Orders/5
        [HttpDelete]
        public IActionResult DeleteOrder(int Id,string userId)
        {
            var order = _Context.GetOrderId(Id, userId);
            if (order == null)
            {
                return NotFound();
            }

            _Context.DeleteOrder(Id);

            return NoContent();
        }

        [HttpPost("Cancel/{id}")]
        public async Task<IActionResult> CancelOrder(int Id, string UserId)
        {
            var order = _Context.GetOrderId(Id,UserId);
            if (order == null)
            {
                return NotFound();
            }

            try
            {
                order.Active = false;
                var CancelledOrder = _Context.EditOrder(order);
                if (CancelledOrder != null) {
                    return CreatedAtAction("Order cancelled", CancelledOrder);
                }
            }
            catch (Exception ex) { 
            
            }
           

            return NoContent();
        }


        private bool OrderExists(int Id)
        {
            return _Context.OrderExist(Id);
        }
    }
}
