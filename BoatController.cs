using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BoatController : MonoBehaviour
{
    public float moveForce = 500f;
    public float turnTorque = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(0, -1f, 0); 
    }

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        
        Vector3 force = transform.forward * moveInput * moveForce;
        rb.AddForce(force);

        
        rb.AddTorque(Vector3.up * turnInput * turnTorque);
    }
}