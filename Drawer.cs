public class Drawer
{
    public void Draw(Triangle triangle){
        var lines = triangle.GenerateLines();
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}