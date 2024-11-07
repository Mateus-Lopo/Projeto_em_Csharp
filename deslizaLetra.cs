// See https://aka.ms/new-console-template for more information


// Projeto feito com o visual studio 2022
string frase;
Console.WriteLine("Escreva uma frase: ");
frase = Console.ReadLine();
int vTam = frase.Length;

for (int n = 0; n < vTam; n++)
{
    for (int i = 60; i >= 10+n; i--)
    {

        string sub = frase.Substring(n, 1);
        Console.SetCursorPosition(i, 10);
        Console.WriteLine(sub);
        Thread.Sleep(100);
        Console.SetCursorPosition(i, 10);
        if (10 + n < i)
        {
            Console.WriteLine(" ");
        }
    }
    
}
Console.Clear();