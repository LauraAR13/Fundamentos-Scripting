using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej4 : MonoBehaviour
{
    Light luz;
    Transform sptransform;
    
    // Start is called before the first frame update

    void Start()
    {
        luz = GetComponent<Light>();
        sptransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        luz.intensity = sptransform.localScale.magnitude * 0.5f;
    }
}
