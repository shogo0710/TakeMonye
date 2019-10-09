using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmController : MonoBehaviour
{
    AudioSource audioSource1;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource1 = GetComponent<AudioSource>();
        audioSource1.pitch = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PitchChange(int a)
    {
        if (a == 1)
        {
            audioSource1.pitch += 0.05f;
        }else if (a == 2)
        {
            audioSource1.pitch -= 0.05f;
        }
    }
}
