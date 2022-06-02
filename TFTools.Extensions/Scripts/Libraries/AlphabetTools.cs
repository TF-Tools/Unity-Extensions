namespace TFTools.Extensions
{
    public static class AlphabetTools
    {
        public static string ConvertNumberToAlphabet (int _number)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int mod = _number % 26;

            string answer = alphabet.Substring (mod, 1);

            int div = _number / 26;
            while (div > 26)
            {
                answer = answer.Insert (0, alphabet.Substring (div, 1));
                div /= 26;
            }

            if (div != 0)
                answer = answer.Insert (0, alphabet.Substring (div, 1));

            return answer;
        }
    }
}