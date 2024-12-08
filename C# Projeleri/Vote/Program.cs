class Program
{
    static List<User> users = new List<User>();
    static Dictionary<string, int> categories = new Dictionary<string, int>{
        {"Film Kategorileri", 0},
        {"Tech Stack Kategorileri", 0},
        {"Spor Kategorileri", 0}
        };
    
    static void Main(){
        Console.WriteLine("Oylama uygulamasına hoşgeldiniz!");
        while(true)
        {
            Console.WriteLine("\n Mevcut Kategoriler:");
            foreach(var cat in categories)
            {
                Console.WriteLine($"- {cat}");
            }

            Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            string username = Console.ReadLine();

            var user = users.FirstOrDefault(u => u.Username == username);
            if(user == null) {
                Console.WriteLine("Kayıt Bulunamadı. Yeni Kullanıcı Oluşturuluyor...");
                user = new User(username);
                users.Add(user);
            }
            if(user.HasVoted) {
                Console.WriteLine("Zaten oy kullandınız.");
                continue;
            }
            Console.WriteLine("Oy Kullanmak İstediğiniz Kategoriyi Seçiniz: ");
            string category = Console.ReadLine();

            if(categories.ContainsKey(category)) {
                categories[category]++;
                user.HasVoted = true;
                Console.WriteLine("Oyunuz Başarıyla Alındı.");
            }
            else {
                Console.WriteLine("Geçersiz Kategori.");
            }

            Console.WriteLine("Başka bir oy kullanmak ister misiniz? (E/H)");
            string choice = Console.ReadLine();
            if(choice.ToLower() != "e") {
                break;
            }
        }
        showResults();

    }

    static void showResults() {
        Console.WriteLine("Oylama Sonuçları:");
        int totalVotes = categories.Values.Sum();

        foreach(var category in categories) {
            double percentage = totalVotes > 0 ? (category.Value / (double)totalVotes) * 100 : 0;
                Console.WriteLine($"Kategori: {category.Key} - Oy Sayısı: {category.Value}, Yüzde: {percentage:F2}%");
        }
    }
}
