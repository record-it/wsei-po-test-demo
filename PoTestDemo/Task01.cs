using System.Globalization;

namespace PoTestDemo;
/**
 * Zaimplementuj metodę AddTwoStringAsDouble aby zwracała sumę liczb double zapisanych w
 * łąńuchach a i b. Jeśli któryś z łańcuchów nie zawiera liczby to zwróć double.NaN
 * Uwaga
 * Łańcych zawiera kropkę w roli separatora dziesiętnego!
 */
public class Task01
{
    public static void Run()
    {
        
    }

    public static double AddTwoStringAsDouble(string a, string b)
    {
        return double.Parse(a, CultureInfo.GetCultureInfo("en-EN")) 
             + double.Parse(b, CultureInfo.GetCultureInfo("en-EN"));
    }
}