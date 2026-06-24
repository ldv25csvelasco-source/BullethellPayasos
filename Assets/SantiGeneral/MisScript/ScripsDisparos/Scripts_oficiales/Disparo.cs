using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject _prefabBalas;
    public Transform puntoDisparo;

    void Update()
    {
        if (InputManager.DisparoButton())
        {
            Disparar();
        }
    }

    protected void Disparar()
    {
        if (_prefabBalas == null || puntoDisparo == null)
            return;

        GameObject bala = Instantiate(
            _prefabBalas,
            puntoDisparo.position,
            Quaternion.identity
        );

        Vector2 direccion = transform.right;

        Bala scriptBala = bala.GetComponent<Bala>();

        if (scriptBala != null)
        {
            scriptBala.Inicializar(direccion);
        }
    }
}