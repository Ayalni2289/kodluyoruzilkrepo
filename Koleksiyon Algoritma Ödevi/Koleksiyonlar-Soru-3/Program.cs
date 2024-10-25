Odev.SesliHarfler();

class Odev{
    public static void SesliHarfler(){
        char[] sesliHarfler = {'a', 'e', 'i', 'o', 'u',};
        string kelime = Console.ReadLine();
        for(int i=0;i<kelime.Length;i++){
            if(Array.IndexOf(sesliHarfler, kelime.ToLower()[i]) != -1){
                Console.WriteLine(kelime[i]);
            }
        }
    }
}