using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] // 직렬화
    private GameObject poops;
    void Start()
    {
        StartCoroutine(CreatePoopRoutine());
    }

    void Update()
    {
        
    }

    IEnumerator CreatePoopRoutine()
    {
        while (true)
        {
            CreatePoop();
            yield return new WaitForSeconds(1);
        }
    }
    private void CreatePoop()
    {
        Vector3 pos = new Vector3(0, 10, 0);
        Instantiate(poops, pos, Quaternion.identity); //quaternion.identity 회전 x
    }
}
