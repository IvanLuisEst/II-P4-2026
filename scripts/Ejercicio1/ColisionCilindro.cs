using UnityEngine;

public class ColisionCilindro : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje EventoMovimiento;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cube"))
        {
            if (EventoMovimiento != null)
            {
                Debug.Log("Colision con el cilindro");
                EventoMovimiento();
            }
        }
    }
}
