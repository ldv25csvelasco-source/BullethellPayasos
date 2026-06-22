using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject _prefabBalas;
    public Transform puntoDisparo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Se presionó la tecla Q");
            Disparar();
        }
    }

    protected void Disparar()
    {
        if (_prefabBalas == null)
        {
            return;
        }

        GameObject bala = Instantiate(_prefabBalas, puntoDisparo.position, Quaternion.identity);
        Debug.Log("Bala instanciada");

      
        Vector2 direccion = transform.localScale.x > 0 ? Vector2.right : Vector2.left;

        Debug.Log("Dirección: " + direccion);

        Bala scriptBala = bala.GetComponent<Bala>();

        if (scriptBala != null)
        {
            scriptBala.Inicializar(direccion);
        }
        else
        {
         
        }
    }
}