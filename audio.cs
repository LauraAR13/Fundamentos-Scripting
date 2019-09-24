using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    AudioSource audioGato;
    float t = 0f;

    // Start is called before the first frame update
    void Start()
    {
        audioGato = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 5)
        {
            audioGato.volume = 0f;
        }
    }
}
