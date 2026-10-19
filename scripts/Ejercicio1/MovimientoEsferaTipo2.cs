using UnityEngine;

public class MovimientoEsferaTipo2 : MonoBehaviour
{
    public float speed = 5f;
    public ColisionCilindro notificador;
    private Vector3 movementDirection; 
    private bool isMoving = false;
    private GameObject cilindro;
    void Start()
    {
        cilindro = GameObject.FindWithTag("cylinder");
        notificador.EventoMovimiento += ActivarMovimiento;
    }

    // Update is called once per frame
    void Update()
    {
        cilindro = GameObject.FindWithTag("cylinder");
        if (isMoving)
        {
            movementDirection = (cilindro.transform.position - transform.position).normalized;
            transform.position += movementDirection * speed * Time.deltaTime;
        }
    }

    void ActivarMovimiento()
    {
        isMoving = true;
    }
}
