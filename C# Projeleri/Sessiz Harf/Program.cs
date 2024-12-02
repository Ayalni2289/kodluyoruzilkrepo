Console.WriteLine("Sessiz Harf Kontrolü İçin Cümle Giriniz: ");
string cumle = Console.ReadLine().ToLower();
string[] kelimeler = cumle.Split(" ");
char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };


foreach(string kelime in kelimeler)
{
    bool bulundu = false;
    
    for (int i = 0; i < kelime.Length-1; i++)
    {
    if (!sesliHarfler.Contains(kelime[i]) && char.IsLetter(kelime[i]))
    {
        if (!sesliHarfler.Contains(kelime[i + 1]) && char.IsLetter(kelime[i + 1]))
        {
            bulundu = true;
            break;
        }
    }
}
Console.WriteLine(bulundu ? "True" : "False");
}

