using UnityEngine;

public class MovimientoPlayerTipo2ShieldCollision : MonoBehaviour
{
    public float speed = 5f;
    public CollisionPlayersShieldCollision notificador;
    private Vector3 movementDirection; 
    private bool isMoving = false;
    public GameObject shield;
    void Start()
    {
        notificador.EventoMovimientoTipo2 += ActivarMovimiento;
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            movementDirection = (shield.transform.position - transform.position).normalized;
            GetComponent<Rigidbody>().MovePosition(transform.position + movementDirection * speed * Time.deltaTime);
        }
    }

    void ActivarMovimiento()
    {
        isMoving = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("shield"))
        {
            isMoving = false;
            other.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
