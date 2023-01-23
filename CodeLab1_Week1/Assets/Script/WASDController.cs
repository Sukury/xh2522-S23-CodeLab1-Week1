using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float forceAmount = 0;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(message: "W Pressed");
            rb.AddForce(x:0,y:0,forceAmount);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(x:0,y:0,-forceAmount);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(x:-forceAmount,y:0,0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(x:forceAmount,y:0,0);
        }
    }
}
