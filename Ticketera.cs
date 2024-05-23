static class Ticketera
{
    private static Dictionary<int, Cliente> dicCliente = new Dictionary<int, Cliente>();
    private static int ultimoIDEntrada = 0;
    private static int[] PreciosTipo = new int[5]{0,45000,60000,30000,100000};
    
    public static int AgregarCliente(Cliente UnCliente){
        ultimoIDEntrada++;
        dicCliente.Add(ultimoIDEntrada,UnCliente);
        return ultimoIDEntrada;
       
    }

    public static Cliente buscarCliente(int id)
    {
        if (dicCliente.ContainsKey(id))
        {
             return dicCliente[id];
        }
        else
        {
            return null;
        }
       
    }

   public static bool cambiarEntrada(Cliente obj, int nuevaEntrada)
   {
        int entradaAnterior = obj.tipoEntrada;
        if (PreciosTipo[nuevaEntrada] > PreciosTipo[entradaAnterior])
        {
            obj.tipoEntrada = nuevaEntrada;
            return true;
        }
        else
        {
            return false;
        }
   }

    public static List<string> MostrarEstadisticas(){
        
        List<string> Lista = new List<string>();
      
        //Calcular
        int total = 0;
        int[] cantPorEntrada = new int[5];
        double[] cantPorTicket = new double[5];
        double cantTotalEntradas = 0;
        foreach (Cliente item in dicCliente.Values)
        {
            
            cantTotalEntradas = cantTotalEntradas + item.cantidad;
            cantPorEntrada[item.tipoEntrada] ++;
            cantPorTicket[item.tipoEntrada] += item.cantidad;

            total += item.cantidad * PreciosTipo[item.tipoEntrada];
        }
        Lista.Add("La cantidad de Clientes inscriptos es: " + dicCliente.Count.ToString());
        Lista.Add("La cantidad de personas que compraron la entrada 1 son: " + cantPorEntrada[1] + "  La cantidad de personas que compraron la entrada 2 son: " + cantPorEntrada[2] + "  La cantidad de personas que compraron la entrada 3 son: " + cantPorEntrada[3] + "  La cantidad de personas que compraron la entrada 4 son: " + cantPorEntrada[4]);        
        
        Lista.Add("El porcentaje de la cantidad de tipo 1 es de: " + (cantPorTicket[1] / cantTotalEntradas *100) + "  El porcentaje de la cantidad de tipo 2 es de: " + (cantPorTicket[2] / cantTotalEntradas *100) + 
                  "El porcentaje de la cantidad de tipo 3 es de: " + (cantPorTicket[3] / cantTotalEntradas *100) + "  El porcentaje de la cantidad de tipo 4 es de: " + (cantPorTicket[4] / cantTotalEntradas *100));
        
        Lista.Add("La recaudación total de las entradas de tipo 1 es de: $" + (cantPorTicket[1] * PreciosTipo[1]) + "  La recaudación total de las entradas de tipo 2 es de: $" + (cantPorTicket[2] * PreciosTipo[2]) + 
                  "La recaudación total de las entradas de tipo 3 es de: $" + (cantPorTicket[3] * PreciosTipo[3]) + "  La recaudación total de las entradas de tipo 4 es de: $" + (cantPorTicket[4] * PreciosTipo[4]));
        Lista.Add("La recaudación total es de: $" + total);

        return  Lista;
    }


     private static void acumularAbono(Cliente UnCliente, int[] cantPorEntrada, int t1, int t2, int t3, int t4, int total)
    { 
        if (UnCliente.tipoEntrada == 1)
        {
            total += t1 * UnCliente.cantidad;
            cantPorEntrada[1] ++;
        }
        else if (UnCliente.tipoEntrada == 2)
        {
            total += t2 * UnCliente.cantidad;
            cantPorEntrada[2] ++;
        }
        else if (UnCliente.tipoEntrada == 3)
        {
            total += t3 * UnCliente.cantidad;
            cantPorEntrada[3] ++;
        }
        
        else if (UnCliente.tipoEntrada == 4)
        {
            total += t4 * UnCliente.cantidad;
            cantPorEntrada[4] ++;
        }
    }

}