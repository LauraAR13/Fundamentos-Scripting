using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] float mag = 8;
    [SerializeField] float magAng = 90;
    [SerializeField] AudioClip idle;
    [SerializeField] AudioClip movement;
    AudioSource audioT;
    Rigidbody rb;
    void Start()
    {
        audioT = GetComponent<AudioSource>();
        rb = GetComponent <Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        audioT.mute = true;
        Vector3 dir = transform.forward * Input.GetAxis("Vertical");
        Vector3 vel = mag * dir;
        Vector3 dist = vel * Time.deltaTime;
        transform.position += dist;

        Vector3 dirAng = new Vector3(0, 1, 0) * Input.GetAxis("Horizontal");

        Vector3 velAng = magAng * dirAng;
        Vector3 distAng = velAng * Time.deltaTime;
        transform.eulerAngles += distAng;

        if ((dir.z> 0 || dirAng.y > 0)||(dir.z <0 || dirAng.y <0))
        {
            audioT.mute = false;
        }

        float magnitudFuerza = 300;
        float sentido = 1;
        Vector3 dir2 = transform.forward;
        Vector3 fuerza = magnitudFuerza * dir2 * sentido;


        float magnitudFuerza2 = 300;
        float sentido2 = 1;
        Vector3 dir3 = transform.forward;
        Vector3 fuerza2 = magnitudFuerza2 * dir2 * sentido2;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(fuerza);
        }


        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(fuerza2);
        }


    }
}
