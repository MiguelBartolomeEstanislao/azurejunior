// Random random = new Random();
// var daysUntilExpiration = random.Next(12);
// var discountPercentage = 20;

//Your subscription will expire soon. Renew now!
//Your subscription expires in _ days.
//Your subscription expires within a day! Renew now and save 20%!
//Your subscription has expired.

//Console.Clear();

//Console.WriteLine($"Days to expiration: {daysUntilExpiration}");

//if (daysUntilExpiration > 10)
{ 
    // Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//else if (daysUntilExpiration <=5 && daysUntilExpiration > 1)
{ 
//    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
}
//lse if (daysUntilExpiration == 1)
{ 
    // Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
}

//else //
// { Console.WriteLine("Your subscription has expired");
    
// } 
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        var discountPercentage = 20;
        bool continueRunning = true; // Variable para controlar el bucle

        while (continueRunning)
        {
            // Generar un nuevo número aleatorio
            var daysUntilExpiration = random.Next(12);
            
            // Limpiar la pantalla antes de mostrar el mensaje (opcional)
            Console.Clear();

            // Mostrar el resultado
            Console.WriteLine($"Days to expiration: {daysUntilExpiration}");

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }

            // Preguntar al usuario si desea ver el resultado de nuevo
            Console.WriteLine("Press 'R' to generate a new number or 'Q' to quit.");
            var userInput = Console.ReadKey(true); // 'true' para no mostrar la tecla en la consola

            if (userInput.Key == ConsoleKey.Q)
            {
                continueRunning = false; // Salir del bucle si el usuario presiona 'Q'
            }
            // Si el usuario presiona 'R', el bucle continuará y generará un nuevo número aleatorio
        }
    }
}

