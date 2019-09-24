using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frecuencia : MonoBehaviour
{
    AudioSource audioGato;
    Light luz;
    // Start is called before the first frame update
    void Start()
    {
        audioGato = GetComponent<AudioSource>();
        luz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (luz.intensity< 0.5)
        {
            audioGato.pitch = 0.5f;
        }
    }
}
