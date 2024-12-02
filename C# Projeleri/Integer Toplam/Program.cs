
class Program
{
    static void Main()
    {
        Algoritma algoritma = new Algoritma();
        algoritma.Hesapla();
    }
}

class Algoritma
{
    public void Hesapla()
    {
        Console.WriteLine("Kaç çift sayı gireceksiniz?");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen her bir çifti aralarında boşluk bırakarak giriniz:");

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int sum = a + b;
            if (a == b)
            {
              
               Console.WriteLine(Math.Pow(sum, 2));
            }
            else
            {

                Console.WriteLine(sum);
            }
        }
    }
}
