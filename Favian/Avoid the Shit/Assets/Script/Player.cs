using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    public float speed = 3f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        ScreenCheck();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    private void ScreenCheck()
    {
        Vector3 Jola = Camera.main.WorldToViewportPoint(this.transform.position);
        if (Jola.x < 0.05f) Jola.x = 0.05f;
        if (Jola.x > 0.95f) Jola.x = 0.95f;
        this.transform.position = Camera.main.ViewportToWorldPoint(Jola);
    }
}
