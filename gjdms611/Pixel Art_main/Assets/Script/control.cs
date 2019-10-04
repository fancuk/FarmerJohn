using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CustomUpdateFunction());
    }

    public IEnumerator CustomUpdateFunction()
    {
        // 공전
        int obj_num = 0;
        string objName = this.gameObject.name;
        Move move = this.gameObject.AddComponent<Move>();
        if (objName == "planet1") obj_num = 1;
        else if (objName == "planet2") obj_num = 2;
        else if (objName == "planet3") obj_num = 3;
        else if (objName == "planet4") obj_num = 4;
        else if (objName == "planet5") obj_num = 5;
        move.move_object_circle(obj_num);

        yield return new WaitForSeconds(Time.deltaTime);
    }
}
