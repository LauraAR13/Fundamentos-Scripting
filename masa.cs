using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masa : MonoBehaviour
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

        if (rb.mass > 5.0)
        {

            rnd.material.color = c;

        }
    }
}
