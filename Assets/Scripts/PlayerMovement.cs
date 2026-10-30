using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 movementInput;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void Update()
    {
        float moveInputX = movementInput.x;
        float moveInputY = movementInput.y;

        Vector3 sidewaysMovement = Vector3.left * moveInputX;
        Vector3 forwardMovement = Vector3.back * moveInputY;

        if (moveInputY != 0)
        {
            RaycastHit[] hits = rb.SweepTestAll(forwardMovement.normalized, 0.1f);

            foreach (RaycastHit hit in hits)
            {
                if (!hit.collider.CompareTag("Ground"))
                {
                    moveInputY = 0;
                    break;
                }
            }
        }

        if (moveInputX != 0)
        {
            RaycastHit[] hits = rb.SweepTestAll(sidewaysMovement.normalized, 0.1f);

            foreach (RaycastHit hit in hits)
            {
                if (!hit.collider.CompareTag("Ground"))
                {
                    moveInputX = 0;
                    break;
                }
            }
        }

        Vector3 movement = Vector3.left * moveInputX + Vector3.back * moveInputY;

        rb.linearVelocity = new Vector3(
            movement.x * moveSpeed,
            rb.linearVelocity.y,
            movement.z * moveSpeed
        );
    }
}