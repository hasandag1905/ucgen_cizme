using System.Security.Cryptography;

public class Triangle
{
    public int Size { get; private set; }

    public Triangle(int size)
    {
        if (size < 1)
            throw new ArgumentException("Boyut 1'den küçük olamaz.");
        else
            Size = size;

    }
    public string[] GenerateLines()
    {
        string[] lines = new string[Size];
        for (int i = 0; i < Size-1; i++)
        {int spaces = Size - i - 1;
        
          
            
            Console.WriteLine(new string(' ', spaces) + "/" + new string(' ', i * 2) + "\\");
            
        }
        if (Size==1)
        {
            Console.WriteLine("/_\\");
        }
        else{
        Console.WriteLine(new string("/") + new string('_', Size * 2-3) + "_\\");
        }

        return lines;
    }

}

      