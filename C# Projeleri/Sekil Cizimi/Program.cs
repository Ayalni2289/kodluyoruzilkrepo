DaireCiz daireCiz = new DaireCiz();
daireCiz.Ciz();

class DaireCiz{
    public void Ciz(){
        int r, i, j;
        
        Console.Write("Dairenin Yarıçapını Giriniz: ");
        r = Convert.ToInt32(Console.ReadLine());
        
        for(i = -r; i <= r; i++){
            for(j = -r; j <= r; j++){
                if(i * i + j * j <= r * r){
                    Console.Write("*");
                }else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}