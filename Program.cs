namespace TP3_InfoPalooza;

class Program
{
    static void Main(string[] args)
    {

        int op;
        Console.WriteLine("1. Nueva Inscripción");
        Console.WriteLine("2. Obtener Estadísticas del Evento");
        Console.WriteLine("3. Buscar Cliente");
        Console.WriteLine("4. Cambiar Entrada de un Cliente");
        Console.WriteLine("5. Salir");

        op = ingresarOpcion("Ingrese la opcion deseada", 1, 5);

        do
        {
            switch (op)
            {
                case 1: 
                    
                break;
            
            }
        } while (op != 5);
        

    }

    public static int ingresarOpcion(string msj, int min, int max)
    {
        int op;

        do
        {
            Console.WriteLine(msj);
            op = int.Parse(Console.ReadLine()); // poner TRY PARSEEEEEEEEEEEEEEEEEEEE
            if (op < min || op > max) Console.WriteLine("ERROR! Ingrese nuevamente");
        
        } while (op < min || op > max);
        return op;
    }
}
