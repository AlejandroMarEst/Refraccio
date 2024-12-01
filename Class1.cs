namespace PersonaHelper
{
    public class Class1
    {
        public static bool ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static (bool IsShort, bool IsPalindrome) NameAnalyser(string name)
        {
            bool isShort;
            bool isPalindrome;
            if (name.Length < 5)
            {
                isShort = true;
            }
            else
            {
                isShort = false;
            }
            if(name.Equals(new string(name.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase))
            {
                isPalindrome = true;
            } else
            {
                isPalindrome= false;
            }
            return (isShort, isPalindrome);
        }
        public static int VerifyColor(string color)
        {
            switch (color.ToLower())
            {
                case "blau":
                case "verd":
                    return 0; // Calmants
                case "daurat":
                    return 1; // Exclusiu
                default:
                    return -1; // Invàlid
            }
        }
        public static int PersonalityTest(string preference)
        {
            switch (preference.ToLower())
            {
                case "matí":
                    return 0; // Personalitat matinal
                case "nit":
                    return 1; // Personalitat nocturna
                default:
                    return 2; // Personalitat imprevista
            }
        }
    }
}
