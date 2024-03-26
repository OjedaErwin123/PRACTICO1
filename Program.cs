// See https://aka.ms/new-console-template for more information
            Console.WriteLine("Calculadora de MRUA");
            Console.Write("Ingrese la velocidad inicial (m/s): ");
            double velocidadInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la aceleración (m/s^2): ");
            double aceleracion = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tiempo (s): ");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            double distancia = velocidadInicial * tiempo + 0.5 * aceleracion * Math.Pow(tiempo, 2);
            Console.WriteLine($"La distancia recorrida es: {distancia} metros");
            double distancia2 = (distancia * 1)/1000;
            Console.WriteLine($"La distancia recorrida es: {distancia2} kilometros");
