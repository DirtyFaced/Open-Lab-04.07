using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            if (original == "")
            {
                return "";
            }
            char[] vysledokchar = new char[original.Length];
            for (int i = original.Length; i > 0; i--)
            {
                vysledokchar[i - 1] = original[original.Length - i];
            }
            string vysledok = new string(vysledokchar);
            return vysledok;
        }
    }
}
