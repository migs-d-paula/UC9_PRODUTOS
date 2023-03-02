string[,] matriz = new string[6, 5];
string pergunta = "", r = "s";
int i, j, produto = 0;
double preco = 0, total = 0;

matriz[0, 0] = "0";
matriz[1, 0] = "1";
matriz[2, 0] = "2";
matriz[3, 0] = "3";
matriz[4, 0] = "4";
matriz[5, 0] = "5";


for (i = 0; i <= 5; i++)
{
    for (j = 1; j <= 4; j++)
    {
        if (j == 1)
        {
            pergunta = "Qual o nome do produto " + (i + 1) + "?";
        }
        if (j == 2)
        {
            pergunta = "Qual o tipo do produto " + (i + 1) + "?";
        }
        if (j == 3)
        {
            pergunta = "Qual a cor do produto " + (i + 1) + "?";
        }
        if (j == 4)
        {
            pergunta = "Qual o preço do produto " + (i + 1) + "?";
        }

        Console.WriteLine(pergunta);
        matriz[i, j] = Console.ReadLine();

        Console.Clear();
    }
}


while (r == "s" || r == "S")
{
    Console.Clear();
    for (i = 0; i <= 5; i++)
    {
        for (j = 0; j <= 4; j++)
        {
            Console.Write(" " + matriz[i, j] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("\n\nqual produto quer comprar? (Utilize o numero das linhas)");
    produto = int.Parse(Console.ReadLine());

    preco = double.Parse(matriz[produto, 4]);

    total = total + preco;

    Console.WriteLine("\n\nvoce desejar comprar mais algo? (Utilize S ou N)");
    r = Console.ReadLine();
}


Console.Clear();

Console.WriteLine("O preço total foi: " + total);