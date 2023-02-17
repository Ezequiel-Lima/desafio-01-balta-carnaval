Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine();

int palavras = 0, caracteres = 0;
if (!string.IsNullOrEmpty(texto))
    (palavras, caracteres) = (texto.Split(' ').Length, texto.Length);

Console.WriteLine($"{caracteres} caracteres, {palavras} palavras");