namespace ConsoleApp2;

public class BordenStapelen
{
    static void Main(string[] args)
    {
        Stack<string> myStack = new Stack<string>();
        myStack.Push("Bord1");
        myStack.Push("Bord2");
        myStack.Push("Bord3");
        Console.WriteLine("Huidige hoeveelheid gestapelde borden"+ myStack.Count());
        
        int stackSize = myStack.Count;
        Console.WriteLine("Huidige hoeveelheid gestapelde borden in de stack" + stackSize);
        
        string topItem = myStack.Peek();
        Console.WriteLine("peeking naar het bovenste bord" + topItem);

        while (myStack.Count > 0)
        {
            string poppeditem = myStack.Pop();
            Console.WriteLine("Popped bord" + poppeditem);
            Console.WriteLine( " Huidige hoeveelheid borden " + myStack.Count);
            
        }
    }
}