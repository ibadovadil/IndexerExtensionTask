namespace IndexerExtensionTask.Models
{
    public class Gallery
    {
        public string Name { get; set; }
        private Car[] Cars { get; set; }

        public Gallery(int size)
        {
            Cars = new Car[size];
        }

        public Car this[int index]
        {
            get
            {
                if (index >= 0 && index < Cars.Length)
                {
                    return Cars[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < Cars.Length)
                {
                    Cars[index] = value;
                }
                else
                {
                    Console.WriteLine("wrong");
                }
            }
        }

        public bool this[string carName]
        {
            get
            {
                foreach (Car car in Cars)
                {
                    if (car != null && car.Name == carName)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}

