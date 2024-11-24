Console.WriteLine("Ters Çevrilecek İfadeyi Giriniz.");
string input= Console.ReadLine();

input.Split(" ").ToList().ForEach(x => Console.Write(new string(x.Reverse().ToArray()) + " "));
