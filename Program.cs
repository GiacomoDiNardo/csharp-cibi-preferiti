// See https://aka.ms/new-console-template for more information


//Esercizio mattina

//string[] cibiPreferiti = { "Bistecca di maiale", "Tordelli Lucchesi", "Risotto ai frutti di mare", "Spaghetti allo scoglio", "Pizza", "Pasta all' arrabbiata"};

//Console.WriteLine("Lunghezza classifica cibi: " + cibiPreferiti.Length);
//Console.WriteLine("Classifica cibi: ");

//for (int i = 0; i < cibiPreferiti.Length; i++)
//{

//    Console.WriteLine(i+1 + ". " + cibiPreferiti[i]);
//}

//Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
//Console.WriteLine("il mio cibo preferito ma non troppo è " + cibiPreferiti[cibiPreferiti.Length-1]);

//if(cibiPreferiti.Length % 2 == 0)
//{
//    Console.WriteLine("i miei cibi mediamente preferiti sono " + cibiPreferiti[cibiPreferiti.Length / 2 - 1] + " e " + cibiPreferiti[cibiPreferiti.Length / 2]);
//} else
//{
//    Console.WriteLine("il mio cibo mediamente preferito è " + cibiPreferiti[cibiPreferiti.Length / 2]);
//}

//Console.WriteLine();

//Esercizio Pomeriggio

//Snack 1
//L’utente inserisce due numeri in successione. Il software stampa il maggiore.

//Console.WriteLine("inserisci due numeri:");

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());

//if(num1 > num2)
//{
//    Console.WriteLine();
//    Console.WriteLine("il numero più alto è: " + num1);
//} else
//{
//    Console.WriteLine();
//    Console.WriteLine("il numero più alto è: " + num2);
//}

//Snack2.
//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine();


//Console.WriteLine("inserisci due parole:");

//string parola1 = Console.ReadLine();
//string parola2 = Console.ReadLine();

//if (parola2.Length > parola1.Length)
//{
//    Console.WriteLine();

//    Console.WriteLine("La parola più corta è {1}, la più lunga è {0}.", parola2, parola1);
//}else
//{
//    Console.WriteLine();

//    Console.WriteLine("La parola più corta è {0}, la più lunga è {1}.", parola2, parola1);
//}

//Snack3.
//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//Console.WriteLine();
//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("inserisci un numero");
//    int num = Convert.ToInt32(Console.ReadLine());
//    somma = somma + num;
//}

//Console.WriteLine();

//Console.WriteLine("la somma dei valori inseriti è: " + somma);


//Snack4.
//Calcola la somma e la media dei numeri da 2 a 10.


//Snack5.
//Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
//stampa il numero, se è dispari, stampa il numero successivo.

//Console.WriteLine();

//Console.WriteLine("inserisci un numero:");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number % 2 == 0)
//{
//Console.WriteLine("il numero pari più vicino è: " + number);
//}else
//{
//    Console.WriteLine("il numero pari successivo è: " + (number + 1));
//}

//Snack6.
//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
//festa.
//Console.WriteLine();

//Console.WriteLine("inserisci il tuo nome");

//Console.WriteLine();

//string[] invitati = { "marco", "matteo", "giovanni", "luca", "fabio" };

//string nome = Console.ReadLine();
//bool accettato = false;
//for (int i = 0; i < invitati.Length; i++)
//{
//    if (nome == invitati[i])
//    {
//        accettato = true;
//        break;
//    }
//}

//if(accettato == true)
//{
//    Console.WriteLine("il suo nome è tra gli invitati, può entrare.");


//}else
//{
//    Console.WriteLine("non è tra gli invitati, mi dispiace.");
//}

//Snack7.
//Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array

//int[] sixNumbers = new int[6];
//for(int i = 0; i < sixNumbers.Length; i++)
//{
//    Console.WriteLine("inserisci un numero:");
//    int insertNum = Convert.ToInt32(Console.ReadLine());
//    if(insertNum % 2 != 0)
//    {
//    sixNumbers[i] = insertNum;
//    }
//}

//Snack8.
//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.

//Console.WriteLine();

//int[] ints = { 4, 6, 7, 2, 5, 3, 9, 6, 3, 5, 1, 34 };
//int sum = 0;

//for (int i = 0; i < ints.Length; i++)
//{

//    if (i % 2 != 0)
//    {
//        sum = sum + ints[i];
//    }
//}

//Console.WriteLine("la somma dei valori in posizione dispari è " + sum);

//Snack9.
//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.

//int[] sum50 = new int[50];
//int somma = 0;
//int i = 0;

//while (somma < 50)
//{
//    Console.WriteLine("inserisci un numero");
//    int insertNum = Convert.ToInt32(Console.ReadLine());

//    somma = somma + insertNum;

//    sum50[i] = insertNum;
//    i++;
//}

//Console.WriteLine("la somma dei numeri inseriti è " + somma);

//Snack10.
//Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("inserisci il numero di array desiderati");

int n = Convert.ToInt32(Console.ReadLine());
Random randNum = new Random();

for (int i = 0; i < n; i++)
{
    int[] arrayN = new int[10];
    Console.WriteLine();
    for (int j = 0; j < 10; j++)
    {
        arrayN[j] = randNum.Next(1,101);
        Console.WriteLine(arrayN[j]);
    }
}