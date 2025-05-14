namespace TP04_Ahorcado;

public class Partida
{
public string palabra{get; private set;}
public int intentos{get; private set;}
public List <char> letrasU{get; private set;}

public Partida(string palabra, int intentos, List <char> letrasU)
{
this.palabra = palabra;
this.intentos = 0;
this.letrasU = letrasU;


}
}