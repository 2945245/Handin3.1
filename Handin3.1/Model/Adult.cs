namespace Handin3._1.Model
{
    public class Adult :Person
    {
        public Job JobTitle { get; set; }

        public Adult()
        {
            JobTitle = new Job();
        }
    }
}