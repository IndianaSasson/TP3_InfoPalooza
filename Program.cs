namespace TP3_InfoPalooza;

class Program
{
    static void Main(string[] args)
    {
        
        
        int op, clientes = 0;



        op = ingresarOpcion("Ingrese la opcion deseada", 1, 5);
        do
        {
            switch (op)
            {
                case 1:
                
                    ingresarDatosClientes();
                    clientes++;

                break;

                case 2:
                    List<string> ResultadosEstadistica = Ticketera.MostrarEstadisticas();
                    foreach (String item in ResultadosEstadistica) Console.WriteLine(item);
                    
                break;

                case 3:
                    int id = ingresarInt("Ingrese el ID de el cliente que quiere buscar:", 1, clientes+1);
                    Cliente obj = new Cliente ();
                    obj = Ticketera.buscarCliente(id);
                    
                    Console.WriteLine("El dni del cliente es: " + obj.DNI);
                    Console.WriteLine("El nombre del cliente es: " + obj.Nombre);
                    Console.WriteLine("El apellido del cliente es: " + obj.Apellido);
                    Console.WriteLine("La fecha en la que el cliente se inscribió fue: " + obj.fechaInscripcion);
                    Console.WriteLine("El tipo de entrada que compro el cliente es: " + obj.tipoEntrada);
                    Console.WriteLine("La cantidad de tickets que compró fue: " + obj.cantidad);

                break;

                case 4:

                break;
            
            }
            op = ingresarOpcion("Ingrese la opcion deseada", 1, 5);

        } while (op != 5);
        

    }


    public static void ingresarDatosClientes()
    {
        int valor = int.MaxValue;
        
        int dni = ingresarInt("Ingrese su DNI", 0, valor);
        string nombre = ingresarString("Ingrese su nombre");
        string apellido = ingresarString("Ingrese su apellido");
        DateTime fecha = ingresarFecha("Ingrese su fecha de inscripción");
        int tipoEntrada = ingresarInt("Ingrese su tipo de entrada (1, 2, 3, 4)", 1, 4);
        int cant = ingresarInt("Ingresa la cantidad de entradas que desea", 1, valor);
        
        Cliente UnCLiente = new Cliente(dni, nombre, apellido, fecha,tipoEntrada, cant);
        int NroTicket = Ticketera.AgregarCliente(UnCLiente);
        Console.WriteLine("Compraste entradas. Tu numero de ticket de compra es " + NroTicket);

    }

    public static DateTime ingresarFecha(string msj)
    {
        DateTime fecha;
        do
        {
             Console.WriteLine(msj);
             fecha = DateTime.Parse(Console.ReadLine());
             if (fecha > DateTime.Today) Console.WriteLine("ERROR! Ingrese nuevamente");
        } while (fecha > DateTime.Today);
        return fecha; 
    }

    public static string ingresarString(string msj)
    {
        string caracteres;
        do
        {
            Console.WriteLine(msj);
            caracteres = Console.ReadLine();
            if (caracteres == string.Empty) Console.WriteLine("ERROR! Ingrese nuevamente");
        } while (caracteres == string.Empty);
        return caracteres;
    }

    public static int ingresarInt(string msj, int min, int max)
    {
        int num;
        do
        {
            Console.WriteLine(msj);
            num = int.Parse(Console.ReadLine()); // poner TRY PARSEEEEEEEEEEEEEEEEEEEE
            if (num < min || num > max) Console.WriteLine("ERROR! Ingrese nuevamente");
        } while (num < min || num > max);
        return num;
    }
    public static int ingresarOpcion(string msj, int min, int max)
    {
        int op;

        
        Console.WriteLine("1. Nueva Inscripción");
        Console.WriteLine("2. Obtener Estadísticas del Evento");
        Console.WriteLine("3. Buscar Cliente");
        Console.WriteLine("4. Cambiar Entrada de un Cliente");
        Console.WriteLine("5. Salir");

        do
        {
            Console.WriteLine(msj);
            op = int.Parse(Console.ReadLine()); // poner TRY PARSEEEEEEEEEEEEEEEEEEEE
            if (op < min || op > max) Console.WriteLine("ERROR! Ingrese nuevamente");
        
        } while (op < min || op > max);
        return op;
    }
}
