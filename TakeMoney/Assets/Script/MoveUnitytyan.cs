using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnitytyan : MonoBehaviour
{
    GameObject director;
    float unitytyanspeed = 7.66f;
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("Director");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(unitytyanspeed * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0.0f, -2.99f, 0.0f);
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0.0f, 2.99f, 0.0f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ONE")       
            this.director.GetComponent<DirectorController>().Countemyurator(0);
        else if(other.gameObject.tag == "FIVE")        
            this.director.GetComponent<DirectorController>().Countemyurator(1);        
        else if (other.gameObject.tag == "TEN")
            this.director.GetComponent<DirectorController>().Countemyurator(2);
        else if (other.gameObject.tag == "FIVE_TEN")
            this.director.GetComponent<DirectorController>().Countemyurator(3);
        else if (other.gameObject.tag == "HYAKU")
            this.director.GetComponent<DirectorController>().Countemyurator(4);
        else if (other.gameObject.tag == "FIVE_HYAKU")
            this.director.GetComponent<DirectorController>().Countemyurator(5);
        else if (other.gameObject.tag == "RED")
            this.director.GetComponent<DirectorController>().Countemyurator(6);
        else if (other.gameObject.tag == "BLUE")
            this.director.GetComponent<DirectorController>().Countemyurator(7);
        else if (other.gameObject.tag == "PURPLE")
            this.director.GetComponent<DirectorController>().Countemyurator(8);
        else if (other.gameObject.tag == "GREEN")
            this.director.GetComponent<DirectorController>().Countemyurator(9);                
    }

    public void UpUnitytyanspeed()
    {
        unitytyanspeed += 1.0f;
    }
}
