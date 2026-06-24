using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;
    private Vector2 direccion;

    public void Inicializar(Vector2 dir)
    {
        direccion = dir.normalized;

        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Jugador"))
        {
            Player_Health vida = collision.GetComponent<Player_Health>();

            if (vida != null)
            {
                vida.RecibirDanio();
            }

            Destroy(gameObject);
        }
    }
}