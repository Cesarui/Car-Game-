using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CarMovement : MonoBehaviour
{
    [SerializeField] InputAction left;
    [SerializeField] InputAction right;

    [SerializeField] float speed = 20f;
    [SerializeField] float turningSpeed = 10f;

    private void OnEnable()
    {
        // Using this to disable it in the future if the player crashes.
        left.Enable();
        right.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    private void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (left.IsPressed())
        {
            transform.Rotate(Vector3.down * turningSpeed * Time.deltaTime);
        }
        if (right.IsPressed())
        {
            transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime);
        }
    }
}
