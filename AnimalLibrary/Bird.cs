namespace AnimalLibrary
{
    public class Bird: Animal
    {
        public bool IsFlightless { get; set; }
        public string IUCNStatus { get; set; } = string.Empty;

        public string GetBirdFamily()
        {
            return Family;
        }
    }
}
