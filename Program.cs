
Console.Clear();

String especiePet;
String racaPet;
String nomePet;
String idadePet;
String pelagemPet;
String nomeTutor;
String contatoTutor;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("          💖 Bem vindo 💖           "); Thread.Sleep(1000);
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("            CADASTRO             ");
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("🐾 🌤️  Pet Hotel Raio de Sol  🌤️ 🐾 "); Thread.Sleep(1300);
Console.ResetColor();

Console.WriteLine();
Console.WriteLine("Digite os dados solicitados: "); Thread.Sleep(500);
Console.WriteLine();

Console.Write("☀️  Espécie         : "); especiePet= Console.ReadLine()!;
Console.Write("☀️  Raça            : "); racaPet= Console.ReadLine()!;
Console.Write("☀️  Nome do pet     : "); nomePet= Console.ReadLine()!;
Console.Write("☀️  Idade           : "); idadePet= Console.ReadLine()!;
Console.Write("☀️  Pelagem/cor     : "); pelagemPet= Console.ReadLine()!;
Console.Write("☀️  Tutor (Seu nome): "); nomeTutor= Console.ReadLine()!;
Console.Write("☀️  Telefone        : "); contatoTutor= Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Obrigada 💕"); Thread.Sleep(500);
Console.WriteLine("Aqui está sua ficha:"); Thread.Sleep(1500);
Console.ResetColor();
Console.Clear();



Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");
Console.Write(" |                  ");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write(" Pet Hotel Raio de Sol");

Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" 🌤️               | ");
Console.WriteLine(" |               🌤️     Ficha de cadastro                   | ");

Console.WriteLine("➕〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️〰️➕ ");

Console.ResetColor();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Espécie: {especiePet
    .PadRight(15, ' ')
    .ToUpper()
    .Substring(0, 15)}| Raça: {racaPet
    .PadRight(23, ' ')
    .ToUpper()
    .Substring(0, 23)} | ");
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Nome do Pet: {nomePet
    .PadRight(43, ' ')
    .ToUpper()
    .Substring(0, 43)}| ");
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Idade do Pet: {idadePet
    .PadRight(10, ' ')
    .ToUpper()
    .Substring(0, 10)}| Pelagem (cor): {pelagemPet
    .PadRight(14, ' ')
    .ToUpper()
    .Substring(0, 14)} | ");
Console.WriteLine(" |➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖ | ");
Console.WriteLine($" | Nome do tutor: {nomeTutor
    .PadRight(41, ' ')
    .ToUpper()
    .Substring(0, 41)}| ");
Console.WriteLine($" | Contato: {contatoTutor
    .PadRight(47, ' ')
    .ToUpper()
    .Substring(0, 47)}| ");
Console.WriteLine("➕➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➖➕ ");


Console.ResetColor();


