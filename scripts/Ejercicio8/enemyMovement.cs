using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private float speed = 4f;
    private bool isMoving = false;
    public GameObject player;
    public GameObject sphere;
    public GamePlayer notificador;
    void Start()
    {
        notificador.EventoEnemigo += ActivarMovimiento;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        {
            transform.LookAt(player.transform);
            GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        }
    }

    void ActivarMovimiento()
    {
        isMoving = true;
        transform.position = sphere.transform.position + new Vector3(0, 0.5f, 0);
        gameObject.AddComponent<Rigidbody>();
        Destroy(sphere);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isMoving = false;
        }
    }
}
