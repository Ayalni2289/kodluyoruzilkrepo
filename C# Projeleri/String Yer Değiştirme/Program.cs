class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir veya daha fazla kelime giriniz:");
        string input = Console.ReadLine();

        string[] words = input.Split(' '); // Girdiyi kelimelere ayır

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = SwapFirstAndLastCharacter(words[i]); // Her kelimeyi işleyerek ilk ve son karakterini değiştir
        }

        string result = string.Join(" ", words); // İşlenmiş kelimeleri birleştir
        Console.WriteLine(result);
    }

    static string SwapFirstAndLastCharacter(string word)
    {
        if (word.Length <= 1)
        {
            return word; // Tek karakterli kelimeler veya boşluklar için işlem yapma
        }

        char first = word[0]; // İlk karakter
        char last = word[^1]; // Son karakter (C# 8.0 ile ^ kullanımı)
        string middle = word.Substring(1, word.Length - 2); // Orta kısım

        return last + middle + first; // Yeni kelimeyi oluştur
    }
}
