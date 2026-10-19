using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public delegate void mensaje();
    public event mensaje EventoMovimiento;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (EventoMovimiento != null)
            {
                EventoMovimiento();
            }
        }
    }
}
