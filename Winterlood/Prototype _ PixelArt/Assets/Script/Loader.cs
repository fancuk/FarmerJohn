using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Script
{
    class Loader : MonoBehaviour
    {
        public GameObject gameManager;
        private void Awake()
        {
            if(GameManager.instance == null)
            {
                Instantiate(gameManager);
            }
        }
    }
}
