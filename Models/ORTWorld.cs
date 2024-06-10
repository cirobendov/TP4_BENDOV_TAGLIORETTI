static class ORTWorld
{
    public static List < string > ListaDestinos {get; private set;} = new List<string> {"París", "Frankfurt", "Milan", "Bali", "NYC", "Cancún", "Barcelona", "Seul", "Toronto", "Amsterdam"};
    public static List < string > ListaHoteles {get; private set;} = new List<string> {"hotel París", "hotel Frankfurt", "hotel Milan", "hotel Bali", "hotel NYC", "hotel Cancún", "hotel Barcelona", "hotel Seul", "hotel Toronto", "hotel Amsterdam"};
    public static List< string > ListaAereos {get; private set;} = new List<string> {"luft", "iberia", "qatar", "delta", "american", "ana", "china", "emirates", "turkish", "united"};
    public static List< string > ListaExcursiones {get; private set;}= new List<string> {"acuario", "camp nou", "lago", "tulipanes", "rock", "sightseen", "ski", "city tour", "sagrada familia", "subir torre"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if(Paquetes.ContainsKey(destinoSeleccionado))
        return false;
        else
        {
            Paquetes.Add(destinoSeleccionado, paquete);
            return true;
        }
    }
 
}