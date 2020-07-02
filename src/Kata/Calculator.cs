namespace Kata
{
    public class Calculator
    {
        public int Add(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return 0;                
            }

            var array = number.Split(",");
            var sum = 0;
            foreach (var slice in array)
            {
                sum += int.Parse(slice);
            }
            return sum;
        }
    }
}