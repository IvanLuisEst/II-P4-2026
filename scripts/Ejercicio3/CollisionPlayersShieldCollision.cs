using UnityEngine;

public class CollisionPlayersShieldCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public delegate void mensaje();
    public event mensaje EventoMovimientoTipo2;
    public event mensaje EventoMovimientoTipo1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tipo 2"))
        {
            if (EventoMovimientoTipo2 != null)
            {
                EventoMovimientoTipo2();
            }
        }
        if (collision.gameObject.CompareTag("tipo 1"))
        {
            if (EventoMovimientoTipo1 != null)
            {
                EventoMovimientoTipo1();
            }
        }
    }
}
