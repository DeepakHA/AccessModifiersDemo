namespace AnimalLibrary
{
    public class Mammal : Animal
    {
        public int NumberOfLegs { get; set; }
        public string NaturalHabitat { get; set; } = string.Empty;

        public string GetMammalClassification()
        {
            return Classification;
        }

        public string GetMammalFamily()
        {
            return Family;
        }
    }
}
