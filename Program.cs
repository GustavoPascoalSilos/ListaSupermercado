// See https://aka.ms/new-console-template for more information



int QTE = 0;

//Solicitar o tamanho da lista
Console.WriteLine("Quantos itens sua lista possuirá? ");
QTE = int.Parse(Console.ReadLine());
Console.Clear();


string[] lista = new string[QTE];

// solicitar os itens da lista
for (int i = 0; i < QTE; i++)
{
    Console.WriteLine($"{i + 1}° item da lista ");
    lista[i] = Console.ReadLine();
    Console.Clear();


    // verifica se os itens se repetem na lista
   
    string desejaInserir = "";
    do
    {
        Console.WriteLine();

        
        int posicao = 0;
        bool encontrou = false;

        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i].ToUpper() == 
            {
                posicao = i;
                encontrou = true;
            }
        }

        if (encontrou)
            Console.WriteLine();
        else
            Console.WriteLine();

        Console.WriteLine("Deseja inserir novamente? (s/n)");
        desejaInserir = Console.ReadLine();
    } while (desejaInserir != "n");
}


//imprime a lista 
for (int i = 0; i < QTE; i++)
{
    Console.WriteLine($"{i + 1}°{lista[i]} ");
}
