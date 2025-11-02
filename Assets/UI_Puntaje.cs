using UnityEngine;
using UnityEngine.UI;

public class UI_Puntaje : MonoBehaviour
{
    public Text textoPuntaje;
    public bool esPantallaFinal;

    void Update()
    {
        if (esPantallaFinal)
            textoPuntaje.text = "Puntaje final: " + ScoreManager.puntajeActual.ToString();
        else
            textoPuntaje.text = "Puntos: " + ScoreManager.puntajeActual.ToString();
    }
}
