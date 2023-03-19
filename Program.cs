String elegir;
do {
    Console.WriteLine("(1)Area del Circulo || (2)Area del rectangulo ||(3)Salir del programa");

    Console.WriteLine("Ingrese un numero de acuerdo a la función: ");
    elegir = Console.ReadLine();

    if (elegir == "1") {

        Console.Write("Radio del circulo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine($"El area del circulo es: {area}");

        } else if (elegir == "2") {
            
            Console.Write("Base del rectángulo: ");
            double baseR = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura del rectángulo: ");
            double alturaR = Convert.ToDouble(Console.ReadLine());
            
            double area = baseR * alturaR;
            Console.WriteLine($"El area del rectángulo es: {area}");
            } else if (elegir != "3") {
                Console.WriteLine("Numero fuera de rango");
                }
                Console.WriteLine();
                } while (elegir != "3");
                
                Console.WriteLine("Programa terminado");