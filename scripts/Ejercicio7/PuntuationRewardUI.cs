using UnityEngine;
using TMPro;

public class PuntuationRewardUI : MonoBehaviour
{
    private int score = 0;
    private int rewardThreshold = 100;
    public TMP_Text textoPuntuacion;
    public TMP_Text textoRecompensa;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tipo 1"))
        {
            score += 25;
            textoPuntuacion.text = "Puntuación: " + score;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("tipo 2"))
        {
            score += 50;
            textoPuntuacion.text = "Puntuación: " + score;
            Destroy(other.gameObject);
        }
        if (score >= rewardThreshold)
        {
            textoRecompensa.text = "¡Has alcanzado " + score + " puntos! ¡Recompensa desbloqueada!";
            rewardThreshold += 100;
        }
        else
        {
            textoRecompensa.text = "";
        }
    }
}
