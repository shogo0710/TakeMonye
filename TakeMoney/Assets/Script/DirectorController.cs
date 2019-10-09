using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectorController : MonoBehaviour
{
    GameObject moneycount;
    GameObject came;
    GameObject thisunitytyan;
    GameObject itemgene;
    GameObject bgm;
    int premoney = 0;
    int summoney = 0;
    public float speed = 0.0f;
    int countup = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.moneycount = GameObject.Find("MoneyCount");
        this.came = GameObject.Find("Main Camera");
        this.thisunitytyan = GameObject.Find("Unitytyan");
        this.itemgene = GameObject.Find("ItemGenerator");
        this.bgm = GameObject.Find("BGM");
    }

    // Update is called once per frame
    void Update()
    {
        moneycount.GetComponent<Text>().text =
            this.premoney.ToString() + "yen\nsum：" + this.summoney.ToString() + "yen";
    }

    public void Countemyurator(int a)
    {
        switch (a)
        {
            case 0: premoney += 1 * countup; break;
            case 1: premoney += 5 * countup; break;
            case 2: premoney += 10 * countup; break;
            case 3: premoney += 50 * countup; break;
            case 4: premoney += 100 * countup; break;
            case 5: premoney += 500 * countup; break;
            case 6:if (premoney > 0)
                {
                    premoney -= 100 * countup;
                    if (premoney < 0)
                    {
                        premoney = 0;
                    }
                }
                break;
            case 7: if (premoney > 0)
                {
                    premoney -= 300 * countup;
                    if (premoney < 0)
                    {
                        premoney = 0;
                    }
                }
                    break;
            case 8: if (premoney > 0)
                {
                    premoney -= 500 * countup;
                    if (premoney < 0)
                    {
                        premoney = 0;
                    }
                }
                    break;
            case 9: if (premoney > 0) premoney /= 2 * countup; break;
        }                        
    }

    //UPボタンをクリックすると速度が上がる
    public void SpeedUp()
    {
        if (speed < 10)
        {
            speed += 1.0f;
            countup++;
            Debug.Log(speed);
            this.came.GetComponent<CameraController>().ChangePrespeed(1);
            this.thisunitytyan.GetComponent<MoveUnitytyan>().UpUnitytyanSpeedChange(1);
            this.itemgene.GetComponent<ItemGenerator>().ChangeItemGenerator(1);
            this.bgm.GetComponent<BgmController>().PitchChange(1);
        }       
    }

    //DOWNボタンをクリックすると速度が下がる
    public void SpeedDown()
    {
        if (speed > 0)
        {
            speed -= 1.0f;
            countup--;
            Debug.Log(speed);
            this.came.GetComponent<CameraController>().ChangePrespeed(2);
            this.thisunitytyan.GetComponent<MoveUnitytyan>().UpUnitytyanSpeedChange(2);
            this.itemgene.GetComponent<ItemGenerator>().ChangeItemGenerator(2);
            this.bgm.GetComponent<BgmController>().PitchChange(2);
        }
    }

    //還元ボタンをクリックするとpremoneyだけsummoneyが増え、premoneyが0になる
    public void ChangeSumMoney()
    {
        summoney += premoney;
        premoney = 0;
    }
}
