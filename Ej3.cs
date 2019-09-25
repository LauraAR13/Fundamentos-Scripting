using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{
    // Start is called before the first frame update

    Light luz; 
    void Start()
    {
       luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Color b = new Color(0, 0, 1f);
        Color r = new Color(1f, 0, 0);
        Color w = new Color(1f, 1f, 1f);
        if (luz.intensity <= 0.25 && luz.intensity <=0.5 )
        {
            luz.color = b;
        }
        else if (luz.intensity > 0.5 && luz.intensity <= 0.75)
        {
            luz.color = r; 
        }
        else if (luz.intensity > 0.75)
        {
            luz.color = w;
        }
    }
}
