using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StockTickerData.Models;
using StockTickerData.Shared;
using System.Net;

namespace StockTickerData.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockTIcker : ControllerBase
    {
        
        private readonly IHttpClientFactory _clientfactory;
        public StockTIcker(IHttpClientFactory clientfactory)
        {
            _clientfactory = clientfactory;

        }
        [HttpGet]
        public async Task<IActionResult> GetTicker()
        {
            try
            {
                var client = _clientfactory.CreateClient("stock");
                var response = await client.GetAsync("Quotes");//update here endpoint
                var result = response.Content.ReadAsStringAsync().Result;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }

        }
    }
}

