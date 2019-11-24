using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
        startFading();
    }

    IEnumerator Fadein()
    {
        for(float f = 0.05f; f<=1; f += 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            Debug.Log(f + "\n");
            yield return new WaitForSeconds(0.05f);
        }
    }
    public void startFading()
    {
        StartCoroutine("Fadein");
    }
}
