class Program
{

    static List<User> users = new List<User>();
    static List<string> transactionLogs = new List<string>();
    static List<string> failedLogins = new List<string>();
    static User currentUser;

    static void Main(){
        Console.WriteLine("ATM Uygulamasına Hoşgeldiniz!");
        Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz: ");
        string username = Console.ReadLine();
        var user = users.FirstOrDefault(u => u.Username == username);

        if(user == null) {
            Console.WriteLine("Kayıt Bulunamadı. Yeni Kullanıcı Oluşturuluyor...");
            failedLogins.Add($"Hatalı Giriş Denemesi: {username} - {DateTime.Now}");
            user = new User(username, 0);
            users.Add(user);
        }
        currentUser = user;
        Console.WriteLine($"Hoşgeldin {user.Username}");
        Menu();

    }
   private static void GunSonu()
    {
        string date = DateTime.Now.ToString("ddMMyyyy");
        string filePath = $"EOD_{date}.txt";

        Console.WriteLine("\n--- Gün Sonu Logları ---");
        Console.WriteLine("Yapılan İşlemler:");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("--- Gün Sonu Logları ---");
            writer.WriteLine("Yapılan İşlemler:");
            foreach (var log in transactionLogs)
            {
                writer.WriteLine(log);
            }

            writer.WriteLine("\nHatalı Giriş Denemeleri:");
            foreach (var log in failedLogins)
            {
                writer.WriteLine(log);
            }
        }

        Console.WriteLine($"\nGün sonu logları '{filePath}' dosyasına kaydedildi.");
        transactionLogs.Clear();
        failedLogins.Clear();
    }
    private static void BakiyeSorgulama()
    {
        Console.WriteLine($"Bakiyeniz: {currentUser.balance} ₺ ");
        transactionLogs.Add($"Bakiye Sorgulama - Kullanıcı: {currentUser.Username} - {DateTime.Now}");
    }

    private static void ParaYatirma()
    {
        Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz: ");
        int tutar = Convert.ToInt32(Console.ReadLine());
        if(tutar < 0)
        {
            Console.WriteLine("Negatif tutar yatırılamaz.");
            return;
        }
        currentUser.balance += tutar;
        Console.WriteLine($"{tutar} TL yatırıldı.");
        transactionLogs.Add($"Para Yatırma: {tutar} TL - Kullanıcı: {currentUser.Username} - {DateTime.Now}");
    }

    private static void ParaCekme()
    {
        Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz: ");
        int tutar = Convert.ToInt32(Console.ReadLine());
        if(tutar < 0 || currentUser.balance < tutar)
        {
            Console.WriteLine("Bakiyeniz Mevcut Değil.");
            return;
        }
        if(tutar % 10 != 0 )
        {
            Console.WriteLine("ATM'den sadece 10 TL'lik banknot çekilebilir.");
            return;
        }
        if(tutar > 1000)
        {
            Console.WriteLine("Günlük çekim limiti 1000 TL'dir.");
            return;
        }
        Console.WriteLine($"{tutar} TL çekildi.");
        currentUser.balance -= tutar;
        transactionLogs.Add($"Para Çekme: {tutar} TL - Kullanıcı: {currentUser.Username} - {DateTime.Now}");

    }
    private static void Menu(){
        while(true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1- Para Çekme");
            Console.WriteLine("2- Para Yatırma");
            Console.WriteLine("3- Bakiye Sorgulama");
            Console.WriteLine("4- Gün Sonu");
            Console.WriteLine("5- Çıkış");
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    ParaCekme();
                    break;
                case "2":
                    ParaYatirma();
                    break;
                case "3":
                    BakiyeSorgulama();
                    break;
                case "4":
                    GunSonu();
                    break;
                case "5":
                    Console.WriteLine("Çıkış Yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz İşlem!");
                    break;
            }
    }
    }
}