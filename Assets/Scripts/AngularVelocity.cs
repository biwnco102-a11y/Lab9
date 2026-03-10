using UnityEngine;
using UnityEngine.InputSystem;

public class AngularVelocity : MonoBehaviour
{
    public float angularSpeed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.isPressed) // aKey = "a" Key
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
