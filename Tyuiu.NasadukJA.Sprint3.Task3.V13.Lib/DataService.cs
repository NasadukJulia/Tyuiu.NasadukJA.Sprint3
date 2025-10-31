using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NasadukJA.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";

            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
            }
            if (digits == "")
            {
                return 0;
            }
            int number = Convert.ToInt32(digits);

            return number;
        }
    }
}