using UnityEngine;
using TMPro;

public class GamePlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int power = 0;
    private int enemyPower = 190;
    public TMP_Text textoPuntuacion;
    public TMP_Text textoPuntuacionEnemigo;
    public TMP_Text textoFinal;
    public delegate void mensaje();
    public event mensaje EventoEnemigo;
    private bool gameStarted = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("tipo 1") && gameStarted)
        {
            power += 25;
            textoPuntuacion.text = "Power: " + power;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("tipo 2") && gameStarted)
        {
            power += 50;
            textoPuntuacion.text = "Power: " + power;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("startingCylinder"))
        {
            gameStarted = true;
            EventoEnemigo();
            textoPuntuacion.text = "Power: " + power;
            textoPuntuacionEnemigo.text = "Enemy Power: " + enemyPower;
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy") && gameStarted)
        {
            if (power >= enemyPower)
            {
                textoFinal.text = "¡Has ganado!";
            }
            else
            {
                textoFinal.text = "¡Has perdido!";
            }
        }
    }
}
