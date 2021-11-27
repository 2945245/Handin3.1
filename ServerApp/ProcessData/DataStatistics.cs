using System.Collections.Generic;
using ServerApp.Data;
using ServerApp.Model;
using ServerApp.Pages;

namespace ServerApp.ProcessData
{
    public class DataStatistics:IDataStatistics
    {
        public IList<FamilyObject> AllFamilyObjects;
        private IFamiliesData familyData;

        public DataStatistics(FamiliesData familyData)
        {
        }

        public int FamiliesWithPets()
        {
            int tmp = 0;
            foreach (var family in AllFamilyObjects)
            {
                if (family.Pets != null && family.Pets.Count > 0)
                {
                    ++tmp;
                }
                
            }

            return tmp;
        }

        public int FamiliesWithoutPets()
        {
            int tmp = 0;
            foreach (var family in AllFamilyObjects)
            {
                if (family.Pets !=null && family.Pets.Count < 1)
                {
                    ++tmp;
                }
                
            }

            return tmp;
            
        }
    }
}