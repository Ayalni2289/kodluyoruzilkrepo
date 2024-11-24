Fibonacci fibonacci = new Fibonacci();
fibonacci.Yazdir();
class Fibonacci{
    private float ortalamaHesapla(int depth){
        if(depth==1){
            return 0;
        }

            int[] fib = new int[depth];
            fib[0]= 0;
            fib[1]= 1;
            for(int i = 2; i < depth; i++){
                fib[i] = fib[i-1] + fib[i-2];
            }
            int sum = 0;
            for(int i = 0; i < depth; i++){
                sum += fib[i];
            }
            return (float)sum/depth;
    }

    public void Yazdir(){
        Console.WriteLine("Ortalama hesaplanacak fibonacci serisi derinliğini giriniz: ");
        int derinlik = Convert.ToInt32(Console.ReadLine());

        if(derinlik <= 0){
            Console.WriteLine("Derinlik 0'dan büyük olmalıdır.");
        }
        else{
            float ortalama = ortalamaHesapla(derinlik);
            Console.WriteLine("Ortalama: " + ortalama);
        }
    }
}