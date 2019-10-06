using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class selectPlanet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Select_planet()
    {
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if (btnName == "planet1")
            SceneManager.LoadScene("planet1Scene");
        else if (btnName == "planet2")
            SceneManager.LoadScene("planet1Scene");
        else if (btnName == "planet3")
            SceneManager.LoadScene("planet1Scene");
        else if (btnName == "planet4")
            SceneManager.LoadScene("planet1Scene");
        else if (btnName == "planet5")
            SceneManager.LoadScene("planet1Scene");
    }
}
