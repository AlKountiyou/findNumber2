using System.Collections;

int number = 0;
ArrayList choix = new ArrayList();
int i = 0;
entrerNombre:
    Console.WriteLine("Entrer un nombre compris entre 1 et 10:");
    string stringNumber = Console.ReadLine();

if(!int.TryParse(stringNumber, out number))
{
    choix.Add(stringNumber);
    goto entrerNombre;
}
else
{
    if(number < 1 || number > 10)
    {
        choix.Add(number);
        goto entrerNombre;
    }
}
if (number == 5)
{
    Console.WriteLine("Vous avez gagné");
    Console.WriteLine("Tentatives: ");
    foreach(var nbr in choix)
    {
        Console.Write(nbr + " ");
    }
}
else
{
    Console.WriteLine("c'est pas bon!");
    choix.Add(number);
    goto entrerNombre;
}

