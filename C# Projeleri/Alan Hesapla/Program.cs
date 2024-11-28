class Program
{
    static void Main(string[] args)
    {
        SecimYap();
    }

    static void SecimYap()
    {
        Console.WriteLine("Yaptırmak İstediğiniz İşlemi Seçiniz:");
        Console.WriteLine("1. Alan Hesabı");
        Console.WriteLine("2. Hacim Hesabı");
        Console.WriteLine("3. Çevre Hesabı");
        int secim = Convert.ToInt32(Console.ReadLine());

        //Singleton
        SecimIslemi.Instance.YapilanSecimIslemi(secim);
    }
}

class SecimIslemi
{
     private static readonly SecimIslemi _instance = new SecimIslemi();

    // Singleton instance'e erişmek için property
    public static SecimIslemi Instance => _instance;

    // Private constructor, dışarıdan yeni örnek yaratılmasını engeller
    private SecimIslemi() { }

    public void YapilanSecimIslemi(int secim)
    {
        switch (secim)
        {
            case 1:
                AlanIslemleri();
                break;
            case 2:
                HacimIslemleri();
                break;
            case 3:
                CevreIslemleri();
                break;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız!");
                break;
        }
    }

    private void AlanIslemleri()
    {
        Console.WriteLine("Alan Hesabı İşlemleri");
        Console.WriteLine("1. Üçgen Alanı Hesabı");
        Console.WriteLine("2. Dikdörtgen Alanı Hesabı");
        Console.WriteLine("3. Daire Alanı Hesabı");
        Console.WriteLine("4. Kare Alanı Hesabı");
        int yeniSecim = Convert.ToInt32(Console.ReadLine());

        switch (yeniSecim)
        {
            case 1:
                Console.WriteLine(AlanHesabı.UcgenAlani());
                break;
            case 2:
                Console.WriteLine(AlanHesabı.DikdortgenAlani());
                break;
            case 3:
                Console.WriteLine(AlanHesabı.DaireAlani());
                break;
            case 4:
                Console.WriteLine(AlanHesabı.KareAlani());
                break;
            default:
                Console.WriteLine("Geçersiz İşlem");
                break;
        }
    }

    private void HacimIslemleri()
    {
        Console.WriteLine("Hacim Hesabı İşlemleri");
        Console.WriteLine("1. Küp Hacmi Hesabı");
        Console.WriteLine("2. Küre Hacmi Hesabı");
        Console.WriteLine("3. Silindir Hacmi Hesabı");
        Console.WriteLine("4. Koninin Hacmi Hesabı");
        int yeniSecim = Convert.ToInt32(Console.ReadLine());

        switch (yeniSecim)
        {
            case 1:
                Console.WriteLine(HacimHesapla.KupHacmi());
                break;
            case 2:
                Console.WriteLine(HacimHesapla.KureHacmi());
                break;
            case 3:
                Console.WriteLine(HacimHesapla.SilindirHacmi());
                break;
            case 4:
                Console.WriteLine(HacimHesapla.KoniHacmi());
                break;
            default:
                Console.WriteLine("Geçersiz İşlem");
                break;
        }
    }

    private void CevreIslemleri()
    {
        Console.WriteLine("Çevre Hesabı İşlemleri");
        Console.WriteLine("1. Üçgen Çevresi Hesabı");
        Console.WriteLine("2. Dikdörtgen Çevresi Hesabı");
        Console.WriteLine("3. Daire Çevresi Hesabı");
        Console.WriteLine("4. Kare Çevresi Hesabı");
        int yeniSecim = Convert.ToInt32(Console.ReadLine());

        switch (yeniSecim)
        {
            case 1:
                Console.WriteLine(CevreHesabı.UcgenCevresi());
                break;
            case 2:
                Console.WriteLine(CevreHesabı.DikdortgenCevresi());
                break;
            case 3:
                Console.WriteLine(CevreHesabı.DaireCevresi());
                break;
            case 4:
                Console.WriteLine(CevreHesabı.KareCevresi());
                break;
            default:
                Console.WriteLine("Geçersiz İşlem");
                break;
        }
    }
}

public static class AlanHesabı
{
    public static int UcgenAlani()
    {
        Console.WriteLine("Taban uzunluğunu giriniz:");
        int taban = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yüksekliği giriniz:");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        return taban * yukseklik / 2;
    }

    public static int DikdortgenAlani()
    {
        Console.WriteLine("Kısa kenar uzunluğunu giriniz:");
        int kisaKenar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzun kenar uzunluğunu giriniz:");
        int uzunKenar = Convert.ToInt32(Console.ReadLine());
        return kisaKenar * uzunKenar;
    }

    public static double DaireAlani()
    {
        Console.WriteLine("Yarıçapı giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        return Math.PI * yaricap * yaricap;
    }

    public static int KareAlani()
    {
        Console.WriteLine("Kenar uzunluğunu giriniz:");
        int kenar = Convert.ToInt32(Console.ReadLine());
        return kenar * kenar;
    }
}

public static class HacimHesapla
{
    public static int KupHacmi()
    {
        Console.WriteLine("Kenar uzunluğunu giriniz:");
        int kenar = Convert.ToInt32(Console.ReadLine());
        return kenar * kenar * kenar;
    }

    public static double KureHacmi()
    {
        Console.WriteLine("Yarıçapı giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        return 4 / 3 * Math.PI * yaricap * yaricap * yaricap;
    }

    public static double SilindirHacmi()
    {
        Console.WriteLine("Yarıçapı giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yüksekliği giriniz:");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        return Math.PI * yaricap * yaricap * yukseklik;
    }

    public static double KoniHacmi()
    {
        Console.WriteLine("Yarıçapı giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yüksekliği giriniz:");
        int yukseklik = Convert.ToInt32(Console.ReadLine());
        return 1 / 3 * Math.PI * yaricap * yaricap * yukseklik;
    }
}

public static class CevreHesabı
{
    public static int UcgenCevresi()
    {
        Console.WriteLine("1. Kenar uzunluğunu giriniz:");
        int kenar1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2. Kenar uzunluğunu giriniz:");
        int kenar2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3. Kenar uzunluğunu giriniz:");
        int kenar3 = Convert.ToInt32(Console.ReadLine());
        return kenar1 + kenar2 + kenar3;
    }

    public static int DikdortgenCevresi()
    {
        Console.WriteLine("Kısa kenar uzunluğunu giriniz:");
        int kisaKenar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Uzun kenar uzunluğunu giriniz:");
        int uzunKenar = Convert.ToInt32(Console.ReadLine());
        return 2 * (kisaKenar + uzunKenar);
    }

    public static double DaireCevresi()
    {
        Console.WriteLine("Yarıçapı giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        return 2 * Math.PI * yaricap;
    }

    public static int KareCevresi()
    {
        Console.WriteLine("Kenar uzunluğunu giriniz:");
        int kenar = Convert.ToInt32(Console.ReadLine());
        return 4 * kenar;
    }
}