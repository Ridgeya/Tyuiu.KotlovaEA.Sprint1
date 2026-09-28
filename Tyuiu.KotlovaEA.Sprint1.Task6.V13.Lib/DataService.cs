using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KotlovaEA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            char previous = '\0';
            foreach (char c in value)
            {
                if (!char.IsLetter(c)) continue;
                if (previous != '\0' && c < previous) return false;
                previous = c;
            }
            return true;
        }
    }
}
