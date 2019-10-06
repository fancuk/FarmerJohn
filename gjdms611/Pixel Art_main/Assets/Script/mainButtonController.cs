using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class mainButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if (btnName == "StartButton")
        {
            SceneManager.LoadScene("SelectScene");
        }
        else if(btnName == "creditButton")
        {
            SceneManager.LoadScene("CreditScene");
        }
        else if (btnName == "Yes_Button")
        {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
                Application.OpenURL("http://google.com");
#else
            Application.Quit();
#endif
        }
    }
}
