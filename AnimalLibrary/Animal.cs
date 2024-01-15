namespace AnimalLibrary
{
    public class Animal
    { 
        private int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        protected internal string Classification { get; set; } = string.Empty;
        private protected string Family {  get; set; } = string.Empty;
    }
}