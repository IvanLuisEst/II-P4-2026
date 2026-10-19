using UnityEngine;

public class PuntuationShieldSimple : MonoBehaviour
{
    private int score = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tipo 1"))
        {
            score += 25;
            Debug.Log("Puntuación: " + score);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("tipo 2"))
        {
            score += 50;
            Debug.Log("Puntuación: " + score);
            Destroy(other.gameObject);
        }
    }
}
