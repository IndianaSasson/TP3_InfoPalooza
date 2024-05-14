class Cliente
{

    public int DNI {get; private set;}
    public string Nombre {get; private set;}
    public string Apellido {get; private set;}
    public DateTime fechaInscripcion {get; set;}
    public int tipoEntrada {get; set;}
    public int cantidad {get; set;}


    public Cliente(){}

    public Cliente(int dni, string nombre, string apellido, DateTime fechaInsc, int tipo, int cant)
    {
        DNI = dni;
        Nombre = nombre;
        Apellido = apellido;
        fechaInscripcion = fechaInsc;
        tipoEntrada = tipo;
        cantidad = cant;
    }



}

