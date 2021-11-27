using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Handin3._1.Data;
using Handin3._1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Handin3._1.Controllers
{
    namespace FamilyWeb.Data
    {
        [ApiController]
        [Route("[Controller]")]
    public class AdultController :ControllerBase{
        
      
            private IFamiliesData familiesData;

            public AdultController(IFamiliesData familiesData)
            {
                this.familiesData = familiesData;
            }

            [HttpGet]
            public async Task<ActionResult<IList<Adult>>> GetAdults()
            {
                try
                {
                    IList<Adult> adults = await familiesData.GetAllAdultsAsync();
              
                    return Ok(adults);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }
        }

    }
}