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
        Debug.Log("Input: " + movementInput);
    }

 void Update()
    {
        float moveInputX = movementInput.x;
        float moveInputY = movementInput.y;

        Vector3 sidewaysMovement = Vector3.left * moveInputX;
        Vector3 forwardMovement = Vector3.back * moveInputY;

        if (moveInputY != 0)
        {
            if (rb.SweepTest(forwardMovement.normalized, out RaycastHit sideHit, 0.1f))
            {
                //if (sideHit.collider.CompareTag("Wall"))
                //{
                    moveInputY = 0;
                //}
            }
        }

        if (moveInputX != 0)
        {
         if (rb.SweepTest(sidewaysMovement.normalized, out RaycastHit forwardHit, 0.1f))
            {
                //if (forwardHit.collider.CompareTag("Wall"))
                //{
                    moveInputX = 0;
                //}
            }   
        }
        Vector3 movement = Vector3.left * moveInputX + Vector3.back * moveInputY;
        rb.linearVelocity = new Vector3(movement.x * moveSpeed, rb.linearVelocity.y, movement.z * moveSpeed);
    }
}
