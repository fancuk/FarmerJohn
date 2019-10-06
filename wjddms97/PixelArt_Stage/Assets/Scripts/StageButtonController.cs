using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StageButtonController : MonoBehaviour
{
    GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoStage()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if(btnName == "stage1-1")
            SceneManager.LoadScene("1-1Scene");
        else if (btnName == "stage1-2")
            SceneManager.LoadScene("1-2Scene");
        else if (btnName == "stage1-3")
            SceneManager.LoadScene("1-3Scene");


    }
}
