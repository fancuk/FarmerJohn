using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_HP : MonoBehaviour
{
    private int HP;

    public Enemy_HP(int _HP)
    {
        HP = _HP;
    }

    public void decreaseHP(int damage)
    {
        HP -= damage;
    }
    
    public int getHP()
    {
        return HP;
    }
}
