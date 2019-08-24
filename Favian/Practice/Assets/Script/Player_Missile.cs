using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Missile : MonoBehaviour
{
    public GameObject PlayerMissile;
    public Transform MissileLocation;
    public float MissileSpeed;
    private bool MissileStatus;

    public int MissileMaxPool;
    private MemoryPool Mpool;
    private GameObject[] MissileArray;

    private void OnApplicationQuit()
    {
        Mpool.Dispose();
    }
    void Start()
    {
        MissileStatus = true;
        Mpool = new MemoryPool();
        Mpool.Create(PlayerMissile, MissileMaxPool);
        MissileArray = new GameObject[MissileMaxPool];
    }

    
    void Update()
    {
        PlayerFire();
    }

    private void PlayerFire()
    {
        if (MissileStatus)
        {
            if (Input.GetKey(KeyCode.A))
            {
                StartCoroutine(MissileCycleControl());
                for(int i = 0; i < MissileMaxPool; i++)
                {
                    if (MissileArray[i] == null)
                    {
                        MissileArray[i] = Mpool.newItem();
                        MissileArray[i].transform.position = MissileLocation.transform.position;
                        break;
                    }
                }
            }
        }
        for(int i = 0; i < MissileMaxPool; i++)
        {
            if (MissileArray[i])
            {
                if (MissileArray[i].GetComponent<Collider2D>().enabled == false)
                {
                    MissileArray[i].GetComponent<Collider2D>().enabled = true;
                    Mpool.RemoveItem(MissileArray[i]);
                    MissileArray[i] = null;
                }
            }
        }
    }
    IEnumerator MissileCycleControl()
    {
        MissileStatus = false;
        yield return new WaitForSeconds(MissileSpeed);
        MissileStatus = true;
    }
}
