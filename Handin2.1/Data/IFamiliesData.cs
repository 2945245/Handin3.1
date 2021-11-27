using System.Collections.Generic;
using System.Threading.Tasks;
using Handin3._1.Model;

namespace Handin3._1.Data
{
    public interface IFamiliesData
    {
        Task <IList<Adult>> GetAllAdultsAsync(); 
        Task<IList<FamilyObject>> GetAllFamiliesAsync();
        Task NewFamilyAsync(FamilyObject family);

    }
}