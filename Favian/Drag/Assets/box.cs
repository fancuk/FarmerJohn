 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    // Start is called before the first frame update
    private float startPosx;
    private float startPosY;
    private bool isBeingHeId = false;

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            startPosx = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeId = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeId = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeId == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition
                = new Vector3(mousePos.x - startPosx, mousePos.y - startPosY, 0);
        }
    }
}
