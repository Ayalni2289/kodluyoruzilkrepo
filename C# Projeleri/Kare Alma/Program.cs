Console.WriteLine("Kaç Adet Çift Sayı Girmek İstersiniz ? ");
int adet = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen Çift Sayıları Giriniz boşuk bırakarak : ");

for(int i=0;i<adet;i++)
{
    Console.WriteLine("Lütfen Çift Sayıları Giriniz : ");
    int [] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    int a = Convert.ToInt32(input[0]);
    int b = Convert.ToInt32(input[1]);
    
    if (a < 67)
    {
        a = 67-a;
    }
    else if(a > 67){
        a = a-67;
        a = a * a;
    }
    if(b < 67)
    {
        b = 67-b;
    }
    else if(b > 67){
        b = b-67;
        b = b * b;
    }
    int toplam = a + b;
    {
        Console.WriteLine(toplam);
    }
}