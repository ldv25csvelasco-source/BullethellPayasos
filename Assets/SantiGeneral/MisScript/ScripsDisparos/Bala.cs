using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;
    public int daño = 1;
    private Vector2 direccion;

    public void Inicializar(Vector2 dir)
    {
        direccion = dir.normalized;
        Debug.Log("Bala inicializada con dirección: " + direccion);

        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth vida = collision.GetComponent<PlayerHealth>();

            if (vida != null)
            {
                vida.TakeDamage(daño);
            }

            Destroy(gameObject);
        }
    }
}