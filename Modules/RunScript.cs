using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    Text flashingText;

    private void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(0.7f);
            flashingText.text = "Touch To Start";
            yield return new WaitForSeconds(0.7f);
        }
    }
}