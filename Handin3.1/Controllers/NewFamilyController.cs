using System.Threading.Tasks;
using Handin3._1.Data;
using Handin3._1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Handin3._1.Controllers{
    [ApiController]
    [Route("[Controller]")]

    public class NewFamilyController:ControllerBase
    {
        
            private IFamiliesData FamiliesData;

            public NewFamilyController(IFamiliesData familiesData)
            {
                FamiliesData = familiesData;
            }

            [HttpPost]

            public async Task PostFamily(FamilyObject familyObject)
            {
                await FamiliesData.NewFamilyAsync(familyObject);
            }

    }
}