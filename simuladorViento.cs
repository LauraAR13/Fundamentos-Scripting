using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simuladorViento : MonoBehaviour
{
    Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Pluma")
        {
            rb.drag = 10;
        }
        else if (tag == "Ladrillo")
        {
            rb.drag = 0;
        }
        else if (tag == "Papel")
        {
            rb.drag = 5; 
        }
    }
}
