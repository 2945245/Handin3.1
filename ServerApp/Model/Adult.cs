namespace ServerApp.Model
{
    public class Adult : Person
    {
        public Job JobTitle { get; set; }

        public Adult()
        {
            JobTitle = new Job();
        }
    }
}