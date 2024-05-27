namespace PoTestDemo;

/**
 * Zaimplementuje metodę Search, aby zwracała ciąg słów zanjdujących się w `items`,
 * aby zawierały łańcuch `fragment`. Zwrócony ciąg musi być posortowany wg długości.
 * 
 */
public class Task02
{
    public static void Run()
    {
        
    }

    public static IEnumerable<string> Search(IEnumerable<string> items, string fragment)
    {
        return items
            .Where(s => s.Contains(fragment))
            .OrderBy(s => s.Length);
    }  
}