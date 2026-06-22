using UnityEngine;
using UnityEngine.InputSystem;

public class Input_Simple : MonoBehaviour
{
    public float velocidad = 5f;
    protected Rigidbody2D rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Mover();
    }

    protected virtual void Mover()
    {
        Vector2 inputMovimiento = InputManager.MoveAxis();
        Vector3 direccion = new Vector3(inputMovimiento.x, inputMovimiento.y, 0f);
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma") && rb != null)
        {
            Vector2 normalDeSuperficie = collision.contacts[0].normal;
            Vector2 velocidadReflejada = Vector2.Reflect(rb.linearVelocity, normalDeSuperficie);
            rb.linearVelocity = velocidadReflejada * 0.8f;
        }
    }
}