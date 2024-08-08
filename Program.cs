class Program
{
    static void Main(string[] args){
        Console.WriteLine("Üçgenin boyutunu giriniz: ");
        if(int.TryParse(Console.ReadLine(),out int size)){
            var triangle = new Triangle(size);
            var drawer = new Drawer();
            drawer.Draw(triangle);
        }
        else{
            Console.WriteLine("Geçersiz boyut");
        }
    }
}