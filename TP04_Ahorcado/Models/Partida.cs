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

  List <char> listaLetras = new List<char>();
  foreach(char letra in palabra)
  {
    listaLetras.Add('_');
  }
}

public static void verificarIngreso(char letra)
{
  if(letrasU.Contains(letra))
  {
    Console.WriteLine("La letra ya fue ingresada");
    intentos++;
  }

  if(palabra.Contains(letra))
  {
    intentos++;
    //aca cambiar de _ a la letra
  }
  else
  {
    intentos++;
    letrasU.Add(letra);
  }

}

public static bool arriesgarPalabra(string palabraArriesgada)
{
  bool adivinaste = false;
  if(palabraArriesgada == palabra)
  {
    adivinaste = true;
  }
  return adivinaste;
}
}