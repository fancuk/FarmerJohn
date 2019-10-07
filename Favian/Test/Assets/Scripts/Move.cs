using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject[] gameObject;
    private int arraysize;
    private float desiredAngle = 0;
    public Transform target;
    public float speed;
    private string[] forward = new string[5];
    private string[] backward = new string[5];
    private int[] index = new int[5];

    void Start()
    {
        arraysize = 4;
        gameObject = new GameObject[arraysize];
        for (int i = 0; i < 4; i++)
        {
            gameObject[i] = transform.GetChild(i).gameObject;
            index[i] = i;
        }
        #region 앞,뒤
        forward[0] = "1to2";
        forward[1] = "2to3";
        forward[2] = "3to4";
        forward[3] = "4to1";
        backward[0] = "1to4";
        backward[1] = "2to1";
        backward[2] = "3to2";
        backward[3] = "4to3";
        #endregion
    }

    void Update()
    {

    }
    public void leftDown()
    {
        for (int i = 0; i < arraysize; i++)
        {
            /*desiredAngle -= 90;
            if (desiredAngle > 360)
            {
                desiredAngle -= 360;
            }
            if (desiredAngle <= 0)
            {
                desiredAngle += 360;
            }*/
            /*Vector3 vector3 = gameObject[i].transform.position;
            float seta = Mathf.Atan2(vector3.y - target.transform.position.y,
                vector3.x - target.transform.position.x);
            float cosX = (float)Mathf.Cos(seta - Mathf.PI / 2);
            float sinY = (float)Mathf.Sin(seta - Mathf.PI / 2);
            vector3.x = cosX * 2 + target.transform.position.x;
            vector3.y = sinY * 2 + target.transform.position.y;*/
            //gameObject[i].transform.position = new Vector3(isit, vector3.y, 0);
            iTween.MoveTo(gameObject[i], iTween.Hash(
                "path", iTweenPath.GetPath(forward[index[i]]),"time",1f, "easeType", iTween.EaseType.linear));
            index[i]++;
            index[i] %= 4;
        }
    }
    public void rightDown()
    {
        for (int i = 0; i < arraysize; i++)
        {
            /*desiredAngle += 90;
            if (desiredAngle > 360)
            {
                desiredAngle -= 360;
            }
            if (desiredAngle <= 0)
            {
                desiredAngle += 360;
            }*/
            /*Vector3 vector3 = gameObject[i].transform.position;
            float seta = Mathf.Atan2(vector3.y - target.transform.position.y,
                vector3.x - target.transform.position.x);
            float cosX = (float)Mathf.Cos(seta + Mathf.PI / 2);
            float sinY = (float)Mathf.Sin(seta + Mathf.PI / 2);
            vector3.x = cosX * 2 + target.transform.position.x;
            vector3.y = sinY * 2 + target.transform.position.y;*/
            //gameObject[i].transform.position = new Vector3(isit, vector3.y, 0);
            iTween.MoveTo(gameObject[i], iTween.Hash(
                "path", iTweenPath.GetPath(backward[index[i]]), "time", 1f, "easeType", iTween.EaseType.linear));
            index[i] += 3;
            index[i] %= 4;
        }
    }
}
