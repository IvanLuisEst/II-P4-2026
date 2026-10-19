using UnityEngine;
using TMPro;

public class PuntuationShieldUI : MonoBehaviour
{
    private int score = 0;
    public TMP_Text textoPuntuacion;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tipo 1"))
        {
            score += 5;
            textoPuntuacion.text = "Puntuación: " + score;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("tipo 2"))
        {
            score += 10;
            textoPuntuacion.text = "Puntuación: " + score;
            Destroy(other.gameObject);
        }
    }
}
