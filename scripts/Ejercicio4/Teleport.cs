using UnityEngine;

public class Teleport : MonoBehaviour
{
    public CollisionPlayer notificador;
    public GameObject shield;
     void Start()
    {
        notificador.EventoMovimiento += ActivarMovimiento;
    }

    // Update is called once per frame
    void ActivarMovimiento()
    {
        transform.position = shield.transform.position - new Vector3(0, 0.4f, 0);
        transform.rotation = shield.transform.rotation;
    }
}
