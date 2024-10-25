using System.Collections;
Odev.Asallık();
class Odev{
    public static void Asallık(){
        ArrayList asal = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();
        Console.WriteLine("20 adet pozitif tam sayı giriniz:");
        
        for(int i=0;i<20;i++){
            int a;

            while(true){
                string? input = Console.ReadLine();

            if(int.TryParse(input, out a) && a>0){
                break;
            }
            else {
                  Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.");
            }
            }

              if(a==1){
                asalOlmayan.Add(a);
              }
              else if (a == 2){
                asal.Add(a);
              }
              else{
                for(int j=2;j<a;j++){
                    if(a%j==0){
                        asalOlmayan.Add(a);
                        break;
                    }
                    else if(j==a-1){
                        asal.Add(a);
                    }
                }
        }
        }
        //Büyükten Küçüğüe Sırala
        asal.Sort();
        asal.Reverse();

        asalOlmayan.Sort();
        asalOlmayan.Reverse();
        
        double asalOrt = 0;
        double asalOlmayanOrt = 0;

        //ortalamaları
        if(asal.Count >0){
            foreach(int i in asal){
                asalOrt += i;
            }
            asalOrt /= asal.Count;
        }
         if(asalOlmayan.Count >0){
            foreach(int i in asalOlmayan){
                asalOlmayanOrt += i;
            }
            asalOlmayanOrt /= asalOlmayan.Count;
        }
        // Asal sayılar
        Console.Write("Asal Sayılar: ");
        foreach (int i in asal)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\nAsal Olan Sayı Adedi: " + asal.Count);
        Console.WriteLine("Asal Olan Sayıların Ortalaması: " + asalOrt.ToString("0.##"));


        // Asal olmayan sayılar
        Console.Write("Asal Olmayan Sayılar: ");
        foreach (int i in asalOlmayan)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\nAsal Olmayan Sayı Adedi: " + asalOlmayan.Count);
        Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + asalOlmayanOrt.ToString("0.##"));
    }
}

