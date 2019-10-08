﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectorController : MonoBehaviour
{
    GameObject moneycount;
    int premoney = 0;
    int summoney = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.moneycount = GameObject.Find("MoneyCount");
    }

    // Update is called once per frame
    void Update()
    {
        moneycount.GetComponent<Text>().text =
            this.premoney.ToString() + "円\n" + this.summoney.ToString();
    }

    public void Countemyurator(int a)
    {
        switch (a)
        {
            case 0: premoney += 1; break;
            case 1: premoney += 5; break;
            case 2: premoney += 10; break;
            case 3: premoney += 50; break;
            case 4: premoney += 100; break;
            case 5: premoney += 500; break;
            case 6: premoney -= 100; break;
            case 7: premoney -= 300; break;
            case 8: premoney += 500; break;
            case 9: premoney /= 2; break;
        }                        
    }
}