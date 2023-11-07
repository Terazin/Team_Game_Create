using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_SE_Manager : MonoBehaviour
{
    public AudioClip SE1;
    public AudioClip SE2;
    public AudioClip SE3;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
