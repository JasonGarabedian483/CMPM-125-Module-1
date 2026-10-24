using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;
    private Vector2 movementInput;

    // Update is called once per frame

    private void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
        Debug.Log("Input: " + movementInput);
    }

    void Update()
    {
        float moveInputX = movementInput.x;
        float moveInputY = movementInput.y;

        transform.Translate(Vector3.left * moveInputX * moveSpeed * Time.deltaTime, Space.Self);
        transform.Translate(Vector3.back * moveInputY * moveSpeed * Time.deltaTime, Space.Self);
    }
}
