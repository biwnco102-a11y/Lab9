using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float rotateSpeed;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(rotateSpeed, 0, 0));
        }
    }
}
