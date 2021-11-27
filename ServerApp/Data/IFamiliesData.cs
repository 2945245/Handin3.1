using System.Collections.Generic;
using System.Threading.Tasks;
using ServerApp.Model;

namespace ServerApp.Data
{
    public interface IFamiliesData
    {
        Task<IList<Adult>> GetAllAdultsAsync();
        Task GetAllFamiliesAsync();
        Task NewFamilyAsync(FamilyObject familyObject);

    }
}