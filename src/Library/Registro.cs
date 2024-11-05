namespace ClassLibrary;

public class Registro: IRegistroPokemon
{
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public int Health {get; private set;}
    public int Defense { get; private set; }
     public  ITipoPokemon TipoPokemon { get; private set; }
    // dic<ataques> moveset { get; set; }

    public Registro(string name, int damage, int health, int defense)
    {
        Name = name;
        Defense = defense;
        Damage = damage;
        Health = health;
        
       // TipoPokemon = tipoPokemon; No esta creado tipo todavia
    }

    public IPokemon CrearPokemon()
    {
        return new Pokemon(this.Name, this.Damage, this.Health, this.Defense);
    }
    // public DevolverMoves();
    // Si true crea pokemon, sino consigue los nombres del registro.
    public string AcceptObtenerNombre(IVisitor visitor)
    {
        return visitor.VisitObtenerNombre(this);
    }

    // Método Accept para crear un Pokémon
    public IPokemon AcceptCrearPokemon(IVisitor visitor)
    {
        return visitor.VisitCrearPoke(this);
    }
}
