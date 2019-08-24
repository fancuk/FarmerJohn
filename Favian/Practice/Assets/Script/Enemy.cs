using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP;
    private Enemy_HP EnemyData;

    void Start()
    {
        EnemyData = new Enemy_HP(HP);
        Debug.Log(gameObject.name + "의 체력 : " + EnemyData.getHP());
    }

    private void Update()
    {
        if (EnemyData.getHP() <= 0)
        {
            Debug.Log("적 파괴!");
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("PlayerMissile"))
        {
            Debug.Log("적 미사일과의 충돌!");
            EnemyData.decreaseHP(10);
            Debug.Log(gameObject.name + "의 현재 체력 : " + EnemyData.getHP());
        }
    }
}
