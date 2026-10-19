using UnityEngine;

public class MovimientoPlayerTipo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public CollisionPlayer notificador;
    private Vector3 movementDirection; 
    private bool isMoving = false;
    public GameObject player;
    void Start()
    {
        notificador.EventoMovimiento += ActivarMovimiento;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            movementDirection = (player.transform.position - transform.position).normalized;
            transform.position += movementDirection * speed * Time.deltaTime;
        }
    }

    void ActivarMovimiento()
    {
        isMoving = true;
    }
}
