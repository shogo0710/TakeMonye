using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float rialspeed = 0;
    float prespeed = 7.66f;
    GameObject dire;
    // Start is called before the first frame update
    void Start()
    {
        this.dire = GameObject.Find("Director");
    }

    // Update is called once per frame
    void Update()
    {
        
        rialspeed += prespeed * Time.deltaTime;
        transform.position = new Vector3(rialspeed, 0, -10);       
    }

    public void UpPrespeed()
    {
        prespeed += 1.0f;
    }
}
