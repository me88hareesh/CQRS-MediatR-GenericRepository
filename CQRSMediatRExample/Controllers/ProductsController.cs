﻿using CQRSMediatRExample.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRExample.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ISender _sender;

        public ProductsController (IMediator mediator, ISender sender)
        {
            _mediator = mediator;
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _sender.Send(new GetProductsQuery());
            return Ok(products);
 
        }

        //[HttpGet]
        //public ActionResult getdata()
        //{
        //    return Ok("hi");
        //}
    }
}
