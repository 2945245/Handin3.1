using System.Collections.Generic;

namespace Handin3._1.Model
{
    public class Child:Person
    {
        public List<Interest> Interests { get; set; }
        public List<Pet> Pets { get; set; }
    }
}