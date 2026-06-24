using UnityEngine;

public class EnemyDisparo : Disparo
{
    public float rangoDeteccion = 5f;
    public float tiempoEntreDisparos = 1.5f;

    private Transform jugador;
    private float contadorTiempo;

    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Player");
        if (obj != null)
        {
            jugador = obj.transform;
        }
    }

    void Update()
    {
        if (jugador == null) return;

        float distancia = Vector2.Distance(transform.position, jugador.position);

        if (distancia <= rangoDeteccion)
        {
            contadorTiempo += Time.deltaTime;

            if (contadorTiempo >= tiempoEntreDisparos)
            {
                Disparar(); 
                contadorTiempo = 0f;
            }
        }
    }
}