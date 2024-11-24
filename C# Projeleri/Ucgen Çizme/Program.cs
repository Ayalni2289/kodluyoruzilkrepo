Ucgen ucgen = new Ucgen();
ucgen.Yaz();

class Ucgen{
    public void Yaz(){
        int i, j, k, n;
        
        Console.Write("Ucgen Yüksekliği Giriniz: ");
        n = Convert.ToInt32(Console.ReadLine());

        for(i = 1; i <= n; i++){
            for(j = 1; j <= n - i; j++){
                Console.Write(" ");
            }
            for(k = 1; k <= 2 * i - 1; k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}