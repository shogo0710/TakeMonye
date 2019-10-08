using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject undermapPre;
    public GameObject undermap;
    int mapcount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MapGenerator());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MapGenerator()
    {
        while (true)
        {
            Vector3 firstpos = undermap.transform.position;
            Debug.Log(firstpos);
            mapcount++;
            firstpos.x += 23.04f * mapcount;
            Debug.Log(firstpos);
            GameObject tuika = Instantiate(undermapPre, firstpos, transform.rotation) as GameObject;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
