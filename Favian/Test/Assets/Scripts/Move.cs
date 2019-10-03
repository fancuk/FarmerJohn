using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Move : MonoBehaviour
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
    private void isBeing()
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
    // Update is called once per frame
    void Update()
    {
        isBeing();
    }
    public void leftDown()
    {
        transform.Translate(-3, 3, 0);
    }
    public void rightDown()
    {
        transform.Translate(3, -3, 0);
    }

}
