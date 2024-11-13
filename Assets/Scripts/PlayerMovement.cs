using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 2000f;
    public float sideways = 500f;
   
    void Update()
    {
        
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forward * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0);
        }
    }
}
