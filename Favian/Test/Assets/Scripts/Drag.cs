using UnityEngine;

public class Drag : MonoBehaviour
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
    void Update()
    {
        isBeing();
        //ScreenCheck();
    }
    /*private void ScreenCheck()
    {
        Vector3 Jola = Camera.main.WorldToViewportPoint(this.transform.position);
        if (Jola.x < 0.05f) Jola.x = 0.05f;
        if (Jola.x > 0.95f) Jola.x = 0.95f;
        this.transform.position = Camera.main.ViewportToWorldPoint(Jola);
    }
    */

}
