using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public CollisionPlayer notificador;
    public GameObject shield;
     void Start()
    {
        notificador.EventoMovimiento += ActivarMovimiento;
    }

    // Update is called once per frame
    void ActivarMovimiento()
    {
        transform.LookAt(shield.transform.position);
    }
}
