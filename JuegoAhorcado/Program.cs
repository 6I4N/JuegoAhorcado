namespace JuegoAhorcado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JUEGO DEL AHORCADO | ADIVINA LA PALABRA!");
            Console.WriteLine("Eliga la opción para jugar:");
            Console.WriteLine("1/Un jugador");
            Console.WriteLine("2/Dos jugadores");
            String opcion = Console.ReadLine();
            Console.Clear();

            if (opcion == "1")
            {
                string[] palabras = { "pan", "globo", "parangaricutirimicuaro", "izquierda", "fuego", "triangulo", "ladrillo", "agua", "jugo", "mandarina" };
                Random random = new Random();
                int numRandom = random.Next(0,11);
                char[] letras = palabras[numRandom].ToCharArray();
                int tamañaPalabra = letras.Length;
                int[] posLetras = new int[tamañaPalabra];
                int intentos = 5;
                for(int i = 0; i < tamañaPalabra; i++)
                {
                    posLetras[i] = 0;
                }
                bool juego = true;
                do
                {
                    int checkLetras = 0;
                    Console.WriteLine($"Intentos restantes: {intentos}");
                    for(int h = 0; h < tamañaPalabra; h++)
                    {
                        if (posLetras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            checkLetras++;
                        }
                    }
                    if (checkLetras == tamañaPalabra)
                    {
                        juego = false;
                        Console.WriteLine("\n\n¡Ganaste!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nIngresa una letra:");
                        char ltr = Convert.ToChar(Console.ReadLine());
                        bool checkPos = false;
                        for(int x = 0; x < tamañaPalabra; x++)
                        {
                            if(ltr == letras[x])
                            {
                                posLetras[x] = 1;
                                checkPos = true;
                            }
                        }
                        if(checkPos == false)
                        {
                            intentos--;
                        }
                        if(intentos== 0)
                        {
                            juego = false;
                            Console.WriteLine("\nPERDISTE!");
                        }
                    }
                } while (juego == true);
            }

            if(opcion == "2")
            {
                Console.WriteLine("Un jugador debe ingresar una palabra sin que el otro lo vea");
                string palabra = Console.ReadLine();
                char[] letras = palabra.ToCharArray();
                int tamañaPalabra = letras.Length;
                int[] posLetras = new int[tamañaPalabra];
                int intentos = 5;
                for (int i = 0; i < tamañaPalabra; i++)
                {
                    posLetras[i] = 0;
                }
                bool juego = true;
                do
                {
                    int checkLetras = 0;
                    Console.WriteLine($"Intentos restantes: {intentos}");
                    for (int h = 0; h < tamañaPalabra; h++)
                    {
                        if (posLetras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            checkLetras++;
                        }
                    }
                    if (checkLetras == tamañaPalabra)
                    {
                        juego = false;
                        Console.WriteLine("\n\n¡Ganaste!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nIngresa una letra:");
                        char ltr = Convert.ToChar(Console.ReadLine());
                        bool checkPos = false;
                        for (int x = 0; x < tamañaPalabra; x++)
                        {
                            if (ltr == letras[x])
                            {
                                posLetras[x] = 1;
                                checkPos = true;
                            }
                        }
                        if (checkPos == false)
                        {
                            intentos--;
                        }
                        if (intentos == 0)
                        {
                            juego = false;
                            Console.WriteLine("\nFIN DEL JUEGO!");
                        }
                    }
                } while (juego == true);
            }
        }
    }
}
