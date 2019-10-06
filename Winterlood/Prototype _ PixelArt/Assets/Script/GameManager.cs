using Assets.Script;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
     StageManager stageManager = new StageManager();
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        InitGame();
    }

    private void InitGame()
    {
    }


   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
