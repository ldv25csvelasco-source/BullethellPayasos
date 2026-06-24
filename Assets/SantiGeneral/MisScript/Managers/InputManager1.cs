using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    public static InputManager Instance = null;

    private Player_Control _controles;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        _controles = new Player_Control();
    }

    private void OnEnable()
    {
        _controles.Enable();
    }

    private void OnDisable()
    {
        _controles.Disable();
    }

    public static Vector2 MoveAxis()
    {
        return Instance._controles.Char_Gameplay.Movimiento.ReadValue<Vector2>();
    }

    public static bool PausaButton()
    {
        return Instance._controles.Char_Gameplay.Pausa.WasPressedThisFrame();
    }

    public static bool DisparoButton()
    {
        return Instance._controles.Char_Gameplay.Disparo.WasPressedThisFrame();
    }
    public static bool ApuntadoButton()
    {
        return Instance._controles.Char_Gameplay.Apuntado.WasPressedThisFrame();
    }
    public static bool AceleronButton()
{
    return Instance._controles.Char_Gameplay.Aceleron.WasPressedThisFrame();
}


}
