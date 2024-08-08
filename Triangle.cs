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
        for (int i = 0; i < Size; i++)
        {
            int spaces = Size - i - 1;
            lines[i] = new string(' ', spaces) + "/" + new string('_', i * 2) + "\\";
        }
        

        return lines;
    }

}

      