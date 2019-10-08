using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject onePre;
    public GameObject fivePre;
    public GameObject tenPre;
    public GameObject fivetenPre;
    public GameObject hyakuPre;
    public GameObject fivehyakuPre;
    public GameObject redPre;
    public GameObject bluePre;
    public GameObject purplePre;
    public GameObject greenPre;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Unitytyan");
        StartCoroutine(TopGene());
        StartCoroutine(MiddleGene());
        StartCoroutine(UnderGene());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator TopGene()
    {
        while (true)
        {
            TopGenerator();
            yield return new WaitForSeconds(0.8f);
            TopGenerator();
            yield return new WaitForSeconds(1.0f);
            TopGenerator();
            yield return new WaitForSeconds(0.7f);            
        }
    }

    IEnumerator MiddleGene()
    {
        while (true)
        {
            MiddleGenerator();
            yield return new WaitForSeconds(0.9f);
            MiddleGenerator();
            yield return new WaitForSeconds(1.2f);
            MiddleGenerator();
            yield return new WaitForSeconds(0.6f);
            MiddleGenerator();
            yield return new WaitForSeconds(1.0f);
            
        }
    }

    IEnumerator UnderGene()
    {
        while (true)
        {
            UnderGenerator();
            yield return new WaitForSeconds(0.7f);
            UnderGenerator();
            yield return new WaitForSeconds(0.7f);
            UnderGenerator();
            yield return new WaitForSeconds(1.2f);
            UnderGenerator();
            yield return new WaitForSeconds(1.0f);
            UnderGenerator();
            yield return new WaitForSeconds(0.9f);
        }
    }

    void TopGenerator()
    {
        Vector3 topPos = player.transform.position;
        topPos.x += 15.0f;
        topPos.y = -2.3f;
        int dice = Random.Range(1, 19);
        if (dice == 1)
        {
            GameObject a = Instantiate(onePre, topPos, transform.rotation) as GameObject;
        }
        else if (dice == 2)
        {
            GameObject ab = Instantiate(fivePre, topPos, transform.rotation) as GameObject;
        }
        else if (dice == 3)
        {
            GameObject ac = Instantiate(tenPre, topPos, transform.rotation) as GameObject;
        }
        else if (4 <= dice && dice < 6)
        {
            GameObject ad = Instantiate(fivetenPre, topPos, transform.rotation) as GameObject;
        }
        else if (6 <= dice && dice < 8)
        {
            GameObject ae = Instantiate(hyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (8 <= dice && dice < 11)
        {
            GameObject af = Instantiate(fivehyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (11 <= dice && dice < 12)
        {
            GameObject ag = Instantiate(redPre, topPos, transform.rotation) as GameObject;
        }
        else if (12 <= dice && dice < 13)
        {
            GameObject ah = Instantiate(bluePre, topPos, transform.rotation) as GameObject;
        }
        else if (13 <= dice && dice < 14)
        {
            GameObject a = Instantiate(purplePre, topPos, transform.rotation) as GameObject;
        }
        else if (14 <= dice && dice < 16)
        {
            GameObject ai = Instantiate(greenPre, topPos, transform.rotation) as GameObject;
        }
        else if (16 <= dice && dice < 19)
        {
            //何も産まない
        }
    }

    void MiddleGenerator()
    {
        Vector3 topPos = player.transform.position;
        topPos.x += 15.0f;
        topPos.y = 0.7f;
        int dice = Random.Range(1, 16);
        if (dice == 1)
        {
            GameObject b = Instantiate(onePre, topPos, transform.rotation) as GameObject;
        }
        else if (dice == 2)
        {
            GameObject ba = Instantiate(fivePre, topPos, transform.rotation) as GameObject;
        }
        else if (3 <= dice && dice < 5) 
        {
            GameObject bb = Instantiate(tenPre, topPos, transform.rotation) as GameObject;
        }
        else if (5 <= dice && dice < 7)
        {
            GameObject bc = Instantiate(fivetenPre, topPos, transform.rotation) as GameObject;
        }
        else if (7 <= dice && dice < 9)
        {
            GameObject bd = Instantiate(hyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (9 <= dice && dice < 10)
        {
            GameObject be = Instantiate(fivehyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (10 <= dice && dice < 11)
        {
            GameObject bf = Instantiate(redPre, topPos, transform.rotation) as GameObject;
        }
        else if (11 <= dice && dice < 12)
        {
            GameObject bg = Instantiate(bluePre, topPos, transform.rotation) as GameObject;
        }
        else if (12 <= dice && dice < 13)
        {
            GameObject bh = Instantiate(greenPre, topPos, transform.rotation) as GameObject;
        }        
        else if (13 <= dice && dice < 16)
        {
            //何も産まない
        }
    }

    void UnderGenerator()
    {
        Vector3 topPos = player.transform.position;
        topPos.x += 15.0f;
        topPos.y = 3.9f;
        int dice = Random.Range(1, 21);
        if (1 <= dice && dice < 3)
        {
            GameObject ccc = Instantiate(onePre, topPos, transform.rotation) as GameObject;
        }
        else if (3 <= dice && dice < 6)
        {
            GameObject c = Instantiate(fivePre, topPos, transform.rotation) as GameObject;
        }
        else if (6 <= dice && dice < 9)
        {
            GameObject ca = Instantiate(tenPre, topPos, transform.rotation) as GameObject;
        }
        else if (9 <= dice && dice < 12)
        {
            GameObject cb = Instantiate(fivetenPre, topPos, transform.rotation) as GameObject;
        }
        else if (12 <= dice && dice < 14)
        {
            GameObject cc = Instantiate(hyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (14 <= dice && dice < 15)
        {
            GameObject cd = Instantiate(fivehyakuPre, topPos, transform.rotation) as GameObject;
        }
        else if (15 <= dice && dice < 16)
        {
            GameObject ce = Instantiate(redPre, topPos, transform.rotation) as GameObject;
        }
        else if (16 <= dice && dice < 17)
        {
            GameObject cf = Instantiate(bluePre, topPos, transform.rotation) as GameObject;
        }
        else if (17 <= dice && dice < 18)
        {
            GameObject cg = Instantiate(purplePre, topPos, transform.rotation) as GameObject;
        }
        else if (18 <= dice && dice < 21)
        {
            //何も産まない
        }
    }
}
