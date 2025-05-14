namespace TP04_Ahorcado;

static public class Partida
{
static public string palabra{get; private set;}
 static public int intentos{get; private set;}
static public List <char> letrasU {get; private set;}

public static void inicializarPartida()
{
  palabra = "Murcielago";
  letrasU = new List<char>();
  intentos = 0;
}

}