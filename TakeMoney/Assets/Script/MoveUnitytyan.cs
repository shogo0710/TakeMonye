using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnitytyan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(7.66f * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -2.99f, 0.0f);
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, 2.99f, 0.0f);
        }
    }
}
