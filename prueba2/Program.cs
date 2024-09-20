string customerName = "Ms. Barros";
string currentProduct = "Magic Yield";

int currentShares = 2975000;
string currentSharesFormatted = currentShares.ToString("N0");


decimal currentReturn = 0.1275m;
decimal currentReturnFormatted = currentReturn * 100;
string currentReturnFormattedString = currentReturnFormatted.ToString("F2");

decimal currentProfit = 55000000.0m;
string newProduct = "Glorious Future";

decimal newReturn = 0.13125m;
decimal newReturnFormatted = newReturn * 100;
string newReturnFormattedString = currentReturnFormatted.ToString("F2");

decimal newProfit = 63000000.0m;
string formattedProfit = newProfit.ToString("C2");

Console.Clear();

string saludo = ($"Dear {customerName},");
Console.WriteLine(saludo);
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return. \n");
Console.WriteLine($"Currently, you own {currentSharesFormatted} shares at a return of {currentReturnFormattedString}% \n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturnFormattedString}.  Given your current volume, your potential profit would be {formattedProfit}. \n");
Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine($"{currentProduct, -20} {currentReturn:P2} {currentProfit,20:C2}");
Console.WriteLine($"{newProduct, -20} {newReturn:P2} {newProfit,20:C2}");






