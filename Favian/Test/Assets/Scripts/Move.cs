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

    void Start()
    {
        arraysize = 4;
        gameObject = new GameObject[arraysize];
        for (int i = 0; i < 4; i++)
        {
            gameObject[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {

    }
    public void leftDown()
    {
        for (int i = 0; i < arraysize; i++)
        {
            desiredAngle -= 90;
            if (desiredAngle > 360)
            {
                desiredAngle -= 360;
            }
            if (desiredAngle <= 0)
            {
                desiredAngle += 360;
            }
            Vector3 damin = new Vector3(0, 0, 90);
            /*transform.localRotation =
                Quaternion.Euler(new Vector3(0, 0, desiredAngle));*/
            gameObject[i].transform.RotateAround(target.position, damin, speed);
            Debug.Log(i + "는 " + desiredAngle + "도 돌았습니다.\n");
        }
    }
    public void rightDown()
    {
        for (int i = 0; i < arraysize; i++)
        {
            desiredAngle += 90;
            if (desiredAngle > 360)
            {
                desiredAngle -= 360;
            }
            if (desiredAngle <= 0)
            {
                desiredAngle += 360;
            }
            Vector3 damin = new Vector3(0, 0, -90);
            /*transform.localRotation =
                Quaternion.Euler(new Vector3(0, 0, desiredAngle));*/
            gameObject[i].transform.RotateAround(target.position, damin, speed);
            Debug.Log(i + "는 " + desiredAngle + "도 돌았습니다.\n");
        }
    }
}
