using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Handin3._1.Data;
using Handin3._1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Handin3._1.Controllers
{
    
    [ApiController]
    [Route("[Controller]")]
    public class FamiliesController :ControllerBase
    {
      
       
            private IFamiliesData familiesData;

            public FamiliesController(IFamiliesData familiesData)
            {
                this.familiesData = familiesData;
            }
        
            [HttpGet]
            public async Task<ActionResult<IList<FamilyObject>>> GetFamilies()
            {
                try
                {
                    IList<FamilyObject> families = await familiesData.GetAllFamiliesAsync();
              
                    return Ok(families);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            
            
            }
    }
}