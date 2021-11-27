using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public interface IFamiliesData
    {
        Task<IList<Adult>> GetAllAdultsAsync();
        Task<IList<FamilyObject>> GetAllFamiliesAsync();
        Task NewFamilyAsync(FamilyObject familyObject);

    }
}