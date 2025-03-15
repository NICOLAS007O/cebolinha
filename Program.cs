string cebolinha;

Console.WriteLine("--- Exercico Cebolinha ---");

Console.WriteLine(@"Eu troco as letras, não  falo bem, mas meus amigos não troco por ninguém
Escreva a frase que deseja converter:"
);

cebolinha = Console.ReadLine();

cebolinha = cebolinha.Replace("r", "l");

Console.WriteLine(cebolinha);