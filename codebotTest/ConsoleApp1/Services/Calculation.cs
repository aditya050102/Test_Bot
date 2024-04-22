namespace ConsoleApp1.Services
{
    public static class Calculation
    {
        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false; // lla number less than 2 are non prime.
            }
            int i = 2;
            while (i <= num / i)
            {
                if (num % i == 0) { return false; };
                i++;
            }
            return true;
        }

        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
                return false;
            return true;
        }
    }
}