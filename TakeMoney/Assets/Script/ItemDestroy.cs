﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    float time = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }
}
