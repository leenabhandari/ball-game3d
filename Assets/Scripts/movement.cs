using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    public Rigidbody ri;
    public float speed,jump;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            ri.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            ri.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ri.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ri.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ri.AddForce(Vector3.up * speed,ForceMode.Impulse);
        }


    }

   
}
