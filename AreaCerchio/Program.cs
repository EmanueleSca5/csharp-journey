Console.WriteLine("Dimmi il raggio del tuo cerchio");
string? textRaggio = Console.ReadLine();

if(double.TryParse(textRaggio, out double raggio))
{
    double areaCerchio = Math.Pow(raggio, 2) * Math.PI;
    Console.WriteLine($"Il risultato è {areaCerchio:F2}");
}
else
{
    Console.WriteLine("Non hai inserito un numero valido");
}