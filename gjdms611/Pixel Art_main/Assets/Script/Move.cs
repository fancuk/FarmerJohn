using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int scale = 330, x=550, y=1300;
    void Start()
    {
        
    }

    void Update() {

    }
    public void move_object_circle(int num)
    {
        Vector3 tmp = this.transform.position;
        tmp.x = (float)Mathf.Cos(-Time.time + (float)6.2 / (float)5 * (float)num) * scale + (float)x;
        tmp.y = (float)Mathf.Sin(-Time.time + (float)6.2 / (float)5 * (float)num) * scale + (float)y;
        this.transform.position = tmp;
    }
}
