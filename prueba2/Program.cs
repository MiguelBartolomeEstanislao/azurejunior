// B123
// C234
// A345
// C15
// B177
// G3003
//C235
// B179

string [] orderIDS = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
foreach (string orderID in orderIDS)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}