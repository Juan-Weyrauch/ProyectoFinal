namespace ClassLibrary;

public class Player : IPlayer
{
    public string Name { get; }
    // inventario quizas? Aca? 
    public List <IPokemon> Equipo { get;  set; }
    public List<int> EleccionPokemon { get; set; }
   
    public void EstablecerEquipo(List<IPokemon> EquipoNuevo) // creo que esto deberia ser de la fabrica
    {
        Equipo = EquipoNuevo;
    }
}