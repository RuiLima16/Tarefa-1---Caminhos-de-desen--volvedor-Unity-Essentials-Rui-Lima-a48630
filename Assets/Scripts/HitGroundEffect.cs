using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGroundEffect : MonoBehaviour
{
    public AudioClip collisionSound;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "plane")
        {
            audioSource.PlayOneShot(collisionSound);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
