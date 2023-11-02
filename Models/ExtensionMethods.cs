namespace IndexerExtensionTask.Models
{
    public static class ExtensionMethods
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
            {
                return false;
            }

            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public static bool IsPowOfTwo(this int number)
        {
            if (number <= 0)
            {
                return false;
            }

            while (number % 2 == 0 && number > 1)
            {
                number /= 2;
            }

            return number == 1;
        }
    }


}
