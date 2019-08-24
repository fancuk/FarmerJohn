using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Missile_Move : MonoBehaviour
{
    public float MissileSpeed;
    public float DestroyMissile;

    void Update()
    {
        transform.Translate(Vector2.up * MissileSpeed * Time.deltaTime);

        if (transform.position.y >= DestroyMissile)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("적 기체와 충돌!");
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
