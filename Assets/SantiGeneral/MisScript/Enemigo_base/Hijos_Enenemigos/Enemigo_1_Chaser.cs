using UnityEngine;


public class Enemigo_1 : Enemy_Stats
{
    private Transform player;

    void Start()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Jugador");

        if (obj != null)
        {
            player = obj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position,
            Velocidad * Time.deltaTime
        );
    }
}