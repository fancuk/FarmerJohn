using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using LitJson;

public class Item
{
    public double seconds = 0;
    public int hours = 9;
    public int min = 0;
    public string apm = "AM";
    public bool apmcheck = true;
    public void check(Text textbox)
    {
        if (seconds >= 60)
        {
            min++;
            seconds = 0;
        }
        if (min >= 60)
        {
            if (hours == 11)
            {
                if (apm == "AM")
                {
                    apm = "PM";
                }
                else
                {
                    apm = "AM";
                }
            }
            hours++;
            min = 0;
        }
        if (hours > 12)
        {
            hours -= 12;
        }
        string temphours = hours.ToString();
        string tempmin = min.ToString();
        if (temphours.Length == 1)
        {
            temphours = "0" + temphours;
        }
        if (tempmin.Length == 1)
        {
            tempmin = "0" + tempmin;
        }
        string time =
            temphours + " : " + tempmin + " " + apm;
        textbox.text = time;
    }
}

public class TimeCount : MonoBehaviour
{
    public Item IT = new Item();
    public Text textbox;

    void Start()
    {
        Load();
        string time =
            "0" + IT.ToString() + " : " + "0" + IT.ToString() + IT.apm;
        textbox.text = time;
    }

    // Update is called once per frame
    void Update()
    {
        IT.seconds += Time.deltaTime * 6;
        IT.check(textbox);
    }

    private void OnApplicationQuit()
    {
        Debug.Log("종료");
        JsonData timeJson = JsonMapper.ToJson(IT);
        File.WriteAllText(Application.dataPath
            + "/Resources/ItemData.json"
            , timeJson.ToString());
    }

    public void Load()
    {
        string Jsonstring = File.ReadAllText(
            Application.dataPath +
            "/Resources/ItemData.json");

        JsonData itemData = JsonMapper.ToObject(Jsonstring);
        Debug.Log("로드");
        IT.seconds = (double)itemData["seconds"];
        IT.hours = (int)itemData["hours"];
        IT.min = (int)itemData["min"];
        IT.apm = itemData["apm"].ToString();
        IT.apmcheck = (bool)itemData["apmcheck"];
    }
}
