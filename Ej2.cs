using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    
    Renderer sphRenderer;
   float   t =0f;
    // Start is called before the first frame update
    void Start()
    {
      
        sphRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        Color r = new Color(1f, 0, 0);
        Color b = new Color(0, 0, 1f);
        Color p = new Color(0.87f, 0.35f, 1f);
        if (t <= 3)
        {
            sphRenderer.material.color = r;
        }
        else if (t >= 3 && t < 6)
        {
            sphRenderer.material.color = b;
        }
        else if (t >= 6)
        {
            sphRenderer.material.color = p;
        }

    }
}
