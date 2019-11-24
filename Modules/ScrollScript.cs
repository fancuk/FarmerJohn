using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    float scrollSpeed = -3f;
    Vector2 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 26);
        transform.position = startPos + Vector2.right * newPos;
    }
}
