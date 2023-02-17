Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine();

var (palavras, caracteres) = (texto.Split(' ').Length, texto.Length);

Console.WriteLine($"{caracteres} caracteres, {palavras} palavras");