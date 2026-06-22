using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    private bool juegoPausado = false;

    void Update()
    {
        if (InputManager.PausaButton())
        {
            AlternarPausa();
        }
    }

    void AlternarPausa()
    {
        juegoPausado = !juegoPausado;

        if (juegoPausado)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}