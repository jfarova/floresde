internal class Program
{
    private static void Main(string[] args)
    {
       int num=1,suma=1;
       while(num!=0){
        Console.WriteLine("ingrese numero");
        num=int.Parse(Console.ReadLine());
         suma=suma+num;

  }

  Console.WriteLine("La suma de los números es "+suma);

        }
}

