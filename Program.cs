// See https://aka.ms/new-console-template for more information

//Esercizio mattina

string[] cibiPreferiti = { "Bistecca di maiale", "Tordelli Lucchesi", "Risotto ai frutti di mare", "Spaghetti allo scoglio", "Pizza", "Pasta all' arrabbiata"};

Console.WriteLine("Lunghezza classifica cibi: " + cibiPreferiti.Length);
Console.WriteLine("Classifica cibi: ");

for (int i = 0; i < cibiPreferiti.Length; i++)
{

    Console.WriteLine(i+1 + ". " + cibiPreferiti[i]);
}

Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
Console.WriteLine("il mio cibo preferito ma non troppo è " + cibiPreferiti[cibiPreferiti.Length-1]);

if(cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine("i miei cibi mediamente preferiti sono " + cibiPreferiti[cibiPreferiti.Length / 2 - 1] + " e " + cibiPreferiti[cibiPreferiti.Length / 2]);
} else
{
    Console.WriteLine("il mio cibo mediamente preferito è " + cibiPreferiti[cibiPreferiti.Length / 2]);
}

Console.WriteLine();

//Esercizio Pomeriggio

//Snack 1
//L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("inserisci due numeri:");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("il numero più alto è: " + num1);
} else
{
    Console.WriteLine("il numero più alto è: " + num2);
}

//Snack2.
//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("inserisci due parole:");

string parola1 = Console.ReadLine();
string parola2 = Console.ReadLine();

if (parola2.Length > parola1.Length)
{
    Console.WriteLine("La parola più lunga è {0}, la più corta è {1}.", parola2, parola1);
}else
{
    Console.WriteLine("La parola più lunga è {1}, la più corta è {0}.", parola2, parola1);
}

