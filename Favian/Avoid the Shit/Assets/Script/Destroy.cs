using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Ground" || collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
