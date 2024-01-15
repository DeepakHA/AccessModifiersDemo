namespace AnimalLibrary
{
    public class AnimalService
    {
        public string GetIUCNStatusOfBird()
        {
            Bird bird = new Bird()
            {
                Name = "Harpy Eagle",
                Description = "Native to South America",
                IsFlightless = false,
                IUCNStatus = "Vulnerable"
            };

            return bird.IUCNStatus;
        }

        public string GetMammalClassification()
        {
            Mammal mammal = new Mammal()
            {
                Classification = "Mammal"
            };

            return mammal.Classification;
        }
    }
}
