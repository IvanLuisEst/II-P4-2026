using UnityEngine;

public class MovimientoPlayerTipo1ShieldCollision : MonoBehaviour
{
    public float speed = 5f;
    public CollisionPlayersShieldCollision notificador;
    private Vector3 movementDirection; 
    private bool isMoving = false;
    public GameObject shield;
    void Start()
    {
        notificador.EventoMovimientoTipo1 += ActivarMovimiento;
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

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("shield"))
        {
            isMoving = false;
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
