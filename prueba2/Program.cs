// Inicializar la salud del héroe y el monstruo
        int heroHealth = 10;
        int monsterHealth = 10;
        Random random = new Random();

        // Bucle del juego
        do
        {
            // El héroe ataca primero
            int heroAttack = random.Next(1, 11); // Valor aleatorio entre 1 y 10
            monsterHealth -= heroAttack; // Reducir la salud del monstruo
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

            // Comprobar si el monstruo ha sido derrotado
            if (monsterHealth <= 0)
            {
                Console.WriteLine("Hero wins!");
                break;
            }

            // El monstruo ataca si sigue vivo
            int monsterAttack = random.Next(1, 11); // Valor aleatorio entre 1 y 10
            heroHealth -= monsterAttack; // Reducir la salud del héroe
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

            // Comprobar si el héroe ha sido derrotado
            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster wins!");
                break;
            }

        } while (heroHealth > 0 && monsterHealth > 0); // Continuar mientras ambos tengan salud

        Console.ReadLine(); // Para evitar que la consola se cierre inmediatamente
    
