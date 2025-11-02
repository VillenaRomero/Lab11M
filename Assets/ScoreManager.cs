using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int puntajeActual = 0;

    public static void SumarPunto()
    {
        puntajeActual++;
    }

    public static void ReiniciarPuntaje()
    {
        puntajeActual = 0;
    }
}
