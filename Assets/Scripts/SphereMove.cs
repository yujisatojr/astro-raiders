using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 1f;
    }
 
    void Update()
    {
       rb.velocity = transform.forward * speed;
    }
}
