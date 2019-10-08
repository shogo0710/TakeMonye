using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject undermapPre;
    public GameObject middlemapPre;
    public GameObject topmapPre;
    public GameObject undermap;
    public GameObject middlemap;
    public GameObject topmap;
    int mapcount = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {            
        StartCoroutine(MapGene());                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MapGene()
    {
        while (true)
        {
            Vector3 firstpos = undermap.transform.position;
            Vector3 secondpos = middlemap.transform.position;
            Vector3 tripos = topmap.transform.position;
            mapcount++;
            firstpos.x += 23.04f * mapcount;    //23.04はプレファブの横の長さ
            secondpos.x += 23.04f * mapcount;
            tripos.x += 23.04f * mapcount;
            Debug.Log(firstpos);
            GameObject tuika = Instantiate(undermapPre, firstpos, transform.rotation) as GameObject;
            GameObject tuika2 = Instantiate(middlemapPre, secondpos, transform.rotation) as GameObject;
            GameObject tuika3 = Instantiate(topmapPre, tripos, transform.rotation) as GameObject;
            yield return new WaitForSeconds(3.0f);
        }
    }
}
