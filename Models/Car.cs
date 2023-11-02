namespace IndexerExtensionTask.Models
{
    public class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int ProducedYear { get; set; }


        public override string ToString()
        {
            return $"Car name is: {Name} ,  Color: {Color} , Produced Year: {ProducedYear} ";
        }
    }
}
