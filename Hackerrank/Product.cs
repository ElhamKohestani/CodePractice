namespace HackerRankProblemSolving
{
    public class Product
    {
        public string Name { get; set; }
        public Product(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name of product{Name}";
        }
    }
}
