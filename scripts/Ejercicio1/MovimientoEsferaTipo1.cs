using UnityEngine;

public class MovimientoEsferaTipo1 : MonoBehaviour
{
    public float speed = 5f;
    public ColisionCilindro notificador;
    private Vector3 movementDirection; 
    private bool isMoving = false;
    public GameObject sphere;
    void Start()
    {
        notificador.EventoMovimiento += ActivarMovimiento;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            movementDirection = (sphere.transform.position - transform.position).normalized;
            transform.position += movementDirection * speed * Time.deltaTime;
        }
    }

    void ActivarMovimiento()
    {
        isMoving = true;
    }
}
