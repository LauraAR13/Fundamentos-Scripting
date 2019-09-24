using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caida : MonoBehaviour
{
    Rigidbody rb;
    Renderer rnd;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rnd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(1f, 0, 0);
        Debug.Log(rb.velocity.y);
        if (rb.velocity.y < -3f)
        {
            rnd.material.color = c;
        }
    }
}
