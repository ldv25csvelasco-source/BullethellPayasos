using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public int vidas = 3;

    public void RecibirDanio()
    {
        vidas--;

        Debug.Log("Vidas restantes: " + vidas);

        if (vidas <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("Fin del Juego");

        // Activar Scoreboard
        // Mostrar pantalla de Game Over

        gameObject.SetActive(false);
    }
}