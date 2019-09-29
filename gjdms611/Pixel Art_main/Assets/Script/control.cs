using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class control : MonoBehaviour
{
    int obj_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        Main main = this.gameObject.AddComponent<Main>();
        obj_num = ++main.planet_number;
    }

    // Update is called once per frame
    void Update()
    {
        Move move = this.gameObject.AddComponent<Move>();
        move.move_object_circle(obj_num);
/*        if (Input.GetMouseButtonDown(0))

        {
            SceneManager.LoadScene("선택씬이름");
        }*/
        
    }
}
