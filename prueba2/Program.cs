string [] values = {"12.3", "45", "ABC", "11", "DEF"};
var mensaje = "";
var total = 0.0;
var resultado = 0.0;

foreach (var value in values) 
{
if (double.TryParse(value, out resultado)) 
{ total += resultado; }
else
{ mensaje += value;}
}

Console.WriteLine("Mensaje" + mensaje);
Console.WriteLine("Total" + total);