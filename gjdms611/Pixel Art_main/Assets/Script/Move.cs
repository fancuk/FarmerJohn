using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void move_object_circle(int num, Gameobject obj)
    {
        Vector3 tmp = obj.transform.position;
        tmp.x = Mathf.Cos(-Time.time + num) * 10;
        tmp.y = Mathf.Sin(-Time.time + num) * 10;
        obj.transform.position = tmp;
    }
    /*
    int num = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        Vector3 tmp = this.transform.position;
        tmp.x = Mathf.Cos(-Time.time + num) * 10;
        tmp.y = Mathf.Sin(-Time.time + num) * 10;
        this.transform.position = tmp;
        //        double x = tmp.x, y = tmp.y;

        //float xMove = Mathf.Cos(Time.time)/4; //x축으로 이동할 양
        //float yMove = Mathf.Sin(Time.time)/4; //y축으로 이동할양
        //this.transform.Translate(new Vector3(xMove, yMove, 0));  //이동
    }*/
}
