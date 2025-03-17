
Console.Clear();

String especiePet= "GATO";
String racaPet= "siames";
String nomePet= "charlie";
String idadePet= "3";
String pelagemPet= "frajola";
String nomeTutor= "Gabi";
String contatoTutor= "13991";

/*
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("        💖 Bem vindo 💖         "); Thread.Sleep(1000);
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("            CADASTRO             ");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("🐾🌤️ Pet Hotel Raio de Sol 🌤️🐾 "); Thread.Sleep(1300);
Console.ResetColor();

Console.WriteLine();
Console.WriteLine("Digite os dados solicitados: "); Thread.Sleep(500);
Console.WriteLine();

Console.Write("☀️ Espécie         : "); especiePet= Console.ReadLine()!;
Console.Write("☀️ Raça            : "); racaPet= Console.ReadLine()!;
Console.Write("☀️ Nome do pet     : "); nomePet= Console.ReadLine()!;
Console.Write("☀️ Idade           : "); idadePet= Console.ReadLine()!;
Console.Write("☀️ Pelagem/cor     : "); pelagemPet= Console.ReadLine()!;
Console.Write("☀️ Tutor (Seu nome): "); nomeTutor= Console.ReadLine()!;
Console.Write("☀️ Telefone        : "); contatoTutor= Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Obrigada 💕"); Thread.Sleep(1000);
Console.ResetColor();

Console.WriteLine(@$"
+=========================================================+
|                 Pet Hotel ""Nem um pio""                  |
+=========================================================+
| Espécie:{especiePet.PadLeft(10, '.')} | Raça:  |
+=========================================================+
| Atende pela alcunha de: ...........................ZECA |
| Idade: 03 ano(s) | Pelagem/cor: ...............CARAMELO |
+=========================================================+");
*/

Console.Clear();
Console.WriteLine(@$"
🟪〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕
 |              🌤️   Pet Hotel Raio de Sol 🌤️                |
➕➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➕
 | Espécie:{especiePet.PadLeft(16, '.').ToUpper()} | Raça: ............INDEFINIDA |
⬜➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➕
⬜ Nome do pet:.......................................ZECA |
⬜ Idade: 03 ano(s) | Pelagem/cor: ...............CARAMELO |
🔲➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➕

💘💘💘💘💘
,,,,,,,,,,
");


Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");
Console.Write(" |                  ");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(" Pet Hotel Raio de Sol");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" 🌤️               | ");
Console.WriteLine(" |               🌤️    Ficha de inscrição                   | ");

Console.WriteLine("➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");

Console.ResetColor();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Espécie: {especiePet.PadRight(15, ' ').ToUpper()}| Raça: {racaPet.PadRight(23, ' ').ToUpper()} | ");
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Nome do Pet: {nomePet.PadRight(43, ' ').ToUpper()}| ");
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");

Console.ResetColor();


