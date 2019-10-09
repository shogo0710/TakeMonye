using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnitytyan : MonoBehaviour
{
    GameObject director;
    public AudioClip sound;
    public AudioClip sound1;
    AudioSource audioSource;
    float unitytyanspeed = 7.66f;
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("Director");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(unitytyanspeed * Time.deltaTime, 0, 0);       
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "ONE")
            this.director.GetComponent<DirectorController>().Countemyurator(0);
        else if (other.gameObject.tag == "FIVE")
            this.director.GetComponent<DirectorController>().Countemyurator(1);
        else if (other.gameObject.tag == "TEN")
            this.director.GetComponent<DirectorController>().Countemyurator(2);
        else if (other.gameObject.tag == "FIVE_TEN")
            this.director.GetComponent<DirectorController>().Countemyurator(3);
        else if (other.gameObject.tag == "HYAKU")
        {
            this.director.GetComponent<DirectorController>().Countemyurator(4);
            this.audioSource.PlayOneShot(sound);
        }
        else if (other.gameObject.tag == "FIVE_HYAKU")
        {
            this.director.GetComponent<DirectorController>().Countemyurator(5);
            this.audioSource.PlayOneShot(sound);
        }
        else if (other.gameObject.tag == "RED")
            this.director.GetComponent<DirectorController>().Countemyurator(6);
        else if (other.gameObject.tag == "BLUE")
            this.director.GetComponent<DirectorController>().Countemyurator(7);
        else if (other.gameObject.tag == "PURPLE")
        {
            this.director.GetComponent<DirectorController>().Countemyurator(8);
            this.audioSource.PlayOneShot(sound1);
        }
        else if (other.gameObject.tag == "GREEN")
        {
            this.director.GetComponent<DirectorController>().Countemyurator(9);
            this.audioSource.PlayOneShot(sound1);
        }
    }

    public void UpUnitytyanSpeedChange(int a)
    {
        if (a == 1)
        {
            unitytyanspeed += 1.0f;
        }else if (a == 2)
        {
            unitytyanspeed -= 1.0f;
        }
        
    }

    public void UnitytyanUp()
    {
        if (transform.position.y < 3.0f)
        {
            transform.Translate(0.0f, 2.99f, 0.0f);
        }
        
    }

    public void UnitytyanDown()
    {
        if (transform.position.y > -2.0f)
        {
            transform.Translate(0.0f, -2.99f, 0.0f);
        }        
    }
}
