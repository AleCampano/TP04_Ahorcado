namespace TP04_Ahorcado;

static public class Partida
{
static public string palabra{get; private set;}
 static public int intentos{get; private set;}
static public List <char> letrasIngresadas {get; private set;}
static public bool juegoFinalizado {get; private set;}
static public bool gano {get; private set;}

public static void inicializarPartida()
{
  palabra = "murcielago";
  letrasIngresadas = new List<char>();
  intentos = 0;
  juegoFinalizado = false;
  gano = false;
}

public static string ObtenerPalabra()
{
  string resultado = "";

  for (int i = 0; i < palabra.Length; i++)
  {
    char letra = palabra[i];
    bool letraEncontrada = false;

    for (int j = 0; j < letrasIngresadas.Count; j++)
    {
      if (letrasIngresadas[j] == letra)
      {
        letraEncontrada = true;
      }
    }

    if (letraEncontrada == true)
    {
      resultado += letra;
    }
    else if(letraEncontrada == false)
    {
      resultado += "_ ";
    }
  }
  return resultado;
}
public static void IngresarLetra(char letra)
{
  bool ingreso = false;

  for (int i = 0; i < letrasIngresadas.Count; i++)
  {
    if (letrasIngresadas[i] == letra)
    {
      ingreso = true;
      intentos++;
    }
  }

  if (!ingreso && !juegoFinalizado)
  {
    letrasIngresadas.Add(letra);
    intentos++;

    bool completa = true;
    for (int i = 0; i < palabra.Length; i++)
    {
      bool encontrada = false;
      for (int j = 0; j < letrasIngresadas.Count; j++)
      {
        if (palabra[i] == letrasIngresadas[j])
        {
          encontrada = true;
        }
      }

        if (encontrada == false)
      {
        completa = false;
      }
    }

    if (completa == true)
    {
    juegoFinalizado = true;
    }
  }
}

public static void arriesgarPalabra(string palabraArriesgada)
{
  intentos++;

  if (EsIgualPalabra(palabraArriesgada, palabra))
  {
    juegoFinalizado = true;
    gano = true;
  }
  else
  {
    juegoFinalizado = false;
    gano = false;
  }
}

public static bool EsIgualPalabra(string arriesgo, string secreta)
{
  bool verificar = true;
  if (arriesgo.Length != secreta.Length)
  {
    verificar = false;
  }

  for (int i = 0; i < arriesgo.Length; i++)
  {
    char letra = arriesgo[i];
    if (letra >= 'a' && letra <= 'z' && letra != secreta[i])
    {
      verificar = false;
    }
  }
  return verificar;
}

}