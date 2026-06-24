using UnityEngine;
using UnityEngine.InputSystem;
public class Aceleron_input : MonoBehaviour
{
    public float speed = 15f;
    public float time = 0.2f;
    public float cooldown = 1f;
    public Collider2D hitbox;

    private Rigidbody2D rb;
    private bool puedeDash = true;
    private bool estaDashing = false;
    private Vector2 dir = Vector2.right;

    private float dashTimer = 0f;
    private float cooldownTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (InputManager.Instance == null) return;

        Vector2 input = InputManager.MoveAxis();

        if (input != Vector2.zero)
        {
            dir = input.normalized;
        }

        if (!puedeDash && !estaDashing)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0f)
            {
                puedeDash = true;
            }
        }

        if (estaDashing)
        {
            dashTimer -= Time.deltaTime;
            rb.linearVelocity = dir * speed;

            if (dashTimer <= 0f)
            {
                estaDashing = false;

                if (hitbox != null) hitbox.enabled = (true);
                rb.linearVelocity = Vector2.zero;
                cooldownTimer = cooldown;
            }
            return;
        }

        if (InputManager.AceleronButton() && puedeDash && !estaDashing)
        {
            if (hitbox != null) hitbox.enabled = (false);

            estaDashing = true;
            puedeDash = false;
            dashTimer = time;
        }
    }
}