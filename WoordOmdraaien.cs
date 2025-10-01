
public class WoordOmdraaien
{
    public static void Main(string[] args)
    {
        string woord = "lepel";
        string omgekeerd = KeerOm(woord);
        Console.WriteLine($"Omgekeerd: {omgekeerd}");
    }

    public static string KeerOm(string s)
    {
        Stack<char> stack = new Stack<char>(s); 
        return new string(stack.ToArray()); 
    }
}