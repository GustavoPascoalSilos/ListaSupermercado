
using System.Reflection;

int QTE = 0;
string item = "";


//Solicitar o tamanho da lista
Console.WriteLine("Quantos itens sua lista possuirá? ");
QTE = int.Parse(Console.ReadLine());
Console.Clear();


string[] lista = new string[QTE];

// solicitar os itens da lista
for (int i = 0; i < QTE; i++)
{
    Console.WriteLine($"{i + 1}° item da lista ");
    item = Console.ReadLine();
   
    // Verificar itens repetidos
    bool  encontrouItem = false;
    for (int j = 0; j < lista.Length; j++)
    {
        if (lista[j] != null)
        {
            if (item.ToUpper() == lista[j].ToUpper())
            {
                encontrouItem = true;
            }
        }
    }

    if (!encontrouItem)

        lista[i] = item;
    else
    {
        
        Console.WriteLine("Não é possivel adicionar o mesmo item!");
        i--;
    }

}
// imprime os itens da lista
Console.Clear();
Console.WriteLine("LISTA DE ITENS");
for (int i = 0;i < lista.Length;i++)
{
    Console.WriteLine($"{i+1}°{lista[i]}");
}

   




