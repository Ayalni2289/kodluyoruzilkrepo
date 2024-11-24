Console.WriteLine("Bir string bir de sayi girniz aralarında virgül koyarak");
string[] girdi = Console.ReadLine().Split(',');

string kelime = girdi[0];
int sayi = Convert.ToInt32(girdi[1]);

Console.WriteLine(kelime.Remove(sayi, 1));