using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

// Monday - KEEP GOINGGGGGGGG
public class CarMovement : MonoBehaviour
{
    [SerializeField] InputAction gas;
    [SerializeField] InputAction left;
    [SerializeField] InputAction right;

    [SerializeField] float speed = 20f;
    [SerializeField] float turningSpeed = 5f;
    [SerializeField] float relativeForceTurn = 10f;

    Rigidbody rb;

    private void OnEnable()
    {
        // Using this to disable it in the future if the player crashes.
        left.Enable();
        right.Enable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (left.IsPressed())
        {
           rb.AddRelativeForce(Vector3.left * relativeForceTurn * Time.deltaTime);
           transform.Rotate(Vector3.down * turningSpeed * Time.deltaTime);
        }
        if (right.IsPressed())
        {
            rb.AddRelativeForce(Vector3.right * relativeForceTurn * Time.deltaTime);
            transform.Rotate(Vector3.up * turningSpeed * Time.deltaTime);
        }
    }
}
