using ClassLibrary;

namespace Library;

public  static class Combate
{
    static IVisitor InfoVisitor = new InfoVisitor();
    //public void Combatir(Player juagor1, Player, jugador2)
   // {}

   public static void EfectuarEfecto(IPokemon pokemon)
   {
       int estadoPokemon = pokemon.Estado;
       int calculoDaño = 0;
       switch (estadoPokemon)
       {
               
              
           case 0:
               break;
           case 1: // Quemado
                 calculoDaño = (int)Math.Round(0.15 * pokemon.Health);
               
               break;

           case 2: // Envenenado
                 calculoDaño = (int)Math.Round(0.10 * pokemon.Health);
               break;

           case 3: // Parálisis (Ejemplo, puedes definir lo que debe hacer en este caso)
               
               break;

           // Agregar otros estados de Pokémon según sea necesario
           default:
               // Si no se corresponde con ningún estado, no hace nada
               break;
       }
       pokemon.DecreaseHealth(calculoDaño);
       
   }

   public static void Recibir(IPokemon pokemon, int damage)
   {
       pokemon.DecreaseHealth(damage);
   }

   public static void Combatir(IPlayer Jugador1, IPlayer Jugador2)
   {
       int turno = 0;
       IPlayer JugadorActual;
       IPlayer JugadorRival;
       
       while (Calculator.CombatValidation(Jugador1, Jugador2)){
           if (turno % 2 == 0) // Sistema sencillo que permite detectar cuando es el turno de cada jugador.
           {
                JugadorActual = Jugador1;
                JugadorRival = Jugador2;
           }
           else
           {
                JugadorActual = Jugador2;
                JugadorRival = Jugador1;
           }

           if (turno < 2)
           {
               ImpresoraDeTexto.MostrarPokemons(JugadorActual);
           }

           turno++; }
       
   }
}
