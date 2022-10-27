// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "Bistecca di maiale", "Tordelli Lucchesi", "Risotto ai frutti di mare", "Spaghetti allo scoglio", "Pizza", "Pasta all' arrabbiata", "Brodo di verdura" };

Console.WriteLine("Lunghezza classifica cibi: " + cibiPreferiti.Length);
Console.WriteLine("Classifica cibi: ");

for (int i = 0; i < cibiPreferiti.Length; i++)
{

    Console.WriteLine(i+1 + " " + cibiPreferiti[i]);
}

Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
Console.WriteLine("il mio cibo preferito ma non troppo è " + cibiPreferiti[cibiPreferiti.Length-1]);
Console.WriteLine("il mio cibo mediamente preferito è " + cibiPreferiti[cibiPreferiti.Length/2]);