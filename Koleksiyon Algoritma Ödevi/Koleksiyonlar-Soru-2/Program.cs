int[] dizi = new int[20];
int[] max = new int[3];
int[] min = new int[3];

for (int i = 0; i < dizi.Length; i++)
{
    int a;
    if (int.TryParse(Console.ReadLine(), out a))
    {
        dizi[i] = a;
    }
    else
    {
        Console.WriteLine("Lütfen sadece sayı giriniz.");
        i--;
    }
}



Array.Sort(dizi);

for(int i=0;i<3;i++){
        max[i] = dizi[dizi.Length - 1 - i];
        min[i] = dizi[i];
}

double maxOrt=0;
double minOrt=0;


Console.WriteLine("En büyük 3 sayı:");
foreach (var item in max)
{
    maxOrt+=item;
    Console.WriteLine(item);
}
 maxOrt/=max.Length;
Console.WriteLine("En Büyük Sayıların Ortalaması: "+maxOrt.ToString("F2"));

Console.WriteLine("En küçük 3 sayı:");
foreach (var item in min)
{
    minOrt+=item;
    Console.WriteLine(item);
}
minOrt/=min.Length;
Console.WriteLine("En Küçük Sayıların Ortalaması: "+minOrt.ToString("F2"));
double toplamOrt = maxOrt + minOrt;
Console.WriteLine("Ortalamaların Toplamı: " + toplamOrt.ToString("F2"));

