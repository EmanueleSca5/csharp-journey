// Console.WriteLine("Sto imparando C#");
// Console.WriteLine("Seconda riga");

// string citta = "Roma";
// int anni = 25;

// Console.WriteLine(citta);
// Console.WriteLine(anni);

// Console.WriteLine($"Abito a {citta} e hp {anni}.");

// Console.WriteLine("Quale è il tuo colore preferito?");

// string? colore = Console.ReadLine();

// Console.WriteLine($"il tuo colore preferito è {colore}");

// *ReadLine restituisce sempre testo, quindi in caso di inserimento numero andrà convertito

// Console.WriteLine("Quanti anni hai?");
// string? eta = Console.ReadLine();

// int? anni = int.Parse(eta);

// int? annodopo = anni + 1;
// Console.WriteLine($"Tra un anno avrai {annodopo} anni");

// string a = "20";
// int b = 20;
// Console.WriteLine(a + 1);
// Console.WriteLine(b + 1);

// Console.WriteLine("Come ti chiami?");
// string? name = Console.ReadLine();

// Console.WriteLine("Quanti anni hai?");
// string? agetxt = Console.ReadLine();


// int age = int.Parse(agetxt);
// int nextyear = age + 1;

// Console.WriteLine($"Ciao {name}, ora hai {age} anni, l anno prossimo avrai {nextyear} anni");


// Console.WriteLine("Quante tazze di caffe hai bevuto?");
// string? caffe = Console.ReadLine();

// if(int.TryParse(caffe, out int numeroCaffe))
// {
//     Console.WriteLine($"Hai bevuto {numeroCaffe} caffe");
// }
// else
// {
//     Console.WriteLine("Non hai inserito un numero valido");
// }

Console.WriteLine("Come ti chiami?");
string? name = Console.ReadLine();

Console.WriteLine("Quanti anni hai?");
string? agetxt = Console.ReadLine();


if(int.TryParse(agetxt, out int age))
{
    int nextyear = age + 1;
    Console.WriteLine($"Ciao {name} , hai {age} anni e l anno prossimo avrai {nextyear} anni");
}
else
{
    Console.WriteLine($"Ciao {name}, purtroppo non hai inserito un numero quindi non conosco la tua età");
}

