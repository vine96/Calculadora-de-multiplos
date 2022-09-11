using System;

Console.WriteLine("Digite um valor: ");
var strEntrada = Console.ReadLine();
if (strEntrada != null)
{
    int num = 0;
    if (int.TryParse(strEntrada, out num))
    {
        int[] arrNum = new int[num];
        int soma = 0;

        Console.WriteLine("Os números múltiplos de 3 e 5 do valor "+ num + " são: ");

        for (int i = 0; i < num; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                arrNum[i] = i;
                soma += i;
                Console.Write(arrNum[i] + " ");
            }
        }

        Console.WriteLine("\n\nA soma de todos os valores é: " + soma);
    }
    else
    {
        Console.WriteLine("Você precisa digitar um número inteiro!");
    }
}
else
{
    Console.WriteLine("Você precisa digitar um número!");
}
